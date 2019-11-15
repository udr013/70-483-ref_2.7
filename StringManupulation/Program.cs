using System;
using System.Linq;
using System.Text;

namespace StringManupulation
{
    class Program
    {
        static void Main(string[] args)
        {
            /// string Contains method
            string name = "          Jimi Hendrix    ";
            if (name.Contains("Jimi"))
            {
                Console.WriteLine("Input contains Jimi");
            }

            /// string Trim, StartsWith, EndsWith methods
            string trimmed = name.TrimStart();
            trimmed = name.TrimEnd();
            //does both of the above...
            trimmed = name.Trim();

            if (trimmed.StartsWith("Jimi"))
            {
                Console.WriteLine("starts with Jimi");
            }
            if (trimmed.EndsWith("Hendrix"))
            {
                Console.WriteLine("Ends with Hendrix");
            }

            ///Index, SubString and Replace
            int index = name.IndexOf("J");
            Console.WriteLine(index);
            Console.WriteLine(name.Substring(index, 4));
            var updatedName = name.Replace("Jimi", "Johnny").Trim();
            Console.WriteLine(updatedName);

            /// split
            foreach(string s in updatedName.Split(" "))
            {
                Console.WriteLine(s);
            }

            




        }
    }
}
