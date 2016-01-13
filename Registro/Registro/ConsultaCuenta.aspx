<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsultaCuenta.aspx.cs" Inherits="Registro.ConsultaCuenta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <center>   
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
 
        Filtrar Por:<asp:DropDownList ID="ConsultaDropDownList" runat="server" style="margin-left: 28px">
            <asp:ListItem>CuentaId</asp:ListItem>
            <asp:ListItem>Descripcion</asp:ListItem>
        </asp:DropDownList>
        <asp:TextBox ID="DatosTextBox" runat="server" style="margin-left: 24px" Width="176px"></asp:TextBox>
        <asp:Button ID="BuscarButton" runat="server" OnClick="BuscarButton_Click" style="margin-left: 28px" Text="Buscar" />
    </div>
        <br />
         <center>
        <asp:GridView ID="ConsultaGridView" runat="server" style="margin-left: 230px" Width="299px">
        </asp:GridView>
              </center>
        <br />
        <br />
        <br />
        </center>
    </form>
</body>
</html>
