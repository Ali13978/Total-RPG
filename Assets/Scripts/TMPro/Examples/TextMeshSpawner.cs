using UnityEngine;

namespace TMPro.Examples
{
    public class TextMeshSpawner : MonoBehaviour
    {
        // Fields
        public int SpawnType;
        public int NumberOfNPC;
        public UnityEngine.Font TheFont;
        private TMPro.Examples.TextMeshProFloatingText floatingText_Script;
        
        // Methods
        public TextMeshSpawner()
        {
            this.NumberOfNPC = 12;
        }
        private void Awake()
        {
        
        }
        private void Start()
        {
            var val_13;
            var val_14;
            float val_15;
            float val_16;
            if(this.NumberOfNPC < 1)
            {
                    return;
            }
            
            var val_13 = 0;
            label_23:
            UnityEngine.GameObject val_1 = new UnityEngine.GameObject();
            UnityEngine.Transform val_2 = transform;
            float val_3 = UnityEngine.Random.Range(min:  -95f, max:  95f);
            float val_4 = UnityEngine.Random.Range(min:  -95f, max:  95f);
            if(this.SpawnType == 0)
            {
                goto label_3;
            }
            
            val_2.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            val_13 = AddComponent<UnityEngine.TextMesh>();
            val_13.GetComponent<UnityEngine.Renderer>().sharedMaterial = this.TheFont.material;
            if(val_13 == null)
            {
                goto label_9;
            }
            
            val_13.font = this.TheFont;
            val_13.anchor = 7;
            goto label_10;
            label_3:
            val_2.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            val_13 = AddComponent<TMPro.TextMeshPro>();
            if(val_13 == null)
            {
                goto label_13;
            }
            
            val_14 = 96f;
            val_13.fontSize = 96f;
            goto label_14;
            label_9:
            val_13.font = this.TheFont;
            val_13.anchor = 7;
            label_10:
            val_13.fontSize = 96;
            UnityEngine.Color val_9 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32());
            val_15 = val_9.g;
            val_16 = val_9.a;
            if(val_13 != null)
            {
                    val_13.color = new UnityEngine.Color() {r = val_9.r, g = val_15, b = val_9.b, a = val_16};
            }
            else
            {
                    val_13.color = new UnityEngine.Color() {r = val_9.r, g = val_15, b = val_9.b, a = val_16};
            }
            
            val_13.text = "!";
            this.floatingText_Script = AddComponent<TMPro.Examples.TextMeshProFloatingText>();
            val_10.SpawnType = 1;
            goto label_19;
            label_13:
            val_14 = 96f;
            0.fontSize = 96f;
            label_14:
            0.text = "!";
            UnityEngine.Color val_11 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32());
            val_16 = val_11.r;
            val_15 = val_11.b;
            this.floatingText_Script = AddComponent<TMPro.Examples.TextMeshProFloatingText>();
            val_12.SpawnType = 0;
            label_19:
            val_13 = val_13 + 1;
            if(val_13 < this.NumberOfNPC)
            {
                goto label_23;
            }
        
        }
    
    }

}
