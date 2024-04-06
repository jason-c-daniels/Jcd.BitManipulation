#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation.Algorithms](Jcd.BitManipulation.Algorithms.md 'Jcd.BitManipulation.Algorithms').[Int64AlgorithmsExtensions](Jcd.BitManipulation.Algorithms.Int64AlgorithmsExtensions.md 'Jcd.BitManipulation.Algorithms.Int64AlgorithmsExtensions')

## Int64AlgorithmsExtensions.GetHighestBitSet(this long) Method

Calculate the index of the highest bit that's been set.

```csharp
public static int GetHighestBitSet(this long number);
```

#### Parameters

<a name='Jcd.BitManipulation.Algorithms.Int64AlgorithmsExtensions.GetHighestBitSet(thislong).number'></a>

`number` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

the number to evaluate

#### Returns

[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')
The index of the highest bit that's been set; or -1 if none were set.