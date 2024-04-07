#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[Int32Extensions](Jcd.BitManipulation.Int32Extensions.md 'Jcd.BitManipulation.Int32Extensions')

## Int32Extensions.ReadBits(this int, int, int) Method

Reads the bits specified and returns the result shifted to the right by the offset.

```csharp
public static int ReadBits(this int number, int offset, int size);
```

#### Parameters

<a name='Jcd.BitManipulation.Int32Extensions.ReadBits(thisint,int,int).number'></a>

`number` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The source of the bits to read.

<a name='Jcd.BitManipulation.Int32Extensions.ReadBits(thisint,int,int).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The bit offset to start reading from.

<a name='Jcd.BitManipulation.Int32Extensions.ReadBits(thisint,int,int).size'></a>

`size` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The total number of bits to extract.

#### Returns

[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')
The value stored in the range of bits specified, right shifted by the offset..