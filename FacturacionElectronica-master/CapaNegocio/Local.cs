using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDato;

namespace CapaNegocio
{
    public class Local : Interface.ILocal
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
        private int id;
        private string nom_l;
        private string tel;
        private string dir;

        public int Id { get => id; set => id = value; }
        public string Nom_l { get => nom_l; set => nom_l = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Dir { get => dir; set => dir = value; }

        public bool Actualizar()
        {
            DataRow fila = datos.TraerDataRow("spActualizarTLocal", id, nom_l, tel, dir);
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
            DataRow fila = datos.TraerDataRow("spAgregarTLocal", nom_l, tel,dir);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }

        public DataSet Buscar(string texto, string criterio)
        {
            return datos.TraerDataSet("spBuscarTLocal", texto, criterio);
        }

        public bool Eliminar()
        {
            DataRow fila = datos.TraerDataRow("spEliminarTLocal", id);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0)
            { return true; }
            else
            { return false; }
        }

        public DataSet Listar()
        {
            return datos.TraerDataSet("spListarTLocal");
        }
    }
}
