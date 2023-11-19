using UnityEngine;

namespace TzarGames.Endless
{
    [Serializable]
    public class StageConversastionInfo
    {
        // Fields
        public TzarGames.Endless.ConversationData Conversation;
        public uint Stage;
        public bool AlwaysShow;
        public TzarGames.Endless.Quests.EpicBossQuest BossQuest;
        public UnityEngine.Events.UnityEvent OnConversationFinished;
        
        // Methods
        public StageConversastionInfo()
        {
        
        }
    
    }

}
