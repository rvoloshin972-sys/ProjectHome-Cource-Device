using System;

namespace ProjectConsApCousce
{
    public class OnlineCourse : Course
    {
        public string Platform { get; set; }
        public OnlineCourse(string name, int duration, string platform)
            : base(name, duration)
        {
            Platform = platform;
        }
        public override string ToString()
        {
            return $"{base.ToString()}, платформа: {Platform}";
        }
        public override bool Equals(object? obj)
        {
            return obj is OnlineCourse other
                && Name == other.Name
                && Duration == other.Duration
                && Platform == other.Platform;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Duration, Platform);
        }
    }
}
