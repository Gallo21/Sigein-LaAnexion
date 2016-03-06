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
    public class CADProveedor : IProveedor
    {
        Conexion conexion = new Conexion();
        Proveedor conteProve = new Proveedor();

        public void InsertarProveedor(Proveedor proveedor)
        {
            SqlConnection cnn = conexion.getConexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "AgregarProveedor";

            cmd.Parameters.Add(new SqlParameter("@CedJuridica", System.Data.SqlDbType.VarChar, 20));
            cmd.Parameters["@CedJuridica"].Value = proveedor.cedJuri;

            cmd.Parameters.Add(new SqlParameter("@NomEmpresa", System.Data.SqlDbType.VarChar, 30));
            cmd.Parameters["@NomEmpresa"].Value = proveedor.NomEmpresa;

            cmd.Parameters.Add(new SqlParameter("@DesEmpresa", System.Data.SqlDbType.VarChar, 200));
            cmd.Parameters["@DesEmpresa"].Value = proveedor.DesEmpresa;

            cmd.Parameters.Add(new SqlParameter("@Telefono", System.Data.SqlDbType.VarChar, 20));
            cmd.Parameters["@Telefono"].Value = proveedor.Tel;

            cmd.Parameters.Add(new SqlParameter("@SitioW", System.Data.SqlDbType.VarChar, 50));
            cmd.Parameters["@SitioW"].Value = proveedor.sitio;


            if (cnn.State == System.Data.ConnectionState.Closed) cnn.Open();
            cmd.ExecuteNonQuery();

            if (cnn.State == System.Data.ConnectionState.Open) cnn.Close();

        }

        public void ActualizarProveedor(Proveedor proveedor)
        {
            SqlConnection cnn = conexion.getConexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ModificarProveedor";

            cmd.Parameters.Add(new SqlParameter("@CedJuridica", System.Data.SqlDbType.VarChar, 20));
            cmd.Parameters["@CedJuridica"].Value = proveedor.cedJuri;

            cmd.Parameters.Add(new SqlParameter("@NomEmpresa", System.Data.SqlDbType.VarChar, 30));
            cmd.Parameters["@NomEmpresa"].Value = proveedor.NomEmpresa;

            cmd.Parameters.Add(new SqlParameter("@DesEmpresa", System.Data.SqlDbType.VarChar, 200));
            cmd.Parameters["@DesEmpresa"].Value = proveedor.DesEmpresa;

            cmd.Parameters.Add(new SqlParameter("@Telefono", System.Data.SqlDbType.VarChar, 20));
            cmd.Parameters["@Telefono"].Value = proveedor.Tel;

            cmd.Parameters.Add(new SqlParameter("@SitioW", System.Data.SqlDbType.VarChar, 50));
            cmd.Parameters["@SitioW"].Value = proveedor.sitio;


            if (cnn.State == System.Data.ConnectionState.Closed) cnn.Open();
            cmd.ExecuteNonQuery();

            if (cnn.State == System.Data.ConnectionState.Open) cnn.Close();

        }

        public void EliminarProveedor(Proveedor proveedor)
        {
            SqlConnection cnn = conexion.getConexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "EliminarProveedor";

            cmd.Parameters.Add(new SqlParameter("@CedJuridica", System.Data.SqlDbType.VarChar, 30));
            cmd.Parameters["@CedJuridica"].Value = proveedor.cedJuri;

            if (cnn.State == System.Data.ConnectionState.Closed) cnn.Open();
            cmd.ExecuteNonQuery();

            if (cnn.State == System.Data.ConnectionState.Open) cnn.Close();

        }

        public Proveedor BuscarProveedor(Proveedor proveedor)
        {
            SqlConnection cnn = conexion.getConexion();
            SqlDataReader dtr;
            // SqlCommand cmd = new SqlCommand("ConsultarUsuario", cnn);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ConsultarProveedor";

            cmd.Parameters.Add(new SqlParameter("@CedJuridica", System.Data.SqlDbType.VarChar, 20));
            cmd.Parameters["@CedJuridica"].Value = proveedor.cedJuri;

            if (cnn.State == System.Data.ConnectionState.Closed) cnn.Open();
            dtr = cmd.ExecuteReader();

            if (dtr.HasRows)
            {
                dtr.Read();
                conteProve.cedJuri = Convert.ToString(dtr[0]);
                conteProve.NomEmpresa = Convert.ToString(dtr[1]);
                conteProve.DesEmpresa = Convert.ToString(dtr[2]);
                conteProve.Tel = Convert.ToString(dtr[3]);
                conteProve.sitio = Convert.ToString(dtr[4]);
            }
            cmd.Parameters.Clear();
            if (cnn.State == System.Data.ConnectionState.Open) cnn.Close();

            return conteProve;
        }

        public List<Proveedor> ListarProveedor()
        {
            SqlConnection cnn = conexion.getConexion();

            SqlCommand cmd = new SqlCommand("ConsultarUsuarios", cnn);

            SqlDataReader Lector;
            List<CONTENEDORES.Proveedor> lista = new List<CONTENEDORES.Proveedor>();
            CONTENEDORES.Proveedor Temp;
            cmd.CommandType = CommandType.StoredProcedure;

            if (cnn.State == System.Data.ConnectionState.Closed) cnn.Open();
            Lector = cmd.ExecuteReader();
            while (Lector.Read())
            {
                Temp = new CONTENEDORES.Proveedor();
                Temp.cedJuri = Lector.GetValue(0).ToString();
                Temp.NomEmpresa = Lector.GetValue(1).ToString();
                Temp.DesEmpresa = Lector.GetValue(2).ToString();
                Temp.Tel = Lector.GetValue(3).ToString();
                Temp.sitio = Lector.GetValue(4).ToString();


                lista.Add(Temp);
            }
            if (cnn.State == System.Data.ConnectionState.Open) cnn.Close();
            return lista;


        }
    }
}
