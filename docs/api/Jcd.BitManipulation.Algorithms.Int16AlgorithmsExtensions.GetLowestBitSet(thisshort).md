#### [Jcd.BitManipulation](index 'index')

### [Jcd.BitManipulation.Algorithms](Jcd.BitManipulation.Algorithms 'Jcd.BitManipulation.Algorithms').[Int16AlgorithmsExtensions](Jcd.BitManipulation.Algorithms.Int16AlgorithmsExtensions 'Jcd.BitManipulation.Algorithms.Int16AlgorithmsExtensions')

## Int16AlgorithmsExtensions.GetLowestBitSet(this short) Method

Calculate the index of the lowest bit that's been set.

```csharp
public static int GetLowestBitSet(this short number);
```

#### Parameters

<a name='Jcd.BitManipulation.Algorithms.Int16AlgorithmsExtensions.GetLowestBitSet(thisshort).number'></a>

`number` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The number to evaluate.

#### Returns

[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')
The index of the lowest bit that's been set; or -1 if none were set.

### Example

```csharp
short v = 1;
Console.WriteLine($"{v.GetHighestBitSet()}"); // outputs: 0

v = 2;
Console.WriteLine($"{v.GetHighestBitSet()}"); // outputs: 1

v = 3;
Console.WriteLine($"{v.GetHighestBitSet()}"); // outputs: 1

v = 4;
Console.WriteLine($"{v.GetHighestBitSet()}"); // outputs: 2
```