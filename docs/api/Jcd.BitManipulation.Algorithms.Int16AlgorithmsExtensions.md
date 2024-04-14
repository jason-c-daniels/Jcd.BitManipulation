#### [Jcd.BitManipulation](index 'index')
### [Jcd.BitManipulation.Algorithms](Jcd.BitManipulation.Algorithms 'Jcd.BitManipulation.Algorithms')

## Int16AlgorithmsExtensions Class

Provides bit counting and other niche bit manipulation facilities
for [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16') values.

```csharp
public static class Int16AlgorithmsExtensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Int16AlgorithmsExtensions

| Methods | |
| :--- | :--- |
| [AreOnlyFirstAndLastBitsSet(this short)](Jcd.BitManipulation.Algorithms.Int16AlgorithmsExtensions.AreOnlyFirstAndLastBitsSet(thisshort) 'Jcd.BitManipulation.Algorithms.Int16AlgorithmsExtensions.AreOnlyFirstAndLastBitsSet(this short)') | Determines if the only lowest bit and one other higher bit are set. |
| [CountBitsSet(this short)](Jcd.BitManipulation.Algorithms.Int16AlgorithmsExtensions.CountBitsSet(thisshort) 'Jcd.BitManipulation.Algorithms.Int16AlgorithmsExtensions.CountBitsSet(this short)') | Counts the bits that are set to 1 in a number. |
| [CountLeadingZeros(this short)](Jcd.BitManipulation.Algorithms.Int16AlgorithmsExtensions.CountLeadingZeros(thisshort) 'Jcd.BitManipulation.Algorithms.Int16AlgorithmsExtensions.CountLeadingZeros(this short)') | Computes the number of sequentially zeroed bits occupying the most significant bit positions. |
| [CountTrailingZeros(this short)](Jcd.BitManipulation.Algorithms.Int16AlgorithmsExtensions.CountTrailingZeros(thisshort) 'Jcd.BitManipulation.Algorithms.Int16AlgorithmsExtensions.CountTrailingZeros(this short)') | Computes the number of sequentially zeroed bits occupying the least significant bit positions. |
| [GetHighestBitSet(this short)](Jcd.BitManipulation.Algorithms.Int16AlgorithmsExtensions.GetHighestBitSet(thisshort) 'Jcd.BitManipulation.Algorithms.Int16AlgorithmsExtensions.GetHighestBitSet(this short)') | Calculate the index of the highest bit that's been set. |
| [GetLowestBitSet(this short)](Jcd.BitManipulation.Algorithms.Int16AlgorithmsExtensions.GetLowestBitSet(thisshort) 'Jcd.BitManipulation.Algorithms.Int16AlgorithmsExtensions.GetLowestBitSet(this short)') | Calculate the index of the lowest bit that's been set. |
| [GetSign(this short)](Jcd.BitManipulation.Algorithms.Int16AlgorithmsExtensions.GetSign(thisshort) 'Jcd.BitManipulation.Algorithms.Int16AlgorithmsExtensions.GetSign(this short)') | Returns a value indicating the sign of the number. |
| [IsEven(this short)](Jcd.BitManipulation.Algorithms.Int16AlgorithmsExtensions.IsEven(thisshort) 'Jcd.BitManipulation.Algorithms.Int16AlgorithmsExtensions.IsEven(this short)') | Determines if the number is odd. |
| [IsNegative(this short)](Jcd.BitManipulation.Algorithms.Int16AlgorithmsExtensions.IsNegative(thisshort) 'Jcd.BitManipulation.Algorithms.Int16AlgorithmsExtensions.IsNegative(this short)') | Indicates if the number is negative. |
| [IsOdd(this short)](Jcd.BitManipulation.Algorithms.Int16AlgorithmsExtensions.IsOdd(thisshort) 'Jcd.BitManipulation.Algorithms.Int16AlgorithmsExtensions.IsOdd(this short)') | Determines if the number is odd. |
| [IsPositive(this short)](Jcd.BitManipulation.Algorithms.Int16AlgorithmsExtensions.IsPositive(thisshort) 'Jcd.BitManipulation.Algorithms.Int16AlgorithmsExtensions.IsPositive(this short)') | Indicates if the number is zero or positive. |
| [IsPowerOfTwo(this short)](Jcd.BitManipulation.Algorithms.Int16AlgorithmsExtensions.IsPowerOfTwo(thisshort) 'Jcd.BitManipulation.Algorithms.Int16AlgorithmsExtensions.IsPowerOfTwo(this short)') | Determines if the number is a power of two. |
| [PopCount(this short)](Jcd.BitManipulation.Algorithms.Int16AlgorithmsExtensions.PopCount(thisshort) 'Jcd.BitManipulation.Algorithms.Int16AlgorithmsExtensions.PopCount(this short)') | Counts the bits that are set to 1 in a number. |
| [RotateLeft(this short, int)](Jcd.BitManipulation.Algorithms.Int16AlgorithmsExtensions.RotateLeft(thisshort,int) 'Jcd.BitManipulation.Algorithms.Int16AlgorithmsExtensions.RotateLeft(this short, int)') | Performs a bitwise left rotation on a number. |
| [RotateRight(this short, int)](Jcd.BitManipulation.Algorithms.Int16AlgorithmsExtensions.RotateRight(thisshort,int) 'Jcd.BitManipulation.Algorithms.Int16AlgorithmsExtensions.RotateRight(this short, int)') | Performs a bitwise right rotation on a number. |
| [RoundUpToPowerOfTwo(this short)](Jcd.BitManipulation.Algorithms.Int16AlgorithmsExtensions.RoundUpToPowerOfTwo(thisshort) 'Jcd.BitManipulation.Algorithms.Int16AlgorithmsExtensions.RoundUpToPowerOfTwo(this short)') | For any given number return the number if it's a power of two, or return the next higher power of two capable of fitting in the data type. For negative values or values that would result in a negative next higher power of two, zero is returned. (e.g. number > 2^(k-2) where k is the bit size.) |