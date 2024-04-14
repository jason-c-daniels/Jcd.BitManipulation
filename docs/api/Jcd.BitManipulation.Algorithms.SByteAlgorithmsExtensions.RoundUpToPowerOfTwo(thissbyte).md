#### [Jcd.BitManipulation](index 'index')

### [Jcd.BitManipulation.Algorithms](Jcd.BitManipulation.Algorithms 'Jcd.BitManipulation.Algorithms').[SByteAlgorithmsExtensions](Jcd.BitManipulation.Algorithms.SByteAlgorithmsExtensions 'Jcd.BitManipulation.Algorithms.SByteAlgorithmsExtensions')

## SByteAlgorithmsExtensions.RoundUpToPowerOfTwo(this sbyte) Method

For any given number return the number if it's a power of two,
or return the next higher power of two capable of fitting in the
data type. For negative values or values that would result in a
negative next higher power of two, zero is returned. (e.g. number > 2^(k-2))
where k is the bit size.)

```csharp
public static sbyte RoundUpToPowerOfTwo(this sbyte number);
```

#### Parameters

<a name='Jcd.BitManipulation.Algorithms.SByteAlgorithmsExtensions.RoundUpToPowerOfTwo(thissbyte).number'></a>

`number` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

The number to evaluate.

#### Returns

[System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

### Example

```csharp
sbyte v = 2;
Console.WriteLine($"{v.RoundUpToPowerOfTwo()}"); // outputs: 2

v = 3;
Console.WriteLine($"{v.RoundUpToPowerOfTwo()}"); // outputs: 4
```