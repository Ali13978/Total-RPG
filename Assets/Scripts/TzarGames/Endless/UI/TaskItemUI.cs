using UnityEngine;

namespace TzarGames.Endless.UI
{
    public class TaskItemUI : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI text;
        [UnityEngine.SerializeField]
        private UnityEngine.UI.Image activeImage;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private System.Action<TzarGames.Endless.UI.TaskItemUI> OnClicked;
        
        // Properties
        public string Label { get; set; }
        public bool Activated { get; set; }
        
        // Methods
        public TaskItemUI()
        {
        
        }
        public void add_OnClicked(System.Action<TzarGames.Endless.UI.TaskItemUI> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnClicked);
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
            while(1152921511011045400 != this.OnClicked);
        
        }
        public void remove_OnClicked(System.Action<TzarGames.Endless.UI.TaskItemUI> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnClicked);
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
            while(1152921511011181976 != this.OnClicked);
        
        }
        public void NotifyClicked()
        {
            if(this.OnClicked == null)
            {
                    return;
            }
            
            this.OnClicked.Invoke(obj:  this);
        }
        public string get_Label()
        {
            if(this.text != null)
            {
                    return this.text.text;
            }
            
            return this.text.text;
        }
        public void set_Label(string value)
        {
            this.text.text = value;
        }
        public bool get_Activated()
        {
            UnityEngine.GameObject val_1 = this.activeImage.gameObject;
            if(val_1 != null)
            {
                    return val_1.activeSelf;
            }
            
            return val_1.activeSelf;
        }
        public void set_Activated(bool value)
        {
            this.activeImage.gameObject.SetActive(value:  value);
        }
    
    }

}
