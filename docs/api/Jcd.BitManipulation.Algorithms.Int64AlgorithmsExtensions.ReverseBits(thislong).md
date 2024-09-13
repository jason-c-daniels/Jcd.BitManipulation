#### [Jcd.BitManipulation](index 'index')
### [Jcd.BitManipulation.Algorithms](Jcd.BitManipulation.Algorithms 'Jcd.BitManipulation.Algorithms').[Int64AlgorithmsExtensions](Jcd.BitManipulation.Algorithms.Int64AlgorithmsExtensions 'Jcd.BitManipulation.Algorithms.Int64AlgorithmsExtensions')

## Int64AlgorithmsExtensions.ReverseBits(this long) Method

Returns a value where the bits of the output are in the reverse order from their inputs.
For example: 10101111 becomes 11110101

```csharp
public static long ReverseBits(this long number);
```
#### Parameters

<a name='Jcd.BitManipulation.Algorithms.Int64AlgorithmsExtensions.ReverseBits(thislong).number'></a>

`number` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The number to evaluate

#### Returns
[System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')
The bits in reverse order.

### Remarks
Algorithm taken from: https://graphics.stanford.edu/~seander/bithacks.html#ReverseByteWith64Bits