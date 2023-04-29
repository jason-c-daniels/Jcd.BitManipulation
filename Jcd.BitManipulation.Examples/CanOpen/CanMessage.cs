using System;
using System.Linq;
using Jcd.BitManipulation.Examples.NumericToByteArrayConversions;

namespace Jcd.BitManipulation.Examples.CanOpen;

public class CanMessage
{
    protected CanMessage(CanHeader canHeader, byte[] data)
    {
        CanHeader = canHeader ?? throw new ArgumentNullException(nameof(canHeader));
        Data = data ?? Array.Empty<byte>();
    }

    protected CanMessage(CanOpenId canOpenId, byte[] data) : this(canOpenId, false, data)
    {
    }

    protected CanMessage(CanOpenId canOpenId, bool rtrFlag = false, byte[] data = null)
    {
        Data = data ?? Array.Empty<byte>();
        CanHeader = new CanHeader(0)
        {
            CanOpenId = canOpenId,
            DataLength = Convert.ToByte(Data.Length)
        };
    }

    public CanHeader CanHeader { get; protected set; }

    public byte[] Data { get; protected set; }
}

public class NmtMonitorResponse : CanMessage
{
    public NmtMonitorResponse(CanOpenId canOpenId, byte[] data)
        : base(canOpenId, false,
            data?.Length == 1
                ? data
                : throw new ArgumentException("There must be exactly 1 byte of state data for an NmtMonitorResponse",
                    nameof(data)))
    {
    }

    public NmtMonitorResponse(CanOpenId canOpenId, NmtMonitorState state) : base(canOpenId, false, new byte[] { state })
    {
    }

    public NmtMonitorState State
    {
        get => Data[0];
        set => Data[0] = value;
    }
}

public class SdoMessageBase : CanMessage
{
    public SdoMessageBase(CanOpenId sdoBaseOpenId,
                          byte nodeId,
                          byte sdoCommand,
                          ushort index,
                          byte subindex,
                          byte[] data = null) :
        base(sdoBaseOpenId + nodeId, false,
            new[] { sdoCommand }
                .Concat(index.ToLittleEndianByteArray())
                .Concat(new[] { subindex })
                .Concat(data ?? Array.Empty<byte>())
                .ToArray())
    {
    }
}