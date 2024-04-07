#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation.Algorithms](Jcd.BitManipulation.Algorithms.md 'Jcd.BitManipulation.Algorithms').[SByteAlgorithmsExtensions](Jcd.BitManipulation.Algorithms.SByteAlgorithmsExtensions.md 'Jcd.BitManipulation.Algorithms.SByteAlgorithmsExtensions')

## SByteAlgorithmsExtensions.CountBitsSet(this sbyte) Method

Counts the bits that are set to 1 in a number.

```csharp
public static sbyte CountBitsSet(this sbyte number);
```

#### Parameters

<a name='Jcd.BitManipulation.Algorithms.SByteAlgorithmsExtensions.CountBitsSet(thissbyte).number'></a>

`number` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

The number to evaluate.

#### Returns

[System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')
The count of the bits set to 1.

### Example

```csharp
var v = sbyte.MaxValue;
Console.WriteLine($"{v.CountBitsSet()} bits are set."); // outputs: 7 bits are set.
```

### Remarks

This is a reader-friendly alias for[PopCount(this sbyte)](Jcd.BitManipulation.Algorithms.SByteAlgorithmsExtensions.PopCount(thissbyte).md 'Jcd.BitManipulation.Algorithms.SByteAlgorithmsExtensions.PopCount(this sbyte)').