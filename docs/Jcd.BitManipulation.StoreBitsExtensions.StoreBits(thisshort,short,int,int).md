### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[StoreBitsExtensions](Jcd.BitManipulation.StoreBitsExtensions.md 'Jcd.BitManipulation.StoreBitsExtensions')

## StoreBitsExtensions.StoreBits(this short, short, int, int) Method

Stores a value at the specified bit location within the variable.

```csharp
public static void StoreBits(this ref short self, short value, int offset, int size);
```
#### Parameters

<a name='Jcd.BitManipulation.StoreBitsExtensions.StoreBits(thisshort,short,int,int).self'></a>

`self` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The value to be modified.

<a name='Jcd.BitManipulation.StoreBitsExtensions.StoreBits(thisshort,short,int,int).value'></a>

`value` [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/System.Int16 'System.Int16')

The value to be stored at the bit location.

<a name='Jcd.BitManipulation.StoreBitsExtensions.StoreBits(thisshort,short,int,int).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The bit location to store the value.

<a name='Jcd.BitManipulation.StoreBitsExtensions.StoreBits(thisshort,short,int,int).size'></a>

`size` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The bit size of the value.