using System;

namespace Converter
{
    public class BinaryConverter : IBinary
    {
        public ulong ToDecimal(string binary)
        {
            return Convert.ToUInt64(binary, 2);
        }
    }
}
