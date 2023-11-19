using UnityEngine;

namespace TzarGames.Common.ScriptViz
{
    [TzarGames.Common.ScriptViz.LabelAttribute]
    public class ActionNodeUISetText : ActionNode
    {
        // Fields
        public UnityEngine.UI.Text TextWidget;
        public string Text;
        private object obj;
        
        // Methods
        public ActionNodeUISetText()
        {
        
        }
        protected override void Init()
        {
            this.Init();
            TzarGames.Common.ScriptViz.SvNodeSlot val_1 = this.addSlotOnLeft(slotName:  "Object");
            val_1.type = 3;
        }
        public override void OnVariableImpulse(object var, TzarGames.Common.ScriptViz.SvNodeSlot slot)
        {
            this.obj = var;
        }
        public override void OnImpulse(TzarGames.Common.NodeSlot slot)
        {
            string val_2 = this.Text;
            if(this.obj != null)
            {
                    val_2 = 0 + val_2;
            }
            
            if(this.TextWidget == null)
            {
                
            }
        
        }
    
    }

}
