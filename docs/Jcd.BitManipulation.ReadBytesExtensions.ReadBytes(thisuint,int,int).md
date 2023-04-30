#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[ReadBytesExtensions](Jcd.BitManipulation.ReadBytesExtensions.md 'Jcd.BitManipulation.ReadBytesExtensions')

## ReadBytesExtensions.ReadBytes(this uint, int, int) Method

Reads a set of bytes starting at the specified byte location within the value.  
The offsets are in LSB, this means the array will be little endian.

```csharp
public static byte[] ReadBytes(this uint value, int offset, int size);
```
#### Parameters

<a name='Jcd.BitManipulation.ReadBytesExtensions.ReadBytes(thisuint,int,int).value'></a>

`value` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The value to be read.

<a name='Jcd.BitManipulation.ReadBytesExtensions.ReadBytes(thisuint,int,int).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The byte location to store the value.

<a name='Jcd.BitManipulation.ReadBytesExtensions.ReadBytes(thisuint,int,int).size'></a>

`size` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The byte size of the value.

#### Returns
[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')