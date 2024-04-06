#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[UInt32Extensions](Jcd.BitManipulation.UInt32Extensions.md 'Jcd.BitManipulation.UInt32Extensions')

## UInt32Extensions.SetBits(this uint, int, int) Method

Sets all specified bits to "on" and returns the modified value.

```csharp
public static uint SetBits(this uint number, int offset=0, int size=32);
```

#### Parameters

<a name='Jcd.BitManipulation.UInt32Extensions.SetBits(thisuint,int,int).number'></a>

`number` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The value to modify.

<a name='Jcd.BitManipulation.UInt32Extensions.SetBits(thisuint,int,int).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The bit location to store the value.

<a name='Jcd.BitManipulation.UInt32Extensions.SetBits(thisuint,int,int).size'></a>

`size` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The number of bits to set on.

#### Returns

[System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')
The modified value.