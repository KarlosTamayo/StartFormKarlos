using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class Conexion
    {
        public DataSet con(string cmd)
        {
            SqlConnection Conexion = new SqlConnection("Data Source=.;Initial Catalog=Administracion;Integrated Security=True");
            Conexion.Close();
            DataSet DS = new DataSet();
            SqlDataAdapter DA = new SqlDataAdapter(cmd, Conexion);
            DA.Fill(DS);            
            return (DS);

        }
    }
}
