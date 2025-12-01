using sample; 

namespace converter;

class Program
{
    public static int Main(string[] argv)
    {
        Console.WriteLine("Gib eine Binärzahl ein (nur 0 und 1):");
        string input = Console.ReadLine() ?? "";

        BinaryConverter conv = new BinaryConverter();
        ulong dezimal = conv.ConvertBinary(input);

        Console.WriteLine($"Dezimalwert: {dezimal}");
        return 0;
    }
}
