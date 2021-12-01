using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDato;

namespace CapaNegocio
{
    public class Factura : Interface.IFactura
    {
        // Crear un objeto para usar la capadato 
        private Datos datos = new DatosSQL();

        // Declaramos un atributo y propiedad para el mensaje del procedimiento almacenado
        private string mensaje;
        public string Mensaje
        {
            get { return mensaje; }
        }
        //Atributos de clase 
        private string id_f;
        private int id_t;
        private int id_l;
        private DateTime fecha;
        private decimal subt;
        private decimal tot;
        private decimal igv;
        private decimal desc;
        private decimal por_desc;
        private string RucCJ;
        private string RucEmp;

        public string Id_f { get => id_f; set => id_f = value; }
        public int Id_t { get => id_t; set => id_t = value; }
        public int Id_l { get => id_l; set => id_l = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public decimal Subt { get => subt; set => subt = value; }
        public decimal Tot { get => tot; set => tot = value; }
        public decimal Igv { get => igv; set => igv = value; }
        public decimal Desc { get => desc; set => desc = value; }
        public decimal Por_desc { get => por_desc; set => por_desc = value; }
        public string RucCJ1 { get => RucCJ; set => RucCJ = value; }
        public string RucEmp1 { get => RucEmp; set => RucEmp = value; }

        public bool Actualizar()
        {
            DataRow fila = datos.TraerDataRow("spActualizarTFactura", id_f, id_t, id_l, fecha, subt, tot, igv, desc, por_desc, RucCJ, RucEmp);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0)
            { return true; }
            else
            { return false; }
        }

        public bool Agregar()
        {
            // Traer los datos de la consulta 
            DataRow fila = datos.TraerDataRow("spAgregarTFactura", id_f, id_t, id_l, fecha, subt, tot, igv, desc, por_desc, RucCJ, RucEmp);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }

        public DataSet Buscar(string texto, string criterio)
        {
            return datos.TraerDataSet("spBuscarTFactura", texto, criterio);
        }

        public bool Eliminar()
        {
            DataRow fila = datos.TraerDataRow("spEliminarTFactura", id_f);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0)
            { return true; }
            else
            { return false; }
        }

        public DataSet Listar()
        {
            return datos.TraerDataSet("spListarTFactura");
        }
    }
}
