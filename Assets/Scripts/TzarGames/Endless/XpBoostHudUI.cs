using UnityEngine;

namespace TzarGames.Endless
{
    public class XpBoostHudUI : GameUIBase
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.RectTransform iconContainer;
        [UnityEngine.SerializeField]
        private UnityEngine.Sprite goldBookSprite;
        [UnityEngine.SerializeField]
        private UnityEngine.Sprite bookSprite;
        [UnityEngine.SerializeField]
        private UnityEngine.UI.Image icon;
        [UnityEngine.SerializeField]
        private UnityEngine.UI.Image iconFillImage;
        private TzarGames.Endless.PlayerCharacter _playerCharacter;
        
        // Methods
        public XpBoostHudUI()
        {
        
        }
        protected override void OnPlayerOwnerSet(TzarGames.GameFramework.Player owner)
        {
            var val_2;
            this.OnPlayerOwnerSet(owner:  owner);
            val_2 = 0;
            this._playerCharacter = ;
        }
        private void Update()
        {
            UnityEngine.Object val_16;
            UnityEngine.Sprite val_17;
            if(0 == this._playerCharacter)
            {
                    return;
            }
            
            TzarGames.Endless.XpBoostTimer val_3 = this._playerCharacter.XpBoostTimer;
            if(val_3 != null)
            {
                    if(val_3.IsStopped == false)
            {
                goto label_6;
            }
            
            }
            
            if(this.iconContainer.gameObject.activeSelf == false)
            {
                    return;
            }
            
            this.iconContainer.gameObject.SetActive(value:  false);
            return;
            label_6:
            if(this.iconContainer.gameObject.activeSelf != true)
            {
                    this.iconContainer.gameObject.SetActive(value:  true);
            }
            
            val_16 = this.icon.sprite;
            if(val_3.goldMode == false)
            {
                goto label_18;
            }
            
            if(0 == val_16)
            {
                goto label_26;
            }
            
            val_16 = this.icon;
            val_17 = this.goldBookSprite;
            goto label_23;
            label_18:
            if(0 == val_16)
            {
                goto label_26;
            }
            
            val_16 = this.bookSprite;
            val_17 = val_16;
            label_23:
            this.icon.sprite = val_17;
            label_26:
            this.iconFillImage.fillAmount = val_3.NormalizedTime;
        }
    
    }

}
