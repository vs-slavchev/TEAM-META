import MySQLdb
from connection_data import *
conn = MySQLdb.connect(host, user, passwd, db)
c = conn.cursor()

from tkinter import *
from tkinter.filedialog import askopenfilename
root = Tk()
root.withdraw()

root.filename = askopenfilename(filetypes=((".txt files", ".txt"), ("All files", ".*")))
with open(root.filename, "r") as f:
	for i in range(4): f.readline()
	for line in f:
		SLog = line.split()
		email = SLog[0]
		
		money_to_add = int(SLog[1])
		money_previously, money_owed, money_current = 0, 0, 0
	
		c.execute("SELECT `money`, `money_owed` FROM `user` WHERE `email` = ('%s')" % (email))
		results = c.fetchall()

		for row in results:
			money_previously = row[0] ## money before the deposit
			money_owed = row[1]
			money_current = money_previously + money_to_add
			if money_current >= money_owed:
				money_current, money_owed = money_current - money_owed, 0
			else:
				money_current, money_owed = 0, money_owed - money_current

			c.execute("UPDATE USER SET money = ('%s'), total_money = total_money + ('%s'), money_owed = ('%s') WHERE email = ('%s')" % (money_current, money_to_add, money_owed, email))
			conn.commit()

conn.close()
