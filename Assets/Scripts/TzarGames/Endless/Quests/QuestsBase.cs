using UnityEngine;

namespace TzarGames.Endless.Quests
{
    [Serializable]
    internal class QuestsBase
    {
        // Fields
        public System.Collections.Generic.List<TzarGames.Endless.Quests.QuestInfo> Quests;
        
        // Methods
        public QuestsBase()
        {
            this.Quests = new System.Collections.Generic.List<TzarGames.Endless.Quests.QuestInfo>();
        }
    
    }

}
