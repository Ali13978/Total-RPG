using UnityEngine;

namespace TMPro.Examples
{
    public class TMP_TextSelector_A : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IEventSystemHandler
    {
        // Fields
        private TMPro.TextMeshPro m_TextMeshPro;
        private UnityEngine.Camera m_Camera;
        private bool m_isHoveringObject;
        private int m_selectedLink;
        private int m_lastCharIndex;
        private int m_lastWordIndex;
        
        // Methods
        public TMP_TextSelector_A()
        {
            this.m_selectedLink = 0;
            this.m_lastCharIndex = 0;
            this.m_lastWordIndex = 0;
        }
        private void Awake()
        {
            this.m_TextMeshPro = this.gameObject.GetComponent<TMPro.TextMeshPro>();
            this.m_Camera = UnityEngine.Camera.main;
            if(this.m_TextMeshPro == null)
            {
                
            }
        
        }
        private void LateUpdate()
        {
            var val_66;
            float val_67;
            float val_68;
            var val_69;
            TMPro.TextMeshPro val_70;
            var val_71;
            float val_72;
            float val_73;
            float val_74;
            int val_75;
            int val_76;
            var val_77;
            val_66 = this;
            this.m_isHoveringObject = false;
            UnityEngine.Vector3 val_2 = UnityEngine.Input.mousePosition;
            val_67 = val_2.x;
            val_68 = val_2.z;
            val_69 = 1152921504824311808;
            val_70 = UnityEngine.Camera.main;
            if((TMPro.TMP_TextUtilities.IsIntersectingRectTransform(rectTransform:  0, position:  new UnityEngine.Vector3() {x = val_67, y = val_2.y, z = val_68}, camera:  this.m_TextMeshPro.rectTransform)) != false)
            {
                    this.m_isHoveringObject = true;
            }
            else
            {
                    if(this.m_isHoveringObject == false)
            {
                    return;
            }
            
            }
            
            UnityEngine.Vector3 val_5 = UnityEngine.Input.mousePosition;
            int val_7 = TMPro.TMP_TextUtilities.FindIntersectingCharacter(text:  0, position:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, camera:  this.m_TextMeshPro, visibleOnly:  UnityEngine.Camera.main);
            if((val_7 != 1) && (val_7 != this.m_lastCharIndex))
            {
                    if((UnityEngine.Input.GetKey(key:  0)) != true)
            {
                    if((UnityEngine.Input.GetKey(key:  0)) == false)
            {
                goto label_20;
            }
            
            }
            
                this.m_lastCharIndex = val_7;
                TMPro.TMP_TextInfo val_11 = this.m_TextMeshPro.textInfo;
                var val_12 = val_11.characterInfo + ((long)val_7 * 328);
                TMPro.TMP_TextInfo val_13 = this.m_TextMeshPro.textInfo;
                var val_14 = val_13.characterInfo + ((long)val_7 * 328);
                int val_15 = UnityEngine.Random.Range(min:  0, max:  0);
                int val_16 = UnityEngine.Random.Range(min:  0, max:  0);
                int val_17 = UnityEngine.Random.Range(min:  0, max:  0);
                TMPro.TMP_TextInfo val_18 = this.m_TextMeshPro.textInfo;
                var val_19 = val_18.meshInfo + ((((long)(int)(val_7) * 328) + val_11.characterInfo + 80) * 72);
                var val_20 = ((((long)(int)(val_7) * 328) + val_11.characterInfo + 80 * 72) + val_18.meshInfo + 88) + ((((long)(int)(val_7) * 328) + val_13.characterInfo + 96) << 2);
                mem2[0] = 0;
                var val_21 = (((long)(int)(val_7) * 328) + val_13.characterInfo + 96) + 1;
                var val_22 = ((((long)(int)(val_7) * 328) + val_11.characterInfo + 80 * 72) + val_18.meshInfo + 88) + (((long)(int)((((long)(int)(val_7) * 328) + val_13.characterInfo + 96 + 1))) << 2);
                mem2[0] = 0;
                var val_24 = ((((long)(int)(val_7) * 328) + val_11.characterInfo + 80 * 72) + val_18.meshInfo + 88) + (((long)(int)((((long)(int)(val_7) * 328) + val_13.characterInfo + 96 + 2))) << 2);
                mem2[0] = 0;
                val_71 = (long)(((long)(int)(val_7) * 328) + val_13.characterInfo + 96) + 3;
                var val_26 = ((((long)(int)(val_7) * 328) + val_11.characterInfo + 80 * 72) + val_18.meshInfo + 88) + (((long)(int)((((long)(int)(val_7) * 328) + val_13.characterInfo + 96 + 3))) << 2);
                mem2[0] = 0;
                TMPro.TMP_TextInfo val_27 = this.m_TextMeshPro.textInfo;
                var val_28 = val_27.meshInfo + ((((long)(int)(val_7) * 328) + val_11.characterInfo + 80) * 72);
                (((long)(int)(val_7) * 328) + val_11.characterInfo + 80 * 72) + val_27.meshInfo + 32.colors32 = (((long)(int)(val_7) * 328) + val_11.characterInfo + 80 * 72) + val_18.meshInfo + 88;
            }
            
            label_20:
            UnityEngine.Vector3 val_29 = UnityEngine.Input.mousePosition;
            val_72 = val_29.x;
            val_73 = val_29.y;
            val_74 = val_29.z;
            int val_30 = TMPro.TMP_TextUtilities.FindIntersectingLink(text:  0, position:  new UnityEngine.Vector3() {x = val_72, y = val_73, z = val_74}, camera:  this.m_TextMeshPro);
            val_75 = this.m_selectedLink;
            if(val_30 != 1)
            {
                goto label_47;
            }
            
            if(val_75 != 1)
            {
                goto label_48;
            }
            
            val_75 = 0;
            label_47:
            val_76 = val_30;
            if(val_30 == val_75)
            {
                goto label_49;
            }
            
            label_48:
            val_76 = 0;
            this.m_selectedLink = val_76;
            label_49:
            if((val_30 != 1) && (val_30 != val_76))
            {
                    this.m_selectedLink = val_30;
                TMPro.TMP_TextInfo val_31 = this.m_TextMeshPro.textInfo;
                var val_32 = val_31.linkInfo + ((long)val_30 * 40);
                typeof(System.String[]).__il2cppRuntimeField_20 = "Link ID: \"";
                typeof(System.String[]).__il2cppRuntimeField_28 = ;
                typeof(System.String[]).__il2cppRuntimeField_30 = "\"   Link Text: \"";
                typeof(System.String[]).__il2cppRuntimeField_38 = ;
                typeof(System.String[]).__il2cppRuntimeField_40 = "\"";
                string val_33 = +0;
                UnityEngine.Debug.Log(message:  0);
                UnityEngine.Vector3 val_34 = UnityEngine.Vector3.zero;
                UnityEngine.Vector3 val_36 = UnityEngine.Input.mousePosition;
                val_74 = val_36.z;
                UnityEngine.Vector2 val_37 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_36.x, y = val_36.y, z = val_74});
                val_72 = val_37.x;
                val_73 = val_37.y;
                bool val_38 = UnityEngine.RectTransformUtility.ScreenPointToWorldPointInRectangle(rect:  0, screenPoint:  new UnityEngine.Vector2() {x = val_72, y = val_73}, cam:  this.m_TextMeshPro.rectTransform, worldPoint: out  new UnityEngine.Vector3() {x = this.m_Camera, y = this.m_Camera, z = this.m_Camera});
                if((((long)(int)(val_30) * 40) + val_31.linkInfo + 32) != 0)
            {
                    if((System.String.op_Equality(a:  0, b:  ((long)(int)(val_30) * 40) + val_31.linkInfo + 32)) != true)
            {
                    bool val_41 = System.String.op_Equality(a:  0, b:  ((long)(int)(val_30) * 40) + val_31.linkInfo + 32);
            }
            
            }
            
            }
            
            UnityEngine.Vector3 val_42 = UnityEngine.Input.mousePosition;
            val_67 = val_42.x;
            val_68 = val_42.z;
            val_70 = UnityEngine.Camera.main;
            int val_44 = TMPro.TMP_TextUtilities.FindIntersectingWord(text:  0, position:  new UnityEngine.Vector3() {x = val_67, y = val_42.y, z = val_68}, camera:  this.m_TextMeshPro);
            if(val_44 == 1)
            {
                    return;
            }
            
            if(val_44 == this.m_lastWordIndex)
            {
                    return;
            }
            
            this.m_lastWordIndex = val_44;
            TMPro.TMP_TextInfo val_45 = this.m_TextMeshPro.textInfo;
            var val_66 = 24;
            val_66 = val_45.wordInfo + ((long)val_44 * val_66);
            val_69 = mem[((long)(int)(val_44) * 24) + val_45.wordInfo + 40];
            val_69 = ((long)(int)(val_44) * 24) + val_45.wordInfo + 40;
            TMPro.TMP_TextInfo val_47 = this.m_TextMeshPro.textInfo;
            var val_48 = val_47.characterInfo + (val_69 * 328);
            UnityEngine.Vector3 val_49 = this.m_TextMeshPro.transform.TransformPoint(position:  new UnityEngine.Vector3() {x = (((long)(int)(val_44) * 24) + val_45.wordInfo + 40 * 328) + val_47.characterInfo + 272, y = (((long)(int)(val_44) * 24) + val_45.wordInfo + 40 * 328) + val_47.characterInfo + 276, z = (((long)(int)(val_44) * 24) + val_45.wordInfo + 40 * 328) + val_47.characterInfo + 280});
            val_67 = val_49.x;
            val_68 = val_49.z;
            UnityEngine.Vector3 val_51 = UnityEngine.Camera.main.WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = val_67, y = val_49.y, z = val_68});
            TMPro.TMP_TextInfo val_52 = this.m_TextMeshPro.textInfo;
            TMPro.TMP_MeshInfo val_67 = val_52.meshInfo[0];
            int val_53 = UnityEngine.Random.Range(min:  0, max:  0);
            int val_54 = UnityEngine.Random.Range(min:  0, max:  0);
            int val_55 = UnityEngine.Random.Range(min:  0, max:  0);
            val_77 = 0;
            val_71 = 328;
            goto label_112;
            label_123:
            TMPro.TMP_MeshInfo val_56 = val_67 + ((val_53) << 2);
            val_77 = 1;
            tangents = (long)(((long)(int)(val_7) * 328) + val_13.characterInfo + 96) + 2;
            label_112:
            val_70 = this.m_TextMeshPro;
            if(val_77 >= (((long)(int)(val_44) * 24) + val_45.wordInfo + 48))
            {
                goto label_114;
            }
            
            TMPro.TMP_TextInfo val_57 = val_70.textInfo;
            var val_59 = val_57.characterInfo + (((long)val_69 + val_77) * 328);
            TMPro.TMP_MeshInfo val_60 = val_67 + ((((long)(int)((((long)(int)(val_44) * 24) + val_45.wordInfo + 40 + val_77)) * 328) + val_57.characterInfo + 96) << 2);
            tangents = 0;
            var val_61 = (((long)(int)((((long)(int)(val_44) * 24) + val_45.wordInfo + 40 + val_77)) * 328) + val_57.characterInfo + 96) + 1;
            TMPro.TMP_MeshInfo val_62 = val_67 + (((long)(int)((((long)(int)((((long)(int)(val_44) * 24) + val_45.wordInfo + 40 + val_77)) * 328) + val_57.characterInfo + 96 + 1))) << 2);
            tangents = 0;
            var val_63 = (((long)(int)((((long)(int)(val_44) * 24) + val_45.wordInfo + 40 + val_77)) * 328) + val_57.characterInfo + 96) + 2;
            TMPro.TMP_MeshInfo val_64 = val_67 + (((long)(int)((((long)(int)((((long)(int)(val_44) * 24) + val_45.wordInfo + 40 + val_77)) * 328) + val_57.characterInfo + 96 + 2))) << 2);
            tangents = 0;
            if(((((long)(int)((((long)(int)(val_44) * 24) + val_45.wordInfo + 40 + val_77)) * 328) + val_57.characterInfo + 96) + 3) < val_52.meshInfo[0].normals)
            {
                goto label_123;
            }
            
            goto label_123;
            label_114:
            val_66 = val_70;
            val_66.colors32 = val_67;
        }
        public void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData)
        {
            UnityEngine.Debug.Log(message:  0);
            this.m_isHoveringObject = true;
        }
        public void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData)
        {
            UnityEngine.Debug.Log(message:  0);
            this.m_isHoveringObject = false;
        }
    
    }

}
