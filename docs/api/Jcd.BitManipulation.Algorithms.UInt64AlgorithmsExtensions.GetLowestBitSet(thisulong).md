#### [Jcd.BitManipulation](index 'index')
### [Jcd.BitManipulation.Algorithms](Jcd.BitManipulation.Algorithms 'Jcd.BitManipulation.Algorithms').[UInt64AlgorithmsExtensions](Jcd.BitManipulation.Algorithms.UInt64AlgorithmsExtensions 'Jcd.BitManipulation.Algorithms.UInt64AlgorithmsExtensions')

## UInt64AlgorithmsExtensions.GetLowestBitSet(this ulong) Method

Calculate the index of the lowest bit that's been set.

```csharp
public static int GetLowestBitSet(this ulong number);
```
#### Parameters

<a name='Jcd.BitManipulation.Algorithms.UInt64AlgorithmsExtensions.GetLowestBitSet(thisulong).number'></a>

`number` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

The number to evaluate.

#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')
The index of the lowest bit that's been set; or -1 if none were set.

### Example

```csharp
ulong v = 1;
Console.WriteLine($"{v.GetHighestBitSet()}"); // outputs: 0

v = 2;
Console.WriteLine($"{v.GetHighestBitSet()}"); // outputs: 1

v = 3;
Console.WriteLine($"{v.GetHighestBitSet()}"); // outputs: 1

v = 4;
Console.WriteLine($"{v.GetHighestBitSet()}"); // outputs: 2
```