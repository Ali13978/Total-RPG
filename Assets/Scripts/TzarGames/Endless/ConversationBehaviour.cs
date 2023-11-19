using UnityEngine;

namespace TzarGames.Endless
{
    public class ConversationBehaviour : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Endless.ConversationData _conversation;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.UI.DialogueUI dialogueUI;
        private TzarGames.Endless.ConversationData currentConversationData;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private System.Action<TzarGames.Endless.ConversationData> OnConversationStopped;
        
        // Methods
        public ConversationBehaviour()
        {
        
        }
        public void add_OnConversationStopped(System.Action<TzarGames.Endless.ConversationData> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnConversationStopped);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921510591237600 != this.OnConversationStopped);
        
        }
        public void remove_OnConversationStopped(System.Action<TzarGames.Endless.ConversationData> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnConversationStopped);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921510591374176 != this.OnConversationStopped);
        
        }
        private void Start()
        {
            this.dialogueUI.add_OnClosed(value:  new System.Action(object:  this, method:  public System.Void TzarGames.Endless.ConversationBehaviour::StopConversation()));
        }
        private void OnDestroy()
        {
            if(0 == this.dialogueUI)
            {
                    return;
            }
            
            this.dialogueUI.remove_OnClosed(value:  new System.Action(object:  this, method:  public System.Void TzarGames.Endless.ConversationBehaviour::StopConversation()));
        }
        [UnityEngine.ContextMenu]
        public void StartConversation()
        {
            this.StartConversation(conversation:  this._conversation);
        }
        public void StartConversation(TzarGames.Endless.ConversationData conversation)
        {
            this.currentConversationData = conversation;
            this.dialogueUI.ShowDialogue(data:  conversation);
            if(0 == TzarGames.Endless.EndlessGameState._instance)
            {
                    return;
            }
            
            TzarGames.Endless.EndlessGameState._instance.paused = true;
            UnityEngine.Time.timeScale = 0f;
        }
        public void StopConversation()
        {
            if(0 == this.currentConversationData)
            {
                    return;
            }
            
            this.dialogueUI.Close();
            if(0 != TzarGames.Endless.EndlessGameState._instance)
            {
                    TzarGames.Endless.EndlessGameState._instance.paused = false;
                UnityEngine.Time.timeScale = 1f;
            }
            
            if(this.OnConversationStopped != null)
            {
                    this.OnConversationStopped.Invoke(obj:  this.currentConversationData);
            }
            
            this.currentConversationData = 0;
        }
    
    }

}
