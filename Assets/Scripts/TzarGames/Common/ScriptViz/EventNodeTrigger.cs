using UnityEngine;

namespace TzarGames.Common.ScriptViz
{
    [TzarGames.Common.ScriptViz.LabelAttribute]
    public class EventNodeTrigger : EventNode
    {
        // Fields
        [UnityEngine.SerializeField]
        private int MaxTriggerCount;
        private int triggerCount;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        private TzarGames.Common.ScriptViz.SvNodeSlot OnTriggerEnterSlot;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        private TzarGames.Common.ScriptViz.SvNodeSlot OnTriggerExitSlot;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        private TzarGames.Common.ScriptViz.SvNodeSlot OnCollisionEnterSlot;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        private TzarGames.Common.ScriptViz.SvNodeSlot OnCollisionExitSlot;
        
        // Methods
        public EventNodeTrigger()
        {
            this.MaxTriggerCount = 1;
        }
        protected override void Init()
        {
            val_1.type = 2;
            this.OnTriggerEnterSlot = this.addSlotOnRight(slotName:  "OnTriggerEnter");
            val_2.type = 2;
            this.OnTriggerExitSlot = this.addSlotOnRight(slotName:  "OnTriggerExit");
            val_3.type = 2;
            this.OnCollisionEnterSlot = this.addSlotOnRight(slotName:  "OnCollisionEnter");
            val_4.type = 2;
            this.OnCollisionExitSlot = this.addSlotOnRight(slotName:  "OnCollisionExit");
        }
        public override void OnTrigger(string slotName)
        {
            var val_10;
            TzarGames.Common.ScriptViz.SvNodeSlot val_11;
            if(this.MaxTriggerCount >= 1)
            {
                    if(this.MaxTriggerCount <= (this.MaxTriggerCount >> 32))
            {
                    return;
            }
            
            }
            
            if(slotName == null)
            {
                goto label_21;
            }
            
            val_10 = 1152921504608284672;
            if((System.String.op_Equality(a:  0, b:  slotName)) == false)
            {
                goto label_6;
            }
            
            val_11 = this.OnTriggerEnterSlot;
            if(val_11 != null)
            {
                goto label_22;
            }
            
            goto label_18;
            label_6:
            if((System.String.op_Equality(a:  0, b:  slotName)) == false)
            {
                goto label_11;
            }
            
            val_11 = this.OnTriggerExitSlot;
            if(val_11 != null)
            {
                goto label_22;
            }
            
            goto label_18;
            label_11:
            if((System.String.op_Equality(a:  0, b:  slotName)) == false)
            {
                goto label_16;
            }
            
            val_11 = this.OnCollisionEnterSlot;
            if(val_11 != null)
            {
                goto label_22;
            }
            
            goto label_18;
            label_16:
            if((System.String.op_Equality(a:  0, b:  slotName)) == false)
            {
                goto label_21;
            }
            
            val_11 = this.OnCollisionExitSlot;
            if(val_11 != null)
            {
                goto label_22;
            }
            
            label_18:
            label_22:
            val_11.Impulse();
            label_21:
            int val_10 = this.triggerCount;
            val_10 = val_10 + 1;
            this.triggerCount = val_10;
        }
    
    }

}
