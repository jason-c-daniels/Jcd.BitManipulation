#### [Jcd.BitManipulation](index 'index')
### [Jcd.BitManipulation.Algorithms](Jcd.BitManipulation.Algorithms 'Jcd.BitManipulation.Algorithms')

## Int64AlgorithmsExtensions Class

Provides bit counting and other niche bit manipulation facilities
for [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64') values.

```csharp
public static class Int64AlgorithmsExtensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Int64AlgorithmsExtensions

| Methods | |
| :--- | :--- |
| [AreOnlyFirstAndLastBitsSet(this long)](Jcd.BitManipulation.Algorithms.Int64AlgorithmsExtensions.AreOnlyFirstAndLastBitsSet(thislong) 'Jcd.BitManipulation.Algorithms.Int64AlgorithmsExtensions.AreOnlyFirstAndLastBitsSet(this long)') | Determines if the only lowest bit and one other higher bit are set. |
| [CountBitsSet(this long)](Jcd.BitManipulation.Algorithms.Int64AlgorithmsExtensions.CountBitsSet(thislong) 'Jcd.BitManipulation.Algorithms.Int64AlgorithmsExtensions.CountBitsSet(this long)') | Counts the bits that are set to 1 in a number. |
| [CountLeadingZeros(this long)](Jcd.BitManipulation.Algorithms.Int64AlgorithmsExtensions.CountLeadingZeros(thislong) 'Jcd.BitManipulation.Algorithms.Int64AlgorithmsExtensions.CountLeadingZeros(this long)') | Computes the number of sequentially zeroed bits occupying the most significant bit positions. |
| [CountTrailingZeros(this long)](Jcd.BitManipulation.Algorithms.Int64AlgorithmsExtensions.CountTrailingZeros(thislong) 'Jcd.BitManipulation.Algorithms.Int64AlgorithmsExtensions.CountTrailingZeros(this long)') | Computes the number of sequentially zeroed bits occupying the least significant bit positions. |
| [GetHighestBitSet(this long)](Jcd.BitManipulation.Algorithms.Int64AlgorithmsExtensions.GetHighestBitSet(thislong) 'Jcd.BitManipulation.Algorithms.Int64AlgorithmsExtensions.GetHighestBitSet(this long)') | Calculate the index of the highest bit that's been set. |
| [GetLowestBitSet(this long)](Jcd.BitManipulation.Algorithms.Int64AlgorithmsExtensions.GetLowestBitSet(thislong) 'Jcd.BitManipulation.Algorithms.Int64AlgorithmsExtensions.GetLowestBitSet(this long)') | Calculate the index of the lowest bit that's been set. |
| [GetSign(this long)](Jcd.BitManipulation.Algorithms.Int64AlgorithmsExtensions.GetSign(thislong) 'Jcd.BitManipulation.Algorithms.Int64AlgorithmsExtensions.GetSign(this long)') | Returns a value indicating the sign of the number. |
| [IsEven(this long)](Jcd.BitManipulation.Algorithms.Int64AlgorithmsExtensions.IsEven(thislong) 'Jcd.BitManipulation.Algorithms.Int64AlgorithmsExtensions.IsEven(this long)') | Determines if the number is odd. |
| [IsNegative(this long)](Jcd.BitManipulation.Algorithms.Int64AlgorithmsExtensions.IsNegative(thislong) 'Jcd.BitManipulation.Algorithms.Int64AlgorithmsExtensions.IsNegative(this long)') | Indicates if the number is negative. |
| [IsOdd(this long)](Jcd.BitManipulation.Algorithms.Int64AlgorithmsExtensions.IsOdd(thislong) 'Jcd.BitManipulation.Algorithms.Int64AlgorithmsExtensions.IsOdd(this long)') | Determines if the number is odd. |
| [IsPositive(this long)](Jcd.BitManipulation.Algorithms.Int64AlgorithmsExtensions.IsPositive(thislong) 'Jcd.BitManipulation.Algorithms.Int64AlgorithmsExtensions.IsPositive(this long)') | Indicates if the number is zero or positive. |
| [IsPowerOfTwo(this long)](Jcd.BitManipulation.Algorithms.Int64AlgorithmsExtensions.IsPowerOfTwo(thislong) 'Jcd.BitManipulation.Algorithms.Int64AlgorithmsExtensions.IsPowerOfTwo(this long)') | Determines if the number is a power of two. |
| [PopCount(this long)](Jcd.BitManipulation.Algorithms.Int64AlgorithmsExtensions.PopCount(thislong) 'Jcd.BitManipulation.Algorithms.Int64AlgorithmsExtensions.PopCount(this long)') | Counts the bits that are set to 1 in a number. |
| [RotateLeft(this long, int)](Jcd.BitManipulation.Algorithms.Int64AlgorithmsExtensions.RotateLeft(thislong,int) 'Jcd.BitManipulation.Algorithms.Int64AlgorithmsExtensions.RotateLeft(this long, int)') | Performs a bitwise left rotation on a number. |
| [RotateRight(this long, int)](Jcd.BitManipulation.Algorithms.Int64AlgorithmsExtensions.RotateRight(thislong,int) 'Jcd.BitManipulation.Algorithms.Int64AlgorithmsExtensions.RotateRight(this long, int)') | Performs a bitwise right rotation on a number. |
| [RoundUpToPowerOfTwo(this long)](Jcd.BitManipulation.Algorithms.Int64AlgorithmsExtensions.RoundUpToPowerOfTwo(thislong) 'Jcd.BitManipulation.Algorithms.Int64AlgorithmsExtensions.RoundUpToPowerOfTwo(this long)') | For any given number return the number if it's a power of two, or return the next higher power of two capable of fitting in the data type. For negative values or values that would result in a negative next higher power of two, zero is returned. (e.g. number > 2^(k-2) where k is the bit size.) |
