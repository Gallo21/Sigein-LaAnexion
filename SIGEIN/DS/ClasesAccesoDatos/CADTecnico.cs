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
    public class CADTecnico : ITecnico
    {
        Conexion conexion = new Conexion();
        Tecnico conteTecnico = new Tecnico();

        public void InsertarTecnico(Tecnico tecnico)
        {
            SqlConnection cnn = conexion.getConexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "InsertarTecnico";

            cmd.Parameters.Add(new SqlParameter("@idTec", System.Data.SqlDbType.VarChar, 20));
            cmd.Parameters["@idTec"].Value = tecnico.idtecnico;

            cmd.Parameters.Add(new SqlParameter("@nomTec", System.Data.SqlDbType.VarChar, 30));
            cmd.Parameters["@nomTec"].Value = tecnico.nombretecnico;

            cmd.Parameters.Add(new SqlParameter("@ape1", System.Data.SqlDbType.VarChar, 20));
            cmd.Parameters["@ape1"].Value = tecnico.apellido1;

            cmd.Parameters.Add(new SqlParameter("@ape2", System.Data.SqlDbType.VarChar, 20));
            cmd.Parameters["@ape2"].Value = tecnico.apellido2;

            cmd.Parameters.Add(new SqlParameter("@email", System.Data.SqlDbType.VarChar, 50));
            cmd.Parameters["@email"].Value = tecnico.email;

            cmd.Parameters.Add(new SqlParameter("@cel", System.Data.SqlDbType.VarChar, 20));
            cmd.Parameters["@cel"].Value = tecnico.telefonocelular;

            if (cnn.State == System.Data.ConnectionState.Closed) cnn.Open();
            cmd.ExecuteNonQuery();

            if (cnn.State == System.Data.ConnectionState.Open) cnn.Close();

        }

        public void ActualizarTecnico(Tecnico tecnico)
        {
            SqlConnection cnn = conexion.getConexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ActualizarTecnico";

            cmd.Parameters.Add(new SqlParameter("@idTec", System.Data.SqlDbType.VarChar, 20));
            cmd.Parameters["@idTec"].Value = tecnico.idtecnico;

            cmd.Parameters.Add(new SqlParameter("@nomTec", System.Data.SqlDbType.VarChar, 30));
            cmd.Parameters["@nomTec"].Value = tecnico.nombretecnico;

            cmd.Parameters.Add(new SqlParameter("@ape1", System.Data.SqlDbType.VarChar, 20));
            cmd.Parameters["@ape1"].Value = tecnico.apellido1;

            cmd.Parameters.Add(new SqlParameter("@ape2", System.Data.SqlDbType.VarChar, 20));
            cmd.Parameters["@ape2"].Value = tecnico.apellido2;

            cmd.Parameters.Add(new SqlParameter("@email", System.Data.SqlDbType.VarChar, 50));
            cmd.Parameters["@email"].Value = tecnico.email;

            cmd.Parameters.Add(new SqlParameter("@cel", System.Data.SqlDbType.VarChar, 20));
            cmd.Parameters["@cel"].Value = tecnico.telefonocelular;

            if (cnn.State == System.Data.ConnectionState.Closed) cnn.Open();
            cmd.ExecuteNonQuery();

            if (cnn.State == System.Data.ConnectionState.Open) cnn.Close();
        }

        public void EliminarTecnico(Tecnico tecnico)
        {
            SqlConnection cnn = conexion.getConexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "EliminarTecnico";

            cmd.Parameters.Add(new SqlParameter("@idTec", System.Data.SqlDbType.VarChar, 20));
            cmd.Parameters["@idTec"].Value = tecnico.idtecnico;

            if (cnn.State == System.Data.ConnectionState.Closed) cnn.Open();
            cmd.ExecuteNonQuery();

            if (cnn.State == System.Data.ConnectionState.Open) cnn.Close();

        }

        public Tecnico BuscarTecnico(Tecnico tecnico)
        {
            SqlConnection cnn = conexion.getConexion();
            SqlDataReader dtr;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "BuscarTecnico";

            cmd.Parameters.Add(new SqlParameter("@idTec", System.Data.SqlDbType.VarChar, 20));
            cmd.Parameters["@idTec"].Value = tecnico.idtecnico;

            if (cnn.State == System.Data.ConnectionState.Closed) cnn.Open();
            dtr = cmd.ExecuteReader();

            if (dtr.HasRows)
            {
                dtr.Read();
                conteTecnico.idtecnico = Convert.ToString(dtr[0]);
                conteTecnico.nombretecnico = Convert.ToString(dtr[1]);
                conteTecnico.apellido1 = Convert.ToString(dtr[2]);
                conteTecnico.apellido2 = Convert.ToString(dtr[3]);
                conteTecnico.email = Convert.ToString(dtr[4]);
                conteTecnico.telefonocelular = Convert.ToString(dtr[5]);
            }

            if (cnn.State == System.Data.ConnectionState.Open) cnn.Close();
            return conteTecnico;

        }

        public List<Tecnico> ListarTecnicos()
        {
            SqlConnection cnn = conexion.getConexion();
            SqlDataReader dtr;
            List<CONTENEDORES.Tecnico> lista = new List<CONTENEDORES.Tecnico>();
            CONTENEDORES.Tecnico temp;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ListarTecnicos";

            if (cnn.State == System.Data.ConnectionState.Closed) cnn.Open();
            dtr = cmd.ExecuteReader();
            while (dtr.Read())
            {
                temp = new CONTENEDORES.Tecnico();
                temp.idtecnico = dtr.GetValue(0).ToString();
                temp.nombretecnico = dtr.GetValue(1).ToString();
                temp.apellido1 = dtr.GetValue(2).ToString();
                temp.apellido2 = dtr.GetValue(3).ToString();
                temp.email = dtr.GetValue(4).ToString();
                temp.telefonocelular = dtr.GetValue(5).ToString();

                lista.Add(temp);
            }

            if (cnn.State == System.Data.ConnectionState.Open) cnn.Close();
            return lista;

        }
    }
}
