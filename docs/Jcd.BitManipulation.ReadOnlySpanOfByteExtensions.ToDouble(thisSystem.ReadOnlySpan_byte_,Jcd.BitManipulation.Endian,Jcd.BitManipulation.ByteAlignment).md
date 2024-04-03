#### [Jcd.BitManipulation](index.md 'index')
### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[ReadOnlySpanOfByteExtensions](Jcd.BitManipulation.ReadOnlySpanOfByteExtensions.md 'Jcd.BitManipulation.ReadOnlySpanOfByteExtensions')

## ReadOnlySpanOfByteExtensions.ToDouble(this ReadOnlySpan<byte>, Endian, ByteAlignment) Method

Converts bytes into a double, discarding any excess data.

```csharp
public static double ToDouble(this System.ReadOnlySpan<byte> data, Jcd.BitManipulation.Endian endian=Jcd.BitManipulation.Endian.Little, Jcd.BitManipulation.ByteAlignment align=Jcd.BitManipulation.ByteAlignment.InferredFromEndian);
```
#### Parameters

<a name='Jcd.BitManipulation.ReadOnlySpanOfByteExtensions.ToDouble(thisSystem.ReadOnlySpan_byte_,Jcd.BitManipulation.Endian,Jcd.BitManipulation.ByteAlignment).data'></a>

`data` [System.ReadOnlySpan&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.ReadOnlySpan-1 'System.ReadOnlySpan`1')[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.ReadOnlySpan-1 'System.ReadOnlySpan`1')

the bytes to convert.

<a name='Jcd.BitManipulation.ReadOnlySpanOfByteExtensions.ToDouble(thisSystem.ReadOnlySpan_byte_,Jcd.BitManipulation.Endian,Jcd.BitManipulation.ByteAlignment).endian'></a>

`endian` [Endian](Jcd.BitManipulation.Endian.md 'Jcd.BitManipulation.Endian')

A setting indicating the endianness of the source data. The default is Endian.Little.

<a name='Jcd.BitManipulation.ReadOnlySpanOfByteExtensions.ToDouble(thisSystem.ReadOnlySpan_byte_,Jcd.BitManipulation.Endian,Jcd.BitManipulation.ByteAlignment).align'></a>

`align` [ByteAlignment](Jcd.BitManipulation.ByteAlignment.md 'Jcd.BitManipulation.ByteAlignment')

Indicates how to align partial data

#### Returns
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')
The converted ulong