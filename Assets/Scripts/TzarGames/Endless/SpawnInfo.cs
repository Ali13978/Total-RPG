using UnityEngine;

namespace TzarGames.Endless
{
    [UnityEngine.CreateAssetMenuAttribute]
    public class SpawnInfo : ScriptableObject
    {
        // Fields
        [UnityEngine.SerializeField]
        private System.Collections.Generic.List<TzarGames.Endless.SpawnGroup> groups;
        
        // Properties
        public System.Collections.Generic.IEnumerable<TzarGames.Endless.SpawnGroup> Groups { get; }
        public int GroupCount { get; }
        
        // Methods
        public SpawnInfo()
        {
        
        }
        public System.Collections.Generic.IEnumerable<TzarGames.Endless.SpawnGroup> get_Groups()
        {
            return (System.Collections.Generic.IEnumerable<TzarGames.Endless.SpawnGroup>)this.groups;
        }
        public int get_GroupCount()
        {
            if(this.groups != null)
            {
                    return this.groups.Count;
            }
            
            return this.groups.Count;
        }
        public TzarGames.Endless.SpawnGroup GetGroupAtIndex(int index)
        {
            var val_3;
            if(this.groups.Count > index)
            {
                    TzarGames.Endless.SpawnGroup val_2 = this.groups.Item[index];
                return (TzarGames.Endless.SpawnGroup)val_3;
            }
            
            UnityEngine.Debug.LogError(message:  0);
            val_3 = 0;
            return (TzarGames.Endless.SpawnGroup)val_3;
        }
    
    }

}
