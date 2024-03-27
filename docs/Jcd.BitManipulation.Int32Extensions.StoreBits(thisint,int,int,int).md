### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[Int32Extensions](Jcd.BitManipulation.Int32Extensions.md 'Jcd.BitManipulation.Int32Extensions')

## Int32Extensions.StoreBits(this int, int, int, int) Method

Stores a value at the specified bit location within the variable.

```csharp
public static int StoreBits(this int value, int source, int offset, int size);
```
#### Parameters

<a name='Jcd.BitManipulation.Int32Extensions.StoreBits(thisint,int,int,int).value'></a>

`value` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The value to be modified.

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