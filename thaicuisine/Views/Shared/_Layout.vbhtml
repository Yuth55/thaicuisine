<!DOCTYPE html>
<!--[if lt IE 7]>      <html class="no-js lt-ie9 lt-ie8 lt-ie7"> <![endif]-->
<!--[if IE 7]>         <html class="no-js lt-ie9 lt-ie8"> <![endif]-->
<!--[if IE 8]>         <html class="no-js lt-ie9"> <![endif]-->
<!--[if gt IE 8]><!-->
<html class="no-js">
 <!--<![endif]-->
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <title>Thai Cuisine</title>
    <meta name="description" content="">
    <meta name="viewport" content="width=device-width, initial-scale=1.0, user-scalable=no, minimum-scale=1.0, maximum-scale=1.0" />
    <!-- Place favicon.ico and apple-touch-icon.png in the root directory -->

</head>
<body>

    <link rel="stylesheet" href="~/less/custom.css">
    <link href='http://fonts.googleapis.com/css?family=Open+Sans:400,300,600&amp;subset=latin,latin-ext' rel='stylesheet' type='text/css'>
    <link href='http://fonts.googleapis.com/css?family=Covered+By+Your+Grace' rel='stylesheet' type='text/css'>
    <link rel="stylesheet" href="~/less/jquery.maximage.css" type="text/css" media="screen" charset="utf-8" />
    <script src="~/js/jquery-2.0.3.min.js"></script>
    <script src="~/js/modernizr-2.6.2.min.js"></script>
    <div class="container full-bg visible-xs sm-navbar">
        <nav>
            <div class="row">
                <div class="navbar-inner">
                    <ul class="main-menu nav">
                        <li>
                            <header class="small-logo">

                                <a href="~/Views/Home" title=""><img src="~/img/logo.png" alt="Thai Cuisine" /></a>
                            </header>
                        </li>
                        <li class="reorder">
                            <a href="#" title="" class="exclude" data-djax-exclude="true"><i class="fa fa-reorder"></i></a>
                        </li>
                    </ul>
                </div>
            </div>
        </nav>
    </div>
    <div id="mobile-nav" class="visible-xs">
        <div class="" id="flyout-container">
            <ul id="menu-mobile" class="nav flyout-menu">
                <li class="menu-item-has-children menu-item">
                    <a title="" href="restaurant.html">Restaurant</a>
                    <span class="open-children"><i class="fa fa-angle-down"></i></span>
                    <ul class="subnav">
                        <li><a href="blog.html" title=""><span>Blog</span></a></li>
                        <li><a href="team.html" title=""><span>Team</span></a></li>
                    </ul>
                </li>
                <li class="menu-item-has-children menu-item">
                    <a title="" href="menu.html">Menu</a>
                    <span class="open-children"><i class="fa fa-angle-down"></i></span>
                    <ul class="subnav">
                        <li><a href="menu.html" title=""><span>Menu 1</span></a></li>
                        <li><a href="menu2.html" title=""><span>Menu 2</span></a></li>
                        <li><a href="menu3.html" title=""><span>Menu 3</span></a></li>
                    </ul>
                </li>
                @*<li class="menu-item">
                        <a title="" href="reservation.html">Reservation</a>
                    </li>*@
                <li class="menu-item">
                    <a title="" href="contact.html">Contact</a>
                </li>
            </ul>
        </div>
    </div>
    <div class="navbar hidden-xs">
        <div class="container">
            <div class="row">
                <nav class="col-md-12 clearfix">
                    <ul class="main-nav white-nav dotted-separator">
                        <li>
                            <div>
                                <a href="restaurant.html" class="content-link restaurant-wrapper"><span>Restaurant</span> <img src="~/img/icon1.png" alt="" /></a>
                            </div>
                        </li>
                        <li>
                            <div>
                                <a href="menu.html" class="content-link menu-wrapper menu-item-has-children"><span>Menu</span> <img src="~/img/icon2.png" alt="" /></a>
                                <ul class="subnav">
                                    <li><a href="menu.html" title=""><span>menu 1</span></a></li>
                                    <li><a href="menu2.html" title=""><span>menu 2</span></a></li>
                                    <li><a href="menu3.html" title=""><span>menu 3</span></a></li>
                                </ul>
                            </div>
                        </li>
                        <li class="menu-image">
                            <div>
                                <a class="content-link" title="logo" href="~/Views/Home"><img src="~/img/logo.png" alt="Thai Cuisine"></a>
                            </div>
                        </li>
                        <li>
                            <div>
                                <a href="reservation.html" class="content-link reservation-wrapper"><span>Reservation</span> <img src="~/img/icon3.png" alt="" /></a>
                            </div>
                        </li>
                        <li>
                            <div>
                                <a href="contact.html" class="content-link contact-wrapper"><span>Contact </span><img src="~/img/icon4.png" alt="" /></a>
                            </div>
                        </li>
                    </ul>
                </nav>
            </div>
        </div>
    </div>




    <div >
        @*class="container body-content"*@
        @RenderBody()
    </div>
    <script src="~/js/jquery.djax.min.js"></script>
    <script src="~/js/jquery.nicescroll.min.js"></script>
    <script src="~/js/jquery.ba-throttle-debounce.min.js"></script>
    <script src="~/js/transit.js"></script>
    <script src="~/js/jquery.cycle.all.min.js"></script>
    <script src="~/js/jquery.maximage.min.js"></script>
    <script src="~/js/jquery.colorbox-min.js"></script>
    <script src="~/js/owl.carousel.min.js"></script>
    <script src="~/js/main.js"></script>
</body>
</html>






