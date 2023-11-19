using UnityEngine;

namespace TzarGames.Endless
{
    [TzarGames.GameFramework.LocalizedClassNameAttribute]
    public sealed class BossInfo : CommonAsset
    {
        // Fields
        [UnityEngine.SerializeField]
        private int stage;
        [UnityEngine.SerializeField]
        private string sceneName;
        
        // Properties
        public int Stage { get; }
        public string SceneName { get; }
        
        // Methods
        public BossInfo()
        {
        
        }
        public int get_Stage()
        {
            return (int)this.stage;
        }
        public string get_SceneName()
        {
            return (string)this.sceneName;
        }
    
    }

}
