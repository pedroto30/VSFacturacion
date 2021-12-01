using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDato;

namespace CapaNegocio
{
    public class Boleta : Interface.IBoleta
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
        private string id_b;
        private int id_t;
        private int id_l;
        private DateTime fecha;
        private decimal subt;
        private decimal tot;
        private decimal desc;
        private decimal por_desc;
        private string DniCN;
        private string RucEmp;

        public string Id_b { get => id_b; set => id_b = value; }
        public int Id_t { get => id_t; set => id_t = value; }
        public int Id_l { get => id_l; set => id_l = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public decimal Subt { get => subt; set => subt = value; }
        public decimal Tot { get => tot; set => tot = value; }
        public decimal Desc { get => desc; set => desc = value; }
        public decimal Por_desc { get => por_desc; set => por_desc = value; }
        public string DniCN1 { get => DniCN; set => DniCN = value; }
        public string RucEmp1 { get => RucEmp; set => RucEmp = value; }

        public bool Actualizar()
        {
            DataRow fila = datos.TraerDataRow("spActualizarTBoleta", id_b, id_t, id_l, fecha, subt, tot, desc, por_desc, DniCN, RucEmp);
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
            DataRow fila = datos.TraerDataRow("spAgregarTBoleta", id_b, id_t, id_l, fecha, subt, tot, desc, por_desc, DniCN, RucEmp);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }

        public DataSet Buscar(string texto, string criterio)
        {
            return datos.TraerDataSet("spBuscarTBoleta", texto, criterio);
        }

        public bool Eliminar()
        {
            DataRow fila = datos.TraerDataRow("spEliminarTBoleta", id_b);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0)
            { return true; }
            else
            { return false; }
        }

        public DataSet Listar()
        {
            return datos.TraerDataSet("spListarTBoleta");
        }
    }
}
