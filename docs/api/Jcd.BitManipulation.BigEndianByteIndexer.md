#### [Jcd.BitManipulation](index 'index')
### [Jcd.BitManipulation](Jcd.BitManipulation 'Jcd.BitManipulation')

## BigEndianByteIndexer Struct

Provides byte level indexing operations (set, get) on the bytes of
a copied value. It provides indexer-style access to the bytes of
the value. Index zero is the most significant byte.

```csharp
public ref struct BigEndianByteIndexer
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
| [Length](Jcd.BitManipulation.BigEndianByteIndexer.Length 'Jcd.BitManipulation.BigEndianByteIndexer.Length') | The number of indexable bytes. |
| [this[int]](Jcd.BitManipulation.BigEndianByteIndexer.this[int] 'Jcd.BitManipulation.BigEndianByteIndexer.this[int]') | Access bytes from the underlying data. |

| Methods | |
| :--- | :--- |
| [Slice(int, int)](Jcd.BitManipulation.BigEndianByteIndexer.Slice(int,int) 'Jcd.BitManipulation.BigEndianByteIndexer.Slice(int, int)') | Get a subset of bytes given a starting offset and length. |
| [StoreBytes(byte[], int, int)](Jcd.BitManipulation.BigEndianByteIndexer.StoreBytes(byte[],int,int) 'Jcd.BitManipulation.BigEndianByteIndexer.StoreBytes(byte[], int, int)') | Stores a set of bytes starting at the specified byte location within the indexer. |
| [StoreBytes(ReadOnlySpan&lt;byte&gt;, int, int)](Jcd.BitManipulation.BigEndianByteIndexer.StoreBytes(System.ReadOnlySpan_byte_,int,int) 'Jcd.BitManipulation.BigEndianByteIndexer.StoreBytes(System.ReadOnlySpan<byte>, int, int)') | Stores a set of bytes starting at the specified byte location within the indexer. |
| [ToString()](Jcd.BitManipulation.BigEndianByteIndexer.ToString() 'Jcd.BitManipulation.BigEndianByteIndexer.ToString()') | Formats the [BigEndianByteIndexer](Jcd.BitManipulation.BigEndianByteIndexer 'Jcd.BitManipulation.BigEndianByteIndexer') as a hexadecimal string in big endian notation. For example: `60 0D C0 DE` |

| Operators | |
| :--- | :--- |
| [explicit operator byte[](BigEndianByteIndexer)](Jcd.BitManipulation.BigEndianByteIndexer.op_Explicitbyte[](Jcd.BitManipulation.BigEndianByteIndexer) 'Jcd.BitManipulation.BigEndianByteIndexer.op_Explicit byte[](Jcd.BitManipulation.BigEndianByteIndexer)') | Explicitly converts the [BigEndianByteIndexer](Jcd.BitManipulation.BigEndianByteIndexer 'Jcd.BitManipulation.BigEndianByteIndexer') to a array of bytes. |
| [explicit operator BigEndianByteIndexer(byte[])](Jcd.BitManipulation.BigEndianByteIndexer.op_ExplicitJcd.BitManipulation.BigEndianByteIndexer(byte[]) 'Jcd.BitManipulation.BigEndianByteIndexer.op_Explicit Jcd.BitManipulation.BigEndianByteIndexer(byte[])') | Explicitly converts an array of  bytes to a [BigEndianByteIndexer](Jcd.BitManipulation.BigEndianByteIndexer 'Jcd.BitManipulation.BigEndianByteIndexer'). |
| [explicit operator BigEndianByteIndexer(LittleEndianByteIndexer)](Jcd.BitManipulation.BigEndianByteIndexer.op_ExplicitJcd.BitManipulation.BigEndianByteIndexer(Jcd.BitManipulation.LittleEndianByteIndexer) 'Jcd.BitManipulation.BigEndianByteIndexer.op_Explicit Jcd.BitManipulation.BigEndianByteIndexer(Jcd.BitManipulation.LittleEndianByteIndexer)') | Explicitly converts a [LittleEndianByteIndexer](Jcd.BitManipulation.LittleEndianByteIndexer 'Jcd.BitManipulation.LittleEndianByteIndexer') to a [BigEndianByteIndexer](Jcd.BitManipulation.BigEndianByteIndexer 'Jcd.BitManipulation.BigEndianByteIndexer'). |
| [explicit operator BigEndianByteIndexer(ReadOnlySpan&lt;byte&gt;)](Jcd.BitManipulation.BigEndianByteIndexer.op_ExplicitJcd.BitManipulation.BigEndianByteIndexer(System.ReadOnlySpan_byte_) 'Jcd.BitManipulation.BigEndianByteIndexer.op_Explicit Jcd.BitManipulation.BigEndianByteIndexer(System.ReadOnlySpan<byte>)') | Explicitly converts an array of  bytes to a [BigEndianByteIndexer](Jcd.BitManipulation.BigEndianByteIndexer 'Jcd.BitManipulation.BigEndianByteIndexer'). |
| [explicit operator ReadOnlySpan&lt;byte&gt;(BigEndianByteIndexer)](Jcd.BitManipulation.BigEndianByteIndexer.op_ExplicitSystem.ReadOnlySpan_byte_(Jcd.BitManipulation.BigEndianByteIndexer) 'Jcd.BitManipulation.BigEndianByteIndexer.op_Explicit System.ReadOnlySpan<byte>(Jcd.BitManipulation.BigEndianByteIndexer)') | Explicitly converts the [BigEndianByteIndexer](Jcd.BitManipulation.BigEndianByteIndexer 'Jcd.BitManipulation.BigEndianByteIndexer') to a [System.ReadOnlySpan&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.ReadOnlySpan-1 'System.ReadOnlySpan`1') of bytes. |
| [implicit operator byte(BigEndianByteIndexer)](Jcd.BitManipulation.BigEndianByteIndexer.op_Implicitbyte(Jcd.BitManipulation.BigEndianByteIndexer) 'Jcd.BitManipulation.BigEndianByteIndexer.op_Implicit byte(Jcd.BitManipulation.BigEndianByteIndexer)') | Implicitly converts the [BigEndianByteIndexer](Jcd.BitManipulation.BigEndianByteIndexer 'Jcd.BitManipulation.BigEndianByteIndexer') to a [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte'). |
| [implicit operator double(BigEndianByteIndexer)](Jcd.BitManipulation.BigEndianByteIndexer.op_Implicitdouble(Jcd.BitManipulation.BigEndianByteIndexer) 'Jcd.BitManipulation.BigEndianByteIndexer.op_Implicit double(Jcd.BitManipulation.BigEndianByteIndexer)') | Implicitly converts the [BigEndianByteIndexer](Jcd.BitManipulation.BigEndianByteIndexer 'Jcd.BitManipulation.BigEndianByteIndexer') to a [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double'). |
| [implicit operator float(BigEndianByteIndexer)](Jcd.BitManipulation.BigEndianByteIndexer.op_Implicitfloat(Jcd.BitManipulation.BigEndianByteIndexer) 'Jcd.BitManipulation.BigEndianByteIndexer.op_Implicit float(Jcd.BitManipulation.BigEndianByteIndexer)') | Implicitly converts the [BigEndianByteIndexer](Jcd.BitManipulation.BigEndianByteIndexer 'Jcd.BitManipulation.BigEndianByteIndexer') to a [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single'). |
| [implicit operator int(BigEndianByteIndexer)](Jcd.BitManipulation.BigEndianByteIndexer.op_Implicitint(Jcd.BitManipulation.BigEndianByteIndexer) 'Jcd.BitManipulation.BigEndianByteIndexer.op_Implicit int(Jcd.BitManipulation.BigEndianByteIndexer)') | Implicitly converts the [BigEndianByteIndexer](Jcd.BitManipulation.BigEndianByteIndexer 'Jcd.BitManipulation.BigEndianByteIndexer') to a [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32'). |
| [implicit operator BigEndianByteIndexer(byte)](Jcd.BitManipulation.BigEndianByteIndexer.op_ImplicitJcd.BitManipulation.BigEndianByteIndexer(byte) 'Jcd.BitManipulation.BigEndianByteIndexer.op_Implicit Jcd.BitManipulation.BigEndianByteIndexer(byte)') | Implicitly converts a [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte') to a [BigEndianByteIndexer](Jcd.BitManipulation.BigEndianByteIndexer 'Jcd.BitManipulation.BigEndianByteIndexer'). |
| [implicit operator BigEndianByteIndexer(double)](Jcd.BitManipulation.BigEndianByteIndexer.op_ImplicitJcd.BitManipulation.BigEndianByteIndexer(double) 'Jcd.BitManipulation.BigEndianByteIndexer.op_Implicit Jcd.BitManipulation.BigEndianByteIndexer(double)') | Implicitly converts a [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double') to a [BigEndianByteIndexer](Jcd.BitManipulation.BigEndianByteIndexer 'Jcd.BitManipulation.BigEndianByteIndexer'). |
| [implicit operator BigEndianByteIndexer(float)](Jcd.BitManipulation.BigEndianByteIndexer.op_ImplicitJcd.BitManipulation.BigEndianByteIndexer(float) 'Jcd.BitManipulation.BigEndianByteIndexer.op_Implicit Jcd.BitManipulation.BigEndianByteIndexer(float)') | Implicitly converts a [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single') to a [BigEndianByteIndexer](Jcd.BitManipulation.BigEndianByteIndexer 'Jcd.BitManipulation.BigEndianByteIndexer'). |
| [implicit operator BigEndianByteIndexer(int)](Jcd.BitManipulation.BigEndianByteIndexer.op_ImplicitJcd.BitManipulation.BigEndianByteIndexer(int) 'Jcd.BitManipulation.BigEndianByteIndexer.op_Implicit Jcd.BitManipulation.BigEndianByteIndexer(int)') | Implicitly converts a [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32') to a [BigEndianByteIndexer](Jcd.BitManipulation.BigEndianByteIndexer 'Jcd.BitManipulation.BigEndianByteIndexer'). |
| [implicit operator BigEndianByteIndexer(long)](Jcd.BitManipulation.BigEndianByteIndexer.op_ImplicitJcd.BitManipulation.BigEndianByteIndexer(long) 'Jcd.BitManipulation.BigEndianByteIndexer.op_Implicit Jcd.BitManipulation.BigEndianByteIndexer(long)') | Implicitly converts a [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64') to a [BigEndianByteIndexer](Jcd.BitManipulation.BigEndianByteIndexer 'Jcd.BitManipulation.BigEndianByteIndexer'). |
| [implicit operator BigEndianByteIndexer(sbyte)](Jcd.BitManipulation.BigEndianByteIndexer.op_ImplicitJcd.BitManipulation.BigEndianByteIndexer(sbyte) 'Jcd.BitManipulation.BigEndianByteIndexer.op_Implicit Jcd.BitManipulation.BigEndianByteIndexer(sbyte)') | Implicitly converts a [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte') to a [BigEndianByteIndexer](Jcd.BitManipulation.BigEndianByteIndexer 'Jcd.BitManipulation.BigEndianByteIndexer'). |
| [implicit operator BigEndianByteIndexer(short)](Jcd.BitManipulation.BigEndianByteIndexer.op_ImplicitJcd.BitManipulation.BigEndianByteIndexer(short) 'Jcd.BitManipulation.BigEndianByteIndexer.op_Implicit Jcd.BitManipulation.BigEndianByteIndexer(short)') | Implicitly converts a [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16') to a [BigEndianByteIndexer](Jcd.BitManipulation.BigEndianByteIndexer 'Jcd.BitManipulation.BigEndianByteIndexer'). |
| [implicit operator BigEndianByteIndexer(uint)](Jcd.BitManipulation.BigEndianByteIndexer.op_ImplicitJcd.BitManipulation.BigEndianByteIndexer(uint) 'Jcd.BitManipulation.BigEndianByteIndexer.op_Implicit Jcd.BitManipulation.BigEndianByteIndexer(uint)') | Implicitly converts a [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32') to a [BigEndianByteIndexer](Jcd.BitManipulation.BigEndianByteIndexer 'Jcd.BitManipulation.BigEndianByteIndexer'). |
| [implicit operator BigEndianByteIndexer(ulong)](Jcd.BitManipulation.BigEndianByteIndexer.op_ImplicitJcd.BitManipulation.BigEndianByteIndexer(ulong) 'Jcd.BitManipulation.BigEndianByteIndexer.op_Implicit Jcd.BitManipulation.BigEndianByteIndexer(ulong)') | Implicitly converts a [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64') to a [BigEndianByteIndexer](Jcd.BitManipulation.BigEndianByteIndexer 'Jcd.BitManipulation.BigEndianByteIndexer'). |
| [implicit operator BigEndianByteIndexer(ushort)](Jcd.BitManipulation.BigEndianByteIndexer.op_ImplicitJcd.BitManipulation.BigEndianByteIndexer(ushort) 'Jcd.BitManipulation.BigEndianByteIndexer.op_Implicit Jcd.BitManipulation.BigEndianByteIndexer(ushort)') | Implicitly converts a [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16') to a [BigEndianByteIndexer](Jcd.BitManipulation.BigEndianByteIndexer 'Jcd.BitManipulation.BigEndianByteIndexer'). |
| [implicit operator long(BigEndianByteIndexer)](Jcd.BitManipulation.BigEndianByteIndexer.op_Implicitlong(Jcd.BitManipulation.BigEndianByteIndexer) 'Jcd.BitManipulation.BigEndianByteIndexer.op_Implicit long(Jcd.BitManipulation.BigEndianByteIndexer)') | Implicitly converts the [BigEndianByteIndexer](Jcd.BitManipulation.BigEndianByteIndexer 'Jcd.BitManipulation.BigEndianByteIndexer') to a [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64'). |
| [implicit operator sbyte(BigEndianByteIndexer)](Jcd.BitManipulation.BigEndianByteIndexer.op_Implicitsbyte(Jcd.BitManipulation.BigEndianByteIndexer) 'Jcd.BitManipulation.BigEndianByteIndexer.op_Implicit sbyte(Jcd.BitManipulation.BigEndianByteIndexer)') | Implicitly converts the [BigEndianByteIndexer](Jcd.BitManipulation.BigEndianByteIndexer 'Jcd.BitManipulation.BigEndianByteIndexer') to a [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte'). |
| [implicit operator short(BigEndianByteIndexer)](Jcd.BitManipulation.BigEndianByteIndexer.op_Implicitshort(Jcd.BitManipulation.BigEndianByteIndexer) 'Jcd.BitManipulation.BigEndianByteIndexer.op_Implicit short(Jcd.BitManipulation.BigEndianByteIndexer)') | Implicitly converts the [BigEndianByteIndexer](Jcd.BitManipulation.BigEndianByteIndexer 'Jcd.BitManipulation.BigEndianByteIndexer') to a [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16'). |
| [implicit operator uint(BigEndianByteIndexer)](Jcd.BitManipulation.BigEndianByteIndexer.op_Implicituint(Jcd.BitManipulation.BigEndianByteIndexer) 'Jcd.BitManipulation.BigEndianByteIndexer.op_Implicit uint(Jcd.BitManipulation.BigEndianByteIndexer)') | Implicitly converts the [BigEndianByteIndexer](Jcd.BitManipulation.BigEndianByteIndexer 'Jcd.BitManipulation.BigEndianByteIndexer') to a [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32'). |
| [implicit operator ulong(BigEndianByteIndexer)](Jcd.BitManipulation.BigEndianByteIndexer.op_Implicitulong(Jcd.BitManipulation.BigEndianByteIndexer) 'Jcd.BitManipulation.BigEndianByteIndexer.op_Implicit ulong(Jcd.BitManipulation.BigEndianByteIndexer)') | Implicitly converts the [BigEndianByteIndexer](Jcd.BitManipulation.BigEndianByteIndexer 'Jcd.BitManipulation.BigEndianByteIndexer') to a [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64'). |
| [implicit operator ushort(BigEndianByteIndexer)](Jcd.BitManipulation.BigEndianByteIndexer.op_Implicitushort(Jcd.BitManipulation.BigEndianByteIndexer) 'Jcd.BitManipulation.BigEndianByteIndexer.op_Implicit ushort(Jcd.BitManipulation.BigEndianByteIndexer)') | Implicitly converts the [BigEndianByteIndexer](Jcd.BitManipulation.BigEndianByteIndexer 'Jcd.BitManipulation.BigEndianByteIndexer') to a [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16'). |
