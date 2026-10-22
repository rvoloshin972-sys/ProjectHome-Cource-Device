using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectConsApDevice2
{
    public class Car : Device
    {
        public string Brand { get; set; }
        public int Year { get; set; }
        public int MaxSpeed { get; set; }
        public Car(string name, string brand, int year, int maxSpeed)
            : base(name,$"Марка: {brand}, рік випуску: {year}, максимальна швидкість: {maxSpeed} км/год")
        {
            Brand = brand;
            Year = year;
            MaxSpeed = maxSpeed;
        }
        public override void Sound()
        {
            Console.WriteLine($"{Name}: звук автомобіля — бі-бі!");
        }
        public override void Show()
        {
            Console.WriteLine($"Автомобіль: {Name}");
        }
        public override void Desc()
        {
            Console.WriteLine($"Марка: {Brand}, рік випуску: {Year}, максимальна швидкість: {MaxSpeed} км/год");
        }
    }
}
