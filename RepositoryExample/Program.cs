﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            IRepository testArray = null;
            Logger.InitLogger();

            Logger.Log.Info("Start application");
            Console.WriteLine("Input 1(if you want use static array) or 2(if you want use DataBase ): ");
            switch (Console.Read())
            {
                case '1':
                    testArray = new ArrayMotorcycleRepository(11);
                    Logger.Log.Info("User chose to static array");
                    break;
                case '2':
                    testArray = new DBMotorcycleRepository();
                    Logger.Log.Info("User chose to DB");
                    break;
            }

            Logger.Log.Info("Create random array");
            RandomMotorcycles(testArray);
            ShowMotorcycle(testArray);

            Guid testGuid = Guid.NewGuid();
            testArray.CreateMotorcycle(new Motorcycle(testGuid, "TestName", "TestModel", 2000, 80));
            ShowMotorcycle(testArray);
            Logger.Log.Info("TestMoto - "+ testGuid.ToString()+"TestName");

            Console.WriteLine(testArray.GetMotorcycleByID(testGuid));

            testArray.DeleteMotorcycle(new Motorcycle(testGuid, "TestName", "TestModel", 2000, 80));
            ShowMotorcycle(testArray);

            if (testArray.GetMotorcycleByID(testGuid) != null)
                Console.WriteLine(testArray.GetMotorcycleByID(testGuid));
            else Console.WriteLine("Motorcycle was not found.");
            Console.ReadKey();
        }
        static void ShowMotorcycle(IRepository testArray)
        {
            IEnumerable<Motorcycle> motorcycles = testArray.GetMotorcycles();
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
            Logger.Log.Info("Start random motorcycles create");
            for (int i = 0; i < 10; i++)
            {
                testArray.CreateMotorcycle(new Motorcycle(Guid.NewGuid(), "Name" + i, "Model" + i, i * 100, i * 10));
            }
            Logger.Log.Info("End random motorcycles create");
        }
    }
}
