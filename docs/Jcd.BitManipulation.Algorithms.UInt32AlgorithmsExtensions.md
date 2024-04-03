#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation.Algorithms](Jcd.BitManipulation.Algorithms.md 'Jcd.BitManipulation.Algorithms')

## UInt32AlgorithmsExtensions Class

Provides bit counting and other niche bit manipulation facilities
for [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32') instances.

```csharp
public static class UInt32AlgorithmsExtensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; UInt32AlgorithmsExtensions

| Methods | |
| :--- | :--- |
| [AreOnlyFirstAndLastBitsSet(this uint)](Jcd.BitManipulation.Algorithms.UInt32AlgorithmsExtensions.AreOnlyFirstAndLastBitsSet(thisuint).md 'Jcd.BitManipulation.Algorithms.UInt32AlgorithmsExtensions.AreOnlyFirstAndLastBitsSet(this uint)') | Determines if the only lowest bit and one other higher bit are set. |
| [CountBitsSet(this uint)](Jcd.BitManipulation.Algorithms.UInt32AlgorithmsExtensions.CountBitsSet(thisuint).md 'Jcd.BitManipulation.Algorithms.UInt32AlgorithmsExtensions.CountBitsSet(this uint)') | Counts the "set" bits on the number. |
| [CountLeadingZeros(this uint)](Jcd.BitManipulation.Algorithms.UInt32AlgorithmsExtensions.CountLeadingZeros(thisuint).md 'Jcd.BitManipulation.Algorithms.UInt32AlgorithmsExtensions.CountLeadingZeros(this uint)') | Computes the number of sequentially zeroed bits occupying the most significant bit positions. |
| [CountTrailingZeros(this uint)](Jcd.BitManipulation.Algorithms.UInt32AlgorithmsExtensions.CountTrailingZeros(thisuint).md 'Jcd.BitManipulation.Algorithms.UInt32AlgorithmsExtensions.CountTrailingZeros(this uint)') | Computes the number of sequentially zeroed bits occupying the least significant bit positions. |
| [GetHighestBitSet(this uint)](Jcd.BitManipulation.Algorithms.UInt32AlgorithmsExtensions.GetHighestBitSet(thisuint).md 'Jcd.BitManipulation.Algorithms.UInt32AlgorithmsExtensions.GetHighestBitSet(this uint)') | Calculate the index of the highest bit that's been set. |
| [GetLowestBitSet(this uint)](Jcd.BitManipulation.Algorithms.UInt32AlgorithmsExtensions.GetLowestBitSet(thisuint).md 'Jcd.BitManipulation.Algorithms.UInt32AlgorithmsExtensions.GetLowestBitSet(this uint)') | Calculate the index of the lowest bit that's been set. |
| [GetValueOrNextHigherPowerOfTwo(this uint)](Jcd.BitManipulation.Algorithms.UInt32AlgorithmsExtensions.GetValueOrNextHigherPowerOfTwo(thisuint).md 'Jcd.BitManipulation.Algorithms.UInt32AlgorithmsExtensions.GetValueOrNextHigherPowerOfTwo(this uint)') | For any given number return the number if it's a power of two, or return the next higher power of two capable of fitting in the data type. |
| [IsPowerOfTwo(this uint)](Jcd.BitManipulation.Algorithms.UInt32AlgorithmsExtensions.IsPowerOfTwo(thisuint).md 'Jcd.BitManipulation.Algorithms.UInt32AlgorithmsExtensions.IsPowerOfTwo(this uint)') | Determines if the number is a power of two. |
