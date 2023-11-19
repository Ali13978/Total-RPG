using UnityEngine;

namespace TMPro.Examples
{
    public class TMP_TextEventCheck : MonoBehaviour
    {
        // Fields
        public TMPro.TMP_TextEventHandler TextEventHandler;
        
        // Methods
        public TMP_TextEventCheck()
        {
        
        }
        private void OnEnable()
        {
            if(0 == this.TextEventHandler)
            {
                    return;
            }
            
            this.TextEventHandler.m_OnCharacterSelection.AddListener(call:  new UnityEngine.Events.UnityAction<System.Char, System.Int32>(object:  this, method:  System.Void TMPro.Examples.TMP_TextEventCheck::OnCharacterSelection(char c, int index)));
            this.TextEventHandler.m_OnWordSelection.AddListener(call:  new UnityEngine.Events.UnityAction<System.String, System.Int32, System.Int32>(object:  this, method:  System.Void TMPro.Examples.TMP_TextEventCheck::OnWordSelection(string word, int firstCharacterIndex, int length)));
            this.TextEventHandler.m_OnLineSelection.AddListener(call:  new UnityEngine.Events.UnityAction<System.String, System.Int32, System.Int32>(object:  this, method:  System.Void TMPro.Examples.TMP_TextEventCheck::OnLineSelection(string lineText, int firstCharacterIndex, int length)));
            this.TextEventHandler.m_OnLinkSelection.AddListener(call:  new UnityEngine.Events.UnityAction<System.String, System.String, System.Int32>(object:  this, method:  System.Void TMPro.Examples.TMP_TextEventCheck::OnLinkSelection(string linkID, string linkText, int linkIndex)));
        }
        private void OnDisable()
        {
            if(0 == this.TextEventHandler)
            {
                    return;
            }
            
            this.TextEventHandler.m_OnCharacterSelection.RemoveListener(call:  new UnityEngine.Events.UnityAction<System.Char, System.Int32>(object:  this, method:  System.Void TMPro.Examples.TMP_TextEventCheck::OnCharacterSelection(char c, int index)));
            this.TextEventHandler.m_OnWordSelection.RemoveListener(call:  new UnityEngine.Events.UnityAction<System.String, System.Int32, System.Int32>(object:  this, method:  System.Void TMPro.Examples.TMP_TextEventCheck::OnWordSelection(string word, int firstCharacterIndex, int length)));
            this.TextEventHandler.m_OnLineSelection.RemoveListener(call:  new UnityEngine.Events.UnityAction<System.String, System.Int32, System.Int32>(object:  this, method:  System.Void TMPro.Examples.TMP_TextEventCheck::OnLineSelection(string lineText, int firstCharacterIndex, int length)));
            this.TextEventHandler.m_OnLinkSelection.RemoveListener(call:  new UnityEngine.Events.UnityAction<System.String, System.String, System.Int32>(object:  this, method:  System.Void TMPro.Examples.TMP_TextEventCheck::OnLinkSelection(string linkID, string linkText, int linkIndex)));
        }
        private void OnCharacterSelection(char c, int index)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = "Character [";
            typeof(System.Object[]).__il2cppRuntimeField_28 = c;
            typeof(System.Object[]).__il2cppRuntimeField_2A = 120883;
            typeof(System.Object[]).__il2cppRuntimeField_30 = "] at Index: ";
            typeof(System.Object[]).__il2cppRuntimeField_38 = index;
            typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
            typeof(System.Object[]).__il2cppRuntimeField_40 = " has been selected.";
            string val_1 = +0;
            UnityEngine.Debug.Log(message:  0);
        }
        private void OnWordSelection(string word, int firstCharacterIndex, int length)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = "Word [";
            typeof(System.Object[]).__il2cppRuntimeField_28 = word;
            typeof(System.Object[]).__il2cppRuntimeField_30 = "] with first character index of ";
            typeof(System.Object[]).__il2cppRuntimeField_38 = firstCharacterIndex;
            typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
            typeof(System.Object[]).__il2cppRuntimeField_40 = " and length of ";
            typeof(System.Object[]).__il2cppRuntimeField_48 = length;
            typeof(System.Object[]).__il2cppRuntimeField_4C = 268435457;
            typeof(System.Object[]).__il2cppRuntimeField_50 = " has been selected.";
            string val_1 = +0;
            UnityEngine.Debug.Log(message:  0);
        }
        private void OnLineSelection(string lineText, int firstCharacterIndex, int length)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = "Line [";
            typeof(System.Object[]).__il2cppRuntimeField_28 = lineText;
            typeof(System.Object[]).__il2cppRuntimeField_30 = "] with first character index of ";
            typeof(System.Object[]).__il2cppRuntimeField_38 = firstCharacterIndex;
            typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
            typeof(System.Object[]).__il2cppRuntimeField_40 = " and length of ";
            typeof(System.Object[]).__il2cppRuntimeField_48 = length;
            typeof(System.Object[]).__il2cppRuntimeField_4C = 268435457;
            typeof(System.Object[]).__il2cppRuntimeField_50 = " has been selected.";
            string val_1 = +0;
            UnityEngine.Debug.Log(message:  0);
        }
        private void OnLinkSelection(string linkID, string linkText, int linkIndex)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = "Link Index: ";
            typeof(System.Object[]).__il2cppRuntimeField_28 = linkIndex;
            typeof(System.Object[]).__il2cppRuntimeField_2C = 268435457;
            typeof(System.Object[]).__il2cppRuntimeField_30 = " with ID [";
            typeof(System.Object[]).__il2cppRuntimeField_38 = linkID;
            typeof(System.Object[]).__il2cppRuntimeField_40 = "] and Text \"";
            typeof(System.Object[]).__il2cppRuntimeField_48 = linkText;
            typeof(System.Object[]).__il2cppRuntimeField_50 = "\" has been selected.";
            string val_1 = +0;
            UnityEngine.Debug.Log(message:  0);
        }
    
    }

}
