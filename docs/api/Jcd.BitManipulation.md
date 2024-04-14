#### [Jcd.BitManipulation](index 'index')

## Jcd.BitManipulation Namespace

Provides extension methods and types that makes code for bit and byte manipulation
on intrinsic data types easier to read vs the standard operators: `&, \|, ^, and ~`.
These are provided for C# supported types.

| Classes | |
| :--- | :--- |
| [BooleanArrayExtensions](Jcd.BitManipulation.BooleanArrayExtensions 'Jcd.BitManipulation.BooleanArrayExtensions') | Provides facilities to convert to numbers from arrays of [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean') values. At their respective bit positions, [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool')  is translated to 1 and [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') is translated to 0. |
| [ByteArrayExtensions](Jcd.BitManipulation.ByteArrayExtensions 'Jcd.BitManipulation.ByteArrayExtensions') | Provides facilities to convert an array of bytes to other data types. |
| [ByteExtensions](Jcd.BitManipulation.ByteExtensions 'Jcd.BitManipulation.ByteExtensions') | Provides easy to read methods for bit manipulation operations on a [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte') |
| [DoubleExtensions](Jcd.BitManipulation.DoubleExtensions 'Jcd.BitManipulation.DoubleExtensions') | Provides easy to read methods for bit manipulation operations on a [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double') |
| [Int16Extensions](Jcd.BitManipulation.Int16Extensions 'Jcd.BitManipulation.Int16Extensions') | Provides easy to read methods for bit manipulation operations on a [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16') |
| [Int32Extensions](Jcd.BitManipulation.Int32Extensions 'Jcd.BitManipulation.Int32Extensions') | Provides easy to read methods for bit manipulation operations on a [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32') |
| [Int64Extensions](Jcd.BitManipulation.Int64Extensions 'Jcd.BitManipulation.Int64Extensions') | Provides easy to read methods for bit manipulation operations on a [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64') |
| [ReadOnlySpanOfByteExtensions](Jcd.BitManipulation.ReadOnlySpanOfByteExtensions 'Jcd.BitManipulation.ReadOnlySpanOfByteExtensions') | Provides facilities to convert [System.ReadOnlySpan&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.ReadOnlySpan-1 'System.ReadOnlySpan`1') of bytes to other data types. |
| [SByteExtensions](Jcd.BitManipulation.SByteExtensions 'Jcd.BitManipulation.SByteExtensions') | Provides easy to read methods for bit manipulation operations on a [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte') |
| [SingleExtensions](Jcd.BitManipulation.SingleExtensions 'Jcd.BitManipulation.SingleExtensions') | Provides easy to read methods for bit manipulation operations on a [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single') |
| [UInt16Extensions](Jcd.BitManipulation.UInt16Extensions 'Jcd.BitManipulation.UInt16Extensions') | Provides easy to read methods for bit manipulation operations on a [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16') |
| [UInt32Extensions](Jcd.BitManipulation.UInt32Extensions 'Jcd.BitManipulation.UInt32Extensions') | Provides easy to read methods for bit manipulation operations on a [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32') |
| [UInt64Extensions](Jcd.BitManipulation.UInt64Extensions 'Jcd.BitManipulation.UInt64Extensions') | Provides easy to read methods for bit manipulation operations on a [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64') |

| Structs | |
| :--- | :--- |
| [BigEndianByteIndexer](Jcd.BitManipulation.BigEndianByteIndexer 'Jcd.BitManipulation.BigEndianByteIndexer') | Provides byte level indexing operations (set, get) on the bytes of a copied value. It provides indexer-style access to the bytes of the value. Index zero is the most significant byte. |
| [BitIndexer](Jcd.BitManipulation.BitIndexer 'Jcd.BitManipulation.BitIndexer') | Provides indexer style access to the bits on a copied value. |
| [BitMask](Jcd.BitManipulation.BitMask 'Jcd.BitManipulation.BitMask') | Provides an integer size independent representation of a bit mask and helper methods to simplify creating bit masks. |
| [LittleEndianByteIndexer](Jcd.BitManipulation.LittleEndianByteIndexer 'Jcd.BitManipulation.LittleEndianByteIndexer') | Provides byte level indexing operations (set, get) on the bytes of a copied value. It provides indexer-style access to the bytes of the value. Index zero is the least significant byte. |

| Enums | |
| :--- | :--- |
| [ByteAlignment](Jcd.BitManipulation.ByteAlignment 'Jcd.BitManipulation.ByteAlignment') | Indicates how to align partially filled data when converting from collections of bytes. |
| [Endian](Jcd.BitManipulation.Endian 'Jcd.BitManipulation.Endian') | The order of the bytes in memory. |