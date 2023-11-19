using UnityEngine;

namespace TzarGames.Endless
{
    public class AdsRewardUI : GameUIBase
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Endless.AdRewardInfo adRewards;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.AdRewardInfo firstAdRewards;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.UIBase mainWindow;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.UIBase rewardWindow;
        [UnityEngine.SerializeField]
        private TzarGames.Common.ShowAds ads;
        [UnityEngine.SerializeField]
        private UnityEngine.RectTransform itemContainer;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.UI.RewardItemUI rewardItemPrefab;
        [UnityEngine.SerializeField]
        private UnityEngine.GameObject getRewardButton;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI goldValue;
        [UnityEngine.SerializeField]
        private float goldCountTime;
        [UnityEngine.SerializeField]
        private float itemCountTime;
        [UnityEngine.SerializeField]
        private UnityEngine.Events.UnityEvent onGoldFinished;
        [UnityEngine.SerializeField]
        private UnityEngine.Events.UnityEvent onItemFinished;
        
        // Properties
        public bool AdsAvailable { get; }
        
        // Methods
        public AdsRewardUI()
        {
            this.goldCountTime = Infinityf;
            this.itemCountTime = 1f;
        }
        public bool get_AdsAvailable()
        {
            var val_7;
            TzarGames.Common.SerializableData val_8;
            var val_9;
            var val_10;
            var val_11;
            if(0 == TzarGames.Endless.EndlessGameState._instance)
            {
                goto label_4;
            }
            
            if(null == 0)
            {
                goto label_6;
            }
            
            val_8 = SelectedCharacter;
            if(val_8 != null)
            {
                goto label_7;
            }
            
            goto label_8;
            label_4:
            val_9 = 1;
            return (bool)val_9;
            label_6:
            val_8 = 0;
            label_8:
            val_7 = 0;
            label_7:
            if(mem[282584257676929] == 0)
            {
                goto label_13;
            }
            
            var val_5 = mem[282584257676823];
            var val_6 = 0;
            val_5 = val_5 + 8;
            label_12:
            if(((mem[282584257676823] + 8) + -8) == null)
            {
                goto label_11;
            }
            
            val_6 = val_6 + 1;
            val_5 = val_5 + 16;
            if(val_6 < mem[282584257676929])
            {
                goto label_12;
            }
            
            goto label_13;
            label_11:
            var val_7 = val_5;
            val_7 = val_7 + 6;
            val_7 = val_7 + val_7;
            val_7 = val_7 + 272;
            label_13:
            if(null == 0)
            {
                goto label_15;
            }
            
            val_11 = SelectedCharacter;
            if(val_11 != null)
            {
                goto label_16;
            }
            
            goto label_17;
            label_15:
            val_11 = 0;
            label_17:
            val_10 = 0;
            label_16:
            if(mem[282584257676929] == 0)
            {
                goto label_21;
            }
            
            var val_8 = mem[282584257676823];
            var val_9 = 0;
            val_8 = val_8 + 8;
            label_20:
            if(((mem[282584257676823] + 8) + -8) == null)
            {
                goto label_19;
            }
            
            val_9 = val_9 + 1;
            val_8 = val_8 + 16;
            if(val_9 < mem[282584257676929])
            {
                goto label_20;
            }
            
            goto label_21;
            label_19:
            var val_10 = val_8;
            val_10 = val_10 + 1;
            val_10 = val_10 + val_10;
            val_10 = val_10 + 272;
            label_21:
            if((val_11.GetAvailableAdsForStage(stage:  0, data:  val_8)) >= 1)
            {
                    if(this.ads != null)
            {
                    return this.ads.IsReady();
            }
            
                return this.ads.IsReady();
            }
            
            val_9 = 0;
            return (bool)val_9;
        }
        private void Start()
        {
            this.ads.OnAdFinished.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void TzarGames.Endless.AdsRewardUI::adsFinished()));
            this.ads.OnAdSkipped.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void TzarGames.Endless.AdsRewardUI::OnAddCancelled()));
            this.getRewardButton.SetActive(value:  false);
        }
        public override void NotifyShown()
        {
            this.NotifyShown();
            if(this.rewardWindow == null)
            {
                
            }
        
        }
        private void OnAddCancelled()
        {
            if(this.mainWindow == null)
            {
                
            }
        
        }
        private void adsFinished()
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.giveReward(checkChance:  true, maxItems:  2147483647));
        }
        public void WatchAd()
        {
            if(this.AdsAvailable == false)
            {
                    return;
            }
            
            this.ads.ShowAd();
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator giveReward(bool checkChance, int maxItems = 2147483647)
        {
            if(null != 0)
            {
                    typeof(AdsRewardUI.<giveReward>c__Iterator0).__il2cppRuntimeField_38 = checkChance;
                typeof(AdsRewardUI.<giveReward>c__Iterator0).__il2cppRuntimeField_3C = maxItems;
            }
            else
            {
                    mem[56] = checkChance;
                typeof(AdsRewardUI.<giveReward>c__Iterator0).__il2cppRuntimeField_3C = maxItems;
            }
            
            typeof(AdsRewardUI.<giveReward>c__Iterator0).__il2cppRuntimeField_68 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        [UnityEngine.ContextMenu]
        private void test()
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.giveReward(checkChance:  false, maxItems:  5));
        }
    
    }

}
