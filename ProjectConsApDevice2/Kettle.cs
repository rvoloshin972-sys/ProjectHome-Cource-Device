using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectConsApDevice2
{
    public class Kettle : Device
    {
        public int Power { get; set; }
        public double Volume { get; set; }
        public Kettle(string name, int power, double volume)
            : base(name, $"Потужність: {power} Вт, об'єм: {volume} л")
        {
            Power = power;
            Volume = volume;
        }
        public override void Sound()
        {
            Console.WriteLine($"{Name}: звук кипіння води — буль-буль!");
        }
        public override void Show()
        {
            Console.WriteLine($"Чайник: {Name}");
        }
        public override void Desc()
        {
            Console.WriteLine($"Потужність: {Power} Вт, об'єм: {Volume} л");
        }
    }
}
