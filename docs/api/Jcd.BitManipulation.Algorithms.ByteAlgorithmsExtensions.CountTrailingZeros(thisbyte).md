#### [Jcd.BitManipulation](index 'index')
### [Jcd.BitManipulation.Algorithms](Jcd.BitManipulation.Algorithms 'Jcd.BitManipulation.Algorithms').[ByteAlgorithmsExtensions](Jcd.BitManipulation.Algorithms.ByteAlgorithmsExtensions 'Jcd.BitManipulation.Algorithms.ByteAlgorithmsExtensions')

## ByteAlgorithmsExtensions.CountTrailingZeros(this byte) Method

Computes the number of sequentially zeroed bits occupying the
least significant bit positions.

```csharp
public static int CountTrailingZeros(this byte number);
```
#### Parameters

<a name='Jcd.BitManipulation.Algorithms.ByteAlgorithmsExtensions.CountTrailingZeros(thisbyte).number'></a>

`number` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The number to evaluate.

#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')
The count of sequentially zeroed bits occupying the least significant bit positions.

### Example

```csharp
byte v = 1;
Console.WriteLine($"{v.CountTrailingZeros()}"); // outputs: 0

v = 2;
Console.WriteLine($"{v.CountTrailingZeros()}"); // outputs: 1

v = 3;
Console.WriteLine($"{v.CountTrailingZeros()}"); // outputs: 0

v = 4;
Console.WriteLine($"{v.CountTrailingZeros()}"); // outputs: 2
```