﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	
		<meta charset="utf-8">
		<meta http-equiv="X-UA-Compatible" content="IE=edge">
		<meta name="viewport" content="width=device-width, initial-scale=1">
        <!-- jquery & Bootstrap js -->
		<script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js"></script>
		<script src="js/bootstrap.min.js"></script>
        <script src="https://ajax.googleapis.com/ajax/libs/jqueryui/1.11.3/jquery-ui.min.js"></script>
		<!-- End Of jquery & Bootstrap js -->
        <meta name="keywords" content="keywords">
        <meta name="description" content="Providing reliable, timely and informative
advanced laboratory services
of supreme quality to our
clients and patients">
        <link rel="stylesheet" type="text/css" href="css/defult.css">
        <link rel="stylesheet" type="text/css" href="css/slider.css">
        <link rel="icon" type="image/png" href="img/favicon.png">
		<title id="pagetitle" runat="server">First Lab</title>
		<link href="css/bootstrap.min.css" rel="stylesheet">
		<!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
		<!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
		<!--[if lt IE 9]>
			<script src="https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js"></script>
			<script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
		<![endif]-->
	
   
</head>
<body onload="slider();">
            <div class=" nav-row" >
                <img src="img/logo.png">
                <div class="left-nav">
                    <h1>First Lab Clinical Laboratory</h1>
                    <div class="nav-div">
                        <ul>
                            <li><a href="#first-slide">home</a></li>
                            <li><a href="#">about</a></li>
                            <li><a href="#">find us</a></li>
                            <li><a href="#">contact</a></li>
                        </ul>
                    </div>
                </div>
            </div>
        <div class="row first-slide" id="first-slide">
            <div class="login">
                <div class="login-nav">
                    <ul>
                        <li><a href="#">عربي</a></li>
                        <li><a href="#" class="login1-btn">log in</a></li>
                        <li><a href="#" class="login2-btn">log in 2</a></li>
                    </ul>
                </div>
                <div class="login1">
                    First name: <input type="text" name="fname"><br>
                    Last name: <input type="text" name="lname"><br></div>
                <div class="login2">log in 2</div>
            </div>
            <div class="social" ><a href="http://www.facebook.com" target="_blank"><img src="img/facebook.png" alt="follow us on facebook"></a></div>
            <div class="row gallery no-gutter">
            <div id="" class="slider col-lg-8 col-lg-offset-2 col-md-8 col-md-offset-2 col-sm-12 col-xs-12 ">
                    <div id="1"><p id="gp1" runat="server">First Lab Clinical Laboratory</p><img  src="gallery/img1.jpg"></div>
                    <div id="2"><p id="gP2" runat="server">First Lab Clinical Laboratory</p><img src="gallery/img2.jpg"></div>
                    <div id="3"><p id="gP3" runat="server">First Lab Clinical Laboratory</p><img src="gallery/img3.jpg"></div>
                    <div id="4"><p id="gP4" runat="server">First Lab Clinical Laboratory</p><img src="gallery/img4.jpg"></div>
                </div>   
            </div>
            <div class="row nav-gallery">
                <div class=" col-lg-8 col-lg-offset-2 col-md-8 col-md-offset-2 col-sm-12 col-xs-12">
                    <div class="nav-gallery-btn">
                        <a href="#" onclick="prev(); return false;"><img src="gallery/pre.png"></a>
                        <a href="#" onclick="next(); return false;"><img src="gallery/next.png"></a>
                    </div>
                </div>
            </div>
            <div class="two-btns">
                <a href="#second-slide">
                    <img src="img/test%20result.png">
                </a>
                <a href="#third-slide">
                    <img src="img/book%20a%20date.png">
                </a>
            </div>
        </div>
        
        
        <div class="row second-slide" id="second-slide">
   <!--منطقة تحت الهيدر فى السلايد الاولى-->
            <div class="second-slide-content" id ="slid2" runat="server">
test 13
            </div>
            
            
            <a href="#first-slide" class="top-btn"><img src="img/top.png" class="top-img"></a>
        </div>
        
        
        <div class="row third-slide" id="third-slide">
   <!--منطقة تحت الهيدر فى السلايد الثانية-->
            <div class="third-slide-content" id ="sl3" runat="server">
       test 14
            </div>

            
            <a href="#first-slide" class="top-btn"><img src="img/top.png" class="top-img"></a>
        </div>
test 15            
        <div class="row footer">
            
        
              
            <div class="row copy"> 
                <p>&copy; Copy Right to First Lab</br>
                Powerd & Designed By<a href="#"> SnowSpark</a></p>
            </div>
        </div> 

        <script src="js/gallery.js" ></script>
        
        <!-- log in jquery -->
        <!-- log in jquery -->
        <!-- log in jquery -->
        <script>
            $(document).ready(function () {
                $(".login1-btn").click(function () {
                    if ($(".login2").css("display") == "block") {
                        $(".login2").slideUp(600);
                        $(".login1").delay(600).slideToggle(600);
                    } else {
                        $(".login1").slideToggle("slow");
                    };
                });
                $(".login2-btn").click(function () {
                    if ($(".login1").css("display") == "block") {
                        $(".login1").slideUp(600);
                        $(".login2").delay(600).slideToggle(600);
                    } else {
                        $(".login2").slideToggle("slow");
                    };
                });
                $(".login").mouseleave(function () {
                    if ($(".login1").css("display") == "block") {
                        $(".login1").slideUp(600);
                    };
                    if ($(".login2").css("display") == "block") {
                        $(".login2").slideUp(600);
                    };
                });
            });
        </script>
        <!-- end log in jquery -->
        <!-- end log in jquery -->
        <!-- end log in jquery -->

        
        
        
        <!-- sliding navigation jquery -->
        <!-- sliding navigation jquery -->
        <!-- sliding navigation jquery -->
        <script type="text/javascript" src="js/skrollr.js"></script>
        <script> 
            $(document).ready(function() {
                $('a[href*=#]').each(function() {
                    if (location.pathname.replace(/^\//,'') == this.pathname.replace(/^\//,'')
                        && location.hostname == this.hostname
                        && this.hash.replace(/#/,'') ) {
                        var $targetId = $(this.hash), $targetAnchor = $('[name=' + this.hash.slice(1) +']');
                        var $target = $targetId.length ? $targetId : $targetAnchor.length ? $targetAnchor : false;
                        
                        if ($target) {
                            var targetOffset = $target.offset().top;
                            <!----- JQUERY CLICK FUNCTION REMOVE AND ADD CLASS "ACTIVE" + SCROLL TO THE #DIV--->   
                            $(this).click(function() {
                            $("#nav li a").removeClass("active");
                            $(this).addClass('active');
                            $('html, body').animate({scrollTop: targetOffset}, 1000);
                            return false;
                            });
                        }
                    }
                });
            }); 
        </script>
        <!-- end sliding navigation jquery -->
        <!-- end sliding navigation jquery -->
        <!-- end sliding navigation jquery -->
        
        
        
        
        
        <!-- div animation jquery -->
        <!-- div animation jquery -->
        <!-- div animation jquery -->
        <script src="js/animation.js" ></script>
        <!-- end div animation jquery -->
        <!-- end div animation jquery -->
        <!-- end div animation jquery -->
        
        
        
	
    <form id="form1" runat="server">
    <div>
    
    </div>
    </form>
</body>
</html>
