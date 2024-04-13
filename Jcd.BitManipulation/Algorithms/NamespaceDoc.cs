// ReSharper disable UnusedType.Global
// ReSharper disable CommentTypo

namespace Jcd.BitManipulation.Algorithms;
#pragma warning disable S2094

/// <summary>
/// Provides various software implementations of common bit manipulation
/// algorithms, for C# supported types.
/// </summary>
/// <example>
/// <code>
/// var ul = ulong.MaxValue;
///
/// var bitCount = ul.CountBitsSet(); // bitCount = 64;
/// bitCount = ul.PopCount(); // also 64; this alias is provided for those who like the assembly language term.
///
/// var hbs = (ul &gt;&gt; 1).GetHighestBitSet(); // 63
///
/// var lbs = (ul &lt;&lt; 1).GetLowestBitSet(); // 1
///
/// var np2 = 63.RoundUpToPowerOfTwo(); // 64
/// np2 = 64.RoundUpToPowerOfTwo(); // also 64.
///
/// var ip2 = 63.IsPowerOfTwo(); // false
/// ip2 = 64.IsPowerOfTwo(); // true
/// ip2 = (-64).IsPowerOfTwo(); // false
///
/// var ip = 63.IsPositive(); // true
/// ip = (-1).IsPositive(); // false
///
/// var ie = 63.IsEven(); // false
/// ie = 64.IsEven(); // true
///
/// </code>
/// </example>
public class NamespaceDoc;