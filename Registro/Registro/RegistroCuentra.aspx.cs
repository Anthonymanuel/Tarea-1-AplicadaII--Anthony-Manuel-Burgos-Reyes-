using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace Registro
{
    public partial class RegistroCuentra : System.Web.UI.Page
    {

        public void Limpiar()
        {
            CuentaIdTextBox.Text = "";
            DescripcionTextBox.Text = "";
            BalanceTextBox.Text = "";
        }
        public void NuevoButton_Click1(object sender, EventArgs e)
        {
            Limpiar();
        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            Cuenta cuenta = new Cuenta();
            float balance;
            int cuentaId;
            int.TryParse(CuentaIdTextBox.Text, out cuentaId);
            float.TryParse(BalanceTextBox.Text, out balance);
            cuenta.CuentaId = cuentaId;
            cuenta.Descripcion = DescripcionTextBox.Text;
            cuenta.Balance = balance;
            if(cuentaId == 0 && cuenta.Insetar())
            {
                Limpiar();
            }
            if (cuentaId > 0 && cuenta.Editar())
            {
                Limpiar();
            }
        }

        protected void EliminarButton_Click(object sender, EventArgs e)
        {
            Cuenta cuenta = new Cuenta();
            int cuentaId;
            int.TryParse(CuentaIdTextBox.Text, out cuentaId);
            cuenta.CuentaId = cuentaId;
            if(cuenta.Eliminar())
            {
                Limpiar();
            }
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            Cuenta cuenta = new Cuenta();
            int cuentaId;
            int.TryParse(CuentaIdTextBox.Text, out cuentaId);
            cuenta.Buscar(cuentaId);
            CuentaIdTextBox.Text = cuenta.CuentaId.ToString();
            DescripcionTextBox.Text = cuenta.Descripcion;
            BalanceTextBox.Text = cuenta.Balance.ToString();

        }
    }
}