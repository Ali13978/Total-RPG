using UnityEngine;

namespace Cinemachine.Utility
{
    public class CinemachineGameWindowDebug
    {
        // Fields
        private static System.Collections.Generic.HashSet<UnityEngine.Object> mClients;
        
        // Methods
        public CinemachineGameWindowDebug()
        {
        
        }
        public static void ReleaseScreenPos(UnityEngine.Object client)
        {
            if(Cinemachine.Utility.CinemachineGameWindowDebug.mClients == null)
            {
                    return;
            }
            
            if((Cinemachine.Utility.CinemachineGameWindowDebug.mClients.Contains(item:  X1)) == false)
            {
                    return;
            }
            
            bool val_2 = Cinemachine.Utility.CinemachineGameWindowDebug.mClients.Remove(item:  X1);
        }
        public static UnityEngine.Rect GetScreenPos(UnityEngine.Object client, string text, UnityEngine.GUIStyle style)
        {
            UnityEngine.Object val_12;
            var val_13;
            System.Collections.Generic.HashSet<UnityEngine.Object> val_14;
            var val_16;
            val_12 = text;
            val_13 = 1152921504931074048;
            val_14 = Cinemachine.Utility.CinemachineGameWindowDebug.mClients;
            if(val_14 == null)
            {
                    Cinemachine.Utility.CinemachineGameWindowDebug.mClients = new System.Collections.Generic.HashSet<UnityEngine.Object>();
                val_14 = Cinemachine.Utility.CinemachineGameWindowDebug.mClients;
                if(null == 0)
            {
                    val_14 = 0;
            }
            
            }
            
            if((val_14.Contains(item:  val_12)) != true)
            {
                    bool val_4 = Add(item:  val_12);
            }
            
            CinemachineFreeLook.Orbit val_5 = new CinemachineFreeLook.Orbit(h:  0f, r:  0f);
            UnityEngine.Vector2 val_7 = X3.CalcSize(content:  new UnityEngine.GUIContent(text:  style));
            if(null == 0)
            {
                    return new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f};
            }
            
            HashSet.Enumerator<T> val_8 = GetEnumerator();
            val_13 = 1152921511736188912;
            goto label_7;
            label_11:
            float val_12 = val_5.m_Radius;
            val_12 = val_7.y + val_12;
            label_7:
            if((0 & 1) == 0)
            {
                goto label_8;
            }
            
            if(0 != 0.InitializationCallback)
            {
                goto label_11;
            }
            
            label_8:
            val_12 = 0;
            val_16 = 1;
            0.Dispose();
            if(( & 1) != 0)
            {
                    return new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f};
            }
            
            if( == false)
            {
                    return new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f};
            }
            
            return new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f};
        }
    
    }

}
