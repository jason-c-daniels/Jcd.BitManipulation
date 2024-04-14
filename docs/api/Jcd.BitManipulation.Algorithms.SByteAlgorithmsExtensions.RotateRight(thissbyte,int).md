#### [Jcd.BitManipulation](index 'index')

### [Jcd.BitManipulation.Algorithms](Jcd.BitManipulation.Algorithms 'Jcd.BitManipulation.Algorithms').[SByteAlgorithmsExtensions](Jcd.BitManipulation.Algorithms.SByteAlgorithmsExtensions 'Jcd.BitManipulation.Algorithms.SByteAlgorithmsExtensions')

## SByteAlgorithmsExtensions.RotateRight(this sbyte, int) Method

Performs a bitwise right rotation on a number.

```csharp
public static sbyte RotateRight(this sbyte number, int count);
```

#### Parameters

<a name='Jcd.BitManipulation.Algorithms.SByteAlgorithmsExtensions.RotateRight(thissbyte,int).number'></a>

`number` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

The number to rotate

<a name='Jcd.BitManipulation.Algorithms.SByteAlgorithmsExtensions.RotateRight(thissbyte,int).count'></a>

`count` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

the number of bits to rotate

#### Returns

[System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')
The rotated value.

### Example

Examples

```csharp
byte ub = 0b11110000;

sbyte b = (sbyte)b;

var b2 = b.RotateRight(3); // b2 = 0b00011110
var b3 = b.RotateRight(4); // b3 = 0b00001111
var b4 = b.RotateRight(5); // b4 = 0b10000111
var b5 = b.RotateRight(6); // b5 = 0b11000011
var b6 = b.RotateRight(7); // b6 = 0b11100001
var b7 = b.RotateRight(8); // b7 = 0b11110000
```