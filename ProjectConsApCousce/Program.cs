using System;
using System.Linq;
using System.Text;
namespace ProjectConsApCousce
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Course course1 = new Course("C# для початківців", 40);
            OnlineCourse course2 = new OnlineCourse("Python для початківців", 30, "Udemy");
            OnlineCourse course3 = new OnlineCourse("Веброзробка", 50, "Coursera");

            Console.WriteLine(" ВЛАСТИВОСТІ COURSE ");
            Console.WriteLine($"Назва: {course1.Name}");
            Console.WriteLine($"Тривалість: {course1.Duration} год.");

            Console.WriteLine("\n ВЛАСТИВОСТІ ONLINECOURSE ");
            Console.WriteLine($"Назва: {course2.Name}");
            Console.WriteLine($"Тривалість: {course2.Duration} год.");
            Console.WriteLine($"Платформа: {course2.Platform}");

            Console.WriteLine("\n ToString() ");
            Console.WriteLine(course1);
            Console.WriteLine(course2);
            Console.WriteLine(course3);

            Course[] courses ={course1,course2,course3};
            Console.WriteLine("\n УСІ КУРСИ ");
            foreach (Course course in courses)
            {
                Console.WriteLine(course.ToString());
            }
            Console.WriteLine("\n ЛИШЕ ONLINECOURSE ");
            foreach (OnlineCourse course in courses.OfType<OnlineCourse>())
            {
                Console.WriteLine(course);
            }
            Console.WriteLine("\n Equals() ");

            OnlineCourse course4 = new OnlineCourse("Python для початківців", 30, "Udemy");
            Console.WriteLine($"course2 дорівнює course4: {course2.Equals(course4)}");
            Console.WriteLine($"course2 дорівнює course3: {course2.Equals(course3)}");
            Console.WriteLine("\n GetHashCode() ");

            Console.WriteLine($"course2: {course2.GetHashCode()}");
            Console.WriteLine($"course3: {course3.GetHashCode()}");
            Console.WriteLine($"course4: {course4.GetHashCode()}");

            Console.WriteLine("\n ПОРІВНЯННЯ ToString() ");

            Console.WriteLine(course2.ToString());
            Console.WriteLine(course4.ToString());

            Console.WriteLine("\nНатисніть будь-яку клавішу для завершення...");
            Console.ReadKey();
        }
    }
}
