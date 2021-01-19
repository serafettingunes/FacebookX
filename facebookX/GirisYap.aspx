<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GirisYap.aspx.cs" Inherits="facebookX.GirisYap" %>



<!--
Author: Colorlib
Author URL: https://colorlib.com
License: Creative Commons Attribution 3.0 Unported
License URL: http://creativecommons.org/licenses/by/3.0/
-->
<!DOCTYPE html>
<html>
<head>
    <link href="uyari.css" rel="stylesheet" />
    <link href="kayitolcss.css" rel="stylesheet" />
    <title>Creative Colorlib SignUp Form</title>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false); function hideURLbar(){ window.scrollTo(0,1); } </script>
    <!-- Custom Theme files -->
    <link href="css/style.css" rel="stylesheet" type="text/css" media="all" />
    <!-- //Custom Theme files -->
    <!-- web font -->
    <link href="//fonts.googleapis.com/css?family=Roboto:300,300i,400,400i,700,700i" rel="stylesheet">
    <!-- //web font -->
</head>
<body>
    <!-- main -->
    <div class="main-w3layouts wrapper"> 
        <div style="text-align:center;">
        </div>
       
        <h2 style="text-align:center; font-size:40px;">
           
            &nbsp;</h2>

        <h1>GİRİŞ YAP</h1>
        <div class="main-agileinfo">
            <div class="agileits-top">
                <form id="form1" runat="server">

                    <asp:TextBox ID="txtgmail" runat="server" class="text" name="Username" placeholder=" Gmail" required=""></asp:TextBox>
                    <br />


                    <asp:TextBox ID="txtSifre" runat="server" class="text" type="password" name="password" placeholder="Şifre" required=""></asp:TextBox>
                    <br />

                     <br />
                    <asp:Button ID="Button1" runat="server" Text="GİRİŞ YAP" OnClick="Button1_Click" />

                </form>
                <p>&nbsp;</p>
            </div>
        </div>
        <!-- copyright -->
        <div class="colorlibcopy-agile">
            <p>© 2018 Colorlib Signup Form. All rights reserved | Design by <a href="https://colorlib.com/" target="_blank">Colorlib</a></p>
        </div>
        <!-- //copyright -->
        <ul class="colorlib-bubbles">
            <li></li>
            <li></li>
            <li></li>
            <li></li>
            <li></li>
            <li></li>
            <li></li>
            <li></li>
            <li></li>
            <li></li>
        </ul>
    </div>
    <!-- //main -->
</body>
</html>


