#### [Jcd.BitManipulation](index 'index')
### [Jcd.BitManipulation](Jcd.BitManipulation 'Jcd.BitManipulation')

## BitMask Struct

Provides an integer size independent representation of a bit mask
and helper methods to simplify creating bit masks.

```csharp
public readonly struct BitMask :
System.IEquatable<Jcd.BitManipulation.BitMask>
```

Implements [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[BitMask](Jcd.BitManipulation.BitMask 'Jcd.BitManipulation.BitMask')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')

| Constructors | |
| :--- | :--- |
| [BitMask(byte)](Jcd.BitManipulation.BitMask.BitMask(byte) 'Jcd.BitManipulation.BitMask.BitMask(byte)') | Constructs a [BitMask](Jcd.BitManipulation.BitMask 'Jcd.BitManipulation.BitMask') from a [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte') |
| [BitMask(int)](Jcd.BitManipulation.BitMask.BitMask(int) 'Jcd.BitManipulation.BitMask.BitMask(int)') | Constructs a [BitMask](Jcd.BitManipulation.BitMask 'Jcd.BitManipulation.BitMask') from a [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32') |
| [BitMask(BitMask)](Jcd.BitManipulation.BitMask.BitMask(Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.BitMask.BitMask(Jcd.BitManipulation.BitMask)') | Copies a existing [BitMask](Jcd.BitManipulation.BitMask 'Jcd.BitManipulation.BitMask') |
| [BitMask(long)](Jcd.BitManipulation.BitMask.BitMask(long) 'Jcd.BitManipulation.BitMask.BitMask(long)') | Constructs a [BitMask](Jcd.BitManipulation.BitMask 'Jcd.BitManipulation.BitMask') from a [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64') |
| [BitMask(sbyte)](Jcd.BitManipulation.BitMask.BitMask(sbyte) 'Jcd.BitManipulation.BitMask.BitMask(sbyte)') | Constructs a [BitMask](Jcd.BitManipulation.BitMask 'Jcd.BitManipulation.BitMask') from a [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte') |
| [BitMask(short)](Jcd.BitManipulation.BitMask.BitMask(short) 'Jcd.BitManipulation.BitMask.BitMask(short)') | Constructs a [BitMask](Jcd.BitManipulation.BitMask 'Jcd.BitManipulation.BitMask') from a [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16') |
| [BitMask(uint)](Jcd.BitManipulation.BitMask.BitMask(uint) 'Jcd.BitManipulation.BitMask.BitMask(uint)') | Constructs a [BitMask](Jcd.BitManipulation.BitMask 'Jcd.BitManipulation.BitMask') from a [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32') |
| [BitMask(ulong)](Jcd.BitManipulation.BitMask.BitMask(ulong) 'Jcd.BitManipulation.BitMask.BitMask(ulong)') | Constructs a [BitMask](Jcd.BitManipulation.BitMask 'Jcd.BitManipulation.BitMask') from a [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64') |
| [BitMask(ushort)](Jcd.BitManipulation.BitMask.BitMask(ushort) 'Jcd.BitManipulation.BitMask.BitMask(ushort)') | Constructs a [BitMask](Jcd.BitManipulation.BitMask 'Jcd.BitManipulation.BitMask') from a [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16') |

| Fields | |
| :--- | :--- |
| [AllBits](Jcd.BitManipulation.BitMask.AllBits 'Jcd.BitManipulation.BitMask.AllBits') | A bitmask with all bits set in the mask. |

| Methods | |
| :--- | :--- |
| [Equals(BitMask)](Jcd.BitManipulation.BitMask.Equals(Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.BitMask.Equals(Jcd.BitManipulation.BitMask)') | Compares this instance to another for equality. |
| [Equals(object)](Jcd.BitManipulation.BitMask.Equals(object) 'Jcd.BitManipulation.BitMask.Equals(object)') | compares this instance agains an object for equality. |
| [FromRange(int, int)](Jcd.BitManipulation.BitMask.FromRange(int,int) 'Jcd.BitManipulation.BitMask.FromRange(int, int)') | Create a [BitMask](Jcd.BitManipulation.BitMask 'Jcd.BitManipulation.BitMask') with a range of bits set. |
| [FromSingleBit(int)](Jcd.BitManipulation.BitMask.FromSingleBit(int) 'Jcd.BitManipulation.BitMask.FromSingleBit(int)') | Create a [BitMask](Jcd.BitManipulation.BitMask 'Jcd.BitManipulation.BitMask') with a single bit set. |
| [GetHashCode()](Jcd.BitManipulation.BitMask.GetHashCode() 'Jcd.BitManipulation.BitMask.GetHashCode()') | Gets the hashcode for this instance. |
| [ToString()](Jcd.BitManipulation.BitMask.ToString() 'Jcd.BitManipulation.BitMask.ToString()') | Formats the [BitMask](Jcd.BitManipulation.BitMask 'Jcd.BitManipulation.BitMask') as a "0b" prefixed string of zeroes and ones. |

| Operators | |
| :--- | :--- |
| [operator &(BitMask, BitMask)](Jcd.BitManipulation.BitMask.op_BitwiseAnd(Jcd.BitManipulation.BitMask,Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.BitMask.op_BitwiseAnd(Jcd.BitManipulation.BitMask, Jcd.BitManipulation.BitMask)') | Bitwise AND |
| [operator |(BitMask, BitMask)](Jcd.BitManipulation.BitMask.op_BitwiseOr(Jcd.BitManipulation.BitMask,Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.BitMask.op_BitwiseOr(Jcd.BitManipulation.BitMask, Jcd.BitManipulation.BitMask)') | Bitwise or |
| [operator ==(BitMask, BitMask)](Jcd.BitManipulation.BitMask.op_Equality(Jcd.BitManipulation.BitMask,Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.BitMask.op_Equality(Jcd.BitManipulation.BitMask, Jcd.BitManipulation.BitMask)') | Compares two [BitMask](Jcd.BitManipulation.BitMask 'Jcd.BitManipulation.BitMask') instances for equality. |
| [operator ^(BitMask, BitMask)](Jcd.BitManipulation.BitMask.op_ExclusiveOr(Jcd.BitManipulation.BitMask,Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.BitMask.op_ExclusiveOr(Jcd.BitManipulation.BitMask, Jcd.BitManipulation.BitMask)') | Bitwise XOR |
| [implicit operator byte(BitMask)](Jcd.BitManipulation.BitMask.op_Implicitbyte(Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.BitMask.op_Implicit byte(Jcd.BitManipulation.BitMask)') | Automatically convert to a [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte') from a [BitMask](Jcd.BitManipulation.BitMask 'Jcd.BitManipulation.BitMask') |
| [implicit operator int(BitMask)](Jcd.BitManipulation.BitMask.op_Implicitint(Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.BitMask.op_Implicit int(Jcd.BitManipulation.BitMask)') | Automatically convert to [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32') from a [BitMask](Jcd.BitManipulation.BitMask 'Jcd.BitManipulation.BitMask') |
| [implicit operator BitMask(byte)](Jcd.BitManipulation.BitMask.op_ImplicitJcd.BitManipulation.BitMask(byte) 'Jcd.BitManipulation.BitMask.op_Implicit Jcd.BitManipulation.BitMask(byte)') | Automatically convert to [BitMask](Jcd.BitManipulation.BitMask 'Jcd.BitManipulation.BitMask') from a [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte') |
| [implicit operator BitMask(int)](Jcd.BitManipulation.BitMask.op_ImplicitJcd.BitManipulation.BitMask(int) 'Jcd.BitManipulation.BitMask.op_Implicit Jcd.BitManipulation.BitMask(int)') | Automatically convert to [BitMask](Jcd.BitManipulation.BitMask 'Jcd.BitManipulation.BitMask') from a [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32') |
| [implicit operator BitMask(long)](Jcd.BitManipulation.BitMask.op_ImplicitJcd.BitManipulation.BitMask(long) 'Jcd.BitManipulation.BitMask.op_Implicit Jcd.BitManipulation.BitMask(long)') | Automatically convert to [BitMask](Jcd.BitManipulation.BitMask 'Jcd.BitManipulation.BitMask') from a [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64') |
| [implicit operator BitMask(sbyte)](Jcd.BitManipulation.BitMask.op_ImplicitJcd.BitManipulation.BitMask(sbyte) 'Jcd.BitManipulation.BitMask.op_Implicit Jcd.BitManipulation.BitMask(sbyte)') | Automatically convert to [BitMask](Jcd.BitManipulation.BitMask 'Jcd.BitManipulation.BitMask') from a [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte') |
| [implicit operator BitMask(short)](Jcd.BitManipulation.BitMask.op_ImplicitJcd.BitManipulation.BitMask(short) 'Jcd.BitManipulation.BitMask.op_Implicit Jcd.BitManipulation.BitMask(short)') | Automatically convert to [BitMask](Jcd.BitManipulation.BitMask 'Jcd.BitManipulation.BitMask') from a [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte') |
| [implicit operator BitMask(uint)](Jcd.BitManipulation.BitMask.op_ImplicitJcd.BitManipulation.BitMask(uint) 'Jcd.BitManipulation.BitMask.op_Implicit Jcd.BitManipulation.BitMask(uint)') | Automatically convert to [BitMask](Jcd.BitManipulation.BitMask 'Jcd.BitManipulation.BitMask') from a [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32') |
| [implicit operator BitMask(ulong)](Jcd.BitManipulation.BitMask.op_ImplicitJcd.BitManipulation.BitMask(ulong) 'Jcd.BitManipulation.BitMask.op_Implicit Jcd.BitManipulation.BitMask(ulong)') | Automatically convert to [BitMask](Jcd.BitManipulation.BitMask 'Jcd.BitManipulation.BitMask') from a [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64') |
| [implicit operator BitMask(ushort)](Jcd.BitManipulation.BitMask.op_ImplicitJcd.BitManipulation.BitMask(ushort) 'Jcd.BitManipulation.BitMask.op_Implicit Jcd.BitManipulation.BitMask(ushort)') | Automatically convert to [BitMask](Jcd.BitManipulation.BitMask 'Jcd.BitManipulation.BitMask') from a [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16') |
| [implicit operator long(BitMask)](Jcd.BitManipulation.BitMask.op_Implicitlong(Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.BitMask.op_Implicit long(Jcd.BitManipulation.BitMask)') | Automatically convert to [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64') from a [BitMask](Jcd.BitManipulation.BitMask 'Jcd.BitManipulation.BitMask') |
| [implicit operator sbyte(BitMask)](Jcd.BitManipulation.BitMask.op_Implicitsbyte(Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.BitMask.op_Implicit sbyte(Jcd.BitManipulation.BitMask)') | Automatically convert to a [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte') from a [BitMask](Jcd.BitManipulation.BitMask 'Jcd.BitManipulation.BitMask') |
| [implicit operator short(BitMask)](Jcd.BitManipulation.BitMask.op_Implicitshort(Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.BitMask.op_Implicit short(Jcd.BitManipulation.BitMask)') | Automatically convert to a [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16') from a [BitMask](Jcd.BitManipulation.BitMask 'Jcd.BitManipulation.BitMask') |
| [implicit operator uint(BitMask)](Jcd.BitManipulation.BitMask.op_Implicituint(Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.BitMask.op_Implicit uint(Jcd.BitManipulation.BitMask)') | Automatically convert to [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32') from a [BitMask](Jcd.BitManipulation.BitMask 'Jcd.BitManipulation.BitMask') |
| [implicit operator ulong(BitMask)](Jcd.BitManipulation.BitMask.op_Implicitulong(Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.BitMask.op_Implicit ulong(Jcd.BitManipulation.BitMask)') | Automatically convert to [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64') from a [BitMask](Jcd.BitManipulation.BitMask 'Jcd.BitManipulation.BitMask') |
| [implicit operator ushort(BitMask)](Jcd.BitManipulation.BitMask.op_Implicitushort(Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.BitMask.op_Implicit ushort(Jcd.BitManipulation.BitMask)') | Automatically convert to [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16') from a [BitMask](Jcd.BitManipulation.BitMask 'Jcd.BitManipulation.BitMask') |
| [operator !=(BitMask, BitMask)](Jcd.BitManipulation.BitMask.op_Inequality(Jcd.BitManipulation.BitMask,Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.BitMask.op_Inequality(Jcd.BitManipulation.BitMask, Jcd.BitManipulation.BitMask)') | Compares two [BitMask](Jcd.BitManipulation.BitMask 'Jcd.BitManipulation.BitMask') instances for inequality. |
| [operator &lt;&lt;(BitMask, int)](Jcd.BitManipulation.BitMask.op_LeftShift(Jcd.BitManipulation.BitMask,int) 'Jcd.BitManipulation.BitMask.op_LeftShift(Jcd.BitManipulation.BitMask, int)') | Bitwise left shift |
| [operator ~(BitMask)](Jcd.BitManipulation.BitMask.op_OnesComplement(Jcd.BitManipulation.BitMask) 'Jcd.BitManipulation.BitMask.op_OnesComplement(Jcd.BitManipulation.BitMask)') | Bitwise complement |
| [operator &gt;&gt;(BitMask, int)](Jcd.BitManipulation.BitMask.op_RightShift(Jcd.BitManipulation.BitMask,int) 'Jcd.BitManipulation.BitMask.op_RightShift(Jcd.BitManipulation.BitMask, int)') | Bitwise right shift |
