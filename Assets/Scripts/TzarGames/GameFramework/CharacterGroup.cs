using UnityEngine;

namespace TzarGames.GameFramework
{
    [TzarGames.GameFramework.LocalizedClassNameAttribute]
    public class CharacterGroup : CommonAsset
    {
        // Fields
        [UnityEngine.SerializeField]
        private System.Collections.Generic.List<TzarGames.GameFramework.CharacterGroup> friendlyGroups;
        
        // Methods
        public CharacterGroup()
        {
        
        }
        public bool IsFriendly(TzarGames.GameFramework.CharacterGroup group)
        {
            if(this.friendlyGroups != null)
            {
                    return this.friendlyGroups.Contains(item:  group);
            }
            
            return this.friendlyGroups.Contains(item:  group);
        }
    
    }

}
