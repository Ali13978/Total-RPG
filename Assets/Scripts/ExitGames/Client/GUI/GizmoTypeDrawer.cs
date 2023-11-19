using UnityEngine;

namespace ExitGames.Client.GUI
{
    public class GizmoTypeDrawer
    {
        // Methods
        public GizmoTypeDrawer()
        {
        
        }
        public static void Draw(UnityEngine.Vector3 center, ExitGames.Client.GUI.GizmoType type, UnityEngine.Color color, float size)
        {
            UnityEngine.Gizmos.color = new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = color.a};
            var val_2 = (W1 < 4) ? (W1 + 3) : 0;
            val_2 = val_2 - 3;
            if(val_2 > 3)
            {
                    return;
            }
            
            var val_4 = 25806128 + ((W1 < 0x4 ? (W1 + 3) : 0 - 3)) << 2;
            val_4 = val_4 + 25806128;
            goto (25806128 + ((W1 < 0x4 ? (W1 + 3) : 0 - 3)) << 2 + 25806128);
        }
    
    }

}
