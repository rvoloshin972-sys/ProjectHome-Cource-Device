using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectConsApDevice2
{
    public class Microwave : Device
    {
        public int Power { get; set; }
        public int Volume { get; set; }
        public Microwave(string name, int power, int volume)
            : base(name, $"Потужність: {power} Вт, об'єм: {volume} л")
        {
            Power = power;
            Volume = volume;
        }
        public override void Sound()
        {
            Console.WriteLine($"{Name}: звук роботи — дзззз!");
        }
        public override void Show()
        {
            Console.WriteLine($"Мікрохвильовка: {Name}");
        }
        public override void Desc()
        {
            Console.WriteLine($"Потужність: {Power} Вт, об'єм: {Volume} л");
        }

    }
}
