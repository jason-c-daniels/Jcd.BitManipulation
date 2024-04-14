#### [Jcd.BitManipulation](index 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation 'Jcd.BitManipulation').[ReadOnlySpanOfByteExtensions](Jcd.BitManipulation.ReadOnlySpanOfByteExtensions 'Jcd.BitManipulation.ReadOnlySpanOfByteExtensions')

## ReadOnlySpanOfByteExtensions.ToUInt32(this ReadOnlySpan<byte>, Endian, ByteAlignment) Method

Converts bytes into a [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32'), discarding any excess data.

```csharp
public static uint ToUInt32(this System.ReadOnlySpan<byte> span, Jcd.BitManipulation.Endian endian=Jcd.BitManipulation.Endian.Little, Jcd.BitManipulation.ByteAlignment align=Jcd.BitManipulation.ByteAlignment.InferredFromEndian);
```

#### Parameters

<a name='Jcd.BitManipulation.ReadOnlySpanOfByteExtensions.ToUInt32(thisSystem.ReadOnlySpan_byte_,Jcd.BitManipulation.Endian,Jcd.BitManipulation.ByteAlignment).span'></a>

`span` [System.ReadOnlySpan&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.ReadOnlySpan-1 'System.ReadOnlySpan`1')[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.ReadOnlySpan-1 'System.ReadOnlySpan`1')

the bytes to convert.

<a name='Jcd.BitManipulation.ReadOnlySpanOfByteExtensions.ToUInt32(thisSystem.ReadOnlySpan_byte_,Jcd.BitManipulation.Endian,Jcd.BitManipulation.ByteAlignment).endian'></a>

`endian` [Endian](Jcd.BitManipulation.Endian 'Jcd.BitManipulation.Endian')

The endian for the bytes.

<a name='Jcd.BitManipulation.ReadOnlySpanOfByteExtensions.ToUInt32(thisSystem.ReadOnlySpan_byte_,Jcd.BitManipulation.Endian,Jcd.BitManipulation.ByteAlignment).align'></a>

`align` [ByteAlignment](Jcd.BitManipulation.ByteAlignment 'Jcd.BitManipulation.ByteAlignment')

Indicates how to align partial data

#### Returns

[System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')
The converted [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')