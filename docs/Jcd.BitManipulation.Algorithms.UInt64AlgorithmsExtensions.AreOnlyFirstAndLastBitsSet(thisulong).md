#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation.Algorithms](Jcd.BitManipulation.Algorithms.md 'Jcd.BitManipulation.Algorithms').[UInt64AlgorithmsExtensions](Jcd.BitManipulation.Algorithms.UInt64AlgorithmsExtensions.md 'Jcd.BitManipulation.Algorithms.UInt64AlgorithmsExtensions')

## UInt64AlgorithmsExtensions.AreOnlyFirstAndLastBitsSet(this ulong) Method

Determines if the only lowest bit and one other higher bit are set.

```csharp
public static bool AreOnlyFirstAndLastBitsSet(this ulong number);
```
#### Parameters

<a name='Jcd.BitManipulation.Algorithms.UInt64AlgorithmsExtensions.AreOnlyFirstAndLastBitsSet(thisulong).number'></a>

`number` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

the number to evaluate

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')
true if the bitwise representation follows this pattern: 0b10..01. with any number of intervening zeros.