#### [Jcd.BitManipulation](index 'index')

### [Jcd.BitManipulation.Algorithms](Jcd.BitManipulation.Algorithms 'Jcd.BitManipulation.Algorithms').[UInt16AlgorithmsExtensions](Jcd.BitManipulation.Algorithms.UInt16AlgorithmsExtensions 'Jcd.BitManipulation.Algorithms.UInt16AlgorithmsExtensions')

## UInt16AlgorithmsExtensions.AreOnlyFirstAndLastBitsSet(this ushort) Method

Determines if only the lowest bit and one other higher bit are set.

```csharp
public static bool AreOnlyFirstAndLastBitsSet(this ushort number);
```

#### Parameters

<a name='Jcd.BitManipulation.Algorithms.UInt16AlgorithmsExtensions.AreOnlyFirstAndLastBitsSet(thisushort).number'></a>

`number` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The number to evaluate.

#### Returns

[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')
true if the bitwise representation follows this pattern: 0b10..01. with any number of intervening zeros.

### Example

```csharp
ushort v = 0b0001;
Console.WriteLine($"{v.AreOnlyFirstAndLastBitsSet()}"); // outputs: True

v = 0b0011;
Console.WriteLine($"{v.AreOnlyFirstAndLastBitsSet()}"); // outputs: True

v = 0b0101;
Console.WriteLine($"{v.AreOnlyFirstAndLastBitsSet()}"); // outputs: True

v = 0b0111;
Console.WriteLine($"{v.AreOnlyFirstAndLastBitsSet()}"); // outputs: False
```