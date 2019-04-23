using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryExample
{
    public class Motorcycle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }

        public int Year { get; set; }
        public int Odometr { get; set; }

        public Motorcycle(int id, string name, string model, int year, int odometr)
        {
            Id = id;
            Name = name;
            Model = model;
            Year = year;
            Odometr = odometr;
        }

        public override bool Equals(object obj)
        {
            return obj is Motorcycle motorcycle &&
                   Id.Equals(motorcycle.Id) &&
                   Name == motorcycle.Name &&
                   Model == motorcycle.Model &&
                   Year == motorcycle.Year &&
                   Odometr == motorcycle.Odometr;
        }

        public override string ToString()
        {
            return $"Id = {Id}, Name = {Name}";
        }
    }
}
