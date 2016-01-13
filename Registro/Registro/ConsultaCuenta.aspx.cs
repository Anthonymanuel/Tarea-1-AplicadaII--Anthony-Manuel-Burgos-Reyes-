using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BLL;
namespace Registro
{
    public partial class ConsultaCuenta : System.Web.UI.Page
    {
      
        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            Cuenta cuenta = new Cuenta();
            DataTable dataTable = new DataTable();
            string condicion;
            int cuentaId;
            int.TryParse(DatosTextBox.Text, out cuentaId);
            if (ConsultaDropDownList.SelectedIndex == 0)
            {
                if (DatosTextBox.Text.Trim().Length == 0)
                {
                    condicion = "1=1";
                }
                else
                {
                    condicion = "CuentaId = " + cuentaId;
                }
                dataTable = cuenta.Listado(" CuentaId, Descripcion, Balance", condicion, "");
                ConsultaGridView.DataSource = dataTable;
                ConsultaGridView.DataBind();
            }
            if (ConsultaDropDownList.SelectedIndex == 1)
            {
                if (DatosTextBox.Text.Trim().Length == 1)
                {
                    condicion = "2=2";
                }
                else
                {
                    condicion = "Descripcion =  "+ DatosTextBox.Text;
                }
                dataTable = cuenta.Listado(" CuentaId, Descripcion, Balance", condicion, "");
                ConsultaGridView.DataSource = dataTable;
                ConsultaGridView.DataBind();

           }

        }
    }
    }
