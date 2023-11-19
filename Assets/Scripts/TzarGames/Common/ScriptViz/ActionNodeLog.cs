using UnityEngine;

namespace TzarGames.Common.ScriptViz
{
    [TzarGames.Common.ScriptViz.LabelAttribute]
    public class ActionNodeLog : ActionNode
    {
        // Fields
        public string LogMessage;
        public bool LogOnlyVariable;
        
        // Methods
        public ActionNodeLog()
        {
            null = null;
            this.LogMessage = System.String.Empty;
        }
        protected override void Init()
        {
            this.Init();
            TzarGames.Common.ScriptViz.SvNodeSlot val_1 = this.addSlotOnLeft(slotName:  "Object");
            val_1.type = 3;
        }
        public override void OnImpulse(TzarGames.Common.NodeSlot slot)
        {
            if(this.LogOnlyVariable != true)
            {
                    UnityEngine.Debug.Log(message:  0);
            }
            
            this.Impulse();
        }
        public override void OnVariableImpulse(object var, TzarGames.Common.ScriptViz.SvNodeSlot slot)
        {
            string val_1 = 0 + this.LogMessage;
            UnityEngine.Debug.Log(message:  0);
        }
    
    }

}
