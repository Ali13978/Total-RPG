using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    [Serializable]
    public class DropDownListItem
    {
        // Fields
        [UnityEngine.SerializeField]
        private string _caption;
        [UnityEngine.SerializeField]
        private UnityEngine.Sprite _image;
        [UnityEngine.SerializeField]
        private bool _isDisabled;
        [UnityEngine.SerializeField]
        private string _id;
        public System.Action OnSelect;
        internal System.Action OnUpdate;
        
        // Properties
        public string Caption { get; set; }
        public UnityEngine.Sprite Image { get; set; }
        public bool IsDisabled { get; set; }
        public string ID { get; set; }
        
        // Methods
        public DropDownListItem(string caption = "", string inId = "", UnityEngine.Sprite image, bool disabled = False, System.Action onSelect)
        {
            val_1 = new System.Object();
            this._caption = caption;
            this._image = image;
            this._id = val_1;
            this.OnSelect = onSelect;
            this._isDisabled = disabled;
        }
        public string get_Caption()
        {
            return (string)this._caption;
        }
        public void set_Caption(string value)
        {
            this._caption = value;
            if(this.OnUpdate == null)
            {
                    return;
            }
            
            this.OnUpdate.Invoke();
        }
        public UnityEngine.Sprite get_Image()
        {
            return (UnityEngine.Sprite)this._image;
        }
        public void set_Image(UnityEngine.Sprite value)
        {
            this._image = value;
            if(this.OnUpdate == null)
            {
                    return;
            }
            
            this.OnUpdate.Invoke();
        }
        public bool get_IsDisabled()
        {
            return (bool)this._isDisabled;
        }
        public void set_IsDisabled(bool value)
        {
            this._isDisabled = value;
            if(this.OnUpdate == null)
            {
                    return;
            }
            
            this.OnUpdate.Invoke();
        }
        public string get_ID()
        {
            return (string)this._id;
        }
        public void set_ID(string value)
        {
            this._id = value;
        }
    
    }

}
