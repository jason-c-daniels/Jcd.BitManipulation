#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation.Algorithms](Jcd.BitManipulation.Algorithms.md 'Jcd.BitManipulation.Algorithms')

## ByteAlgorithmsExtensions Class

Provides bit counting and other niche bit manipulation facilities
for [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte') instances.

```csharp
public static class ByteAlgorithmsExtensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ByteAlgorithmsExtensions

| Methods | |
| :--- | :--- |
| [AreOnlyFirstAndLastBitsSet(this byte)](Jcd.BitManipulation.Algorithms.ByteAlgorithmsExtensions.AreOnlyFirstAndLastBitsSet(thisbyte).md 'Jcd.BitManipulation.Algorithms.ByteAlgorithmsExtensions.AreOnlyFirstAndLastBitsSet(this byte)') | Determines if the only lowest bit and one other higher bit are set. |
| [CountBitsSet(this byte)](Jcd.BitManipulation.Algorithms.ByteAlgorithmsExtensions.CountBitsSet(thisbyte).md 'Jcd.BitManipulation.Algorithms.ByteAlgorithmsExtensions.CountBitsSet(this byte)') | Counts the "set" bits on the number. |
| [CountLeadingZeros(this byte)](Jcd.BitManipulation.Algorithms.ByteAlgorithmsExtensions.CountLeadingZeros(thisbyte).md 'Jcd.BitManipulation.Algorithms.ByteAlgorithmsExtensions.CountLeadingZeros(this byte)') | Computes the number of sequentially zeroed bits occupying the most significant bit positions. |
| [CountTrailingZeros(this byte)](Jcd.BitManipulation.Algorithms.ByteAlgorithmsExtensions.CountTrailingZeros(thisbyte).md 'Jcd.BitManipulation.Algorithms.ByteAlgorithmsExtensions.CountTrailingZeros(this byte)') | Computes the number of sequentially zeroed bits occupying the least significant bit positions. |
| [GetHighestBitSet(this byte)](Jcd.BitManipulation.Algorithms.ByteAlgorithmsExtensions.GetHighestBitSet(thisbyte).md 'Jcd.BitManipulation.Algorithms.ByteAlgorithmsExtensions.GetHighestBitSet(this byte)') | Calculate the index of the highest bit that's been set. |
| [GetLowestBitSet(this byte)](Jcd.BitManipulation.Algorithms.ByteAlgorithmsExtensions.GetLowestBitSet(thisbyte).md 'Jcd.BitManipulation.Algorithms.ByteAlgorithmsExtensions.GetLowestBitSet(this byte)') | Calculate the index of the lowest bit that's been set. |
| [GetValueOrNextHigherPowerOfTwo(this byte)](Jcd.BitManipulation.Algorithms.ByteAlgorithmsExtensions.GetValueOrNextHigherPowerOfTwo(thisbyte).md 'Jcd.BitManipulation.Algorithms.ByteAlgorithmsExtensions.GetValueOrNextHigherPowerOfTwo(this byte)') | For any given number return the number if it's a power of two, or return the next higher power of two capable of fitting in the data type. |
| [IsPowerOfTwo(this byte)](Jcd.BitManipulation.Algorithms.ByteAlgorithmsExtensions.IsPowerOfTwo(thisbyte).md 'Jcd.BitManipulation.Algorithms.ByteAlgorithmsExtensions.IsPowerOfTwo(this byte)') | Determines if the number is a power of two. |
