using UnityEngine;

namespace TzarGames.Common.ScriptViz
{
    [TzarGames.Common.ScriptViz.LabelAttribute]
    public class EventNodeStringMessage : EventNode
    {
        // Fields
        [UnityEngine.SerializeField]
        private string EventID;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        private TzarGames.Common.ScriptViz.SvNodeSlot outSlot;
        
        // Methods
        public EventNodeStringMessage()
        {
        
        }
        protected override void Init()
        {
            val_1.type = 2;
            this.outSlot = this.addSlotOnRight(slotName:  "Out");
        }
        public override void OnTrigger(string slotName)
        {
            if((System.String.op_Equality(a:  0, b:  slotName)) == false)
            {
                    return;
            }
            
            this.outSlot.Impulse();
        }
    
    }

}
