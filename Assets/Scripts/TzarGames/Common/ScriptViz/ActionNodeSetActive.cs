using UnityEngine;

namespace TzarGames.Common.ScriptViz
{
    [TzarGames.Common.ScriptViz.LabelAttribute]
    public class ActionNodeSetActive : ActionNode
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.GameObject gameObject;
        [UnityEngine.SerializeField]
        private bool active;
        
        // Methods
        public ActionNodeSetActive()
        {
            this.active = true;
        }
        protected override void Init()
        {
            this.Init();
            TzarGames.Common.ScriptViz.SvNodeSlot val_1 = this.addSlotOnLeft(slotName:  "Active");
            val_1.type = 3;
        }
        public override void OnImpulse(TzarGames.Common.NodeSlot slot)
        {
            this.gameObject.SetActive(value:  (this.active == true) ? 1 : 0);
            this.Impulse();
        }
        public override void OnVariableImpulse(object var, TzarGames.Common.ScriptViz.SvNodeSlot slot)
        {
            this.active = System.Convert.ToBoolean(value:  0);
        }
    
    }

}
