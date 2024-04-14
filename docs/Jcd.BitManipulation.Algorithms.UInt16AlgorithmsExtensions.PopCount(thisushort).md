#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation.Algorithms](Jcd.BitManipulation.Algorithms.md 'Jcd.BitManipulation.Algorithms').[UInt16AlgorithmsExtensions](Jcd.BitManipulation.Algorithms.UInt16AlgorithmsExtensions.md 'Jcd.BitManipulation.Algorithms.UInt16AlgorithmsExtensions')

## UInt16AlgorithmsExtensions.PopCount(this ushort) Method

Counts the bits that are set to 1 in a number.

```csharp
public static int PopCount(this ushort number);
```

#### Parameters

<a name='Jcd.BitManipulation.Algorithms.UInt16AlgorithmsExtensions.PopCount(thisushort).number'></a>

`number` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The number to evaluate.

#### Returns

[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')
The count of the bits set to 1.

### Example

```csharp
var v = ushort.MaxValue;
Console.WriteLine($"{v.PopCount()} bits are set."); // outputs: 16 bits are set.
```

### Remarks

This is an alias for [CountBitsSet(this ushort)](Jcd.BitManipulation.Algorithms.UInt16AlgorithmsExtensions.CountBitsSet(thisushort).md 'Jcd.BitManipulation.Algorithms.UInt16AlgorithmsExtensions.CountBitsSet(this ushort)').