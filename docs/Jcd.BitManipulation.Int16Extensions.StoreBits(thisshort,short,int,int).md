### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[Int16Extensions](Jcd.BitManipulation.Int16Extensions.md 'Jcd.BitManipulation.Int16Extensions')

## Int16Extensions.StoreBits(this short, short, int, int) Method

Stores a value at the specified bit location within the variable.

```csharp
public static short StoreBits(this short value, short source, int offset, int size);
```
#### Parameters

<a name='Jcd.BitManipulation.Int16Extensions.StoreBits(thisshort,short,int,int).value'></a>

`value` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The value to be modified.

<a name='Jcd.BitManipulation.Int16Extensions.StoreBits(thisshort,short,int,int).source'></a>

`source` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The value to be stored at the bit location.

<a name='Jcd.BitManipulation.Int16Extensions.StoreBits(thisshort,short,int,int).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The bit location to store the value.

<a name='Jcd.BitManipulation.Int16Extensions.StoreBits(thisshort,short,int,int).size'></a>

`size` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The bit size of the value.

#### Returns

[System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')
The modified value.