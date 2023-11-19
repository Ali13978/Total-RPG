using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    [System.Runtime.CompilerServices.ExtensionAttribute]
    public static class ScrollRectExtensions
    {
        // Methods
        [System.Runtime.CompilerServices.ExtensionAttribute]
        public static void ScrollToTop(UnityEngine.UI.ScrollRect scrollRect)
        {
            CinemachineFreeLook.Orbit val_1 = new CinemachineFreeLook.Orbit(h:  0f, r:  1f);
            X1.normalizedPosition = new UnityEngine.Vector2() {x = val_1.m_Height, y = val_1.m_Radius};
        }
        [System.Runtime.CompilerServices.ExtensionAttribute]
        public static void ScrollToBottom(UnityEngine.UI.ScrollRect scrollRect)
        {
            CinemachineFreeLook.Orbit val_1 = new CinemachineFreeLook.Orbit(h:  0f, r:  0f);
            X1.normalizedPosition = new UnityEngine.Vector2() {x = val_1.m_Height, y = val_1.m_Radius};
        }
    
    }

}
