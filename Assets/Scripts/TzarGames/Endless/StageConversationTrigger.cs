using UnityEngine;

namespace TzarGames.Endless
{
    public class StageConversationTrigger : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private float delay;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.StageConversastionInfo[] conversations;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.ConversationBehaviour _conversationBehaviour;
        [UnityEngine.SerializeField]
        private UnityEngine.Events.UnityEvent onConversationActivated;
        [UnityEngine.SerializeField]
        private UnityEngine.Events.UnityEvent onConversationStarted;
        [UnityEngine.SerializeField]
        private UnityEngine.Events.UnityEvent onNoActiveConversation;
        private const string stageConversationKey = "CONVERSATION_TRIGGERED_";
        
        // Methods
        public StageConversationTrigger()
        {
            this.delay = 1f;
        }
        private bool isTriggered(TzarGames.Common.SerializableData data, int conversationId)
        {
            if(data != null)
            {
                    return data.HasString(id:  this.getTriggeredKey(conversationId:  conversationId));
            }
            
            return data.HasString(id:  this.getTriggeredKey(conversationId:  conversationId));
        }
        private string getTriggeredKey(int conversationId)
        {
            return (string)0 + "CONVERSATION_TRIGGERED_";
        }
        private void setTriggeredFlag(TzarGames.Common.SerializableData data, int conversationId)
        {
            data.SetString(id:  this.getTriggeredKey(conversationId:  conversationId), stringValue:  "yes");
        }
        private void deleteTriggeredFlag(TzarGames.Common.SerializableData data, int conversationId)
        {
            data.DeleteString(id:  this.getTriggeredKey(conversationId:  conversationId));
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator Start()
        {
            typeof(StageConversationTrigger.<Start>c__Iterator0).__il2cppRuntimeField_30 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        private void OnDestroy()
        {
            if(0 == this._conversationBehaviour)
            {
                    return;
            }
            
            this._conversationBehaviour.remove_OnConversationStopped(value:  new System.Action<TzarGames.Endless.ConversationData>(object:  this, method:  System.Void TzarGames.Endless.StageConversationTrigger::OnConversationStopped(TzarGames.Endless.ConversationData obj)));
        }
        private void OnConversationStopped(TzarGames.Endless.ConversationData obj)
        {
            var val_4 = 0;
            do
            {
                if(val_4 >= this.conversations.Length)
            {
                    return;
            }
            
                TzarGames.Endless.StageConversastionInfo val_3 = this.conversations[0];
                val_4 = val_4 + 1;
            }
            while(0 != this.conversations[0x0][0].Conversation);
            
            this.conversations[0x0][0].OnConversationFinished.Invoke();
        }
    
    }

}
