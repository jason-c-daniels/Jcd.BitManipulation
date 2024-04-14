#### [Jcd.BitManipulation](index 'index')

### [Jcd.BitManipulation.Algorithms](Jcd.BitManipulation.Algorithms 'Jcd.BitManipulation.Algorithms').[SByteAlgorithmsExtensions](Jcd.BitManipulation.Algorithms.SByteAlgorithmsExtensions 'Jcd.BitManipulation.Algorithms.SByteAlgorithmsExtensions')

## SByteAlgorithmsExtensions.CountBitsSet(this sbyte) Method

Counts the bits that are set to 1 in a number.

```csharp
public static int CountBitsSet(this sbyte number);
```

#### Parameters

<a name='Jcd.BitManipulation.Algorithms.SByteAlgorithmsExtensions.CountBitsSet(thissbyte).number'></a>

`number` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

The number to evaluate.

#### Returns

[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')
The count of the bits set to 1.

### Example

```csharp
var v = sbyte.MaxValue;
Console.WriteLine($"{v.CountBitsSet()} bits are set."); // outputs: 7 bits are set.
```

### Remarks

This is a reader-friendly alias for [PopCount(this sbyte)](Jcd.BitManipulation.Algorithms.SByteAlgorithmsExtensions.PopCount(thissbyte) 'Jcd.BitManipulation.Algorithms.SByteAlgorithmsExtensions.PopCount(this sbyte)').