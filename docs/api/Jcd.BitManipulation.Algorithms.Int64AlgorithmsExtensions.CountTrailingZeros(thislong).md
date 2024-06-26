#### [Jcd.BitManipulation](index 'index')

### [Jcd.BitManipulation.Algorithms](Jcd.BitManipulation.Algorithms 'Jcd.BitManipulation.Algorithms').[Int64AlgorithmsExtensions](Jcd.BitManipulation.Algorithms.Int64AlgorithmsExtensions 'Jcd.BitManipulation.Algorithms.Int64AlgorithmsExtensions')

## Int64AlgorithmsExtensions.CountTrailingZeros(this long) Method

Computes the number of sequentially zeroed bits occupying the
least significant bit positions.

```csharp
public static int CountTrailingZeros(this long number);
```

#### Parameters

<a name='Jcd.BitManipulation.Algorithms.Int64AlgorithmsExtensions.CountTrailingZeros(thislong).number'></a>

`number` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The number to evaluate.

#### Returns

[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')
The count of sequentially zeroed bits occupying the least significant bit positions.

### Example

```csharp
long v = 1;
Console.WriteLine($"{v.CountTrailingZeros()}"); // outputs: 0

v = 2;
Console.WriteLine($"{v.CountTrailingZeros()}"); // outputs: 1

v = 3;
Console.WriteLine($"{v.CountTrailingZeros()}"); // outputs: 1

v = 4;
Console.WriteLine($"{v.CountTrailingZeros()}"); // outputs: 2
```