#region

using System;

using Jcd.BitManipulation.Algorithms;

// ReSharper disable NotAccessedVariable
// ReSharper disable IdentifierTypo
// ReSharper disable CommentTypo
// ReSharper disable RedundantArgumentDefaultValue
// ReSharper disable HeapView.ObjectAllocation
// ReSharper disable RedundantAssignment
// ReSharper disable HeapView.BoxingAllocation
// ReSharper disable ConvertToConstant.Local
// ReSharper disable UnusedMember.Local
// ReSharper disable HeapView.ObjectAllocation.Evident
// ReSharper disable UnusedVariable
#pragma warning disable S1481
#pragma warning disable S1854
#pragma warning disable S125
#pragma warning disable S3254
#pragma warning disable S4055
#pragma warning disable S4056
#pragma warning disable S109
#pragma warning disable S1192

#endregion

namespace Jcd.BitManipulation.Examples;

public static class ReadMeExamples
{
   public static void Rotate_Examples()
   {
      byte b = 0b00001111;
      b.RotateLeft(3);
      b.RotateLeft(4);
      b.RotateLeft(5);
      b.RotateLeft(6);
      b.RotateLeft(7);
      b.RotateLeft(8);

      b = 0b11110000;
      b.RotateRight(3); // b2 = 0b00011110
      b.RotateRight(4); // b3 = 0b00001111
      b.RotateRight(5); // b4 = 0b10000111
      b.RotateRight(6); // b5 = 0b11000011
      b.RotateRight(7); // b6 = 0b11100001
      b.RotateRight(8); // b7 = 0b11110000
   }

   public static void Alignment_ToUInt32_Example()
   {
      byte[] array = [0x0A, 0x0F, 0xEE];

      var val = array.ToUInt32();        // this is the same as: var ui1 = array.ToUInt32(Endian.Little, ByteAlignment.InferredFromEndian);
      Console.WriteLine($"0x{val:X08}"); // outputs: 0x00EE0F0A

      val = array.ToUInt32(align: ByteAlignment.MostSignificantByte
                          );             // this is the same as: var ui1 = array.ToUInt32(Endian.Little, ByteAlignment.MostSignificantByte);
      Console.WriteLine($"0x{val:X08}"); // outputs: 0xEE0F0A00

      val = array.ToUInt32(Endian.Big);  // this is the same as: var ui1 = array.ToUInt32(Endian.Big, ByteAlignment.InferredFromEndian);
      Console.WriteLine($"0x{val:X08}"); // outputs: 0x0A0FEE00

      val = array.ToUInt32(Endian.Big, ByteAlignment.LeastSignificantByte);
      Console.WriteLine($"0x{val:X08}"); // outputs: 0x000A0FEE
   }

   public static void ReadMe_BitManipulation_Byte_Example()
   {
      byte data = 0b00000000;

      // turn on all the bits
      data = data.SetBits(); // value is now 0b11111111

      // this is the equivalent as above
      data = data.SetBits();

      // Clear the upper 4 bits.
      data = data.ClearBits(4, 4); // value is now 0b00001111

      // Toggle all the bits.
      data = data.ToggleBits(); // value is now 0b11110000

      // read the upper nybble as a byte
      data.ReadBits(4, 4);

      // write 0b1011 into the upper nybble of data
      data = data.StoreBits(0b1011, 4, 4); // data is now 0b10110000

      // chaining operations, the same steps and end results
      data.ClearBits();
      data = data.SetBits()       // value is now 0b11111111
                 .SetBits()       // this is the equivalent as above
                 .ClearBits(4, 4) // value is now 0b00001111
                 .ToggleBits();   // value is now 0b11110000

      data.ReadBits(4, 4)           // extract the upper nybble (0b00001111)
          .StoreBits(0b1011, 4, 4); // store the value in the upper 4 bits, now upperByte is now 0b10111111
   }

   public static void ReadMe_BitManipulation_SByte_Example()
   {
      sbyte data = 0b00000000;

      // turn on all the bits
      data = data.SetBits(); // value is now 0b11111111

      // this is the equivalent as above
      data = data.SetBits();

      // Clear the upper 4 bits.
      data = data.ClearBits(4, 4); // value is now 0b00001111

      // Toggle all the bits.
      data = data.ToggleBits(); // value is now 0b11110000

      // read the upper nybble as a byte
      data.ReadBits(4, 4);

      // write 0b1011 into the upper nybble of data
      data = data.StoreBits(0b1011, 4, 4); // data is now 0b10110000

      // chaining operations, the same steps and end results
      data.ClearBits();
      data = data.SetBits()       // value is now 0b11111111
                 .SetBits()       // this is the equivalent as above
                 .ClearBits(4, 4) // value is now 0b00001111
                 .ToggleBits();   // value is now 0b11110000

      data.ReadBits(4, 4)           // extract the upper nybble (0b00001111)
          .StoreBits(0b1011, 4, 4); // store the value in the upper 4 bits, now upperByte is now 0b10111111
   }

   public static void ReadMe_BitManipulation_UInt16_Example()
   {
      ushort data = 0b0000000000000000;

      // turn on all the bits
      data = data.SetBits(); // value is now 0b1111111111111111

      // this is the equivalent as above
      data = data.SetBits();

      // Clear the middle 4 bits.
      data = data.ClearBits(4, 8); // value is now 0b1111000000001111

      // Toggle all the bits.
      data = data.ToggleBits(); // value is now 0b0000111111110000

      var finalData = data;

      // read the upper byte
      var upperByte = (byte) data.ReadBits(8, 8); // upperByte is now 0b00001111

      // write 0b1011 into the upper nybble
      upperByte = upperByte.StoreBits(0b1011, 4, 4); // upperByte is now 0b10111111

      // chaining operations, the same steps and end results
      data.ClearBits();
      data = data.SetBits()       // value is now 0b1111111111111111
                 .SetBits()       // this is the equivalent as above
                 .ClearBits(4, 8) // value is now 0b1111000000001111
                 .ToggleBits();   // value is now 0b0000111111110000

      upperByte = ((byte) data.ReadBits(8, 8)) // extract the upper byte (0b00001111)
        .StoreBits(0b1011, 4, 4);              // store the value in the upper 4 bits, now upperByte is now 0b10111111

      // finalData 0b0000111111110000
      var beByte0 = finalData.ReadByte(0, Endian.Big); // 00001111
      var leByte0 = finalData.ReadByte(0);             // 11110000

      var mutatedData = finalData.StoreByte(0b10111111, 0, Endian.Big).StoreByte(0b01010101, 0) // lower byte is now 0b01010101
         ;                                                                                      // mutatedData is now 0b1011111101010101

      var beBa = mutatedData.ToByteArray(Endian.Big); // beBa=[0b10111111, 0b01010101]

      var leBa = mutatedData.ToByteArray(); // leBa=[0b01010101, 0b10111111]

      var leBaToUInt16Le = leBa.ToUInt16(); // leBaToUInt16Le = 0b1011111101010101

      var leBaToUInt16Be = leBa.ToUInt16(Endian.Big); // leBaToUInt16Le  = 0b0101010110111111
   }

   public static void ReadMe_BitManipulation_Int16_Example()
   {
      short data = 0b0000000000000000;

      // turn on all the bits
      data = data.SetBits(); // value is now 0b1111111111111111

      // this is the equivalent as above
      data = data.SetBits();

      // Clear the middle 4 bits.
      data = data.ClearBits(4, 8); // value is now 0b1111000000001111

      // Toggle all the bits.
      data = data.ToggleBits(); // value is now 0b0000111111110000

      var finalData = data;

      // read the upper byte
      var upperByte = (byte) data.ReadBits(8, 8); // upperByte is now 0b00001111

      // write 0b1011 into the upper nybble
      upperByte = upperByte.StoreBits(0b1011, 4, 4); // upperByte is now 0b10111111

      // chaining operations, the same steps and end results
      data.ClearBits();
      data = data.SetBits()       // value is now 0b1111111111111111
                 .SetBits()       // this is the equivalent as above
                 .ClearBits(4, 8) // value is now 0b1111000000001111
                 .ToggleBits();   // value is now 0b0000111111110000

      upperByte = ((byte) data.ReadBits(8, 8)) // extract the upper byte (0b00001111)
        .StoreBits(0b1011, 4, 4);              // store the value in the upper 4 bits, now upperByte is now 0b10111111

      // finalData 0b0000111111110000
      var beByte0 = finalData.ReadByte(0, Endian.Big); // 00001111
      var leByte0 = finalData.ReadByte(0);             // 11110000

      var mutatedData = finalData.StoreByte(0b10111111, 0, Endian.Big).StoreByte(0b01010101, 0) // lower byte is now 0b01010101
         ;                                                                                      // mutatedData is now 0b1011111101010101

      var beBa = mutatedData.ToByteArray(Endian.Big); // beBa=[0b10111111, 0b01010101]

      var leBa = mutatedData.ToByteArray(); // leBa=[0b01010101, 0b10111111]

      var leBaToInt16Le = leBa.ToInt16(); // leBaToInt16Le = 0b1011111101010101

      var leBaToInt16Be = leBa.ToInt16(Endian.Big); // leBaToInt16Le  = 0b0101010110111111
   }

   public static void ReadMe_BitManipulation_UInt32_Example()
   {
      uint data = 0;

      // turn on all the bits
      data = data.SetBits(); // value is now 0b11111111111111111111111111111111

      // this is the equivalent as above
      data = data.SetBits();

      // Clear the middle 4 bits.
      data = data.ClearBits(4, 8); // value is now 0b11111111111111111111000000001111

      // Toggle all the bits.
      data = data.ToggleBits(); // value is now 0b00000000000000000000111111110000

      var finalData = data;

      // read the second byte
      var secondByte = (byte) data.ReadBits(8, 8); // secondByte is now 0b00001111

      // write 0b1011 into the upper nybble
      secondByte = secondByte.StoreBits(0b1011, 4, 4); // secondByte is now 0b10111111

      // chaining operations, the same steps and end results
      data.ClearBits();
      data = data.SetBits()       // value is now 0b11111111111111111111111111111111
                 .SetBits()       // this is the equivalent as above
                 .ClearBits(4, 8) // value is now 01111111111111111b1111000000001111
                 .ToggleBits();   // value is now 0b00000000000000000000111111110000

      secondByte = ((byte) data.ReadBits(8, 8)) // extract the upper byte (0b00001111)
        .StoreBits(0b1011, 4, 4);               // store the value in the upper 4 bits, now upperByte is now 0b10111111

      // finalData is 0b00000000000000000000111111110000

      var beByte0 = finalData.ReadByte(0, Endian.Big); // 00001111
      var leByte0 = finalData.ReadByte(0);             // 11110000

      var mutatedData = finalData.StoreByte(0b10111111, 0, Endian.Big).StoreByte(0b01010101, 0) // lower byte is now 0b01010101
         ;

      // mutatedData is now 0b10111111000000000000111101010101

      var beBa = mutatedData.ToByteArray(Endian.Big); // beBa=[0b10111111, 0b00000000, 0b00001111, 0b01010101]

      var leBa = mutatedData.ToByteArray(); // leBa=[0b01010101, 0b00001111, 0b00000000, 0b10111111]

      var leBaToUInt32Le = leBa.ToUInt32(); // leBaToUInt32Le = 0b10111111000000000000111101010101

      var leBaToUInt32Be = leBa.ToUInt32(Endian.Big); // leBaToUInt32Be  = 0b01010101000011110000000010111111
   }

   public static void ReadMe_BitManipulation_Int32_Example()
   {
      var data = 0;

      // turn on all the bits
      data = data.SetBits(); // value is now 0b11111111111111111111111111111111

      // this is the equivalent as above
      data = data.SetBits();

      // Clear the middle 4 bits.
      data = data.ClearBits(4, 8); // value is now 0b11111111111111111111000000001111

      // Toggle all the bits.
      data = data.ToggleBits(); // value is now 0b00000000000000000000111111110000

      var finalData = data;

      // read the second byte
      var secondByte = (byte) data.ReadBits(8, 8); // secondByte is now 0b00001111

      // write 0b1011 into the upper nybble
      secondByte = secondByte.StoreBits(0b1011, 4, 4); // secondByte is now 0b10111111

      // chaining operations, the same steps and end results
      data.ClearBits();
      data = data.SetBits()       // value is now 0b11111111111111111111111111111111
                 .SetBits()       // this is the equivalent as above
                 .ClearBits(4, 8) // value is now 01111111111111111b1111000000001111
                 .ToggleBits();   // value is now 0b00000000000000000000111111110000

      secondByte = ((byte) data.ReadBits(8, 8)) // extract the upper byte (0b00001111)
        .StoreBits(0b1011, 4, 4);               // store the value in the upper 4 bits, now upperByte is now 0b10111111

      // finalData is 0b00000000000000000000111111110000

      var beByte0 = finalData.ReadByte(0, Endian.Big); // 00001111
      var leByte0 = finalData.ReadByte(0);             // 11110000

      var mutatedData = finalData.StoreByte(0b10111111, 0, Endian.Big).StoreByte(0b01010101, 0) // lower byte is now 0b01010101
         ;

      // mutatedData is now 0b10111111000000000000111101010101

      var beBa = mutatedData.ToByteArray(Endian.Big); // beBa=[0b10111111, 0b00000000, 0b00001111, 0b01010101]

      var leBa = mutatedData.ToByteArray(); // leBa=[0b01010101, 0b00001111, 0b00000000, 0b10111111]

      var leBaToInt32Le = leBa.ToInt32(); // leBaToInt32Le = 0b10111111000000000000111101010101

      var leBaToInt32Be = leBa.ToInt32(Endian.Big); // leBaToInt32Be  = 0b01010101000011110000000010111111
   }

   public static void ReadMe_BitManipulation_UInt64_Example()
   {
      ulong data = 0;

      // turn on all the bits
      data = data.SetBits(); // value is now 0b1111111111111111111111111111111111111111111111111111111111111111

      // this is the equivalent as above
      data = data.SetBits();

      // Clear the middle 4 bits.
      data = data.ClearBits(4, 8); // value is now 0b1111111111111111111111111111111111111111111111111111000000001111

      // Toggle all the bits.
      data = data.ToggleBits(); // value is now 0b0000000000000000000000000000000000000000000000000000111111110000

      var finalData = data;

      // read the second byte
      var secondByte = (byte) data.ReadBits(8, 8); // secondByte is now 0b00001111

      // write 0b1011 into the upper nybble
      secondByte = secondByte.StoreBits(0b1011, 4, 4); // secondByte is now 0b10111111

      // chaining operations, the same steps and end results
      data.ClearBits();
      data = data.SetBits()       // value is now 0b1111111111111111111111111111111111111111111111111111111111111111
                 .SetBits()       // this is the equivalent as above
                 .ClearBits(4, 8) // value is now 0b1111111111111111111111111111111111111111111111111111000000001111
                 .ToggleBits();   // value is now 0b0000000000000000000000000000000000000000000000000000111111110000

      secondByte = ((byte) data.ReadBits(8, 8)) // extract the upper byte (0b00001111)
        .StoreBits(0b1011, 4, 4);               // store the value in the upper 4 bits, now upperByte is now 0b10111111

      // finalData is 0b0000000000000000000000000000000000000000000000000000111111110000
      var beByte0 = finalData.ReadByte(0, Endian.Big); // 00001111
      var leByte0 = finalData.ReadByte(0);             // 11110000

      var mutatedData = finalData.StoreByte(0b10111111, 0, Endian.Big).StoreByte(0b01010101, 0);

      // mutatedData is now 0b1011111100000000000000000000000000000000000000000000111101010101

      var beBa = mutatedData.ToByteArray(Endian.Big); // beBa=[0b10111111, 0b00000000, 0b00000000, 0b00000000, 0b00000000, 0b00000000, 0b00001111, 0b01010101]

      var leBa = mutatedData.ToByteArray(); // leBa=[0b01010101, 0b00001111, 0b00000000, 0b00000000, 0b00000000, 0b00000000, 0b00000000, 0b10111111]

      var leBaToUInt64Le = leBa.ToUInt64(); // leBaToUInt64Le = 0b1011111100000000000000000000000000000000000000000000111101010101

      var leBaToUInt64Be = leBa.ToUInt64(Endian.Big); // leBaToUInt64Be  = 0b0101010100001111000000000000000000000000000000000000000010111111
   }

   public static void ReadMe_BitManipulation_Int64_Example()
   {
      long data = 0;

      // turn on all the bits
      data = data.SetBits(); // value is now 0b1111111111111111111111111111111111111111111111111111111111111111

      // this is the equivalent as above
      data = data.SetBits();

      // Clear the middle 4 bits.
      data = data.ClearBits(4, 8); // value is now 0b1111111111111111111111111111111111111111111111111111000000001111

      // Toggle all the bits.
      data = data.ToggleBits(); // value is now 0b0000000000000000000000000000000000000000000000000000111111110000

      var finalData = data;

      // read the second byte
      var secondByte = (byte) data.ReadBits(8, 8); // secondByte is now 0b00001111

      // write 0b1011 into the upper nybble
      secondByte = secondByte.StoreBits(0b1011, 4, 4); // secondByte is now 0b10111111

      // chaining operations, the same steps and end results
      data.ClearBits();
      data = data.SetBits()       // value is now 0b1111111111111111111111111111111111111111111111111111111111111111
                 .SetBits()       // this is the equivalent as above
                 .ClearBits(4, 8) // value is now 0b1111111111111111111111111111111111111111111111111111000000001111
                 .ToggleBits();   // value is now 0b0000000000000000000000000000000000000000000000000000111111110000

      secondByte = ((byte) data.ReadBits(8, 8)) // extract the upper byte (0b00001111)
        .StoreBits(0b1011, 4, 4);               // store the value in the upper 4 bits, now upperByte is now 0b10111111

      // finalData is 0b0000000000000000000000000000000000000000000000000000111111110000
      var beByte0 = finalData.ReadByte(0, Endian.Big); // 00001111
      var leByte0 = finalData.ReadByte(0);             // 11110000

      var mutatedData = finalData.StoreByte(0b10111111, 0, Endian.Big).StoreByte(0b01010101, 0);

      // mutatedData is now 0b1011111100000000000000000000000000000000000000000000111101010101

      var beBa = mutatedData.ToByteArray(Endian.Big); // beBa=[0b10111111, 0b00000000, 0b00000000, 0b00000000, 0b00000000, 0b00000000, 0b00001111, 0b01010101]

      var leBa = mutatedData.ToByteArray(); // leBa=[0b01010101, 0b00001111, 0b00000000, 0b00000000, 0b00000000, 0b00000000, 0b00000000, 0b10111111]

      var leBaToInt64Le = leBa.ToInt64(); // leBaToInt64Le = 0b1011111100000000000000000000000000000000000000000000111101010101

      var leBaToInt64Be = leBa.ToInt64(Endian.Big); // leBaToInt64Be  = 0b0101010100001111000000000000000000000000000000000000000010111111
   }

   public static void BitIndexer_Example()
   {
      ushort ui16 = 0b1011110001010101;
      BitIndexer bi = ui16;
      Console.WriteLine(bi.ToString()); // outputs: 0b1011110001010101

      if (bi[0])
      {
         Console.WriteLine("Index 0 is set/true!"); // this will write to the output.
      }

      if (bi[1])
      {
         Console.WriteLine("Index 1 is set/true!"); // this will not write to the output.
      }

      if (bi[10])
      {
         Console.WriteLine("Index 10 is set/true!");
      }

      bi[1] = true; // bi is now 0b1011110001010111

      if (bi[1])
      {
         Console.WriteLine("Index 1 is set/true!"); // this will write to the output.
      }

      Console.WriteLine(bi.ToString()); // outputs: 0b1011110001010111

      var flags = bi[..];
      Array.Reverse(flags);
      var ui16Reversed = flags.ToUInt16(); // ui16Reversed = 0b1110101000111101;
      BitIndexer biReversed = ui16Reversed;

      Console.WriteLine(biReversed.ToString()); // outputs: 0b1110101000111101
   }

   public static void ByteIndexer_Example()
   {
      // ByteIndexers on 64 bit values
      BigEndianByteIndexer bebi = 0xDECAFFC0FFEEC0DE;
      LittleEndianByteIndexer lebi = 0xDECAFFC0FFEEC0DE;

      Console.WriteLine(bebi.ToString()); // outputs: "DE CA FF C0 FF EE C0 DE"
      Console.WriteLine(lebi.ToString()); // outputs: "DE C0 EE FF C0 FF CA DE"

      bebi[0] = 0x0A;
      lebi[0] = 0x0B;

      Console.WriteLine(bebi.ToString()); // outputs: "0A CA FF C0 FF EE C0 DE"
      Console.WriteLine(lebi.ToString()); // outputs: "0B C0 EE FF C0 FF CA DE"

      // ByteIndexers on 32 bit values
      bebi = 0x600DC0DE;
      lebi = 0x600DC0DE;

      Console.WriteLine(bebi.ToString()); // outputs: "60 0D C0 DE"
      Console.WriteLine(lebi.ToString()); // outputs: "DE C0 0D 60"

      bebi[0] = 0x0A;
      lebi[0] = 0x0B;

      Console.WriteLine(bebi.ToString()); // outputs: "0A 0D C0 DE"
      Console.WriteLine(lebi.ToString()); // outputs: "0B C0 0D 60"
   }
}