using UnityEngine;

namespace TzarGames.Common.ScriptViz
{
    [TzarGames.Common.ScriptViz.LabelAttribute]
    public class ActionNodeSetInt : ActionNode
    {
        // Fields
        [UnityEngine.SerializeField]
        private int value;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        private TzarGames.Common.ScriptViz.SvNodeSlot varOutSlot;
        
        // Methods
        public ActionNodeSetInt()
        {
        
        }
        protected override void Init()
        {
            this.Init();
            val_1.type = 4;
            this.varOutSlot = this.addSlotOnRight(slotName:  "Value");
        }
        public override void OnImpulse(TzarGames.Common.NodeSlot slot)
        {
            this.varOutSlot.VariableImpulse(variable:  this.value);
            this.Impulse();
        }
    
    }

}
