using UnityEngine;

namespace TzarGames.Endless
{
    public class SpeedBoostUI : GameUIBase
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.RectTransform iconContainer;
        [UnityEngine.SerializeField]
        private UnityEngine.UI.Image iconFillImage;
        private TzarGames.Endless.PlayerCharacter _playerCharacter;
        
        // Methods
        public SpeedBoostUI()
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
            var val_13;
            if(0 == this._playerCharacter)
            {
                    return;
            }
            
            TzarGames.Endless.SpeedBoostTimer val_3 = this._playerCharacter.SpeedBoost;
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
            val_13 = this.iconContainer.gameObject;
            if(val_13.activeSelf != true)
            {
                    val_13 = this.iconContainer.gameObject;
                val_13.SetActive(value:  true);
            }
            
            this.iconFillImage.fillAmount = val_3.NormalizedTime;
        }
    
    }

}
