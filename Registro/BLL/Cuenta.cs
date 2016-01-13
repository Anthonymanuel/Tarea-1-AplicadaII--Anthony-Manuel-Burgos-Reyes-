using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Cuenta : ClaseMaestra
    {
        public int CuentaId { get; set; }
        public string Descripcion { get; set; }
        public float Balance { get; set; }

        public Cuenta()
        {
            this.CuentaId = 0;
            this.Descripcion = "";
            this.Balance = 0;

        }
        public override bool Insetar()
        {
            ConexionDB conexion = new ConexionDB();
            bool retorno = false;
            retorno = conexion.Ejecutar(String.Format("Insert Into Cuentas (Descripcion,Balance) Values ('{0}',{1})", this.Descripcion, this.Balance));
            return retorno;
        }

        public override bool Editar()
        {
            ConexionDB conexion = new ConexionDB();
            bool retorno = false;
            retorno = conexion.Ejecutar(String.Format("Update Cuentas Set  Descripcion = '{0}',Balance = {1}  Where CuentaId = {2}", this.Descripcion, this.Balance, this.CuentaId));
            return retorno;
        }


        public override bool Eliminar()
        {
            ConexionDB conexion = new ConexionDB();
            bool retorno = false;
            retorno = conexion.Ejecutar(String.Format("Delete Cuentas Where CuentaId = {0}", this.CuentaId));
            return retorno;
        }

        public override bool Buscar(int idBuscado)
        {
            ConexionDB conexion = new ConexionDB();
            DataTable dt = new DataTable();


            dt = conexion.ObtenerDatos(String.Format("Select *from Cuentas where CuentaId = {0}", idBuscado));
            if (dt.Rows.Count > 0)
            {
                this.CuentaId = (int)dt.Rows[0]["CuentaId"];
                this.Descripcion = dt.Rows[0]["Descripcion"].ToString();
                this.Balance = Convert.ToSingle(dt.Rows[0]["Balance"]);
            }
            return dt.Rows.Count > 0;
        }

        public override DataTable Listado(string campos, string condicion, string orden)
        {
            string Orden = "";
            if (!orden.Equals(""))
                Orden = " Orden by " + orden;
            ConexionDB conexion = new ConexionDB();
            return conexion.ObtenerDatos("Select " + campos + " From Cuentas where " +
                condicion + "" + Orden);

        }
    }
}
