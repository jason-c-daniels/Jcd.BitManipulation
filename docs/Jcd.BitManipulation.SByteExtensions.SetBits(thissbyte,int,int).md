#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[SByteExtensions](Jcd.BitManipulation.SByteExtensions.md 'Jcd.BitManipulation.SByteExtensions')

## SByteExtensions.SetBits(this sbyte, int, int) Method

Sets all specified bits to "on" and returns the modified value.

```csharp
public static sbyte SetBits(this sbyte value, int offset=0, int size=8);
```
#### Parameters

<a name='Jcd.BitManipulation.SByteExtensions.SetBits(thissbyte,int,int).value'></a>

`value` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

The value to modify.

<a name='Jcd.BitManipulation.SByteExtensions.SetBits(thissbyte,int,int).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The bit location to store the value.

<a name='Jcd.BitManipulation.SByteExtensions.SetBits(thissbyte,int,int).size'></a>

`size` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The number of bits to set on.

#### Returns
[System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')
The modified value.