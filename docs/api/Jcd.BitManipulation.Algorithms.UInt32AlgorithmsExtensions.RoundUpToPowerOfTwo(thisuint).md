#### [Jcd.BitManipulation](index 'index')

### [Jcd.BitManipulation.Algorithms](Jcd.BitManipulation.Algorithms 'Jcd.BitManipulation.Algorithms').[UInt32AlgorithmsExtensions](Jcd.BitManipulation.Algorithms.UInt32AlgorithmsExtensions 'Jcd.BitManipulation.Algorithms.UInt32AlgorithmsExtensions')

## UInt32AlgorithmsExtensions.RoundUpToPowerOfTwo(this uint) Method

For any given number return the number if it's a power of two,
or return the next higher power of two capable of fitting in the
data type.

```csharp
public static uint RoundUpToPowerOfTwo(this uint number);
```

#### Parameters

<a name='Jcd.BitManipulation.Algorithms.UInt32AlgorithmsExtensions.RoundUpToPowerOfTwo(thisuint).number'></a>

`number` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The number to evaluate.

#### Returns

[System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

### Example

```csharp
uint v = 2;
Console.WriteLine($"{v.RoundUpToPowerOfTwo()}"); // outputs: 2

v = 3;
Console.WriteLine($"{v.RoundUpToPowerOfTwo()}"); // outputs: 4
```