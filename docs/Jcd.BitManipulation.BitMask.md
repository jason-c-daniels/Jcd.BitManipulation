### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation')

## BitMask Struct

An abstraction and factory methods to aid in bit manipulation.

```csharp
public struct BitMask
```

| Constructors | |
| :--- | :--- |
| [BitMask(byte)](Jcd.BitManipulation.BitMask.BitMask(byte).md 'Jcd.BitManipulation.BitMask.BitMask(byte)') | Create a bitmask |
| [BitMask(int)](Jcd.BitManipulation.BitMask.BitMask(int).md 'Jcd.BitManipulation.BitMask.BitMask(int)') | Create a bitmask |
| [BitMask(BitMask)](Jcd.BitManipulation.BitMask.BitMask(Jcd.BitManipulation.BitMask).md 'Jcd.BitManipulation.BitMask.BitMask(Jcd.BitManipulation.BitMask)') | Copy constructor |
| [BitMask(long)](Jcd.BitManipulation.BitMask.BitMask(long).md 'Jcd.BitManipulation.BitMask.BitMask(long)') | Create a bitmask |
| [BitMask(sbyte)](Jcd.BitManipulation.BitMask.BitMask(sbyte).md 'Jcd.BitManipulation.BitMask.BitMask(sbyte)') | Create a bitmask |
| [BitMask(short)](Jcd.BitManipulation.BitMask.BitMask(short).md 'Jcd.BitManipulation.BitMask.BitMask(short)') | Create a bitmask |
| [BitMask(uint)](Jcd.BitManipulation.BitMask.BitMask(uint).md 'Jcd.BitManipulation.BitMask.BitMask(uint)') | Create a bitmask |
| [BitMask(ulong)](Jcd.BitManipulation.BitMask.BitMask(ulong).md 'Jcd.BitManipulation.BitMask.BitMask(ulong)') | Create a bitmask |
| [BitMask(ushort)](Jcd.BitManipulation.BitMask.BitMask(ushort).md 'Jcd.BitManipulation.BitMask.BitMask(ushort)') | Create a bitmask |

| Fields | |
| :--- | :--- |
| [Bits](Jcd.BitManipulation.BitMask.Bits.md 'Jcd.BitManipulation.BitMask.Bits') | The backing store for the actual bits of the bitmask. |

| Methods | |
| :--- | :--- |
| [CreateRange(int, int)](Jcd.BitManipulation.BitMask.CreateRange(int,int).md 'Jcd.BitManipulation.BitMask.CreateRange(int, int)') | Create a 64 bit, bitmask of a specified bit size and bit location within the number. |
| [CreateSingleBit(int)](Jcd.BitManipulation.BitMask.CreateSingleBit(int).md 'Jcd.BitManipulation.BitMask.CreateSingleBit(int)') | Create a 64 bit, single bit bitmask, given bit position. |
| [ToString()](Jcd.BitManipulation.BitMask.ToString().md 'Jcd.BitManipulation.BitMask.ToString()') | Format as a bit representation |

| Operators | |
| :--- | :--- |
| [implicit operator byte(BitMask)](Jcd.BitManipulation.BitMask.op_Implicitbyte(Jcd.BitManipulation.BitMask).md 'Jcd.BitManipulation.BitMask.op_Implicit byte(Jcd.BitManipulation.BitMask)') | Automatically convert to byte from a BitMask |
| [implicit operator int(BitMask)](Jcd.BitManipulation.BitMask.op_Implicitint(Jcd.BitManipulation.BitMask).md 'Jcd.BitManipulation.BitMask.op_Implicit int(Jcd.BitManipulation.BitMask)') | Automatically convert to int from a BitMask |
| [implicit operator BitMask(byte)](Jcd.BitManipulation.BitMask.op_ImplicitJcd.BitManipulation.BitMask(byte).md 'Jcd.BitManipulation.BitMask.op_Implicit Jcd.BitManipulation.BitMask(byte)') | Automatically convert to BitMask from a byte |
| [implicit operator BitMask(int)](Jcd.BitManipulation.BitMask.op_ImplicitJcd.BitManipulation.BitMask(int).md 'Jcd.BitManipulation.BitMask.op_Implicit Jcd.BitManipulation.BitMask(int)') | Automatically convert to BitMask from an int |
| [implicit operator BitMask(long)](Jcd.BitManipulation.BitMask.op_ImplicitJcd.BitManipulation.BitMask(long).md 'Jcd.BitManipulation.BitMask.op_Implicit Jcd.BitManipulation.BitMask(long)') | Automatically convert to BitMask from a long |
| [implicit operator BitMask(sbyte)](Jcd.BitManipulation.BitMask.op_ImplicitJcd.BitManipulation.BitMask(sbyte).md 'Jcd.BitManipulation.BitMask.op_Implicit Jcd.BitManipulation.BitMask(sbyte)') | Automatically convert to BitMask from an sbyte |
| [implicit operator BitMask(short)](Jcd.BitManipulation.BitMask.op_ImplicitJcd.BitManipulation.BitMask(short).md 'Jcd.BitManipulation.BitMask.op_Implicit Jcd.BitManipulation.BitMask(short)') | Automatically convert to BitMask from a byte |
| [implicit operator BitMask(uint)](Jcd.BitManipulation.BitMask.op_ImplicitJcd.BitManipulation.BitMask(uint).md 'Jcd.BitManipulation.BitMask.op_Implicit Jcd.BitManipulation.BitMask(uint)') | Automatically convert to BitMask from a uint |
| [implicit operator BitMask(ulong)](Jcd.BitManipulation.BitMask.op_ImplicitJcd.BitManipulation.BitMask(ulong).md 'Jcd.BitManipulation.BitMask.op_Implicit Jcd.BitManipulation.BitMask(ulong)') | Automatically convert to BitMask from a ulong |
| [implicit operator BitMask(ushort)](Jcd.BitManipulation.BitMask.op_ImplicitJcd.BitManipulation.BitMask(ushort).md 'Jcd.BitManipulation.BitMask.op_Implicit Jcd.BitManipulation.BitMask(ushort)') | Automatically convert to BitMask from a ushort |
| [implicit operator long(BitMask)](Jcd.BitManipulation.BitMask.op_Implicitlong(Jcd.BitManipulation.BitMask).md 'Jcd.BitManipulation.BitMask.op_Implicit long(Jcd.BitManipulation.BitMask)') | Automatically convert to long from a BitMask |
| [implicit operator sbyte(BitMask)](Jcd.BitManipulation.BitMask.op_Implicitsbyte(Jcd.BitManipulation.BitMask).md 'Jcd.BitManipulation.BitMask.op_Implicit sbyte(Jcd.BitManipulation.BitMask)') | Automatically convert to sbyte from a BitMask |
| [implicit operator short(BitMask)](Jcd.BitManipulation.BitMask.op_Implicitshort(Jcd.BitManipulation.BitMask).md 'Jcd.BitManipulation.BitMask.op_Implicit short(Jcd.BitManipulation.BitMask)') | Automatically convert to short from a BitMask |
| [implicit operator uint(BitMask)](Jcd.BitManipulation.BitMask.op_Implicituint(Jcd.BitManipulation.BitMask).md 'Jcd.BitManipulation.BitMask.op_Implicit uint(Jcd.BitManipulation.BitMask)') | Automatically convert to uint from a BitMask |
| [implicit operator ulong(BitMask)](Jcd.BitManipulation.BitMask.op_Implicitulong(Jcd.BitManipulation.BitMask).md 'Jcd.BitManipulation.BitMask.op_Implicit ulong(Jcd.BitManipulation.BitMask)') | Automatically convert to ulong from a BitMask |
| [implicit operator ushort(BitMask)](Jcd.BitManipulation.BitMask.op_Implicitushort(Jcd.BitManipulation.BitMask).md 'Jcd.BitManipulation.BitMask.op_Implicit ushort(Jcd.BitManipulation.BitMask)') | Automatically convert to ushort from a BitMask |
