#### [Jcd.BitManipulation](index 'index')
### [Jcd.BitManipulation.Algorithms](Jcd.BitManipulation.Algorithms 'Jcd.BitManipulation.Algorithms').[SByteAlgorithmsExtensions](Jcd.BitManipulation.Algorithms.SByteAlgorithmsExtensions 'Jcd.BitManipulation.Algorithms.SByteAlgorithmsExtensions')

## SByteAlgorithmsExtensions.RotateLeft(this sbyte, int) Method

Performs a bitwise left rotation on a number.

```csharp
public static sbyte RotateLeft(this sbyte number, int count);
```
#### Parameters

<a name='Jcd.BitManipulation.Algorithms.SByteAlgorithmsExtensions.RotateLeft(thissbyte,int).number'></a>

`number` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

The number to rotate

<a name='Jcd.BitManipulation.Algorithms.SByteAlgorithmsExtensions.RotateLeft(thissbyte,int).count'></a>

`count` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

the number of bits to rotate

#### Returns
[System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')
The rotated value.

### Example
Examples

```csharp
sbyte b = 0b00001111;
var b2 = b.RotateLeft(3); // b2 = 0b01111000
var b3 = b.RotateLeft(4); // b3 = 0b11110000
var b4 = b.RotateLeft(5); // b4 = 0b11100001
var b5 = b.RotateLeft(6); // b5 = 0b11000011
var b6 = b.RotateLeft(7); // b6 = 0b10000111
var b7 = b.RotateLeft(8); // b7 = 0b00001111
```