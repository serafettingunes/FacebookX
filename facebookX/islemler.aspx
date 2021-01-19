<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="islemler.aspx.cs" Inherits="facebookX.islemler" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <div>
            <asp:FileUpload ID="FileUpload1" runat="server" OnDataBinding="FileUpload1_DataBinding" />
        &nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="KAYDET" />
        </div>
    </form>
</body>
</html>
