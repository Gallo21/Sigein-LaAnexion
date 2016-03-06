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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServiceUsuario : IServiceUsuario
    {
        BS.Interfaces.IBSUsuario bsUsuario = new BS.Clases.BSUsuario();

        public void InsertarUsuario(Usuario usuario)
        {
            bsUsuario.InsertarUsuario(usuario);
        }

        public void ActualizarUsuario(Usuario usuario)
        {
            bsUsuario.ActualizarUsuario(usuario);
        }

        public void EliminarUsuario(Usuario usuario)
        {
            bsUsuario.EliminarUsuario(usuario);
        }

        public Usuario BuscarUsuario(Usuario usuario)
        {
            return bsUsuario.BuscarUsuario(usuario);
        }

        public List<Usuario> ListarUsuario()
        {
            return bsUsuario.ListarUsuario();
        }

        public Usuario ValidarUsuario(string id, string pass)
        {
           return bsUsuario.ValidarUsuario(id, pass);
        }
    }
}
