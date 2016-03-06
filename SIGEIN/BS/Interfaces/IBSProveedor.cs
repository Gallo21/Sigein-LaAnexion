using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CONTENEDORES;

namespace BS.Interfaces
{
    public interface IBSProveedor
    {
        void InsertarProveedor(CONTENEDORES.Proveedor proveedor);

        void ActualizarProveedor(CONTENEDORES.Proveedor proveedor);

        void EliminarProveedor(CONTENEDORES.Proveedor proveedor);

        CONTENEDORES.Proveedor BuscarProveedor(CONTENEDORES.Proveedor proveedor);

        List<CONTENEDORES.Proveedor> ListarProveedor();

    }
}
