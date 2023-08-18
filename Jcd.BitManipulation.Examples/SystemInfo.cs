#region

using System.Linq;
using Hardware.Info;
using Jcd.Units;
using Jcd.Units.UnitsOfMeasure.SI;
using Jcd.Units.UnitTypes;

#endregion

namespace Jcd.BitManipulation.Examples;

public class SystemInfo
{
    private static readonly Frequency GHz = Frequencies.Gigahertz;
    private static readonly Frequency MHz = Frequencies.Megahertz;
    private readonly IHardwareInfo _hardwareInfo;

    private SystemInfo()
    {
        _hardwareInfo = new HardwareInfo(false);
        _hardwareInfo.RefreshCPUList(false);
        CPU = _hardwareInfo.CpuList.First();

        MaximumCPUFrequency = CPU.MaxClockSpeed.As(MHz)
            .To(GHz);

        RefreshInfo();
    }

    public static SystemInfo Instance { get; } = new();

    // ReSharper disable once InconsistentNaming
    public CPU CPU { get; private set; }

    // ReSharper disable once InconsistentNaming
    public Quantity<Frequency> MaximumCPUFrequency { get; }

    // ReSharper disable once InconsistentNaming
    public Quantity<Frequency> CurrentCPUFrequency { get; private set; }

    public void RefreshInfo()
    {
        _hardwareInfo.RefreshCPUList(false);
        CPU = _hardwareInfo.CpuList.First();
        CurrentCPUFrequency = GetCurrentClockSpeed(CPU);
    }

    private static Quantity<Frequency> GetCurrentClockSpeed(CPU cpu)
    {
        return cpu.CurrentClockSpeed > 1000
            ? (cpu.CurrentClockSpeed / 1000d).As(Frequencies.Gigahertz)
            : cpu.CurrentClockSpeed.As(Frequencies.Megahertz);
    }
}