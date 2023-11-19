using UnityEngine;

namespace TzarGames.Common.ScriptViz
{
    [TzarGames.Common.ScriptViz.LabelAttribute]
    public class ActionNodeCompareNumber : ActionNode
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
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        private TzarGames.Common.ScriptViz.SvNodeSlot lessSlot;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        private TzarGames.Common.ScriptViz.SvNodeSlot greaterSlot;
        [UnityEngine.SerializeField]
        private float value1;
        [UnityEngine.SerializeField]
        private float value2;
        
        // Methods
        public ActionNodeCompareNumber()
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
            val_5.type = 2;
            this.lessSlot = this.addSlotOnRight(slotName:  "Less");
            val_6.type = 2;
            this.greaterSlot = this.addSlotOnRight(slotName:  "Greater");
        }
        public override void OnImpulse(TzarGames.Common.NodeSlot slot)
        {
            TzarGames.Common.ScriptViz.SvNodeSlot val_1;
            if((this.value1 & 1) == 0)
            {
                goto label_0;
            }
            
            val_1 = this.equalsSlot;
            if(val_1 != null)
            {
                goto label_7;
            }
            
            goto label_6;
            label_0:
            this.notEqualsSlot.Impulse();
            if(this.value1 >= 0)
            {
                goto label_4;
            }
            
            val_1 = this.lessSlot;
            if(val_1 != null)
            {
                goto label_7;
            }
            
            goto label_6;
            label_4:
            val_1 = this.greaterSlot;
            if(val_1 != null)
            {
                goto label_7;
            }
            
            label_6:
            label_7:
            val_1.Impulse();
            this.Impulse();
        }
        public override void OnVariableImpulse(object var, TzarGames.Common.ScriptViz.SvNodeSlot slot)
        {
            TzarGames.Common.ScriptViz.SvNodeSlot val_5 = slot;
            if(0 == val_5)
            {
                    this.value1 = System.Convert.ToSingle(value:  0);
                return;
            }
            
            val_5 = this.var2slot;
            if((UnityEngine.Object.op_Implicit(exists:  0)) == false)
            {
                    return;
            }
            
            this.value2 = System.Convert.ToSingle(value:  0);
        }
    
    }

}
