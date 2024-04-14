#### [Jcd.BitManipulation](index 'index')
### [Jcd.BitManipulation](Jcd.BitManipulation 'Jcd.BitManipulation').[ReadOnlySpanOfByteExtensions](Jcd.BitManipulation.ReadOnlySpanOfByteExtensions 'Jcd.BitManipulation.ReadOnlySpanOfByteExtensions')

## ReadOnlySpanOfByteExtensions.ToInt16(this ReadOnlySpan<byte>, Endian, ByteAlignment) Method

Converts bytes into a [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16'), discarding any excess data.

```csharp
public static short ToInt16(this System.ReadOnlySpan<byte> span, Jcd.BitManipulation.Endian endian=Jcd.BitManipulation.Endian.Little, Jcd.BitManipulation.ByteAlignment align=Jcd.BitManipulation.ByteAlignment.InferredFromEndian);
```
#### Parameters

<a name='Jcd.BitManipulation.ReadOnlySpanOfByteExtensions.ToInt16(thisSystem.ReadOnlySpan_byte_,Jcd.BitManipulation.Endian,Jcd.BitManipulation.ByteAlignment).span'></a>

`span` [System.ReadOnlySpan&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.ReadOnlySpan-1 'System.ReadOnlySpan`1')[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.ReadOnlySpan-1 'System.ReadOnlySpan`1')

the bytes to convert.

<a name='Jcd.BitManipulation.ReadOnlySpanOfByteExtensions.ToInt16(thisSystem.ReadOnlySpan_byte_,Jcd.BitManipulation.Endian,Jcd.BitManipulation.ByteAlignment).endian'></a>

`endian` [Endian](Jcd.BitManipulation.Endian 'Jcd.BitManipulation.Endian')

The endian for the bytes.

<a name='Jcd.BitManipulation.ReadOnlySpanOfByteExtensions.ToInt16(thisSystem.ReadOnlySpan_byte_,Jcd.BitManipulation.Endian,Jcd.BitManipulation.ByteAlignment).align'></a>

`align` [ByteAlignment](Jcd.BitManipulation.ByteAlignment 'Jcd.BitManipulation.ByteAlignment')

Indicates how to align partial data

#### Returns
[System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')
The converted [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')