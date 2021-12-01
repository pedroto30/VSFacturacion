using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
//using System.Web.UI.WebControls;
using CapaDato;

namespace CapaNegocio
{
    public class Trabajador : Interface.ITrabajador
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
        private string dni;
        private string ape;
        private string nom;
        private string rol;
        private string tel;
        private string dir;
        private string gene;
        private int id_u;
       
        

        public int Id { get => id; set => id = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Ape { get => ape; set => ape = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Rol { get => rol; set => rol = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Dir { get => dir; set => dir = value; }
        public string Gene { get => gene; set => gene = value; }
        public int Id_u { get => id_u; set => id_u = value; }
        
        public bool Actualizar()
        {
            DataRow fila = datos.TraerDataRow("spActualizarTTrabajador", id, dni, ape, nom, rol, tel, dir, gene, id_u);
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
            DataRow fila = datos.TraerDataRow("spAgregarTTrabajador", dni, ape, nom, rol, tel, dir, gene, id_u);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }

        public DataSet Buscar(string texto, string criterio)
        {
            return datos.TraerDataSet("spBuscarTTrabajador", texto, criterio);
        }

        public bool Eliminar()
        {
            DataRow fila = datos.TraerDataRow("spEliminarTTrabajador", id);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0)
            { return true; }
            else
            { return false; }
        }

        public DataSet Listar()
        {
            return datos.TraerDataSet("spListarTTrabajador");
        }
              
        
    }
}
