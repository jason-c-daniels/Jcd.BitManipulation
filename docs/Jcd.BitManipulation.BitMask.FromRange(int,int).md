### [Jcd.BitManipulation](Jcd.BitManipulation.md 'Jcd.BitManipulation').[BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask')

## BitMask.FromRange(int, int) Method

Create a 64 bit [BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask') with a range of bits set.

```csharp
public static Jcd.BitManipulation.BitMask FromRange(int offset=0, int size=64);
```
#### Parameters

<a name='Jcd.BitManipulation.BitMask.FromRange(int,int).offset'></a>

`offset` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

the lowest bit to start turning on

<a name='Jcd.BitManipulation.BitMask.FromRange(int,int).size'></a>

`size` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

the number of bits to set to 1

#### Returns

[BitMask](Jcd.BitManipulation.BitMask.md 'Jcd.BitManipulation.BitMask')
the shifted mask