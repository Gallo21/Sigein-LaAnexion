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
    public class CADRepresentanteProveedor : IRepresentanteProveedor
    {
        Conexion conexion = new Conexion();
        RepresentanteProveedor conteRepreProve = new RepresentanteProveedor();

        public void InsertarRepresentanteProveedor(RepresentanteProveedor repProveedor)
        {
            SqlConnection cnn = conexion.getConexion();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "AgregarRepresentanteProveedor";

            cmd.Parameters.Add(new SqlParameter("@IdRProvee", System.Data.SqlDbType.VarChar, 15));
            cmd.Parameters["@IdRProvee"].Value = repProveedor.IdRProvee;

            cmd.Parameters.Add(new SqlParameter("@Cedjuridica", System.Data.SqlDbType.VarChar, 20));
            cmd.Parameters["@Cedjuridica"].Value = repProveedor.Cedjuridica;

            cmd.Parameters.Add(new SqlParameter("@Nom", System.Data.SqlDbType.VarChar, 30));
            cmd.Parameters["@Nom"].Value = repProveedor.Nom;

            cmd.Parameters.Add(new SqlParameter("@Ape1", System.Data.SqlDbType.VarChar, 20));
            cmd.Parameters["@Ape1"].Value = repProveedor.Ape1;

            cmd.Parameters.Add(new SqlParameter("@Ape2", System.Data.SqlDbType.VarChar, 20));
            cmd.Parameters["@Ape2"].Value = repProveedor.Ape2;

            cmd.Parameters.Add(new SqlParameter("@email", System.Data.SqlDbType.VarChar, 50));
            cmd.Parameters["@email"].Value = repProveedor.email;

            cmd.Parameters.Add(new SqlParameter("@TCelular", System.Data.SqlDbType.VarChar, 20));
            cmd.Parameters["@TCelular"].Value = repProveedor.TCelular;

            if (cnn.State == System.Data.ConnectionState.Closed) cnn.Open();
            cmd.ExecuteNonQuery();

            if (cnn.State == System.Data.ConnectionState.Open) cnn.Close();

        }

        public void ActualizarRepresentanteProveedor(RepresentanteProveedor repProveedor)
        {
            SqlConnection cnn = conexion.getConexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ModificarRepresentanteProveedor";

            cmd.Parameters.Add(new SqlParameter("@IdRProvee", System.Data.SqlDbType.VarChar, 15));
            cmd.Parameters["@IdRProvee"].Value = repProveedor.IdRProvee;

            cmd.Parameters.Add(new SqlParameter("@Cedjuridica", System.Data.SqlDbType.VarChar, 20));
            cmd.Parameters["@Cedjuridica"].Value = repProveedor.Cedjuridica;

            cmd.Parameters.Add(new SqlParameter("@Nom", System.Data.SqlDbType.VarChar, 30));
            cmd.Parameters["@Nom"].Value = repProveedor.Nom;

            cmd.Parameters.Add(new SqlParameter("@Ape1", System.Data.SqlDbType.VarChar, 20));
            cmd.Parameters["@Ape1"].Value = repProveedor.Ape1;

            cmd.Parameters.Add(new SqlParameter("@Ape2", System.Data.SqlDbType.VarChar, 20));
            cmd.Parameters["@Ape2"].Value = repProveedor.Ape2;

            cmd.Parameters.Add(new SqlParameter("@email", System.Data.SqlDbType.VarChar, 50));
            cmd.Parameters["@email"].Value = repProveedor.email;

            cmd.Parameters.Add(new SqlParameter("@TCelular", System.Data.SqlDbType.VarChar, 20));
            cmd.Parameters["@TCelular"].Value = repProveedor.TCelular;

            if (cnn.State == System.Data.ConnectionState.Closed) cnn.Open();
            cmd.ExecuteNonQuery();

            if (cnn.State == System.Data.ConnectionState.Open) cnn.Close();

        }

        public void EliminarRepresentanteProveedor(RepresentanteProveedor repProveedor)
        {
            SqlConnection cnn = conexion.getConexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "EliminarRepresentanteProveedor";

            cmd.Parameters.Add(new SqlParameter("@IdRProvee", System.Data.SqlDbType.VarChar, 15));
            cmd.Parameters["@IdRProvee"].Value = repProveedor.IdRProvee;

            if (cnn.State == System.Data.ConnectionState.Closed) cnn.Open();
            cmd.ExecuteNonQuery();

            if (cnn.State == System.Data.ConnectionState.Open) cnn.Close();
        }

        public RepresentanteProveedor BuscarRepresentanteProveedor(RepresentanteProveedor repProveedor)
        {
            SqlConnection cnn = conexion.getConexion();

            SqlDataReader dtr;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ConsultarRepresentanteProveedor";

            cmd.Parameters.Add(new SqlParameter("@IdRProvee", System.Data.SqlDbType.VarChar, 15));
            cmd.Parameters["@IdRProvee"].Value = repProveedor.IdRProvee;

            if (cnn.State == System.Data.ConnectionState.Closed) cnn.Open();
            dtr = cmd.ExecuteReader();

            if (dtr.HasRows)
            {
                dtr.Read();
                conteRepreProve.IdRProvee = Convert.ToString(dtr[0]);
                conteRepreProve.Cedjuridica = Convert.ToString(dtr[1]);
                conteRepreProve.Nom = Convert.ToString(dtr[2]);
                conteRepreProve.Ape1 = Convert.ToString(dtr[3]);
                conteRepreProve.Ape2 = Convert.ToString(dtr[4]);
                conteRepreProve.email = Convert.ToString(dtr[5]);
                conteRepreProve.TCelular = Convert.ToString(dtr[6]);
            }
            if (cnn.State == System.Data.ConnectionState.Open) cnn.Close();
            cmd.Parameters.Clear();

            return conteRepreProve;

        }

        public List<RepresentanteProveedor> ListarRepresentanteProveedores()
        {
            SqlConnection cnn = conexion.getConexion();
            SqlCommand cmd = new SqlCommand("ConsultarRepresentantesProvedores", cnn);

            SqlDataReader Lector;
            List<CONTENEDORES.RepresentanteProveedor> lista = new List<CONTENEDORES.RepresentanteProveedor>();
            CONTENEDORES.RepresentanteProveedor Temp;
            cmd.CommandType = CommandType.StoredProcedure;

            if (cnn.State == System.Data.ConnectionState.Closed) cnn.Open();
            Lector = cmd.ExecuteReader();
            while (Lector.Read())
            {
                Temp = new CONTENEDORES.RepresentanteProveedor();
                Temp.IdRProvee = Lector.GetValue(0).ToString();
                Temp.Cedjuridica = Lector.GetValue(1).ToString();
                Temp.Nom = Lector.GetValue(2).ToString();
                Temp.Ape1 = Lector.GetValue(3).ToString();
                Temp.Ape2 = Lector.GetValue(4).ToString();
                Temp.email = Lector.GetValue(5).ToString();
                Temp.TCelular = Lector.GetValue(6).ToString();

                lista.Add(Temp);
            }
            if (cnn.State == System.Data.ConnectionState.Open) cnn.Close();
            return lista;

        }

       
       
    }
}
