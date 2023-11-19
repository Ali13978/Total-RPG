using UnityEngine;

namespace TzarGames.Common.ScriptViz
{
    [TzarGames.Common.ScriptViz.LabelAttribute]
    public class ActionNodeCompare : ActionNode
    {
        // Fields
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        private TzarGames.Common.ScriptViz.SvNodeSlot var1slot;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        private TzarGames.Common.ScriptViz.SvNodeSlot var2slot;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        private TzarGames.Common.ScriptViz.SvNodeSlot equalsSlot;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        private TzarGames.Common.ScriptViz.SvNodeSlot notEqualsSlot;
        private object var1;
        private object var2;
        
        // Methods
        public ActionNodeCompare()
        {
        
        }
        protected override void Init()
        {
            this.Init();
            val_1.type = 3;
            this.var1slot = this.addSlotOnLeft(slotName:  "1st object");
            val_2.type = 3;
            this.var2slot = this.addSlotOnLeft(slotName:  "2nd object");
            val_3.type = 2;
            this.equalsSlot = this.addSlotOnRight(slotName:  "Equals");
            val_4.type = 2;
            this.notEqualsSlot = this.addSlotOnRight(slotName:  "Not equals");
        }
        public override void OnImpulse(TzarGames.Common.NodeSlot slot)
        {
            TzarGames.Common.ScriptViz.SvNodeSlot val_1;
            if((this.var1 & 1) == 0)
            {
                goto label_1;
            }
            
            val_1 = this.equalsSlot;
            if(val_1 != null)
            {
                goto label_4;
            }
            
            goto label_3;
            label_1:
            val_1 = this.notEqualsSlot;
            if(val_1 != null)
            {
                goto label_4;
            }
            
            label_3:
            label_4:
            val_1.Impulse();
            this.Impulse();
        }
        public override void OnVariableImpulse(object var, TzarGames.Common.ScriptViz.SvNodeSlot slot)
        {
            TzarGames.Common.ScriptViz.SvNodeSlot val_3 = slot;
            if(0 == val_3)
            {
                    this.var1 = var;
                return;
            }
            
            val_3 = this.var2slot;
            if((UnityEngine.Object.op_Implicit(exists:  0)) == false)
            {
                    return;
            }
            
            this.var2 = var;
        }
    
    }

}
