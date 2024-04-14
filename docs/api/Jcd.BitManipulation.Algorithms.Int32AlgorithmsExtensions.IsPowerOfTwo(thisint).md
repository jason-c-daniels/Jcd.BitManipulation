#### [Jcd.BitManipulation](index 'index')
### [Jcd.BitManipulation.Algorithms](Jcd.BitManipulation.Algorithms 'Jcd.BitManipulation.Algorithms').[Int32AlgorithmsExtensions](Jcd.BitManipulation.Algorithms.Int32AlgorithmsExtensions 'Jcd.BitManipulation.Algorithms.Int32AlgorithmsExtensions')

## Int32AlgorithmsExtensions.IsPowerOfTwo(this int) Method

Determines if the number is a power of two.

```csharp
public static bool IsPowerOfTwo(this int number);
```
#### Parameters

<a name='Jcd.BitManipulation.Algorithms.Int32AlgorithmsExtensions.IsPowerOfTwo(thisint).number'></a>

`number` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The number to evaluate.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')
true if number == 2^n; where n is an integer.

### Example

```csharp
int v = 1;
if (v.IsPowerOfTwo()) Console.WriteLine($"{v} is a power of two!"); // outputs: 1 is a power of two!

v = 2;
if (v.IsPowerOfTwo()) Console.WriteLine($"{v} is a power of two!"); // outputs: 2 is a power of two!

v = 3;
if (v.IsPowerOfTwo()) Console.WriteLine($"{v} is a power of two!"); // does not output anything.

v = 4;
if (v.IsPowerOfTwo()) Console.WriteLine($"{v} is a power of two!"); // outputs: 4 is a power of two!
```