using System;

namespace Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";

            Console.WriteLine("Gib eine Binärzahl ein (nur 0 und 1 – anderes Zeichen stoppt):");

            while (true)
            {
                char c = Console.ReadKey(true).KeyChar;

                if (c != '0' && c != '1')
                    break;

                Console.Write(c);
                input += c;
            }

            Console.WriteLine("\n\nEingegeben: " + input);

            IBinary converter = new BinaryConverter();
            ulong result = converter.ToDecimal(input);

            Console.WriteLine("Dezimalwert: " + result);
        }
    }
}
