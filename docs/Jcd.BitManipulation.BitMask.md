#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation')

## BitMask Struct

An conceptual abstraction for a bit mask.

```csharp
public readonly struct BitMask
```

| Constructors | |
| :--- | :--- |
| [BitMask(byte)](Jcd.BitManipulation.BitMask.BitMask(byte).md 'Jcd.BitManipulation.BitMask.BitMask(byte)') | Constructs a [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask') from a [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte') |
| [BitMask(int)](Jcd.BitManipulation.BitMask.BitMask(int).md 'Jcd.BitManipulation.BitMask.BitMask(int)') | Constructs a [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask') from an [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32') |
| [BitMask(BitMask)](Jcd.BitManipulation.BitMask.BitMask(Jcd.BitManipulation.BitMask).md 'Jcd.BitManipulation.BitMask.BitMask(Jcd.BitManipulation.BitMask)') | Copies an existing [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask') |
| [BitMask(long)](Jcd.BitManipulation.BitMask.BitMask(long).md 'Jcd.BitManipulation.BitMask.BitMask(long)') | Constructs a [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask') from a [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64') |
| [BitMask(sbyte)](Jcd.BitManipulation.BitMask.BitMask(sbyte).md 'Jcd.BitManipulation.BitMask.BitMask(sbyte)') | Constructs a [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask') from an [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte') |
| [BitMask(short)](Jcd.BitManipulation.BitMask.BitMask(short).md 'Jcd.BitManipulation.BitMask.BitMask(short)') | Constructs a [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask') from a [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16') |
| [BitMask(uint)](Jcd.BitManipulation.BitMask.BitMask(uint).md 'Jcd.BitManipulation.BitMask.BitMask(uint)') | Constructs a [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask') from a [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32') |
| [BitMask(ulong)](Jcd.BitManipulation.BitMask.BitMask(ulong).md 'Jcd.BitManipulation.BitMask.BitMask(ulong)') | Constructs a [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask') from a [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64') |
| [BitMask(ushort)](Jcd.BitManipulation.BitMask.BitMask(ushort).md 'Jcd.BitManipulation.BitMask.BitMask(ushort)') | Create a bitmask |

| Fields | |
| :--- | :--- |
| [Bits](Jcd.BitManipulation.BitMask.Bits.md 'Jcd.BitManipulation.BitMask.Bits') | The backing store for the actual bits of the [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask'). |

| Methods | |
| :--- | :--- |
| [FromRange(int, int)](Jcd.BitManipulation.BitMask.FromRange(int,int).md 'Jcd.BitManipulation.BitMask.FromRange(int, int)') | Create a 64 bit [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask') with a range of bits set. |
| [FromSingleBit(int)](Jcd.BitManipulation.BitMask.FromSingleBit(int).md 'Jcd.BitManipulation.BitMask.FromSingleBit(int)') | Create a 64 bit bit [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask') with a single bit set. |
| [ToString()](Jcd.BitManipulation.BitMask.ToString().md 'Jcd.BitManipulation.BitMask.ToString()') | Formats the [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask') as a "0b" prefixed string of zeroes and ones. |

| Operators | |
| :--- | :--- |
| [implicit operator byte(BitMask)](Jcd.BitManipulation.BitMask.op_Implicitbyte(Jcd.BitManipulation.BitMask).md 'Jcd.BitManipulation.BitMask.op_Implicit byte(Jcd.BitManipulation.BitMask)') | Automatically convert to [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte') from a [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask') |
| [implicit operator int(BitMask)](Jcd.BitManipulation.BitMask.op_Implicitint(Jcd.BitManipulation.BitMask).md 'Jcd.BitManipulation.BitMask.op_Implicit int(Jcd.BitManipulation.BitMask)') | Automatically convert to [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32') from a [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask') |
| [implicit operator BitMask(byte)](Jcd.BitManipulation.BitMask.op_ImplicitJcd.BitManipulation.BitMask(byte).md 'Jcd.BitManipulation.BitMask.op_Implicit Jcd.BitManipulation.BitMask(byte)') | Automatically convert to [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask') from a [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte') |
| [implicit operator BitMask(int)](Jcd.BitManipulation.BitMask.op_ImplicitJcd.BitManipulation.BitMask(int).md 'Jcd.BitManipulation.BitMask.op_Implicit Jcd.BitManipulation.BitMask(int)') | Automatically convert to [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask') from an [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32') |
| [implicit operator BitMask(long)](Jcd.BitManipulation.BitMask.op_ImplicitJcd.BitManipulation.BitMask(long).md 'Jcd.BitManipulation.BitMask.op_Implicit Jcd.BitManipulation.BitMask(long)') | Automatically convert to [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask') from a [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64') |
| [implicit operator BitMask(sbyte)](Jcd.BitManipulation.BitMask.op_ImplicitJcd.BitManipulation.BitMask(sbyte).md 'Jcd.BitManipulation.BitMask.op_Implicit Jcd.BitManipulation.BitMask(sbyte)') | Automatically convert to [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask') from an [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte') |
| [implicit operator BitMask(short)](Jcd.BitManipulation.BitMask.op_ImplicitJcd.BitManipulation.BitMask(short).md 'Jcd.BitManipulation.BitMask.op_Implicit Jcd.BitManipulation.BitMask(short)') | Automatically convert to [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask') from a [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte') |
| [implicit operator BitMask(uint)](Jcd.BitManipulation.BitMask.op_ImplicitJcd.BitManipulation.BitMask(uint).md 'Jcd.BitManipulation.BitMask.op_Implicit Jcd.BitManipulation.BitMask(uint)') | Automatically convert to [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask') from a [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32') |
| [implicit operator BitMask(ulong)](Jcd.BitManipulation.BitMask.op_ImplicitJcd.BitManipulation.BitMask(ulong).md 'Jcd.BitManipulation.BitMask.op_Implicit Jcd.BitManipulation.BitMask(ulong)') | Automatically convert to [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask') from a [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64') |
| [implicit operator BitMask(ushort)](Jcd.BitManipulation.BitMask.op_ImplicitJcd.BitManipulation.BitMask(ushort).md 'Jcd.BitManipulation.BitMask.op_Implicit Jcd.BitManipulation.BitMask(ushort)') | Automatically convert to [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask') from a [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16') |
| [implicit operator long(BitMask)](Jcd.BitManipulation.BitMask.op_Implicitlong(Jcd.BitManipulation.BitMask).md 'Jcd.BitManipulation.BitMask.op_Implicit long(Jcd.BitManipulation.BitMask)') | Automatically convert to [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64') from a [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask') |
| [implicit operator sbyte(BitMask)](Jcd.BitManipulation.BitMask.op_Implicitsbyte(Jcd.BitManipulation.BitMask).md 'Jcd.BitManipulation.BitMask.op_Implicit sbyte(Jcd.BitManipulation.BitMask)') | Automatically convert to [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte') from a [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask') |
| [implicit operator short(BitMask)](Jcd.BitManipulation.BitMask.op_Implicitshort(Jcd.BitManipulation.BitMask).md 'Jcd.BitManipulation.BitMask.op_Implicit short(Jcd.BitManipulation.BitMask)') | Automatically convert to [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16') from a [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask') |
| [implicit operator uint(BitMask)](Jcd.BitManipulation.BitMask.op_Implicituint(Jcd.BitManipulation.BitMask).md 'Jcd.BitManipulation.BitMask.op_Implicit uint(Jcd.BitManipulation.BitMask)') | Automatically convert to [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32') from a [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask') |
| [implicit operator ulong(BitMask)](Jcd.BitManipulation.BitMask.op_Implicitulong(Jcd.BitManipulation.BitMask).md 'Jcd.BitManipulation.BitMask.op_Implicit ulong(Jcd.BitManipulation.BitMask)') | Automatically convert to [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64') from a [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask') |
| [implicit operator ushort(BitMask)](Jcd.BitManipulation.BitMask.op_Implicitushort(Jcd.BitManipulation.BitMask).md 'Jcd.BitManipulation.BitMask.op_Implicit ushort(Jcd.BitManipulation.BitMask)') | Automatically convert to [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16') from a [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask') |
