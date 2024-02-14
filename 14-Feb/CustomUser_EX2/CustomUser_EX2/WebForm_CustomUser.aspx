<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm_CustomUser.aspx.cs" Inherits="CustomUser_EX2.WebForm_CustomUser" %>

<%@ Register assembly="CustomUserControl_Example" namespace="CustomUserControl_Example" tagprefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <cc1:WebCustomControl ID="WebCustomControl1" runat="server" />
        </div>
    </form>
</body>
</html>
