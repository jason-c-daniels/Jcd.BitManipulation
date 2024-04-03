#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[Int16Extensions](Jcd.BitManipulation.Int16Extensions.md 'Jcd.BitManipulation.Int16Extensions')

## Int16Extensions.ReadBits(this short, int, int) Method

Reads the bits specified and returns the result shifted to the right by the offset.

```csharp
public static short ReadBits(this short value, int offset, int size);
```
#### Parameters

<a name='Jcd.BitManipulation.Int16Extensions.ReadBits(thisshort,int,int).value'></a>

`value` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The source of the bits to read.

<a name='Jcd.BitManipulation.Int16Extensions.ReadBits(thisshort,int,int).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The bit offset to start reading from.

<a name='Jcd.BitManipulation.Int16Extensions.ReadBits(thisshort,int,int).size'></a>

`size` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The total number of bits to extract.

#### Returns
[System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')
The value stored in the range of bits specified, right shifted by the offset..