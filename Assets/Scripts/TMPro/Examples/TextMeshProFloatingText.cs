using UnityEngine;

namespace TMPro.Examples
{
    public class TextMeshProFloatingText : MonoBehaviour
    {
        // Fields
        public UnityEngine.Font TheFont;
        private UnityEngine.GameObject m_floatingText;
        private TMPro.TextMeshPro m_textMeshPro;
        private UnityEngine.TextMesh m_textMesh;
        private UnityEngine.Transform m_transform;
        private UnityEngine.Transform m_floatingText_Transform;
        private UnityEngine.Transform m_cameraTransform;
        private UnityEngine.Vector3 lastPOS;
        private UnityEngine.Quaternion lastRotation;
        public int SpawnType;
        
        // Methods
        public TextMeshProFloatingText()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            this.lastPOS = val_1;
            mem[1152921512523907044] = val_1.y;
            mem[1152921512523907048] = val_1.z;
            UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.identity;
            this.lastRotation = val_2;
            mem[1152921512523907056] = val_2.y;
            mem[1152921512523907060] = val_2.z;
            mem[1152921512523907064] = val_2.w;
        }
        private void Awake()
        {
            this.m_transform = this.transform;
            this.m_floatingText = new UnityEngine.GameObject(name:  0 + this.name);
            this.m_cameraTransform = UnityEngine.Camera.main.transform;
        }
        private void Start()
        {
            float val_27;
            float val_28;
            var val_29;
            string val_30;
            UnityEngine.Font val_32;
            if(this.SpawnType != 1)
            {
                    if(this.SpawnType != 0)
            {
                    return;
            }
            
                TMPro.TextMeshPro val_1 = this.m_floatingText.AddComponent<TMPro.TextMeshPro>();
                this.m_textMeshPro = val_1;
                CinemachineFreeLook.Orbit val_3 = new CinemachineFreeLook.Orbit(h:  3f, r:  3f);
                val_1.rectTransform.sizeDelta = new UnityEngine.Vector2() {x = val_3.m_Height, y = val_3.m_Radius};
                UnityEngine.Transform val_4 = this.m_floatingText.transform;
                this.m_floatingText_Transform = val_4;
                UnityEngine.Vector3 val_5 = this.m_transform.position;
                UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                val_4.position = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
                this.m_textMeshPro.alignment = 2;
                int val_7 = UnityEngine.Random.Range(min:  0, max:  0);
                int val_8 = UnityEngine.Random.Range(min:  0, max:  0);
                int val_9 = UnityEngine.Random.Range(min:  0, max:  0);
                UnityEngine.Color val_10 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32());
                val_27 = val_10.r;
                val_28 = val_10.b;
                this.m_textMeshPro.fontSize = 24f;
                val_29 = null;
                val_29 = null;
                val_30 = System.String.Empty;
                this.m_textMeshPro.text = val_30;
                System.Collections.IEnumerator val_11 = this.DisplayTextMeshProFloatingText();
            }
            else
            {
                    UnityEngine.Transform val_12 = this.m_floatingText.transform;
                this.m_floatingText_Transform = val_12;
                UnityEngine.Vector3 val_13 = this.m_transform.position;
                UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                val_12.position = new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z};
                UnityEngine.TextMesh val_15 = this.m_floatingText.AddComponent<UnityEngine.TextMesh>();
                this.m_textMesh = val_15;
                System.Type val_16 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
                string val_27 = "Fonts/ARIAL";
                UnityEngine.Object val_17 = UnityEngine.Resources.Load(path:  0, systemTypeInstance:  val_27);
                if(val_17 != null)
            {
                    val_27 = (null == null) ? (val_17) : 0;
            }
            else
            {
                    val_32 = 0;
            }
            
                val_15.font = val_32;
                this.m_textMesh.GetComponent<UnityEngine.Renderer>().sharedMaterial = this.m_textMesh.font.material;
                val_30 = UnityEngine.Random.Range(min:  0, max:  0);
                int val_22 = UnityEngine.Random.Range(min:  0, max:  0);
                int val_23 = UnityEngine.Random.Range(min:  0, max:  0);
                UnityEngine.Color val_24 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32());
                val_27 = val_24.r;
                val_28 = val_24.b;
                this.m_textMesh.color = new UnityEngine.Color() {r = val_27, g = val_24.g, b = val_28, a = val_24.a};
                this.m_textMesh.anchor = 7;
                this.m_textMesh.fontSize = 24;
            }
            
            UnityEngine.Coroutine val_26 = this.StartCoroutine(routine:  this.DisplayTextMeshFloatingText());
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        public System.Collections.IEnumerator DisplayTextMeshProFloatingText()
        {
            typeof(TextMeshProFloatingText.<DisplayTextMeshProFloatingText>c__Iterator0).__il2cppRuntimeField_38 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        public System.Collections.IEnumerator DisplayTextMeshFloatingText()
        {
            typeof(TextMeshProFloatingText.<DisplayTextMeshFloatingText>c__Iterator1).__il2cppRuntimeField_38 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
    
    }

}
