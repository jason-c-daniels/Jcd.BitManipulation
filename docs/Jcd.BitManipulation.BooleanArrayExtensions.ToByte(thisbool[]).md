#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[BooleanArrayExtensions](Jcd.BitManipulation.BooleanArrayExtensions.md 'Jcd.BitManipulation.BooleanArrayExtensions')

## BooleanArrayExtensions.ToByte(this bool[]) Method

Converts an array of bools into a [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte'),
discarding any excess bits.

```csharp
public static byte ToByte(this bool[] bits);
```
#### Parameters

<a name='Jcd.BitManipulation.BooleanArrayExtensions.ToByte(thisbool[]).bits'></a>

`bits` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

the array of bools to convert, Least Significant Bit at index 0

#### Returns

[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')
The converted [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')