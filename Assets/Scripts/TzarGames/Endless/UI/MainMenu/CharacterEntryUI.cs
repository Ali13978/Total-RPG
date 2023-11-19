using UnityEngine;

namespace TzarGames.Endless.UI.MainMenu
{
    public class CharacterEntryUI : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Common.UI.TextUI characterName;
        [UnityEngine.SerializeField]
        private UnityEngine.CanvasRenderer selectedIcon;
        private bool selected;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private System.Action<TzarGames.Endless.UI.MainMenu.CharacterEntryUI> OnSelected;
        
        // Properties
        public string CharacterName { get; set; }
        public bool Selected { get; set; }
        
        // Methods
        public CharacterEntryUI()
        {
        
        }
        public string get_CharacterName()
        {
            if(this.characterName != null)
            {
                    return this.characterName.text;
            }
            
            return this.characterName.text;
        }
        public void set_CharacterName(string value)
        {
            this.characterName.text = value;
        }
        public bool get_Selected()
        {
            return (bool)this.selected;
        }
        public void set_Selected(bool value)
        {
            this.selected = value;
            this.selectedIcon.SetAlpha(alpha:  (value != true) ? 1f : 0f);
        }
        public void add_OnSelected(System.Action<TzarGames.Endless.UI.MainMenu.CharacterEntryUI> value)
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
            while(1152921510962826736 != this.OnSelected);
        
        }
        public void remove_OnSelected(System.Action<TzarGames.Endless.UI.MainMenu.CharacterEntryUI> value)
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
            while(1152921510962963312 != this.OnSelected);
        
        }
        public void NotifyClicked()
        {
            if(this.OnSelected == null)
            {
                    return;
            }
            
            this.OnSelected.Invoke(obj:  this);
        }
    
    }

}
