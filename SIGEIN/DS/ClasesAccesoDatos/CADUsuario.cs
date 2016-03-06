using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CONTENEDORES;
using DS.Interfaces;
using System.Data.SqlClient;
using System.Data;

namespace DS.ClasesAccesoDatos
{
    public class CADUsuario : IUsuario
    {
        Conexion conexion = new Conexion();
        Usuario conteUsuario = new Usuario();

        public void InsertarUsuario(Usuario usuario)
        {
            SqlConnection cnn = conexion.getConexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "InsertarUsuario";

            cmd.Parameters.Add(new SqlParameter("@IdUsuario", System.Data.SqlDbType.VarChar, 20));
            cmd.Parameters["@IdUsuario"].Value = usuario.idusuario;

            cmd.Parameters.Add(new SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 30));
            cmd.Parameters["@nombre"].Value = usuario.nombreusuario;

            cmd.Parameters.Add(new SqlParameter("@contraseña", System.Data.SqlDbType.VarChar, 50));
            cmd.Parameters["@contraseña"].Value = usuario.contraseña;

            cmd.Parameters.Add(new SqlParameter("@nomDepar", System.Data.SqlDbType.VarChar, 30));
            cmd.Parameters["@nomDepar"].Value = usuario.nombredepartamento;

            cmd.Parameters.Add(new SqlParameter("@ocupacion", System.Data.SqlDbType.VarChar, 30));
            cmd.Parameters["@ocupacion"].Value = usuario.ocupacion;

            cmd.Parameters.Add(new SqlParameter("@ape1", System.Data.SqlDbType.VarChar, 20));
            cmd.Parameters["@ape1"].Value = usuario.apellido1;

            cmd.Parameters.Add(new SqlParameter("@ape2", System.Data.SqlDbType.VarChar, 20));
            cmd.Parameters["@ape2"].Value = usuario.apellido2;

            cmd.Parameters.Add(new SqlParameter("@estatusBloqueo", System.Data.SqlDbType.Bit));
            cmd.Parameters["@estatusBloqueo"].Value = usuario.estatusbloqueo;

            cmd.Parameters.Add(new SqlParameter("@accesoIntrusos", System.Data.SqlDbType.Int));
            cmd.Parameters["@accesoIntrusos"].Value = usuario.accesointrusos;

            cmd.Parameters.Add(new SqlParameter("@email", System.Data.SqlDbType.VarChar, 50));
            cmd.Parameters["@email"].Value = usuario.email;

            cmd.Parameters.Add(new SqlParameter("@telefonoCelular", System.Data.SqlDbType.VarChar, 20));
            cmd.Parameters["@telefonoCelular"].Value = usuario.telefonocelular;


            if (cnn.State == System.Data.ConnectionState.Closed) cnn.Open();
            cmd.ExecuteNonQuery();

            if (cnn.State == System.Data.ConnectionState.Open) cnn.Close();
        }

        public void ActualizarUsuario(Usuario usuario)
        {

            SqlConnection cnn = conexion.getConexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ActualizarUsuario";

            cmd.Parameters.Add(new SqlParameter("@IdUsuario", System.Data.SqlDbType.VarChar, 20));
            cmd.Parameters["@IdUsuario"].Value = usuario.idusuario;

            cmd.Parameters.Add(new SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 30));
            cmd.Parameters["@nombre"].Value = usuario.nombreusuario;

            cmd.Parameters.Add(new SqlParameter("@contraseña", System.Data.SqlDbType.VarChar, 50));
            cmd.Parameters["@contraseña"].Value = usuario.contraseña;

            cmd.Parameters.Add(new SqlParameter("@nomDepar", System.Data.SqlDbType.VarChar, 30));
            cmd.Parameters["@nomDepar"].Value = usuario.nombredepartamento;

            cmd.Parameters.Add(new SqlParameter("@ocupacion", System.Data.SqlDbType.VarChar, 30));
            cmd.Parameters["@ocupacion"].Value = usuario.ocupacion;

            cmd.Parameters.Add(new SqlParameter("@ape1", System.Data.SqlDbType.VarChar, 20));
            cmd.Parameters["@ape1"].Value = usuario.apellido1;

            cmd.Parameters.Add(new SqlParameter("@ape2", System.Data.SqlDbType.VarChar, 20));
            cmd.Parameters["@ape2"].Value = usuario.apellido2;

            cmd.Parameters.Add(new SqlParameter("@estatusBloqueo", System.Data.SqlDbType.Bit));
            cmd.Parameters["@estatusBloqueo"].Value = usuario.estatusbloqueo;

            cmd.Parameters.Add(new SqlParameter("@accesoIntrusos", System.Data.SqlDbType.Int));
            cmd.Parameters["@accesoIntrusos"].Value = usuario.accesointrusos;

            cmd.Parameters.Add(new SqlParameter("@email", System.Data.SqlDbType.VarChar, 50));
            cmd.Parameters["@email"].Value = usuario.email;

            cmd.Parameters.Add(new SqlParameter("@telefonoCelular", System.Data.SqlDbType.VarChar, 20));
            cmd.Parameters["@telefonoCelular"].Value = usuario.telefonocelular;


            if (cnn.State == System.Data.ConnectionState.Closed) cnn.Open();
            cmd.ExecuteNonQuery();

            if (cnn.State == System.Data.ConnectionState.Open) cnn.Close();
        }

        public void EliminarUsuario(Usuario usuario)
        {
            SqlConnection cnn = conexion.getConexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "EliminarUsuario";

            cmd.Parameters.Add(new SqlParameter("@IdUsuario", System.Data.SqlDbType.VarChar, 20));
            cmd.Parameters["@IdUsuario"].Value = usuario.idusuario;


            if (cnn.State == System.Data.ConnectionState.Closed) cnn.Open();
            cmd.ExecuteNonQuery();

            if (cnn.State == System.Data.ConnectionState.Open) cnn.Close();
        }

        public Usuario BuscarUsuario(Usuario usuario)
        {
            SqlConnection cnn = conexion.getConexion();
            SqlDataReader dtr;
            // SqlCommand cmd = new SqlCommand("ConsultarUsuario", cnn);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "BuscarUsuario";

            cmd.Parameters.Add(new SqlParameter("@IdUsuario", System.Data.SqlDbType.VarChar, 30));
            cmd.Parameters["@IdUsuario"].Value = usuario.idusuario;

            if (cnn.State == System.Data.ConnectionState.Closed) cnn.Open();
            dtr = cmd.ExecuteReader();

            if (dtr.HasRows)
            {
                dtr.Read();
                conteUsuario.idusuario = Convert.ToString(dtr[0]);
                conteUsuario.nombreusuario = Convert.ToString(dtr[1]);
                conteUsuario.contraseña = Convert.ToString(dtr[2]);
                conteUsuario.nombredepartamento = Convert.ToString(dtr[3]);
                conteUsuario.ocupacion = Convert.ToString(dtr[4]);
                conteUsuario.apellido1 = Convert.ToString(dtr[5]);
                conteUsuario.apellido2 = Convert.ToString(dtr[6]);
                conteUsuario.estatusbloqueo = Convert.ToInt32(dtr[7]);
                conteUsuario.accesointrusos = Convert.ToInt32(dtr[8]);
                conteUsuario.email = Convert.ToString(dtr[9]);
                conteUsuario.telefonocelular = Convert.ToString(dtr[10]);

            }
            cmd.Parameters.Clear();
            if (cnn.State == System.Data.ConnectionState.Open) cnn.Close();

            return conteUsuario;
        }

        public List<Usuario> ListarUsuario()
        {
            SqlConnection cnn = conexion.getConexion();
            SqlCommand cmd = new SqlCommand("ListarUsuarios", cnn);

            SqlDataReader Lector;
            List<CONTENEDORES.Usuario> lista = new List<CONTENEDORES.Usuario>();
            CONTENEDORES.Usuario Temp;
            cmd.CommandType = CommandType.StoredProcedure;

            if (cnn.State == System.Data.ConnectionState.Closed) cnn.Open();
            Lector = cmd.ExecuteReader();
            while (Lector.Read())
            {
                Temp = new CONTENEDORES.Usuario();
                Temp.idusuario = Lector.GetValue(0).ToString();
                Temp.nombreusuario = Lector.GetValue(1).ToString();
                Temp.contraseña = Lector.GetValue(2).ToString();
                Temp.nombredepartamento = Lector.GetValue(3).ToString();
                Temp.ocupacion = Lector.GetValue(4).ToString();
                Temp.apellido1 = Lector.GetValue(5).ToString();
                Temp.apellido2 = Lector.GetValue(6).ToString();
                Temp.estatusbloqueo = Convert.ToInt32(Lector.GetValue(7));
                Temp.accesointrusos = Convert.ToInt32(Lector.GetValue(8));
                Temp.email = Lector.GetValue(9).ToString();
                Temp.telefonocelular = Lector.GetValue(10).ToString(); 

                lista.Add(Temp);
            }
            if (cnn.State == System.Data.ConnectionState.Open) cnn.Close();
            return lista;
        }

        public Usuario ValidarUsuario(string id, string pass)
        {
            SqlConnection cnn = conexion.getConexion();
            SqlDataReader dtr;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "ValidarUsuario";

            cmd.Parameters.Add(new SqlParameter("@IdUsuario", System.Data.SqlDbType.VarChar, 30));
            cmd.Parameters["@IdUsuario"].Value = id;

            cmd.Parameters.Add(new SqlParameter("@Contraseña", System.Data.SqlDbType.VarChar, 20));
            cmd.Parameters["@Contraseña"].Value = pass;

            if (cnn.State == System.Data.ConnectionState.Closed) cnn.Open();
            dtr = cmd.ExecuteReader();

            if (dtr.HasRows)
            {
                dtr.Read();
                conteUsuario.idusuario = Convert.ToString(dtr[0]);
                conteUsuario.contraseña = Convert.ToString(dtr[1]);
            }

            if (cnn.State == System.Data.ConnectionState.Open) cnn.Close();

            cmd.Parameters.Clear();
            return conteUsuario;
        }
    }
}
