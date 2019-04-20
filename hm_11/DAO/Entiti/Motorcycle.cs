using System;

namespace DAO.Entiti
{
    public class Motorcycle
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }

        public int Year { get; set; }
        public int Odometr { get; set; }

        public Motorcycle(Guid id, string name, string model, int year, int odometr)
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
