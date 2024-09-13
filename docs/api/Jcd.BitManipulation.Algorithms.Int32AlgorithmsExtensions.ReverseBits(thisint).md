#### [Jcd.BitManipulation](index 'index')
### [Jcd.BitManipulation.Algorithms](Jcd.BitManipulation.Algorithms 'Jcd.BitManipulation.Algorithms').[Int32AlgorithmsExtensions](Jcd.BitManipulation.Algorithms.Int32AlgorithmsExtensions 'Jcd.BitManipulation.Algorithms.Int32AlgorithmsExtensions')

## Int32AlgorithmsExtensions.ReverseBits(this int) Method

Returns a value where the bits of the output are in the reverse order from their inputs.
For example: 10101111 becomes 11110101

```csharp
public static int ReverseBits(this int number);
```
#### Parameters

<a name='Jcd.BitManipulation.Algorithms.Int32AlgorithmsExtensions.ReverseBits(thisint).number'></a>

`number` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The number to evaluate

#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')
The bits in reverse order.

### Remarks
Algorithm taken from: https://graphics.stanford.edu/~seander/bithacks.html#ReverseByteWith64Bits