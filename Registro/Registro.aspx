<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Registro.aspx.cs" Inherits="Registro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Registro</p>
        <p>
            &nbsp;</p>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Cuenta Id:<asp:TextBox ID="CuentaIdTextBox" runat="server" Height="16px" style="margin-left: 43px" Width="135px"></asp:TextBox>
        </p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Descripcion:<asp:TextBox ID="DescripcionTextBox" runat="server" style="margin-left: 27px" Width="135px"></asp:TextBox>
        </p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Balance:&nbsp;<asp:TextBox ID="BalanceTextBox" runat="server" style="margin-left: 49px" Width="135px"></asp:TextBox>
        </p>
    <div>
    
        <asp:Button ID="NuevoButton" runat="server" OnClick="NuevoButton_Click" style="margin-left: 106px" Text="Nuevo" />
        <asp:Button ID="GuardarButton" runat="server" style="margin-left: 25px" Text="Guardar" />
        <asp:Button ID="EliminarButton" runat="server" style="margin-left: 24px" Text="Eliminar" Width="69px" />
    
    </div>
    </form>
</body>
</html>
