#region

using Hardware.Info;

using Jcd.Units;
using Jcd.Units.UnitsOfMeasure.SI;
using Jcd.Units.UnitTypes;

// ReSharper disable HeapView.DelegateAllocation
// ReSharper disable HeapView.BoxingAllocation
// ReSharper disable HeapView.ObjectAllocation
// ReSharper disable HeapView.ObjectAllocation.Evident
// ReSharper disable HeapView.ClosureAllocation

#pragma warning disable S109

#endregion

namespace Jcd.BitManipulation.Examples;

public class SystemInfo
{
   private static readonly Frequency GHz = Frequencies.Gigahertz;
   private static readonly Frequency MHz = Frequencies.Megahertz;
   private readonly HardwareInfo hardwareInfo;

   private SystemInfo()
   {
      hardwareInfo = new HardwareInfo(false);
      hardwareInfo.RefreshCPUList(false);
      Cpu = hardwareInfo.CpuList[0];

      MaximumCpuFrequency = Cpu.MaxClockSpeed.As(MHz).To(GHz);

      RefreshInfo();
   }

   public static SystemInfo Instance { get; } = new();

   // ReSharper disable once InconsistentNaming
   public CPU Cpu { get; private set; }

   // ReSharper disable once InconsistentNaming
   public Quantity<Frequency> MaximumCpuFrequency { get; }

   // ReSharper disable once InconsistentNaming
   public Quantity<Frequency> CurrentCpuFrequency { get; private set; }

   public void RefreshInfo()
   {
      hardwareInfo.RefreshCPUList(false);
      Cpu = hardwareInfo.CpuList[0];
      CurrentCpuFrequency = GetCurrentClockSpeed(Cpu);
   }

   private static Quantity<Frequency> GetCurrentClockSpeed(CPU cpu)
   {
      return cpu.CurrentClockSpeed > 1000
                ? (cpu.CurrentClockSpeed / 1000d).As(Frequencies.Gigahertz)
                : cpu.CurrentClockSpeed.As(Frequencies.Megahertz);
   }
}