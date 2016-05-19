import MySQLdb
conn = MySQLdb.connect(host = "",
                       user = "",
                       passwd = "",
                       db = "")
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
        c.execute("INSERT INTO TRANSACTIONS(DEPOSIT_ID, AMOUNT) VALUES ('%s', '%s')" % (SLog[0], SLog[1]))

conn.commit()        
conn.close()