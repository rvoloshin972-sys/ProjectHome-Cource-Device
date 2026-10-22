using ConsApMoneyProduct;
using System;

namespace ConsApMoneyProduct
{
    public class Product : Money
    {
        public string Name { get; set; }
        public Product()
        {
            Name = "Без назви";
        }
        public Product(string name,int wholePart,int fractionalPart,string currency = "грн")
            : base(wholePart, fractionalPart, currency)
        {
            Name = name;
        }
        public void ReducePrice(int wholePart, int fractionalPart)
        {
            long reduction = (long)wholePart * 100 + fractionalPart;
            SetAmount(TotalCents - reduction);
        }
        public override void Display()
        {
            Console.WriteLine($"Товар: {Name}, ціна: {ToString()}");
        }
        public override string ToString()
        {
            return $"{Name}: {wholePart}.{fractionalPart:D2} {Currency}";
        }
        public override bool Equals(object? obj)
        {
            return obj is Product other&& base.Equals(other)&& Name == other.Name;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), Name);
        }
    }
}
