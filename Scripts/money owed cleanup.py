import MySQLdb
conn = MySQLdb.connect(host = "athena01.fhict.local",
                       user = "dbi345959",
                       passwd = "2XArGTUPc9",
                       db = "dbi345959")
c = conn.cursor()

c.execute("SELECT `qr_code`, `money`, `money_owed` FROM `user` WHERE `money`>0 AND `money_owed`>0")
results = c.fetchall()
q="UPDATE user SET money=%s, money_owed = %s WHERE qr_code = ('%s')"
for row in results:
	qr = row[0]
	moni = row[1]
	gibmoni = row[2]
	if moni > gibmoni:
		moni, gibmoni = moni-gibmoni, 0
		c.execute(q % (moni, gibmoni, qr))
		conn.commit()
	elif gibmoni > moni:
		moni, gibmoni = 0, gibmoni-moni
		c.execute(q % (moni, gibmoni, qr))
		conn.commit()
	elif gibmoni == moni:
		moni, gibmoni = 0, 0
		c.execute(q % (moni, gibmoni, qr))
		conn.commit()

conn.close()