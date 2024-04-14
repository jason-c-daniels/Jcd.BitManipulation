#### [Jcd.BitManipulation](index 'index')
### [Jcd.BitManipulation.Algorithms](Jcd.BitManipulation.Algorithms 'Jcd.BitManipulation.Algorithms')

## UInt64AlgorithmsExtensions Class

Provides bit counting and other niche bit manipulation facilities
for [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64') values.

```csharp
public static class UInt64AlgorithmsExtensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; UInt64AlgorithmsExtensions

| Methods | |
| :--- | :--- |
| [AreOnlyFirstAndLastBitsSet(this ulong)](Jcd.BitManipulation.Algorithms.UInt64AlgorithmsExtensions.AreOnlyFirstAndLastBitsSet(thisulong) 'Jcd.BitManipulation.Algorithms.UInt64AlgorithmsExtensions.AreOnlyFirstAndLastBitsSet(this ulong)') | Determines if the only lowest bit and one other higher bit are set. |
| [CountBitsSet(this ulong)](Jcd.BitManipulation.Algorithms.UInt64AlgorithmsExtensions.CountBitsSet(thisulong) 'Jcd.BitManipulation.Algorithms.UInt64AlgorithmsExtensions.CountBitsSet(this ulong)') | Counts the bits that are set to 1 in a number. |
| [CountLeadingZeros(this ulong)](Jcd.BitManipulation.Algorithms.UInt64AlgorithmsExtensions.CountLeadingZeros(thisulong) 'Jcd.BitManipulation.Algorithms.UInt64AlgorithmsExtensions.CountLeadingZeros(this ulong)') | Computes the number of sequentially zeroed bits occupying the most significant bit positions. |
| [CountTrailingZeros(this ulong)](Jcd.BitManipulation.Algorithms.UInt64AlgorithmsExtensions.CountTrailingZeros(thisulong) 'Jcd.BitManipulation.Algorithms.UInt64AlgorithmsExtensions.CountTrailingZeros(this ulong)') | Computes the number of sequentially zeroed bits occupying the least significant bit positions. |
| [GetHighestBitSet(this ulong)](Jcd.BitManipulation.Algorithms.UInt64AlgorithmsExtensions.GetHighestBitSet(thisulong) 'Jcd.BitManipulation.Algorithms.UInt64AlgorithmsExtensions.GetHighestBitSet(this ulong)') | Calculate the index of the highest bit that's been set. |
| [GetLowestBitSet(this ulong)](Jcd.BitManipulation.Algorithms.UInt64AlgorithmsExtensions.GetLowestBitSet(thisulong) 'Jcd.BitManipulation.Algorithms.UInt64AlgorithmsExtensions.GetLowestBitSet(this ulong)') | Calculate the index of the lowest bit that's been set. |
| [GetSign(this ulong)](Jcd.BitManipulation.Algorithms.UInt64AlgorithmsExtensions.GetSign(thisulong) 'Jcd.BitManipulation.Algorithms.UInt64AlgorithmsExtensions.GetSign(this ulong)') | Returns a value indicating the sign of the number. |
| [IsEven(this ulong)](Jcd.BitManipulation.Algorithms.UInt64AlgorithmsExtensions.IsEven(thisulong) 'Jcd.BitManipulation.Algorithms.UInt64AlgorithmsExtensions.IsEven(this ulong)') | Determines if the number is odd. |
| [IsNegative(this ulong)](Jcd.BitManipulation.Algorithms.UInt64AlgorithmsExtensions.IsNegative(thisulong) 'Jcd.BitManipulation.Algorithms.UInt64AlgorithmsExtensions.IsNegative(this ulong)') | Indicates if the number is negative. (Always false for unsigned numbers) |
| [IsOdd(this ulong)](Jcd.BitManipulation.Algorithms.UInt64AlgorithmsExtensions.IsOdd(thisulong) 'Jcd.BitManipulation.Algorithms.UInt64AlgorithmsExtensions.IsOdd(this ulong)') | Determines if the number is odd. |
| [IsPositive(this ulong)](Jcd.BitManipulation.Algorithms.UInt64AlgorithmsExtensions.IsPositive(thisulong) 'Jcd.BitManipulation.Algorithms.UInt64AlgorithmsExtensions.IsPositive(this ulong)') | Indicates if the number is zero or positive. (Always true for unsigned numbers) |
| [IsPowerOfTwo(this ulong)](Jcd.BitManipulation.Algorithms.UInt64AlgorithmsExtensions.IsPowerOfTwo(thisulong) 'Jcd.BitManipulation.Algorithms.UInt64AlgorithmsExtensions.IsPowerOfTwo(this ulong)') | Determines if the number is a power of two. |
| [PopCount(this ulong)](Jcd.BitManipulation.Algorithms.UInt64AlgorithmsExtensions.PopCount(thisulong) 'Jcd.BitManipulation.Algorithms.UInt64AlgorithmsExtensions.PopCount(this ulong)') | Counts the bits that are set to 1 in a number. |
| [RotateLeft(this ulong, int)](Jcd.BitManipulation.Algorithms.UInt64AlgorithmsExtensions.RotateLeft(thisulong,int) 'Jcd.BitManipulation.Algorithms.UInt64AlgorithmsExtensions.RotateLeft(this ulong, int)') | Performs a bitwise left rotation on a number. |
| [RotateRight(this ulong, int)](Jcd.BitManipulation.Algorithms.UInt64AlgorithmsExtensions.RotateRight(thisulong,int) 'Jcd.BitManipulation.Algorithms.UInt64AlgorithmsExtensions.RotateRight(this ulong, int)') | Performs a bitwise right rotation on a number. |
| [RoundUpToPowerOfTwo(this ulong)](Jcd.BitManipulation.Algorithms.UInt64AlgorithmsExtensions.RoundUpToPowerOfTwo(thisulong) 'Jcd.BitManipulation.Algorithms.UInt64AlgorithmsExtensions.RoundUpToPowerOfTwo(this ulong)') | For any given number return the number if it's a power of two, or return the next higher power of two capable of fitting in the data type. |