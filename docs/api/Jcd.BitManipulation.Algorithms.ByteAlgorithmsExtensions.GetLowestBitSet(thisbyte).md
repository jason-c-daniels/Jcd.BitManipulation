#### [Jcd.BitManipulation](index 'index')

### [Jcd.BitManipulation.Algorithms](Jcd.BitManipulation.Algorithms 'Jcd.BitManipulation.Algorithms').[ByteAlgorithmsExtensions](Jcd.BitManipulation.Algorithms.ByteAlgorithmsExtensions 'Jcd.BitManipulation.Algorithms.ByteAlgorithmsExtensions')

## ByteAlgorithmsExtensions.GetLowestBitSet(this byte) Method

Calculate the index of the lowest bit that's been set.

```csharp
public static int GetLowestBitSet(this byte number);
```

#### Parameters

<a name='Jcd.BitManipulation.Algorithms.ByteAlgorithmsExtensions.GetLowestBitSet(thisbyte).number'></a>

`number` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The number to evaluate.

#### Returns

[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')
The index of the lowest bit that's been set; or -1 if none were set.

### Example

```csharp
byte v = 1;
Console.WriteLine($"{v.GetLowestBitSet()}"); // outputs: 0

v = 2;
Console.WriteLine($"{v.GetLowestBitSet()}"); // outputs: 1

v = 3;
Console.WriteLine($"{v.GetLowestBitSet()}"); // outputs: 0

v = 4;
Console.WriteLine($"{v.GetLowestBitSet()}"); // outputs: 2
```