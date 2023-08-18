#region

using Jcd.Units;
using Jcd.Units.UnitsOfMeasure;
using Jcd.Units.UnitsOfMeasure.SI;
using Jcd.Units.UnitTypes;

#endregion

namespace Jcd.BitManipulation.Examples;

internal record RunStats
(
    Quantity<Duration> Elapsed
    , Quantity<Duration> ElapsedPerOperation
    , double TotalCpuCycles
    , double CpuCyclesPerOperation
    , Quantity<Frequency> AverageCpuFrequency
    , int OperationsPerIteration
)
{
    public static readonly RunStats Empty = new(
        0.As(Durations.Second)
        , 0.As(Durations.Second)
        , 0d
        , 0d
        , 0.As(Frequencies.Hertz)
        , 0
    );
}