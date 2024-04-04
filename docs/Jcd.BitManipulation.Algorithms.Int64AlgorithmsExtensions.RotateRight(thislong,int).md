#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation.Algorithms](Jcd.BitManipulation.Algorithms.md 'Jcd.BitManipulation.Algorithms').[Int64AlgorithmsExtensions](Jcd.BitManipulation.Algorithms.Int64AlgorithmsExtensions.md 'Jcd.BitManipulation.Algorithms.Int64AlgorithmsExtensions')

## Int64AlgorithmsExtensions.RotateRight(this long, int) Method

Performs a bitwise right rotation on a number.

```csharp
public static long RotateRight(this long number, int count);
```

#### Parameters

<a name='Jcd.BitManipulation.Algorithms.Int64AlgorithmsExtensions.RotateRight(thislong,int).number'></a>

`number` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The number to rotate

<a name='Jcd.BitManipulation.Algorithms.Int64AlgorithmsExtensions.RotateRight(thislong,int).count'></a>

`count` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

the number of bits to rotate

#### Returns

[System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')
The rotated value.

### Example

Examples

```csharp
long b = 0b11110000;
var b2 = b.RotateRight(3); // b2 = 0b00011110
var b3 = b.RotateRight(4); // b3 = 0b00001111
var b4 = b.RotateRight(5); // b4 = 0b10000111
var b5 = b.RotateRight(6); // b5 = 0b11000011
var b6 = b.RotateRight(7); // b6 = 0b11100001
var b7 = b.RotateRight(8); // b7 = 0b11110000
```