### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[StoreBitsExtensions](Jcd.BitManipulation.StoreBitsExtensions.md 'Jcd.BitManipulation.StoreBitsExtensions')

## StoreBitsExtensions.StoreBits(this ushort, ushort, int, int) Method

Stores a value at the specified bit location within the variable.

```csharp
public static void StoreBits(this ref ushort self, ushort value, int offset, int size);
```
#### Parameters

<a name='Jcd.BitManipulation.StoreBitsExtensions.StoreBits(thisushort,ushort,int,int).self'></a>

`self` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The value to be modified.

<a name='Jcd.BitManipulation.StoreBitsExtensions.StoreBits(thisushort,ushort,int,int).value'></a>

`value` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

The value to be stored at the bit location.

<a name='Jcd.BitManipulation.StoreBitsExtensions.StoreBits(thisushort,ushort,int,int).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The bit location to store the value.

<a name='Jcd.BitManipulation.StoreBitsExtensions.StoreBits(thisushort,ushort,int,int).size'></a>

`size` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The bit size of the value.