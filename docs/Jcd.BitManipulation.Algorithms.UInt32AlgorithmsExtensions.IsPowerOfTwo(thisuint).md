#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation.Algorithms](Jcd.BitManipulation.Algorithms 'Jcd.BitManipulation.Algorithms').[UInt32AlgorithmsExtensions](Jcd.BitManipulation.Algorithms.UInt32AlgorithmsExtensions 'Jcd.BitManipulation.Algorithms.UInt32AlgorithmsExtensions')

## UInt32AlgorithmsExtensions.IsPowerOfTwo(this uint) Method

Determines if the number is a power of two.

```csharp
public static bool IsPowerOfTwo(this uint number);
```

#### Parameters

<a name='Jcd.BitManipulation.Algorithms.UInt32AlgorithmsExtensions.IsPowerOfTwo(thisuint).number'></a>

`number` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

The number to evaluate.

#### Returns

[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')
true if number == 2^n; where n is an integer.

### Example

```csharp
uint v = 1;
if (v.IsPowerOfTwo()) Console.WriteLine($"{v} is a power of two!"); // outputs: 1 is a power of two!

v = 2;
if (v.IsPowerOfTwo()) Console.WriteLine($"{v} is a power of two!"); // outputs: 2 is a power of two!

v = 3;
if (v.IsPowerOfTwo()) Console.WriteLine($"{v} is a power of two!"); // does not output anything.

v = 4;
if (v.IsPowerOfTwo()) Console.WriteLine($"{v} is a power of two!"); // outputs: 4 is a power of two!
```