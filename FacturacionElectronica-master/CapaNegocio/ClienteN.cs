using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDato;

namespace CapaNegocio
{
    public class ClienteN : Interface.IClienteN
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
        private string Dni;
        private string nomb;
        private string ape;
        private string tel;
        private string dir;
        private string email;

        public string Dni1 { get => Dni; set => Dni = value; }
        public string Nomb { get => nomb; set => nomb = value; }
        public string Ape { get => ape; set => ape = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Dir { get => dir; set => dir = value; }
        public string Email { get => email; set => email = value; }

        public bool Actualizar()
        {
            DataRow fila = datos.TraerDataRow("spActualizarTCNatural", Dni, nomb, ape, tel, dir, email);
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
            DataRow fila = datos.TraerDataRow("spAgregarTCNatural", Dni, nomb, ape, tel, dir, email);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0) return true;
            else return false;
        }

        public DataSet Buscar(string texto, string criterio)
        {
            return datos.TraerDataSet("spBuscarTCNatural", texto, criterio);
        }

        public bool Eliminar()
        {
            DataRow fila = datos.TraerDataRow("spEliminarTCNatural", Dni);
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            if (codError == 0)
            { return true; }
            else
            { return false; }
        }

        public DataSet Listar()
        {
            return datos.TraerDataSet("spListarTCNatural");
        }
    }

       
    }
