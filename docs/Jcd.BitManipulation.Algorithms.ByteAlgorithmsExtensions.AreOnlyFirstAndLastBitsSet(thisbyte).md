#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation.Algorithms](Jcd.BitManipulation.Algorithms.md 'Jcd.BitManipulation.Algorithms').[ByteAlgorithmsExtensions](Jcd.BitManipulation.Algorithms.ByteAlgorithmsExtensions.md 'Jcd.BitManipulation.Algorithms.ByteAlgorithmsExtensions')

## ByteAlgorithmsExtensions.AreOnlyFirstAndLastBitsSet(this byte) Method

Determines if the only lowest bit and one other higher bit are set.

```csharp
public static bool AreOnlyFirstAndLastBitsSet(this byte number);
```

#### Parameters

<a name='Jcd.BitManipulation.Algorithms.ByteAlgorithmsExtensions.AreOnlyFirstAndLastBitsSet(thisbyte).number'></a>

`number` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The number to evaluate.

#### Returns

[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')
true if the bitwise representation follows this pattern: 0b10..01. with any number of intervening
zeros.

### Example

```csharp
byte v = 0b0001;
Console.WriteLine($"{v.AreOnlyFirstAndLastBitsSet()}"); // outputs: True

v = 0b0011;
Console.WriteLine($"{v.AreOnlyFirstAndLastBitsSet()}"); // outputs: True

v = 0b0101;
Console.WriteLine($"{v.AreOnlyFirstAndLastBitsSet()}"); // outputs: True

v = 0b0111;
Console.WriteLine($"{v.AreOnlyFirstAndLastBitsSet()}"); // outputs: False
```