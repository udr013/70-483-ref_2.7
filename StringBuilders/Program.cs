using System;

namespace StringBuilders
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Jimi";
            string lastName = "Hendrix";

            // StringBuilder
            StringBuilder fullName = new StringBuilder();
            fullName.Append(firstName);
            fullName.Append(" ");
            fullName.Append(lastName);
            Console.WriteLine("Full name: {0}", fullName);

            //why ToString is used in example?
            Console.WriteLine("Full name: {0}", fullName.ToString());
        }
    }
}
