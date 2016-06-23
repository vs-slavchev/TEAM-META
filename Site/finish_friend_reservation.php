<HTML>
<HEAD>
<TITLE>Event Info</TITLE>

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
      <form method="post" action="./php/finish_friend_registration.php">
        <fieldset>
          <legend><font color="white">Register:</font></legend>
					<ul style="padding:5px;">
						<li style="padding:3px;">
            <input type="email" name="email" placeholder="Email Address">
						</li><li style="padding:3px;">
            <input type="text" name="first_name" placeholder="First name">
						</li><li style="padding:3px;">
            <input type="text" name="last_name" placeholder="Last name">
						</li><li style="padding:3px;">
            <input type="text" name="paypal" placeholder="PayPal account">
						</li><li style="padding:3px;">
            <input type="text" name="phone_number" placeholder="Phone number">
						</li>
					</ul>
					<button type="submit">Submit</button>
        </fieldset>
      </form>
    </div>
    <div class="info-list">
        TICKETS:<br>
    The entrance price for the festival is 55 euro. After the reservation you will get an unique identity number by e-mail and you will be asked to deposit <b>20 euro</b> in to the bank account of the event. At the
entrance of the event you will be checked quickly if you are allowed to enter the event. If you did not pay at all or enough, you will have to pay. The penalty fee for not paying on time is 10
euro.<br>During the event it is not possible to pay in cash: only by event-account trough your QR code.<br><br>
        CAMPING:<BR>
        You can book a camping spot by choosing a free spot
on the map of the camping. Every spot can be booked for at most 6 people. To make a reservation for a camping spot
you have to specify all participants and choose which one of them will get the bill and be responsible for the organization of your group. You can only make a reservation for
the whole weekend; not for a single day. Reservation for a camping spot is 30 euro plus 20 euro for every guest.<br><br>
    </div>
        <p class="home-pt3-title">Map</p>
        <div>
        <img src="pics/1030_groot.png" width="100%">
        </div>
	<!-- map to build using google dev API, can't with just iframe without API key-->
</div>
    </div>
</BODY>
</HTML>
