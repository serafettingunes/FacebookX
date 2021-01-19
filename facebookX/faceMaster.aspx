<%@ Page Title="" Language="C#" MasterPageFile="~/face.Master" AutoEventWireup="true" CodeBehind="faceMaster.aspx.cs" Inherits="facebookX.faceMaster" %>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <asp:Image ID="Image1" Width="100%" runat="server" Height="300px" class="tp-bgimg defaultimg" data-lazyload="undefined" data-bgfit="cover" data-bgposition="left top" data-bgrepeat="no-repeat" data-lazydone="undefined" />
</asp:Content>


<asp:Content ID="Content2" runat="server" contentplaceholderid="ContentPlaceHolder2">
    <a href="islemler2.aspx">
    <asp:Image  Height="40" Width="40" ID="Image2" runat="server" />
    </a>
</asp:Content>




