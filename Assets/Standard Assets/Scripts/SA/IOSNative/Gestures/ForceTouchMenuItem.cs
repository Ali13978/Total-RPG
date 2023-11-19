using UnityEngine;

namespace SA.IOSNative.Gestures
{
    [Serializable]
    public class ForceTouchMenuItem
    {
        // Fields
        public bool IsOpen;
        public string Title;
        public string Subtitle;
        public string Action;
        
        // Methods
        public ForceTouchMenuItem()
        {
            var val_1;
            this.IsOpen = true;
            this.Title = "new_menu_item";
            val_1 = null;
            val_1 = null;
            this.Subtitle = System.String.Empty;
            this.Action = "new_menu_item";
        }
    
    }

}
