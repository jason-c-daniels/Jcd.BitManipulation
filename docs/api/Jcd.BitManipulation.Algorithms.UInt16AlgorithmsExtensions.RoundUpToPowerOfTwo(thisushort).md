#### [Jcd.BitManipulation](index 'index')

### [Jcd.BitManipulation.Algorithms](Jcd.BitManipulation.Algorithms 'Jcd.BitManipulation.Algorithms').[UInt16AlgorithmsExtensions](Jcd.BitManipulation.Algorithms.UInt16AlgorithmsExtensions 'Jcd.BitManipulation.Algorithms.UInt16AlgorithmsExtensions')

## UInt16AlgorithmsExtensions.RoundUpToPowerOfTwo(this ushort) Method

For any given number return the number if it's a power of two,
or return the next higher power of two capable of fitting in the
data type.

```csharp
public static ushort RoundUpToPowerOfTwo(this ushort number);
```

#### Parameters

<a name='Jcd.BitManipulation.Algorithms.UInt16AlgorithmsExtensions.RoundUpToPowerOfTwo(thisushort).number'></a>

`number` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The number to evaluate.

#### Returns

[System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

### Example

```csharp
ushort v = 2;
Console.WriteLine($"{v.RoundUpToPowerOfTwo()}"); // outputs: 2

v = 3;
Console.WriteLine($"{v.RoundUpToPowerOfTwo()}"); // outputs: 4
```