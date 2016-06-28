![logo](https://raw.githubusercontent.com/vs-slavchev/TEAM-META/master/logo.png)

Software for event management. The solution consists of:

	- website for registering visitors, choosing a camp spot and inviting friends;
	- applications to be used by staff at: event entrance, camp entrance, shops, stands to loan materials, event exit,
	  event status monitoring;
	- android application that reads QR codes and utilizes the phone as a QR reader connected with the applications for
	  fast service;
	- a script that receives Paypal logfiles about the payments and updates visitors' balance in their event account;
	- prepared mysql database schema;


The 'Site' folder contains the website with: css, fonts, pictures and the php backend. Pages contain:

	- information about the event;
	- registration form and a way to book a camp spot;
	- friend invitation form. Invited people receive an email and are able to be put in the same camp their friends
	  have chosen;
	- twitter feed about the event;

The 'EventApplications' folder contains the C# solution with the 6 applications. Open with Visual Studio 2013 and 2015.
Each application is in a separate project.

	- event entrance: check if a visitor is allowed to enter and whether all fees are collected;
	- camp entrance: chech status and help visitors find their camp;
	- shops: buy food and drinks with their event account money by just showing the QR code;
	- stands to loan materials: loan chargers, laptops or other equipment for the duration of the event;
	- event exit: check if user has returned all loaned items and mark their leaving;
	- event status monitoring: overall statistics about the whole event or a particular visitor;

The 'Scripts' folder contains the Paypal logfile parsing script, an example logfile and the DB schema.
To run the python script you will need to install MySQLDB driver with pip.

The 'QRreaderApp' folder contains the android app for reading QR codes. Developed with Android Studio. To start it up:

	1. Enable USB Debugging on your phone in the development settings.
	2. Connect your phone and your PC with the cable.
	3. Run the app from Android Studio.
	4. On start up choose a device id. This id will be required by the PC apps to retrieve the scanned QR code.


Finally, the 'Documents' folder contains all of the documentation about the project:

	- diagrams and charts;
	- GUI design and wireframes;
	- agendas and minutes regularly tracking our progress on detailed tasks;
	- process report describing our research, planning, acompished tasks and achievements, problems and the situation
	  for each week;
	- setup document reflecting our initial approach and planning according the problem description and requirements;
	- project plan describing our view on the risks, constraints and expected deliverables;
