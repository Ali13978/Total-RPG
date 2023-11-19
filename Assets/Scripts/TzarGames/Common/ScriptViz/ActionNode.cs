using UnityEngine;

namespace TzarGames.Common.ScriptViz
{
    [UnityEngine.HideInInspector]
    public class ActionNode : SvNode
    {
        // Fields
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        private TzarGames.Common.ScriptViz.SvNodeSlot outSlot;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        private TzarGames.Common.ScriptViz.SvNodeSlot inSlot;
        
        // Properties
        protected TzarGames.Common.ScriptViz.SvNodeSlot InSlot { get; }
        
        // Methods
        public ActionNode()
        {
        
        }
        protected override void Init()
        {
            val_1.type = 1;
            this.inSlot = this.addSlotOnLeft(slotName:  "In");
            if((this & 1) == 0)
            {
                    return;
            }
            
            val_2.type = 2;
            this.outSlot = this.addSlotOnRight(slotName:  "Out");
        }
        protected virtual bool hasOutSlot()
        {
            return true;
        }
        protected void DefaultImpulse()
        {
            this.outSlot.Impulse();
        }
        protected void RandomImpulse()
        {
            this.outSlot.RandomOutImpulse();
        }
        protected TzarGames.Common.ScriptViz.SvNodeSlot get_InSlot()
        {
            return (TzarGames.Common.ScriptViz.SvNodeSlot)this.inSlot;
        }
    
    }

}
