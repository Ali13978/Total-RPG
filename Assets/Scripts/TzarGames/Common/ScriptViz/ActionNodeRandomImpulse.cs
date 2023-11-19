using UnityEngine;

namespace TzarGames.Common.ScriptViz
{
    [TzarGames.Common.ScriptViz.LabelAttribute]
    public class ActionNodeRandomImpulse : ActionNode
    {
        // Methods
        public ActionNodeRandomImpulse()
        {
        
        }
        public override void OnImpulse(TzarGames.Common.NodeSlot slot)
        {
            X19.RandomOutImpulse();
        }
    
    }

}
