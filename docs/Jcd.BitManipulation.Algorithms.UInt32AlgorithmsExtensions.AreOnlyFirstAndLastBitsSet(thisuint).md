#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation.Algorithms](Jcd.BitManipulation.Algorithms.md 'Jcd.BitManipulation.Algorithms').[UInt32AlgorithmsExtensions](Jcd.BitManipulation.Algorithms.UInt32AlgorithmsExtensions.md 'Jcd.BitManipulation.Algorithms.UInt32AlgorithmsExtensions')

## UInt32AlgorithmsExtensions.AreOnlyFirstAndLastBitsSet(this uint) Method

Determines if the only lowest bit and one other higher bit are set.

```csharp
public static bool AreOnlyFirstAndLastBitsSet(this uint number);
```

#### Parameters

<a name='Jcd.BitManipulation.Algorithms.UInt32AlgorithmsExtensions.AreOnlyFirstAndLastBitsSet(thisuint).number'></a>

`number` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The number to evaluate.

#### Returns

[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')
true if the bitwise representation follows this pattern: 0b10..01. with any number of intervening
zeros.

### Example

```csharp
uint v = 0b0001;
Console.WriteLine($"{v.AreOnlyFirstAndLastBitsSet()}"); // outputs: True

v = 0b0011;
Console.WriteLine($"{v.AreOnlyFirstAndLastBitsSet()}"); // outputs: True

v = 0b0101;
Console.WriteLine($"{v.AreOnlyFirstAndLastBitsSet()}"); // outputs: True

v = 0b0111;
Console.WriteLine($"{v.AreOnlyFirstAndLastBitsSet()}"); // outputs: False
```