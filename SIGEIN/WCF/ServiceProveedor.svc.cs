using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using CONTENEDORES;

namespace WCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServiceProveedor" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServiceProveedor.svc o ServiceProveedor.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServiceProveedor : IServiceProveedor
    {
        BS.Interfaces.IBSTecnico bsTecnico = new BS.Clases.BSTecnico();
        public void InsertarProveedor(Proveedor proveedor)
        {
            throw new NotImplementedException();
        }

        public void ActualizarProveedor(Proveedor proveedor)
        {
            throw new NotImplementedException();
        }

        public void EliminarProveedor(Proveedor proveedor)
        {
            throw new NotImplementedException();
        }

        public Proveedor BuscarProveedor(Proveedor proveedor)
        {
            throw new NotImplementedException();
        }
   
        public List<Proveedor> ListarProveedores()
        {
            throw new NotImplementedException();
        }
    }
}
