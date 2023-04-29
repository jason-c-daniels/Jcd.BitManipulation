namespace Jcd.BitManipulation.Examples.CanOpen;

public class CanHeader
{
    private uint _headerData;

    public CanHeader(uint headerData)
    {
        _headerData = headerData;
    }

    public CanHeader(byte functionCode, byte nodeId, bool rtrFlag, byte dataLength)
    {
        _headerData = 0;
        FunctionCode = functionCode;
        NodeId = nodeId;
        RtrFlag = rtrFlag;
        DataLength = dataLength;
    }

    public CanOpenId CanOpenId
    {
        get => _headerData.ReadBits(5, 11);
        set => _headerData = _headerData.StoreBits(value, 5, 11);
    }

    public bool RtrFlag
    {
        get => _headerData.ReadBit(4);
        set => _headerData = _headerData.StoreBit(value, 4);
    }

    public byte NodeId
    {
        get => (byte)_headerData.ReadBits(5, 7);
        set => _headerData = _headerData.StoreBits(value, 5, 7);
    }

    public byte FunctionCode
    {
        get => (byte)_headerData.ReadBits(12, 4);
        set => _headerData = _headerData.StoreBits(value, 12, 4);
    }

    public byte DataLength
    {
        get => (byte)_headerData.ReadBits(0, 4);
        set => _headerData = _headerData.StoreBits(value, 0, 4);
    }

    public static explicit operator uint(CanHeader canHeader)
    {
        return canHeader._headerData;
    }

    public static explicit operator CanHeader(uint headerData)
    {
        return new CanHeader(headerData);
    }
}