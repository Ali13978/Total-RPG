using UnityEngine;

namespace TzarGames.Endless
{
    public class AddInsectSpikeInfluence : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.TzarHero.ArrowProjectile projectile;
        [UnityEngine.SerializeField]
        private float speedMultiplier;
        [UnityEngine.SerializeField]
        private float effectTime;
        
        // Methods
        public AddInsectSpikeInfluence()
        {
            this.speedMultiplier = 0.5f;
            this.effectTime = 2.552118E+38f;
        }
        private void Reset()
        {
            this.projectile = this.GetComponent<TzarGames.TzarHero.ArrowProjectile>();
        }
        private void Awake()
        {
            this.projectile.add_OnCharacterTakeHit(value:  new System.Action<TzarGames.TzarHero.CharacterDamageInfo>(object:  this, method:  System.Void TzarGames.Endless.AddInsectSpikeInfluence::onCharacterTakeHit(TzarGames.TzarHero.CharacterDamageInfo info)));
        }
        private void OnDestroy()
        {
            if(0 == this.projectile)
            {
                    return;
            }
            
            this.projectile.remove_OnCharacterTakeHit(value:  new System.Action<TzarGames.TzarHero.CharacterDamageInfo>(object:  this, method:  System.Void TzarGames.Endless.AddInsectSpikeInfluence::onCharacterTakeHit(TzarGames.TzarHero.CharacterDamageInfo info)));
        }
        private void onCharacterTakeHit(TzarGames.TzarHero.CharacterDamageInfo info)
        {
            var val_6;
            TzarGames.TzarHero.TH_Character val_1 = info.Victim;
            if((val_1.TryGetFirstInfluenceOfType<AddInsectSpikeInfluence.InsectSpikeInfluence>()) != null)
            {
                    val_6 = null;
                val_6 = null;
            }
            else
            {
                    val_1.AddInfluence(influence:  new AddInsectSpikeInfluence.InsectSpikeInfluence(speedMultiplier:  this.speedMultiplier, instigator:  info.Instigator, effectTime:  this.effectTime));
                return;
            }
            
            ResetTimer();
        }
    
    }

}
