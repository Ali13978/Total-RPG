using UnityEngine;

namespace ExitGames.Client.Photon.Chat
{
    public class ChatChannel
    {
        // Fields
        public readonly string Name;
        public readonly System.Collections.Generic.List<string> Senders;
        public readonly System.Collections.Generic.List<object> Messages;
        public int MessageLimit;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private bool <IsPrivate>k__BackingField;
        
        // Properties
        public bool IsPrivate { get; set; }
        public int MessageCount { get; }
        
        // Methods
        public ChatChannel(string name)
        {
            this.Senders = new System.Collections.Generic.List<System.String>();
            this.Messages = new System.Collections.Generic.List<System.Object>();
            this.Name = name;
        }
        public bool get_IsPrivate()
        {
            return (bool)this.<IsPrivate>k__BackingField;
        }
        protected internal void set_IsPrivate(bool value)
        {
            this.<IsPrivate>k__BackingField = value;
        }
        public int get_MessageCount()
        {
            if(this.Messages != null)
            {
                    return this.Messages.Count;
            }
            
            return this.Messages.Count;
        }
        public void Add(string sender, object message)
        {
            this.Senders.Add(item:  sender);
            this.Messages.Add(item:  message);
            this.TruncateMessages();
        }
        public void Add(string[] senders, object[] messages)
        {
            this.Senders.AddRange(collection:  senders);
            this.Messages.AddRange(collection:  messages);
            this.TruncateMessages();
        }
        public void TruncateMessages()
        {
            if(this.MessageLimit < 1)
            {
                    return;
            }
            
            if(this.Messages.Count <= this.MessageLimit)
            {
                    return;
            }
            
            System.Collections.Generic.List<System.Object> val_3 = this.Messages;
            val_3 = val_3.Count - this.MessageLimit;
            this.Senders.RemoveRange(index:  0, count:  val_3);
            this.Messages.RemoveRange(index:  0, count:  val_3);
        }
        public void ClearMessages()
        {
            this.Senders.Clear();
            this.Messages.Clear();
        }
        public string ToStringMessages()
        {
            var val_7;
            System.Text.StringBuilder val_1 = new System.Text.StringBuilder();
            val_7 = 0;
            goto label_1;
            label_9:
            System.Text.StringBuilder val_2 = AppendLine(value:  X22);
            val_7 = 1;
            label_1:
            if(val_7 >= this.Messages.Count)
            {
                goto label_3;
            }
            
            object val_5 = this.Messages.Item[1];
            string val_6 = System.String.Format(format:  0, arg0:  "{0}: {1}", arg1:  this.Senders.Item[1]);
            if(null != 0)
            {
                goto label_9;
            }
            
            goto label_9;
            label_3:
            if(null == 0)
            {
                
            }
        
        }
    
    }

}
