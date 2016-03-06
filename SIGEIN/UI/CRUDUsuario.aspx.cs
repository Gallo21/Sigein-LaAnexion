using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using CONTENEDORES;
using WCF;

namespace UI.CRUDS
{
    public partial class CRUDUsuario : System.Web.UI.Page
    {
        WCF.IServiceDepartamento wcfDepar = new WCF.ServiceDepartamento();
        WCF.IServiceUsuario wcfUsuario = new WCF.ServiceUsuario();
        CONTENEDORES.Usuario contUsuario = new CONTENEDORES.Usuario();
        protected void Page_Load(object sender, EventArgs e)
        {
            // Label9.Text = Session["NombreVariable"].ToString();
            if (!IsPostBack)
            {
                ddlDepartamento.DataSource = wcfDepar.DesplegarDepartamentos();
                ddlDepartamento.DataBind();
                txtDepartamento.Visible = false;
                botonesInicio();
            }
        }

        private void limpiarTXT()
        {
            botonesInicio();
            txtCedula.Text = "";
            txtNombre.Text = "";
            txtContraseña.Text = "";
            txtOcupacion.Text = "";
            txtPrimerApellido.Text = "";
            txtSegundoApellido.Text = "";
            txtCorreoElectronico.Text = "";
            txtTelefonoCelular.Text = "";
            txtDepartamento.Visible = false;
        }

        /*
           Manejo de Botones 
                             */
        private void clickBuscar()
        {
            btnAgregar.Enabled = false;
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
            txtCedula.Enabled = false;
        }

        private void botonesInicio()
        {
            btnAgregar.Enabled = true;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
            txtCedula.Enabled = true;
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            if (validarTXTVacios())
            {
                contUsuario.idusuario = txtCedula.Text;
                contUsuario.nombreusuario = txtNombre.Text;
                contUsuario.contraseña = txtContraseña.Text;
                contUsuario.nombredepartamento = ddlDepartamento.SelectedItem.ToString();
                contUsuario.ocupacion = txtOcupacion.Text;
                contUsuario.apellido1 = txtPrimerApellido.Text;
                contUsuario.apellido2 = txtSegundoApellido.Text;
                contUsuario.estatusbloqueo = 0;
                contUsuario.accesointrusos = 0;
                contUsuario.email = txtCorreoElectronico.Text;
                contUsuario.telefonocelular = txtTelefonoCelular.Text;

                wcfUsuario.InsertarUsuario(contUsuario);
                limpiarTXT();
            }
            else
            {
                Response.Write("<script language=javascript>alert('Campos Incompletos');</script>");
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            if (validarTXTVacios())
            {
                contUsuario.idusuario = txtCedula.Text;
                contUsuario.nombreusuario = txtNombre.Text;
                contUsuario.contraseña = txtContraseña.Text;
                contUsuario.nombredepartamento = ddlDepartamento.SelectedItem.ToString();
                contUsuario.ocupacion = txtOcupacion.Text;
                contUsuario.apellido1 = txtPrimerApellido.Text;
                contUsuario.apellido2 = txtSegundoApellido.Text;
                contUsuario.estatusbloqueo = 0;
                contUsuario.accesointrusos = 0;
                contUsuario.email = txtCorreoElectronico.Text;
                contUsuario.telefonocelular = txtTelefonoCelular.Text;


                wcfUsuario.ActualizarUsuario(contUsuario);
                limpiarTXT();

            }
            else
            {
                Response.Write("<script language=javascript>alert('Campos Incompletos');</script>");
            }
        }   

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtCedula.Text.Length > 0)
            {
                contUsuario.idusuario = txtCedula.Text;

                wcfUsuario.EliminarUsuario(contUsuario);
                limpiarTXT();
            }

            else
            {
                Response.Write("<script language=javascript>alert('Digite la cédula');</script>");
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarTXT();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            contUsuario.idusuario = txtCedula.Text;
            CONTENEDORES.Usuario contUsuario2 = wcfUsuario.BuscarUsuario(contUsuario);
            if (contUsuario2.idusuario == null)
            {
                Response.Write("<script language=javascript>alert('No hay Datos');</script>");
            }
            else
            {
                clickBuscar();

                // UNA.SIGEIN.CONTENEDORES.Usuario contUsuario2 = wcf.BuscarUsuario(contUsuario);

                txtNombre.Text = contUsuario2.nombreusuario;
                txtPrimerApellido.Text = contUsuario2.apellido1;
                txtSegundoApellido.Text = contUsuario2.apellido2;

                txtDepartamento.Visible = true;
                txtDepartamento.Text = contUsuario2.nombredepartamento;
                txtDepartamento.ReadOnly = true;
                txtOcupacion.Text = contUsuario2.ocupacion;
                txtContraseña.Text = contUsuario2.contraseña;
                txtCorreoElectronico.Text = contUsuario2.email;

                txtTelefonoCelular.Text = contUsuario2.telefonocelular;

                //List<string> lista = new List<string>();   
                //lista.Add(contUsuario2.nombredepartamento);

                //DropDownList1.DataSource = wcf.ComboDepartamentos();
                //DropDownList1.DataBind();
                //cmbNomDep.DataSource = lista;
                //cmbNomDep.DataBind();

                //DropDownList1.DataSource = lista;
                //DropDownList1.DataBind();
            }
        }

        protected bool validarTXTVacios()
        {

            if (txtCedula.Text.Length == 0 || txtNombre.Text.Length == 0 || txtPrimerApellido.Text.Length == 0 ||
                txtSegundoApellido.Text.Length == 0 || txtOcupacion.Text.Length == 0 ||
                txtContraseña.Text.Length == 0 || txtCorreoElectronico.Text.Length == 0 || txtTelefonoCelular.Text.Length == 0)
            {
                return false;
            }

            else
            {
                return true;
            }
        }
    }
}