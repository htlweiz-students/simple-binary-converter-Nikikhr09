namespace sample;

public class BinaryConverter : IBinary
{
    public ulong ConvertBinary(string binary)
    {
       
        return Convert.ToUInt64(binary, 2);
    }
}
