### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[ReadOnlySpanOfByteExtensions](Jcd.BitManipulation.ReadOnlySpanOfByteExtensions.md 'Jcd.BitManipulation.ReadOnlySpanOfByteExtensions')

## ReadOnlySpanOfByteExtensions.ToUInt32(this ReadOnlySpan<byte>, Endian) Method

Converts bytes into a [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32'), discarding any excess data.

```csharp
public static uint ToUInt32(this System.ReadOnlySpan<byte> data, Jcd.BitManipulation.Endian endian=Jcd.BitManipulation.Endian.Little);
```
#### Parameters

<a name='Jcd.BitManipulation.ReadOnlySpanOfByteExtensions.ToUInt32(thisSystem.ReadOnlySpan_byte_,Jcd.BitManipulation.Endian).data'></a>

`data` [System.ReadOnlySpan&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.ReadOnlySpan-1 'System.ReadOnlySpan`1')[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.ReadOnlySpan-1 'System.ReadOnlySpan`1')

the bytes to convert

<a name='Jcd.BitManipulation.ReadOnlySpanOfByteExtensions.ToUInt32(thisSystem.ReadOnlySpan_byte_,Jcd.BitManipulation.Endian).endian'></a>

`endian` [Endian](Jcd.BitManipulation.Endian.md 'Jcd.BitManipulation.Endian')

The endian for the bytes.

#### Returns

[System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')
The converted [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')