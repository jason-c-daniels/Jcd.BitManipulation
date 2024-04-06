#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[Int64Extensions](Jcd.BitManipulation.Int64Extensions.md 'Jcd.BitManipulation.Int64Extensions')

## Int64Extensions.StoreBit(this long, bool, int) Method

Store a single bit at the specified offset and returns the modified value.

```csharp
public static long StoreBit(this long value, bool bit, int offset);
```

#### Parameters

<a name='Jcd.BitManipulation.Int64Extensions.StoreBit(thislong,bool,int).value'></a>

`value` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The value to modify.

<a name='Jcd.BitManipulation.Int64Extensions.StoreBit(thislong,bool,int).bit'></a>

`bit` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

The value to store at the specified bit offset.

<a name='Jcd.BitManipulation.Int64Extensions.StoreBit(thislong,bool,int).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The offset of the bit to store.

#### Returns

[System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')
The modified value.