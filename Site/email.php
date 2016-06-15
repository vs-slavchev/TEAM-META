
<HTML>
<HEAD>
<TITLE>Reservations</TITLE>

<LINK REL="stylesheet" HREF="css\base.css" TYPE="text/css" charset="utf-8">
<LINK REL="stylesheet" HREF="css\txtformat.css" TYPE="text/css" charset="utf-8">
<LINK REL="stylesheet" HREF="css\homebody.css" TYPE="text/css" charset="utf-8">

<script src="./js/jquery-2.2.1.js" type="text/javascript" charset="utf-8"></script>
<script src="./js/jquery.easing.1.3.js" type="text/javascript" charset="utf-8"></script>
</HEAD>
<BODY>
<div class="toolbar-container">
	<div class="toolbar">
		<div class="logo-container">
			<a href="index.html">
				<img src="pics/logo_front.png" class="logo">
			</a>
		</div>
		<div class="toolbar-nav">
			<ul class="nav-list">
				<li class="nav-item">
					<p class="nav-btn">
						<a href="index.html">Home</a>
					</p>
				</li>
				<li class="nav-item">
					<p class="nav-btn">
						<a href="reservation.php">Reservation</a>
					</p>
				</li>
				<li class="nav-item">
					<p class="nav-btn">
						<a href="contact.html">Contact</a>
					</p>
				</li>
			</ul>
		</div>
	</div>
</div>
<div class="body">
    <div class="bgc">
	<p class="home-pt3-title">Reservation</p>
	<div style="width:150px; margin-left:42%">
      <form method="post" action="./php/friend_emails.php">
        <fieldset>
          <legend><font color="white">E-mails:</font></legend>
					<ul style="padding:5px;">
						<li style="padding:3px;">
            <input type="email" name="email1" placeholder="Email Address 1"></li>
						<li style="padding:3px;">
            <input type="email" name="email2" placeholder="Email Address 2"></li>
						<li style="padding:3px;">
            <input type="email" name="email3" placeholder="Email Address 3"></li>
						<li style="padding:3px;">
            <input type="email" name="email4" placeholder="Email Address 4"></li>
						<li style="padding:3px;">
            <input type="email" name="email5" placeholder="Email Address 5"></li>
					</ul>
          <button type="submit">Submit</button>
        </fieldset>
      </form>
    </div>
    <div class="info-list">
        Here you can enter the emails of friends you would like to go to the event with. They
				will receive an email informing them of your invite and the offer. If they register
				through your invite they can easily choose to be in your camp spot. A QR code will
				be automatically assigned to them, so they can register online with their email
				address or use the QR code they received to register on the entrance of the event.<br><br><br><br>
		</div>
</div>
    </div>
</BODY>
</HTML>
