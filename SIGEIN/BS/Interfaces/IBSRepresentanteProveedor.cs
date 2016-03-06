using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CONTENEDORES;

namespace BS.Interfaces
{
    public interface IBSRepresentanteProveedor
    {
        void InsertarRepresentanteProveedor(CONTENEDORES.RepresentanteProveedor repProveedor);

        void ActualizarRepresentanteProveedor(CONTENEDORES.RepresentanteProveedor repProveedor);

        void EliminarRepresentanteProveedor(CONTENEDORES.RepresentanteProveedor repProveedor);

        CONTENEDORES.RepresentanteProveedor BuscarRepresentanteProveedor(CONTENEDORES.RepresentanteProveedor repProveedor);

        List<CONTENEDORES.RepresentanteProveedor> ListarRepresentanteProveedores();
    }
}
