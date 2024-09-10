#### [Jcd.BitManipulation](index 'index')
### [Jcd.BitManipulation.Algorithms](Jcd.BitManipulation.Algorithms 'Jcd.BitManipulation.Algorithms').[UInt32AlgorithmsExtensions](Jcd.BitManipulation.Algorithms.UInt32AlgorithmsExtensions 'Jcd.BitManipulation.Algorithms.UInt32AlgorithmsExtensions')

## UInt32AlgorithmsExtensions.ReverseBits(this uint) Method

Returns a value where the bits of the output are in the reverse order from their inputs.
For example: 1010000010101111 becomes 1111010100000101

```csharp
public static uint ReverseBits(this uint number);
```
#### Parameters

<a name='Jcd.BitManipulation.Algorithms.UInt32AlgorithmsExtensions.ReverseBits(thisuint).number'></a>

`number` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The number to evaluate

#### Returns
[System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')
The bits in reverse order.

### Remarks
Algorithm taken from: https://graphics.stanford.edu/~seander/bithacks.html#ReverseParallel