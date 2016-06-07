import MySQLdb
conn = MySQLdb.connect(host = "athena01.fhict.local",
                       user = "dbi345959",
                       passwd = "2XArGTUPc9",
                       db = "dbi345959")
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
        c.execute("UPDATE USER SET money = money + ('%s'), total_money = total_money + ('%s') WHERE QR_CODE = ('%s')" % (SLog[1], SLog[1], SLog[0]))
		
conn.commit()        
conn.close()