#### [Jcd.BitManipulation](index 'index')
### [Jcd.BitManipulation.Algorithms](Jcd.BitManipulation.Algorithms 'Jcd.BitManipulation.Algorithms')

## UInt16AlgorithmsExtensions Class

Provides bit counting and other niche bit manipulation facilities
for [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16') values.

```csharp
public static class UInt16AlgorithmsExtensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; UInt16AlgorithmsExtensions

| Methods | |
| :--- | :--- |
| [AreOnlyFirstAndLastBitsSet(this ushort)](Jcd.BitManipulation.Algorithms.UInt16AlgorithmsExtensions.AreOnlyFirstAndLastBitsSet(thisushort) 'Jcd.BitManipulation.Algorithms.UInt16AlgorithmsExtensions.AreOnlyFirstAndLastBitsSet(this ushort)') | Determines if the only lowest bit and one other higher bit are set. |
| [CountBitsSet(this ushort)](Jcd.BitManipulation.Algorithms.UInt16AlgorithmsExtensions.CountBitsSet(thisushort) 'Jcd.BitManipulation.Algorithms.UInt16AlgorithmsExtensions.CountBitsSet(this ushort)') | Counts the bits that are set to 1 in a number. |
| [CountLeadingZeros(this ushort)](Jcd.BitManipulation.Algorithms.UInt16AlgorithmsExtensions.CountLeadingZeros(thisushort) 'Jcd.BitManipulation.Algorithms.UInt16AlgorithmsExtensions.CountLeadingZeros(this ushort)') | Computes the number of sequentially zeroed bits occupying the most significant bit positions. |
| [CountTrailingZeros(this ushort)](Jcd.BitManipulation.Algorithms.UInt16AlgorithmsExtensions.CountTrailingZeros(thisushort) 'Jcd.BitManipulation.Algorithms.UInt16AlgorithmsExtensions.CountTrailingZeros(this ushort)') | Computes the number of sequentially zeroed bits occupying the least significant bit positions. |
| [GetHighestBitSet(this ushort)](Jcd.BitManipulation.Algorithms.UInt16AlgorithmsExtensions.GetHighestBitSet(thisushort) 'Jcd.BitManipulation.Algorithms.UInt16AlgorithmsExtensions.GetHighestBitSet(this ushort)') | Calculate the index of the highest bit that's been set. |
| [GetLowestBitSet(this ushort)](Jcd.BitManipulation.Algorithms.UInt16AlgorithmsExtensions.GetLowestBitSet(thisushort) 'Jcd.BitManipulation.Algorithms.UInt16AlgorithmsExtensions.GetLowestBitSet(this ushort)') | Calculate the index of the lowest bit that's been set. |
| [GetSign(this ushort)](Jcd.BitManipulation.Algorithms.UInt16AlgorithmsExtensions.GetSign(thisushort) 'Jcd.BitManipulation.Algorithms.UInt16AlgorithmsExtensions.GetSign(this ushort)') | Returns a value indicating the sign of the number. |
| [IsEven(this ushort)](Jcd.BitManipulation.Algorithms.UInt16AlgorithmsExtensions.IsEven(thisushort) 'Jcd.BitManipulation.Algorithms.UInt16AlgorithmsExtensions.IsEven(this ushort)') | Determines if the number is odd. |
| [IsNegative(this ushort)](Jcd.BitManipulation.Algorithms.UInt16AlgorithmsExtensions.IsNegative(thisushort) 'Jcd.BitManipulation.Algorithms.UInt16AlgorithmsExtensions.IsNegative(this ushort)') | Indicates if the number is negative. (Always false for unsigned numbers) |
| [IsOdd(this ushort)](Jcd.BitManipulation.Algorithms.UInt16AlgorithmsExtensions.IsOdd(thisushort) 'Jcd.BitManipulation.Algorithms.UInt16AlgorithmsExtensions.IsOdd(this ushort)') | Determines if the number is odd. |
| [IsPositive(this ushort)](Jcd.BitManipulation.Algorithms.UInt16AlgorithmsExtensions.IsPositive(thisushort) 'Jcd.BitManipulation.Algorithms.UInt16AlgorithmsExtensions.IsPositive(this ushort)') | Indicates if the number is zero or positive. (Always true for unsigned numbers) |
| [IsPowerOfTwo(this ushort)](Jcd.BitManipulation.Algorithms.UInt16AlgorithmsExtensions.IsPowerOfTwo(thisushort) 'Jcd.BitManipulation.Algorithms.UInt16AlgorithmsExtensions.IsPowerOfTwo(this ushort)') | Determines if the number is a power of two. |
| [PopCount(this ushort)](Jcd.BitManipulation.Algorithms.UInt16AlgorithmsExtensions.PopCount(thisushort) 'Jcd.BitManipulation.Algorithms.UInt16AlgorithmsExtensions.PopCount(this ushort)') | Counts the bits that are set to 1 in a number. |
| [RotateLeft(this ushort, int)](Jcd.BitManipulation.Algorithms.UInt16AlgorithmsExtensions.RotateLeft(thisushort,int) 'Jcd.BitManipulation.Algorithms.UInt16AlgorithmsExtensions.RotateLeft(this ushort, int)') | Performs a bitwise left rotation on a number. |
| [RotateRight(this ushort, int)](Jcd.BitManipulation.Algorithms.UInt16AlgorithmsExtensions.RotateRight(thisushort,int) 'Jcd.BitManipulation.Algorithms.UInt16AlgorithmsExtensions.RotateRight(this ushort, int)') | Performs a bitwise right rotation on a number. |
| [RoundUpToPowerOfTwo(this ushort)](Jcd.BitManipulation.Algorithms.UInt16AlgorithmsExtensions.RoundUpToPowerOfTwo(thisushort) 'Jcd.BitManipulation.Algorithms.UInt16AlgorithmsExtensions.RoundUpToPowerOfTwo(this ushort)') | For any given number return the number if it's a power of two, or return the next higher power of two capable of fitting in the data type. |
