using System;
using ConsApMoneyProduct;

namespace ConsApMoneyProduct
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Money money = new Money(125, 50, "грн");
            Console.WriteLine(" Клас Money ");
            money.Display();

            money.SetWholePart(200);
            money.SetFractionalPart(75);

            Console.WriteLine($"Після зміни суми: {money}");
            Console.WriteLine($"Ціла частина: {money.WholePart}");
            Console.WriteLine($"Копійки: {money.FractionalPart}");

            Console.WriteLine();
            Console.WriteLine(" Клас Product ");

            Product product1 = new Product("Хліб", 35, 50);
            Product product2 = new Product("Молоко", 48, 99);
            Product product3 = new Product("Хліб", 35, 50);

            product1.Display();
            product2.Display();
            product3.Display();

            Console.WriteLine();
            Console.WriteLine(" Зменшення ціни ");

            product1.ReducePrice(5, 25);
            product1.Display();

            Console.WriteLine();
            Console.WriteLine(" Перевірка Equals() ");
            Console.WriteLine($"product1 дорівнює product2: {product1.Equals(product2)}");
            Console.WriteLine($"product2 дорівнює product3: {product2.Equals(product3)}");

            Console.WriteLine(
                $"money дорівнює новому Money(200, 75): " +
                $"{money.Equals(new Money(200, 75, "грн"))}");

            Console.WriteLine();
            Console.WriteLine(" Перевірка GetHashCode() ");
            Console.WriteLine($"Хеш-код money: {money.GetHashCode()}");
            Console.WriteLine($"Хеш-код product1: {product1.GetHashCode()}");
            Console.WriteLine($"Хеш-код product2: {product2.GetHashCode()}");
            Console.WriteLine();
            Console.WriteLine(" Успадкування та поліморфізм ");
            Money[] list =
            {
                money,product1,product2,product3,new Money(500, 0, "грн"),new Product("Телефон", 12500, 99)
            };
            foreach (Money item in list)
            {
                item.Display();
            }
            Console.WriteLine();
            Console.WriteLine(" Порівняння товарів ");
            Console.WriteLine($"Назва товару: {product1.Name}");
            Console.WriteLine($"Ціна товару: {product1}");
            Console.WriteLine();
            Console.WriteLine("Натисніть будь-яку клавішу для завершення...");
            Console.ReadKey();
        }
    }
}
