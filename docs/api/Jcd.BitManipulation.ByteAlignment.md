#### [Jcd.BitManipulation](index 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation 'Jcd.BitManipulation')

## ByteAlignment Enum

Indicates how to align partially filled data when converting from collections of bytes.

```csharp
public enum ByteAlignment
```

### Fields

<a name='Jcd.BitManipulation.ByteAlignment.InferredFromEndian'></a>

`InferredFromEndian` 0

Indicates that little endian data is to be aligned to LSB and big endian data is to be aligned at MSB

<a name='Jcd.BitManipulation.ByteAlignment.LeastSignificantByte'></a>

`LeastSignificantByte` 1

Align the decoded value to the least significant byte

<a name='Jcd.BitManipulation.ByteAlignment.MostSignificantByte'></a>

`MostSignificantByte` 2

Align the decoded value to the most significant byte

### Example

Convert a 3 byte array to a UInt32

```csharp
using Jcd.BitManipulation;

byte[] array = [0x0A, 0x0F, 0xEE];

var val = array.ToUInt32(); // this is the same as: var ui1 = array.ToUInt32(Endian.Little, ByteAlignment.InferredFromEndian);
Console.WriteLine($"0x{val:X08}"); // outputs: 0x00EE0F0A

val = array.ToUInt32(align:ByteAlignment.MostSignificantByte); // this is the same as: var ui1 = array.ToUInt32(Endian.Little, ByteAlignment.MostSignificantByte);
Console.WriteLine($"0x{val:X08}"); // outputs: 0xEE0F0A00

val = array.ToUInt32(Endian.Big); // this is the same as: var ui1 = array.ToUInt32(Endian.Big, ByteAlignment.InferredFromEndian);
Console.WriteLine($"0x{val:X08}"); // outputs: 0x0A0FEE00

val = array.ToUInt32(Endian.Big, ByteAlignment.LeastSignificantByte);
Console.WriteLine($"0x{val:X08}"); // outputs: 0x000A0FEE
```

### Remarks

This only applies when trying to convert a collection of bytes to a numeric type that's
larger in bytes than the length of the collection. If the source collection is larger,
the excess bytes are discarded.