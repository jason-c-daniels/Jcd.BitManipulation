#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation.Algorithms](Jcd.BitManipulation.Algorithms 'Jcd.BitManipulation.Algorithms').[UInt64AlgorithmsExtensions](Jcd.BitManipulation.Algorithms.UInt64AlgorithmsExtensions 'Jcd.BitManipulation.Algorithms.UInt64AlgorithmsExtensions')

## UInt64AlgorithmsExtensions.CountTrailingZeros(this ulong) Method

Computes the number of sequentially zeroed bits occupying the
least significant bit positions.

```csharp
public static int CountTrailingZeros(this ulong number);
```

#### Parameters

<a name='Jcd.BitManipulation.Algorithms.UInt64AlgorithmsExtensions.CountTrailingZeros(thisulong).number'></a>

`number` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

The number to evaluate.

#### Returns

[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')
The count of sequentially zeroed bits occupying the least significant bit positions.

### Example

```csharp
ulong v = 1;
Console.WriteLine($"{v.CountTrailingZeros()}"); // outputs: 0

v = 2;
Console.WriteLine($"{v.CountTrailingZeros()}"); // outputs: 1

v = 3;
Console.WriteLine($"{v.CountTrailingZeros()}"); // outputs: 1

v = 4;
Console.WriteLine($"{v.CountTrailingZeros()}"); // outputs: 2
```