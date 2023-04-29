namespace Jcd.BitManipulation.Examples.CanOpen;

public struct CanOpenId
{
    private readonly uint _id;
    public bool ContainsNodeId { get; private set; }
    public bool IsValid { get; private set; }
    public CanOpenIdType CanOpenIdType { get; private set; }
    public CommunicationDirection CommunicationDirection { get; private set; }

    public byte NodeId => (byte)_id.ReadBits(0, 7);
    public byte FunctionCode => (byte)_id.ReadBits(7, 4);

    private CanOpenId(uint id, bool containsNodeId, CanOpenIdType canOpenIdType,
                      CommunicationDirection communicationDirection, bool isValid = true)
    {
        _id = id;
        ContainsNodeId = containsNodeId;
        CanOpenIdType = canOpenIdType;
        CommunicationDirection = communicationDirection;
        IsValid = isValid;
    }

    private static bool InNodeRange(uint baseNumber, uint value, bool includeBase = true)
    {
        return includeBase
            ? value >= baseNumber && value <= (baseNumber | 0x7F)
            : value > baseNumber && value <= (baseNumber | 0x7F);
    }

    public static CanOpenId From11BitIdentifier(uint value)
    {
        if (value == 0x000)
            return new CanOpenId(value, false, CanOpenIdType.NmtControl, CommunicationDirection.Request);
        if (value == 0x001)
            return new CanOpenId(value, false, CanOpenIdType.GlobalFailsafe, CommunicationDirection.Unknown);
        if (value == 0x080) return new CanOpenId(value, false, CanOpenIdType.Sync, CommunicationDirection.Request);
        if (InNodeRange(0x80, value, false))
            return new CanOpenId(value, true, CanOpenIdType.Emergency, CommunicationDirection.Response);
        if (value == 0x100) return new CanOpenId(value, false, CanOpenIdType.TimeStamp, CommunicationDirection.Request);
        if (InNodeRange(0x180, value))
            return new CanOpenId(value, true, CanOpenIdType.Pdo, CommunicationDirection.Response);
        if (InNodeRange(0x200, value))
            return new CanOpenId(value, true, CanOpenIdType.Pdo, CommunicationDirection.Request);
        if (InNodeRange(0x280, value))
            return new CanOpenId(value, true, CanOpenIdType.Pdo, CommunicationDirection.Response);
        if (InNodeRange(0x300, value))
            return new CanOpenId(value, true, CanOpenIdType.Pdo, CommunicationDirection.Request);
        if (InNodeRange(0x380, value))
            return new CanOpenId(value, true, CanOpenIdType.Pdo, CommunicationDirection.Response);
        if (InNodeRange(0x400, value))
            return new CanOpenId(value, true, CanOpenIdType.Pdo, CommunicationDirection.Request);
        if (InNodeRange(0x480, value))
            return new CanOpenId(value, true, CanOpenIdType.Pdo, CommunicationDirection.Response);
        if (InNodeRange(0x500, value))
            return new CanOpenId(value, true, CanOpenIdType.Pdo, CommunicationDirection.Request);
        if (InNodeRange(0x580, value))
            return new CanOpenId(value, true, CanOpenIdType.Sdo, CommunicationDirection.Response);
        if (InNodeRange(0x600, value))
            return new CanOpenId(value, true, CanOpenIdType.Sdo, CommunicationDirection.Request);
        if (InNodeRange(0x700, value))
            return new CanOpenId(value, true, CanOpenIdType.NmtMonitor, CommunicationDirection.Response);
        if (value == 0x7E4) return new CanOpenId(value, true, CanOpenIdType.Lss, CommunicationDirection.Response);
        if (value == 0x7E5) return new CanOpenId(value, true, CanOpenIdType.Lss, CommunicationDirection.Request);
        return new CanOpenId(value, false, CanOpenIdType.Unknown, CommunicationDirection.Unknown, false);
    }

    public static implicit operator uint(CanOpenId canOpenId)
    {
        return canOpenId._id;
    }

    public static implicit operator CanOpenId(uint id)
    {
        return From11BitIdentifier(id);
    }
}