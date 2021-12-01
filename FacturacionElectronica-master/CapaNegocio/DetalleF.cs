using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDato;

namespace CapaNegocio
{
    public class DetalleF : Interface.IDetalleF
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
        private int id_p;
        private decimal cant;

        public int Id_p { get => id_p; set => id_p = value; }
        public decimal Cant { get => cant; set => cant = value; }
        public string Id_f { get => id_f; set => id_f = value; }

        public bool Actualizar()
        {
            DataRow fila = datos.TraerDataRow("spActualizarTDetalleF", id_f, id_p, cant);
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
            DataRow fila = datos.TraerDataRow("spAgregarTDetalleF", id_f, id_p, cant);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }

        public DataSet Buscar(string texto, string criterio)
        {
            return datos.TraerDataSet("spBuscarTDetalleF", texto, criterio);
        }

        public bool Eliminar()
        {
            DataRow fila = datos.TraerDataRow("spEliminarTDetalleF", id_f);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0)
            { return true; }
            else
            { return false; }
        }

        public DataSet Listar()
        {
            return datos.TraerDataSet("spListarTDetalleF");
        }
    }
}
