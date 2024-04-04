#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation.Algorithms](Jcd.BitManipulation.Algorithms.md 'Jcd.BitManipulation.Algorithms').[Int16AlgorithmsExtensions](Jcd.BitManipulation.Algorithms.Int16AlgorithmsExtensions.md 'Jcd.BitManipulation.Algorithms.Int16AlgorithmsExtensions')

## Int16AlgorithmsExtensions.GetHighestBitSet(this short) Method

Calculate the index of the highest bit that's been set.

```csharp
public static int GetHighestBitSet(this short number);
```

#### Parameters

<a name='Jcd.BitManipulation.Algorithms.Int16AlgorithmsExtensions.GetHighestBitSet(thisshort).number'></a>

`number` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

the number to evaluate

#### Returns

[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')
The index of the highest bit that's been set; or -1 if none were set.