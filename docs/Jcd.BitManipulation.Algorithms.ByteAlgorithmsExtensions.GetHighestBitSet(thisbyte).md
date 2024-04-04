#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation.Algorithms](Jcd.BitManipulation.Algorithms.md 'Jcd.BitManipulation.Algorithms').[ByteAlgorithmsExtensions](Jcd.BitManipulation.Algorithms.ByteAlgorithmsExtensions.md 'Jcd.BitManipulation.Algorithms.ByteAlgorithmsExtensions')

## ByteAlgorithmsExtensions.GetHighestBitSet(this byte) Method

Calculate the index of the highest bit that's been set.

```csharp
public static int GetHighestBitSet(this byte number);
```

#### Parameters

<a name='Jcd.BitManipulation.Algorithms.ByteAlgorithmsExtensions.GetHighestBitSet(thisbyte).number'></a>

`number` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

the number to evaluate

#### Returns

[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')
The index of the highest bit that's been set; or -1 if none were set.