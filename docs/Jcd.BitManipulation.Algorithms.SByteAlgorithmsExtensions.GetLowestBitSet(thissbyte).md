#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation.Algorithms](Jcd.BitManipulation.Algorithms.md 'Jcd.BitManipulation.Algorithms').[SByteAlgorithmsExtensions](Jcd.BitManipulation.Algorithms.SByteAlgorithmsExtensions.md 'Jcd.BitManipulation.Algorithms.SByteAlgorithmsExtensions')

## SByteAlgorithmsExtensions.GetLowestBitSet(this sbyte) Method

Calculate the index of the lowest bit that's been set.

```csharp
public static sbyte GetLowestBitSet(this sbyte number);
```

#### Parameters

<a name='Jcd.BitManipulation.Algorithms.SByteAlgorithmsExtensions.GetLowestBitSet(thissbyte).number'></a>

`number` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

the number to evaluate

#### Returns

[System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')
The index of the lowest bit that's been set; or -1 if none were set.