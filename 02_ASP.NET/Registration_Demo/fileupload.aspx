<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="fileupload.aspx.cs" Inherits="Registration_Demo.fileupload" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <br /><br />

        <asp:Button ID="Button1" runat="server"
            Text="Upload File"
            OnClick="Button1_Click" />

        <br /><br />

        <asp:Label ID="Label1" runat="server"></asp:Label>
    </form>
</body>
</html>
