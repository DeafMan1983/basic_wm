namespace basic_wm;

using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;

[Serializable]
public struct Position<T>
    where T : unmanaged
{
    public T X, Y;

    public Position(T x, T y) => (x, y) = (X, Y);
}

[Serializable]
public struct Size<T>
    where T : unmanaged
{
    public T width, height;

    public Size(T w, T h) => (width, height) = (w, h);
}
public unsafe static class Utils
{
    public static string XRequestCodeToString(byte request_code)
    {
        string[] X_REQUEST_CODE_NAMES = new string[]{
                "",
                "CreateWindow",
                "ChangeWindowAttributes",
                "GetWindowAttributes",
                "DestroyWindow",
                "DestroySubwindows",
                "ChangeSaveSet",
                "ReparentWindow",
                "MapWindow",
                "MapSubwindows",
                "UnmapWindow",
                "UnmapSubwindows",
                "ConfigureWindow",
                "CirculateWindow",
                "GetGeometry",
                "QueryTree",
                "InternAtom",
                "GetAtomName",
                "ChangeProperty",
                "DeleteProperty",
                "GetProperty",
                "ListProperties",
                "SetSelectionOwner",
                "GetSelectionOwner",
                "ConvertSelection",
                "SendEvent",
                "GrabPointer",
                "UngrabPointer",
                "GrabButton",
                "UngrabButton",
                "ChangeActivePointerGrab",
                "GrabKeyboard",
                "UngrabKeyboard",
                "GrabKey",
                "UngrabKey",
                "AllowEvents",
                "GrabServer",
                "UngrabServer",
                "QueryPointer",
                "GetMotionEvents",
                "TranslateCoords",
                "WarpPointer",
                "SetInputFocus",
                "GetInputFocus",
                "QueryKeymap",
                "OpenFont",
                "CloseFont",
                "QueryFont",
                "QueryTextExtents",
                "ListFonts",
                "ListFontsWithInfo",
                "SetFontPath",
                "GetFontPath",
                "CreatePixmap",
                "FreePixmap",
                "CreateGC",
                "ChangeGC",
                "CopyGC",
                "SetDashes",
                "SetClipRectangles",
                "FreeGC",
                "ClearArea",
                "CopyArea",
                "CopyPlane",
                "PolyPoint",
                "PolyLine",
                "PolySegment",
                "PolyRectangle",
                "PolyArc",
                "FillPoly",
                "PolyFillRectangle",
                "PolyFillArc",
                "PutImage",
                "GetImage",
                "PolyText8",
                "PolyText16",
                "ImageText8",
                "ImageText16",
                "CreateColormap",
                "FreeColormap",
                "CopyColormapAndFree",
                "InstallColormap",
                "UninstallColormap",
                "ListInstalledColormaps",
                "AllocColor",
                "AllocNamedColor",
                "AllocColorCells",
                "AllocColorPlanes",
                "FreeColors",
                "StoreColors",
                "StoreNamedColor",
                "QueryColors",
                "LookupColor",
                "CreateCursor",
                "CreateGlyphCursor",
                "FreeCursor",
                "RecolorCursor",
                "QueryBestSize",
                "QueryExtension",
                "ListExtensions",
                "ChangeKeyboardMapping",
                "GetKeyboardMapping",
                "ChangeKeyboardControl",
                "GetKeyboardControl",
                "Bell",
                "ChangePointerControl",
                "GetPointerControl",
                "SetScreenSaver",
                "GetScreenSaver",
                "ChangeHosts",
                "ListHosts",
                "SetAccessControl",
                "SetCloseDownMode",
                "KillClient",
                "RotateProperties",
                "ForceScreenSaver",
                "SetPointerMapping",
                "GetPointerMapping",
                "SetModifierMapping",
                "GetModifierMapping",
                "NoOperation"
        };
        return X_REQUEST_CODE_NAMES[request_code];
    }
}