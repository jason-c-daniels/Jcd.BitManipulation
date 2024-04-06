#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation.Algorithms](Jcd.BitManipulation.Algorithms.md 'Jcd.BitManipulation.Algorithms').[ByteAlgorithmsExtensions](Jcd.BitManipulation.Algorithms.ByteAlgorithmsExtensions.md 'Jcd.BitManipulation.Algorithms.ByteAlgorithmsExtensions')

## ByteAlgorithmsExtensions.GetSign(this byte) Method

Returns a value indicating the sign of the number.

```csharp
public static int GetSign(this byte number);
```

#### Parameters

<a name='Jcd.BitManipulation.Algorithms.ByteAlgorithmsExtensions.GetSign(thisbyte).number'></a>

`number` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')

The number to evaluate

#### Returns

[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')
-1 if < 0; 1 if > 0; 0 otherwise.