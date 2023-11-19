using UnityEngine;

namespace TzarGames.Endless
{
    public class HammerReward : Reward
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.Item item;
        [UnityEngine.SerializeField]
        private int count;
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedStringAsset message;
        
        // Properties
        public int Count { get; }
        
        // Methods
        public HammerReward()
        {
            this.count = 1;
        }
        public int get_Count()
        {
            return (int)this.count;
        }
        public override void ProcessReward(int count)
        {
            this.ProcessReward(count:  count);
            TzarGames.Endless.PlayerCharacter val_1 = TzarGames.Endless.EndlessGameManager.LocalPlayerCharacter;
            if(0 == val_1)
            {
                    UnityEngine.Debug.LogError(message:  0);
                return;
            }
            
            val_1.TemplateInstance.Inventory.DefaultBag.AddConsumableItem(item:  this.item, count:  count);
            if(TzarGames.Endless.EndlessGameState.Instance.IsItSafeStateToSaveGame() == false)
            {
                    return;
            }
            
            TzarGames.Endless.EndlessGameManager.SetHeroDataToGameState();
        }
        public override bool CanRewardedInGameState()
        {
            return true;
        }
        public override bool CanRewardedInMainMenu()
        {
            return false;
        }
        public override bool IsReadyToProcess()
        {
            if(this.IsReadyToProcess() == false)
            {
                    return false;
            }
            
            return UnityEngine.Object.op_Inequality(x:  0, y:  TzarGames.Endless.EndlessGameManager.LocalPlayerCharacter);
        }
        public override string GetRewardMessage(int count)
        {
            return (string)System.String.Format(format:  0, arg0:  TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0));
        }
    
    }

}
