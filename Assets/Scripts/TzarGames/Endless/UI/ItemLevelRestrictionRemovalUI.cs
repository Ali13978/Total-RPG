using UnityEngine;

namespace TzarGames.Endless.UI
{
    public class ItemLevelRestrictionRemovalUI : GameUIBase
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedStringAsset removalText;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI removalTextUi;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI levelWarning;
        [UnityEngine.SerializeField]
        private UnityEngine.Events.UnityEvent onSuccess;
        [UnityEngine.SerializeField]
        private UnityEngine.Events.UnityEvent onNotEnoughResource;
        
        // Methods
        public ItemLevelRestrictionRemovalUI()
        {
        
        }
        public void ShowWarning(bool show)
        {
            show = show;
            this.levelWarning.enabled = show;
        }
        public override void NotifyShown()
        {
            this.NotifyShown();
            ulong val_2 = TzarGames.Endless.ItemLevelRestrictionRemoval.RubyCost;
            this.removalTextUi.text = System.String.Format(format:  0, arg0:  TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0));
        }
        public void BuyRemoval()
        {
            TzarGames.GameFramework.IPlayerComponent val_10;
            UnityEngine.Events.UnityEvent val_11;
            TzarGames.GameFramework.Player val_3 = this.PlayerOwner;
            val_10 = val_3.PlayerComponent;
            if(val_10 != null)
            {
                
            }
            
            val_10 = 0;
            TzarGames.Endless.EndlessPlayerCharacterTemplate val_8 = val_10.PlayerTemplateInstance;
            if((TzarGames.Endless.ItemLevelRestrictionRemoval.RemoveItemLevelRestriction(characterInfo:  0, template:  TzarGames.Endless.EndlessGameState.Instance.SelectedCharacter)) == 0)
            {
                goto label_11;
            }
            
            val_11 = this.onNotEnoughResource;
            if(val_11 != null)
            {
                goto label_14;
            }
            
            goto label_13;
            label_11:
            val_11 = this.onSuccess;
            if(val_11 != null)
            {
                goto label_14;
            }
            
            label_13:
            label_14:
            val_11.Invoke();
        }
    
    }

}
