using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CONTENEDORES;
using BS.Interfaces;

namespace BS.Clases
{
    public class BSProveedor : IBSProveedor
    {
        DS.Interfaces.IProveedor cadProveedor = new DS.ClasesAccesoDatos.CADProveedor();

        public void InsertarProveedor(Proveedor proveedor)
        {
            cadProveedor.InsertarProveedor(proveedor);
        }
        public void ActualizarProveedor(Proveedor proveedor)
        {
            cadProveedor.ActualizarProveedor(proveedor);
        }

        public void EliminarProveedor(Proveedor proveedor)
        {
            cadProveedor.EliminarProveedor(proveedor);
        }
        public Proveedor BuscarProveedor(Proveedor proveedor)
        {
            return cadProveedor.BuscarProveedor(proveedor);
        }

        public List<Proveedor> ListarProveedor()
        {
            return cadProveedor.ListarProveedor();
        }
    }
}
