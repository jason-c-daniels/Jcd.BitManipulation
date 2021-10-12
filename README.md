# Jcd.BitManipulation
A .Net Standard 2.1 library adding syntactic sugar to your bit manipulation experience. 

## Examples

```csharp
ushort data=0b0000000000000000;
// turn on all the bits
data.SetBits(0,16);  // value is now 0b1111111111111111
// this is the equivalent as above
data.SetBits();

// Clear the middle 4 bits.
data.ClearBits(4,8); // value is now 0b1111000000001111

// Toggle all the bits.
data.ToggleBits(); // value is now 0b0000111111110000

// read the upper byte 
var upperByte = (byte) data.ReadBits(8,8); // upperByte is now 0b00001111

// write 0b1111 into the upper nybble
upperByte.StoreBits(0b00001111,4,4); // upperByte is now 0b11111111
```


## Build, Code Stats and Nuget
[![GitHub](https://img.shields.io/github/license/jason-c-daniels/Jcd.BitManipulation)](https://github.com/jason-c-daniels/Jcd.BitManipulation/blob/main/LICENSE) 
[![Build status](https://ci.appveyor.com/api/projects/status/98xuytl8nl7rns7m?svg=true)](https://ci.appveyor.com/project/jason-c-daniels/jcd-bitmanipulation)
[![CodeFactor Grade](https://img.shields.io/codefactor/grade/github/jason-c-daniels/Jcd.BitManipulation)](https://www.codefactor.io/repository/github/jason-c-daniels/jcd.bitmanipulation)

[![MyGet](https://img.shields.io/myget/jason-c-daniels/v/Jcd.BitManipulation?logo=nuget)](https://www.myget.org/feed/jason-c-daniels/package/nuget/Jcd.BitManipulation)
[![Nuget](https://img.shields.io/nuget/v/Jcd.BitManipulation?logo=nuget)](https://www.nuget.org/packages/Jcd.BitManipulation)

## API Documentation
[![API Docs](https://img.shields.io/badge/Read-The%20API%20Documentation-blue?style=for-the-badge)](https://github.com/jason-c-daniels/Jcd.BitManipulation/blob/main/docs/Jcd_BitManipulation.md)
