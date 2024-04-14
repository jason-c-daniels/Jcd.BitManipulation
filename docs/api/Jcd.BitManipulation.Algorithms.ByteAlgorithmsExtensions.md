#### [Jcd.BitManipulation](index 'index')
### [Jcd.BitManipulation.Algorithms](Jcd.BitManipulation.Algorithms 'Jcd.BitManipulation.Algorithms')

## ByteAlgorithmsExtensions Class

Provides bit counting and other niche bit manipulation facilities
for [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte') values.

```csharp
public static class ByteAlgorithmsExtensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ByteAlgorithmsExtensions

| Methods | |
| :--- | :--- |
| [AreOnlyFirstAndLastBitsSet(this byte)](Jcd.BitManipulation.Algorithms.ByteAlgorithmsExtensions.AreOnlyFirstAndLastBitsSet(thisbyte) 'Jcd.BitManipulation.Algorithms.ByteAlgorithmsExtensions.AreOnlyFirstAndLastBitsSet(this byte)') | Determines if the only lowest bit and one other higher bit are set. |
| [CountBitsSet(this byte)](Jcd.BitManipulation.Algorithms.ByteAlgorithmsExtensions.CountBitsSet(thisbyte) 'Jcd.BitManipulation.Algorithms.ByteAlgorithmsExtensions.CountBitsSet(this byte)') | Counts the bits that are set to 1 in a number. |
| [CountLeadingZeros(this byte)](Jcd.BitManipulation.Algorithms.ByteAlgorithmsExtensions.CountLeadingZeros(thisbyte) 'Jcd.BitManipulation.Algorithms.ByteAlgorithmsExtensions.CountLeadingZeros(this byte)') | Computes the number of sequentially zeroed bits occupying the most significant bit positions. |
| [CountTrailingZeros(this byte)](Jcd.BitManipulation.Algorithms.ByteAlgorithmsExtensions.CountTrailingZeros(thisbyte) 'Jcd.BitManipulation.Algorithms.ByteAlgorithmsExtensions.CountTrailingZeros(this byte)') | Computes the number of sequentially zeroed bits occupying the least significant bit positions. |
| [GetHighestBitSet(this byte)](Jcd.BitManipulation.Algorithms.ByteAlgorithmsExtensions.GetHighestBitSet(thisbyte) 'Jcd.BitManipulation.Algorithms.ByteAlgorithmsExtensions.GetHighestBitSet(this byte)') | Calculate the index of the highest bit that's been set. |
| [GetLowestBitSet(this byte)](Jcd.BitManipulation.Algorithms.ByteAlgorithmsExtensions.GetLowestBitSet(thisbyte) 'Jcd.BitManipulation.Algorithms.ByteAlgorithmsExtensions.GetLowestBitSet(this byte)') | Calculate the index of the lowest bit that's been set. |
| [GetSign(this byte)](Jcd.BitManipulation.Algorithms.ByteAlgorithmsExtensions.GetSign(thisbyte) 'Jcd.BitManipulation.Algorithms.ByteAlgorithmsExtensions.GetSign(this byte)') | Returns a value indicating the sign of the number. |
| [IsEven(this byte)](Jcd.BitManipulation.Algorithms.ByteAlgorithmsExtensions.IsEven(thisbyte) 'Jcd.BitManipulation.Algorithms.ByteAlgorithmsExtensions.IsEven(this byte)') | Determines if the number is odd. |
| [IsNegative(this byte)](Jcd.BitManipulation.Algorithms.ByteAlgorithmsExtensions.IsNegative(thisbyte) 'Jcd.BitManipulation.Algorithms.ByteAlgorithmsExtensions.IsNegative(this byte)') | Indicates if the number is negative. (Always false for unsigned numbers) |
| [IsOdd(this byte)](Jcd.BitManipulation.Algorithms.ByteAlgorithmsExtensions.IsOdd(thisbyte) 'Jcd.BitManipulation.Algorithms.ByteAlgorithmsExtensions.IsOdd(this byte)') | Determines if the number is odd. |
| [IsPositive(this byte)](Jcd.BitManipulation.Algorithms.ByteAlgorithmsExtensions.IsPositive(thisbyte) 'Jcd.BitManipulation.Algorithms.ByteAlgorithmsExtensions.IsPositive(this byte)') | Indicates if the number is zero or positive. (Always true for unsigned numbers) |
| [IsPowerOfTwo(this byte)](Jcd.BitManipulation.Algorithms.ByteAlgorithmsExtensions.IsPowerOfTwo(thisbyte) 'Jcd.BitManipulation.Algorithms.ByteAlgorithmsExtensions.IsPowerOfTwo(this byte)') | Determines if the number is a power of two. |
| [PopCount(this byte)](Jcd.BitManipulation.Algorithms.ByteAlgorithmsExtensions.PopCount(thisbyte) 'Jcd.BitManipulation.Algorithms.ByteAlgorithmsExtensions.PopCount(this byte)') | Counts the bits that are set to 1 in a number. |
| [RotateLeft(this byte, int)](Jcd.BitManipulation.Algorithms.ByteAlgorithmsExtensions.RotateLeft(thisbyte,int) 'Jcd.BitManipulation.Algorithms.ByteAlgorithmsExtensions.RotateLeft(this byte, int)') | Performs a bitwise left rotation on a number. |
| [RotateRight(this byte, int)](Jcd.BitManipulation.Algorithms.ByteAlgorithmsExtensions.RotateRight(thisbyte,int) 'Jcd.BitManipulation.Algorithms.ByteAlgorithmsExtensions.RotateRight(this byte, int)') | Performs a bitwise right rotation on a number. |
| [RoundUpToPowerOfTwo(this byte)](Jcd.BitManipulation.Algorithms.ByteAlgorithmsExtensions.RoundUpToPowerOfTwo(thisbyte) 'Jcd.BitManipulation.Algorithms.ByteAlgorithmsExtensions.RoundUpToPowerOfTwo(this byte)') | For any given number return the number if it's a power of two, or return the next higher power of two capable of fitting in the data type. |