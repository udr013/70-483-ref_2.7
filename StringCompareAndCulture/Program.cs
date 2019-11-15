using System;
using System.Globalization;
using System.Threading;

namespace StringCompareAndCulture
{
    class Program
    {
        static void Main(string[] args)
        {
            // Default comparison fails becase the strings are different
            if (!"Straße".Equals("Strasse"))
                Console.WriteLine("Unicode Strasse are not equal");
            
            // Set the curent culture for this thread to EN-US
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("nl-NL");
            if ("Straße".Equals("Strasse", StringComparison.CurrentCulture))
                Console.WriteLine("Culture comparison Strasse are equal");
           
            // IgnoreCase option to perform comparisions
            if ("Straße".Equals("STRASSE", StringComparison.CurrentCultureIgnoreCase))
                Console.WriteLine("Culture comparison Strasse are equal");

            // looks purely at the values of the raw byte
            if (!"Straße".Equals("STRASSE", StringComparison.OrdinalIgnoreCase))
                Console.WriteLine("Ordinal comparison Strasse are not equal");
        }
    }
}
