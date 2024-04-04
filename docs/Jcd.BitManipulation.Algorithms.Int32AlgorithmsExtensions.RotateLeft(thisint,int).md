#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation.Algorithms](Jcd.BitManipulation.Algorithms.md 'Jcd.BitManipulation.Algorithms').[Int32AlgorithmsExtensions](Jcd.BitManipulation.Algorithms.Int32AlgorithmsExtensions.md 'Jcd.BitManipulation.Algorithms.Int32AlgorithmsExtensions')

## Int32AlgorithmsExtensions.RotateLeft(this int, int) Method

Performs a bitwise left rotation on a number.

```csharp
public static int RotateLeft(this int number, int count);
```

#### Parameters

<a name='Jcd.BitManipulation.Algorithms.Int32AlgorithmsExtensions.RotateLeft(thisint,int).number'></a>

`number` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The number to rotate

<a name='Jcd.BitManipulation.Algorithms.Int32AlgorithmsExtensions.RotateLeft(thisint,int).count'></a>

`count` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

the number of bits to rotate

#### Returns

[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')
The rotated value.

### Example

Examples

```csharp
int b = 0b00001111;
var b2 = b.RotateLeft(3); // b2 = 0b01111000
var b3 = b.RotateLeft(4); // b3 = 0b11110000
var b4 = b.RotateLeft(5); // b4 = 0b11100001
var b5 = b.RotateLeft(6); // b5 = 0b11000011
var b6 = b.RotateLeft(7); // b6 = 0b10000111
var b7 = b.RotateLeft(8); // b7 = 0b00001111
```