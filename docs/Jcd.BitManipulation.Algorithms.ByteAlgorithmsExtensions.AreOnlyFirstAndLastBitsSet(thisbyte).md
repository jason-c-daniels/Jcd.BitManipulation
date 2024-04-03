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

the number to evaluate

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')
true if the bitwise representation follows this pattern: 0b10..01. with any number of intervening zeros.