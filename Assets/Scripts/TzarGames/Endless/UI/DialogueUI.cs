using UnityEngine;

namespace TzarGames.Endless.UI
{
    public class DialogueUI : UIBase
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Endless.UI.DialogueEntryUI entryUI;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private System.Action OnClosed;
        private TzarGames.Endless.ConversationData _data;
        private int currentEntry;
        
        // Methods
        public DialogueUI()
        {
        
        }
        public void add_OnClosed(System.Action value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnClosed);
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
            while(1152921510898297392 != this.OnClosed);
        
        }
        public void remove_OnClosed(System.Action value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnClosed);
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
            while(1152921510898433968 != this.OnClosed);
        
        }
        public void ShowDialogue(TzarGames.Endless.ConversationData data)
        {
            this.currentEntry = 0;
            this._data = data;
            this.show(entryNum:  this.currentEntry);
            UnityEngine.Object.FindObjectOfType<UnityEngine.UI.Extensions.BoundTooltipItem>().Disable();
        }
        public void ShowNext()
        {
            if(0 == this._data)
            {
                    UnityEngine.Debug.LogError(message:  0);
                return;
            }
            
            TzarGames.Endless.ConversationEntry[] val_2 = this._data.Entries;
            if((this.currentEntry + 1) < val_2.Length)
            {
                    int val_4 = this.currentEntry + 1;
                this.currentEntry = val_4;
                this.show(entryNum:  val_4);
                return;
            }
            
            this.Close();
        }
        public void Close()
        {
            if(0 == this._data)
            {
                    return;
            }
            
            this._data = 0;
            UnityEngine.Object.FindObjectOfType<UnityEngine.UI.Extensions.BoundTooltipItem>().ShowPreviousStateMenu();
            if(this.OnClosed == null)
            {
                    return;
            }
            
            this.OnClosed.Invoke();
        }
        private void show(int entryNum)
        {
            TzarGames.Endless.ConversationEntry val_3 = this._data.Entries[(long)entryNum];
            this.entryUI._text.text = TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0);
            this.entryUI.Icon = val_1[(long)(int)(entryNum)][0].Icon;
        }
    
    }

}
