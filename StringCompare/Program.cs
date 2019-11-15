using System;

namespace StringCompare
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "hello";
            string b = "hello";
            string c = "hel";
            string d = "lo";
            string e = c + d;
            /// will improve string storage efficiency, normally this happens at compile time like for a, b, c, d
            /// e will be created at runtime, though this should only be done when you see real use of it for preformance
            e = string.Intern(e);

            // in java == will result to false in c# this is true;
            Console.WriteLine("a == b: {0}", a == b);
            Console.WriteLine("a == e: {0}", a == e);

            Console.WriteLine("a equals b: {0}", a.Equals(b));
            Console.WriteLine("a equals e: {0}", a.Equals(e));

            string firstName = "Jimi";
            string lastName = "Hendrix";
        }
    }
}
