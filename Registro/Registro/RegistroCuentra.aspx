<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistroCuentra.aspx.cs" Inherits="Registro.RegistroCuentra" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            &nbsp;CuentaId:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="CuentaIdTextBox" runat="server" style="margin-left: 34px" Width="126px"></asp:TextBox>
            <asp:Button ID="BuscarButton" runat="server" OnClick="BuscarButton_Click" style="margin-left: 29px" Text="Buscar" />
            <br />
            <br />
            &nbsp; Descripcion:<asp:TextBox ID="DescripcionTextBox" runat="server" style="margin-left: 67px"></asp:TextBox>
            <br />
            <br />
            &nbsp;&nbsp; Balance:<asp:TextBox ID="BalanceTextBox" runat="server" Width="130px" style="margin-left: 84px"></asp:TextBox>
            <br />
        </p>
        <p>
            &nbsp;<asp:Button ID="NuevoButton" runat="server" OnClick="NuevoButton_Click1" style="margin-left: 94px" Text="Nuevo" />
            <asp:Button ID="GuardarButton" runat="server" OnClick="GuardarButton_Click" style="margin-left: 27px" Text="Guardar" />
            <asp:Button ID="EliminarButton" runat="server" OnClick="EliminarButton_Click" Text="Eliminar" style="margin-left: 17px" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    <div style="margin-left: 80px">
    
        <br />
    
    </div>
    </form>
</body>
</html>
