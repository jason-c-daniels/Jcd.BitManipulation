#### [Jcd.BitManipulation](index 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation 'Jcd.BitManipulation').[BooleanArrayExtensions](Jcd.BitManipulation.BooleanArrayExtensions 'Jcd.BitManipulation.BooleanArrayExtensions')

## BooleanArrayExtensions.ToUInt32(this bool[]) Method

Converts an array of bools into a [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32'), discarding any excess bits.

```csharp
public static uint ToUInt32(this bool[] bits);
```

#### Parameters

<a name='Jcd.BitManipulation.BooleanArrayExtensions.ToUInt32(thisbool[]).bits'></a>

`bits` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

The array of [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean') values to convert. The Least Significant Bit is at index 0

#### Returns

[System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')
The converted [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')