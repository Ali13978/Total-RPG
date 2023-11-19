using UnityEngine;

namespace TzarGames.TzarHero
{
    public class CharacterGroupEventHandler : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private System.Collections.Generic.List<TzarGames.TzarHero.TH_Character> characters;
        [UnityEngine.SerializeField]
        private UnityEngine.Events.UnityEvent OnAllDead;
        
        // Methods
        public CharacterGroupEventHandler()
        {
        
        }
        private void Start()
        {
            var val_4;
            var val_5;
            this.checkCharacters();
            List.Enumerator<T> val_1 = this.characters.GetEnumerator();
            label_4:
            if((0 & 1) == 0)
            {
                goto label_2;
            }
            
            TH_Character.dlgDeadEvent val_3 = new TH_Character.dlgDeadEvent(object:  this, method:  System.Void TzarGames.TzarHero.CharacterGroupEventHandler::onCharacterDead(TzarGames.TzarHero.DeadEventData deadEventData));
            0.InitializationCallback.add_OnCharacterDead(value:  null);
            goto label_4;
            label_2:
            val_4 = 0;
            val_5 = 1;
            0.Dispose();
            if((val_5 & 1) != 0)
            {
                    return;
            }
            
            if(val_4 == 0)
            {
                    return;
            }
        
        }
        private void checkCharacters()
        {
            UnityEngine.Object val_5;
            System.Collections.Generic.List<TzarGames.TzarHero.TH_Character> val_5 = this.characters;
            val_5 = val_5.Count - 1;
            if((val_5 & 2147483648) != 0)
            {
                    return;
            }
            
            do
            {
                val_5 = this.characters.Item[val_5];
                if(0 == val_5)
            {
                    val_5 = this.characters;
                val_5.RemoveAt(index:  val_5);
            }
            
                val_5 = val_5 - 1;
            }
            while((val_5 & 2147483648) == 0);
        
        }
        private void OnDestroy()
        {
            var val_4;
            var val_5;
            this.checkCharacters();
            List.Enumerator<T> val_1 = this.characters.GetEnumerator();
            label_4:
            if((0 & 1) == 0)
            {
                goto label_2;
            }
            
            TH_Character.dlgDeadEvent val_3 = new TH_Character.dlgDeadEvent(object:  this, method:  System.Void TzarGames.TzarHero.CharacterGroupEventHandler::onCharacterDead(TzarGames.TzarHero.DeadEventData deadEventData));
            0.InitializationCallback.remove_OnCharacterDead(value:  null);
            goto label_4;
            label_2:
            val_4 = 0;
            val_5 = 1;
            0.Dispose();
            if((val_5 & 1) != 0)
            {
                    return;
            }
            
            if(val_4 == 0)
            {
                    return;
            }
        
        }
        private void onCharacterDead(TzarGames.TzarHero.DeadEventData deadEventData)
        {
            object val_7;
            dlgDeadEvent val_8;
            var val_9;
            var val_10;
            val_7 = this;
            this.checkCharacters();
            TH_Character.dlgDeadEvent val_1 = null;
            val_8 = val_1;
            val_1 = new TH_Character.dlgDeadEvent(object:  this, method:  System.Void TzarGames.TzarHero.CharacterGroupEventHandler::onCharacterDead(TzarGames.TzarHero.DeadEventData deadEventData));
            deadEventData.Victim.remove_OnCharacterDead(value:  val_8);
            if(this.characters.Count < 1)
            {
                    return;
            }
            
            List.Enumerator<T> val_3 = this.characters.GetEnumerator();
            label_8:
            if((0 & 1) == 0)
            {
                goto label_6;
            }
            
            if(0.InitializationCallback.isDead == true)
            {
                goto label_8;
            }
            
            val_9 = 0;
            val_8 = 0;
            val_10 = 1;
            goto label_9;
            label_6:
            val_9 = 0;
            val_10 = 1;
            val_8 = 1;
            label_9:
            0.Dispose();
            if(val_8 == 0)
            {
                    return;
            }
            
            val_7 = this.OnAllDead;
            val_7.Invoke();
        }
    
    }

}
