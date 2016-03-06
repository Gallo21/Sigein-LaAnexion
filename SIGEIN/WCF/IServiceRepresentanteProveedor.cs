using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServiceRepresentanteProveedor" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServiceRepresentanteProveedor
    {
        [OperationContract]
        void InsertarRepresentanteProveedor(CONTENEDORES.RepresentanteProveedor repProveedor);

        [OperationContract]
        void ActualizarRepresentanteProveedor(CONTENEDORES.RepresentanteProveedor repProveedor);

        [OperationContract]
        void EliminarRepresentanteProveedor(CONTENEDORES.RepresentanteProveedor repProveedor);

        [OperationContract]
        CONTENEDORES.RepresentanteProveedor BuscarRepresentanteProveedor(CONTENEDORES.RepresentanteProveedor repProveedor);

        [OperationContract]
        List<CONTENEDORES.RepresentanteProveedor> ListarRepresentanteProveedores();

    }
}
