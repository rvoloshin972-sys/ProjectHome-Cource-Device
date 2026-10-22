using System;

namespace ProjectConsApCousce
{
    public class Course
    {
        public string Name { get; set; }
        public int Duration { get; set; }
        public Course(string name, int duration)
        {
            Name = name;
            Duration = duration;
        }
        public override string ToString()
        {
            return $"Курс: {Name}, тривалість: {Duration} год.";
        }
    }
}
