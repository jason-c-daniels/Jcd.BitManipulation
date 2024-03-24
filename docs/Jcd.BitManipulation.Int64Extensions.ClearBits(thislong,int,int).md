### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[Int64Extensions](Jcd.BitManipulation.Int64Extensions.md 'Jcd.BitManipulation.Int64Extensions')

## Int64Extensions.ClearBits(this long, int, int) Method

Sets all specified bits to "off" and returns the modified value.

```csharp
public static long ClearBits(this long value, int offset=0, int size=64);
```
#### Parameters

<a name='Jcd.BitManipulation.Int64Extensions.ClearBits(thislong,int,int).value'></a>

`value` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The value to be modified.

<a name='Jcd.BitManipulation.Int64Extensions.ClearBits(thislong,int,int).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The offset of where to begin clearing bits.

<a name='Jcd.BitManipulation.Int64Extensions.ClearBits(thislong,int,int).size'></a>

`size` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The number of bits to clear.

#### Returns

[System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')
The modified value.