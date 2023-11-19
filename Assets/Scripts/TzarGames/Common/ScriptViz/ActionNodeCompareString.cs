using UnityEngine;

namespace TzarGames.Common.ScriptViz
{
    [TzarGames.Common.ScriptViz.LabelAttribute]
    public class ActionNodeCompareString : ActionNode
    {
        // Fields
        [UnityEngine.SerializeField]
        private string stringValue;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        private TzarGames.Common.ScriptViz.SvNodeSlot equalsSlot;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        private TzarGames.Common.ScriptViz.SvNodeSlot notEqualsSlot;
        private string inputString;
        
        // Methods
        public ActionNodeCompareString()
        {
        
        }
        protected override void Init()
        {
            this.Init();
            TzarGames.Common.ScriptViz.SvNodeSlot val_1 = this.addSlotOnLeft(slotName:  "Input string");
            val_1.type = 3;
            val_2.type = 2;
            this.equalsSlot = this.addSlotOnRight(slotName:  "Equals");
            val_3.type = 2;
            this.notEqualsSlot = this.addSlotOnRight(slotName:  "Not equals");
        }
        public override void OnImpulse(TzarGames.Common.NodeSlot slot)
        {
            TzarGames.Common.ScriptViz.SvNodeSlot val_2;
            if((this.stringValue.Equals(value:  this.inputString)) == false)
            {
                goto label_1;
            }
            
            val_2 = this.equalsSlot;
            if(val_2 != null)
            {
                goto label_4;
            }
            
            goto label_3;
            label_1:
            val_2 = this.notEqualsSlot;
            if(val_2 != null)
            {
                goto label_4;
            }
            
            label_3:
            label_4:
            val_2.Impulse();
            this.Impulse();
        }
        public override void OnVariableImpulse(object var, TzarGames.Common.ScriptViz.SvNodeSlot slot)
        {
            object val_2 = var;
            if(val_2 != null)
            {
                    if(null == null)
            {
                goto label_2;
            }
            
            }
            
            val_2 = 0;
            label_2:
            this.inputString = val_2;
        }
    
    }

}
