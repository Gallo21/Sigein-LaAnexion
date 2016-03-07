using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI
{
    public partial class LoginUsuario : System.Web.UI.Page
    {

        WCF.IServiceUsuario wcf = new WCF.ServiceUsuario();
        CONTENEDORES.Usuario contUsuario = new CONTENEDORES.Usuario();
        CONTENEDORES.Usuario contUsuario2 = new CONTENEDORES.Usuario();
        CONTENEDORES.Usuario contUsuario3 = new CONTENEDORES.Usuario();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {

            contUsuario = wcf.ValidarUsuario(Login1.UserName, Login1.Password);
            
            if (contUsuario.idusuario != null)
            {
                contUsuario2.idusuario = Login1.UserName;
                contUsuario3 = wcf.ComprobarCaducidad(contUsuario2);
                Session["IdUsuario"] = Login1.UserName;

                if (contUsuario3.caducidadcontraseña == DateTime.Now.Date)
                {
                    Response.Redirect("CambioContra.aspx");
                }
                
                else
                {
                    Response.Redirect("CRUDUsuario.aspx");
                }
            }
        }
    }
}