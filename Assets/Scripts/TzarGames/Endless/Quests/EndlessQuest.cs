using UnityEngine;

namespace TzarGames.Endless.Quests
{
    [TzarGames.GameFramework.LocalizedClassNameAttribute]
    public abstract class EndlessQuest : Quest
    {
        // Fields
        [UnityEngine.SerializeField]
        private string[] sceneNames;
        [UnityEngine.SerializeField]
        private int minimumStage;
        [UnityEngine.SerializeField]
        private bool raisesStage;
        [UnityEngine.HeaderAttribute]
        [UnityEngine.SerializeField]
        private int gold;
        [UnityEngine.SerializeField]
        private float goldGrowRate;
        [UnityEngine.SerializeField]
        private int xp;
        [UnityEngine.SerializeField]
        private float xpGrowRate;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.Quests.ItemRewardInfo[] rewardItems;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.Endless.ICharacterInfo <Owner>k__BackingField;
        
        // Properties
        public string[] SceneNames { get; }
        public TzarGames.Endless.ICharacterInfo Owner { get; set; }
        public bool RaisesStage { get; }
        public TzarGames.GameFramework.Item[] RewardItems { get; }
        public int MinimumStage { get; }
        
        // Methods
        protected EndlessQuest()
        {
            this.gold = 1000;
            this.goldGrowRate = 0.5f;
            this.xp = 1000;
            this.xpGrowRate = 0.5f;
            val_1 = new TzarGames.Common.CommonAsset();
        }
        public string[] get_SceneNames()
        {
            return (System.String[])this.sceneNames;
        }
        public TzarGames.Endless.ICharacterInfo get_Owner()
        {
            return (TzarGames.Endless.ICharacterInfo)this.<Owner>k__BackingField;
        }
        public void set_Owner(TzarGames.Endless.ICharacterInfo value)
        {
            this.<Owner>k__BackingField = value;
        }
        public bool get_RaisesStage()
        {
            return (bool)this.raisesStage;
        }
        public TzarGames.GameFramework.Item[] get_RewardItems()
        {
            var val_2;
            System.Collections.Generic.List<TzarGames.GameFramework.Item> val_1 = new System.Collections.Generic.List<TzarGames.GameFramework.Item>();
            val_2 = 0;
            goto label_1;
            label_7:
            Add(item:  this);
            val_2 = 1;
            label_1:
            if(val_2 >= this.rewardItems.Length)
            {
                goto label_3;
            }
            
            TzarGames.Endless.Quests.ItemRewardInfo val_2 = this.rewardItems[1];
            if(null != 0)
            {
                goto label_7;
            }
            
            goto label_7;
            label_3:
            if(null != 0)
            {
                    return ToArray();
            }
            
            return ToArray();
        }
        public virtual void Initialize()
        {
        
        }
        public virtual bool ConflictsWith(TzarGames.Endless.Quests.EndlessQuest quest)
        {
            return false;
        }
        public int GetGoldRewardForLevel(uint level)
        {
            float val_2 = this.goldGrowRate;
            val_2 = (float)(double)level * val_2;
            val_2 = (float)this.gold * val_2;
            return (int)(int)val_2 + this.gold;
        }
        public int GetXpRewardForLevel(uint level)
        {
            float val_2 = this.xpGrowRate;
            val_2 = (float)(double)level * val_2;
            val_2 = (float)this.xp * val_2;
            return (int)(int)val_2 + this.xp;
        }
        public TzarGames.GameFramework.Item[] GetItemsReward()
        {
            var val_3;
            System.Collections.Generic.List<TzarGames.GameFramework.Item> val_1 = new System.Collections.Generic.List<TzarGames.GameFramework.Item>();
            val_3 = 0;
            goto label_1;
            label_8:
            val_3 = 1;
            label_1:
            if(val_3 >= this.rewardItems.Length)
            {
                goto label_3;
            }
            
            TzarGames.Endless.Quests.ItemRewardInfo val_3 = this.rewardItems[1];
            if((GameUtils.RandomDrop(chanceRate:  0)) == false)
            {
                goto label_8;
            }
            
            Add(item:  this.rewardItems[0x1][0].Item);
            goto label_8;
            label_3:
            if(null != 0)
            {
                    return ToArray();
            }
            
            return ToArray();
        }
        public int get_MinimumStage()
        {
            return (int)this.minimumStage;
        }
    
    }

}
