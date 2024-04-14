#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation.Algorithms](Jcd.BitManipulation.Algorithms 'Jcd.BitManipulation.Algorithms').[ByteAlgorithmsExtensions](Jcd.BitManipulation.Algorithms.ByteAlgorithmsExtensions 'Jcd.BitManipulation.Algorithms.ByteAlgorithmsExtensions')

## ByteAlgorithmsExtensions.CountBitsSet(this byte) Method

Counts the bits that are set to 1 in a number.

```csharp
public static int CountBitsSet(this byte number);
```

#### Parameters

<a name='Jcd.BitManipulation.Algorithms.ByteAlgorithmsExtensions.CountBitsSet(thisbyte).number'></a>

`number` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The number to evaluate.

#### Returns

[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')
The count of the bits set to 1.

### Example

```csharp
var v = byte.MaxValue;
Console.WriteLine($"{v.CountBitsSet()} bits are set."); // outputs: 8 bits are set.
```

### Remarks

This is a reader-friendly alias for [PopCount(this byte)](Jcd.BitManipulation.Algorithms.ByteAlgorithmsExtensions.PopCount(thisbyte) 'Jcd.BitManipulation.Algorithms.ByteAlgorithmsExtensions.PopCount(this byte)').