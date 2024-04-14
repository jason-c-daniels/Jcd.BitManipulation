#### [Jcd.BitManipulation](index 'index')
### [Jcd.BitManipulation.Algorithms](Jcd.BitManipulation.Algorithms 'Jcd.BitManipulation.Algorithms').[Int64AlgorithmsExtensions](Jcd.BitManipulation.Algorithms.Int64AlgorithmsExtensions 'Jcd.BitManipulation.Algorithms.Int64AlgorithmsExtensions')

## Int64AlgorithmsExtensions.CountLeadingZeros(this long) Method

Computes the number of sequentially zeroed bits occupying the
most significant bit positions.

```csharp
public static int CountLeadingZeros(this long number);
```
#### Parameters

<a name='Jcd.BitManipulation.Algorithms.Int64AlgorithmsExtensions.CountLeadingZeros(thislong).number'></a>

`number` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The number to evaluate.

#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')
The count of sequentially zeroed bits occupying the most significant bit positions.

### Example

```csharp
long v = 0x7FFFFFFF_FFFFFFFF;
Console.WriteLine($"{v.CountLeadingZeros()}"); // outputs: 1

v = 0x3FFFFFFF_FFFFFFFF;
Console.WriteLine($"{v.CountLeadingZeros()}"); // outputs: 2

v = 1;
Console.WriteLine($"{v.CountLeadingZeros()}"); // outputs: 63
```