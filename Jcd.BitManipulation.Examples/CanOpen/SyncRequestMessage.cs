namespace Jcd.BitManipulation.Examples.CanOpen;

public class SyncRequestMessage : CanMessage
{
    public SyncRequestMessage() : base(CanOpenIds.Sync, new byte[] { })
    {
    }
}