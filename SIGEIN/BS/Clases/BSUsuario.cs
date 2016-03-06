using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BS.Interfaces;
using CONTENEDORES;
using DS;

namespace BS.Clases
{
    public class BSUsuario : IBSUsuario
    {
        DS.Interfaces.IUsuario cadUsuario = new DS.ClasesAccesoDatos.CADUsuario();

        public void InsertarUsuario(Usuario usuario)
        {
            cadUsuario.InsertarUsuario(usuario);
        }

        public void ActualizarUsuario(Usuario usuario)
        {
            cadUsuario.ActualizarUsuario(usuario);
        }

        public void EliminarUsuario(Usuario usuario)
        {
            cadUsuario.EliminarUsuario(usuario);
        }

        public Usuario BuscarUsuario(Usuario usuario)
        {
            return cadUsuario.BuscarUsuario(usuario);
        }
        
        public List<Usuario> ListarUsuario()
        {
            return cadUsuario.ListarUsuario();
        }
        
        public Usuario ValidarUsuario(string id, string pass)
        {
            return cadUsuario.ValidarUsuario(id, pass); 
        }
    }
}
