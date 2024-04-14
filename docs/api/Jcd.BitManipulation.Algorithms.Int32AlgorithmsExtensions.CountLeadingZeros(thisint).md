#### [Jcd.BitManipulation](index 'index')

### [Jcd.BitManipulation.Algorithms](Jcd.BitManipulation.Algorithms 'Jcd.BitManipulation.Algorithms').[Int32AlgorithmsExtensions](Jcd.BitManipulation.Algorithms.Int32AlgorithmsExtensions 'Jcd.BitManipulation.Algorithms.Int32AlgorithmsExtensions')

## Int32AlgorithmsExtensions.CountLeadingZeros(this int) Method

Computes the number of sequentially zeroed bits occupying the
most significant bit positions.

```csharp
public static int CountLeadingZeros(this int number);
```

#### Parameters

<a name='Jcd.BitManipulation.Algorithms.Int32AlgorithmsExtensions.CountLeadingZeros(thisint).number'></a>

`number` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The number to evaluate.

#### Returns

[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')
The count of sequentially zeroed bits occupying the most significant bit positions.

### Example

```csharp
int v = 0x7FFFFFFF;
Console.WriteLine($"{v.CountLeadingZeros()}"); // outputs: 1

v = 0x3FFFFFFF;
Console.WriteLine($"{v.CountLeadingZeros()}"); // outputs: 2

v = 1;
Console.WriteLine($"{v.CountLeadingZeros()}"); // outputs: 31
```