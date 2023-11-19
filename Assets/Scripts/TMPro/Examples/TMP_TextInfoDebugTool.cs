using UnityEngine;

namespace TMPro.Examples
{
    [UnityEngine.ExecuteInEditMode]
    public class TMP_TextInfoDebugTool : MonoBehaviour
    {
        // Fields
        public bool ShowCharacters;
        public bool ShowWords;
        public bool ShowLinks;
        public bool ShowLines;
        public bool ShowMeshBounds;
        public bool ShowTextBounds;
        [UnityEngine.SpaceAttribute]
        [UnityEngine.TextAreaAttribute]
        public string ObjectStats;
        private TMPro.TMP_Text m_TextComponent;
        private UnityEngine.Transform m_Transform;
        
        // Methods
        public TMP_TextInfoDebugTool()
        {
        
        }
    
    }

}
