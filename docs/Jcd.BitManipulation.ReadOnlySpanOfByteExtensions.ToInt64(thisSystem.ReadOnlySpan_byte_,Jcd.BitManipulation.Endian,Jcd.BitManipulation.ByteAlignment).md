#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[ReadOnlySpanOfByteExtensions](Jcd.BitManipulation.ReadOnlySpanOfByteExtensions.md 'Jcd.BitManipulation.ReadOnlySpanOfByteExtensions')

## ReadOnlySpanOfByteExtensions.ToInt64(this ReadOnlySpan<byte>, Endian, ByteAlignment) Method

Converts bytes into a [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64'), discarding any excess data.

```csharp
public static long ToInt64(this System.ReadOnlySpan<byte> span, Jcd.BitManipulation.Endian endian=Jcd.BitManipulation.Endian.Little, Jcd.BitManipulation.ByteAlignment align=Jcd.BitManipulation.ByteAlignment.InferredFromEndian);
```

#### Parameters

<a name='Jcd.BitManipulation.ReadOnlySpanOfByteExtensions.ToInt64(thisSystem.ReadOnlySpan_byte_,Jcd.BitManipulation.Endian,Jcd.BitManipulation.ByteAlignment).span'></a>

`span` [System.ReadOnlySpan&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.ReadOnlySpan-1 'System.ReadOnlySpan`1')[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.ReadOnlySpan-1 'System.ReadOnlySpan`1')

the bytes to convert.

<a name='Jcd.BitManipulation.ReadOnlySpanOfByteExtensions.ToInt64(thisSystem.ReadOnlySpan_byte_,Jcd.BitManipulation.Endian,Jcd.BitManipulation.ByteAlignment).endian'></a>

`endian` [Endian](Jcd.BitManipulation.Endian.md 'Jcd.BitManipulation.Endian')

The endian for the bytes.

<a name='Jcd.BitManipulation.ReadOnlySpanOfByteExtensions.ToInt64(thisSystem.ReadOnlySpan_byte_,Jcd.BitManipulation.Endian,Jcd.BitManipulation.ByteAlignment).align'></a>

`align` [ByteAlignment](Jcd.BitManipulation.ByteAlignment.md 'Jcd.BitManipulation.ByteAlignment')

Indicates how to align partial data

#### Returns

[System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')
The converted [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')