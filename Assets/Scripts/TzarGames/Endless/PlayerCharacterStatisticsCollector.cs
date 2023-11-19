using UnityEngine;

namespace TzarGames.Endless
{
    public class PlayerCharacterStatisticsCollector : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Endless.PlayerCharacter character;
        
        // Methods
        public PlayerCharacterStatisticsCollector()
        {
        
        }
        private TzarGames.Endless.CharacterStatistics GetStatistics()
        {
            var val_6;
            TzarGames.Endless.EndlessGameState val_1 = TzarGames.Endless.EndlessGameState.Instance;
            if(0 == val_1)
            {
                    return 0;
            }
            
            var val_6 = 0;
            val_6 = val_6 + 1;
            val_6 = val_1.SelectedCharacter;
        }
        private void Reset()
        {
            this.character = this.GetComponent<TzarGames.Endless.PlayerCharacter>();
        }
        private void Start()
        {
            this.character.add_OnCharacterDead(value:  new TH_Character.dlgDeadEvent(object:  this, method:  public System.Void TzarGames.Endless.PlayerCharacterStatisticsCollector::OnDead(TzarGames.TzarHero.DeadEventData characterDeadEvent)));
            this.character.add_OnHitOtherCharacter(value:  new TH_Character.dlgHitEvent(object:  this, method:  System.Void TzarGames.Endless.PlayerCharacterStatisticsCollector::Character_OnHitOtherCharacter(TzarGames.TzarHero.ICharacterDamageInfo hitData)));
            this.character.add_OnHitBlockedByShield(value:  new System.Action<TzarGames.TzarHero.ICharacterDamageInfo>(object:  this, method:  System.Void TzarGames.Endless.PlayerCharacterStatisticsCollector::Character_OnHitBlockedByShield(TzarGames.TzarHero.ICharacterDamageInfo obj)));
        }
        private void Character_OnHitBlockedByShield(TzarGames.TzarHero.ICharacterDamageInfo obj)
        {
            if(this.GetStatistics() == null)
            {
                    return;
            }
            
            int val_2 = val_1.ShieldBlocks;
            val_2 = val_2 + 1;
            val_1.ShieldBlocks = val_2;
        }
        private void Character_OnHitOtherCharacter(TzarGames.TzarHero.ICharacterDamageInfo hitData)
        {
            var val_3;
            if(this.GetStatistics() == null)
            {
                    return;
            }
            
            int val_3 = val_1.Hits;
            val_3 = val_3 + 1;
            val_1.Hits = val_3;
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_3 = hitData;
            if((hitData & 1) == 0)
            {
                    return;
            }
            
            int val_5 = val_1.CriticalHits;
            val_5 = val_5 + 1;
            val_1.CriticalHits = val_5;
        }
        public void OnDead(TzarGames.TzarHero.DeadEventData characterDeadEvent)
        {
            if(this.GetStatistics() == null)
            {
                    return;
            }
            
            int val_2 = val_1.Deaths;
            val_2 = val_2 + 1;
            val_1.Deaths = val_2;
        }
    
    }

}
