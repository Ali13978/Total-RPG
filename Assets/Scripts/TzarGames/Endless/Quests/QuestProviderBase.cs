using UnityEngine;

namespace TzarGames.Endless.Quests
{
    public class QuestProviderBase : MonoBehaviour
    {
        // Fields
        protected System.Collections.Generic.List<TzarGames.Endless.Quests.EndlessQuest> availableQuests;
        
        // Properties
        public TzarGames.Endless.Quests.EndlessQuest[] AvailableQuests { get; }
        
        // Methods
        public QuestProviderBase()
        {
            this.availableQuests = new System.Collections.Generic.List<TzarGames.Endless.Quests.EndlessQuest>();
        }
        public TzarGames.Endless.Quests.EndlessQuest[] get_AvailableQuests()
        {
            if(this.availableQuests != null)
            {
                    return this.availableQuests.ToArray();
            }
            
            return this.availableQuests.ToArray();
        }
    
    }

}
