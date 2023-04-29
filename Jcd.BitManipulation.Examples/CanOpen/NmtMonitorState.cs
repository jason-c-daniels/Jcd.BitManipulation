namespace Jcd.BitManipulation.Examples.CanOpen;

public readonly struct NmtMonitorState
{
    private readonly byte _data;
    public bool IsValid { get; }

    private NmtMonitorState(byte data, bool isValid = true)
    {
        _data = data;
        IsValid = isValid;
    }

    private static NmtMonitorState FromByte(byte data)
    {
        if (data == 0x00 ||
            data == 0x04 ||
            data == 0x05 ||
            data == 0x7F
           ) return new NmtMonitorState(data);
        return new NmtMonitorState(data, false);
    }

    public static implicit operator byte(NmtMonitorState nmtCommandCode)
    {
        return nmtCommandCode._data;
    }

    public static implicit operator NmtMonitorState(byte data)
    {
        return FromByte(data);
    }
}

public static class NmtMonitorStates
{
    public static readonly NmtMonitorState BootUp = 0x00;
    public static readonly NmtMonitorState Stopped = 0x04;
    public static readonly NmtMonitorState Operational = 0x05;
    public static readonly NmtMonitorState Preoperational = 0x7F;
}