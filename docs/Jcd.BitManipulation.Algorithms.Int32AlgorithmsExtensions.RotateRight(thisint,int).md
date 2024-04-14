#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation.Algorithms](Jcd.BitManipulation.Algorithms 'Jcd.BitManipulation.Algorithms').[Int32AlgorithmsExtensions](Jcd.BitManipulation.Algorithms.Int32AlgorithmsExtensions 'Jcd.BitManipulation.Algorithms.Int32AlgorithmsExtensions')

## Int32AlgorithmsExtensions.RotateRight(this int, int) Method

Performs a bitwise right rotation on a number.

```csharp
public static int RotateRight(this int number, int count);
```

#### Parameters

<a name='Jcd.BitManipulation.Algorithms.Int32AlgorithmsExtensions.RotateRight(thisint,int).number'></a>

`number` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The number to rotate

<a name='Jcd.BitManipulation.Algorithms.Int32AlgorithmsExtensions.RotateRight(thisint,int).count'></a>

`count` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

the number of bits to rotate

#### Returns

[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')
The rotated value.

### Example

```csharp
var rotationBase = sizeof(short)-5;

uint ub = 0b11110000_00000000_00000000_00000000;

int b = (int)ub;

var b2 = b.RotateRight(rotationBase+0); // b2 = 0b00000000_00000000_00000000_00011110
var b3 = b.RotateRight(rotationBase+1); // b3 = 0b00000000_00000000_00000000_00001111
var b4 = b.RotateRight(rotationBase+2); // b4 = 0b10000000_00000000_00000000_00000111
var b5 = b.RotateRight(rotationBase+3); // b5 = 0b11000000_00000000_00000000_00000011
var b6 = b.RotateRight(rotationBase+4); // b6 = 0b11100000_00000000_00000000_00000001
var b7 = b.RotateRight(rotationBase+5); // b7 = 0b11110000_00000000_00000000_00000000
```