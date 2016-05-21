<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DetalleProducto.aspx.cs" Inherits="WebAppAsignacion.DetalleProducto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
        <table class="auto-style1" border="1" >
        <tr>
            <td style="text-align: center" colspan="2">
                <asp:Label ID="lbltitulo" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="Red" Text="DETALLE DE EQUIPOS"></asp:Label>
            </td>
        </tr>

        <tr>
            <td/>
            <td/>
        </tr>

        <tr>
            <td style="text-align: center">
                <asp:Label ID="lblCodigo" runat="server" Text="CODIGO:"></asp:Label>
            </td>
            <td style="text-align: center">
                <asp:Label ID="lblCodigox" runat="server"></asp:Label>
            </td>
        </tr>
        
        <tr>
            <td style="text-align: center">
                <asp:Label ID="lblNombre" runat="server" Text="NOMBRE:"></asp:Label>
            </td>
            <td style="text-align: center">
                <asp:Label ID="lblNombrex" runat="server"></asp:Label>
            </td>
        </tr>

        <tr>
            <td style="text-align: center">
                <asp:Label ID="lblDescripcion" runat="server" Text="DESCRIPCION:"></asp:Label>
            </td>
            <td style="text-align: center">
                <asp:Label ID="lblDescripcionx" runat="server"></asp:Label>
            </td>
        </tr>

        <tr>
            <td style="text-align: center">
                <asp:Label ID="lblMarca" runat="server" Text="MARCA:"></asp:Label>
            </td>
            <td style="text-align: center">
                <asp:Label ID="lblMarcax" runat="server"></asp:Label>
            </td>
        </tr>

        <tr>
            <td style="text-align: center">
                <asp:Label ID="lblArea" runat="server" Text="AREA:"></asp:Label>
            </td>
            <td style="text-align: center">
                <asp:Label ID="lblAreax" runat="server"></asp:Label>
            </td>
        </tr>

        <tr>
            <td style="text-align: center">
                <asp:Label ID="lblPrecio" runat="server" Text="PRECIO:"></asp:Label>
            </td>
            <td style="text-align: center">
                <asp:Label ID="lblPreciox" runat="server"></asp:Label>
            </td>
        </tr>

        <tr>
            <td style="text-align: center">
                <asp:Label ID="lblFecha" runat="server" Text="FECHA REGISTRO:"></asp:Label>
            </td>
            <td style="text-align: center">
                <asp:Label ID="lblFechax" runat="server"></asp:Label>
            </td>
        </tr>

        <tr>
            <td style="text-align: center">
                <asp:Label ID="lblEstado" runat="server" Text="ESTADO:"></asp:Label>
            </td>
            <td style="text-align: center">
                <asp:Label ID="lblEstadox" runat="server"></asp:Label>
            </td>
        </tr>
        
        <tr>
            <td/>
            <td/>
        </tr>

         <tr>
            <td>
            <asp:Button ID="btnSalir" runat="server" Text="Salir" OnClick="btnSalir_Click" />
            </td>
            <td />
        </tr>
        
        </table>

   
    
    </div>
    </form>
</body>
</html>
