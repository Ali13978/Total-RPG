using UnityEngine;

namespace TzarGames.Common.ScriptViz
{
    [UnityEngine.HideInInspector]
    public abstract class VariableNode : SvNode
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Common.ScriptViz.SvNodeSlot outSlot;
        
        // Properties
        protected abstract object Value { get; set; }
        
        // Methods
        protected VariableNode()
        {
        
        }
        protected override void Init()
        {
            TzarGames.Common.ScriptViz.SvNodeSlot val_1 = this.addSlotOnLeft(slotName:  "In");
            val_1.type = 3;
            val_2.type = 4;
            this.outSlot = this.addSlotOnRight(slotName:  "Out");
        }
        public void ImpulseDefaultValue()
        {
            this.outSlot.VariableImpulse(variable:  this);
        }
        protected void ImpulseOut(object variable)
        {
            if(0 == this.outSlot)
            {
                    return;
            }
            
            this.outSlot.VariableImpulse(variable:  variable);
        }
        protected override void OnEnable()
        {
            this.ImpulseDefaultValue();
        }
        public override void OnVariableImpulse(object var, TzarGames.Common.ScriptViz.SvNodeSlot slot)
        {
            this.ImpulseOut(variable:  this);
        }
        protected abstract object get_Value(); // 0
        protected abstract void set_Value(object value); // 0
    
    }

}
