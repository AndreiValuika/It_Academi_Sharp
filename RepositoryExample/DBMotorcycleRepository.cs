using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryExample
{
    class DBMotorcycleRepository : IRepository
    {
        private string connectionString;
        public DBMotorcycleRepository()
        {
            connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Motorcycledb;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                Console.WriteLine("Подключение открыто");
                Console.WriteLine("Свойства подключения:");
                Console.WriteLine("\tСтрока подключения: {0}", connection.ConnectionString);
                Console.WriteLine("\tБаза данных: {0}", connection.Database);
                Console.WriteLine("\tСервер: {0}", connection.DataSource);
            }
        }
        public void CreateMotorcycle(Motorcycle moto)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sqlExpression = $"INSERT INTO Motorcycle (Id, Name,Model,Year,Odometr) " +
                                    $"VALUES ('{moto.Id.ToString()}','{moto.Name}','{moto.Model}',{moto.Year},{moto.Odometr})";
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                int number = command.ExecuteNonQuery();
                Console.WriteLine("Added motorcycles: {0}", number);
            }
        }
        public void DeleteMotorcycle(Motorcycle moto)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open(); 
                string sqlExpression = $"DELETE FROM Motorcycle WHERE Id = '{moto.Id.ToString()}'" ;
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                int number = command.ExecuteNonQuery();
                Console.WriteLine("Deleted motorcycles: {0}", number);
            }
        }

        public Motorcycle GetMotorcycleByID(Guid id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sqlExpression = $"SELECT * FROM Motorcycle WHERE Id = '{id.ToString()}'";
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                using (SqlDataReader dr = command.ExecuteReader())
                {
                    Motorcycle tempMoto = new Motorcycle();
                    while (dr.Read())
                    {
                        tempMoto.Id = Guid.Parse(dr["Id"].ToString().Trim());
                        tempMoto.Name = dr["Name"].ToString();
                        tempMoto.Model = dr["Model"].ToString();
                        tempMoto.Year = (Int32)dr["Year"];
                        tempMoto.Odometr = (int)dr["Odometr"];

                        return tempMoto;
                    }
                    return null;
                }
            }
        }
        public IList<Motorcycle> GetMotorcycles()
        {
            IList<Motorcycle> motorcycles = new List<Motorcycle>();
            string sqlExpression = "SELECT * FROM Motorcycle";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(sqlExpression, connection);
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                       Motorcycle tempMoto = new Motorcycle();

                       tempMoto.Id = Guid.Parse(dr["Id"].ToString().Trim());
                       tempMoto.Name = dr["Name"].ToString();
                       tempMoto.Model = dr["Model"].ToString();
                       tempMoto.Year = (Int32) dr["Year"];
                       tempMoto.Odometr = (int)dr["Odometr"];

                       motorcycles.Add(tempMoto);
                    }
                }
                return motorcycles;
            } 
        }
        public void UpdateMotorcycle(Motorcycle motorcycle)
        {
            throw new NotImplementedException();
        }
    }
}
