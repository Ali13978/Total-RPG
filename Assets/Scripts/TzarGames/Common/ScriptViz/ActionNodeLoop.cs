using UnityEngine;

namespace TzarGames.Common.ScriptViz
{
    [TzarGames.Common.ScriptViz.LabelAttribute]
    public class ActionNodeLoop : ActionNode
    {
        // Fields
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        private TzarGames.Common.ScriptViz.SvNodeSlot iterationCountSlot;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        private TzarGames.Common.ScriptViz.SvNodeSlot iterationNumberSlot;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        private TzarGames.Common.ScriptViz.SvNodeSlot iterationSlot;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        private TzarGames.Common.ScriptViz.SvNodeSlot finishedSlot;
        [UnityEngine.SerializeField]
        private int iterationCount;
        private object var1;
        private object var2;
        
        // Methods
        public ActionNodeLoop()
        {
        
        }
        protected override void Init()
        {
            this.Init();
            val_1.type = 3;
            this.iterationCountSlot = this.addSlotOnLeft(slotName:  "Iteration count");
            val_2.type = 4;
            this.iterationNumberSlot = this.addSlotOnRight(slotName:  "Executing iteration number");
            val_3.type = 2;
            this.iterationSlot = this.addSlotOnRight(slotName:  "Iteration executed");
            val_4.type = 2;
            this.finishedSlot = this.addSlotOnRight(slotName:  "Finished");
        }
        protected override bool hasOutSlot()
        {
            return false;
        }
        public override void OnImpulse(TzarGames.Common.NodeSlot slot)
        {
            if(this.iterationCount >= 1)
            {
                    object val_1 = 0;
                do
            {
                this.iterationNumberSlot.VariableImpulse(variable:  val_1);
                this.iterationSlot.Impulse();
                val_1 = val_1 + 1;
            }
            while(val_1 < this.iterationCount);
            
            }
            
            this.finishedSlot.Impulse();
        }
        public override void OnVariableImpulse(object var, TzarGames.Common.ScriptViz.SvNodeSlot slot)
        {
            if(var == null)
            {
                    return;
            }
            
            if(((UnityEngine.Object.op_Equality(x:  0, y:  slot)) ^ 1) == true)
            {
                    return;
            }
            
            if(null != null)
            {
                    return;
            }
            
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            this.iterationCount = null;
        }
    
    }

}
