#### [Jcd.BitManipulation](index 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation 'Jcd.BitManipulation').[Int32Extensions](Jcd.BitManipulation.Int32Extensions 'Jcd.BitManipulation.Int32Extensions')

## Int32Extensions.StoreBits(this int, int, int, int) Method

Stores a range of bits to the value, from a source value, and returns the modified value. The source value is left shifted by the offset before storing.

```csharp
public static int StoreBits(this int number, int source, int offset, int size);
```

#### Parameters

<a name='Jcd.BitManipulation.Int32Extensions.StoreBits(thisint,int,int,int).number'></a>

`number` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The value to modify.

<a name='Jcd.BitManipulation.Int32Extensions.StoreBits(thisint,int,int,int).source'></a>

`source` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The value to be stored at the bit location.

<a name='Jcd.BitManipulation.Int32Extensions.StoreBits(thisint,int,int,int).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The bit location to store the value.

<a name='Jcd.BitManipulation.Int32Extensions.StoreBits(thisint,int,int,int).size'></a>

`size` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The bit size of the value.

#### Returns

[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')
The modified value.