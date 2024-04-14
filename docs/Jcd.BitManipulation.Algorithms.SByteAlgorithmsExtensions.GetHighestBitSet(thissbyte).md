#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation.Algorithms](Jcd.BitManipulation.Algorithms 'Jcd.BitManipulation.Algorithms').[SByteAlgorithmsExtensions](Jcd.BitManipulation.Algorithms.SByteAlgorithmsExtensions 'Jcd.BitManipulation.Algorithms.SByteAlgorithmsExtensions')

## SByteAlgorithmsExtensions.GetHighestBitSet(this sbyte) Method

Calculate the index of the highest bit that's been set.

```csharp
public static int GetHighestBitSet(this sbyte number);
```

#### Parameters

<a name='Jcd.BitManipulation.Algorithms.SByteAlgorithmsExtensions.GetHighestBitSet(thissbyte).number'></a>

`number` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

The number to evaluate.

#### Returns

[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')
The index of the highest bit that's been set; or -1 if none were set.

### Example

```csharp
sbyte v = 1;
Console.WriteLine($"{v.GetHighestBitSet()}"); // outputs: 0

v = 2;
Console.WriteLine($"{v.GetHighestBitSet()}"); // outputs: 1

v = 3;
Console.WriteLine($"{v.GetHighestBitSet()}"); // outputs: 1

v = 4;
Console.WriteLine($"{v.GetHighestBitSet()}"); // outputs: 2
```