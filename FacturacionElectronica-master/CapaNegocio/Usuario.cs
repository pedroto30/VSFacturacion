using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


using CapaDato;

namespace CapaNegocio
{
    [DataContract]
    public class Usuario : Interface.IUsuario
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
        private string Idusu;
        private string contra;
        
        public int Id { get => id; set => id = value; }
        [DataMember]
        public string Idusu1 { get => Idusu; set => Idusu = value; }
        [DataMember]
        public string Contra { get => contra; set => contra = value; }

        public bool Actualizar()
        {
            DataRow fila = datos.TraerDataRow("spActualizarTUsuario", id, Idusu, contra);
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
            DataRow fila = datos.TraerDataRow("spAgregarUsuario", Idusu, contra);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }

        public DataSet Buscar(string texto, string criterio)
        {
            return datos.TraerDataSet("spBuscarTUsuario", texto, criterio);
        }

        public bool Eliminar()
        {
            DataRow fila = datos.TraerDataRow("spEliminarTUsuario", id);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0)
            { return true; }
            else
            { return false; }
        }

        public DataSet Listar()
        {
            return datos.TraerDataSet("spListarTUsuario");
        }

        public bool Login_User()
        {
            DataRow fila = datos.TraerDataRow("spLoginUsuario", Idusu,Contra);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0)
            { return true; }
            else
            { return false; }
        }

        public DataSet ListarIdUsuario()
        {
         return datos.TraerDataSet("spListarIdUsuario");
        }
        
    }
}
