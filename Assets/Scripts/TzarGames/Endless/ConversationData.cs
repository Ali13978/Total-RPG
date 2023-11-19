using UnityEngine;

namespace TzarGames.Endless
{
    [TzarGames.GameFramework.LocalizedClassNameAttribute]
    public class ConversationData : CommonAsset
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Endless.ConversationEntry[] _entries;
        
        // Properties
        public TzarGames.Endless.ConversationEntry[] Entries { get; }
        
        // Methods
        public ConversationData()
        {
        
        }
        public TzarGames.Endless.ConversationEntry[] get_Entries()
        {
            return (TzarGames.Endless.ConversationEntry[])this._entries;
        }
    
    }

}
