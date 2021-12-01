using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDato;

namespace CapaNegocio
{
    public class NotaCredito : Interface.INotaCredito
    {
        // Crear un objeto para usar la capadato 
        private Datos datos = new DatosSQL();

        // Declaramos un atributo y propiedad para el mensaje del procedimiento almacenado
        /*private string mensaje;
        public string Mensaje
        {
            get { return mensaje; }
        }*/
        //Atributos de clase 
        private string id;
        private DateTime fecha;
        private string descr;
        private string id_f;

        public string Id { get => id; set => id = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Descr { get => descr; set => descr = value; }
        public string Id_f { get => id_f; set => id_f = value; }

        public bool Actualizar()
        {
            throw new NotImplementedException();
        }

        public bool Agregar()
        {
            throw new NotImplementedException();
        }

        public DataSet Buscar(string texto, string criterio)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar()
        {
            throw new NotImplementedException();
        }

        public DataSet Listar()
        {
            throw new NotImplementedException();
        }
    }
}
