<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WfPanel.aspx.cs" Inherits="WebAppAsignacion.WfPanel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 358px">
        
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Solicitar PC" />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Mantenimiento PC" />
    
    </div>
    </form>
</body>
</html>
