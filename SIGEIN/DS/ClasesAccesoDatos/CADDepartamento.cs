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
    public class CADDepartamento : IDepartamento
    {
        Conexion conexion = new Conexion();

        public List<string> DesplegarDepartamentos()
        {
            SqlConnection cnn = new SqlConnection("Data source=RV; Initial Catalog=sigein; Integrated Security=True");

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "DesplegarDepartamentos";

            SqlDataReader Lector;
            List<string> lista = new List<string>();
            //List<CONTENEDORES.Departamento> lista = new List<CONTENEDORES.Departamento>();
            //CONTENEDORES.Departamento Temp;
            string Temp;
            cmd.CommandType = CommandType.StoredProcedure;

            if (cnn.State == System.Data.ConnectionState.Closed) cnn.Open();
            Lector = cmd.ExecuteReader();
            while (Lector.Read())
            {

                // Temp = new CONTENEDORES.Departamento();

                //  Temp.nombredepartamento = Lector.GetValue(0).ToString();
                Temp = Lector.GetValue(0).ToString();
                lista.Add(Temp);
            }
            if (cnn.State == System.Data.ConnectionState.Open) cnn.Close();
            return lista;
        }
    }
}
