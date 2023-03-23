// ReSharper disable RedundantArgumentDefaultValue

#region

using System;
using System.Diagnostics;

#endregion

namespace Jcd.BitManipulation.Examples;

internal static class Program
{
    private static void Main()
    {
        // chaining operations, the same steps and end results
        var data = 0;
        byte upperByte = 0;
        const long iterations
            #if DEBUG
            = 1_000_000;
        #else
            = 1_000_000_000;
        #endif
        const int opsPerIteration = 6;
        var sw = Stopwatch.StartNew();
        for (var i = 0; i < iterations; i++)
        {
            data = i.SetBits(0, 16) // value is now 0b1111111111111111
                .SetBits() // this is the equivalent as above
                .ClearBits(4, 8) // value is now 0b1111000000001111
                .ToggleBits(); // value is now 0b0000111111110000

            upperByte = ((byte)data.ReadBits(8, 8)) // extract the upper byte (0b00001111)
                .StoreBits(0b1011, 4, 4); // store the value in the upper 4 bits, now upperByte is now 0b10111111
        }

        sw.Stop();
        var elapsed = sw.Elapsed.TotalMilliseconds;
        var elapsedPer = elapsed / (iterations * opsPerIteration);
        Console.WriteLine(
            $"{iterations:n0} iterations with {opsPerIteration} operations per iteration took {elapsed:n2} ms for an average of {elapsedPer:e2} ms per operation.");
        Console.WriteLine($"{upperByte} {data}");
    }

    private static void ReadMeExample()
    {
        ushort data = 0b0000000000000000;
        // turn on all the bits
        data = data.SetBits(0, 16); // value is now 0b1111111111111111
        // this is the equivalent as above
        data = data.SetBits();

        // Clear the middle 4 bits.
        data = data.ClearBits(4, 8); // value is now 0b1111000000001111

        // Toggle all the bits.
        data = data.ToggleBits(); // value is now 0b0000111111110000

        // read the upper byte 
        var upperByte = (byte)data.ReadBits(8, 8); // upperByte is now 0b00001111

        // write 0b1011 into the upper nybble
        upperByte = upperByte.StoreBits(0b1011, 4, 4); // upperByte is now 0b10111111

        // chaining operations, the same steps and end results
        data.ClearBits();
        data = data.SetBits(0, 16) // value is now 0b1111111111111111
            .SetBits() // this is the equivalent as above
            .ClearBits(4, 8) // value is now 0b1111000000001111
            .ToggleBits(); // value is now 0b0000111111110000

        upperByte = ((byte)data.ReadBits(8, 8)) // extract the upper byte (0b00001111)
            .StoreBits(0b1011, 4, 4); // store the value in the upper 4 bits, now upperByte is now 0b10111111
    }
}