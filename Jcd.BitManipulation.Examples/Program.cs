#region

// ReSharper disable NotAccessedVariable
// ReSharper disable IdentifierTypo
// ReSharper disable CommentTypo
// ReSharper disable RedundantArgumentDefaultValue
// ReSharper disable HeapView.ObjectAllocation
// ReSharper disable RedundantAssignment
// ReSharper disable HeapView.BoxingAllocation
// ReSharper disable ConvertToConstant.Local
// ReSharper disable UnusedMember.Local
// ReSharper disable HeapView.ObjectAllocation.Evident
// ReSharper disable UnusedVariable

#pragma warning disable S1481
#pragma warning disable S1854
#pragma warning disable S125
#pragma warning disable S3254
#pragma warning disable S4055
#pragma warning disable S4056
#pragma warning disable S109
#pragma warning disable S1192

#endregion

namespace Jcd.BitManipulation.Examples;

internal static class Program
{
   public static void Main()
   {

      ReadMeExamples.Rotate_Examples();
      ReadMeExamples.BitIndexer_Example();
      ReadMeExamples.ByteIndexer_Example();
      ReadMeExamples.ReadMe_BitManipulation_Byte_Example();
      ReadMeExamples.ReadMe_BitManipulation_SByte_Example();
      ReadMeExamples.ReadMe_BitManipulation_UInt16_Example();
      ReadMeExamples.ReadMe_BitManipulation_Int16_Example();
      ReadMeExamples.ReadMe_BitManipulation_UInt32_Example();
      ReadMeExamples.ReadMe_BitManipulation_Int32_Example();
      ReadMeExamples.ReadMe_BitManipulation_UInt64_Example();
      ReadMeExamples.ReadMe_BitManipulation_Int64_Example();
      ReadMeExamples.Alignment_ToUInt32_Example();

      #if DEBUG
      const long iterations = 1_000_000;
      #else
      const long iterations = 100_000_000;
      #endif

      // warm things up
      PerfTiming.TimeBitOperationsRotateRightOnUInt64(iterations                        / 10, false);
      PerfTiming.TimeRotateRightOnUInt64(iterations                                     / 10, false);
      PerfTiming.TimeBitOperationsRotateLeftOnUInt64(iterations                         / 10, false);
      PerfTiming.TimeRotateLeftOnUInt64(iterations                                      / 10, false);
      PerfTiming.TimeStoreByteAndReadByteCalls(iterations                               / 10, false);
      PerfTiming.TimeStoreByteAndReadByteFromIndexerCalls(iterations                    / 10, false);
      PerfTiming.TimeLittleEndianByteIndexerCastOperations(iterations                   / 10, false);
      PerfTiming.TimeBigEndianByteIndexerCastOperations(iterations                      / 10, false);
      PerfTiming.TimeByteArrayModificationInALoopSubtractFromOtherResults(iterations    / 10, false);
      PerfTiming.TimeStore8BytesToLongCalls(iterations                                  / 10, false);
      PerfTiming.TimeStore4BytesToLongCalls(iterations                                  / 10, false);
      PerfTiming.TimeStore2BytesToLongCalls(iterations                                  / 10, false);
      PerfTiming.TimeStore8BytesToIndexerCalls(iterations                               / 10, false);
      PerfTiming.TimeStore4BytesToIndexerCalls(iterations                               / 10, false);
      PerfTiming.TimeStore2BytesToIndexerCalls(iterations                               / 10, false);
      PerfTiming.TimeByteArrayToUInt64_BitConverter_NativeEndian(iterations             / 10, false);
      PerfTiming.TimeByteArrayToUInt64_BitConverter_ReversedFromNativeEndian(iterations / 10, false);
      PerfTiming.TimeByteArrayToUInt64LittleEndianByteIndexer(iterations                / 10, false);
      PerfTiming.TimeByteArrayToUInt64BigEndianByteIndexer(iterations                   / 10, false);
      PerfTiming.TimeReadOnlySpanOfByteToUInt64LittleEndian(iterations                  / 10, false);
      PerfTiming.TimeReadOnlySpanOfByteToUInt64BigEndian(iterations                     / 10, false);

      // now run and report.
      PerfTiming.ReportSystemInfo();
      PerfTiming.TimeBitOperationsRotateRightOnUInt64(iterations);
      PerfTiming.TimeRotateRightOnUInt64(iterations);
      PerfTiming.TimeBitOperationsRotateLeftOnUInt64(iterations);
      PerfTiming.TimeRotateLeftOnUInt64(iterations);
      PerfTiming.TimeBitManipulations(iterations);
      PerfTiming.TimeStoreByteAndReadByteCalls(iterations);
      PerfTiming.TimeStoreByteAndReadByteFromIndexerCalls(iterations);
      PerfTiming.TimeLittleEndianByteIndexerCastOperations(iterations);
      PerfTiming.TimeBigEndianByteIndexerCastOperations(iterations);
      PerfTiming.TimeByteArrayModificationInALoopSubtractFromOtherResults(iterations / 10);
      PerfTiming.TimeStore8BytesToLongCalls(iterations);
      PerfTiming.TimeStore4BytesToLongCalls(iterations);
      PerfTiming.TimeStore2BytesToLongCalls(iterations);
      PerfTiming.TimeStore8BytesToIndexerCalls(iterations);
      PerfTiming.TimeStore4BytesToIndexerCalls(iterations);
      PerfTiming.TimeStore2BytesToIndexerCalls(iterations);
      PerfTiming.TimeByteArrayToUInt64_BitConverter_NativeEndian(iterations             / 10);
      PerfTiming.TimeByteArrayToUInt64_BitConverter_ReversedFromNativeEndian(iterations / 10);
      PerfTiming.TimeByteArrayToUInt64LittleEndianByteIndexer(iterations);
      PerfTiming.TimeByteArrayToUInt64BigEndianByteIndexer(iterations);
      PerfTiming.TimeReadOnlySpanOfByteToUInt64LittleEndian(iterations);
      PerfTiming.TimeReadOnlySpanOfByteToUInt64BigEndian(iterations);
   }
}