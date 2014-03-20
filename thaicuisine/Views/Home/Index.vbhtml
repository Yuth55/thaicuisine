﻿@Code
    ViewData("Title") = "Home Page"
End Code


<div id="content-wrapper">
    <div class="dynamic-content container" id="main-content">
        <div class="social-share top">
            <ul>
                <li>
                    <a href="https://www.facebook.com/pages/Thai-Cuisine-Restaurant/115893918454924"><i class="fa fa-facebook"></i></a>
                </li>
                @*<li>
                    <a href="https://twitter.com"><i class="fa fa-twitter"></i></a>
                </li>*@
                <li>
                    <a href="https://plus.google.com/101341997345008565100/about"><i class="fa fa-google-plus"></i></a>
                </li>
                @*<li>
                    <a href="https://pinterest.com"><i class="fa fa-pinterest"></i></a>
                </li>
                <li>
                    <a href="https://linkedin.com"><i class="fa fa-linkedin"></i></a>
                </li>*@
            </ul>
        </div>
        @*<div class="arrow-nav hidden-sm hidden-md hidden-lg">
            <a href="restaurant.html">
                <i class="fa fa-share"></i>
            </a>
        </div>*@
        <div id="maximage">
            <div>
                <img src="~/img/pad-thai-shrimp.jpeg" class="current-slide" alt="" data-href=".slide1" />
            </div>

            <div>
                <img src="~/img/curryminor.jpg" alt="" data-href=".slide2" />
            </div>
            <div>
                <img src="~/img/duckcurry.JPG" alt="" data-href=" .slide3" />
            </div>
            <div>
                <img src="~/img/masacurry.jpg" alt="" data-href=" .slide4" />
            </div>
            <div>
                <img src="~/img/masamum2.jpg" alt="" data-href=".slide5" />
            </div>
            <div>
                <img src="~/img/red-curry-with-chicken.jpg" alt="" data-href=".slide6" />
            </div>
            <div>
                <img src="~/img/soft-shell-crab-and-smoked-trout-003.jpg" alt="" data-href=".slide7" />
            </div>
            <div>
                <img src="~/img/thai-pork-satay-bangkok.jpg" alt="" data-href=".slide8" />
            </div>
        </div>
    </div>
</div>
