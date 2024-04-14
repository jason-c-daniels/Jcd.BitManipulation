#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation.Algorithms](Jcd.BitManipulation.Algorithms 'Jcd.BitManipulation.Algorithms').[Int16AlgorithmsExtensions](Jcd.BitManipulation.Algorithms.Int16AlgorithmsExtensions 'Jcd.BitManipulation.Algorithms.Int16AlgorithmsExtensions')

## Int16AlgorithmsExtensions.PopCount(this short) Method

Counts the bits that are set to 1 in a number.

```csharp
public static int PopCount(this short number);
```

#### Parameters

<a name='Jcd.BitManipulation.Algorithms.Int16AlgorithmsExtensions.PopCount(thisshort).number'></a>

`number` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The number to evaluate.

#### Returns

[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')
The count of the bits set to 1.

### Example

```csharp
var v = short.MaxValue;
Console.WriteLine($"{v.PopCount()} bits are set."); // outputs: 15 bits are set.
```

### Remarks

This is an alias for [CountBitsSet(this short)](Jcd.BitManipulation.Algorithms.Int16AlgorithmsExtensions.CountBitsSet(thisshort) 'Jcd.BitManipulation.Algorithms.Int16AlgorithmsExtensions.CountBitsSet(this short)').