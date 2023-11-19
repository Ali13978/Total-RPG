using UnityEngine;

namespace TMPro.Examples
{
    public class Benchmark02 : MonoBehaviour
    {
        // Fields
        public int SpawnType;
        public int NumberOfNPC;
        private TMPro.Examples.TextMeshProFloatingText floatingText_Script;
        
        // Methods
        public Benchmark02()
        {
            this.NumberOfNPC = 12;
        }
        private void Start()
        {
            var val_35;
            var val_36;
            UnityEngine.Font val_37;
            UnityEngine.Transform val_38;
            float val_39;
            float val_40;
            var val_41;
            var val_42;
            if(this.NumberOfNPC < 1)
            {
                    return;
            }
            
            var val_36 = 0;
            label_50:
            if(this.SpawnType == 2)
            {
                goto label_2;
            }
            
            if(this.SpawnType == 1)
            {
                goto label_3;
            }
            
            if(this.SpawnType != 0)
            {
                goto label_44;
            }
            
            UnityEngine.GameObject val_1 = null;
            val_35 = val_1;
            val_1 = new UnityEngine.GameObject();
            float val_3 = UnityEngine.Random.Range(min:  -95f, max:  95f);
            float val_4 = UnityEngine.Random.Range(min:  -95f, max:  95f);
            transform.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            val_36 = AddComponent<TMPro.TextMeshPro>();
            CinemachineFreeLook.Orbit val_7 = new CinemachineFreeLook.Orbit(h:  0.5f, r:  0f);
            val_36.rectTransform.pivot = new UnityEngine.Vector2() {x = val_7.m_Height, y = val_7.m_Radius};
            if(val_36 == null)
            {
                goto label_11;
            }
            
            val_36.alignment = 2;
            goto label_12;
            label_3:
            UnityEngine.GameObject val_8 = new UnityEngine.GameObject();
            float val_10 = UnityEngine.Random.Range(min:  -95f, max:  95f);
            float val_11 = UnityEngine.Random.Range(min:  -95f, max:  95f);
            transform.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            val_36 = AddComponent<UnityEngine.TextMesh>();
            System.Type val_13 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            string val_35 = "Fonts/ARIAL";
            UnityEngine.Object val_14 = UnityEngine.Resources.Load(path:  0, systemTypeInstance:  val_35);
            if(val_14 == null)
            {
                goto label_19;
            }
            
            val_35 = (null == null) ? (val_14) : 0;
            goto label_20;
            label_2:
            UnityEngine.GameObject val_15 = null;
            val_35 = val_15;
            val_15 = new UnityEngine.GameObject();
            AddComponent<UnityEngine.Canvas>().worldCamera = UnityEngine.Camera.main;
            transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            float val_20 = UnityEngine.Random.Range(min:  -95f, max:  95f);
            float val_21 = UnityEngine.Random.Range(min:  -95f, max:  95f);
            transform.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.GameObject val_22 = new UnityEngine.GameObject();
            val_36 = AddComponent<TMPro.TextMeshProUGUI>();
            val_38 = transform;
            val_36.rectTransform.SetParent(parent:  val_38, worldPositionStays:  false);
            UnityEngine.Color val_26 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32());
            val_39 = val_26.r;
            val_40 = val_26.b;
            if(val_36 == null)
            {
                goto label_32;
            }
            
            val_36.alignment = 2;
            val_36.fontSize = 96f;
            goto label_47;
            label_19:
            val_37 = 0;
            label_20:
            val_36.font = val_37;
            if(val_36 != null)
            {
                    val_41 = val_36.GetComponent<UnityEngine.Renderer>();
            }
            else
            {
                    val_41 = 0.GetComponent<UnityEngine.Renderer>();
            }
            
            val_38 = val_36.font.material;
            val_41.sharedMaterial = val_38;
            if(val_36 != null)
            {
                    val_36.anchor = 7;
            }
            else
            {
                    val_36.anchor = 7;
            }
            
            val_36.fontSize = 96;
            UnityEngine.Color val_31 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32());
            val_40 = val_31.g;
            val_39 = val_31.a;
            if(val_36 != null)
            {
                    val_36.color = new UnityEngine.Color() {r = val_31.r, g = val_40, b = val_31.b, a = val_39};
            }
            else
            {
                    val_36.color = new UnityEngine.Color() {r = val_31.r, g = val_40, b = val_31.b, a = val_39};
            }
            
            val_36.text = "!";
            this.floatingText_Script = AddComponent<TMPro.Examples.TextMeshProFloatingText>();
            val_32.SpawnType = 1;
            goto label_44;
            label_11:
            val_36.alignment = 2;
            label_12:
            val_36.fontSize = 96f;
            UnityEngine.Color val_33 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32());
            val_39 = val_33.r;
            val_40 = val_33.g;
            val_42 = 0;
            if(val_36 == null)
            {
                    val_42 = 1;
            }
            
            if(val_42 != 0)
            {
                goto label_46;
            }
            
            goto label_47;
            label_32:
            val_36.alignment = 2;
            val_36.fontSize = 96f;
            label_46:
            label_47:
            val_36.text = "!";
            this.floatingText_Script = AddComponent<TMPro.Examples.TextMeshProFloatingText>();
            val_34.SpawnType = 0;
            label_44:
            val_36 = val_36 + 1;
            if(val_36 < this.NumberOfNPC)
            {
                goto label_50;
            }
        
        }
    
    }

}
