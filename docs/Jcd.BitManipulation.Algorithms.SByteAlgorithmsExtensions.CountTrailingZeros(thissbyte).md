#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation.Algorithms](Jcd.BitManipulation.Algorithms.md 'Jcd.BitManipulation.Algorithms').[SByteAlgorithmsExtensions](Jcd.BitManipulation.Algorithms.SByteAlgorithmsExtensions.md 'Jcd.BitManipulation.Algorithms.SByteAlgorithmsExtensions')

## SByteAlgorithmsExtensions.CountTrailingZeros(this sbyte) Method

Computes the number of sequentially zeroed bits occupying the
least significant bit positions.

```csharp
public static sbyte CountTrailingZeros(this sbyte number);
```

#### Parameters

<a name='Jcd.BitManipulation.Algorithms.SByteAlgorithmsExtensions.CountTrailingZeros(thissbyte).number'></a>

`number` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

The number to evaluate.

#### Returns

[System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')
The count of sequentially zeroed bits occupying the least significant bit positions.

### Example

```csharp
sbyte v = 1;
Console.WriteLine($"{v.CountTrailingZeros()}"); // outputs: 0

v = 2;
Console.WriteLine($"{v.CountTrailingZeros()}"); // outputs: 1

v = 3;
Console.WriteLine($"{v.CountTrailingZeros()}"); // outputs: 1

v = 4;
Console.WriteLine($"{v.CountTrailingZeros()}"); // outputs: 2
```