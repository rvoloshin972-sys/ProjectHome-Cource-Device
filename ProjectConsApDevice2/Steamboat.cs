using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectConsApDevice2
{
    public class Steamboat : Device
    {
        public string FuelType { get; set; }
        public int PassengerCapacity { get; set; }
        public Steamboat(string name, string fuelType, int passengerCapacity)
            : base(name,$"Паливо: {fuelType}, пасажиромісткість: {passengerCapacity} осіб")
        {
            FuelType = fuelType;
            PassengerCapacity = passengerCapacity;
        }
        public override void Sound()
        {
            Console.WriteLine($"{Name}: звук пароплава — ту-ту!");
        }
        public override void Show()
        {
            Console.WriteLine($"Пароплав: {Name}");
        }
        public override void Desc()
        {
            Console.WriteLine($"Паливо: {FuelType}, пасажиромісткість: {PassengerCapacity} осіб");
        }
    }
}
