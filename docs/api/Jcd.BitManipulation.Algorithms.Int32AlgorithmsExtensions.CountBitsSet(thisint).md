#### [Jcd.BitManipulation](index 'index')

### [Jcd.BitManipulation.Algorithms](Jcd.BitManipulation.Algorithms 'Jcd.BitManipulation.Algorithms').[Int32AlgorithmsExtensions](Jcd.BitManipulation.Algorithms.Int32AlgorithmsExtensions 'Jcd.BitManipulation.Algorithms.Int32AlgorithmsExtensions')

## Int32AlgorithmsExtensions.CountBitsSet(this int) Method

Counts the bits that are set to 1 in a number.

```csharp
public static int CountBitsSet(this int number);
```

#### Parameters

<a name='Jcd.BitManipulation.Algorithms.Int32AlgorithmsExtensions.CountBitsSet(thisint).number'></a>

`number` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The number to evaluate.

#### Returns

[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')
The count of the bits set to 1.

### Example

```csharp
var v = int.MaxValue;
Console.WriteLine($"{v.CountBitsSet()} bits are set."); // outputs: 31 bits are set.
```

### Remarks

This is a reader-friendly alias for [PopCount(this int)](Jcd.BitManipulation.Algorithms.Int32AlgorithmsExtensions.PopCount(thisint) 'Jcd.BitManipulation.Algorithms.Int32AlgorithmsExtensions.PopCount(this int)').