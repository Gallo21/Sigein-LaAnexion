using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS
{
    public class Conexion
    {
        public Conexion() { }

        public SqlConnection getConexion() {

            SqlConnection cnn = new SqlConnection("Data source=RV; Initial Catalog=sigein; Integrated Security=True");

            return cnn;
        }
    }
}
