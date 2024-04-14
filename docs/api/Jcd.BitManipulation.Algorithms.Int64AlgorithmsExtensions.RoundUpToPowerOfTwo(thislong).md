#### [Jcd.BitManipulation](index 'index')
### [Jcd.BitManipulation.Algorithms](Jcd.BitManipulation.Algorithms 'Jcd.BitManipulation.Algorithms').[Int64AlgorithmsExtensions](Jcd.BitManipulation.Algorithms.Int64AlgorithmsExtensions 'Jcd.BitManipulation.Algorithms.Int64AlgorithmsExtensions')

## Int64AlgorithmsExtensions.RoundUpToPowerOfTwo(this long) Method

For any given number return the number if it's a power of two,
or return the next higher power of two capable of fitting in the
data type. For negative values or values that would result in a
negative next higher power of two, zero is returned. (e.g. number > 2^(k-2)
where k is the bit size.)

```csharp
public static long RoundUpToPowerOfTwo(this long number);
```
#### Parameters

<a name='Jcd.BitManipulation.Algorithms.Int64AlgorithmsExtensions.RoundUpToPowerOfTwo(thislong).number'></a>

`number` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The number to evaluate.

#### Returns
[System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

### Example

```csharp
long v = 2;
Console.WriteLine($"{v.RoundUpToPowerOfTwo()}"); // outputs: 2

v = 3;
Console.WriteLine($"{v.RoundUpToPowerOfTwo()}"); // outputs: 4
```