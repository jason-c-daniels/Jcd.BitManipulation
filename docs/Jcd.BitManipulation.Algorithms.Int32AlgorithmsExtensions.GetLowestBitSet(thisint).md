#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation.Algorithms](Jcd.BitManipulation.Algorithms.md 'Jcd.BitManipulation.Algorithms').[Int32AlgorithmsExtensions](Jcd.BitManipulation.Algorithms.Int32AlgorithmsExtensions.md 'Jcd.BitManipulation.Algorithms.Int32AlgorithmsExtensions')

## Int32AlgorithmsExtensions.GetLowestBitSet(this int) Method

Calculate the index of the lowest bit that's been set.

```csharp
public static int GetLowestBitSet(this int number);
```

#### Parameters

<a name='Jcd.BitManipulation.Algorithms.Int32AlgorithmsExtensions.GetLowestBitSet(thisint).number'></a>

`number` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

the number to evaluate

#### Returns

[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')
The index of the lowest bit that's been set; or -1 if none were set.