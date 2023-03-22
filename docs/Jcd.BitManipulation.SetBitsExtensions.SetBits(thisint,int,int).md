### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[SetBitsExtensions](Jcd.BitManipulation.SetBitsExtensions.md 'Jcd.BitManipulation.SetBitsExtensions')

## SetBitsExtensions.SetBits(this int, int, int) Method

Sets all specified bits to "on" in a variable

```csharp
public static void SetBits(this ref int self, int offset=0, int size=32);
```
#### Parameters

<a name='Jcd.BitManipulation.SetBitsExtensions.SetBits(thisint,int,int).self'></a>

`self` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The value to be modified.

<a name='Jcd.BitManipulation.SetBitsExtensions.SetBits(thisint,int,int).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The bit location to store the value.

<a name='Jcd.BitManipulation.SetBitsExtensions.SetBits(thisint,int,int).size'></a>

`size` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The number of bits to set on.