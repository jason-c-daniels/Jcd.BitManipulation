#### [Jcd.BitManipulation](index 'index')
### [Jcd.BitManipulation.Algorithms](Jcd.BitManipulation.Algorithms 'Jcd.BitManipulation.Algorithms')

## Int32AlgorithmsExtensions Class

Provides bit counting and other niche bit manipulation facilities
for [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32') values.

```csharp
public static class Int32AlgorithmsExtensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Int32AlgorithmsExtensions

| Methods | |
| :--- | :--- |
| [AreOnlyFirstAndLastBitsSet(this int)](Jcd.BitManipulation.Algorithms.Int32AlgorithmsExtensions.AreOnlyFirstAndLastBitsSet(thisint) 'Jcd.BitManipulation.Algorithms.Int32AlgorithmsExtensions.AreOnlyFirstAndLastBitsSet(this int)') | Determines if the only lowest bit and one other higher bit are set. |
| [CountBitsSet(this int)](Jcd.BitManipulation.Algorithms.Int32AlgorithmsExtensions.CountBitsSet(thisint) 'Jcd.BitManipulation.Algorithms.Int32AlgorithmsExtensions.CountBitsSet(this int)') | Counts the bits that are set to 1 in a number. |
| [CountLeadingZeros(this int)](Jcd.BitManipulation.Algorithms.Int32AlgorithmsExtensions.CountLeadingZeros(thisint) 'Jcd.BitManipulation.Algorithms.Int32AlgorithmsExtensions.CountLeadingZeros(this int)') | Computes the number of sequentially zeroed bits occupying the most significant bit positions. |
| [CountTrailingZeros(this int)](Jcd.BitManipulation.Algorithms.Int32AlgorithmsExtensions.CountTrailingZeros(thisint) 'Jcd.BitManipulation.Algorithms.Int32AlgorithmsExtensions.CountTrailingZeros(this int)') | Computes the number of sequentially zeroed bits occupying the least significant bit positions. |
| [GetHighestBitSet(this int)](Jcd.BitManipulation.Algorithms.Int32AlgorithmsExtensions.GetHighestBitSet(thisint) 'Jcd.BitManipulation.Algorithms.Int32AlgorithmsExtensions.GetHighestBitSet(this int)') | Calculate the index of the highest bit that's been set. |
| [GetLowestBitSet(this int)](Jcd.BitManipulation.Algorithms.Int32AlgorithmsExtensions.GetLowestBitSet(thisint) 'Jcd.BitManipulation.Algorithms.Int32AlgorithmsExtensions.GetLowestBitSet(this int)') | Calculate the index of the lowest bit that's been set. |
| [GetSign(this int)](Jcd.BitManipulation.Algorithms.Int32AlgorithmsExtensions.GetSign(thisint) 'Jcd.BitManipulation.Algorithms.Int32AlgorithmsExtensions.GetSign(this int)') | Returns a value indicating the sign of the number. |
| [IsEven(this int)](Jcd.BitManipulation.Algorithms.Int32AlgorithmsExtensions.IsEven(thisint) 'Jcd.BitManipulation.Algorithms.Int32AlgorithmsExtensions.IsEven(this int)') | Determines if the number is odd. |
| [IsNegative(this int)](Jcd.BitManipulation.Algorithms.Int32AlgorithmsExtensions.IsNegative(thisint) 'Jcd.BitManipulation.Algorithms.Int32AlgorithmsExtensions.IsNegative(this int)') | Indicates if the number is negative. |
| [IsOdd(this int)](Jcd.BitManipulation.Algorithms.Int32AlgorithmsExtensions.IsOdd(thisint) 'Jcd.BitManipulation.Algorithms.Int32AlgorithmsExtensions.IsOdd(this int)') | Determines if the number is odd. |
| [IsPositive(this int)](Jcd.BitManipulation.Algorithms.Int32AlgorithmsExtensions.IsPositive(thisint) 'Jcd.BitManipulation.Algorithms.Int32AlgorithmsExtensions.IsPositive(this int)') | Indicates if the number is zero or positive. |
| [IsPowerOfTwo(this int)](Jcd.BitManipulation.Algorithms.Int32AlgorithmsExtensions.IsPowerOfTwo(thisint) 'Jcd.BitManipulation.Algorithms.Int32AlgorithmsExtensions.IsPowerOfTwo(this int)') | Determines if the number is a power of two. |
| [PopCount(this int)](Jcd.BitManipulation.Algorithms.Int32AlgorithmsExtensions.PopCount(thisint) 'Jcd.BitManipulation.Algorithms.Int32AlgorithmsExtensions.PopCount(this int)') | Counts the bits that are set to 1 in a number. |
| [RotateLeft(this int, int)](Jcd.BitManipulation.Algorithms.Int32AlgorithmsExtensions.RotateLeft(thisint,int) 'Jcd.BitManipulation.Algorithms.Int32AlgorithmsExtensions.RotateLeft(this int, int)') | Performs a bitwise left rotation on a number. |
| [RotateRight(this int, int)](Jcd.BitManipulation.Algorithms.Int32AlgorithmsExtensions.RotateRight(thisint,int) 'Jcd.BitManipulation.Algorithms.Int32AlgorithmsExtensions.RotateRight(this int, int)') | Performs a bitwise right rotation on a number. |
| [RoundUpToPowerOfTwo(this int)](Jcd.BitManipulation.Algorithms.Int32AlgorithmsExtensions.RoundUpToPowerOfTwo(thisint) 'Jcd.BitManipulation.Algorithms.Int32AlgorithmsExtensions.RoundUpToPowerOfTwo(this int)') | For any given number return the number if it's a power of two, or return the next higher power of two capable of fitting in the data type. For negative values or values that would result in a negative next higher power of two, zero is returned. (e.g. number > 2^(k-2) where k is the bit size.) |