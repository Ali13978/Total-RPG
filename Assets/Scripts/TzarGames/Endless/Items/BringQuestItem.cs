using UnityEngine;

namespace TzarGames.Endless.Items
{
    [TzarGames.GameFramework.LocalizedClassNameAttribute]
    public class BringQuestItem : StageItem
    {
        // Fields
        [UnityEngine.Serialization.FormerlySerializedAsAttribute]
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedStringAsset localizedStory;
        
        // Properties
        public string Story { get; }
        
        // Methods
        public BringQuestItem()
        {
            val_1 = new TzarGames.GameFramework.Item();
        }
        public string get_Story()
        {
            return TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0);
        }
    
    }

}
