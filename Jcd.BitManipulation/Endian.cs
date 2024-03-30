namespace Jcd.BitManipulation;

/// <summary>
/// The order of the bytes in memory.
/// </summary>
public enum Endian
{
   /// <summary>
   /// Indicates that the least significant byte is at index 0.
   /// </summary>
   Little = 0

  ,

   /// <summary>
   /// Indicates that the most significant byte is at index 0.
   /// </summary>
   Big = 1
}