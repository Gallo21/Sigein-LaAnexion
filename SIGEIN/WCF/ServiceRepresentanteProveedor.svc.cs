using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using CONTENEDORES;

namespace WCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServiceRepresentanteProveedor" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServiceRepresentanteProveedor.svc o ServiceRepresentanteProveedor.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServiceRepresentanteProveedor : IServiceRepresentanteProveedor
    {
        BS.Interfaces.IBSRepresentanteProveedor bsRepresentanteProveedor = new BS.Clases.BSRepresentanteProveedor();

        public void InsertarRepresentanteProveedor(RepresentanteProveedor repProveedor)
        {
            bsRepresentanteProveedor.InsertarRepresentanteProveedor(repProveedor);
        }

        public void ActualizarRepresentanteProveedor(RepresentanteProveedor repProveedor)
        {
            bsRepresentanteProveedor.ActualizarRepresentanteProveedor(repProveedor);
        }

        public void EliminarRepresentanteProveedor(RepresentanteProveedor repProveedor)
        {
            bsRepresentanteProveedor.EliminarRepresentanteProveedor(repProveedor);
        }

        public RepresentanteProveedor BuscarRepresentanteProveedor(RepresentanteProveedor repProveedor)
        {
            return bsRepresentanteProveedor.BuscarRepresentanteProveedor(repProveedor);
        }

        public List<RepresentanteProveedor> ListarRepresentanteProveedores()
        {
            return bsRepresentanteProveedor.ListarRepresentanteProveedores();
        }
    }
}
