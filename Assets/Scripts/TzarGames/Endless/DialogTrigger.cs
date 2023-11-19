using UnityEngine;

namespace TzarGames.Endless
{
    public class DialogTrigger : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Endless.ConversationBehaviour conversationHandler;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.ConversationData conversation;
        [UnityEngine.SerializeField]
        private bool triggerOnce;
        private const string dialogTriggerKey = "DLG_TRG_KEY_";
        
        // Methods
        public DialogTrigger()
        {
        
        }
        private string getKey(int conversationId)
        {
            return (string)0 + "DLG_TRG_KEY_";
        }
        public void TriggerDialog(TzarGames.TzarHero.TH_Character character)
        {
            string val_10;
            var val_11;
            var val_12;
            if(character.PlayerOwner != null)
            {
                    if(character.PlayerOwner.itsMe == false)
            {
                    return;
            }
            
            }
            
            if((this.triggerOnce == false) || (0 == TzarGames.Endless.EndlessGameState._instance))
            {
                goto label_10;
            }
            
            if(null == 0)
            {
                goto label_12;
            }
            
            val_12 = SelectedCharacter;
            if(val_12 != null)
            {
                goto label_13;
            }
            
            goto label_14;
            label_12:
            val_12 = 0;
            label_14:
            val_11 = 0;
            label_13:
            if(mem[282584257676929] == 0)
            {
                goto label_18;
            }
            
            var val_9 = mem[282584257676823];
            var val_10 = 0;
            val_9 = val_9 + 8;
            label_17:
            if(((mem[282584257676823] + 8) + -8) == null)
            {
                goto label_16;
            }
            
            val_10 = val_10 + 1;
            val_9 = val_9 + 16;
            if(val_10 < mem[282584257676929])
            {
                goto label_17;
            }
            
            goto label_18;
            label_16:
            var val_11 = val_9;
            val_11 = val_11 + 6;
            val_11 = val_11 + val_11;
            val_11 = val_11 + 272;
            label_18:
            val_10 = this.conversation.getKey(conversationId:  this.conversation);
            if((val_12.HasInt(id:  val_10)) != false)
            {
                    return;
            }
            
            val_12.SetInt(id:  val_10, val:  1);
            label_10:
            this.conversationHandler.StartConversation(conversation:  this.conversation);
        }
    
    }

}
