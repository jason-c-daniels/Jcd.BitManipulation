#### [Jcd.BitManipulation](index 'index')

### [Jcd.BitManipulation.Algorithms](Jcd.BitManipulation.Algorithms 'Jcd.BitManipulation.Algorithms').[UInt64AlgorithmsExtensions](Jcd.BitManipulation.Algorithms.UInt64AlgorithmsExtensions 'Jcd.BitManipulation.Algorithms.UInt64AlgorithmsExtensions')

## UInt64AlgorithmsExtensions.RoundUpToPowerOfTwo(this ulong) Method

For any given number return the number if it's a power of two,
or return the next higher power of two capable of fitting in the
data type.

```csharp
public static ulong RoundUpToPowerOfTwo(this ulong number);
```

#### Parameters

<a name='Jcd.BitManipulation.Algorithms.UInt64AlgorithmsExtensions.RoundUpToPowerOfTwo(thisulong).number'></a>

`number` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

The number to evaluate.

#### Returns

[System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

### Example

```csharp
ulong v = 2;
Console.WriteLine($"{v.RoundUpToPowerOfTwo()}"); // outputs: 2

v = 3;
Console.WriteLine($"{v.RoundUpToPowerOfTwo()}"); // outputs: 4
```