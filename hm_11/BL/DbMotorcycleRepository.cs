using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using DAO.Entity;

namespace DAL
{
    class DbMotorcycleRepository : IRepository
    {
        public DbMotorcycleRepository()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            Console.WriteLine(connectionString);

            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                // Открываем подключение
                connection.Open();
                Console.WriteLine("Подключение открыто");
                Console.WriteLine("Свойства подключения:");
                Console.WriteLine("\tСтрока подключения: {0}", connection.ConnectionString);
                Console.WriteLine("\tБаза данных: {0}", connection.Database);
                Console.WriteLine("\tСервер: {0}", connection.DataSource);
                Console.WriteLine("\tВерсия сервера: {0}", connection.ServerVersion);
                Console.WriteLine("\tСостояние: {0}", connection.State);
                Console.WriteLine("\tWorkstationld: {0}", connection.WorkstationId);


                Motorcycle moto = new Motorcycle();
                moto.Id = Guid.NewGuid();
                moto.Name = "Minsk";
                moto.Model = "KX1204";
                moto.Year = 2010;
                moto.Odometr = 100;
                Console.WriteLine(moto.Id.ToString());
                string st = moto.Id.ToString();

                Console.WriteLine("----------------------");
                string sqlExpression = $"INSERT INTO Motorcycle (Id, Name,Model,Year,Odometr) " +
                    $"VALUES ('{moto.Id.ToString()}','{moto.Name}','{moto.Model}',{moto.Year},{moto.Odometr})";
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                int number = command.ExecuteNonQuery();
                Console.WriteLine("Добавлено объектов: {0}", number);
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // закрываем подключение
                connection.Close();
                Console.WriteLine("Подключение закрыто...");
                //  Console.Read();
            }
        }
        public void CreateMotorcycle(Motorcycle motorcycle)
        {
            throw new NotImplementedException();
        }

        public void DeleteMotorcycle(Motorcycle motorcycle)
        {
            throw new NotImplementedException();
        }

        public Motorcycle GetMotorcycleByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Motorcycle> GetMotorcycles()
        {
            throw new NotImplementedException();
        }

        public void UpdateMotorcycle(Motorcycle motorcycle)
        {
            throw new NotImplementedException();
        }
    }
}
