namespace Jcd.BitManipulation.Examples.CanOpen;

public static class CanOpenIds
{
    public static CanOpenId NmtControl = 0x000;
    public static CanOpenId GlobalFailSafe = 0x001;
    public static CanOpenId Sync = 0x080;
    public static CanOpenId TimeStamp = 0x100;
    public static CanOpenId LssResponse = 0x7E4;
    public static CanOpenId LssRequest = 0x7E5;
    public static CanOpenId TxPdo1Base = 0x180;
    public static CanOpenId RxPdo1Base = 0x200;
    public static CanOpenId TxPdo2Base = 0x280;
    public static CanOpenId RxPdo2Base = 0x300;
    public static CanOpenId TxPdo3Base = 0x380;
    public static CanOpenId RxPdo3Base = 0x400;
    public static CanOpenId TxPdo4Base = 0x480;
    public static CanOpenId RxPdo4Base = 0x500;

    public static CanOpenId SdoResponseBase = 0x580;
    public static CanOpenId SdoRequestBase = 0x600;

    public static CanOpenId NmtMonitorBase = 0x700;
}