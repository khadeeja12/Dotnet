<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LoginForm._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content=
        "width=device-width, initial-scale=1.0">
    <title>Landing Page</title>
</head>

<body>
    <style>
        * {
    padding: 0;
    margin: 0;
    box-sizing: border-box;
}

body {
    background-color: white;
    color: black;
    font-family: "Fira Sans", sans-serif;
    background-color: white;
}

nav {
    width: 100%;
    height: 80px;
    display: flex;
    justify-content: space-between;
    padding: 20px 5%;
    background-color: #8cc099;
}

nav .heading {
    font-size: 30px;
    font-weight: 700;
    color: white;
}

nav ul {
    display: flex;
    list-style: none;
}

nav ul li {
    padding: 8px 15px;
    border-radius: 10px;
    transition: 0.2s ease-in;
}

nav ul li a {
    color: black;
    font-size: 20px;
    font-weight: 500;
    text-decoration: none;
    color: white;
}

nav ul li:hover {
    background-color: green;
}

nav ul li a:hover {
    color: white;
}

nav .sideMenuButton {
    font-size: 30px;
    font-weight: bolder;
    cursor: pointer;
    display: none;
}

/* responsive navbar css */
@media screen and (max-width: 600px) {
    nav .sideMenuButton {
        display: flex;
    }

    nav .navbar {
        display: none;
    }

    .sideNavigationBar {
        display: block !important;
    }
}

.sideNavigationBar {
    height: 100%;
    position: fixed;
    top: 0;
    right: 0%;
    background-color: green;
    overflow-x: hidden;
    transition: 0.3s ease-in;
    padding-top: 60px;
    display: none;
}

.sideNavigationBar a {
    padding: 8px 8px 8px 40px;
    display: block;
    font-size: 25px;
    font-weight: 500;
    color: #d1d1d1;
    transition: 0.3s;
    text-decoration: none;
}

.sideNavigationBar a button {
    padding: 10px 20px;
    border-radius: 10px;
    color: green;
    font-size: 16px;
    border-style: none;
    font-weight: 700;
}

.sideNavigationBar a:hover {
    color: white;
}

.sideNavigationBar .closeButton {
    position: absolute;
    top: 10px;
    right: 25px;
    font-size: 20px;
    margin-left: 50px;
}

.line {
    display: flex;
    justify-content: space-between;
    align-items: center;
    margin: 2% 5%;
}

.line .side1 {
    padding-right: 50px;
}

.side1 h1 {
    font-size: 60px;
    margin-bottom: 10px;
    color: green;
}

.side1 button {
    width: 200px;
    padding: 12px 20px;
    border-radius: 20px;
    border-style: none;
    color: black;
    font-size: 17px;
    font-weight: 600;
}

a {
    text-decoration: none;
    color: black;
}

/* Header content responsive */
@media screen and (max-width: 980px) {
    .side2 img {
        width: 350px;
    }

    .side1 h1 {
        font-size: 40px;
    }

    .side1 p {
        font-size: 17px;
    }

    .line {
        margin-top: 80px;
    }
}

@media screen and (max-width: 600px) {
    .side1 h1 {
        font-size: 35px;
    }

    .line {
        flex-direction: column;
    }

    .line .side1 {
        padding: 30px;
    }
}

/* section */

section .topic a {
    font-size: 25px;
    font-weight: 500;
    margin-bottom: 10px;
}

.about .boxes {
    display: flex;
    flex-wrap: wrap;
    justify-content: space-between;
}

.about .boxes .box {
    margin: 10px 20px;
    max-width: calc(100% / 3 - 50px);
    text-align: center;
    border-radius: 12px;
    padding: 30px 10px;
    box-shadow: 0 5px 10px rgba(0, 0, 0, 0.12);
    cursor: default;
}

/* Contact Page  */

.contact {
    padding: 20px;
}

.contact .content {
    margin: 0 auto;
    padding: 30px 0;
}

.content .title {
    width: 80%;
    text-align: center;
    font-weight: bolder;
    font-size: 40px;
}

.title {
    margin-bottom: 30px;
    margin-left: 80px;
}

.contactMenu {
    display: flex;
    justify-content: space-evenly;
}

.input2 {
    margin-top: 10;
}

.label1 {
    font-size: 18px;
    margin-top: 8px;
    margin-bottom: 8px;
    font-weight: bolder;
}

.contactMenu .input1 input {
    border-radius: 13px;
    padding: 6px;
}

.input2 input {
    border-color: rgb(252, 244, 244);
    width: 400px;
}

.button {
    margin-top: 12px;
    margin-left: 5px;
}

.button button {
    width: 162px;
    height: 35px;
    border-radius: 12px;
    border-color: transparent;
}

.button button:hover {
    background-color: #8cc099;
}

button {
    width: 162px;
    height: 45px;
    border-radius: 12px;
    border-color: transparent;
}

button:hover {
    background-color: #8cc099;
}

.rightside1 {
    display: flex;
    flex-direction: column;
    margin-left: 300px;
}

.title1 {
    font-size: 18px;
    margin-top: 8px;
    margin-bottom: 5px;
    font-weight: bolder;
}

.content1 {
    width: 450px;
    margin-top: 2px;
    color: grey;
}

/* Footer */
footer {
    background: var(--primary-color);
    padding: 15px 0;
    text-align: center;
    font-family: "Poppins", sans-serif;
}

footer .footer span {
    font-size: 17px;
    font-weight: 400;
    color: var(--white-color);
}

footer .footer span a {
    font-weight: 500;
    color: var(--white-color);
}

footer .footer span a:hover {
    text-decoration: underline;
}

@media screen and (max-width: 1060px) {
    .contactMenu {
        flex-direction: column;
        align-items: center;
    }

    .rightside1 {
        display: flex;
        flex-direction: column;
        margin-left: 0px;
    }

    .content1 {
        width: 100%;
        margin-top: 2px;
        color: grey;
    }

    .side2 img {
        width: 95%;
        height: 90%;
    }
}

@media screen and (max-width: 600px) {
    .side2 img {
        width: 100%;
    }

    section .topic a {
        font-size: 20px;
    }

    section .topic p {
        font-size: 5px;
    }

    .about .boxes {
        display: flex;
        flex-direction: column;
        align-items: center;
    }

    .about .boxes .box {
        max-width: 70%;
    }
}
    </style>
    <nav>
        <div class="heading">Tailoring Store</div>
        <span class="sideMenuButton" 
            onclick="openNavbar()">
            &#9776
        </span>

        <div class="navbar">
            <ul>
                <li><a href="#Home">Home</a></li>
                <li><a href="#">Sign In</a></li>
                <li><a href="#">Sign Up</a></li>
            </ul>
        </div>
    </nav>

    <!-- Side navigation bar for 
        responsive website -->
    <div class="sideNavigationBar" 
        id="sideNavigationBar">
        <a href="#" class="closeButton" 
            onclick="closeNavbar()">
            &#x274C
        </a>
        <a href="#">Home</a>
        <a href="#">Login</a>
        <a href="#">Sign Up</a>
    </div>

    <!-- Content -->
    <div class="line" id="Home">
        <div class="side1">
            <h1>Stitch & Made</h1>
            <button>
                <a href=""
                </a>
                Explore More
            </button>
        </div>
        <div class="side2">
            <img src=
"https://bristolshoppingquarter.co.uk/wp-content/uploads/2020/02/urban-tailor-600x391.jpg"
                width="500">
        </div>
    </div>

    <section class="about" id="My Projects">
        <div class="content">
            <div class="title">
                <span>Dresses</span>
            </div>
            <div class="boxes">
                <div class="box">
                    <div class="topic">
                        <a href="" target="_blank">
                            Saree
                        </a>
                    </div>
                    <p>
                        Discover the essence of tradition and elegance with our exclusive saree collection, 
                        where each masterpiece is intricately woven to blend rich cultural heritage with contemporary fashion. 
                        Designed to enhance the grace and beauty of every woman, our sarees promise unmatched comfort and sophistication for any occasion, 
                        from festive events to everyday wear.
                    </p>
                </div>
                <div class="box">

                    <div class="topic">
                        <a href="" target="_blank">
                            Churidar
                        </a>
                    </div>
                    <p>
                        Step into elegance and comfort with our exquisite churidar collection, 
                        where tradition meets modern style in designs that flatter every silhouette. 
                        Crafted with the finest fabrics for a snug yet flexible fit, our churidars are the perfect blend of grace and sophistication,
                        whether for special occasions or everyday wear.
                    </p>
                </div>

                <div class="box">
                    <div class="topic">
                        <a href="" target="_blank">
                            Western
                        </a>
                    </div>
                    <p>
                        Elevate your wardrobe with our chic and versatile Western wear collection, 
                        designed for the modern individual who values both style and comfort. 
                        From casual outfits to statement pieces, our collection offers fashionable options that seamlessly blend contemporary trends with 
                        timeless appeal for every occasion.
                    </p>
                </div>
            </div>
        </div>
    </section>

    <section class="contact" id="contact">
        <div class="content">
            <div class="title"><span>Sign Up</span></div>
            <div class="contactMenu">
                <div class="input1">
                    <div class="label1">Your Name</div>
                    <div class="input2">
                        <input type="text" 
                            placeholder="Enter your Name here">
                    </div>
                    <div class="label1">
                        <label>Your Email</label>
                    </div>
                    <div class="input2">
                        <input type="text" 
                            placeholder="Enter your Email here">
                    </div>
                    <div class="label1">
                        <label>Your Password</label>
                    </div>
                    <div class="input2">
                        <input type="text" 
                            placeholder="Enter your Password here">
                    </div>
                    <div class="button">
                        <button>Sign Up</button>
                    </div>
                </div>
                <div class="input3">
                    <div class="rightside1">
                        <div class="title1">
                            <span>
                                Contact Us
                            </span>
                        </div>
                        <div class="content1">
                            A-143, 9th Floor, Sovereign 
                            Corporate Tower, Sector-136, 
                            Noida, Uttar Pradesh - 201305
                        </div>
                        <div class="title1">
                            <span>More Information</span>
                        </div>
                        <div class="content1">
                            We pride ourselves on delivering exceptional tailoring services tailored to your unique style and preferences. 
                            Our team of skilled craftsmen and designers work closely with you to create custom-made garments that fit perfectly and reflect your personal taste. Whether you need alterations, bespoke suits, bridal wear, or traditional attire, 
                            we use only the finest materials and meticulous techniques to ensure every piece is crafted to perfection..Visit us today for a consultation and experience the art of tailoring at its finestThank you for choosing 
                            and supporting us!
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- Footer section -->
    <footer>
        <div class="footer">
            <span>
                Created By
                <a href="https://www.geeksforgeeks.org/" 
                    target="_blank">
                    TailoringStore
                </a>
            </span>
        </div>
    </footer>
    <script>
        function openNavbar() {
    document.getElementById("sideNavigationBar")
        .style.width = "50%";
}
function closeNavbar() {
    document.getElementById("sideNavigationBar")
        .style.width = "0%";
}
    </script>
</body>

</html>

</asp:Content>
