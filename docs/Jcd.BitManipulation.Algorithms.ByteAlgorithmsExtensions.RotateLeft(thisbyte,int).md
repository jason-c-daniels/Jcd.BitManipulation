#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation.Algorithms](Jcd.BitManipulation.Algorithms 'Jcd.BitManipulation.Algorithms').[ByteAlgorithmsExtensions](Jcd.BitManipulation.Algorithms.ByteAlgorithmsExtensions 'Jcd.BitManipulation.Algorithms.ByteAlgorithmsExtensions')

## ByteAlgorithmsExtensions.RotateLeft(this byte, int) Method

Performs a bitwise left rotation on a number.

```csharp
public static byte RotateLeft(this byte number, int count);
```

#### Parameters

<a name='Jcd.BitManipulation.Algorithms.ByteAlgorithmsExtensions.RotateLeft(thisbyte,int).number'></a>

`number` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The number to rotate

<a name='Jcd.BitManipulation.Algorithms.ByteAlgorithmsExtensions.RotateLeft(thisbyte,int).count'></a>

`count` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

the number of bits to rotate

#### Returns

[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')
The rotated value.

### Example

Examples

```csharp
byte b = 0b00001111;
var b2 = b.RotateLeft(3); // b2 = 0b01111000
var b3 = b.RotateLeft(4); // b3 = 0b11110000
var b4 = b.RotateLeft(5); // b4 = 0b11100001
var b5 = b.RotateLeft(6); // b5 = 0b11000011
var b6 = b.RotateLeft(7); // b6 = 0b10000111
var b7 = b.RotateLeft(8); // b7 = 0b00001111
```