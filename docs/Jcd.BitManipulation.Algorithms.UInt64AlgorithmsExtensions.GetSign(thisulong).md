#### [Jcd.BitManipulation](index.md 'index')

### [Jcd.BitManipulation.Algorithms](Jcd.BitManipulation.Algorithms.md 'Jcd.BitManipulation.Algorithms').[UInt64AlgorithmsExtensions](Jcd.BitManipulation.Algorithms.UInt64AlgorithmsExtensions.md 'Jcd.BitManipulation.Algorithms.UInt64AlgorithmsExtensions')

## UInt64AlgorithmsExtensions.GetSign(this ulong) Method

Returns a value indicating the sign of the number.

```csharp
public static int GetSign(this ulong number);
```

#### Parameters

<a name='Jcd.BitManipulation.Algorithms.UInt64AlgorithmsExtensions.GetSign(thisulong).number'></a>

`number` [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64 'System.UInt64')

The number to evaluate

#### Returns

[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')
-1 if < 0; 1 if > 0; 0 otherwise.