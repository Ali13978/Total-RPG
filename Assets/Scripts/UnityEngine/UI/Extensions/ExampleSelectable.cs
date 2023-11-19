using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    public class ExampleSelectable : MonoBehaviour, IBoxSelectable
    {
        // Fields
        private bool _selected;
        private bool _preSelected;
        private UnityEngine.SpriteRenderer spriteRenderer;
        private UnityEngine.UI.Image image;
        private UnityEngine.UI.Text text;
        
        // Properties
        public bool selected { get; set; }
        public bool preSelected { get; set; }
        
        // Methods
        public ExampleSelectable()
        {
        
        }
        public bool get_selected()
        {
            return (bool)this._selected;
        }
        public void set_selected(bool value)
        {
            this._selected = value;
        }
        public bool get_preSelected()
        {
            return (bool)this._preSelected;
        }
        public void set_preSelected(bool value)
        {
            this._preSelected = value;
        }
        private void Start()
        {
            this.spriteRenderer = this.transform.GetComponent<UnityEngine.SpriteRenderer>();
            this.image = this.transform.GetComponent<UnityEngine.UI.Image>();
            this.text = this.transform.GetComponent<UnityEngine.UI.Text>();
        }
        private void Update()
        {
            float val_15;
            float val_16;
            float val_17;
            float val_18;
            UnityEngine.UI.Text val_19;
            UnityEngine.Color val_1 = UnityEngine.Color.white;
            val_15 = val_1.r;
            val_16 = val_1.g;
            val_17 = val_1.b;
            val_18 = val_1.a;
            if(this._preSelected != false)
            {
                    UnityEngine.Color val_2 = UnityEngine.Color.yellow;
                val_15 = val_2.r;
                val_16 = val_2.g;
                val_17 = val_2.b;
                val_18 = val_2.a;
            }
            
            if(this._selected != false)
            {
                    UnityEngine.Color val_3 = UnityEngine.Color.green;
                val_15 = val_3.r;
                val_16 = val_3.g;
                val_17 = val_3.b;
                val_18 = val_3.a;
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
            {
                    this.spriteRenderer.color = new UnityEngine.Color() {r = val_15, g = val_16, b = val_17, a = val_18};
                return;
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  0)) == false)
            {
                goto label_9;
            }
            
            val_19 = this.text;
            if(val_19 != null)
            {
                goto label_15;
            }
            
            goto label_11;
            label_9:
            if((UnityEngine.Object.op_Implicit(exists:  0)) == false)
            {
                goto label_14;
            }
            
            val_19 = this.image;
            if(val_19 != null)
            {
                goto label_15;
            }
            
            label_11:
            label_15:
            val_19.color = new UnityEngine.Color() {r = val_15, g = val_16, b = val_17, a = val_18};
            return;
            label_14:
            UnityEngine.Renderer val_7 = this.GetComponent<UnityEngine.Renderer>();
            if((UnityEngine.Object.op_Implicit(exists:  0)) == false)
            {
                    return;
            }
            
            this.GetComponent<UnityEngine.Renderer>().material.color = new UnityEngine.Color() {r = val_15, g = val_16, b = val_17, a = val_18};
        }
        private UnityEngine.Transform UnityEngine.UI.Extensions.IBoxSelectable.get_transform()
        {
            return this.transform;
        }
    
    }

}
