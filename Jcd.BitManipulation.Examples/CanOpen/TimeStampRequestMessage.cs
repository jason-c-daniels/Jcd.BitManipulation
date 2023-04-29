namespace Jcd.BitManipulation.Examples.CanOpen;

public class TimeStampRequestMessage : CanMessage
{
    public TimeStampRequestMessage() : base(CanOpenIds.TimeStamp, new byte[] { })
    {
    }
}