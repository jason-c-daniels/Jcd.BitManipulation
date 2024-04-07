#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation.Algorithms](Jcd.BitManipulation.Algorithms.md 'Jcd.BitManipulation.Algorithms').[ByteAlgorithmsExtensions](Jcd.BitManipulation.Algorithms.ByteAlgorithmsExtensions.md 'Jcd.BitManipulation.Algorithms.ByteAlgorithmsExtensions')

## ByteAlgorithmsExtensions.RoundUpToPowerOfTwo(this byte) Method

For any given number return the number if it's a power of two,
or return the next higher power of two capable of fitting in the
data type.

```csharp
public static byte RoundUpToPowerOfTwo(this byte number);
```

#### Parameters

<a name='Jcd.BitManipulation.Algorithms.ByteAlgorithmsExtensions.RoundUpToPowerOfTwo(thisbyte).number'></a>

`number` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The number to evaluate.

#### Returns

[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

### Example

```csharp
byte v = 2;
Console.WriteLine($"{v.RoundUpToPowerOfTwo()}"); // outputs: 2

v = 3;
Console.WriteLine($"{v.RoundUpToPowerOfTwo()}"); // outputs: 4
```