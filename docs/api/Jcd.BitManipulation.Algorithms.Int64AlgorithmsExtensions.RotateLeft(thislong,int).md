#### [Jcd.BitManipulation](index 'index')

### [Jcd.BitManipulation.Algorithms](Jcd.BitManipulation.Algorithms 'Jcd.BitManipulation.Algorithms').[Int64AlgorithmsExtensions](Jcd.BitManipulation.Algorithms.Int64AlgorithmsExtensions 'Jcd.BitManipulation.Algorithms.Int64AlgorithmsExtensions')

## Int64AlgorithmsExtensions.RotateLeft(this long, int) Method

Performs a bitwise left rotation on a number.

```csharp
public static long RotateLeft(this long number, int count);
```

#### Parameters

<a name='Jcd.BitManipulation.Algorithms.Int64AlgorithmsExtensions.RotateLeft(thislong,int).number'></a>

`number` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The number to rotate

<a name='Jcd.BitManipulation.Algorithms.Int64AlgorithmsExtensions.RotateLeft(thislong,int).count'></a>

`count` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

the number of bits to rotate

#### Returns

[System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')
The rotated value.

### Example

```csharp
var rotationBase = sizeof(long)-5;

long b = 0b00000000_00000000_00000000_00000000_00000000_00000000_00000000_00001111;

var b2 = b.RotateLeft(rotationBase+0); // b2 = 0b01111000_00000000_00000000_00000000_00000000_00000000_00000000_00000000
var b3 = b.RotateLeft(rotationBase+1); // b3 = 0b11110000_00000000_00000000_00000000_00000000_00000000_00000000_00000000
var b4 = b.RotateLeft(rotationBase+2); // b4 = 0b11100000_00000000_00000000_00000000_00000000_00000000_00000000_00000001
var b5 = b.RotateLeft(rotationBase+3); // b5 = 0b11000000_00000000_00000000_00000000_00000000_00000000_00000000_00000011
var b6 = b.RotateLeft(rotationBase+4); // b6 = 0b10000000_00000000_00000000_00000000_00000000_00000000_00000000_00000111
var b7 = b.RotateLeft(rotationBase+5); // b7 = 0b00000000_00000000_00000000_00000000_00000000_00000000_00000000_00001111
```