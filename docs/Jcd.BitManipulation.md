## Jcd.BitManipulation Namespace

Provides a set of extension methods and types to assist with
making bit manipulation code easier to read.

### Example

```csharp
ushort data = 0b0000000000000000;

// turn on all the bits
data = data.SetBits(0, 16); // value is now 0b1111111111111111

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
data = data.SetBits(0, 16)  // value is now 0b1111111111111111
           .SetBits()       // this is the equivalent as above
           .ClearBits(4, 8) // value is now 0b1111000000001111
           .ToggleBits();   // value is now 0b0000111111110000

upperByte = ((byte) data.ReadBits(8, 8)) // extract the upper byte (0b00001111)
  .StoreBits(0b1011, 4, 4);              // store the value in the upper 4 bits, now upperByte is now 0b10111111

// finalData 0b0000111111110000
var beByte0 = finalData.ReadByte(0, Endian.Big);    // 00001111
var leByte0 = finalData.ReadByte(0, Endian.Little); // 11110000

var mutatedData = finalData.StoreByte(0b10111111, 0, Endian.Big)     // Upper byte is now 0b10111111
                           .StoreByte(0b01010101, 0, Endian.Little); // lower byte is now 0b01010101

// mutatedData is now 0b1011111101010101

var beBa = mutatedData.ToByteArray(Endian.Big); // beBa=[0b10111111, 0b01010101]

var leBa = mutatedData.ToByteArray(Endian.Little); // leBa=[0b01010101, 0b10111111]

var leBaToUInt16Le = (BitMask) leBa.ToUInt16(Endian.Little); // leBaToUInt16Le = 0b1011111101010101

var leBaToUInt16Be = (BitMask) leBa.ToUInt16(Endian.Big);   // leBaToUInt16Le  = 0b0101010110111111

// ByteIndexers on 64 bit values
BigEndianByteIndexer bebi = 0xDECAFFC0FFEEC0DE;
LittleEndianByteIndexer lebi = 0xDECAFFC0FFEEC0DE;

Console.WriteLine(bebi.ToString()); // outputs: "DE CA FF C0 FF EE C0 DE"
Console.WriteLine(lebi.ToString()); // outputs: "DE C0 EE FF C0 FF CA DE"

var bebib1 = bebi[1]; // bebib1 = 0xCA
var lebib1 = lebi[1]; // lebib1 = 0xC0

bebi[0] = 0x0A;
lebi[0] = 0x0B;

Console.WriteLine(bebi.ToString()); // outputs: "0A CA FF C0 FF EE C0 DE"
Console.WriteLine(lebi.ToString()); // outputs: "0B C0 EE FF C0 FF CA DE"

// ByteIndexers on 32 bit values
bebi = 0x600DC0DE;
lebi = 0x600DC0DE;

Console.WriteLine(bebi.ToString()); // outputs: "60 0D C0 DE"
Console.WriteLine(lebi.ToString()); // outputs: "DE C0 0D 60"

bebib1 = bebi[1]; // bebib1 = 0x0D
lebib1 = lebi[1]; // lebib1 = 0xC0

bebi[0] = 0x0A;
lebi[0] = 0x0B;

Console.WriteLine(bebi.ToString()); // outputs: "0A 0D C0 DE"
Console.WriteLine(lebi.ToString()); // outputs: "0B C0 0D 60"
```

| Classes                                                                                                                                |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        |
|:---------------------------------------------------------------------------------------------------------------------------------------|:---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| [BooleanArrayExtensions](Jcd.BitManipulation.BooleanArrayExtensions.md 'Jcd.BitManipulation.BooleanArrayExtensions')                   | Extension methods to aid in converting to numbers from arrays of [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean') values. At their respective bit positions, [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool')  is translated to 1 and [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') is translated to 0. |
| [ByteArrayExtensions](Jcd.BitManipulation.ByteArrayExtensions.md 'Jcd.BitManipulation.ByteArrayExtensions')                            | Extension methods to aid in converting numbers to and from arrays of bools                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             |
| [ByteExtensions](Jcd.BitManipulation.ByteExtensions.md 'Jcd.BitManipulation.ByteExtensions')                                           | Provides methods to perform easy to read bit manipulations on a single [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')                                                                                                                                                                                                                                                                                                                                                                                                                                                                            |
| [DoubleExtensions](Jcd.BitManipulation.DoubleExtensions.md 'Jcd.BitManipulation.DoubleExtensions')                                     | Provides methods to perform easy to read bit and byte manipulations on a [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
| [Int16Extensions](Jcd.BitManipulation.Int16Extensions.md 'Jcd.BitManipulation.Int16Extensions')                                        | Provides methods to perform easy to read bit and byte manipulations on an [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')                                                                                                                                                                                                                                                                                                                                                                                                                                                                      |
| [Int32Extensions](Jcd.BitManipulation.Int32Extensions.md 'Jcd.BitManipulation.Int32Extensions')                                        | Provides methods to perform easy to read bit and byte manipulations on an [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')                                                                                                                                                                                                                                                                                                                                                                                                                                                                      |
| [Int64Extensions](Jcd.BitManipulation.Int64Extensions.md 'Jcd.BitManipulation.Int64Extensions')                                        | Provides methods to perform easy to read bit and byte manipulations on an [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')                                                                                                                                                                                                                                                                                                                                                                                                                                                                      |
| [ReadOnlySpanOfByteExtensions](Jcd.BitManipulation.ReadOnlySpanOfByteExtensions.md 'Jcd.BitManipulation.ReadOnlySpanOfByteExtensions') | Provides facilities to convert [System.ReadOnlySpan&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.ReadOnlySpan-1 'System.ReadOnlySpan`1') of bytes to other data types.                                                                                                                                                                                                                                                                                                                                                                                                                                                  |
| [SByteExtensions](Jcd.BitManipulation.SByteExtensions.md 'Jcd.BitManipulation.SByteExtensions')                                        | Provides methods to perform easy to read bit manipulations on an [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')                                                                                                                                                                                                                                                                                                                                                                                                                                                                               |
| [SingleExtensions](Jcd.BitManipulation.SingleExtensions.md 'Jcd.BitManipulation.SingleExtensions')                                     | Provides methods to perform easy to read bit and byte manipulations on a [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
| [UInt16Extensions](Jcd.BitManipulation.UInt16Extensions.md 'Jcd.BitManipulation.UInt16Extensions')                                     | Provides methods to perform easy to read bit and byte manipulations on a [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
| [UInt32Extensions](Jcd.BitManipulation.UInt32Extensions.md 'Jcd.BitManipulation.UInt32Extensions')                                     | Provides methods to perform easy to read bit and byte manipulations on a [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
| [UInt64Extensions](Jcd.BitManipulation.UInt64Extensions.md 'Jcd.BitManipulation.UInt64Extensions')                                     | Provides methods to perform easy to read bit and byte manipulations on a [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |

| Structs                                                                                                                 |                                                                                                                                                                                     |
|:------------------------------------------------------------------------------------------------------------------------|:------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| [BigEndianByteIndexer](Jcd.BitManipulation.BigEndianByteIndexer.md 'Jcd.BitManipulation.BigEndianByteIndexer')          | Provides byte level indexing operations (set, get) on a stored number. Allows for indexer syntax when accessing the stored bytes. Index zero is the most significant byte.  |
| [BitIndexer](Jcd.BitManipulation.BitIndexer.md 'Jcd.BitManipulation.BitIndexer')                                        | Provides indexed access to the bits on a stored integer type, up to 64 bits.                                                                                                        |
| [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask')                                                 | An conceptual abstraction for a bit mask.                                                                                                                                           |
| [LittleEndianByteIndexer](Jcd.BitManipulation.LittleEndianByteIndexer.md 'Jcd.BitManipulation.LittleEndianByteIndexer') | Provides byte level indexing operations (set, get) on a stored number. Allows for indexer syntax when accessing the stored bytes. Index zero is the least significant byte. |

| Enums                                                                |                                           |
|:---------------------------------------------------------------------|:------------------------------------------|
| [Endian](Jcd.BitManipulation.Endian.md 'Jcd.BitManipulation.Endian') | A type indicating which endian is in use. |
