using UnityEngine;

namespace TzarGames.Common.ScriptViz
{
    [TzarGames.Common.ScriptViz.LabelAttribute]
    public class ActionNodeLoadLevel : ActionNode
    {
        // Fields
        [UnityEngine.SerializeField]
        private string LevelName;
        
        // Methods
        public ActionNodeLoadLevel()
        {
        
        }
        public override void OnImpulse(TzarGames.Common.NodeSlot slot)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  0);
            this.Impulse();
        }
    
    }

}
