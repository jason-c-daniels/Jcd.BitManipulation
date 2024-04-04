#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[UInt64Extensions](Jcd.BitManipulation.UInt64Extensions.md 'Jcd.BitManipulation.UInt64Extensions')

## UInt64Extensions.StoreBit(this ulong, bool, int) Method

Store a single bit at the specified offset and returns the modified value.

```csharp
public static ulong StoreBit(this ulong value, bool bit, int offset);
```

#### Parameters

<a name='Jcd.BitManipulation.UInt64Extensions.StoreBit(thisulong,bool,int).value'></a>

`value` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

The value to modify.

<a name='Jcd.BitManipulation.UInt64Extensions.StoreBit(thisulong,bool,int).bit'></a>

`bit` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

The value to store at the specified bit offset.

<a name='Jcd.BitManipulation.UInt64Extensions.StoreBit(thisulong,bool,int).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The offset of the bit to store.

#### Returns

[System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')
The modified value.