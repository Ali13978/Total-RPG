using UnityEngine;

namespace TzarGames.Common.ScriptViz
{
    [TzarGames.Common.ScriptViz.LabelAttribute]
    public class ActionNodeDestroy : ActionNode
    {
        // Fields
        private UnityEngine.Object objectToDestroy;
        
        // Methods
        public ActionNodeDestroy()
        {
        
        }
        protected override void Init()
        {
            this.Init();
            TzarGames.Common.ScriptViz.SvNodeSlot val_1 = this.addSlotOnLeft(slotName:  "Object to destroy");
            val_1.type = 3;
        }
        public override void OnImpulse(TzarGames.Common.NodeSlot slot)
        {
            UnityEngine.Object.Destroy(obj:  0);
            this.Impulse();
        }
        public override void OnVariableImpulse(object var, TzarGames.Common.ScriptViz.SvNodeSlot slot)
        {
            if(var == null)
            {
                    return;
            }
            
            this.objectToDestroy = var;
        }
    
    }

}
