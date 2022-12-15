using System;
using System.Data.SqlClient;

namespace SqlConnectionADO.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var connection=new SqlConnection("Data Source=DESKTOP-PP0TB7N;" +
                "Initial Catalog=DemoAdoDB;Integrated Security=True"))
            {

                connection.Open();
                Console.WriteLine("Connected");
                insertRows(connection);
                selectRows(connection);
            }
        }

        static public void selectRows(SqlConnection connection)
        {
            using (var command=new SqlCommand())
            {
                command.Connection = connection;
                command.CommandText=@"select * from tblSample";
                SqlDataReader reader = command.ExecuteReader();
                //while (reader.Read())
                //{
                //    Console.WriteLine(reader.GetInt32(0) + " " + reader.GetString(1));
                //}
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(reader["id"]+" "+ reader["Text"]);
                    }
                }

            }
        }

        static public void insertRows(SqlConnection connection)
        {
            SqlParameter parameter;
            using (var command = new SqlCommand())
            {
                command.Connection = connection;
                command.CommandText = @"insert into tblSample values(@Name)";
                parameter = new SqlParameter("@Name",System.Data.SqlDbType.NVarChar);
                parameter.Value = "Kamlesh";
                command.Parameters.Add(parameter);
                command.ExecuteScalar();
            }
        }
    }
}
