using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CONTENEDORES;
using BS.Interfaces;

namespace BS.Clases
{
    public class BSRepresentanteProveedor : IBSRepresentanteProveedor
    {
        DS.Interfaces.IRepresentanteProveedor cadRepresentanteProveedor = new DS.ClasesAccesoDatos.CADRepresentanteProveedor();

        public void InsertarRepresentanteProveedor(RepresentanteProveedor repProveedor)
        {
            cadRepresentanteProveedor.InsertarRepresentanteProveedor(repProveedor);
        }

        public void ActualizarRepresentanteProveedor(RepresentanteProveedor repProveedor)
        {
            cadRepresentanteProveedor.ActualizarRepresentanteProveedor(repProveedor);
        }

        public void EliminarRepresentanteProveedor(RepresentanteProveedor repProveedor)
        {
            cadRepresentanteProveedor.EliminarRepresentanteProveedor(repProveedor);
        }

        public RepresentanteProveedor BuscarRepresentanteProveedor(RepresentanteProveedor repProveedor)
        {
            return cadRepresentanteProveedor.BuscarRepresentanteProveedor(repProveedor);
        }

        public List<RepresentanteProveedor> ListarRepresentanteProveedores()
        {
            return cadRepresentanteProveedor.ListarRepresentanteProveedores();
        }
    }
}
