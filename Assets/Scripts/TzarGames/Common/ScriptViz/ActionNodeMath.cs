using UnityEngine;

namespace TzarGames.Common.ScriptViz
{
    [TzarGames.Common.ScriptViz.LabelAttribute]
    public class ActionNodeMath : ActionNode
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Common.ScriptViz.MathOperations operation;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        private TzarGames.Common.ScriptViz.SvNodeSlot varOutSlot;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        private TzarGames.Common.ScriptViz.SvNodeSlot var1Slot;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        private TzarGames.Common.ScriptViz.SvNodeSlot var2Slot;
        [UnityEngine.SerializeField]
        private float value1;
        [UnityEngine.SerializeField]
        private float value2;
        
        // Methods
        public ActionNodeMath()
        {
        
        }
        protected override void Init()
        {
            this.Init();
            val_1.type = 4;
            this.varOutSlot = this.addSlotOnRight(slotName:  "Result");
            val_2.type = 3;
            this.var1Slot = this.addSlotOnLeft(slotName:  "1st value");
            val_3.type = 3;
            this.var2Slot = this.addSlotOnLeft(slotName:  "2nd value");
        }
        public override void OnImpulse(TzarGames.Common.NodeSlot slot)
        {
            var val_2 = this;
            TzarGames.Common.ScriptViz.MathOperations val_2 = this.operation;
            val_2 = (val_2 < 3) ? (val_2 + 3) : 0;
            if(val_2 > 5)
            {
                    return;
            }
            
            var val_3 = 25807504 + (this.operation < 0x3 ? (this.operation + 3) : 0) << 2;
            val_3 = val_3 + 25807504;
            goto (25807504 + (this.operation < 0x3 ? (this.operation + 3) : 0) << 2 + 25807504);
        }
        public override void OnVariableImpulse(object var, TzarGames.Common.ScriptViz.SvNodeSlot slot)
        {
            if(var != null)
            {
                    if(((UnityEngine.Object.op_Equality(x:  0, y:  slot)) ^ 1) != true)
            {
                    this.value1 = System.Convert.ToSingle(value:  0);
            }
            
            }
            
            if(var == null)
            {
                    return;
            }
            
            if(((UnityEngine.Object.op_Equality(x:  0, y:  slot)) ^ 1) == true)
            {
                    return;
            }
            
            this.value2 = System.Convert.ToSingle(value:  0);
        }
    
    }

}
