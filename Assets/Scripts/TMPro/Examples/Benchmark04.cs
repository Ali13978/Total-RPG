using UnityEngine;

namespace TMPro.Examples
{
    public class Benchmark04 : MonoBehaviour
    {
        // Fields
        public int SpawnType;
        public int MinPointSize;
        public int MaxPointSize;
        public int Steps;
        private UnityEngine.Transform m_Transform;
        
        // Methods
        public Benchmark04()
        {
            this.MinPointSize = 76;
            this.MaxPointSize = 64;
            this.Steps = 4;
        }
        private void Start()
        {
            int val_22;
            int val_23;
            float val_24;
            int val_25;
            string val_26;
            this.m_Transform = this.transform;
            int val_2 = UnityEngine.Screen.height;
            var val_3 = (val_2 < 0) ? (val_2 + 1) : (val_2);
            val_3 = val_3 >> 1;
            UnityEngine.Camera.main.orthographicSize = (float)val_3;
            val_22 = this.MinPointSize;
            val_23 = this.MaxPointSize;
            if(val_22 > val_23)
            {
                    return;
            }
            
            float val_21 = (float)UnityEngine.Screen.width;
            val_21 = val_21 / (float)UnityEngine.Screen.height;
            val_21 = (float)val_3 * val_21;
            float val_8 = val_21 * (-0.975f);
            val_24 = 0f;
            do
            {
                if(this.SpawnType != 0)
            {
                    val_25 = val_23 >> 32;
            }
            else
            {
                    val_26 = 0 + "Text - "("Text - ") + val_22;
                UnityEngine.GameObject val_11 = new UnityEngine.GameObject(name:  val_26);
                if(val_24 > ((float)val_3 + (float)val_3))
            {
                    return;
            }
            
                UnityEngine.Vector3 val_13 = this.m_Transform.position;
                float val_14 = ((float)val_3 * 0.975f) - val_24;
                UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                transform.position = new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z};
                TMPro.TextMeshPro val_16 = AddComponent<TMPro.TextMeshPro>();
                CinemachineFreeLook.Orbit val_18 = new CinemachineFreeLook.Orbit(h:  0f, r:  0.5f);
                val_16.rectTransform.pivot = new UnityEngine.Vector2() {x = val_18.m_Height, y = val_18.m_Radius};
                if(val_16 != null)
            {
                    val_16.enableWordWrapping = false;
                val_16.extraPadding = true;
                val_16.isOrthographic = true;
            }
            else
            {
                    val_16.enableWordWrapping = false;
                val_16.extraPadding = true;
                val_16.isOrthographic = true;
            }
            
                val_16.fontSize = (float)val_22;
                val_26 = 0 + val_22;
                val_16.text = val_26;
                UnityEngine.Color val_20 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32());
                val_25 = this.Steps;
                val_23 = this.MaxPointSize;
                val_24 = val_24 + (float)val_22;
            }
            
                val_22 = val_25 + val_22;
            }
            while(val_22 <= val_23);
        
        }
    
    }

}
