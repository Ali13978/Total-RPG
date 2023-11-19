using UnityEngine;

namespace TzarGames.Endless.Quests
{
    [Serializable]
    public class QuestInfo : IQuestInfo
    {
        // Fields
        [UnityEngine.SerializeField]
        private int _id;
        [UnityEngine.SerializeField]
        private TzarGames.Common.SerializableData _data;
        
        // Properties
        public int Id { get; }
        public TzarGames.Common.SerializableData Data { get; set; }
        
        // Methods
        public QuestInfo(int id)
        {
            this._id = id;
        }
        public int get_Id()
        {
            return (int)this._id;
        }
        public TzarGames.Common.SerializableData get_Data()
        {
            return (TzarGames.Common.SerializableData)this._data;
        }
        public void set_Data(TzarGames.Common.SerializableData value)
        {
            this._data = value;
        }
    
    }

}
