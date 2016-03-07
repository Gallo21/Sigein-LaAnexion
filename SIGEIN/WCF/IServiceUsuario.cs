using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using CONTENEDORES;

namespace WCF
{
    [ServiceContract]
    public interface IServiceUsuario
    {
        [OperationContract]
        void InsertarUsuario(Usuario usuario);

        [OperationContract]
        void ActualizarUsuario(CONTENEDORES.Usuario usuario);

        [OperationContract]
        void EliminarUsuario(CONTENEDORES.Usuario usuario);

        [OperationContract]
        Usuario BuscarUsuario(Usuario usuario);

        [OperationContract]
        List<CONTENEDORES.Usuario> ListarUsuario();

        [OperationContract]
        CONTENEDORES.Usuario ValidarUsuario(string id, string pass);

        [OperationContract]
        Usuario ComprobarCaducidad(Usuario usuario);
    }
}
