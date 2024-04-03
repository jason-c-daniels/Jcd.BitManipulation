#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation')

## LittleEndianByteIndexer Struct

Provides byte level indexing operations (set, get) on the bytes of
a copied value. It provides indexer-style access to the bytes of
the value. Index zero is the least significant byte.

```csharp
public ref struct LittleEndianByteIndexer
```

### Example

```csharp
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

| Properties | |
| :--- | :--- |
| [Length](Jcd.BitManipulation.LittleEndianByteIndexer.Length.md 'Jcd.BitManipulation.LittleEndianByteIndexer.Length') | The number of bytes this type will index |
| [this[int]](Jcd.BitManipulation.LittleEndianByteIndexer.this[int].md 'Jcd.BitManipulation.LittleEndianByteIndexer.this[int]') | Access bytes from the underlying data. |

| Methods | |
| :--- | :--- |
| [Slice(int, int)](Jcd.BitManipulation.LittleEndianByteIndexer.Slice(int,int).md 'Jcd.BitManipulation.LittleEndianByteIndexer.Slice(int, int)') | Get a subset of bytes given a starting offset and length. |
| [StoreBytes(byte[], int, int)](Jcd.BitManipulation.LittleEndianByteIndexer.StoreBytes(byte[],int,int).md 'Jcd.BitManipulation.LittleEndianByteIndexer.StoreBytes(byte[], int, int)') | Stores a set of bytes starting at the specified byte location within the indexer. |
| [StoreBytes(ReadOnlySpan&lt;byte&gt;, int, int)](Jcd.BitManipulation.LittleEndianByteIndexer.StoreBytes(System.ReadOnlySpan_byte_,int,int).md 'Jcd.BitManipulation.LittleEndianByteIndexer.StoreBytes(System.ReadOnlySpan<byte>, int, int)') | Stores a set of bytes starting at the specified byte location within the indexer. |
| [ToString()](Jcd.BitManipulation.LittleEndianByteIndexer.ToString().md 'Jcd.BitManipulation.LittleEndianByteIndexer.ToString()') | Formats the [LittleEndianByteIndexer](Jcd.BitManipulation.LittleEndianByteIndexer.md 'Jcd.BitManipulation.LittleEndianByteIndexer') as a hexadecimal string in big endian notation. For example: `DE C0 0D 60` |

| Operators | |
| :--- | :--- |
| [explicit operator byte[](LittleEndianByteIndexer)](Jcd.BitManipulation.LittleEndianByteIndexer.op_Explicitbyte[](Jcd.BitManipulation.LittleEndianByteIndexer).md 'Jcd.BitManipulation.LittleEndianByteIndexer.op_Explicit byte[](Jcd.BitManipulation.LittleEndianByteIndexer)') | Explicitly converts the [LittleEndianByteIndexer](Jcd.BitManipulation.LittleEndianByteIndexer.md 'Jcd.BitManipulation.LittleEndianByteIndexer') to an array of bytes. |
| [explicit operator LittleEndianByteIndexer(byte[])](Jcd.BitManipulation.LittleEndianByteIndexer.op_ExplicitJcd.BitManipulation.LittleEndianByteIndexer(byte[]).md 'Jcd.BitManipulation.LittleEndianByteIndexer.op_Explicit Jcd.BitManipulation.LittleEndianByteIndexer(byte[])') | Explicitly converts an array of  bytes to a [LittleEndianByteIndexer](Jcd.BitManipulation.LittleEndianByteIndexer.md 'Jcd.BitManipulation.LittleEndianByteIndexer'). |
| [explicit operator LittleEndianByteIndexer(BigEndianByteIndexer)](Jcd.BitManipulation.LittleEndianByteIndexer.op_ExplicitJcd.BitManipulation.LittleEndianByteIndexer(Jcd.BitManipulation.BigEndianByteIndexer).md 'Jcd.BitManipulation.LittleEndianByteIndexer.op_Explicit Jcd.BitManipulation.LittleEndianByteIndexer(Jcd.BitManipulation.BigEndianByteIndexer)') | Explicitly converts a [BigEndianByteIndexer](Jcd.BitManipulation.BigEndianByteIndexer.md 'Jcd.BitManipulation.BigEndianByteIndexer') to a [LittleEndianByteIndexer](Jcd.BitManipulation.LittleEndianByteIndexer.md 'Jcd.BitManipulation.LittleEndianByteIndexer'). |
| [explicit operator LittleEndianByteIndexer(ReadOnlySpan&lt;byte&gt;)](Jcd.BitManipulation.LittleEndianByteIndexer.op_ExplicitJcd.BitManipulation.LittleEndianByteIndexer(System.ReadOnlySpan_byte_).md 'Jcd.BitManipulation.LittleEndianByteIndexer.op_Explicit Jcd.BitManipulation.LittleEndianByteIndexer(System.ReadOnlySpan<byte>)') | Explicitly converts an array of  bytes to a [LittleEndianByteIndexer](Jcd.BitManipulation.LittleEndianByteIndexer.md 'Jcd.BitManipulation.LittleEndianByteIndexer'). |
| [explicit operator ReadOnlySpan&lt;byte&gt;(LittleEndianByteIndexer)](Jcd.BitManipulation.LittleEndianByteIndexer.op_ExplicitSystem.ReadOnlySpan_byte_(Jcd.BitManipulation.LittleEndianByteIndexer).md 'Jcd.BitManipulation.LittleEndianByteIndexer.op_Explicit System.ReadOnlySpan<byte>(Jcd.BitManipulation.LittleEndianByteIndexer)') | Explicitly converts the [LittleEndianByteIndexer](Jcd.BitManipulation.LittleEndianByteIndexer.md 'Jcd.BitManipulation.LittleEndianByteIndexer') to an array of bytes. |
| [implicit operator byte(LittleEndianByteIndexer)](Jcd.BitManipulation.LittleEndianByteIndexer.op_Implicitbyte(Jcd.BitManipulation.LittleEndianByteIndexer).md 'Jcd.BitManipulation.LittleEndianByteIndexer.op_Implicit byte(Jcd.BitManipulation.LittleEndianByteIndexer)') | Implicitly converts the [LittleEndianByteIndexer](Jcd.BitManipulation.LittleEndianByteIndexer.md 'Jcd.BitManipulation.LittleEndianByteIndexer') to a [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64'). |
| [implicit operator double(LittleEndianByteIndexer)](Jcd.BitManipulation.LittleEndianByteIndexer.op_Implicitdouble(Jcd.BitManipulation.LittleEndianByteIndexer).md 'Jcd.BitManipulation.LittleEndianByteIndexer.op_Implicit double(Jcd.BitManipulation.LittleEndianByteIndexer)') | Implicitly converts the byte indexer to its underlying data type. |
| [implicit operator float(LittleEndianByteIndexer)](Jcd.BitManipulation.LittleEndianByteIndexer.op_Implicitfloat(Jcd.BitManipulation.LittleEndianByteIndexer).md 'Jcd.BitManipulation.LittleEndianByteIndexer.op_Implicit float(Jcd.BitManipulation.LittleEndianByteIndexer)') | Implicitly converts the [LittleEndianByteIndexer](Jcd.BitManipulation.LittleEndianByteIndexer.md 'Jcd.BitManipulation.LittleEndianByteIndexer') to a [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single'). |
| [implicit operator int(LittleEndianByteIndexer)](Jcd.BitManipulation.LittleEndianByteIndexer.op_Implicitint(Jcd.BitManipulation.LittleEndianByteIndexer).md 'Jcd.BitManipulation.LittleEndianByteIndexer.op_Implicit int(Jcd.BitManipulation.LittleEndianByteIndexer)') | Implicitly converts the [LittleEndianByteIndexer](Jcd.BitManipulation.LittleEndianByteIndexer.md 'Jcd.BitManipulation.LittleEndianByteIndexer') to a [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64'). |
| [implicit operator LittleEndianByteIndexer(byte)](Jcd.BitManipulation.LittleEndianByteIndexer.op_ImplicitJcd.BitManipulation.LittleEndianByteIndexer(byte).md 'Jcd.BitManipulation.LittleEndianByteIndexer.op_Implicit Jcd.BitManipulation.LittleEndianByteIndexer(byte)') | Implicitly converts a [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte') to a [LittleEndianByteIndexer](Jcd.BitManipulation.LittleEndianByteIndexer.md 'Jcd.BitManipulation.LittleEndianByteIndexer'). |
| [implicit operator LittleEndianByteIndexer(double)](Jcd.BitManipulation.LittleEndianByteIndexer.op_ImplicitJcd.BitManipulation.LittleEndianByteIndexer(double).md 'Jcd.BitManipulation.LittleEndianByteIndexer.op_Implicit Jcd.BitManipulation.LittleEndianByteIndexer(double)') | Implicitly converts a [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double') to a [LittleEndianByteIndexer](Jcd.BitManipulation.LittleEndianByteIndexer.md 'Jcd.BitManipulation.LittleEndianByteIndexer'). |
| [implicit operator LittleEndianByteIndexer(float)](Jcd.BitManipulation.LittleEndianByteIndexer.op_ImplicitJcd.BitManipulation.LittleEndianByteIndexer(float).md 'Jcd.BitManipulation.LittleEndianByteIndexer.op_Implicit Jcd.BitManipulation.LittleEndianByteIndexer(float)') | Implicitly converts a [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single') to a [LittleEndianByteIndexer](Jcd.BitManipulation.LittleEndianByteIndexer.md 'Jcd.BitManipulation.LittleEndianByteIndexer'). |
| [implicit operator LittleEndianByteIndexer(int)](Jcd.BitManipulation.LittleEndianByteIndexer.op_ImplicitJcd.BitManipulation.LittleEndianByteIndexer(int).md 'Jcd.BitManipulation.LittleEndianByteIndexer.op_Implicit Jcd.BitManipulation.LittleEndianByteIndexer(int)') | Implicitly converts a [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32') to a [LittleEndianByteIndexer](Jcd.BitManipulation.LittleEndianByteIndexer.md 'Jcd.BitManipulation.LittleEndianByteIndexer'). |
| [implicit operator LittleEndianByteIndexer(long)](Jcd.BitManipulation.LittleEndianByteIndexer.op_ImplicitJcd.BitManipulation.LittleEndianByteIndexer(long).md 'Jcd.BitManipulation.LittleEndianByteIndexer.op_Implicit Jcd.BitManipulation.LittleEndianByteIndexer(long)') | Implicitly converts a [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64') to a [LittleEndianByteIndexer](Jcd.BitManipulation.LittleEndianByteIndexer.md 'Jcd.BitManipulation.LittleEndianByteIndexer'). |
| [implicit operator LittleEndianByteIndexer(sbyte)](Jcd.BitManipulation.LittleEndianByteIndexer.op_ImplicitJcd.BitManipulation.LittleEndianByteIndexer(sbyte).md 'Jcd.BitManipulation.LittleEndianByteIndexer.op_Implicit Jcd.BitManipulation.LittleEndianByteIndexer(sbyte)') | Implicitly converts a [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte') to a [LittleEndianByteIndexer](Jcd.BitManipulation.LittleEndianByteIndexer.md 'Jcd.BitManipulation.LittleEndianByteIndexer'). |
| [implicit operator LittleEndianByteIndexer(short)](Jcd.BitManipulation.LittleEndianByteIndexer.op_ImplicitJcd.BitManipulation.LittleEndianByteIndexer(short).md 'Jcd.BitManipulation.LittleEndianByteIndexer.op_Implicit Jcd.BitManipulation.LittleEndianByteIndexer(short)') | Implicitly converts a [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16') to a [LittleEndianByteIndexer](Jcd.BitManipulation.LittleEndianByteIndexer.md 'Jcd.BitManipulation.LittleEndianByteIndexer'). |
| [implicit operator LittleEndianByteIndexer(uint)](Jcd.BitManipulation.LittleEndianByteIndexer.op_ImplicitJcd.BitManipulation.LittleEndianByteIndexer(uint).md 'Jcd.BitManipulation.LittleEndianByteIndexer.op_Implicit Jcd.BitManipulation.LittleEndianByteIndexer(uint)') | Implicitly converts a [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32') to a [LittleEndianByteIndexer](Jcd.BitManipulation.LittleEndianByteIndexer.md 'Jcd.BitManipulation.LittleEndianByteIndexer'). |
| [implicit operator LittleEndianByteIndexer(ulong)](Jcd.BitManipulation.LittleEndianByteIndexer.op_ImplicitJcd.BitManipulation.LittleEndianByteIndexer(ulong).md 'Jcd.BitManipulation.LittleEndianByteIndexer.op_Implicit Jcd.BitManipulation.LittleEndianByteIndexer(ulong)') | Implicitly converts a [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64') to a [LittleEndianByteIndexer](Jcd.BitManipulation.LittleEndianByteIndexer.md 'Jcd.BitManipulation.LittleEndianByteIndexer'). |
| [implicit operator LittleEndianByteIndexer(ushort)](Jcd.BitManipulation.LittleEndianByteIndexer.op_ImplicitJcd.BitManipulation.LittleEndianByteIndexer(ushort).md 'Jcd.BitManipulation.LittleEndianByteIndexer.op_Implicit Jcd.BitManipulation.LittleEndianByteIndexer(ushort)') | Implicitly converts a [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16') to a [LittleEndianByteIndexer](Jcd.BitManipulation.LittleEndianByteIndexer.md 'Jcd.BitManipulation.LittleEndianByteIndexer'). |
| [implicit operator long(LittleEndianByteIndexer)](Jcd.BitManipulation.LittleEndianByteIndexer.op_Implicitlong(Jcd.BitManipulation.LittleEndianByteIndexer).md 'Jcd.BitManipulation.LittleEndianByteIndexer.op_Implicit long(Jcd.BitManipulation.LittleEndianByteIndexer)') | Implicitly converts the [LittleEndianByteIndexer](Jcd.BitManipulation.LittleEndianByteIndexer.md 'Jcd.BitManipulation.LittleEndianByteIndexer') to a [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64'). |
| [implicit operator sbyte(LittleEndianByteIndexer)](Jcd.BitManipulation.LittleEndianByteIndexer.op_Implicitsbyte(Jcd.BitManipulation.LittleEndianByteIndexer).md 'Jcd.BitManipulation.LittleEndianByteIndexer.op_Implicit sbyte(Jcd.BitManipulation.LittleEndianByteIndexer)') | Implicitly converts the [LittleEndianByteIndexer](Jcd.BitManipulation.LittleEndianByteIndexer.md 'Jcd.BitManipulation.LittleEndianByteIndexer') to a [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64'). |
| [implicit operator short(LittleEndianByteIndexer)](Jcd.BitManipulation.LittleEndianByteIndexer.op_Implicitshort(Jcd.BitManipulation.LittleEndianByteIndexer).md 'Jcd.BitManipulation.LittleEndianByteIndexer.op_Implicit short(Jcd.BitManipulation.LittleEndianByteIndexer)') | Implicitly converts the [LittleEndianByteIndexer](Jcd.BitManipulation.LittleEndianByteIndexer.md 'Jcd.BitManipulation.LittleEndianByteIndexer') to a [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64'). |
| [implicit operator uint(LittleEndianByteIndexer)](Jcd.BitManipulation.LittleEndianByteIndexer.op_Implicituint(Jcd.BitManipulation.LittleEndianByteIndexer).md 'Jcd.BitManipulation.LittleEndianByteIndexer.op_Implicit uint(Jcd.BitManipulation.LittleEndianByteIndexer)') | Implicitly converts the [LittleEndianByteIndexer](Jcd.BitManipulation.LittleEndianByteIndexer.md 'Jcd.BitManipulation.LittleEndianByteIndexer') to a [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64'). |
| [implicit operator ulong(LittleEndianByteIndexer)](Jcd.BitManipulation.LittleEndianByteIndexer.op_Implicitulong(Jcd.BitManipulation.LittleEndianByteIndexer).md 'Jcd.BitManipulation.LittleEndianByteIndexer.op_Implicit ulong(Jcd.BitManipulation.LittleEndianByteIndexer)') | Implicitly converts the [LittleEndianByteIndexer](Jcd.BitManipulation.LittleEndianByteIndexer.md 'Jcd.BitManipulation.LittleEndianByteIndexer') to a [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64'). |
| [implicit operator ushort(LittleEndianByteIndexer)](Jcd.BitManipulation.LittleEndianByteIndexer.op_Implicitushort(Jcd.BitManipulation.LittleEndianByteIndexer).md 'Jcd.BitManipulation.LittleEndianByteIndexer.op_Implicit ushort(Jcd.BitManipulation.LittleEndianByteIndexer)') | Implicitly converts the [LittleEndianByteIndexer](Jcd.BitManipulation.LittleEndianByteIndexer.md 'Jcd.BitManipulation.LittleEndianByteIndexer') to a [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64'). |
