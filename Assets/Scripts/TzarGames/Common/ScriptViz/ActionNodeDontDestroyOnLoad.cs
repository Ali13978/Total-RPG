using UnityEngine;

namespace TzarGames.Common.ScriptViz
{
    [TzarGames.Common.ScriptViz.LabelAttribute]
    public class ActionNodeDontDestroyOnLoad : ActionNode
    {
        // Methods
        public ActionNodeDontDestroyOnLoad()
        {
        
        }
        public override void OnImpulse(TzarGames.Common.NodeSlot slot)
        {
            UnityEngine.Object.DontDestroyOnLoad(target:  0);
            this.Impulse();
        }
    
    }

}
