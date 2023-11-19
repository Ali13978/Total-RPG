using UnityEngine;

namespace TzarGames.Endless.UI.Chat
{
    public class ChatUI : StateMachine, IChatClientListener
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.UIBase chatWindow;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.UIBase settingsWindow;
        [UnityEngine.SerializeField]
        private UnityEngine.UI.ScrollRect scroll;
        [UnityEngine.SerializeField]
        private int maxMessageCount;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.UI.Chat.ChatMessageUI messagePrefab;
        [UnityEngine.SerializeField]
        private UnityEngine.RectTransform messageContainer;
        [UnityEngine.SerializeField]
        private UnityEngine.Color otherNameColor;
        [UnityEngine.SerializeField]
        private UnityEngine.Color playerNameColor;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.InputFieldUI inputField;
        [UnityEngine.SerializeField]
        private UnityEngine.RectTransform currentUsersContainer;
        [UnityEngine.SerializeField]
        private UnityEngine.RectTransform blockedUserContainer;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.UI.Chat.ChatUserEntryUI userEntryUI;
        private System.Collections.Generic.List<string> blockedUsers;
        private TzarGames.Endless.IChatProvider chatProvider;
        private const string CHAT_DATA_KEY = "CHAT_DATA_KEY";
        private TzarGames.Common.InstancePool<TzarGames.Endless.UI.Chat.ChatMessageUI> messagePool;
        private System.Collections.Generic.List<TzarGames.Endless.UI.Chat.ChatMessageUI> activeMessages;
        
        // Methods
        public ChatUI()
        {
            this.maxMessageCount = 50;
            UnityEngine.Color val_1 = UnityEngine.Color.cyan;
            this.otherNameColor = val_1;
            mem[1152921510885133268] = val_1.g;
            mem[1152921510885133272] = val_1.b;
            mem[1152921510885133276] = val_1.a;
            UnityEngine.Color val_2 = UnityEngine.Color.blue;
            this.playerNameColor = val_2;
            mem[1152921510885133284] = val_2.g;
            mem[1152921510885133288] = val_2.b;
            mem[1152921510885133292] = val_2.a;
            this.blockedUsers = new System.Collections.Generic.List<System.String>();
            this.activeMessages = new System.Collections.Generic.List<TzarGames.Endless.UI.Chat.ChatMessageUI>();
        }
        private TzarGames.Endless.UI.Chat.ChatMessageUI createMessage(TzarGames.Endless.UI.Chat.ChatMessageUI prefab)
        {
            TzarGames.Endless.UI.SkillUpgradeUI val_1 = TzarGames.GameFramework.GameManager.MakeInstance<TzarGames.Endless.UI.SkillUpgradeUI>(obj:  0);
            val_1.gameObject.hideFlags = 1;
            return (TzarGames.Endless.UI.Chat.ChatMessageUI)val_1;
        }
        public void CloseSettings()
        {
            bool val_1 = this.GotoState<ChatUI.Chat>(stateData:  0);
        }
        public void ShowSettings()
        {
            bool val_1 = this.GotoState<ChatUI.Settings>(stateData:  0);
        }
        public void Send()
        {
            var val_7;
            var val_8;
            var val_9;
            string val_1 = this.inputField.Text;
            if((System.String.IsNullOrEmpty(value:  0)) != false)
            {
                    return;
            }
            
            var val_7 = 0;
            val_7 = val_7 + 1;
            val_7 = this.chatProvider;
            string val_5 = this.inputField.Text;
            var val_8 = 0;
            val_8 = val_8 + 1;
            val_8 = this.chatProvider;
            val_9 = null;
            val_9 = null;
            this.inputField.Text = System.String.Empty;
        }
        private void Start()
        {
            var val_11;
            var val_12;
            val_11 = 0;
            if(0 != TzarGames.Endless.EndlessGameState.Instance)
            {
                    val_11 = 0;
                if((TzarGames.Endless.EndlessGameState.Instance.CommonSaveGameData.GetString(id:  "CHAT_DATA_KEY")) != null)
            {
                    val_11 = public static ChatData UnityEngine.JsonUtility::FromJson<ChatData>(string json);
                EncodedData val_6 = UnityEngine.JsonUtility.FromJson<EncodedData>(json:  0);
                this.blockedUsers = val_6.Data;
            }
            
            }
            
            TzarGames.Endless.UI.Chat.PhotonChatProvider val_7 = TzarGames.Endless.UI.Chat.PhotonChatProvider.Instance;
            this.chatProvider = val_7;
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_11 = 8;
            val_12 = val_7;
            this.messagePool = new TzarGames.Common.InstancePool<TzarGames.Endless.UI.Chat.ChatMessageUI>(original:  this.messagePrefab, createObjectCallback:  new InstancePool.CreateInstanceDeleagate<TzarGames.Endless.UI.Chat.ChatMessageUI>(object:  this, method:  TzarGames.Endless.UI.Chat.ChatMessageUI TzarGames.Endless.UI.Chat.ChatUI::createMessage(TzarGames.Endless.UI.Chat.ChatMessageUI prefab)), maxCount:  this.maxMessageCount);
            CreateObjects(count:  50);
        }
        private void OnDestroy()
        {
            var val_2;
            if(this.chatProvider == null)
            {
                    return;
            }
            
            var val_2 = 0;
            val_2 = val_2 + 1;
            val_2 = this.chatProvider;
        }
        public void OnConnected()
        {
        
        }
        public void OnDisconnected()
        {
        
        }
        public void OnGetMessages(string channelName, string[] senders, object[] messages)
        {
            var val_19;
            object val_20;
            TzarGames.Endless.UI.Chat.ChatMessageUI val_21;
            var val_23;
            val_19 = 0;
            goto label_2;
            label_34:
            val_19 = 1;
            label_2:
            if(val_19 >= messages.Length)
            {
                goto label_4;
            }
            
            val_20 = messages[1];
            string val_19 = senders[1];
            if(this.blockedUsers != null)
            {
                    if((this.blockedUsers.Contains(item:  val_19)) == true)
            {
                goto label_34;
            }
            
            }
            
            if(this.activeMessages.Count < this.maxMessageCount)
            {
                    val_21 = this.messagePool.Get();
            }
            else
            {
                    val_21 = this.activeMessages.Item[0];
                this.activeMessages.RemoveAt(index:  0);
            }
            
            this.activeMessages.Add(item:  val_21);
            val_21.gameObject.hideFlags = 0;
            var val_20 = 0;
            val_20 = val_20 + 1;
            val_23 = this.chatProvider;
            bool val_9 = val_19.Equals(value:  this.chatProvider);
            if(val_20 != null)
            {
                    if(null == null)
            {
                goto label_27;
            }
            
            }
            
            val_20 = 0;
            label_27:
            val_21.Build(playerName:  val_19, playerNameColor: ref  new UnityEngine.Color() {r = (val_9 != true) ? this.playerNameColor : this.otherNameColor, g = (val_9 != true) ? 1152921510886449604 : 1152921510886449588, b = (val_9 != true) ? 1152921510886449608 : 1152921510886449592, a = (val_9 != true) ? 1152921510886449612 : 1152921510886449596}, message:  val_20);
            UnityEngine.Transform val_15 = val_21.transform;
            val_15.SetParent(parent:  this.messageContainer);
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.one;
            if(val_15 != null)
            {
                    val_15.localScale = new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z};
            }
            else
            {
                    0.localScale = new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z};
            }
            
            val_15.SetAsLastSibling();
            goto label_34;
            label_4:
            if(this.scroll.verticalNormalizedPosition >= 0)
            {
                    return;
            }
            
            UnityEngine.Coroutine val_18 = this.StartCoroutine(routine:  this.scrollRoutine());
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator scrollRoutine()
        {
            typeof(ChatUI.<scrollRoutine>c__Iterator0).__il2cppRuntimeField_10 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        private void Update()
        {
            if(this.CurrentState == null)
            {
                
            }
        
        }
    
    }

}
