using UnityEngine;

namespace Unitycoding.UIWidgets
{
    public class MessageSlot : UISlot<Unitycoding.UIWidgets.MessageOptions>
    {
        // Fields
        public UnityEngine.UI.Text text;
        public UnityEngine.UI.Image icon;
        
        // Methods
        public MessageSlot()
        {
        
        }
        protected override void Start()
        {
            this.Start();
            this.transform.SetAsLastSibling();
        }
        public override void UpdateSlot(Unitycoding.UIWidgets.MessageOptions item)
        {
            UnityEngine.UI.Image val_7;
            if(item == null)
            {
                    return;
            }
            
            if(0 != this.text)
            {
                    string val_2 = Unitycoding.UIWidgets.UIUtility.ColorString(value:  null, color:  new UnityEngine.Color() {r = item.color, g = V10.16B, b = V9.16B, a = V8.16B});
                this.DelayCrossFade(graphic:  this.text, options:  item);
            }
            
            val_7 = this.icon;
            if(0 == val_7)
            {
                    return;
            }
            
            val_7 = this.icon.gameObject;
            UnityEngine.Sprite val_7 = item.icon;
            val_7 = UnityEngine.Object.op_Inequality(x:  0, y:  val_7);
            val_7.SetActive(value:  val_7);
            if(0 == item.icon)
            {
                    return;
            }
            
            this.icon.sprite = item.icon;
            this.DelayCrossFade(graphic:  this.icon, options:  item);
        }
        private void DelayCrossFade(UnityEngine.UI.Graphic graphic, Unitycoding.UIWidgets.MessageOptions options)
        {
            float val_3;
            float val_4;
            if(options != null)
            {
                    val_3 = options.delay;
                val_4 = options.duration;
            }
            else
            {
                    val_3 = 5.87748E-39f;
                val_4 = 2.295924E-39f;
            }
            
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.DelayCrossFade(graphic:  graphic, delay:  val_3, duration:  val_4, ignoreTimeScale:  options.ignoreTimeScale));
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator DelayCrossFade(UnityEngine.UI.Graphic graphic, float delay, float duration, bool ignoreTimeScale)
        {
            if(null != 0)
            {
                    typeof(MessageSlot.<DelayCrossFade>c__Iterator0).__il2cppRuntimeField_10 = delay;
                typeof(MessageSlot.<DelayCrossFade>c__Iterator0).__il2cppRuntimeField_18 = graphic;
                typeof(MessageSlot.<DelayCrossFade>c__Iterator0).__il2cppRuntimeField_20 = duration;
                typeof(MessageSlot.<DelayCrossFade>c__Iterator0).__il2cppRuntimeField_24 = ignoreTimeScale;
            }
            else
            {
                    mem[16] = delay;
                mem[24] = graphic;
                mem[32] = duration;
                typeof(MessageSlot.<DelayCrossFade>c__Iterator0).__il2cppRuntimeField_24 = ignoreTimeScale;
            }
            
            typeof(MessageSlot.<DelayCrossFade>c__Iterator0).__il2cppRuntimeField_28 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
    
    }

}
