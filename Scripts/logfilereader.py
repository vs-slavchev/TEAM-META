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
		qr_code = SLog[0]
		## kakuv data type sa parite tuka? iskam ama moga li da gi subiram kato int?
		money_to_add = int(SLog[1])
		money_previously, money_owed, money_current = 0, 0, 0
	
		c.execute("SELECT `money`, `money_owed` FROM `user` WHERE `qr_code` = ('%s')" % (qr_code))
		results = c.fetchall()

		for row in results:
			money_previously = row[0] ## money before the deposit
			money_owed = row[1]
			money_current = money_previously + money_to_add
			if money_current >= money_owed:
				money_current, money_owed = money_current - money_owed, 0
			else:
				money_current, money_owed = 0, money_owed - money_current

			## kak se pi6e na nekolko reda bez da s4upa placeholderite? a tova query pre4i li si s gornoto?
			c.execute("UPDATE USER SET money = ('%s'), total_money = total_money + ('%s'), money_owed = ('%s') WHERE QR_CODE = ('%s')" % (money_current, money_to_add, money_owed, qr_code))
			conn.commit()

conn.close()
