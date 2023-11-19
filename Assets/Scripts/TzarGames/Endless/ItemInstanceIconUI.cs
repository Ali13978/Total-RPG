using UnityEngine;

namespace TzarGames.Endless
{
    public class ItemInstanceIconUI : GameUIBase
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.GameFramework.Item item;
        [UnityEngine.SerializeField]
        private UnityEngine.RectTransform iconContainer;
        private TzarGames.Endless.PlayerCharacter _playerCharacter;
        
        // Methods
        public ItemInstanceIconUI()
        {
        
        }
        protected override void OnPlayerOwnerSet(TzarGames.GameFramework.Player owner)
        {
            var val_2;
            this.OnPlayerOwnerSet(owner:  owner);
            val_2 = 0;
            this._playerCharacter = ;
            this.updateIcon();
        }
        public override void NotifyShown()
        {
            this.NotifyShown();
            this.updateIcon();
        }
        private void updateIcon()
        {
            int val_12;
            var val_13;
            var val_14;
            val_12 = this.item;
            System.Collections.Generic.List<TzarGames.GameFramework.ItemInstance> val_4 = this._playerCharacter.TemplateInstance.Inventory.DefaultBag.GetAllItemInstancesById(id:  val_12);
            if((val_4 != null) && (val_4.Count != 0))
            {
                    val_12 = this._playerCharacter.TemplateInstance;
                val_13 = val_12.IsItemActivated(item:  val_4.Item[0]);
                UnityEngine.GameObject val_9 = this.iconContainer.gameObject;
                val_14 = val_13;
            }
            else
            {
                    val_13 = this.iconContainer.gameObject;
                val_14 = 0;
            }
            
            val_13.SetActive(value:  false);
        }
    
    }

}
