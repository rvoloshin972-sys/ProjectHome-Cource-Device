using System;

namespace ConsApMoneyProduct
{
    public class Money
    {
        protected int wholePart;
        protected int fractionalPart;
        private string currency;
        public int WholePart
        {
            get { return wholePart; }
            set { SetAmount((long)value * 100 + fractionalPart); }
        }

        public int FractionalPart
        {
            get { return fractionalPart; }
            set { SetAmount((long)wholePart * 100 + value); }
        }
        public string Currency
        {
            get { return currency; }
            set { currency = string.IsNullOrWhiteSpace(value) ? "грн" : value; }
        }
        public long TotalCents
        {
            get { return (long)wholePart * 100 + fractionalPart; }
        }
        public Money()
        {
            wholePart = 0;
            fractionalPart = 0;
            currency = "грн";
        }
        public Money(int wholePart, int fractionalPart, string currency = "грн")
        {
            this.currency = string.IsNullOrWhiteSpace(currency) ? "грн" : currency;
            SetAmount((long)wholePart * 100 + fractionalPart);
        }
        public void SetWholePart(int value)
        {
            WholePart = value;
        }
        public void SetFractionalPart(int value)
        {
            FractionalPart = value;
        }
        protected void SetAmount(long totalCents)
        {
            totalCents = Math.Max(0, totalCents);
            wholePart = (int)(totalCents / 100);
            fractionalPart = (int)(totalCents % 100);
        }
        public virtual void Display()
        {
            Console.WriteLine(ToString());
        }
        public override string ToString()
        {
            return $"{wholePart}.{fractionalPart:D2} {currency}";
        }
        public override bool Equals(object? obj)
        {
            return obj is Money other&& TotalCents == other.TotalCents&& Currency == other.Currency;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(TotalCents, Currency);
        }
    }
}
