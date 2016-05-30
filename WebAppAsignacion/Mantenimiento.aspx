<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Mantenimiento.aspx.cs" Inherits="WebAppAsignacion.Mantenimiento" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
           
        <table class="auto-style1">
        <tr>
            <td style="text-align: center">
                <asp:Label ID="lbltitulo" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="Red" Text="MANTENIMIENTO DE EQUIPOS"></asp:Label>
            </td>
        </tr>

        <tr>
            <td/>
        </tr>
        
         <tr>
            <td>
            <asp:Button ID="btnNuevo" runat="server" Text="Nuevo" />
            </td>
        </tr>

        <tr>
            <td style="text-align: center">
            <asp:GridView ID="gvEquipos" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#333333" 
                                                        BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" Height="230px" 
                                                        Width="850px" style="text-align: center; margin-left: 0px;" AllowPaging="True" PageSize="5" OnPageIndexChanging="Paginar">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="NRO SERIE" />
                    <asp:BoundField DataField="Tipo" HeaderText="TIPO" />
                    <asp:BoundField DataField="Modelo" HeaderText="MODELO" />
                    <asp:BoundField DataField="Estado" HeaderText="ESTADO" />
                    <asp:BoundField DataField="FechaReg" HeaderText="FECHA REGISTRO" />
                    <asp:HyperLinkField DataNavigateUrlFields="Id" DataNavigateUrlFormatString="ModificarProducto.aspx?id={0}" HeaderText="MODIFICAR" Text="Modificar" />
                    <asp:HyperLinkField DataNavigateUrlFields="Id" DataNavigateUrlFormatString="EliminarProducto.aspx?id={0}" HeaderText="ELIMINAR" Text="Eliminar" />
                    <asp:HyperLinkField DataNavigateUrlFields="Id" DataNavigateUrlFormatString="DetalleProducto.aspx?id={0}" HeaderText="DETALLE" Text="Detalle" />
                </Columns>
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#242121" />
            </asp:GridView>                
            </td>
        </tr>

        <tr>
            <td/>
        </tr>

        <tr>
            <td>
            <asp:Button ID="btnSalir" runat="server" Text="Salir" OnClick="btnSalir_Click" />
            </td>
        </tr>


         </table>

            
       
    
    </div>
    </form>
</body>
</html>
