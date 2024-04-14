#### [Jcd.BitManipulation](index 'index')
### [Jcd.BitManipulation.Algorithms](Jcd.BitManipulation.Algorithms 'Jcd.BitManipulation.Algorithms').[Int16AlgorithmsExtensions](Jcd.BitManipulation.Algorithms.Int16AlgorithmsExtensions 'Jcd.BitManipulation.Algorithms.Int16AlgorithmsExtensions')

## Int16AlgorithmsExtensions.CountLeadingZeros(this short) Method

Computes the number of sequentially zeroed bits occupying the
most significant bit positions.

```csharp
public static int CountLeadingZeros(this short number);
```
#### Parameters

<a name='Jcd.BitManipulation.Algorithms.Int16AlgorithmsExtensions.CountLeadingZeros(thisshort).number'></a>

`number` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The number to evaluate.

#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')
The count of sequentially zeroed bits occupying the most significant bit positions.

### Example

```csharp
short v = 0x7FFF;
Console.WriteLine($"{v.CountLeadingZeros()}"); // outputs: 1

v = 0x3FFF;
Console.WriteLine($"{v.CountLeadingZeros()}"); // outputs: 2

v = 1;
Console.WriteLine($"{v.CountLeadingZeros()}"); // outputs: 15
```