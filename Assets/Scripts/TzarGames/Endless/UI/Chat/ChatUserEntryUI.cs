using UnityEngine;

namespace TzarGames.Endless.UI.Chat
{
    public class ChatUserEntryUI : MonoBehaviour, IPoolable
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI userName;
        [UnityEngine.SerializeField]
        private UnityEngine.UI.Toggle toggle;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private System.Action<TzarGames.Endless.UI.Chat.ChatUserEntryUI> OnTogglePressed;
        
        // Properties
        public string UserName { get; set; }
        public bool IsBlocked { get; set; }
        
        // Methods
        public ChatUserEntryUI()
        {
        
        }
        public void add_OnTogglePressed(System.Action<TzarGames.Endless.UI.Chat.ChatUserEntryUI> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnTogglePressed);
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
            while(1152921510889630312 != this.OnTogglePressed);
        
        }
        public void remove_OnTogglePressed(System.Action<TzarGames.Endless.UI.Chat.ChatUserEntryUI> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnTogglePressed);
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
            while(1152921510889766888 != this.OnTogglePressed);
        
        }
        public string get_UserName()
        {
            if(this.userName != null)
            {
                    return this.userName.text;
            }
            
            return this.userName.text;
        }
        public void set_UserName(string value)
        {
            this.userName.text = value;
        }
        public bool get_IsBlocked()
        {
            if(this.toggle != null)
            {
                    return this.toggle.isOn;
            }
            
            return this.toggle.isOn;
        }
        public void set_IsBlocked(bool value)
        {
            value = value;
            this.toggle.isOn = value;
        }
        public void OnStateChanged(bool val)
        {
            if(this.OnTogglePressed == null)
            {
                    return;
            }
            
            this.OnTogglePressed.Invoke(obj:  this);
        }
        public void OnPushedToPool()
        {
            this.userName.enabled = false;
        }
        public void OnPulledFromPool()
        {
            this.userName.enabled = true;
        }
    
    }

}
