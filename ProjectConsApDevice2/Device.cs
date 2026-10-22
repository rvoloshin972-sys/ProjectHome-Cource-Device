using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectConsApDevice2
{
    public class Device
    {
        public string Name { get; set; }
        public string Characteristics { get; set; }
        public Device(string name, string characteristics) 
        {
            Name = name;
            Characteristics = characteristics;
        }
        public virtual void Sound()
        {
            Console.WriteLine("Пристрій видає звук.");
        }
        public virtual void Show()
        {
            Console.WriteLine($"Назва пристрою: {Name}");
        }
        public virtual void Desc()
        {
            Console.WriteLine($"Характеристики: {Characteristics}");
        }
        public override string ToString()
        {
            return $"Пристрій: {Name}, характеристики: {Characteristics}";
        }
        public override bool Equals(object? obj)
        {
            return obj is Device other
                && GetType() == other.GetType()
                && Name == other.Name
                && Characteristics == other.Characteristics;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(GetType(), Name, Characteristics);
        }
    }
}
