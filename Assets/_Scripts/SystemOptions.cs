using UnityEngine;

namespace _Scripts
{
    public static class SystemOptions
    {
        public static void HideCursor(bool hide)
        {
            Cursor.visible = !hide;
        }
    }
}