using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    [System.Runtime.CompilerServices.ExtensionAttribute]
    public static class RectTransformExtension
    {
        // Methods
        [System.Runtime.CompilerServices.ExtensionAttribute]
        public static UnityEngine.Vector2 switchToRectTransform(UnityEngine.RectTransform from, UnityEngine.RectTransform to)
        {
            float val_34;
            float val_35;
            float val_36;
            float val_37;
            UnityEngine.Rect val_1 = to.rect;
            if(to != null)
            {
                    UnityEngine.Vector2 val_2 = to.pivot;
                val_34 = val_2.x;
            }
            else
            {
                    UnityEngine.Vector2 val_3 = 0.pivot;
                val_34 = val_3.x;
            }
            
            UnityEngine.Rect val_4 = to.rect;
            UnityEngine.Rect val_5 = to.rect;
            if(to != null)
            {
                    UnityEngine.Vector2 val_6 = to.pivot;
                val_35 = val_6.y;
            }
            else
            {
                    UnityEngine.Vector2 val_7 = 0.pivot;
                val_35 = val_7.y;
            }
            
            UnityEngine.Rect val_8 = to.rect;
            CinemachineFreeLook.Orbit val_13 = new CinemachineFreeLook.Orbit(h:  (val_1.m_XMin * val_34) + val_4.m_XMin, r:  (val_5.m_XMin * val_35) + val_8.m_XMin);
            UnityEngine.Vector3 val_14 = to.position;
            UnityEngine.Vector2 val_15 = UnityEngine.RectTransformUtility.WorldToScreenPoint(cam:  0, worldPoint:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
            UnityEngine.Vector2 val_16 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_15.x, y = val_15.y}, b:  new UnityEngine.Vector2() {x = val_13.m_Height, y = val_13.m_Radius});
            bool val_17 = UnityEngine.RectTransformUtility.ScreenPointToLocalPointInRectangle(rect:  0, screenPoint:  new UnityEngine.Vector2() {x = val_16.x, y = val_16.y}, cam:  X2, localPoint: out  new UnityEngine.Vector2());
            UnityEngine.Rect val_18 = X2.rect;
            if(X2 != 0)
            {
                    UnityEngine.Vector2 val_19 = X2.pivot;
                val_36 = val_19.x;
            }
            else
            {
                    UnityEngine.Vector2 val_20 = 0.pivot;
                val_36 = val_20.x;
            }
            
            UnityEngine.Rect val_21 = X2.rect;
            UnityEngine.Rect val_22 = X2.rect;
            if(X2 != 0)
            {
                    UnityEngine.Vector2 val_23 = X2.pivot;
                val_37 = val_23.y;
            }
            else
            {
                    UnityEngine.Vector2 val_24 = 0.pivot;
                val_37 = val_24.y;
            }
            
            UnityEngine.Rect val_25 = X2.rect;
            CinemachineFreeLook.Orbit val_30 = new CinemachineFreeLook.Orbit(h:  (val_18.m_XMin * val_36) + val_21.m_XMin, r:  (val_22.m_XMin * val_37) + val_25.m_XMin);
            UnityEngine.Vector2 val_31 = X2.anchoredPosition;
            UnityEngine.Vector2 val_32 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_31.x, y = val_31.y}, b:  new UnityEngine.Vector2() {x = 0f, y = 0f});
            UnityEngine.Vector2 val_33 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_32.x, y = val_32.y}, b:  new UnityEngine.Vector2() {x = val_30.m_Height, y = val_30.m_Radius});
            return new UnityEngine.Vector2() {x = val_33.x, y = val_33.y};
        }
    
    }

}
