#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[Int64Extensions](Jcd.BitManipulation.Int64Extensions.md 'Jcd.BitManipulation.Int64Extensions')

## Int64Extensions.ToggleBits(this long, int, int) Method

Toggles the specified range of bits and returns the modified value.

```csharp
public static long ToggleBits(this long value, int offset=0, int size=64);
```
#### Parameters

<a name='Jcd.BitManipulation.Int64Extensions.ToggleBits(thislong,int,int).value'></a>

`value` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The value to modify.

<a name='Jcd.BitManipulation.Int64Extensions.ToggleBits(thislong,int,int).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The offset of the bits to toggle.

<a name='Jcd.BitManipulation.Int64Extensions.ToggleBits(thislong,int,int).size'></a>

`size` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The number of bits to toggle.

#### Returns
[System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')
The modified value.