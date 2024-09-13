#### [Jcd.BitManipulation](index 'index')
### [Jcd.BitManipulation.Algorithms](Jcd.BitManipulation.Algorithms 'Jcd.BitManipulation.Algorithms').[SByteAlgorithmsExtensions](Jcd.BitManipulation.Algorithms.SByteAlgorithmsExtensions 'Jcd.BitManipulation.Algorithms.SByteAlgorithmsExtensions')

## SByteAlgorithmsExtensions.ReverseBits(this sbyte) Method

Returns a value where the bits of the output are in the reverse order from their inputs.
For example: 10101111 becomes 11110101

```csharp
public static sbyte ReverseBits(this sbyte number);
```
#### Parameters

<a name='Jcd.BitManipulation.Algorithms.SByteAlgorithmsExtensions.ReverseBits(thissbyte).number'></a>

`number` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

The number to evaluate

#### Returns
[System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')
The bits in reverse order.

### Remarks
Algorithm taken from: https://graphics.stanford.edu/~seander/bithacks.html#ReverseByteWith64Bits