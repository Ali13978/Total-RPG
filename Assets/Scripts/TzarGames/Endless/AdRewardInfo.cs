using UnityEngine;

namespace TzarGames.Endless
{
    public class AdRewardInfo : CommonAsset
    {
        // Fields
        private const string watchedCountKey = "STAGE_AD_WATCH_COUNT";
        private const string alreadyWatchedKey = "STAGE_AD_ANY_WATCHED";
        private const int max_ads_rewards_per_stage = 5;
        [UnityEngine.SerializeField]
        private int goldRewardStageMultiplier;
        [UnityEngine.SerializeField]
        private float goldRewardRandomPercent;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.AdRewardItem[] itemRewards;
        
        // Methods
        public AdRewardInfo()
        {
            this.goldRewardStageMultiplier = 300;
            this.goldRewardRandomPercent = 20f;
        }
        public uint GetGoldRewardForStage(uint stage)
        {
            float val_3 = this.goldRewardRandomPercent;
            float val_2 = 100f;
            float val_4 = (float)this.goldRewardStageMultiplier;
            val_2 = val_3 / val_2;
            val_3 = val_4 * val_2;
            val_4 = -(val_4 * val_2);
            float val_1 = UnityEngine.Random.Range(min:  val_4, max:  val_3);
            val_1 = val_1 + (float)this.goldRewardStageMultiplier;
            val_1 = (float)(double)stage * val_1;
            return 0;
        }
        private string getStageKey(uint stage)
        {
            return (string)0 + "STAGE_AD_WATCH_COUNT";
        }
        public static bool IsAnyStageAdWatched(TzarGames.Common.SerializableData data)
        {
            if(X1 != 0)
            {
                    return X1.HasInt(id:  "STAGE_AD_ANY_WATCHED");
            }
            
            return X1.HasInt(id:  "STAGE_AD_ANY_WATCHED");
        }
        public int GetAvailableAdsForStage(uint stage, TzarGames.Common.SerializableData data)
        {
            var val_5;
            string val_1 = this.getStageKey(stage:  stage);
            if((data.HasInt(id:  val_1)) != false)
            {
                    int val_3 = data.GetInt(id:  val_1);
                val_3 = (val_3 < 5) ? (5 - val_3) : 0;
                return 5;
            }
            
            val_5 = 5;
            return 5;
        }
        public void IncrementWatchCount(uint stage, TzarGames.Common.SerializableData data)
        {
            var val_7;
            string val_1 = this.getStageKey(stage:  stage);
            if((data.HasInt(id:  val_1)) != false)
            {
                    val_7 = (data.GetInt(id:  val_1)) + 1;
            }
            else
            {
                    val_7 = 1;
            }
            
            if(data != null)
            {
                    data.SetInt(id:  val_1, val:  1);
            }
            else
            {
                    0.SetInt(id:  val_1, val:  1);
            }
            
            if((data.HasInt(id:  "STAGE_AD_ANY_WATCHED")) != false)
            {
                    return;
            }
            
            data.SetInt(id:  "STAGE_AD_ANY_WATCHED", val:  1);
        }
        public TzarGames.Endless.AdRewardItem[] TryGetItemRewards(CodeStage.AntiCheat.ObscuredTypes.ObscuredBool checkChance, int maxCount = 2147483647)
        {
            TzarGames.Endless.AdRewardItem val_6;
            var val_7;
            bool val_6 = checkChance.inited;
            val_6 = this;
            System.Collections.Generic.List<TzarGames.Endless.AdRewardItem> val_1 = new System.Collections.Generic.List<TzarGames.Endless.AdRewardItem>();
            var val_7 = 0;
            val_7 = 0;
            label_10:
            if(val_7 >= this.itemRewards.Length)
            {
                goto label_2;
            }
            
            val_6 = this.itemRewards[0];
            val_6 = (val_6 & (-4294967296)) | (val_6 & 4294967295);
            if((CodeStage.AntiCheat.ObscuredTypes.ObscuredBool.op_Implicit(value:  new CodeStage.AntiCheat.ObscuredTypes.ObscuredBool() {inited = checkChance.currentCryptoKey, fakeValue = checkChance.currentCryptoKey, fakeValueActive = checkChance.currentCryptoKey})) != false)
            {
                    if((UnityEngine.Random.Range(min:  0f, max:  100f)) > this.itemRewards[0x0][0].chancePercent)
            {
                goto label_8;
            }
            
            }
            
            Add(item:  val_6);
            val_7 = val_7 + 1;
            label_8:
            val_7 = val_7 + 1;
            if(val_7 != maxCount)
            {
                goto label_10;
            }
            
            label_2:
            if(null != 0)
            {
                    return ToArray();
            }
            
            return ToArray();
        }
        public void GiveRewardToCharacter(TzarGames.Endless.PlayerCharacter playerCharacter, int gold, TzarGames.Endless.AdRewardItem[] items)
        {
            var val_3;
            playerCharacter.AddGold(goldAdd:  gold);
            val_3 = 0;
            goto label_1;
            label_8:
            bool val_1 = playerCharacter.TakeItem(itemInstance:  gold, dropperInfo:  0);
            val_3 = 1;
            label_1:
            if(val_3 >= items.Length)
            {
                    return;
            }
            
            TzarGames.Endless.AdRewardItem val_3 = items[1];
            TzarGames.GameFramework.ItemInstance val_2 = items[0x1][0].item.CreateItemInstance();
            if(playerCharacter != null)
            {
                goto label_8;
            }
            
            goto label_8;
        }
    
    }

}
