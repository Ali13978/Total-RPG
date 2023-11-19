using UnityEngine;

namespace TzarGames.Endless
{
    public class NotificationHandler : MonoBehaviour
    {
        // Fields
        private const string subjectKey = "SUBJECT";
        private const string rubyRewardKey = "DAILYRUBY";
        private const string hammerRewardKey = "DAILYHAMMER";
        private const string commonTopicKey = "FCM_COMMON_TOPIC";
        [UnityEngine.SerializeField]
        private bool debugMode;
        [UnityEngine.SerializeField]
        private string appId;
        [UnityEngine.SerializeField]
        private string googleProjectNumber;
        [UnityEngine.SerializeField]
        private UnityEngine.Events.UnityEvent OnDailyRuby;
        [UnityEngine.SerializeField]
        private UnityEngine.Events.UnityEvent OnDailyHammer;
        
        // Methods
        public NotificationHandler()
        {
        
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator Start()
        {
            typeof(NotificationHandler.<Start>c__Iterator0).__il2cppRuntimeField_10 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        private void Privacy_OnDataCollectionPermissionChanged(bool canCollectData)
        {
            bool val_1 = canCollectData;
            string val_2 = 0 + "Changing data collection settings for Firebase Messaging to ";
            UnityEngine.Debug.Log(message:  0);
            bool val_3 = canCollectData;
            Firebase.Messaging.FirebaseMessaging.TokenRegistrationOnInitEnabled = false;
            if(canCollectData != false)
            {
                    System.Threading.Tasks.Task val_6 = Firebase.Messaging.FirebaseMessaging.SubscribeAsync(topic:  0);
                return;
            }
            
            System.Threading.Tasks.Task val_7 = Firebase.Messaging.FirebaseMessaging.UnsubscribeAsync(topic:  0);
        }
        public void OnTokenReceived(object sender, Firebase.Messaging.TokenReceivedEventArgs token)
        {
            string val_1 = token.Token;
            string val_2 = 0 + "Received Registration Token: "("Received Registration Token: ");
            UnityEngine.Debug.Log(message:  0);
        }
        public void OnMessageReceived(object sender, Firebase.Messaging.MessageReceivedEventArgs e)
        {
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            val_12 = this;
            string val_2 = e.Message.From;
            val_13 = 0 + "Received a new message from: "("Received a new message from: ");
            UnityEngine.Debug.Log(message:  0);
            System.Collections.Generic.IDictionary<System.String, System.String> val_5 = e.Message.Data;
            if(val_5 == null)
            {
                    return;
            }
            
            var val_12 = 0;
            val_12 = val_12 + 1;
            val_14 = val_5;
            label_25:
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_15 = val_5;
            if(((val_5 & 1) & 1) == 0)
            {
                goto label_33;
            }
            
            var val_14 = 0;
            val_14 = val_14 + 1;
            val_16 = val_5;
            this.handleNotificationData(key:  val_5.InitializationCallback, value:  val_5);
            goto label_25;
            label_33:
            if(val_5 != null)
            {
                    var val_15 = 0;
                val_15 = val_15 + 1;
                val_17 = val_5;
            }
            
            if( == 115)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
        
        }
        private void handleNotificationData(string key, string value)
        {
            UnityEngine.Events.UnityEvent val_4;
            if((System.String.op_Equality(a:  0, b:  key)) == false)
            {
                    return;
            }
            
            if((System.String.op_Equality(a:  0, b:  value)) == false)
            {
                goto label_6;
            }
            
            val_4 = this.OnDailyRuby;
            if(val_4 != null)
            {
                goto label_12;
            }
            
            goto label_8;
            label_6:
            if((System.String.op_Equality(a:  0, b:  value)) == false)
            {
                    return;
            }
            
            val_4 = this.OnDailyHammer;
            if(val_4 != null)
            {
                goto label_12;
            }
            
            label_8:
            label_12:
            val_4.Invoke();
        }
    
    }

}
