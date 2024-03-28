### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[ReadOnlySpanOfByteExtensions](Jcd.BitManipulation.ReadOnlySpanOfByteExtensions.md 'Jcd.BitManipulation.ReadOnlySpanOfByteExtensions')

## ReadOnlySpanOfByteExtensions.ToInt64(this ReadOnlySpan<byte>, Endian) Method

Converts bytes into a [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64'),
discarding any excess data.

```csharp
public static long ToInt64(this System.ReadOnlySpan<byte> data, Jcd.BitManipulation.Endian endian=Jcd.BitManipulation.Endian.Little);
```
#### Parameters

<a name='Jcd.BitManipulation.ReadOnlySpanOfByteExtensions.ToInt64(thisSystem.ReadOnlySpan_byte_,Jcd.BitManipulation.Endian).data'></a>

`data` [System.ReadOnlySpan&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.ReadOnlySpan-1 'System.ReadOnlySpan`1')[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.ReadOnlySpan-1 'System.ReadOnlySpan`1')

the bytes to convert

<a name='Jcd.BitManipulation.ReadOnlySpanOfByteExtensions.ToInt64(thisSystem.ReadOnlySpan_byte_,Jcd.BitManipulation.Endian).endian'></a>

`endian` [Endian](Jcd.BitManipulation.Endian.md 'Jcd.BitManipulation.Endian')

The endian for the bytes.

#### Returns

[System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')
The converted [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')