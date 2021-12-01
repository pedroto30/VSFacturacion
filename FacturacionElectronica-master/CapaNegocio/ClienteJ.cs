using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDato;

namespace CapaNegocio
{
    public class ClienteJ : Interface.IClienteJ
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
        private string Ruc;
        private string raz_soc;
        private string tel;
        private string dir;
        private string email;

        public string Ruc1 { get => Ruc; set => Ruc = value; }
        public string Raz_soc { get => raz_soc; set => raz_soc = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Dir { get => dir; set => dir = value; }
        public string Email { get => email; set => email = value; }

        public bool Actualizar()
        {
            DataRow fila = datos.TraerDataRow("spActualizarTCJuridicos", Ruc, raz_soc, tel, dir, email);
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
            DataRow fila = datos.TraerDataRow("spAgregarTCJuridicos", Ruc, raz_soc, tel, dir, email);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }

        public DataSet Buscar(string texto, string criterio)
        {
            return datos.TraerDataSet("spBuscarTCJuridicos", texto, criterio);
        }

        public bool Eliminar()
        {
            DataRow fila = datos.TraerDataRow("spEliminarTCJuridicos", Ruc);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0)
            { return true; }
            else
            { return false; }
        }

        public DataSet Listar()
        {
            return datos.TraerDataSet("spListarTCJuridicos");
        }
    }
}
