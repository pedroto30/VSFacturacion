using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDato;

namespace CapaNegocio
{
    public class Empresa : Interface.IEmpresa
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
        private string ruc;
        private string raz_soc;
        private string dir;
        private string tel;
        private string cel;
        private string email;
        private string propieta;

        public string Ruc { get => ruc; set => ruc = value; }
        public string Raz_soc { get => raz_soc; set => raz_soc = value; }
        public string Dir { get => dir; set => dir = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Cel { get => cel; set => cel = value; }
        public string Email { get => email; set => email = value; }
        public string Propieta { get => propieta; set => propieta = value; }

        public bool Actualizar()
        {
            DataRow fila = datos.TraerDataRow("spActualizarTEmpresa", ruc, raz_soc, dir, tel, cel, email, propieta);
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
            DataRow fila = datos.TraerDataRow("spAgregarTEmpresa", ruc, raz_soc, dir, tel, cel, email, propieta);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }

        public DataSet Buscar(string texto, string criterio)
        {
            return datos.TraerDataSet("spBuscarTEmpresa", texto, criterio);
        }

        public bool Eliminar()
        {
            DataRow fila = datos.TraerDataRow("spEliminarTEmpresa", ruc);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0)
            { return true; }
            else
            { return false; }
        }

        public DataSet Listar()
        {
            return datos.TraerDataSet("spListarTEmpresa");
        }
    }
}
