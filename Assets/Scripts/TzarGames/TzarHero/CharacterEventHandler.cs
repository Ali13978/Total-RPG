using UnityEngine;

namespace TzarGames.TzarHero
{
    public class CharacterEventHandler : MonoBehaviour, IPoolable
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.TzarHero.TH_Character character;
        [UnityEngine.SerializeField]
        private UnityEngine.Events.UnityEvent OnAttackStart;
        public TzarGames.TzarHero.CharacterEvent OnSpawn;
        public TzarGames.TzarHero.CharacterDeadEvent OnDead;
        public TzarGames.TzarHero.CharacterEvent OnAlive;
        public TzarGames.TzarHero.CharacterHitEvent OnTakeHit;
        public TzarGames.TzarHero.CharacterEvent OnLevelUp;
        public TzarGames.GameFramework.Events.ItemTakeEvent OnTakeItem;
        
        // Methods
        public CharacterEventHandler()
        {
        
        }
        private void Reset()
        {
            if(0 != this.character)
            {
                    return;
            }
            
            this.character = this.GetComponent<TzarGames.TzarHero.TH_Character>();
        }
        private void OnEnable()
        {
            this.character.add_OnSpawn(value:  new TH_Character.dlgCharacterEvent(object:  this, method:  System.Void TzarGames.TzarHero.CharacterEventHandler::onSpawnHandler(TzarGames.TzarHero.TH_Character spawnedCharacter)));
            this.character.add_OnCharacterDead(value:  new TH_Character.dlgDeadEvent(object:  this, method:  System.Void TzarGames.TzarHero.CharacterEventHandler::onDeadHandler(TzarGames.TzarHero.DeadEventData data)));
            this.character.add_OnCharacterAlive(value:  new TH_Character.dlgCharacterEvent(object:  this, method:  System.Void TzarGames.TzarHero.CharacterEventHandler::onCharacterAlive(TzarGames.TzarHero.TH_Character character)));
            this.character.add_OnCharacterTakeHit(value:  new TH_Character.dlgHitEvent(object:  this, method:  System.Void TzarGames.TzarHero.CharacterEventHandler::onTakeHitHandler(TzarGames.TzarHero.ICharacterDamageInfo hitInfo)));
            this.character.add_OnStartAttack(value:  new TzarGames.Common.TG_VoidDelegate(object:  this, method:  System.Void TzarGames.TzarHero.CharacterEventHandler::onStartAttackHandler()));
            this.character.add_OnCharacterLevelUp(value:  new TH_Character.dlgCharacterEvent(object:  this, method:  System.Void TzarGames.TzarHero.CharacterEventHandler::CharacterOnOnCharacterLevelUp(TzarGames.TzarHero.TH_Character character)));
            this.character.add_OnItemAddedToInventory(value:  new TH_Character.ItemTakeDelegate(object:  this, method:  System.Void TzarGames.TzarHero.CharacterEventHandler::OnItemAddedToInventory(TzarGames.GameFramework.ITakeItemEvent eventData)));
        }
        private void OnItemAddedToInventory(TzarGames.GameFramework.ITakeItemEvent eventData)
        {
            this.OnTakeItem.Invoke(arg0:  eventData);
        }
        private void CharacterOnOnCharacterLevelUp(TzarGames.TzarHero.TH_Character character)
        {
            this.OnLevelUp.Invoke(arg0:  character);
        }
        private void onCharacterAlive(TzarGames.TzarHero.TH_Character character)
        {
            this.OnAlive.Invoke(arg0:  character);
        }
        private void OnDisable()
        {
            this.character.remove_OnSpawn(value:  new TH_Character.dlgCharacterEvent(object:  this, method:  System.Void TzarGames.TzarHero.CharacterEventHandler::onSpawnHandler(TzarGames.TzarHero.TH_Character spawnedCharacter)));
            this.character.remove_OnCharacterDead(value:  new TH_Character.dlgDeadEvent(object:  this, method:  System.Void TzarGames.TzarHero.CharacterEventHandler::onDeadHandler(TzarGames.TzarHero.DeadEventData data)));
            this.character.remove_OnCharacterAlive(value:  new TH_Character.dlgCharacterEvent(object:  this, method:  System.Void TzarGames.TzarHero.CharacterEventHandler::onCharacterAlive(TzarGames.TzarHero.TH_Character character)));
            this.character.remove_OnCharacterTakeHit(value:  new TH_Character.dlgHitEvent(object:  this, method:  System.Void TzarGames.TzarHero.CharacterEventHandler::onTakeHitHandler(TzarGames.TzarHero.ICharacterDamageInfo hitInfo)));
            this.character.remove_OnStartAttack(value:  new TzarGames.Common.TG_VoidDelegate(object:  this, method:  System.Void TzarGames.TzarHero.CharacterEventHandler::onStartAttackHandler()));
            this.character.remove_OnCharacterLevelUp(value:  new TH_Character.dlgCharacterEvent(object:  this, method:  System.Void TzarGames.TzarHero.CharacterEventHandler::CharacterOnOnCharacterLevelUp(TzarGames.TzarHero.TH_Character character)));
            this.character.remove_OnItemAddedToInventory(value:  new TH_Character.ItemTakeDelegate(object:  this, method:  System.Void TzarGames.TzarHero.CharacterEventHandler::OnItemAddedToInventory(TzarGames.GameFramework.ITakeItemEvent eventData)));
        }
        private void onDeadHandler(TzarGames.TzarHero.DeadEventData data)
        {
            this.OnDead.Invoke(arg0:  data);
        }
        private void onTakeHitHandler(TzarGames.TzarHero.ICharacterDamageInfo hitInfo)
        {
            this.OnTakeHit.Invoke(arg0:  hitInfo);
        }
        private void onStartAttackHandler()
        {
            this.OnAttackStart.Invoke();
        }
        private void onSpawnHandler(TzarGames.TzarHero.TH_Character spawnedCharacter)
        {
            this.OnSpawn.Invoke(arg0:  spawnedCharacter);
        }
        public void OnPushedToPool()
        {
            this.enabled = false;
        }
        public void OnPulledFromPool()
        {
            this.enabled = true;
        }
    
    }

}
