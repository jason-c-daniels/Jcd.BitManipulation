// ReSharper disable RedundantArgumentDefaultValue
namespace Jcd.BitManipulation.Examples
{
    internal static class Program
    {
        private static void Main()
        {
            ushort data=0b0000000000000000;
            // turn on all the bits
            data.SetBits(0,16);  // value is now 0b1111111111111111
            // this is the equivalent as above
            data.SetBits();

            // Clear the middle 4 bits.
            data.ClearBits(4,8); // value is now 0b1111000000001111

            // Toggle all the bits.
            data.ToggleBits(); // value is now 0b0000111111110000

            // read the upper byte 
            var upperByte = (byte) data.ReadBits(8,8); // upperByte is now 0b00001111

            // write 0b1111 into the upper nybble
            upperByte.StoreBits(0b00001111,4,4); // upperByte is now 0b11111111
        }
    }
}