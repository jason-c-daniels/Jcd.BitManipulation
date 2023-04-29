namespace Jcd.BitManipulation.Examples.CanOpen;

public struct NmtCommandCode
{
    private readonly byte _data;
    public bool IsValid { get; }

    private NmtCommandCode(byte data, bool isValid = true)
    {
        _data = data;
        IsValid = isValid;
    }

    private static NmtCommandCode FromByte(byte data)
    {
        if (data == 0x01 ||
            data == 0x02 ||
            data == 0x80 ||
            data == 0x81 ||
            data == 0x82
           ) return new NmtCommandCode(data);
        return new NmtCommandCode(data, false);
    }

    public static implicit operator byte(NmtCommandCode nmtCommandCode)
    {
        return nmtCommandCode._data;
    }

    public static implicit operator NmtCommandCode(byte data)
    {
        return FromByte(data);
    }
}