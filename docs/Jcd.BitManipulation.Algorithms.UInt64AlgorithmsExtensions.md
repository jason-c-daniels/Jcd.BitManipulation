#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation.Algorithms](Jcd.BitManipulation.Algorithms.md 'Jcd.BitManipulation.Algorithms')

## UInt64AlgorithmsExtensions Class

Provides bit counting and other niche bit manipulation facilities
for [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64') instances.

```csharp
public static class UInt64AlgorithmsExtensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; UInt64AlgorithmsExtensions

| Methods | |
| :--- | :--- |
| [AreOnlyFirstAndLastBitsSet(this ulong)](Jcd.BitManipulation.Algorithms.UInt64AlgorithmsExtensions.AreOnlyFirstAndLastBitsSet(thisulong).md 'Jcd.BitManipulation.Algorithms.UInt64AlgorithmsExtensions.AreOnlyFirstAndLastBitsSet(this ulong)') | Determines if the only lowest bit and one other higher bit are set. |
| [CountBitsSet(this ulong)](Jcd.BitManipulation.Algorithms.UInt64AlgorithmsExtensions.CountBitsSet(thisulong).md 'Jcd.BitManipulation.Algorithms.UInt64AlgorithmsExtensions.CountBitsSet(this ulong)') | Counts the "set" bits on the number. |
| [CountLeadingZeros(this ulong)](Jcd.BitManipulation.Algorithms.UInt64AlgorithmsExtensions.CountLeadingZeros(thisulong).md 'Jcd.BitManipulation.Algorithms.UInt64AlgorithmsExtensions.CountLeadingZeros(this ulong)') | Computes the number of sequentially zeroed bits occupying the most significant bit positions. |
| [CountTrailingZeros(this ulong)](Jcd.BitManipulation.Algorithms.UInt64AlgorithmsExtensions.CountTrailingZeros(thisulong).md 'Jcd.BitManipulation.Algorithms.UInt64AlgorithmsExtensions.CountTrailingZeros(this ulong)') | Computes the number of sequentially zeroed bits occupying the least significant bit positions. |
| [GetHighestBitSet(this ulong)](Jcd.BitManipulation.Algorithms.UInt64AlgorithmsExtensions.GetHighestBitSet(thisulong).md 'Jcd.BitManipulation.Algorithms.UInt64AlgorithmsExtensions.GetHighestBitSet(this ulong)') | Calculate the index of the highest bit that's been set. |
| [GetLowestBitSet(this ulong)](Jcd.BitManipulation.Algorithms.UInt64AlgorithmsExtensions.GetLowestBitSet(thisulong).md 'Jcd.BitManipulation.Algorithms.UInt64AlgorithmsExtensions.GetLowestBitSet(this ulong)') | Calculate the index of the lowest bit that's been set. |
| [GetValueOrNextHigherPowerOfTwo(this ulong)](Jcd.BitManipulation.Algorithms.UInt64AlgorithmsExtensions.GetValueOrNextHigherPowerOfTwo(thisulong).md 'Jcd.BitManipulation.Algorithms.UInt64AlgorithmsExtensions.GetValueOrNextHigherPowerOfTwo(this ulong)') | For any given number return the number if it's a power of two, or return the next higher power of two capable of fitting in the data type. |
| [IsPowerOfTwo(this ulong)](Jcd.BitManipulation.Algorithms.UInt64AlgorithmsExtensions.IsPowerOfTwo(thisulong).md 'Jcd.BitManipulation.Algorithms.UInt64AlgorithmsExtensions.IsPowerOfTwo(this ulong)') | Determines if the number is a power of two. |
