using UnityEngine;

namespace TzarGames.Endless.UI.MainMenu
{
    public class SaveGameEntryUI : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI description;
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI time;
        [UnityEngine.SerializeField]
        private UnityEngine.CanvasRenderer _canvasRenderer;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private System.Action<TzarGames.Endless.UI.MainMenu.SaveGameEntryUI> OnSelected;
        private bool isHighlighted;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.Endless.CloudSaveSystem.ICloudSaveGameFile <SaveFile>k__BackingField;
        
        // Properties
        public string Description { get; set; }
        public string Time { get; set; }
        public TzarGames.Endless.CloudSaveSystem.ICloudSaveGameFile SaveFile { get; set; }
        public bool Highlight { get; set; }
        
        // Methods
        public SaveGameEntryUI()
        {
        
        }
        public void add_OnSelected(System.Action<TzarGames.Endless.UI.MainMenu.SaveGameEntryUI> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnSelected);
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
            while(1152921510980209680 != this.OnSelected);
        
        }
        public void remove_OnSelected(System.Action<TzarGames.Endless.UI.MainMenu.SaveGameEntryUI> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnSelected);
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
            while(1152921510980346256 != this.OnSelected);
        
        }
        public string get_Description()
        {
            if(this.description != null)
            {
                    return this.description.text;
            }
            
            return this.description.text;
        }
        public void set_Description(string value)
        {
            this.description.text = value;
        }
        public string get_Time()
        {
            if(this.time != null)
            {
                    return this.time.text;
            }
            
            return this.time.text;
        }
        public void set_Time(string value)
        {
            this.time.text = value;
        }
        public TzarGames.Endless.CloudSaveSystem.ICloudSaveGameFile get_SaveFile()
        {
            return (TzarGames.Endless.CloudSaveSystem.ICloudSaveGameFile)this.<SaveFile>k__BackingField;
        }
        public void set_SaveFile(TzarGames.Endless.CloudSaveSystem.ICloudSaveGameFile value)
        {
            this.<SaveFile>k__BackingField = value;
        }
        public void Select()
        {
            if(this.OnSelected == null)
            {
                    return;
            }
            
            this.OnSelected.Invoke(obj:  this);
        }
        public bool get_Highlight()
        {
            return (bool)this.isHighlighted;
        }
        public void set_Highlight(bool value)
        {
            this.isHighlighted = value;
            if(value != false)
            {
                
            }
            
            this._canvasRenderer.SetAlpha(alpha:  0f);
        }
    
    }

}
