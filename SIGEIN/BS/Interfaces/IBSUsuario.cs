using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CONTENEDORES;


namespace BS.Interfaces
{
    public interface IBSUsuario
    {
        void InsertarUsuario(CONTENEDORES.Usuario usuario);

        void ActualizarUsuario(CONTENEDORES.Usuario usuario);

        void EliminarUsuario(CONTENEDORES.Usuario usuario);

        CONTENEDORES.Usuario BuscarUsuario(Usuario usuario);

        List<CONTENEDORES.Usuario> ListarUsuario();

        CONTENEDORES.Usuario ValidarUsuario(string id, string pass);
    }
}
