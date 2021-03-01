using System;
using System.Data.SqlClient;

namespace ADO.NET
{
    class Program
    {
        public const string CONNECTION_STRING = "Server=DESKTOP-LROIRAD\\SQLEXPRESS;Database=ProductsList;User Id=csharp_user;Password=123456;";
        static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection(CONNECTION_STRING);
            RunReadCommand(connection);
        }
        public static void RunReadCommand(SqlConnection connection)
        {
            var read = "select*from Products";
            ReadCommandeExcution(connection, read);
        }
        public static void ReadCommandeExcution(SqlConnection connection, string commandtext)
        {
            connection.Open();
            SqlCommand command = new SqlCommand(commandtext, connection);

            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var id = (int)reader["Id"];
                var title = (string)reader["Title"];
                var price = (decimal)reader["Price"];
                var isAvailable = (Boolean)reader["IsAvailable"];
                var createdOn = (DateTime) reader["CreatedOn"];
                var availabeQuantity = (int)reader["AvaiableQuantity"];
                Console.WriteLine($"Id={id},Title:{title},Price={price},IsAvailable:{isAvailable},CreatedOn:{createdOn},AvailabeQuantity:{availabeQuantity}");
            }

            connection.Close();
            command.Dispose();
            connection.Dispose();
        }
    }
}
