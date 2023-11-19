using UnityEngine;

namespace TzarGames.Endless
{
    public class Rewarder : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private System.Collections.Generic.List<TzarGames.Endless.Reward> rewards;
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedStringAsset rubyRewardMessage;
        private const string fullGameRewardKey = "FULL_GAME_REWARD_";
        private const string commonRubyKey = "COMMON_RUBY_REWARD";
        private const string customRewardPrefix = "CUSTOM_REWARD_";
        public TzarGames.Common.Events.StringEvent OnCustomReward;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private static System.Action<int> OnRubiesRewarded;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private static TzarGames.Endless.Rewarder <Instance>k__BackingField;
        private UnityEngine.Coroutine cacheRewardCoroutine;
        
        // Properties
        public static TzarGames.Endless.Rewarder Instance { get; set; }
        
        // Methods
        public Rewarder()
        {
        
        }
        public static void add_OnRubiesRewarded(System.Action<int> value)
        {
            var val_3;
            System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  TzarGames.Endless.Rewarder.OnRubiesRewarded);
            val_3 = 0;
            if(val_1 == null)
            {
                    return;
            }
            
            val_3 = val_1;
            if(null == null)
            {
                    return;
            }
            
            val_3 = 0;
        }
        public static void remove_OnRubiesRewarded(System.Action<int> value)
        {
            var val_3;
            System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  TzarGames.Endless.Rewarder.OnRubiesRewarded);
            val_3 = 0;
            if(val_1 == null)
            {
                    return;
            }
            
            val_3 = val_1;
            if(null == null)
            {
                    return;
            }
            
            val_3 = 0;
        }
        public static TzarGames.Endless.Rewarder get_Instance()
        {
            return (TzarGames.Endless.Rewarder)TzarGames.Endless.Rewarder.<Instance>k__BackingField;
        }
        private static void set_Instance(TzarGames.Endless.Rewarder value)
        {
            TzarGames.Endless.Rewarder.<Instance>k__BackingField = X1;
        }
        private void Awake()
        {
            if(0 != (TzarGames.Endless.Rewarder.<Instance>k__BackingField))
            {
                    UnityEngine.Debug.LogError(message:  0);
                UnityEngine.GameObject val_2 = this.gameObject;
                UnityEngine.Object.Destroy(obj:  0);
                return;
            }
            
            TzarGames.Endless.Rewarder.<Instance>k__BackingField = this;
            System.Action val_3 = new System.Action(object:  this, method:  System.Void TzarGames.Endless.Rewarder::checkRewards());
            TzarGames.Endless.EndlessGameState.add_OnLobbyLoaded(value:  0);
            System.Action val_4 = new System.Action(object:  this, method:  System.Void TzarGames.Endless.Rewarder::checkRewards());
            TzarGames.Endless.EndlessGameState.add_OnMainMenuLoaded(value:  0);
            System.Action val_5 = new System.Action(object:  this, method:  System.Void TzarGames.Endless.Rewarder::EndlessInAppManager_OnGamePurchased());
            TzarGames.Endless.EndlessInAppManager.add_OnGamePurchased(value:  0);
        }
        private void checkRewards()
        {
            this.tryRewardCachedRubies();
            if(this.cacheRewardCoroutine != null)
            {
                    this.StopCoroutine(routine:  this.cacheRewardCoroutine);
            }
            
            this.cacheRewardCoroutine = this.StartCoroutine(routine:  this.tryRewardCachedRewards());
        }
        private void OnDestroy()
        {
            if(0 != (TzarGames.Endless.Rewarder.<Instance>k__BackingField))
            {
                    return;
            }
            
            TzarGames.Endless.Rewarder.<Instance>k__BackingField = 0;
            System.Action val_2 = new System.Action(object:  this, method:  System.Void TzarGames.Endless.Rewarder::tryRewardCachedRubies());
            TzarGames.Endless.EndlessGameState.remove_OnLobbyLoaded(value:  0);
            System.Action val_3 = new System.Action(object:  this, method:  System.Void TzarGames.Endless.Rewarder::tryRewardCachedRubies());
            TzarGames.Endless.EndlessGameState.remove_OnMainMenuLoaded(value:  0);
        }
        private void EndlessInAppManager_OnGamePurchased()
        {
            this.CheckAndRewardForFullGame();
        }
        public void CheckAndRewardForFullGame()
        {
            if(0 == TzarGames.Endless.EndlessGameState.Instance)
            {
                    return;
            }
            
            if(TzarGames.Endless.EndlessGameState.Instance.IsGamePurchased() == false)
            {
                    return;
            }
            
            TzarGames.Common.SerializableData val_7 = TzarGames.Endless.EndlessGameState.Instance.CommonSaveGameData;
            if(val_7 == null)
            {
                    return;
            }
            
            if((val_7.HasInt(id:  "FULL_GAME_REWARD_")) != false)
            {
                    return;
            }
            
            val_7.SetInt(id:  "FULL_GAME_REWARD_", val:  1);
            UnityEngine.Coroutine val_11 = this.StartCoroutine(routine:  this.rewardRubies_internal(rubyCount:  5));
        }
        private static string buildCustomRewardName(string rewardName)
        {
            return 0 + "CUSTOM_REWARD_";
        }
        public void ProcessUniqueReward(TzarGames.Endless.Reward reward)
        {
            if((this.CanGetReward(reward:  reward)) == false)
            {
                    return;
            }
            
            TzarGames.Endless.EndlessGameState.Instance.CommonSaveGameData.SetInt(id:  TzarGames.Endless.Rewarder.buildCustomRewardName(rewardName:  reward.Name), val:  1);
            this.ProcessReward(reward:  reward, count:  1);
        }
        public bool CanGetReward(TzarGames.Endless.Reward reward)
        {
            bool val_5 = TzarGames.Endless.EndlessGameState.Instance.CommonSaveGameData.HasInt(id:  TzarGames.Endless.Rewarder.buildCustomRewardName(rewardName:  reward.Name));
            val_5 = (~val_5) & 1;
            return (bool)val_5;
        }
        public void ProcessRubyReward(TzarGames.Endless.RubyReward reward)
        {
            TzarGames.Endless.EndlessGameState.Instance.CommonSaveGameData.SetInt(id:  TzarGames.Endless.Rewarder.buildCustomRewardName(rewardName:  reward.Name), val:  1);
            this.RewardRubies(rubyCount:  reward.rubyCount);
            this.OnCustomReward.Invoke(arg0:  reward.Name);
        }
        public void RewardRubies(int rubyCount)
        {
            if(rubyCount < 1)
            {
                    return;
            }
            
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.rewardRubies_internal(rubyCount:  rubyCount));
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator rewardRubies_internal(int rubyCount)
        {
            if(null != 0)
            {
                    typeof(Rewarder.<rewardRubies_internal>c__Iterator0).__il2cppRuntimeField_10 = rubyCount;
            }
            else
            {
                    mem[16] = rubyCount;
            }
            
            typeof(Rewarder.<rewardRubies_internal>c__Iterator0).__il2cppRuntimeField_28 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        private void tryRewardCachedRubies()
        {
            var val_11;
            int val_12;
            var val_13;
            var val_14;
            TzarGames.Endless.EndlessGameState val_1 = TzarGames.Endless.EndlessGameState.Instance;
            if(val_1.IsItSafeStateToSaveGame() == false)
            {
                    return;
            }
            
            if(val_1.SelectedCharacter == null)
            {
                    return;
            }
            
            val_11 = val_1.CommonSaveGameData;
            if((val_11.HasInt(id:  "COMMON_RUBY_REWARD")) == false)
            {
                    return;
            }
            
            if(val_11 != null)
            {
                    val_12 = val_11.GetInt(id:  "COMMON_RUBY_REWARD");
            }
            else
            {
                    val_12 = 0.GetInt(id:  "COMMON_RUBY_REWARD");
            }
            
            val_13 = 0;
            val_11.DeleteInt(id:  "COMMON_RUBY_REWARD");
            if(val_12 < 1)
            {
                    return;
            }
            
            val_11 = TzarGames.Endless.EndlessGameState.Instance.SelectedCharacter;
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_13 = 5;
            val_14 = val_11;
            val_1.SaveGame();
            if(TzarGames.Endless.Rewarder.OnRubiesRewarded == null)
            {
                    return;
            }
            
            TzarGames.Endless.Rewarder.OnRubiesRewarded.Invoke(obj:  val_12);
        }
        public void ProcessReward(TzarGames.Endless.Reward reward)
        {
            this.ProcessReward(reward:  reward, count:  1);
        }
        public void ProcessReward(TzarGames.Endless.Reward reward, int count)
        {
            if(count < 1)
            {
                    return;
            }
            
            if((this.rewards.Contains(item:  reward)) != true)
            {
                    this.rewards.Add(item:  reward);
            }
            
            UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.reward_internal(reward:  reward, count:  count));
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator reward_internal(TzarGames.Endless.Reward reward, int count)
        {
            if(null != 0)
            {
                    typeof(Rewarder.<reward_internal>c__Iterator1).__il2cppRuntimeField_10 = count;
                typeof(Rewarder.<reward_internal>c__Iterator1).__il2cppRuntimeField_20 = reward;
            }
            else
            {
                    mem[16] = count;
                mem[32] = reward;
            }
            
            typeof(Rewarder.<reward_internal>c__Iterator1).__il2cppRuntimeField_38 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator tryRewardCachedRewards()
        {
            typeof(Rewarder.<tryRewardCachedRewards>c__Iterator2).__il2cppRuntimeField_30 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
    
    }

}
