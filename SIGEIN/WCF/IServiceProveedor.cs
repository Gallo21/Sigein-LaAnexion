using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using CONTENEDORES;

namespace WCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServiceProveedor" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServiceProveedor
    {
        [OperationContract]
        void InsertarProveedor(CONTENEDORES.Proveedor proveedor);

        [OperationContract]
        void ActualizarProveedor(CONTENEDORES.Proveedor proveedor);

        [OperationContract]
        void EliminarProveedor(CONTENEDORES.Proveedor proveedor);

        [OperationContract]
        Proveedor BuscarProveedor(Proveedor proveedor);

        [OperationContract]
        List<CONTENEDORES.Proveedor> ListarProveedores();

    }
}
