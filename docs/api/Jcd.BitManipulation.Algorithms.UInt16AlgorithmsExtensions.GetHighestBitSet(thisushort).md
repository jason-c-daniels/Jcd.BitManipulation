#### [Jcd.BitManipulation](index 'index')
### [Jcd.BitManipulation.Algorithms](Jcd.BitManipulation.Algorithms 'Jcd.BitManipulation.Algorithms').[UInt16AlgorithmsExtensions](Jcd.BitManipulation.Algorithms.UInt16AlgorithmsExtensions 'Jcd.BitManipulation.Algorithms.UInt16AlgorithmsExtensions')

## UInt16AlgorithmsExtensions.GetHighestBitSet(this ushort) Method

Calculate the index of the highest bit that's been set.

```csharp
public static int GetHighestBitSet(this ushort number);
```
#### Parameters

<a name='Jcd.BitManipulation.Algorithms.UInt16AlgorithmsExtensions.GetHighestBitSet(thisushort).number'></a>

`number` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The number to evaluate.

#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')
The index of the highest bit that's been set; or -1 if none were set.

### Example

```csharp
ushort v = 1;
Console.WriteLine($"{v.GetHighestBitSet()}"); // outputs: 0

v = 2;
Console.WriteLine($"{v.GetHighestBitSet()}"); // outputs: 1

v = 3;
Console.WriteLine($"{v.GetHighestBitSet()}"); // outputs: 1

v = 4;
Console.WriteLine($"{v.GetHighestBitSet()}"); // outputs: 2
```