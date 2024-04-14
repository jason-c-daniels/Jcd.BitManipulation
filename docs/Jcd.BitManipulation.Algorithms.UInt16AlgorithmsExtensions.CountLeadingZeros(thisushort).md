#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation.Algorithms](Jcd.BitManipulation.Algorithms 'Jcd.BitManipulation.Algorithms').[UInt16AlgorithmsExtensions](Jcd.BitManipulation.Algorithms.UInt16AlgorithmsExtensions 'Jcd.BitManipulation.Algorithms.UInt16AlgorithmsExtensions')

## UInt16AlgorithmsExtensions.CountLeadingZeros(this ushort) Method

Computes the number of sequentially zeroed bits occupying the
most significant bit positions.

```csharp
public static int CountLeadingZeros(this ushort number);
```

#### Parameters

<a name='Jcd.BitManipulation.Algorithms.UInt16AlgorithmsExtensions.CountLeadingZeros(thisushort).number'></a>

`number` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The number to evaluate.

#### Returns

[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')
The count of sequentially zeroed bits occupying the most significant bit positions.

### Example

```csharp
ushort v = 0x7FFF;
Console.WriteLine($"{v.CountLeadingZeros()}"); // outputs: 1

v = 0x3FFF;
Console.WriteLine($"{v.CountLeadingZeros()}"); // outputs: 2

v = 1;
Console.WriteLine($"{v.CountLeadingZeros()}"); // outputs: 15
```