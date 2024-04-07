#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation.Algorithms](Jcd.BitManipulation.Algorithms.md 'Jcd.BitManipulation.Algorithms').[UInt64AlgorithmsExtensions](Jcd.BitManipulation.Algorithms.UInt64AlgorithmsExtensions.md 'Jcd.BitManipulation.Algorithms.UInt64AlgorithmsExtensions')

## UInt64AlgorithmsExtensions.PopCount(this ulong) Method

Counts the bits that are set to 1 in a number.

```csharp
public static int PopCount(this ulong number);
```

#### Parameters

<a name='Jcd.BitManipulation.Algorithms.UInt64AlgorithmsExtensions.PopCount(thisulong).number'></a>

`number` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

The number to evaluate.

#### Returns

[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')
The count of the bits set to 1.

### Example

```csharp
var v = ulong.MaxValue;
Console.WriteLine($"{v.PopCount()} bits are set."); // outputs: 64 bits are set.
```

### Remarks

This is an alias for [CountBitsSet(this ulong)](Jcd.BitManipulation.Algorithms.UInt64AlgorithmsExtensions.CountBitsSet(thisulong).md 'Jcd.BitManipulation.Algorithms.UInt64AlgorithmsExtensions.CountBitsSet(this ulong)').