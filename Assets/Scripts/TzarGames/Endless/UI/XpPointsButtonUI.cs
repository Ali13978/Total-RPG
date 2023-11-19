using UnityEngine;

namespace TzarGames.Endless.UI
{
    public class XpPointsButtonUI : GameUIBase
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI pointsCount;
        private TzarGames.Endless.PlayerCharacter playerCharacter;
        
        // Methods
        public XpPointsButtonUI()
        {
        
        }
        protected override void OnPlayerOwnerSet(TzarGames.GameFramework.Player owner)
        {
            var val_2;
            this.OnPlayerOwnerSet(owner:  owner);
            val_2 = 0;
            this.playerCharacter = ;
        }
        private void Update()
        {
            TzarGames.Common.UI.TextUI val_8;
            TzarGames.Common.UI.TextUI val_9;
            val_8 = this;
            if(0 == this.playerCharacter)
            {
                    return;
            }
            
            val_9 = this.pointsCount;
            bool val_5 = val_9.enabled;
            if(this.playerCharacter.PlayerTemplateInstance.AvailableUpgradePoints > 0)
            {
                    if(val_5 != true)
            {
                    val_9 = this.pointsCount;
                val_9.enabled = true;
            }
            
                val_8 = this.pointsCount;
                val_8.text = System.String.Format(format:  0, arg0:  "+{0}");
                return;
            }
            
            if(val_5 == false)
            {
                    return;
            }
            
            this.pointsCount.enabled = false;
        }
    
    }

}
