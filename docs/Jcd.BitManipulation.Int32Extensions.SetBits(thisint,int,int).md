### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[Int32Extensions](Jcd.BitManipulation.Int32Extensions.md 'Jcd.BitManipulation.Int32Extensions')

## Int32Extensions.SetBits(this int, int, int) Method

Sets all specified bits to "on"

```csharp
public static int SetBits(this int value, int offset=0, int size=32);
```
#### Parameters

<a name='Jcd.BitManipulation.Int32Extensions.SetBits(thisint,int,int).value'></a>

`value` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The value to be modified.

<a name='Jcd.BitManipulation.Int32Extensions.SetBits(thisint,int,int).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The bit location to store the value.

<a name='Jcd.BitManipulation.Int32Extensions.SetBits(thisint,int,int).size'></a>

`size` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The number of bits to set on.

#### Returns

[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')
The modified value.