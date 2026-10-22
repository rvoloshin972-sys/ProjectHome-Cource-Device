using System;
using System.Text;

namespace ProjectConsApDevice2
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Device kettle = new Kettle("Bosch", 2200, 1.7);
            Device microwave = new Microwave("Samsung", 1000, 23);
            Device car = new Car("Camry", "Toyota", 2022, 220);
            Device steamboat = new Steamboat("Україна", "Вугілля", 300);

            Console.WriteLine(" МЕТОД SHOW ");
            kettle.Show();
            microwave.Show();
            car.Show();
            steamboat.Show();

            Console.WriteLine("\n МЕТОД DESC ");
            kettle.Desc();
            microwave.Desc();
            car.Desc();
            steamboat.Desc();

            Console.WriteLine("\n МЕТОД SOUND ");
            kettle.Sound();
            microwave.Sound();
            car.Sound();
            steamboat.Sound();

            Console.WriteLine("\n МЕТОД ToString() ");
            Console.WriteLine(kettle);
            Console.WriteLine(microwave);
            Console.WriteLine(car);
            Console.WriteLine(steamboat);

            Console.WriteLine("\n МАСИВ ПРИСТРОЇВ ");

            Device[] devices =
            {
                kettle,microwave,car,steamboat,new Kettle("Bosch", 2200, 1.7)
            };

            foreach (Device device in devices)
            {
                device.Show();
                device.Desc();
                device.Sound();
                Console.WriteLine();
            }

            Console.WriteLine(" Equals() ");
            Console.WriteLine($"Перший і п'ятий пристрої однакові: {devices[0].Equals(devices[4])}");
            Console.WriteLine($"Перший і другий пристрої однакові: {devices[0].Equals(devices[1])}");
            Console.WriteLine("\n GetHashCode() ");

            Console.WriteLine($"Чайник: {kettle.GetHashCode()}");
            Console.WriteLine($"Мікрохвильовка: {microwave.GetHashCode()}");
            Console.WriteLine($"Автомобіль: {car.GetHashCode()}");
            Console.WriteLine($"Пароплав: {steamboat.GetHashCode()}");

            Console.WriteLine("\n ToString() ДЛЯ МАСИВУ ");
            foreach (Device device in devices)
            {
                Console.WriteLine(device.ToString());
            }
            Console.WriteLine("\nНатисніть будь-яку клавішу для завершення...");
            Console.ReadKey();
        }
    }
}
