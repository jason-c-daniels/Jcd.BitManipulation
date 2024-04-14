#### [Jcd.BitManipulation](index 'index')
### [Jcd.BitManipulation.Algorithms](Jcd.BitManipulation.Algorithms 'Jcd.BitManipulation.Algorithms').[Int16AlgorithmsExtensions](Jcd.BitManipulation.Algorithms.Int16AlgorithmsExtensions 'Jcd.BitManipulation.Algorithms.Int16AlgorithmsExtensions')

## Int16AlgorithmsExtensions.RoundUpToPowerOfTwo(this short) Method

For any given number return the number if it's a power of two,
or return the next higher power of two capable of fitting in the
data type. For negative values or values that would result in a
negative next higher power of two, zero is returned. (e.g. number > 2^(k-2)
where k is the bit size.)

```csharp
public static short RoundUpToPowerOfTwo(this short number);
```
#### Parameters

<a name='Jcd.BitManipulation.Algorithms.Int16AlgorithmsExtensions.RoundUpToPowerOfTwo(thisshort).number'></a>

`number` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The number to evaluate.

#### Returns
[System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

### Example

```csharp
short v = 2;
Console.WriteLine($"{v.RoundUpToPowerOfTwo()}"); // outputs: 2

v = 3;
Console.WriteLine($"{v.RoundUpToPowerOfTwo()}"); // outputs: 4
```