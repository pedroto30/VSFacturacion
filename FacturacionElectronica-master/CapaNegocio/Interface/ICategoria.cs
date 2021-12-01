using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

namespace CapaNegocio.Interface
{
    interface ICategoria
    {
        //Declaramamos los metodos de la Interface que permitan implementar el CRUD
        DataSet Listar();
        bool Agregar();
        bool Eliminar();
        bool Actualizar();
        DataSet Buscar(string texto, string criterio);
    }
}
