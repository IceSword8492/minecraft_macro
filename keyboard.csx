using System.Runtime.InteropServices;

[DllImport("USER32.dll")]
public static extern uint keybd_event(byte bVk, byte bScan, uint dwFlags, UIntPtr dwExtraInfo);
const int KEYEVENTF_KEYDOWN = 0;
const int KEYEVENTF_KEYUP = 2;


class Key {
    public static char Ctrl = (char)0x11;
    public static char Shift = (char)0x10;
    public static char Esc = (char)243;
    public static char Enter = (char)13;
    public static void Press (char ch) {
        keybd_event((byte)ch, 0, KEYEVENTF_KEYDOWN, (UIntPtr)0);
        keybd_event((byte)ch, 0, KEYEVENTF_KEYUP, (UIntPtr)0);
    }
    public static void Down (char ch) {
        keybd_event((byte)ch, 0, KEYEVENTF_KEYDOWN, (UIntPtr)0);
    }
    public static void Up (char ch) {
        keybd_event((byte)ch, 0, KEYEVENTF_KEYUP, (UIntPtr)0);
    }
}