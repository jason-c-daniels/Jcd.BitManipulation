namespace Jcd.BitManipulation.Examples.CanOpen;

public static class NmtCommandCodes
{
    public static readonly NmtCommandCode Operational = 0x01;
    public static readonly NmtCommandCode Stopped = 0x02;
    public static readonly NmtCommandCode Preoperational = 0x80;
    public static readonly NmtCommandCode ResetNode = 0x81;
    public static readonly NmtCommandCode ResetCommunication = 0x82;
}