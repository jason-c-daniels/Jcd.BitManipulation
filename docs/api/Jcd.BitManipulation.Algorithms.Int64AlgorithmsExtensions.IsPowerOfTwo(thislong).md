#### [Jcd.BitManipulation](index 'index')
### [Jcd.BitManipulation.Algorithms](Jcd.BitManipulation.Algorithms 'Jcd.BitManipulation.Algorithms').[Int64AlgorithmsExtensions](Jcd.BitManipulation.Algorithms.Int64AlgorithmsExtensions 'Jcd.BitManipulation.Algorithms.Int64AlgorithmsExtensions')

## Int64AlgorithmsExtensions.IsPowerOfTwo(this long) Method

Determines if the number is a power of two.

```csharp
public static bool IsPowerOfTwo(this long number);
```
#### Parameters

<a name='Jcd.BitManipulation.Algorithms.Int64AlgorithmsExtensions.IsPowerOfTwo(thislong).number'></a>

`number` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

The number to evaluate.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')
true if number == 2^n; where n is an integer.

### Example

```csharp
long v = 1;
if (v.IsPowerOfTwo()) Console.WriteLine($"{v} is a power of two!"); // outputs: 1 is a power of two!

v = 2;
if (v.IsPowerOfTwo()) Console.WriteLine($"{v} is a power of two!"); // outputs: 2 is a power of two!

v = 3;
if (v.IsPowerOfTwo()) Console.WriteLine($"{v} is a power of two!"); // does not output anything.

v = 4;
if (v.IsPowerOfTwo()) Console.WriteLine($"{v} is a power of two!"); // outputs: 4 is a power of two!
```