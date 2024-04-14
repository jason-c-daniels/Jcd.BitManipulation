#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation.Algorithms](Jcd.BitManipulation.Algorithms.md 'Jcd.BitManipulation.Algorithms').[Int64AlgorithmsExtensions](Jcd.BitManipulation.Algorithms.Int64AlgorithmsExtensions.md 'Jcd.BitManipulation.Algorithms.Int64AlgorithmsExtensions')

## Int64AlgorithmsExtensions.PopCount(this long) Method

Counts the bits that are set to 1 in a number.

```csharp
public static int PopCount(this long number);
```

#### Parameters

<a name='Jcd.BitManipulation.Algorithms.Int64AlgorithmsExtensions.PopCount(thislong).number'></a>

`number` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The number to evaluate.

#### Returns

[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')
The count of the bits set to 1.

### Example

```csharp
var v = long.MaxValue;
Console.WriteLine($"{v.PopCount()} bits are set."); // outputs: 63 bits are set.
```

### Remarks

This is an alias for[CountBitsSet(this long)](Jcd.BitManipulation.Algorithms.Int64AlgorithmsExtensions.CountBitsSet(thislong).md 'Jcd.BitManipulation.Algorithms.Int64AlgorithmsExtensions.CountBitsSet(this long)').