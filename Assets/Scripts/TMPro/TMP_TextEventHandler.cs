using UnityEngine;

namespace TMPro
{
    public class TMP_TextEventHandler : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IEventSystemHandler
    {
        // Fields
        [UnityEngine.SerializeField]
        private TMPro.TMP_TextEventHandler.CharacterSelectionEvent m_OnCharacterSelection;
        [UnityEngine.SerializeField]
        private TMPro.TMP_TextEventHandler.WordSelectionEvent m_OnWordSelection;
        [UnityEngine.SerializeField]
        private TMPro.TMP_TextEventHandler.LineSelectionEvent m_OnLineSelection;
        [UnityEngine.SerializeField]
        private TMPro.TMP_TextEventHandler.LinkSelectionEvent m_OnLinkSelection;
        private TMPro.TMP_Text m_TextComponent;
        private UnityEngine.Camera m_Camera;
        private UnityEngine.Canvas m_Canvas;
        private int m_selectedLink;
        private int m_lastCharIndex;
        private int m_lastWordIndex;
        private int m_lastLineIndex;
        
        // Properties
        public TMPro.TMP_TextEventHandler.CharacterSelectionEvent onCharacterSelection { get; set; }
        public TMPro.TMP_TextEventHandler.WordSelectionEvent onWordSelection { get; set; }
        public TMPro.TMP_TextEventHandler.LineSelectionEvent onLineSelection { get; set; }
        public TMPro.TMP_TextEventHandler.LinkSelectionEvent onLinkSelection { get; set; }
        
        // Methods
        public TMP_TextEventHandler()
        {
            this.m_OnCharacterSelection = new TMP_TextEventHandler.CharacterSelectionEvent();
            this.m_OnWordSelection = new TMP_TextEventHandler.WordSelectionEvent();
            this.m_OnLineSelection = new TMP_TextEventHandler.LineSelectionEvent();
            this.m_OnLinkSelection = new TMP_TextEventHandler.LinkSelectionEvent();
            this.m_selectedLink = 0;
            this.m_lastCharIndex = 0;
            this.m_lastWordIndex = 0;
            this.m_lastLineIndex = 0;
        }
        public TMPro.TMP_TextEventHandler.CharacterSelectionEvent get_onCharacterSelection()
        {
            return (CharacterSelectionEvent)this.m_OnCharacterSelection;
        }
        public void set_onCharacterSelection(TMPro.TMP_TextEventHandler.CharacterSelectionEvent value)
        {
            this.m_OnCharacterSelection = value;
        }
        public TMPro.TMP_TextEventHandler.WordSelectionEvent get_onWordSelection()
        {
            return (WordSelectionEvent)this.m_OnWordSelection;
        }
        public void set_onWordSelection(TMPro.TMP_TextEventHandler.WordSelectionEvent value)
        {
            this.m_OnWordSelection = value;
        }
        public TMPro.TMP_TextEventHandler.LineSelectionEvent get_onLineSelection()
        {
            return (LineSelectionEvent)this.m_OnLineSelection;
        }
        public void set_onLineSelection(TMPro.TMP_TextEventHandler.LineSelectionEvent value)
        {
            this.m_OnLineSelection = value;
        }
        public TMPro.TMP_TextEventHandler.LinkSelectionEvent get_onLinkSelection()
        {
            return (LinkSelectionEvent)this.m_OnLinkSelection;
        }
        public void set_onLinkSelection(TMPro.TMP_TextEventHandler.LinkSelectionEvent value)
        {
            this.m_OnLinkSelection = value;
        }
        private void Awake()
        {
            TMPro.TMP_Text val_2 = this.gameObject.GetComponent<TMPro.TMP_Text>();
            this.m_TextComponent = val_2;
            if(val_2.GetType() == (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                goto label_5;
            }
            
            label_14:
            this.m_Camera = UnityEngine.Camera.main;
            return;
            label_5:
            UnityEngine.Canvas val_7 = this.gameObject.GetComponentInParent<UnityEngine.Canvas>();
            this.m_Canvas = val_7;
            if(0 == val_7)
            {
                    return;
            }
            
            if(this.m_Canvas.renderMode == 0)
            {
                goto label_12;
            }
            
            UnityEngine.Camera val_10 = this.m_Canvas.worldCamera;
            goto label_14;
            label_12:
            this.m_Camera = 0;
        }
        private void LateUpdate()
        {
            var val_24;
            UnityEngine.Camera val_25;
            float val_26;
            float val_27;
            val_24 = 1152921504719626240;
            UnityEngine.Vector3 val_2 = UnityEngine.Input.mousePosition;
            val_25 = this.m_Camera;
            val_26 = val_2.x;
            val_27 = val_2.z;
            if((TMPro.TMP_TextUtilities.IsIntersectingRectTransform(rectTransform:  0, position:  new UnityEngine.Vector3() {x = val_26, y = val_2.y, z = val_27}, camera:  this.m_TextComponent.rectTransform)) == false)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_4 = UnityEngine.Input.mousePosition;
            int val_5 = TMPro.TMP_TextUtilities.FindIntersectingCharacter(text:  0, position:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, camera:  this.m_TextComponent, visibleOnly:  this.m_Camera);
            if((val_5 != 1) && (val_5 != this.m_lastCharIndex))
            {
                    this.m_lastCharIndex = val_5;
                TMPro.TMP_TextInfo val_6 = this.m_TextComponent.textInfo;
                var val_7 = val_6.characterInfo + ((long)val_5 * 328);
                this.SendOnCharacterSelection(character:  ((long)(int)(val_5) * 328) + val_6.characterInfo + 32, characterIndex:  val_5);
            }
            
            UnityEngine.Vector3 val_8 = UnityEngine.Input.mousePosition;
            int val_9 = TMPro.TMP_TextUtilities.FindIntersectingWord(text:  0, position:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, camera:  this.m_TextComponent);
            if((val_9 != 1) && (val_9 != this.m_lastWordIndex))
            {
                    this.m_lastWordIndex = val_9;
                TMPro.TMP_TextInfo val_10 = this.m_TextComponent.textInfo;
                var val_24 = 24;
                val_24 = val_10.wordInfo + ((long)val_9 * val_24);
                this.SendOnWordSelection(word:  ((long)(int)(val_9) * 24) + val_10.wordInfo + 32, charIndex:  ((long)(int)(val_9) * 24) + val_10.wordInfo + 32, length:  ((long)(int)(val_9) * 24) + val_10.wordInfo + 48);
            }
            
            UnityEngine.Vector3 val_11 = UnityEngine.Input.mousePosition;
            int val_12 = TMPro.TMP_TextUtilities.FindIntersectingLine(text:  0, position:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, camera:  this.m_TextComponent);
            if((val_12 == 1) || (val_12 == this.m_lastLineIndex))
            {
                goto label_32;
            }
            
            this.m_lastLineIndex = val_12;
            TMPro.TMP_TextInfo val_13 = this.m_TextComponent.textInfo;
            var val_14 = val_13.lineInfo + ((long)val_12 * 88);
            if((((long)(int)(val_12) * 88) + val_13.lineInfo + 32) < 1)
            {
                goto label_41;
            }
            
            var val_25 = 0;
            label_48:
            TMPro.TMP_TextInfo val_15 = this.m_TextComponent.textInfo;
            if(val_25 >= val_15.characterInfo.Length)
            {
                goto label_41;
            }
            
            TMPro.TMP_TextInfo val_16 = this.m_TextComponent.textInfo;
            var val_18 = val_16.characterInfo + (((long)(((long)(int)(val_12) * 88) + val_13.lineInfo + 48) + val_25) * 328);
            System.Char[].__il2cppRuntimeField_byval_arg.__il2cppRuntimeField_0 = ((long)(int)((((long)(int)(val_12) * 88) + val_13.lineInfo + 48 + 0)) * 328) + val_16.characterInfo + 32;
            val_25 = val_25 + 1;
            if(val_25 < ((long)((long)(int)(val_12) * 88) + val_13.lineInfo + 32))
            {
                goto label_48;
            }
            
            label_41:
            this.SendOnLineSelection(line:  0.CreateString(val:  null), charIndex:  ((long)(int)(val_12) * 88) + val_13.lineInfo + 48, length:  (long)((long)(int)(val_12) * 88) + val_13.lineInfo + 32);
            val_24 = 1152921504719626240;
            label_32:
            UnityEngine.Vector3 val_20 = UnityEngine.Input.mousePosition;
            val_25 = this.m_Camera;
            val_26 = val_20.x;
            val_27 = val_20.z;
            int val_21 = TMPro.TMP_TextUtilities.FindIntersectingLink(text:  0, position:  new UnityEngine.Vector3() {x = val_26, y = val_20.y, z = val_27}, camera:  this.m_TextComponent);
            if(val_21 == 1)
            {
                    return;
            }
            
            if(val_21 == this.m_selectedLink)
            {
                    return;
            }
            
            this.m_selectedLink = val_21;
            TMPro.TMP_TextInfo val_22 = this.m_TextComponent.textInfo;
            var val_23 = val_22.linkInfo + ((long)val_21 * 40);
            val_25 = ;
            this.SendOnLinkSelection(linkID:  ((long)(int)(val_21) * 40) + val_22.linkInfo + 32, linkText:  ((long)(int)(val_21) * 40) + val_22.linkInfo + 32, linkIndex:  val_21);
        }
        public void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData)
        {
        
        }
        public void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData)
        {
        
        }
        private void SendOnCharacterSelection(char character, int characterIndex)
        {
            if(this.m_OnCharacterSelection == null)
            {
                    return;
            }
            
            this.m_OnCharacterSelection.Invoke(arg0:  character, arg1:  characterIndex);
        }
        private void SendOnWordSelection(string word, int charIndex, int length)
        {
            if(this.m_OnWordSelection == null)
            {
                    return;
            }
            
            this.m_OnWordSelection.Invoke(arg0:  word, arg1:  charIndex, arg2:  length);
        }
        private void SendOnLineSelection(string line, int charIndex, int length)
        {
            if(this.m_OnLineSelection == null)
            {
                    return;
            }
            
            this.m_OnLineSelection.Invoke(arg0:  line, arg1:  charIndex, arg2:  length);
        }
        private void SendOnLinkSelection(string linkID, string linkText, int linkIndex)
        {
            if(this.m_OnLinkSelection == null)
            {
                    return;
            }
            
            this.m_OnLinkSelection.Invoke(arg0:  linkID, arg1:  linkText, arg2:  linkIndex);
        }
    
    }

}
