using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleApp
{
    public class ConnectionPooling
    {
        public void DBConnections()
        {
            using (SqlConnection con = new SqlConnection("Data Source=Suresh;Integrated security=SSPI;Initial Catalog=SampleDB"))
            {
                con.Open();
                // Connection Pool A will be created.
            }

            using (SqlConnection con = new SqlConnection("Data Source=Suresh;Integrated security=SSPI;Initial Catalog=aspdotnetDB"))
            {
                con.Open();
                // Separate connection pool B will create because connection string different.
            }

            using (SqlConnection con = new SqlConnection("Data Source=Suresh;Initial Catalog=aspdotnetdb;Pooling=false;"))
            {
                con.Open();
                // No connection pool will create because we defined Pooling = false.
            }

            using (SqlConnection con = new SqlConnection("Data Source=Suresh;Integrated security=SSPI;Initial Catalog=SampleDB"))
            {
                con.Open();
                // This connection string matches with Connection Pool A.
            }
        }
    }
}
