using System;
using System.IO;

namespace StringReaderAndWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            StringWriter writer = new StringWriter();
            writer.WriteLine("Here's some input");
            writer.Close();

            Console.WriteLine(writer);
            //example uses ToString again... 
            Console.WriteLine(writer.ToString());

            // With @ reads as multiline..
            string datastring = @"Jimi Hendrix
                                 29";
            StringReader reader = new StringReader(datastring);

            string name = reader.ReadLine();
            int age = int.Parse(reader.ReadLine());
            Console.WriteLine("Result: {0}", reader.ReadLine());
            // better use using?
            reader.Close();
            Console.WriteLine("Name: {0}, Age:{1}", name, age);

            string name2;
            int age2;
            StringReader reader2;
            using (reader2 = new StringReader(datastring))
            {
                name2 = reader2.ReadLine();
                age2 = int.Parse(reader2.ReadLine());
            }
            /// closed because of using, will throw System.ObjectDisposedException: 'Cannot read from a closed TextReader.' 
            /// reader is not null, only disposed?
            // Console.WriteLine(reader2.ReadLine());
            Console.WriteLine("Name: {0}, Age:{1}", name2, age2);
        }
    }
}
