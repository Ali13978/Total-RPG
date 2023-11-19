using UnityEngine;

namespace TzarGames.Common.ScriptViz
{
    [TzarGames.Common.ScriptViz.LabelAttribute]
    public class EventNodeStart : EventNode
    {
        // Fields
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        private TzarGames.Common.ScriptViz.SvNodeSlot outSlot;
        
        // Methods
        public EventNodeStart()
        {
        
        }
        protected override void Init()
        {
            val_1.type = 2;
            this.outSlot = this.addSlotOnRight(slotName:  "Out");
        }
        public override void OnTrigger(string slotName)
        {
            this.outSlot.Impulse();
        }
    
    }

}
