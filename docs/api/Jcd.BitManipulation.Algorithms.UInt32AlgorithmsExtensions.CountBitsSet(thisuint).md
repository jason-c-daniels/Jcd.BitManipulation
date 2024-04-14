#### [Jcd.BitManipulation](index 'index')

### [Jcd.BitManipulation.Algorithms](Jcd.BitManipulation.Algorithms 'Jcd.BitManipulation.Algorithms').[UInt32AlgorithmsExtensions](Jcd.BitManipulation.Algorithms.UInt32AlgorithmsExtensions 'Jcd.BitManipulation.Algorithms.UInt32AlgorithmsExtensions')

## UInt32AlgorithmsExtensions.CountBitsSet(this uint) Method

Counts the bits that are set to 1 in a number.

```csharp
public static int CountBitsSet(this uint number);
```

#### Parameters

<a name='Jcd.BitManipulation.Algorithms.UInt32AlgorithmsExtensions.CountBitsSet(thisuint).number'></a>

`number` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The number to evaluate.

#### Returns

[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')
The count of the bits set to 1.

### Example

```csharp
var v = uint.MaxValue;
Console.WriteLine($"{v.CountBitsSet()} bits are set."); // outputs: 32 bits are set.
```

### Remarks

This is a reader-friendly alias for [PopCount(this uint)](Jcd.BitManipulation.Algorithms.UInt32AlgorithmsExtensions.PopCount(thisuint) 'Jcd.BitManipulation.Algorithms.UInt32AlgorithmsExtensions.PopCount(this uint)').