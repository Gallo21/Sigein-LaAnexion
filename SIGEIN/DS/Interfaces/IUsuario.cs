using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CONTENEDORES;




namespace DS.Interfaces
{
    public interface IUsuario
    {
        void InsertarUsuario(CONTENEDORES.Usuario usuario);

        void ActualizarUsuario(CONTENEDORES.Usuario usuario);

        void EliminarUsuario(CONTENEDORES.Usuario usuario);

        CONTENEDORES.Usuario BuscarUsuario(Usuario usuario);

        CONTENEDORES.Usuario ValidarUsuario(string id, string pass);

        List<CONTENEDORES.Usuario> ListarUsuario();

        CONTENEDORES.Usuario ComprobarCaducidad(Usuario usuario);
    }
}
