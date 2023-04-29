using Jcd.BitManipulation.Examples.CanOpen;

namespace Jcd.BitManipulation.Examples;

public class NmtRequestMessage : CanMessage
{
    public NmtRequestMessage(NmtCommandCode requestedState, byte nodeId) : base(CanOpenIds.NmtControl, false,
        new byte[] { requestedState, nodeId })
    {
    }

    public CanOpenId CanOpenId => CanHeader.CanOpenId;

    public byte NodeId
    {
        get => Data[1];
        set => Data[1] = value;
    }

    public NmtCommandCode RequestedState
    {
        get => Data[0];
        set => Data[0] = value;
    }
}