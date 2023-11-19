using UnityEngine;

namespace Cinemachine.Utility
{
    [System.Runtime.CompilerServices.ExtensionAttribute]
    public static class UnityRectExtensions
    {
        // Methods
        [System.Runtime.CompilerServices.ExtensionAttribute]
        public static UnityEngine.Rect Inflated(UnityEngine.Rect r, UnityEngine.Vector2 delta)
        {
            delta.x = r.m_XMin - delta.x;
            float val_1 = delta.x + delta.x;
            float val_2 = delta.y + delta.y;
            float val_3 = r.m_XMin - delta.y;
            val_1 = val_1 + r.m_XMin;
            val_2 = val_2 + r.m_XMin;
            return new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f};
        }
    
    }

}
