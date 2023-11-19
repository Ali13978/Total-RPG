using UnityEngine;

namespace TzarGames.Endless
{
    public class DamageBoostUI : GameUIBase
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.RectTransform iconContainer;
        [UnityEngine.SerializeField]
        private UnityEngine.UI.Image iconFillImage;
        private TzarGames.Endless.PlayerCharacter _playerCharacter;
        
        // Methods
        public DamageBoostUI()
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
            float val_14;
            if(0 == this._playerCharacter)
            {
                    return;
            }
            
            TzarGames.Endless.DamageBoostTimer val_3 = this._playerCharacter.DamageBoost;
            if((val_3 != null) && (val_3 != null))
            {
                    if(val_3.IsStopped == false)
            {
                goto label_7;
            }
            
            }
            
            if(this.iconContainer.gameObject.activeSelf == false)
            {
                    return;
            }
            
            this.iconContainer.gameObject.SetActive(value:  false);
            return;
            label_7:
            val_13 = this.iconContainer.gameObject;
            if(val_13.activeSelf != true)
            {
                    val_13 = this.iconContainer.gameObject;
                val_13.SetActive(value:  true);
            }
            
            if(val_13 != null)
            {
                    val_14 = val_13.NormalizedTime;
            }
            else
            {
                    val_14 = 0f;
            }
            
            this.iconFillImage.fillAmount = val_14;
        }
    
    }

}
