<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="KayitOl.aspx.cs" Inherits="facebookX.KayitOl" %>

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
             <asp:Image ID="Image1"  runat="server" Height="130px" Width="130px"    />
        </div>
       
        <h2 style="text-align:center; font-size:40px;">
           
            <asp:Label ID="lblUyari" runat="server"></asp:Label>
        </h2>

        <h1>KAYIT OL</h1>
        <div class="main-agileinfo">
            <div class="agileits-top">
                <form id="form1" runat="server">

                    <asp:TextBox ID="txtAd" runat="server" class="text" name="Username" placeholder=" Ad" required=""></asp:TextBox>
                    <br />
                    <asp:TextBox ID="txtSoyad" runat="server" class="text" name="Username" placeholder="Soyad" required=""></asp:TextBox>

                    <asp:TextBox ID="txtGmail" runat="server" class="text email" type="email" name="email" placeholder="Gmail" required=""></asp:TextBox>


                    <asp:TextBox ID="txtSifre" runat="server" class="text" type="password" name="password" placeholder="Şifre" required=""></asp:TextBox>
                    <br />
                    <asp:TextBox ID="txtSifreTekrar" runat="server"  type="password" name="password" placeholder="ŞifreTekrar" required=""></asp:TextBox>

                     <br />
                     İkon Resmi 
                    <asp:FileUpload ID="FileUpload1" runat="server" class="text" required=""  />
                    <br />
                    <br />
                     Banner Resmi 
                    <asp:FileUpload ID="FileUpload2" runat="server" class="text" required=""  />
                    <asp:Button ID="Button1" runat="server" Text="KAYIT OL" OnClick="Button1_Click" />

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
