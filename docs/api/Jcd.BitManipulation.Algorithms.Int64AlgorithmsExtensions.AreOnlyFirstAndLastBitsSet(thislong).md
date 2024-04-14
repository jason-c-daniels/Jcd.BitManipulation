#### [Jcd.BitManipulation](index 'index')

### [Jcd.BitManipulation.Algorithms](Jcd.BitManipulation.Algorithms 'Jcd.BitManipulation.Algorithms').[Int64AlgorithmsExtensions](Jcd.BitManipulation.Algorithms.Int64AlgorithmsExtensions 'Jcd.BitManipulation.Algorithms.Int64AlgorithmsExtensions')

## Int64AlgorithmsExtensions.AreOnlyFirstAndLastBitsSet(this long) Method

Determines if only the lowest bit and one other higher bit are set.

```csharp
public static bool AreOnlyFirstAndLastBitsSet(this long number);
```

#### Parameters

<a name='Jcd.BitManipulation.Algorithms.Int64AlgorithmsExtensions.AreOnlyFirstAndLastBitsSet(thislong).number'></a>

`number` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The number to evaluate.

#### Returns

[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')
true if the bitwise representation follows this pattern: 0b10..01. with any number of intervening zeros.

### Example

```csharp
long v = 0b0001;
Console.WriteLine($"{v.AreOnlyFirstAndLastBitsSet()}"); // outputs: True

v = 0b0011;
Console.WriteLine($"{v.AreOnlyFirstAndLastBitsSet()}"); // outputs: True

v = 0b0101;
Console.WriteLine($"{v.AreOnlyFirstAndLastBitsSet()}"); // outputs: True

v = 0b0111;
Console.WriteLine($"{v.AreOnlyFirstAndLastBitsSet()}"); // outputs: False
```