#### [Jcd.BitManipulation](index 'index')
### [Jcd.BitManipulation.Algorithms](Jcd.BitManipulation.Algorithms 'Jcd.BitManipulation.Algorithms')

## SByteAlgorithmsExtensions Class

Provides bit counting and other niche bit manipulation facilities
for [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte') values.

```csharp
public static class SByteAlgorithmsExtensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; SByteAlgorithmsExtensions

| Methods | |
| :--- | :--- |
| [AreOnlyFirstAndLastBitsSet(this sbyte)](Jcd.BitManipulation.Algorithms.SByteAlgorithmsExtensions.AreOnlyFirstAndLastBitsSet(thissbyte) 'Jcd.BitManipulation.Algorithms.SByteAlgorithmsExtensions.AreOnlyFirstAndLastBitsSet(this sbyte)') | Determines if the only lowest bit and one other higher bit are set. |
| [CountBitsSet(this sbyte)](Jcd.BitManipulation.Algorithms.SByteAlgorithmsExtensions.CountBitsSet(thissbyte) 'Jcd.BitManipulation.Algorithms.SByteAlgorithmsExtensions.CountBitsSet(this sbyte)') | Counts the bits that are set to 1 in a number. |
| [CountLeadingZeros(this sbyte)](Jcd.BitManipulation.Algorithms.SByteAlgorithmsExtensions.CountLeadingZeros(thissbyte) 'Jcd.BitManipulation.Algorithms.SByteAlgorithmsExtensions.CountLeadingZeros(this sbyte)') | Computes the number of sequentially zeroed bits occupying the most significant bit positions. |
| [CountTrailingZeros(this sbyte)](Jcd.BitManipulation.Algorithms.SByteAlgorithmsExtensions.CountTrailingZeros(thissbyte) 'Jcd.BitManipulation.Algorithms.SByteAlgorithmsExtensions.CountTrailingZeros(this sbyte)') | Computes the number of sequentially zeroed bits occupying the least significant bit positions. |
| [GetHighestBitSet(this sbyte)](Jcd.BitManipulation.Algorithms.SByteAlgorithmsExtensions.GetHighestBitSet(thissbyte) 'Jcd.BitManipulation.Algorithms.SByteAlgorithmsExtensions.GetHighestBitSet(this sbyte)') | Calculate the index of the highest bit that's been set. |
| [GetLowestBitSet(this sbyte)](Jcd.BitManipulation.Algorithms.SByteAlgorithmsExtensions.GetLowestBitSet(thissbyte) 'Jcd.BitManipulation.Algorithms.SByteAlgorithmsExtensions.GetLowestBitSet(this sbyte)') | Calculate the index of the lowest bit that's been set. |
| [GetSign(this sbyte)](Jcd.BitManipulation.Algorithms.SByteAlgorithmsExtensions.GetSign(thissbyte) 'Jcd.BitManipulation.Algorithms.SByteAlgorithmsExtensions.GetSign(this sbyte)') | Returns a value indicating the sign of the number. |
| [IsEven(this sbyte)](Jcd.BitManipulation.Algorithms.SByteAlgorithmsExtensions.IsEven(thissbyte) 'Jcd.BitManipulation.Algorithms.SByteAlgorithmsExtensions.IsEven(this sbyte)') | Determines if the number is odd. |
| [IsNegative(this sbyte)](Jcd.BitManipulation.Algorithms.SByteAlgorithmsExtensions.IsNegative(thissbyte) 'Jcd.BitManipulation.Algorithms.SByteAlgorithmsExtensions.IsNegative(this sbyte)') | Indicates if the number is negative. |
| [IsOdd(this sbyte)](Jcd.BitManipulation.Algorithms.SByteAlgorithmsExtensions.IsOdd(thissbyte) 'Jcd.BitManipulation.Algorithms.SByteAlgorithmsExtensions.IsOdd(this sbyte)') | Determines if the number is odd. |
| [IsPositive(this sbyte)](Jcd.BitManipulation.Algorithms.SByteAlgorithmsExtensions.IsPositive(thissbyte) 'Jcd.BitManipulation.Algorithms.SByteAlgorithmsExtensions.IsPositive(this sbyte)') | Indicates if the number is zero or positive. |
| [IsPowerOfTwo(this sbyte)](Jcd.BitManipulation.Algorithms.SByteAlgorithmsExtensions.IsPowerOfTwo(thissbyte) 'Jcd.BitManipulation.Algorithms.SByteAlgorithmsExtensions.IsPowerOfTwo(this sbyte)') | Determines if the number is a power of two. |
| [PopCount(this sbyte)](Jcd.BitManipulation.Algorithms.SByteAlgorithmsExtensions.PopCount(thissbyte) 'Jcd.BitManipulation.Algorithms.SByteAlgorithmsExtensions.PopCount(this sbyte)') | Counts the bits that are set to 1 in a number. |
| [RotateLeft(this sbyte, int)](Jcd.BitManipulation.Algorithms.SByteAlgorithmsExtensions.RotateLeft(thissbyte,int) 'Jcd.BitManipulation.Algorithms.SByteAlgorithmsExtensions.RotateLeft(this sbyte, int)') | Performs a bitwise left rotation on a number. |
| [RotateRight(this sbyte, int)](Jcd.BitManipulation.Algorithms.SByteAlgorithmsExtensions.RotateRight(thissbyte,int) 'Jcd.BitManipulation.Algorithms.SByteAlgorithmsExtensions.RotateRight(this sbyte, int)') | Performs a bitwise right rotation on a number. |
| [RoundUpToPowerOfTwo(this sbyte)](Jcd.BitManipulation.Algorithms.SByteAlgorithmsExtensions.RoundUpToPowerOfTwo(thissbyte) 'Jcd.BitManipulation.Algorithms.SByteAlgorithmsExtensions.RoundUpToPowerOfTwo(this sbyte)') | For any given number return the number if it's a power of two, or return the next higher power of two capable of fitting in the data type. For negative values or values that would result in a negative next higher power of two, zero is returned. (e.g. number > 2^(k-2)) where k is the bit size.) |