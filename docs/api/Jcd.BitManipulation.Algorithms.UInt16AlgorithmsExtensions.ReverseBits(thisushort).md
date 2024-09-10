#### [Jcd.BitManipulation](index 'index')
### [Jcd.BitManipulation.Algorithms](Jcd.BitManipulation.Algorithms 'Jcd.BitManipulation.Algorithms').[UInt16AlgorithmsExtensions](Jcd.BitManipulation.Algorithms.UInt16AlgorithmsExtensions 'Jcd.BitManipulation.Algorithms.UInt16AlgorithmsExtensions')

## UInt16AlgorithmsExtensions.ReverseBits(this ushort) Method

Returns a value where the bits of the output are in the reverse order from their inputs.
For example: 1010000010101111 becomes 1111010100000101

```csharp
public static ushort ReverseBits(this ushort number);
```
#### Parameters

<a name='Jcd.BitManipulation.Algorithms.UInt16AlgorithmsExtensions.ReverseBits(thisushort).number'></a>

`number` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The number to evaluate

#### Returns
[System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')
The bits in reverse order.

### Remarks
Algorithm taken from: https://graphics.stanford.edu/~seander/bithacks.html#ReverseParallel