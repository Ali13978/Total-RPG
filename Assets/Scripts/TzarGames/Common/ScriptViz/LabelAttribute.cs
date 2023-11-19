using UnityEngine;

namespace TzarGames.Common.ScriptViz
{
    public class LabelAttribute : Attribute
    {
        // Fields
        private readonly string _label;
        
        // Properties
        public string Label { get; }
        
        // Methods
        public LabelAttribute(string label)
        {
            this._label = label;
        }
        public string get_Label()
        {
            return (string)this._label;
        }
    
    }

}
