#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation.Algorithms](Jcd.BitManipulation.Algorithms.md 'Jcd.BitManipulation.Algorithms').[SByteAlgorithmsExtensions](Jcd.BitManipulation.Algorithms.SByteAlgorithmsExtensions.md 'Jcd.BitManipulation.Algorithms.SByteAlgorithmsExtensions')

## SByteAlgorithmsExtensions.AreOnlyFirstAndLastBitsSet(this sbyte) Method

Determines if the only lowest bit and one other higher bit are set.

```csharp
public static bool AreOnlyFirstAndLastBitsSet(this sbyte number);
```

#### Parameters

<a name='Jcd.BitManipulation.Algorithms.SByteAlgorithmsExtensions.AreOnlyFirstAndLastBitsSet(thissbyte).number'></a>

`number` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

The number to evaluate.

#### Returns

[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')
true if the bitwise representation follows this pattern: 0b10..01. with any number of intervening zeros.

### Example

```csharp
sbyte v = 0b0001;
Console.WriteLine($"{v.AreOnlyFirstAndLastBitsSet()}"); // outputs: True

v = 0b0011;
Console.WriteLine($"{v.AreOnlyFirstAndLastBitsSet()}"); // outputs: True

v = 0b0101;
Console.WriteLine($"{v.AreOnlyFirstAndLastBitsSet()}"); // outputs: True

v = 0b0111;
Console.WriteLine($"{v.AreOnlyFirstAndLastBitsSet()}"); // outputs: False
```