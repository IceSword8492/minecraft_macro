#r "System.Windows.Forms"

#load "D:\Dドキュメント\programming\cs\minecraft_macro_key2key\coord.csx"

using System.Runtime.InteropServices;
using System.Windows.Forms;

[DllImport("USER32.dll", CallingConvention = CallingConvention.StdCall)]
static extern void SetCursorPos(int x, int y);

[DllImport("USER32.dll", CallingConvention = CallingConvention.StdCall)]
static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

const int MOUSEEVENTF_LEFTDOWN = 0x2;
const int MOUSEEVENTF_LEFTUP = 0x4;
const int MOUSEEVENTF_RIGHTDOWN = 0x8;
const int MOUSEEVENTF_RIGHTUP = 0x10;

class Mouse {
    public static void ClickL () {
        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
    }
    public static void ClickR () {
        mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
        mouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
    }
    public static void DownL () {
        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
    }
    public static void UpL () {
        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
    }
    public static void DownR () {
        mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
    }
    public static void UpR () {
        mouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
    }
    public static Coord GetCursorPosition () {
        return new Coord(Cursor.Position.X, Cursor.Position.Y);
    }
    public static void SetCursorPosition (int x, int y) {
        SetCursorPos(x, y);
    }
    public static void SetCursorPosition (Coord c) {
        SetCursorPos(c.x, c.y);
    }
}