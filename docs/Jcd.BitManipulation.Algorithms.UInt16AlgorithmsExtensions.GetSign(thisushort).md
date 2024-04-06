#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation.Algorithms](Jcd.BitManipulation.Algorithms.md 'Jcd.BitManipulation.Algorithms').[UInt16AlgorithmsExtensions](Jcd.BitManipulation.Algorithms.UInt16AlgorithmsExtensions.md 'Jcd.BitManipulation.Algorithms.UInt16AlgorithmsExtensions')

## UInt16AlgorithmsExtensions.GetSign(this ushort) Method

Returns a value indicating the sign of the number.

```csharp
public static int GetSign(this ushort number);
```

#### Parameters

<a name='Jcd.BitManipulation.Algorithms.UInt16AlgorithmsExtensions.GetSign(thisushort).number'></a>

`number` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The number to evaluate

#### Returns

[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')
-1 if < 0; 1 if > 0; 0 otherwise.