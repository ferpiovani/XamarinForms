using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;



namespace CCAgenda.DAL
{
    public class DBConn
    {
        public DBConn()
        {
            try
            {
                String AzureConn = "Server=tcp:clinicalappserver.database.windows.net,1433;Initial Catalog=CliniCalApp;Persist Security Info=False;User ID=hellbck;Password=G0lf1nh054t0m1c05;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
                /*
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "<server>.database.windows.net";
                builder.UserID = "<username>";
                builder.Password = "<password>";
                builder.InitialCatalog = "<database>";
                */

                using (SqlConnection connection = new SqlConnection(AzureConn))
                {
                    Console.WriteLine("\nQuery data example:");
                    Console.WriteLine("=========================================\n");

                    connection.Open();
                    StringBuilder sb = new StringBuilder();
                    sb.Append("SELECT * ");
                    sb.Append("FROM Table");
                    String sql = sb.ToString();

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                getName  = reader.GetString(1);
                            }
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public String getName { get; set; }
    }
}
