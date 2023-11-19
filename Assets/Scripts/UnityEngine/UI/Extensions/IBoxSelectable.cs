using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    public interface IBoxSelectable
    {
        // Properties
        public abstract bool selected { get; set; }
        public abstract bool preSelected { get; set; }
        public abstract UnityEngine.Transform transform { get; }
        
        // Methods
        public abstract bool get_selected(); // 0
        public abstract void set_selected(bool value); // 0
        public abstract bool get_preSelected(); // 0
        public abstract void set_preSelected(bool value); // 0
        public abstract UnityEngine.Transform get_transform(); // 0
    
    }

}
