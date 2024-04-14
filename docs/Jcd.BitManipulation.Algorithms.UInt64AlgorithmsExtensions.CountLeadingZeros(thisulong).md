#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation.Algorithms](Jcd.BitManipulation.Algorithms 'Jcd.BitManipulation.Algorithms').[UInt64AlgorithmsExtensions](Jcd.BitManipulation.Algorithms.UInt64AlgorithmsExtensions 'Jcd.BitManipulation.Algorithms.UInt64AlgorithmsExtensions')

## UInt64AlgorithmsExtensions.CountLeadingZeros(this ulong) Method

Computes the number of sequentially zeroed bits occupying the
most significant bit positions.

```csharp
public static int CountLeadingZeros(this ulong number);
```

#### Parameters

<a name='Jcd.BitManipulation.Algorithms.UInt64AlgorithmsExtensions.CountLeadingZeros(thisulong).number'></a>

`number` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

The number to evaluate.

#### Returns

[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')
The count of sequentially zeroed bits occupying the most significant bit positions.

### Example

```csharp
ulong v = 0x7FFFFFFF_FFFFFFFF;
Console.WriteLine($"{v.CountLeadingZeros()}"); // outputs: 1

v = 0x3FFFFFFF_FFFFFFFF;
Console.WriteLine($"{v.CountLeadingZeros()}"); // outputs: 2

v = 1;
Console.WriteLine($"{v.CountLeadingZeros()}"); // outputs: 63
```