#### [Jcd.BitManipulation](index 'index')
### [Jcd.BitManipulation](Jcd.BitManipulation 'Jcd.BitManipulation').[SByteExtensions](Jcd.BitManipulation.SByteExtensions 'Jcd.BitManipulation.SByteExtensions')

## SByteExtensions.StoreBits(this sbyte, sbyte, int, int) Method

Stores a range of bits to the value, from a source value, and returns the modified value.

```csharp
public static sbyte StoreBits(this sbyte number, sbyte source, int offset, int size);
```
#### Parameters

<a name='Jcd.BitManipulation.SByteExtensions.StoreBits(thissbyte,sbyte,int,int).number'></a>

`number` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

The value to modify.

<a name='Jcd.BitManipulation.SByteExtensions.StoreBits(thissbyte,sbyte,int,int).source'></a>

`source` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')

The value to be stored at the bit location.

<a name='Jcd.BitManipulation.SByteExtensions.StoreBits(thissbyte,sbyte,int,int).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The bit location to store the value.

<a name='Jcd.BitManipulation.SByteExtensions.StoreBits(thissbyte,sbyte,int,int).size'></a>

`size` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The bit size of the value.

#### Returns
[System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')
The modified value.