using System;

namespace FormatStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 99;
            double pi = 3.141592654;
            
            Console.WriteLine(
                /// :D = Decimal system, 
                /// -3 = using three possitions starting from front, leaving one space behind the number
                "{0, -3:D}" +
                /// :X = hexadecimal system,
                "{0, -2:X}" +
                /// :N - number of decimals
                /// using 6 positions starting from the last decimal taking the ',' in account.
                "{1, 6:N3}", i, pi);
        }
    }
}
