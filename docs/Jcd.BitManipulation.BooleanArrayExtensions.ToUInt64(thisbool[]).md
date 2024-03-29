### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[BooleanArrayExtensions](Jcd.BitManipulation.BooleanArrayExtensions.md 'Jcd.BitManipulation.BooleanArrayExtensions')

## BooleanArrayExtensions.ToUInt64(this bool[]) Method

Converts an array of bools into a [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64'), discarding any excess bits.

```csharp
public static ulong ToUInt64(this bool[] bits);
```
#### Parameters

<a name='Jcd.BitManipulation.BooleanArrayExtensions.ToUInt64(thisbool[]).bits'></a>

`bits` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

the array of bools to convert. Least Significant Bit at index 0

#### Returns
[System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')
The converted [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')