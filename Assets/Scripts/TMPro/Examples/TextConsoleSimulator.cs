using UnityEngine;

namespace TMPro.Examples
{
    public class TextConsoleSimulator : MonoBehaviour
    {
        // Fields
        private TMPro.TMP_Text m_TextComponent;
        private bool hasTextChanged;
        
        // Methods
        public TextConsoleSimulator()
        {
        
        }
        private void Awake()
        {
            this.m_TextComponent = this.gameObject.GetComponent<TMPro.TMP_Text>();
        }
        private void Start()
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.RevealCharacters(textComponent:  this.m_TextComponent));
        }
        private void OnEnable()
        {
            null = null;
            TMPro.TMPro_EventManager.TEXT_CHANGED_EVENT.Add(rhs:  new System.Action<UnityEngine.Object>(object:  this, method:  System.Void TMPro.Examples.TextConsoleSimulator::ON_TEXT_CHANGED(UnityEngine.Object obj)));
        }
        private void OnDisable()
        {
            null = null;
            TMPro.TMPro_EventManager.TEXT_CHANGED_EVENT.Remove(rhs:  new System.Action<UnityEngine.Object>(object:  this, method:  System.Void TMPro.Examples.TextConsoleSimulator::ON_TEXT_CHANGED(UnityEngine.Object obj)));
        }
        private void ON_TEXT_CHANGED(UnityEngine.Object obj)
        {
            this.hasTextChanged = true;
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator RevealCharacters(TMPro.TMP_Text textComponent)
        {
            if(null != 0)
            {
                    typeof(TextConsoleSimulator.<RevealCharacters>c__Iterator0).__il2cppRuntimeField_10 = textComponent;
            }
            else
            {
                    mem[16] = textComponent;
            }
            
            typeof(TextConsoleSimulator.<RevealCharacters>c__Iterator0).__il2cppRuntimeField_28 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator RevealWords(TMPro.TMP_Text textComponent)
        {
            typeof(TextConsoleSimulator.<RevealWords>c__Iterator1).__il2cppRuntimeField_10 = textComponent;
            return (System.Collections.IEnumerator)new System.Object();
        }
    
    }

}
