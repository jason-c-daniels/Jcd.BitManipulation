#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation')

## BitIndexer Struct

Provides indexer style access to the bits on a copied value.

```csharp
public ref struct BitIndexer
```

### Example

Examples:

```csharp
ushort ui16 = 0b1011110001010101;
BitIndexer bi = ui16;
Console.WriteLine(bi.ToString()); // outputs: 0b1011110001010101

if (bi[0])
Console.WriteLine("Index 0 is set/true!"); // this will write to the output.

if (bi[1])
Console.WriteLine("Index 1 is set/true!"); // this will not write to the output.

if (bi[10])
Console.WriteLine("Index 10 is set/true!");

bi[1] = true; // bi is now 0b1011110001010111
if (bi[1])
Console.WriteLine("Index 1 is set/true!"); // this will write to the output.

Console.WriteLine(bi.ToString()); // outputs: 0b1011110001010111

var flags = bi[0..^0]; // flags = [true, true, true, false, true, false, true, false, false, false,
true, true, true, true, false, true];
Array.Reverse(flags);
var ui16Reversed=flags.ToUInt16(); // ui16Reversed = 0b1110101000111101;
BitIndexer biReversed = ui16Reversed;

Console.WriteLine(biReversed.ToString()); // outputs: 0b1110101000111101
```

| Properties                                                                                          |                                                                                                                                 |
|:----------------------------------------------------------------------------------------------------|:--------------------------------------------------------------------------------------------------------------------------------|
| [Length](Jcd.BitManipulation.BitIndexer.Length.md 'Jcd.BitManipulation.BitIndexer.Length')          | The number of bits indexable by this [BitIndexer](Jcd.BitManipulation.BitIndexer.md 'Jcd.BitManipulation.BitIndexer') instance. |
| [this[int]](Jcd.BitManipulation.BitIndexer.this[int].md 'Jcd.BitManipulation.BitIndexer.this[int]') | Gets or sets individual bits within the backing store.                                                                          |

| Methods                                                                                                              |                                                           |
|:---------------------------------------------------------------------------------------------------------------------|:----------------------------------------------------------|
| [Slice(int, int)](Jcd.BitManipulation.BitIndexer.Slice(int,int).md 'Jcd.BitManipulation.BitIndexer.Slice(int, int)') | Gets a subset of bits given a starting offset and length. |
| [ToString()](Jcd.BitManipulation.BitIndexer.ToString().md 'Jcd.BitManipulation.BitIndexer.ToString()')               | Format as a bit representation                            |

| Operators                                                                                                                                                                                                       |                                                                                                                                                                                                                           |
|:----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|:--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| [implicit operator bool[](BitIndexer)](Jcd.BitManipulation.BitIndexer.op_Implicitbool[](Jcd.BitManipulation.BitIndexer).md 'Jcd.BitManipulation.BitIndexer.op_Implicit bool[](Jcd.BitManipulation.BitIndexer)') | Automatically convert from a [BitIndexer](Jcd.BitManipulation.BitIndexer.md 'Jcd.BitManipulation.BitIndexer') to a array of [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean') |
| [implicit operator byte(BitIndexer)](Jcd.BitManipulation.BitIndexer.op_Implicitbyte(Jcd.BitManipulation.BitIndexer).md 'Jcd.BitManipulation.BitIndexer.op_Implicit byte(Jcd.BitManipulation.BitIndexer)')       | Automatically convert from a [BitIndexer](Jcd.BitManipulation.BitIndexer.md 'Jcd.BitManipulation.BitIndexer') to a [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')                   |
| [implicit operator double(BitIndexer)](Jcd.BitManipulation.BitIndexer.op_Implicitdouble(Jcd.BitManipulation.BitIndexer).md 'Jcd.BitManipulation.BitIndexer.op_Implicit double(Jcd.BitManipulation.BitIndexer)') | Automatically convert from a [BitIndexer](Jcd.BitManipulation.BitIndexer.md 'Jcd.BitManipulation.BitIndexer') to a [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')             |
| [implicit operator float(BitIndexer)](Jcd.BitManipulation.BitIndexer.op_Implicitfloat(Jcd.BitManipulation.BitIndexer).md 'Jcd.BitManipulation.BitIndexer.op_Implicit float(Jcd.BitManipulation.BitIndexer)')    | Automatically convert from a BitIndexer to a [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')                                                                                   |
| [implicit operator int(BitIndexer)](Jcd.BitManipulation.BitIndexer.op_Implicitint(Jcd.BitManipulation.BitIndexer).md 'Jcd.BitManipulation.BitIndexer.op_Implicit int(Jcd.BitManipulation.BitIndexer)')          | Automatically convert from a BitIndexer to a [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')                                                                                      |
| [implicit operator BitIndexer(bool[])](Jcd.BitManipulation.BitIndexer.op_ImplicitJcd.BitManipulation.BitIndexer(bool[]).md 'Jcd.BitManipulation.BitIndexer.op_Implicit Jcd.BitManipulation.BitIndexer(bool[])') | Automatically convert from a [BitIndexer](Jcd.BitManipulation.BitIndexer.md 'Jcd.BitManipulation.BitIndexer') to a array of [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean') |
| [implicit operator BitIndexer(byte)](Jcd.BitManipulation.BitIndexer.op_ImplicitJcd.BitManipulation.BitIndexer(byte).md 'Jcd.BitManipulation.BitIndexer.op_Implicit Jcd.BitManipulation.BitIndexer(byte)')       | Automatically Convert from a [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte') to a [BitIndexer](Jcd.BitManipulation.BitIndexer.md 'Jcd.BitManipulation.BitIndexer')                   |
| [implicit operator BitIndexer(double)](Jcd.BitManipulation.BitIndexer.op_ImplicitJcd.BitManipulation.BitIndexer(double).md 'Jcd.BitManipulation.BitIndexer.op_Implicit Jcd.BitManipulation.BitIndexer(double)') | Automatically Convert from a [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64') to a [BitIndexer](Jcd.BitManipulation.BitIndexer.md 'Jcd.BitManipulation.BitIndexer')             |
| [implicit operator BitIndexer(float)](Jcd.BitManipulation.BitIndexer.op_ImplicitJcd.BitManipulation.BitIndexer(float).md 'Jcd.BitManipulation.BitIndexer.op_Implicit Jcd.BitManipulation.BitIndexer(float)')    | Automatically Convert from a [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64') to a [BitIndexer](Jcd.BitManipulation.BitIndexer.md 'Jcd.BitManipulation.BitIndexer')             |
| [implicit operator BitIndexer(int)](Jcd.BitManipulation.BitIndexer.op_ImplicitJcd.BitManipulation.BitIndexer(int).md 'Jcd.BitManipulation.BitIndexer.op_Implicit Jcd.BitManipulation.BitIndexer(int)')          | Automatically Convert from a [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32') to a [BitIndexer](Jcd.BitManipulation.BitIndexer.md 'Jcd.BitManipulation.BitIndexer')                |
| [implicit operator BitIndexer(long)](Jcd.BitManipulation.BitIndexer.op_ImplicitJcd.BitManipulation.BitIndexer(long).md 'Jcd.BitManipulation.BitIndexer.op_Implicit Jcd.BitManipulation.BitIndexer(long)')       | Automatically Convert from a [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64') to a [BitIndexer](Jcd.BitManipulation.BitIndexer.md 'Jcd.BitManipulation.BitIndexer')                |
| [implicit operator BitIndexer(sbyte)](Jcd.BitManipulation.BitIndexer.op_ImplicitJcd.BitManipulation.BitIndexer(sbyte).md 'Jcd.BitManipulation.BitIndexer.op_Implicit Jcd.BitManipulation.BitIndexer(sbyte)')    | Automatically Convert from a [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte') to a [BitIndexer](Jcd.BitManipulation.BitIndexer.md 'Jcd.BitManipulation.BitIndexer')                |
| [implicit operator BitIndexer(short)](Jcd.BitManipulation.BitIndexer.op_ImplicitJcd.BitManipulation.BitIndexer(short).md 'Jcd.BitManipulation.BitIndexer.op_Implicit Jcd.BitManipulation.BitIndexer(short)')    | Automatically Convert from a [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16') to a [BitIndexer](Jcd.BitManipulation.BitIndexer.md 'Jcd.BitManipulation.BitIndexer')                |
| [implicit operator BitIndexer(uint)](Jcd.BitManipulation.BitIndexer.op_ImplicitJcd.BitManipulation.BitIndexer(uint).md 'Jcd.BitManipulation.BitIndexer.op_Implicit Jcd.BitManipulation.BitIndexer(uint)')       | Automatically Convert from a [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32') to a [BitIndexer](Jcd.BitManipulation.BitIndexer.md 'Jcd.BitManipulation.BitIndexer')             |
| [implicit operator BitIndexer(ulong)](Jcd.BitManipulation.BitIndexer.op_ImplicitJcd.BitManipulation.BitIndexer(ulong).md 'Jcd.BitManipulation.BitIndexer.op_Implicit Jcd.BitManipulation.BitIndexer(ulong)')    | Automatically Convert from a [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64') to a [BitIndexer](Jcd.BitManipulation.BitIndexer.md 'Jcd.BitManipulation.BitIndexer')             |
| [implicit operator BitIndexer(ushort)](Jcd.BitManipulation.BitIndexer.op_ImplicitJcd.BitManipulation.BitIndexer(ushort).md 'Jcd.BitManipulation.BitIndexer.op_Implicit Jcd.BitManipulation.BitIndexer(ushort)') | Automatically Convert from a [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16') to a [BitIndexer](Jcd.BitManipulation.BitIndexer.md 'Jcd.BitManipulation.BitIndexer')             |
| [implicit operator long(BitIndexer)](Jcd.BitManipulation.BitIndexer.op_Implicitlong(Jcd.BitManipulation.BitIndexer).md 'Jcd.BitManipulation.BitIndexer.op_Implicit long(Jcd.BitManipulation.BitIndexer)')       | Automatically convert from a BitIndexer to a [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')                                                                                      |
| [implicit operator sbyte(BitIndexer)](Jcd.BitManipulation.BitIndexer.op_Implicitsbyte(Jcd.BitManipulation.BitIndexer).md 'Jcd.BitManipulation.BitIndexer.op_Implicit sbyte(Jcd.BitManipulation.BitIndexer)')    | Automatically convert from a [BitIndexer](Jcd.BitManipulation.BitIndexer.md 'Jcd.BitManipulation.BitIndexer') to a [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')                |
| [implicit operator short(BitIndexer)](Jcd.BitManipulation.BitIndexer.op_Implicitshort(Jcd.BitManipulation.BitIndexer).md 'Jcd.BitManipulation.BitIndexer.op_Implicit short(Jcd.BitManipulation.BitIndexer)')    | Automatically convert from a [BitIndexer](Jcd.BitManipulation.BitIndexer.md 'Jcd.BitManipulation.BitIndexer') to a [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')                |
| [implicit operator uint(BitIndexer)](Jcd.BitManipulation.BitIndexer.op_Implicituint(Jcd.BitManipulation.BitIndexer).md 'Jcd.BitManipulation.BitIndexer.op_Implicit uint(Jcd.BitManipulation.BitIndexer)')       | Automatically convert from a BitIndexer to a [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')                                                                                   |
| [implicit operator ulong(BitIndexer)](Jcd.BitManipulation.BitIndexer.op_Implicitulong(Jcd.BitManipulation.BitIndexer).md 'Jcd.BitManipulation.BitIndexer.op_Implicit ulong(Jcd.BitManipulation.BitIndexer)')    | Automatically convert from a BitIndexer to a [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')                                                                                   |
| [implicit operator ushort(BitIndexer)](Jcd.BitManipulation.BitIndexer.op_Implicitushort(Jcd.BitManipulation.BitIndexer).md 'Jcd.BitManipulation.BitIndexer.op_Implicit ushort(Jcd.BitManipulation.BitIndexer)') | Automatically convert from a BitIndexer to a [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')                                                                                   |
