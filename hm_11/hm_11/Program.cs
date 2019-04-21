

using DAL;
using DAO.Entiti;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm_11
{
    class Program
    {
        static void Main(string[] args)
        {

            IRepository testArray = new ArrayMotorcycleRepository(10);

            RandomMotorcycles(testArray);

            ShowMotorcycle(testArray);

            testArray.DeleteMotorcycle(new Motorcycle(1, "Name1", "Model1", 100, 10));

            ShowMotorcycle(testArray);

            testArray.CreateMotorcycle(new Motorcycle(11, "Name11", "Model11", 2,8));

            ShowMotorcycle(testArray);

            Console.WriteLine(testArray.GetMotorcycleByID(4));
            Console.ReadKey();
        }

        static void ShowMotorcycle(IRepository testArray)
        {
            List<Motorcycle> motorcycles = testArray.GetMotorcycles();
            Console.WriteLine("---------------------------");
            foreach (var moto in motorcycles)
            {
                Console.WriteLine(moto);
            }
            Console.WriteLine("---------------------------");
            Console.WriteLine("Press any key");
            Console.ReadKey();
        }

        static void RandomMotorcycles(IRepository testArray)
        {
            for (int i = 0; i < 10; i++)
            {
                testArray.CreateMotorcycle(new Motorcycle(i, "Name" + i, "Model" + i, i * 100, i * 10));
            }
        } 
    }
}
