#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation.Algorithms](Jcd.BitManipulation.Algorithms.md 'Jcd.BitManipulation.Algorithms').[Int16AlgorithmsExtensions](Jcd.BitManipulation.Algorithms.Int16AlgorithmsExtensions.md 'Jcd.BitManipulation.Algorithms.Int16AlgorithmsExtensions')

## Int16AlgorithmsExtensions.RotateRight(this short, int) Method

Performs a bitwise right rotation on a number.

```csharp
public static short RotateRight(this short number, int count);
```

#### Parameters

<a name='Jcd.BitManipulation.Algorithms.Int16AlgorithmsExtensions.RotateRight(thisshort,int).number'></a>

`number` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The number to rotate

<a name='Jcd.BitManipulation.Algorithms.Int16AlgorithmsExtensions.RotateRight(thisshort,int).count'></a>

`count` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

the number of bits to rotate

#### Returns

[System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')
The rotated value.

### Example

```csharp
var rotationBase = sizeof(short)-5;

ushort ub = 0b11110000_00000000;

short b = (short)ub;

var b2 = b.RotateRight(rotationBase+0); // b2 = 0b00000000_00011110
var b3 = b.RotateRight(rotationBase+1); // b3 = 0b00000000_00001111
var b4 = b.RotateRight(rotationBase+2); // b4 = 0b10000000_00000111
var b5 = b.RotateRight(rotationBase+3); // b5 = 0b11000000_00000011
var b6 = b.RotateRight(rotationBase+4); // b6 = 0b11100000_00000001
var b7 = b.RotateRight(rotationBase+5); // b7 = 0b11110000_00000000
```