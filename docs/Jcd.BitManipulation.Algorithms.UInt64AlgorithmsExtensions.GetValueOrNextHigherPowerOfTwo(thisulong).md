#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation.Algorithms](Jcd.BitManipulation.Algorithms.md 'Jcd.BitManipulation.Algorithms').[UInt64AlgorithmsExtensions](Jcd.BitManipulation.Algorithms.UInt64AlgorithmsExtensions.md 'Jcd.BitManipulation.Algorithms.UInt64AlgorithmsExtensions')

## UInt64AlgorithmsExtensions.GetValueOrNextHigherPowerOfTwo(this ulong) Method

For any given number return the number if it's a power of two,
or return the next higher power of two capable of fitting in the
data type.

```csharp
public static ulong GetValueOrNextHigherPowerOfTwo(this ulong number);
```
#### Parameters

<a name='Jcd.BitManipulation.Algorithms.UInt64AlgorithmsExtensions.GetValueOrNextHigherPowerOfTwo(thisulong).number'></a>

`number` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

the number to evaluate

#### Returns
[System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')