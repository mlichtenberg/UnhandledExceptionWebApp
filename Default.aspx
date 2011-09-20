<%@ Page Title="Home Page" Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="UnhandledExceptionWebApp._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<body>
    <form id="form1" runat="server">
    <div>
    <h2>
        Unhandled Exception Tests
    </h2>
    <asp:Button ID="btnStackOverflow" runat="server" onclick="btnStackOverflow_Click" Text="Stack Overflow" />
    <asp:Button ID="btnException" runat="server" Text="Exception" onclick="btnException_Click" />
    <asp:Button ID="btnUnhandled" runat="server" Text="Unhandled Exception" onclick="btnUnhandled_Click" />
    </div>
    </form>
</body>
</html>
