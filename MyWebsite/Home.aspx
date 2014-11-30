<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    Click
    <asp:Button ID="btnGridDisplay" runat="server" onclick="btnGridDisplay_Click" 
        Text="Button" />
&nbsp;to load data in gridview<br />
    <asp:GridView ID="GV1" runat="server">
    </asp:GridView>
    <asp:DataGrid ID="DG1" runat="server">
    </asp:DataGrid>
    </form>
</body>
</html>
