using UnityEngine;

namespace TMPro.Examples
{
    public class TMP_TextSelector_B : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler, IPointerUpHandler, IEventSystemHandler
    {
        // Fields
        public UnityEngine.RectTransform TextPopup_Prefab_01;
        private UnityEngine.RectTransform m_TextPopup_RectTransform;
        private TMPro.TextMeshProUGUI m_TextPopup_TMPComponent;
        private const string k_LinkText = "You have selected link <#ffff00>";
        private const string k_WordText = "Word Index: <#ffff00>";
        private TMPro.TextMeshProUGUI m_TextMeshPro;
        private UnityEngine.Canvas m_Canvas;
        private UnityEngine.Camera m_Camera;
        private bool isHoveringObject;
        private int m_selectedWord;
        private int m_selectedLink;
        private int m_lastIndex;
        private UnityEngine.Matrix4x4 m_matrix;
        private TMPro.TMP_MeshInfo[] m_cachedMeshInfoVertexData;
        
        // Methods
        public TMP_TextSelector_B()
        {
            this.m_selectedWord = 0;
            this.m_selectedLink = 0;
            this.m_lastIndex = 0;
        }
        private void Awake()
        {
            this.m_TextMeshPro = this.gameObject.GetComponent<TMPro.TextMeshProUGUI>();
            UnityEngine.Canvas val_4 = this.gameObject.GetComponentInParent<UnityEngine.Canvas>();
            this.m_Canvas = val_4;
            if(val_4.renderMode != 0)
            {
                    this.m_Camera = this.m_Canvas.worldCamera;
            }
            else
            {
                    this.m_Camera = 0;
            }
            
            Unitycoding.UIWidgets.RadialMenuItem val_7 = UnityEngine.Object.Instantiate<Unitycoding.UIWidgets.RadialMenuItem>(original:  0);
            this.m_TextPopup_RectTransform = val_7;
            val_7.SetParent(parent:  this.m_Canvas.transform, worldPositionStays:  false);
            this.m_TextPopup_TMPComponent = this.m_TextPopup_RectTransform.GetComponentInChildren<TMPro.TextMeshProUGUI>();
            this.m_TextPopup_RectTransform.gameObject.SetActive(value:  false);
        }
        private void OnEnable()
        {
            null = null;
            TMPro.TMPro_EventManager.TEXT_CHANGED_EVENT.Add(rhs:  new System.Action<UnityEngine.Object>(object:  this, method:  System.Void TMPro.Examples.TMP_TextSelector_B::ON_TEXT_CHANGED(UnityEngine.Object obj)));
        }
        private void OnDisable()
        {
            null = null;
            TMPro.TMPro_EventManager.TEXT_CHANGED_EVENT.Remove(rhs:  new System.Action<UnityEngine.Object>(object:  this, method:  System.Void TMPro.Examples.TMP_TextSelector_B::ON_TEXT_CHANGED(UnityEngine.Object obj)));
        }
        private void ON_TEXT_CHANGED(UnityEngine.Object obj)
        {
            if(0 != obj)
            {
                    return;
            }
            
            this.m_cachedMeshInfoVertexData = this.m_TextMeshPro.textInfo.CopyMeshInfoVertexData();
        }
        private void LateUpdate()
        {
            var val_30;
            var val_31;
            var val_32;
            UnityEngine.Matrix4x4 val_33;
            TMPro.TextMeshProUGUI val_102;
            var val_103;
            var val_104;
            float val_105;
            float val_106;
            float val_107;
            int val_108;
            var val_109;
            var val_110;
            var val_111;
            float val_112;
            int val_113;
            UnityEngine.Camera val_114;
            float val_115;
            float val_116;
            int val_117;
            int val_118;
            string val_119;
            val_102 = this;
            if(this.isHoveringObject == false)
            {
                goto label_1;
            }
            
            val_103 = 1152921504719626240;
            UnityEngine.Vector3 val_1 = UnityEngine.Input.mousePosition;
            val_104 = 1152921504824311808;
            val_105 = val_1.x;
            val_106 = val_1.y;
            val_107 = val_1.z;
            int val_2 = TMPro.TMP_TextUtilities.FindIntersectingCharacter(text:  0, position:  new UnityEngine.Vector3() {x = val_105, y = val_106, z = val_107}, camera:  this.m_TextMeshPro, visibleOnly:  this.m_Camera);
            if(val_2 == 1)
            {
                goto label_6;
            }
            
            val_108 = val_2;
            if(val_2 != this.m_lastIndex)
            {
                    this.RestoreCachedVertexAttributes(index:  this.m_lastIndex);
                val_108 = 0;
                this.m_lastIndex = val_108;
            }
            
            if(val_2 == val_108)
            {
                goto label_78;
            }
            
            if((UnityEngine.Input.GetKey(key:  0)) != true)
            {
                    if((UnityEngine.Input.GetKey(key:  0)) == false)
            {
                goto label_78;
            }
            
            }
            
            this.m_lastIndex = val_2;
            TMPro.TMP_TextInfo val_6 = this.m_TextMeshPro.textInfo;
            var val_7 = val_6.characterInfo + ((long)val_2 * 328);
            TMPro.TMP_TextInfo val_8 = this.m_TextMeshPro.textInfo;
            var val_9 = val_8.characterInfo + ((long)val_2 * 328);
            var val_101 = ((long)(int)(val_2) * 328) + val_8.characterInfo + 96;
            TMPro.TMP_TextInfo val_10 = this.m_TextMeshPro.textInfo;
            var val_11 = val_10.meshInfo + ((((long)(int)(val_2) * 328) + val_6.characterInfo + 80) * 72);
            val_109 = mem[(((long)(int)(val_2) * 328) + val_6.characterInfo + 80 * 72) + val_10.meshInfo + 48];
            val_109 = (((long)(int)(val_2) * 328) + val_6.characterInfo + 80 * 72) + val_10.meshInfo + 48;
            val_110 = mem[(((long)(int)(val_2) * 328) + val_6.characterInfo + 80 * 72) + val_10.meshInfo + 48 + 24];
            val_110 = (((long)(int)(val_2) * 328) + val_6.characterInfo + 80 * 72) + val_10.meshInfo + 48 + 24;
            if(val_101 >= val_110)
            {
                    val_110 = mem[(((long)(int)(val_2) * 328) + val_6.characterInfo + 80 * 72) + val_10.meshInfo + 48 + 24];
                val_110 = (((long)(int)(val_2) * 328) + val_6.characterInfo + 80 * 72) + val_10.meshInfo + 48 + 24;
            }
            
            var val_12 = val_109 + (val_101 * 12);
            var val_14 = val_109 + (((long)val_101 + 2) * 12);
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = (((long)(int)(val_2) * 328) + val_8.characterInfo + 96 * 12) + (((long)(int)(val_2) * 328) + val_6.characterInfo + 80 * 72) + val_10.meshInfo + 48 + 32, y = (((long)(int)(val_2) * 328) + val_8.characterInfo + 96 * 12) + (((long)(int)(val_2) * 328) + val_6.characterInfo + 80 * 72) + val_10.meshInfo + 48 + 32 + 4, z = (((long)(int)(val_2) * 328) + val_8.characterInfo + 96 * 12) + (((long)(int)(val_2) * 328) + val_6.characterInfo + 80 * 72) + val_10.meshInfo + 48 + 32 + 8}, b:  new UnityEngine.Vector3() {x = ((long)(int)((((long)(int)(val_2) * 328) + val_8.characterInfo + 96 + 2)) * 12) + (((long)(int)(val_2) * 328) + val_6.characterInfo + 80 * 72) + val_10.meshInfo + 48 + 32, y = ((long)(int)((((long)(int)(val_2) * 328) + val_8.characterInfo + 96 + 2)) * 12) + (((long)(int)(val_2) * 328) + val_6.characterInfo + 80 * 72) + val_10.meshInfo + 48 + 32 + 4, z = ((long)(int)((((long)(int)(val_2) * 328) + val_8.characterInfo + 96 + 2)) * 12) + (((long)(int)(val_2) * 328) + val_6.characterInfo + 80 * 72) + val_10.meshInfo + 48 + 32 + 8});
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, d:  2f);
            UnityEngine.Vector2 val_17 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z});
            UnityEngine.Vector3 val_18 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_17.x, y = val_17.y});
            UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = (((long)(int)(val_2) * 328) + val_8.characterInfo + 96 * 12) + (((long)(int)(val_2) * 328) + val_6.characterInfo + 80 * 72) + val_10.meshInfo + 48 + 32, y = (((long)(int)(val_2) * 328) + val_8.characterInfo + 96 * 12) + (((long)(int)(val_2) * 328) + val_6.characterInfo + 80 * 72) + val_10.meshInfo + 48 + 32 + 4, z = (((long)(int)(val_2) * 328) + val_8.characterInfo + 96 * 12) + (((long)(int)(val_2) * 328) + val_6.characterInfo + 80 * 72) + val_10.meshInfo + 48 + 32 + 8}, b:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
            mem2[0] = val_19.x;
            mem2[0] = val_19.y;
            mem2[0] = val_19.z;
            val_101 = val_109 + (((long)val_101 + 1) * 12);
            UnityEngine.Vector3 val_21 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = ((long)(int)((((long)(int)(val_2) * 328) + val_8.characterInfo + 96 + 1)) * 12) + (((long)(int)(val_2) * 328) + val_6.characterInfo + 80 * 72) + val_10.meshInfo + 48 + 32, y = ((long)(int)((((long)(int)(val_2) * 328) + val_8.characterInfo + 96 + 1)) * 12) + (((long)(int)(val_2) * 328) + val_6.characterInfo + 80 * 72) + val_10.meshInfo + 48 + 32 + 4, z = ((long)(int)((((long)(int)(val_2) * 328) + val_8.characterInfo + 96 + 1)) * 12) + (((long)(int)(val_2) * 328) + val_6.characterInfo + 80 * 72) + val_10.meshInfo + 48 + 32 + 8}, b:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
            mem2[0] = val_21.x;
            mem2[0] = val_21.y;
            mem2[0] = val_21.z;
            UnityEngine.Vector3 val_22 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = ((long)(int)((((long)(int)(val_2) * 328) + val_8.characterInfo + 96 + 2)) * 12) + (((long)(int)(val_2) * 328) + val_6.characterInfo + 80 * 72) + val_10.meshInfo + 48 + 32, y = ((long)(int)((((long)(int)(val_2) * 328) + val_8.characterInfo + 96 + 2)) * 12) + (((long)(int)(val_2) * 328) + val_6.characterInfo + 80 * 72) + val_10.meshInfo + 48 + 32 + 4, z = ((long)(int)((((long)(int)(val_2) * 328) + val_8.characterInfo + 96 + 2)) * 12) + (((long)(int)(val_2) * 328) + val_6.characterInfo + 80 * 72) + val_10.meshInfo + 48 + 32 + 8}, b:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
            var val_102 = val_101;
            mem2[0] = val_22.x;
            mem2[0] = val_22.y;
            mem2[0] = val_22.z;
            val_102 = val_102 + 3;
            var val_23 = val_109 + ((long)val_102 * 12);
            val_111 = ((long)(int)((((long)(int)(val_2) * 328) + val_8.characterInfo + 96 + 3)) * 12) + (((long)(int)(val_2) * 328) + val_6.characterInfo + 80 * 72) + val_10.meshInfo + 48 + 32;
            UnityEngine.Vector3 val_24 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = ((long)(int)((((long)(int)(val_2) * 328) + val_8.characterInfo + 96 + 3)) * 12) + (((long)(int)(val_2) * 328) + val_6.characterInfo + 80 * 72) + val_10.meshInfo + 48 + 32, y = ((long)(int)((((long)(int)(val_2) * 328) + val_8.characterInfo + 96 + 3)) * 12) + (((long)(int)(val_2) * 328) + val_6.characterInfo + 80 * 72) + val_10.meshInfo + 48 + 32 + 4, z = ((long)(int)((((long)(int)(val_2) * 328) + val_8.characterInfo + 96 + 3)) * 12) + (((long)(int)(val_2) * 328) + val_6.characterInfo + 80 * 72) + val_10.meshInfo + 48 + 32 + 8}, b:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
            mem2[0] = val_24.x;
            mem2[0] = val_24.y;
            mem2[0] = val_24.z;
            UnityEngine.Vector3 val_25 = UnityEngine.Vector3.zero;
            UnityEngine.Quaternion val_26 = UnityEngine.Quaternion.identity;
            UnityEngine.Vector3 val_27 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_28 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z}, d:  1.5f);
            UnityEngine.Matrix4x4 val_29 = UnityEngine.Matrix4x4.TRS(pos:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z}, q:  new UnityEngine.Quaternion() {x = val_26.x, y = val_26.y, z = val_26.z, w = val_26.w}, s:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.z});
            mem[1152921512536039416] = val_30;
            mem[1152921512536039400] = val_31;
            mem[1152921512536039384] = val_32;
            this.m_matrix = val_33;
            mem2[0] = (((long)(int)(val_2) * 328) + val_8.characterInfo + 96 * 12) + (((long)(int)(val_2) * 328) + val_6.characterInfo + 80 * 72) + val_10.meshInfo + 48 + 32;
            mem2[0] = (((long)(int)(val_2) * 328) + val_8.characterInfo + 96 * 12) + (((long)(int)(val_2) * 328) + val_6.characterInfo + 80 * 72) + val_10.meshInfo + 48 + 32 + 4;
            mem2[0] = (((long)(int)(val_2) * 328) + val_8.characterInfo + 96 * 12) + (((long)(int)(val_2) * 328) + val_6.characterInfo + 80 * 72) + val_10.meshInfo + 48 + 32 + 8;
            mem2[0] = ((long)(int)((((long)(int)(val_2) * 328) + val_8.characterInfo + 96 + 1)) * 12) + (((long)(int)(val_2) * 328) + val_6.characterInfo + 80 * 72) + val_10.meshInfo + 48 + 32;
            mem2[0] = ((long)(int)((((long)(int)(val_2) * 328) + val_8.characterInfo + 96 + 1)) * 12) + (((long)(int)(val_2) * 328) + val_6.characterInfo + 80 * 72) + val_10.meshInfo + 48 + 32 + 4;
            mem2[0] = ((long)(int)((((long)(int)(val_2) * 328) + val_8.characterInfo + 96 + 1)) * 12) + (((long)(int)(val_2) * 328) + val_6.characterInfo + 80 * 72) + val_10.meshInfo + 48 + 32 + 8;
            mem2[0] = ((long)(int)((((long)(int)(val_2) * 328) + val_8.characterInfo + 96 + 2)) * 12) + (((long)(int)(val_2) * 328) + val_6.characterInfo + 80 * 72) + val_10.meshInfo + 48 + 32;
            mem2[0] = ((long)(int)((((long)(int)(val_2) * 328) + val_8.characterInfo + 96 + 2)) * 12) + (((long)(int)(val_2) * 328) + val_6.characterInfo + 80 * 72) + val_10.meshInfo + 48 + 32 + 4;
            mem2[0] = ((long)(int)((((long)(int)(val_2) * 328) + val_8.characterInfo + 96 + 2)) * 12) + (((long)(int)(val_2) * 328) + val_6.characterInfo + 80 * 72) + val_10.meshInfo + 48 + 32 + 8;
            mem2[0] = ((long)(int)((((long)(int)(val_2) * 328) + val_8.characterInfo + 96 + 3)) * 12) + (((long)(int)(val_2) * 328) + val_6.characterInfo + 80 * 72) + val_10.meshInfo + 48 + 32;
            mem2[0] = ((long)(int)((((long)(int)(val_2) * 328) + val_8.characterInfo + 96 + 3)) * 12) + (((long)(int)(val_2) * 328) + val_6.characterInfo + 80 * 72) + val_10.meshInfo + 48 + 32 + 4;
            mem2[0] = ((long)(int)((((long)(int)(val_2) * 328) + val_8.characterInfo + 96 + 3)) * 12) + (((long)(int)(val_2) * 328) + val_6.characterInfo + 80 * 72) + val_10.meshInfo + 48 + 32 + 8;
            UnityEngine.Vector3 val_34 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = (((long)(int)(val_2) * 328) + val_8.characterInfo + 96 * 12) + (((long)(int)(val_2) * 328) + val_6.characterInfo + 80 * 72) + val_10.meshInfo + 48 + 32, y = (((long)(int)(val_2) * 328) + val_8.characterInfo + 96 * 12) + (((long)(int)(val_2) * 328) + val_6.characterInfo + 80 * 72) + val_10.meshInfo + 48 + 32 + 4, z = (((long)(int)(val_2) * 328) + val_8.characterInfo + 96 * 12) + (((long)(int)(val_2) * 328) + val_6.characterInfo + 80 * 72) + val_10.meshInfo + 48 + 32 + 8}, b:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
            mem2[0] = val_34.x;
            mem2[0] = val_34.y;
            mem2[0] = val_34.z;
            UnityEngine.Vector3 val_35 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = ((long)(int)((((long)(int)(val_2) * 328) + val_8.characterInfo + 96 + 1)) * 12) + (((long)(int)(val_2) * 328) + val_6.characterInfo + 80 * 72) + val_10.meshInfo + 48 + 32, y = ((long)(int)((((long)(int)(val_2) * 328) + val_8.characterInfo + 96 + 1)) * 12) + (((long)(int)(val_2) * 328) + val_6.characterInfo + 80 * 72) + val_10.meshInfo + 48 + 32 + 4, z = ((long)(int)((((long)(int)(val_2) * 328) + val_8.characterInfo + 96 + 1)) * 12) + (((long)(int)(val_2) * 328) + val_6.characterInfo + 80 * 72) + val_10.meshInfo + 48 + 32 + 8}, b:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
            mem2[0] = val_35.x;
            mem2[0] = val_35.y;
            mem2[0] = val_35.z;
            UnityEngine.Vector3 val_36 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = ((long)(int)((((long)(int)(val_2) * 328) + val_8.characterInfo + 96 + 2)) * 12) + (((long)(int)(val_2) * 328) + val_6.characterInfo + 80 * 72) + val_10.meshInfo + 48 + 32, y = ((long)(int)((((long)(int)(val_2) * 328) + val_8.characterInfo + 96 + 2)) * 12) + (((long)(int)(val_2) * 328) + val_6.characterInfo + 80 * 72) + val_10.meshInfo + 48 + 32 + 4, z = ((long)(int)((((long)(int)(val_2) * 328) + val_8.characterInfo + 96 + 2)) * 12) + (((long)(int)(val_2) * 328) + val_6.characterInfo + 80 * 72) + val_10.meshInfo + 48 + 32 + 8}, b:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
            val_104 = 1152921504824311808;
            mem2[0] = val_36.x;
            mem2[0] = val_36.y;
            mem2[0] = val_36.z;
            val_105 = mem[((long)(int)((((long)(int)(val_2) * 328) + val_8.characterInfo + 96 + 3)) * 12) + (((long)(int)(val_2) * 328) + val_6.characterInfo + 80 * 72) + val_10.meshInfo + 48 + 32];
            val_105 = ((long)(int)((((long)(int)(val_2) * 328) + val_8.characterInfo + 96 + 3)) * 12) + (((long)(int)(val_2) * 328) + val_6.characterInfo + 80 * 72) + val_10.meshInfo + 48 + 32;
            val_106 = mem[((long)(int)((((long)(int)(val_2) * 328) + val_8.characterInfo + 96 + 3)) * 12) + (((long)(int)(val_2) * 328) + val_6.characterInfo + 80 * 72) + val_10.meshInfo + 48 + 32 + 4];
            val_106 = ((long)(int)((((long)(int)(val_2) * 328) + val_8.characterInfo + 96 + 3)) * 12) + (((long)(int)(val_2) * 328) + val_6.characterInfo + 80 * 72) + val_10.meshInfo + 48 + 32 + 4;
            val_107 = mem[((long)(int)((((long)(int)(val_2) * 328) + val_8.characterInfo + 96 + 3)) * 12) + (((long)(int)(val_2) * 328) + val_6.characterInfo + 80 * 72) + val_10.meshInfo + 48 + 32 + 8];
            val_107 = ((long)(int)((((long)(int)(val_2) * 328) + val_8.characterInfo + 96 + 3)) * 12) + (((long)(int)(val_2) * 328) + val_6.characterInfo + 80 * 72) + val_10.meshInfo + 48 + 32 + 8;
            UnityEngine.Vector3 val_37 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_105, y = val_106, z = val_107}, b:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
            mem2[0] = val_37.x;
            mem2[0] = val_37.y;
            mem2[0] = val_37.z;
            TMPro.TMP_TextInfo val_38 = this.m_TextMeshPro.textInfo;
            val_103 = 1152921504719626240;
            var val_39 = val_38.meshInfo + ((((long)(int)(val_2) * 328) + val_6.characterInfo + 80) * 72);
            var val_40 = ((((long)(int)(val_2) * 328) + val_6.characterInfo + 80 * 72) + val_38.meshInfo + 88) + ((((long)(int)(val_2) * 328) + val_8.characterInfo + 96) << 2);
            mem2[0] = 0;
            var val_41 = ((((long)(int)(val_2) * 328) + val_6.characterInfo + 80 * 72) + val_38.meshInfo + 88) + (((long)(int)((((long)(int)(val_2) * 328) + val_8.characterInfo + 96 + 1))) << 2);
            mem2[0] = 0;
            var val_42 = ((((long)(int)(val_2) * 328) + val_6.characterInfo + 80 * 72) + val_38.meshInfo + 88) + (((long)(int)((((long)(int)(val_2) * 328) + val_8.characterInfo + 96 + 2))) << 2);
            mem2[0] = 0;
            var val_43 = ((((long)(int)(val_2) * 328) + val_6.characterInfo + 80 * 72) + val_38.meshInfo + 88) + (((long)(int)((((long)(int)(val_2) * 328) + val_8.characterInfo + 96 + 3))) << 2);
            mem2[0] = 0;
            TMPro.TMP_TextInfo val_44 = this.m_TextMeshPro.textInfo;
            var val_46 = (val_44.meshInfo + ((((long)(int)(val_2) * 328) + val_6.characterInfo + 80) * 72)) + 32;
            var val_47 = ((((long)(int)(val_2) * 328) + val_6.characterInfo + 80 * 72) + val_10.meshInfo + 48 + 24) - 4;
            if(this.m_TextMeshPro != null)
            {
                goto label_78;
            }
            
            goto label_78;
            label_1:
            if(this.m_lastIndex == 1)
            {
                    return;
            }
            
            this.RestoreCachedVertexAttributes(index:  this.m_lastIndex);
            this.m_lastIndex = 0;
            return;
            label_6:
            this.RestoreCachedVertexAttributes(index:  this.m_lastIndex);
            this.m_lastIndex = 0;
            label_78:
            UnityEngine.Vector3 val_48 = UnityEngine.Input.mousePosition;
            val_112 = val_48.x;
            int val_49 = TMPro.TMP_TextUtilities.FindIntersectingWord(text:  0, position:  new UnityEngine.Vector3() {x = val_112, y = val_48.y, z = val_48.z}, camera:  this.m_TextMeshPro);
            if((0 == this.m_TextPopup_RectTransform) || (this.m_selectedWord == 1))
            {
                goto label_88;
            }
            
            if(val_49 == 1)
            {
                goto label_89;
            }
            
            val_113 = val_49;
            if(val_49 == this.m_selectedWord)
            {
                goto label_90;
            }
            
            label_89:
            TMPro.TMP_TextInfo val_51 = this.m_TextMeshPro.textInfo;
            var val_103 = 24;
            val_103 = val_51.wordInfo + (this.m_selectedWord * val_103);
            var val_105 = (this.m_selectedWord * 24) + val_51.wordInfo + 48;
            if(val_105 >= 1)
            {
                    var val_104 = (this.m_selectedWord * 24) + val_51.wordInfo + 40;
                val_109 = 72;
                do
            {
                TMPro.TMP_TextInfo val_52 = this.m_TextMeshPro.textInfo;
                var val_53 = val_52.characterInfo + ((long)val_104 * 328);
                TMPro.TMP_TextInfo val_54 = this.m_TextMeshPro.textInfo;
                var val_55 = val_54.characterInfo + ((long)val_104 * 328);
                TMPro.TMP_TextInfo val_56 = this.m_TextMeshPro.textInfo;
                var val_57 = val_56.meshInfo + ((((long)(int)((this.m_selectedWord * 24) + val_51.wordInfo + 40) * 328) + val_52.characterInfo + 80) * 72);
                val_111 = mem[(((long)(int)((this.m_selectedWord * 24) + val_51.wordInfo + 40) * 328) + val_52.characterInfo + 80 * 72) + val_56.meshInfo + 88];
                val_111 = (((long)(int)((this.m_selectedWord * 24) + val_51.wordInfo + 40) * 328) + val_52.characterInfo + 80 * 72) + val_56.meshInfo + 88;
                var val_58 = val_111 + ((((long)(int)((this.m_selectedWord * 24) + val_51.wordInfo + 40) * 328) + val_54.characterInfo + 96) << 2);
                val_112 = 1.33333f;
                UnityEngine.Color32 val_59 = TMPro.TMPro_ExtensionMethods.Tint(c1:  new UnityEngine.Color32(), tint:  1.33333f);
                mem2[0] = val_59.r;
                mem[1] = val_59.g;
                mem[2] = val_59.b;
                mem[3] = val_59.a;
                var val_60 = (((long)(int)((this.m_selectedWord * 24) + val_51.wordInfo + 40) * 328) + val_54.characterInfo + 96) + 1;
                var val_61 = val_111 + (((long)(int)((((long)(int)((this.m_selectedWord * 24) + val_51.wordInfo + 40) * 328) + val_54.characterInfo + 96 + 1))) << 2);
                mem2[0] = val_59.r;
                mem[1] = val_59.g;
                mem[2] = val_59.b;
                mem[3] = val_59.a;
                var val_62 = (((long)(int)((this.m_selectedWord * 24) + val_51.wordInfo + 40) * 328) + val_54.characterInfo + 96) + 2;
                var val_63 = val_111 + (((long)(int)((((long)(int)((this.m_selectedWord * 24) + val_51.wordInfo + 40) * 328) + val_54.characterInfo + 96 + 2))) << 2);
                mem2[0] = val_59.r;
                mem[1] = val_59.g;
                mem[2] = val_59.b;
                mem[3] = val_59.a;
                var val_64 = (((long)(int)((this.m_selectedWord * 24) + val_51.wordInfo + 40) * 328) + val_54.characterInfo + 96) + 3;
                var val_65 = val_111 + (((long)(int)((((long)(int)((this.m_selectedWord * 24) + val_51.wordInfo + 40) * 328) + val_54.characterInfo + 96 + 3))) << 2);
                val_104 = val_104 + 1;
                val_105 = val_105 - 1;
                mem2[0] = val_59.r;
                mem[1] = val_59.g;
                mem[2] = val_59.b;
                mem[3] = val_59.a;
            }
            while(val_105 != 0);
            
            }
            
            this.m_selectedWord = 0;
            val_103 = 1152921504719626240;
            val_104 = 1152921504824311808;
            label_88:
            if(val_49 == 1)
            {
                goto label_123;
            }
            
            val_113 = this.m_selectedWord;
            label_90:
            if(((val_49 != val_113) && ((UnityEngine.Input.GetKey(key:  0)) != true)) && ((UnityEngine.Input.GetKey(key:  0)) != true))
            {
                    this.m_selectedWord = val_49;
                TMPro.TMP_TextInfo val_70 = this.m_TextMeshPro.textInfo;
                var val_106 = 24;
                val_106 = val_70.wordInfo + ((long)val_49 * val_106);
                var val_108 = ((long)(int)(val_49) * 24) + val_70.wordInfo + 48;
                if(val_108 >= 1)
            {
                    var val_107 = ((long)(int)(val_49) * 24) + val_70.wordInfo + 40;
                do
            {
                TMPro.TMP_TextInfo val_71 = this.m_TextMeshPro.textInfo;
                var val_72 = val_71.characterInfo + ((long)val_107 * 328);
                TMPro.TMP_TextInfo val_73 = this.m_TextMeshPro.textInfo;
                var val_74 = val_73.characterInfo + ((long)val_107 * 328);
                TMPro.TMP_TextInfo val_75 = this.m_TextMeshPro.textInfo;
                var val_76 = val_75.meshInfo + ((((long)(int)(((long)(int)(val_49) * 24) + val_70.wordInfo + 40) * 328) + val_71.characterInfo + 80) * 72);
                var val_77 = ((((long)(int)(((long)(int)(val_49) * 24) + val_70.wordInfo + 40) * 328) + val_71.characterInfo + 80 * 72) + val_75.meshInfo + 88) + ((((long)(int)(((long)(int)(val_49) * 24) + val_70.wordInfo + 40) * 328) + val_73.characterInfo + 96) << 2);
                val_112 = 0.75f;
                UnityEngine.Color32 val_78 = TMPro.TMPro_ExtensionMethods.Tint(c1:  new UnityEngine.Color32(), tint:  val_112);
                mem2[0] = val_78.r;
                mem[1] = val_78.g;
                mem[2] = val_78.b;
                mem[3] = val_78.a;
                var val_79 = (((long)(int)(((long)(int)(val_49) * 24) + val_70.wordInfo + 40) * 328) + val_73.characterInfo + 96) + 1;
                var val_80 = ((((long)(int)(((long)(int)(val_49) * 24) + val_70.wordInfo + 40) * 328) + val_71.characterInfo + 80 * 72) + val_75.meshInfo + 88) + (((long)(int)((((long)(int)(((long)(int)(val_49) * 24) + val_70.wordInfo + 40) * 328) + val_73.characterInfo + 96 + 1))) << 2);
                mem2[0] = val_78.r;
                mem[1] = val_78.g;
                mem[2] = val_78.b;
                mem[3] = val_78.a;
                val_111 = (long)(((long)(int)(((long)(int)(val_49) * 24) + val_70.wordInfo + 40) * 328) + val_73.characterInfo + 96) + 2;
                var val_82 = ((((long)(int)(((long)(int)(val_49) * 24) + val_70.wordInfo + 40) * 328) + val_71.characterInfo + 80 * 72) + val_75.meshInfo + 88) + (((long)(int)((((long)(int)(((long)(int)(val_49) * 24) + val_70.wordInfo + 40) * 328) + val_73.characterInfo + 96 + 2))) << 2);
                mem2[0] = val_78.r;
                mem[1] = val_78.g;
                mem[2] = val_78.b;
                mem[3] = val_78.a;
                val_109 = (long)(((long)(int)(((long)(int)(val_49) * 24) + val_70.wordInfo + 40) * 328) + val_73.characterInfo + 96) + 3;
                var val_84 = ((((long)(int)(((long)(int)(val_49) * 24) + val_70.wordInfo + 40) * 328) + val_71.characterInfo + 80 * 72) + val_75.meshInfo + 88) + (((long)(int)((((long)(int)(((long)(int)(val_49) * 24) + val_70.wordInfo + 40) * 328) + val_73.characterInfo + 96 + 3))) << 2);
                val_107 = val_107 + 1;
                val_108 = val_108 - 1;
                mem2[0] = val_78.r;
                mem[1] = val_78.g;
                mem[2] = val_78.b;
                mem[3] = val_78.a;
            }
            while(val_108 != 0);
            
            }
            
                val_104 = 1152921504824311808;
                val_103 = val_103;
            }
            
            label_123:
            UnityEngine.Vector3 val_85 = UnityEngine.Input.mousePosition;
            val_114 = this.m_Camera;
            val_115 = val_85.x;
            val_116 = val_85.z;
            int val_86 = TMPro.TMP_TextUtilities.FindIntersectingLink(text:  0, position:  new UnityEngine.Vector3() {x = val_115, y = val_85.y, z = val_116}, camera:  this.m_TextMeshPro);
            val_117 = this.m_selectedLink;
            if(val_86 != 1)
            {
                goto label_153;
            }
            
            if(val_117 != 1)
            {
                goto label_154;
            }
            
            val_117 = 0;
            label_153:
            val_118 = val_86;
            if(val_86 == val_117)
            {
                goto label_155;
            }
            
            label_154:
            val_114 = this.m_TextPopup_RectTransform.gameObject;
            val_114.SetActive(value:  false);
            val_118 = 0;
            this.m_selectedLink = val_118;
            label_155:
            if(val_86 == 1)
            {
                    return;
            }
            
            if(val_86 == val_118)
            {
                    return;
            }
            
            this.m_selectedLink = val_86;
            TMPro.TMP_TextInfo val_88 = this.m_TextMeshPro.textInfo;
            var val_89 = val_88.linkInfo + ((long)val_86 * 40);
            UnityEngine.Vector3 val_90 = UnityEngine.Vector3.zero;
            UnityEngine.Vector3 val_92 = UnityEngine.Input.mousePosition;
            val_116 = val_92.z;
            UnityEngine.Vector2 val_93 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_92.x, y = val_92.y, z = val_116});
            val_114 = this.m_Camera;
            val_115 = val_93.x;
            bool val_94 = UnityEngine.RectTransformUtility.ScreenPointToWorldPointInRectangle(rect:  0, screenPoint:  new UnityEngine.Vector2() {x = val_115, y = val_93.y}, cam:  this.m_TextMeshPro.rectTransform, worldPoint: out  new UnityEngine.Vector3() {x = val_114, y = val_114, z = val_114});
            if((((long)(int)(val_86) * 40) + val_88.linkInfo + 32) == 0)
            {
                    return;
            }
            
            val_114 = 1152921504608284672;
            if((System.String.op_Equality(a:  0, b:  ((long)(int)(val_86) * 40) + val_88.linkInfo + 32)) != false)
            {
                    val_115 = val_90.x;
                val_116 = val_90.z;
                this.m_TextPopup_RectTransform.position = new UnityEngine.Vector3() {x = val_115, y = val_90.y, z = val_116};
                this.m_TextPopup_RectTransform.gameObject.SetActive(value:  true);
                val_102 = this.m_TextPopup_TMPComponent;
                val_119 = "You have selected link <#ffff00> ID 01";
            }
            else
            {
                    if((System.String.op_Equality(a:  0, b:  ((long)(int)(val_86) * 40) + val_88.linkInfo + 32)) == false)
            {
                    return;
            }
            
                val_115 = val_90.x;
                val_116 = val_90.z;
                this.m_TextPopup_RectTransform.position = new UnityEngine.Vector3() {x = val_115, y = val_90.y, z = val_116};
                this.m_TextPopup_RectTransform.gameObject.SetActive(value:  true);
                val_102 = this.m_TextPopup_TMPComponent;
                val_119 = "You have selected link <#ffff00> ID 02";
            }
            
            val_102.text = val_119;
        }
        public void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData)
        {
            this.isHoveringObject = true;
        }
        public void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData)
        {
            this.isHoveringObject = false;
        }
        public void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
        {
        
        }
        public void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
        {
        
        }
        private void RestoreCachedVertexAttributes(int index)
        {
            if(index == 1)
            {
                    return;
            }
            
            TMPro.TMP_TextInfo val_1 = this.m_TextMeshPro.textInfo;
            int val_107 = val_1.characterCount;
            val_107 = val_107 - 1;
            if(val_107 < index)
            {
                    return;
            }
            
            TMPro.TMP_TextInfo val_2 = this.m_TextMeshPro.textInfo;
            var val_3 = val_2.characterInfo + ((long)index * 328);
            TMPro.TMP_TextInfo val_4 = this.m_TextMeshPro.textInfo;
            var val_5 = val_4.characterInfo + ((long)index * 328);
            var val_6 = this.m_cachedMeshInfoVertexData + ((((long)(int)(index) * 328) + val_2.characterInfo + 80) * 72);
            TMPro.TMP_TextInfo val_7 = this.m_TextMeshPro.textInfo;
            var val_8 = val_7.meshInfo + ((((long)(int)(index) * 328) + val_2.characterInfo + 80) * 72);
            var val_108 = 12;
            val_108 = ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + val_7.meshInfo + 48) + ((((long)(int)(index) * 328) + val_4.characterInfo + 96) * val_108);
            var val_9 = val_108 + 32;
            var val_109 = 12;
            val_109 = ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 48) + ((((long)(int)(index) * 328) + val_4.characterInfo + 96) * val_109);
            mem2[0] = (((long)(int)(index) * 328) + val_4.characterInfo + 96 * 12) + (((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 48 + 40;
            mem2[0] = (((long)(int)(index) * 328) + val_4.characterInfo + 96 * 12) + (((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 48 + 32;
            var val_110 = 12;
            val_110 = ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + val_7.meshInfo + 48) + (((long)(((long)(int)(index) * 328) + val_4.characterInfo + 96) + 1) * val_110);
            var val_11 = val_110 + 32;
            var val_111 = 12;
            val_111 = ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 48) + (((long)(((long)(int)(index) * 328) + val_4.characterInfo + 96) + 1) * val_111);
            mem2[0] = ((long)(int)((((long)(int)(index) * 328) + val_4.characterInfo + 96 + 1)) * 12) + (((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 48 + 40;
            mem2[0] = ((long)(int)((((long)(int)(index) * 328) + val_4.characterInfo + 96 + 1)) * 12) + (((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 48 + 32;
            var val_112 = 12;
            val_112 = ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + val_7.meshInfo + 48) + (((long)(((long)(int)(index) * 328) + val_4.characterInfo + 96) + 2) * val_112);
            var val_13 = val_112 + 32;
            var val_113 = 12;
            val_113 = ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 48) + (((long)(((long)(int)(index) * 328) + val_4.characterInfo + 96) + 2) * val_113);
            mem2[0] = ((long)(int)((((long)(int)(index) * 328) + val_4.characterInfo + 96 + 2)) * 12) + (((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 48 + 40;
            mem2[0] = ((long)(int)((((long)(int)(index) * 328) + val_4.characterInfo + 96 + 2)) * 12) + (((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 48 + 32;
            var val_114 = 12;
            val_114 = ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + val_7.meshInfo + 48) + (((long)(((long)(int)(index) * 328) + val_4.characterInfo + 96) + 3) * val_114);
            var val_15 = val_114 + 32;
            var val_115 = 12;
            val_115 = ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 48) + (((long)(((long)(int)(index) * 328) + val_4.characterInfo + 96) + 3) * val_115);
            mem2[0] = ((long)(int)((((long)(int)(index) * 328) + val_4.characterInfo + 96 + 3)) * 12) + (((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 48 + 40;
            mem2[0] = ((long)(int)((((long)(int)(index) * 328) + val_4.characterInfo + 96 + 3)) * 12) + (((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 48 + 32;
            TMPro.TMP_TextInfo val_16 = this.m_TextMeshPro.textInfo;
            var val_17 = val_16.meshInfo + ((((long)(int)(index) * 328) + val_2.characterInfo + 80) * 72);
            var val_18 = this.m_cachedMeshInfoVertexData + ((((long)(int)(index) * 328) + val_2.characterInfo + 80) * 72);
            var val_19 = ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 88) + ((((long)(int)(index) * 328) + val_4.characterInfo + 96) << 2);
            var val_20 = ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + val_16.meshInfo + 88) + ((((long)(int)(index) * 328) + val_4.characterInfo + 96) << 2);
            mem2[0] = ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 88 + (((long)(int)(index) * 328) + val_4.characterInfo + 96) << 2) + 32;
            var val_21 = ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 88) + (((long)(int)((((long)(int)(index) * 328) + val_4.characterInfo + 96 + 1))) << 2);
            var val_22 = ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + val_16.meshInfo + 88) + (((long)(int)((((long)(int)(index) * 328) + val_4.characterInfo + 96 + 1))) << 2);
            mem2[0] = ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 88 + ((long)(int)((((long)(int)(index) * 328) + val_4.characterInfo + 96 + 1))) << 2) + 32;
            var val_23 = ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 88) + (((long)(int)((((long)(int)(index) * 328) + val_4.characterInfo + 96 + 2))) << 2);
            var val_24 = ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + val_16.meshInfo + 88) + (((long)(int)((((long)(int)(index) * 328) + val_4.characterInfo + 96 + 2))) << 2);
            mem2[0] = ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 88 + ((long)(int)((((long)(int)(index) * 328) + val_4.characterInfo + 96 + 2))) << 2) + 32;
            var val_25 = ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 88) + (((long)(int)((((long)(int)(index) * 328) + val_4.characterInfo + 96 + 3))) << 2);
            var val_26 = ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + val_16.meshInfo + 88) + (((long)(int)((((long)(int)(index) * 328) + val_4.characterInfo + 96 + 3))) << 2);
            mem2[0] = ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 88 + ((long)(int)((((long)(int)(index) * 328) + val_4.characterInfo + 96 + 3))) << 2) + 32;
            var val_27 = this.m_cachedMeshInfoVertexData + ((((long)(int)(index) * 328) + val_2.characterInfo + 80) * 72);
            TMPro.TMP_TextInfo val_28 = this.m_TextMeshPro.textInfo;
            var val_29 = val_28.meshInfo + ((((long)(int)(index) * 328) + val_2.characterInfo + 80) * 72);
            var val_31 = (((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + val_28.meshInfo + 72) + ((((long)(int)(index) * 328) + val_4.characterInfo + 96) << 3)) + 32;
            var val_32 = ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 72) + ((((long)(int)(index) * 328) + val_4.characterInfo + 96) << 3);
            mem2[0] = ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 72 + (((long)(int)(index) * 328) + val_4.characterInfo + 96) << 3) + 32;
            var val_34 = (((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + val_28.meshInfo + 72) + (((long)(int)((((long)(int)(index) * 328) + val_4.characterInfo + 96 + 1))) << 3)) + 32;
            var val_35 = ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 72) + (((long)(int)((((long)(int)(index) * 328) + val_4.characterInfo + 96 + 1))) << 3);
            mem2[0] = ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 72 + ((long)(int)((((long)(int)(index) * 328) + val_4.characterInfo + 96 + 1))) << 3) + 32;
            var val_37 = (((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + val_28.meshInfo + 72) + (((long)(int)((((long)(int)(index) * 328) + val_4.characterInfo + 96 + 2))) << 3)) + 32;
            var val_38 = ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 72) + (((long)(int)((((long)(int)(index) * 328) + val_4.characterInfo + 96 + 2))) << 3);
            mem2[0] = ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 72 + ((long)(int)((((long)(int)(index) * 328) + val_4.characterInfo + 96 + 2))) << 3) + 32;
            var val_40 = (((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + val_28.meshInfo + 72) + (((long)(int)((((long)(int)(index) * 328) + val_4.characterInfo + 96 + 3))) << 3)) + 32;
            var val_41 = ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 72) + (((long)(int)((((long)(int)(index) * 328) + val_4.characterInfo + 96 + 3))) << 3);
            mem2[0] = ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 72 + ((long)(int)((((long)(int)(index) * 328) + val_4.characterInfo + 96 + 3))) << 3) + 32;
            var val_42 = this.m_cachedMeshInfoVertexData + ((((long)(int)(index) * 328) + val_2.characterInfo + 80) * 72);
            TMPro.TMP_TextInfo val_43 = this.m_TextMeshPro.textInfo;
            var val_44 = val_43.meshInfo + ((((long)(int)(index) * 328) + val_2.characterInfo + 80) * 72);
            var val_46 = (((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + val_43.meshInfo + 80) + ((((long)(int)(index) * 328) + val_4.characterInfo + 96) << 3)) + 32;
            var val_47 = ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 80) + ((((long)(int)(index) * 328) + val_4.characterInfo + 96) << 3);
            mem2[0] = ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 80 + (((long)(int)(index) * 328) + val_4.characterInfo + 96) << 3) + 32;
            var val_49 = (((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + val_43.meshInfo + 80) + (((long)(int)((((long)(int)(index) * 328) + val_4.characterInfo + 96 + 1))) << 3)) + 32;
            var val_50 = ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 80) + (((long)(int)((((long)(int)(index) * 328) + val_4.characterInfo + 96 + 1))) << 3);
            mem2[0] = ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 80 + ((long)(int)((((long)(int)(index) * 328) + val_4.characterInfo + 96 + 1))) << 3) + 32;
            var val_52 = (((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + val_43.meshInfo + 80) + (((long)(int)((((long)(int)(index) * 328) + val_4.characterInfo + 96 + 2))) << 3)) + 32;
            var val_53 = ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 80) + (((long)(int)((((long)(int)(index) * 328) + val_4.characterInfo + 96 + 2))) << 3);
            mem2[0] = ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 80 + ((long)(int)((((long)(int)(index) * 328) + val_4.characterInfo + 96 + 2))) << 3) + 32;
            var val_55 = (((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + val_43.meshInfo + 80) + (((long)(int)((((long)(int)(index) * 328) + val_4.characterInfo + 96 + 3))) << 3)) + 32;
            var val_56 = ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 80) + (((long)(int)((((long)(int)(index) * 328) + val_4.characterInfo + 96 + 3))) << 3);
            mem2[0] = ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 80 + ((long)(int)((((long)(int)(index) * 328) + val_4.characterInfo + 96 + 3))) << 3) + 32;
            var val_116 = (((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 48 + 24;
            val_116 = (val_116 < 0) ? (val_116 + 3) : (val_116);
            var val_58 = val_116 & 4294967292;
            var val_117 = 12;
            val_117 = ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + val_7.meshInfo + 48) + (((long)val_58 - 4) * val_117);
            var val_60 = val_117 + 32;
            var val_118 = 12;
            val_118 = ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 48) + (((long)val_58 - 4) * val_118);
            mem2[0] = ((long)(int)((((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 48 + 24 < 0x0 ? ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfo) * 12) + (((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 48 + 40;
            mem2[0] = ((long)(int)((((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 48 + 24 < 0x0 ? ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfo) * 12) + (((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 48 + 32;
            var val_119 = 12;
            val_119 = ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + val_7.meshInfo + 48) + (((long)val_58 - 3) * val_119);
            var val_62 = val_119 + 32;
            var val_120 = 12;
            val_120 = ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 48) + (((long)val_58 - 3) * val_120);
            mem2[0] = ((long)(int)((((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 48 + 24 < 0x0 ? ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfo) * 12) + (((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 48 + 40;
            mem2[0] = ((long)(int)((((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 48 + 24 < 0x0 ? ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfo) * 12) + (((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 48 + 32;
            var val_121 = 12;
            val_121 = ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + val_7.meshInfo + 48) + (((long)val_58 - 2) * val_121);
            var val_64 = val_121 + 32;
            var val_122 = 12;
            val_122 = ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 48) + (((long)val_58 - 2) * val_122);
            mem2[0] = ((long)(int)((((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 48 + 24 < 0x0 ? ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfo) * 12) + (((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 48 + 40;
            mem2[0] = ((long)(int)((((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 48 + 24 < 0x0 ? ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfo) * 12) + (((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 48 + 32;
            var val_123 = 12;
            val_123 = ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + val_7.meshInfo + 48) + (((long)val_58 - 1) * val_123);
            val_58 = val_123 + 32;
            var val_124 = 12;
            val_124 = ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 48) + (((long)val_58 - 1) * val_124);
            mem2[0] = ((long)(int)((((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 48 + 24 < 0x0 ? ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfo) * 12) + (((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 48 + 40;
            mem2[0] = ((long)(int)((((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 48 + 24 < 0x0 ? ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfo) * 12) + (((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 48 + 32;
            var val_66 = this.m_cachedMeshInfoVertexData + ((((long)(int)(index) * 328) + val_2.characterInfo + 80) * 72);
            TMPro.TMP_TextInfo val_67 = this.m_TextMeshPro.textInfo;
            var val_68 = val_67.meshInfo + ((((long)(int)(index) * 328) + val_2.characterInfo + 80) * 72);
            var val_69 = ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 88) + (((long)(int)((((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 48 + 24 < 0x0 ? ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfo)) << 2);
            var val_70 = ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + val_67.meshInfo + 88) + (((long)(int)((((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 48 + 24 < 0x0 ? ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfo)) << 2);
            mem2[0] = ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 88 + ((long)(int)((((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshIn + 32;
            var val_71 = ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 88) + (((long)(int)((((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 48 + 24 < 0x0 ? ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfo)) << 2);
            var val_72 = ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + val_67.meshInfo + 88) + (((long)(int)((((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 48 + 24 < 0x0 ? ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfo)) << 2);
            mem2[0] = ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 88 + ((long)(int)((((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshIn + 32;
            var val_73 = ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 88) + (((long)(int)((((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 48 + 24 < 0x0 ? ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfo)) << 2);
            var val_74 = ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + val_67.meshInfo + 88) + (((long)(int)((((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 48 + 24 < 0x0 ? ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfo)) << 2);
            mem2[0] = ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 88 + ((long)(int)((((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshIn + 32;
            var val_75 = ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 88) + (((long)(int)((((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 48 + 24 < 0x0 ? ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfo)) << 2);
            var val_76 = ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + val_67.meshInfo + 88) + (((long)(int)((((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 48 + 24 < 0x0 ? ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfo)) << 2);
            mem2[0] = ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 88 + ((long)(int)((((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshIn + 32;
            var val_77 = this.m_cachedMeshInfoVertexData + ((((long)(int)(index) * 328) + val_2.characterInfo + 80) * 72);
            TMPro.TMP_TextInfo val_78 = this.m_TextMeshPro.textInfo;
            var val_79 = val_78.meshInfo + ((((long)(int)(index) * 328) + val_2.characterInfo + 80) * 72);
            var val_81 = (((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + val_78.meshInfo + 72) + (((long)(int)((((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 48 + 24 < 0x0 ? ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfo)) << 3)) + 32;
            var val_82 = ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 72) + (((long)(int)((((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 48 + 24 < 0x0 ? ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfo)) << 3);
            mem2[0] = ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 72 + ((long)(int)((((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshIn + 32;
            var val_84 = (((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + val_78.meshInfo + 72) + (((long)(int)((((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 48 + 24 < 0x0 ? ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfo)) << 3)) + 32;
            var val_85 = ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 72) + (((long)(int)((((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 48 + 24 < 0x0 ? ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfo)) << 3);
            mem2[0] = ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 72 + ((long)(int)((((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshIn + 32;
            var val_87 = (((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + val_78.meshInfo + 72) + (((long)(int)((((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 48 + 24 < 0x0 ? ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfo)) << 3)) + 32;
            var val_88 = ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 72) + (((long)(int)((((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 48 + 24 < 0x0 ? ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfo)) << 3);
            mem2[0] = ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 72 + ((long)(int)((((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshIn + 32;
            var val_90 = (((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + val_78.meshInfo + 72) + (((long)(int)((((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 48 + 24 < 0x0 ? ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfo)) << 3)) + 32;
            var val_91 = ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 72) + (((long)(int)((((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 48 + 24 < 0x0 ? ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfo)) << 3);
            mem2[0] = ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 72 + ((long)(int)((((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshIn + 32;
            var val_92 = this.m_cachedMeshInfoVertexData + ((((long)(int)(index) * 328) + val_2.characterInfo + 80) * 72);
            TMPro.TMP_TextInfo val_93 = this.m_TextMeshPro.textInfo;
            var val_94 = val_93.meshInfo + ((((long)(int)(index) * 328) + val_2.characterInfo + 80) * 72);
            var val_96 = (((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + val_93.meshInfo + 80) + (((long)(int)((((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 48 + 24 < 0x0 ? ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfo)) << 3)) + 32;
            var val_97 = ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 80) + (((long)(int)((((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 48 + 24 < 0x0 ? ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfo)) << 3);
            mem2[0] = ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 80 + ((long)(int)((((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshIn + 32;
            var val_99 = (((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + val_93.meshInfo + 80) + (((long)(int)((((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 48 + 24 < 0x0 ? ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfo)) << 3)) + 32;
            var val_100 = ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 80) + (((long)(int)((((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 48 + 24 < 0x0 ? ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfo)) << 3);
            mem2[0] = ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 80 + ((long)(int)((((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshIn + 32;
            var val_102 = (((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + val_93.meshInfo + 80) + (((long)(int)((((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 48 + 24 < 0x0 ? ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfo)) << 3)) + 32;
            var val_103 = ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 80) + (((long)(int)((((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 48 + 24 < 0x0 ? ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfo)) << 3);
            mem2[0] = ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 80 + ((long)(int)((((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshIn + 32;
            var val_105 = (((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + val_93.meshInfo + 80) + (((long)(int)((((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 48 + 24 < 0x0 ? ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfo)) << 3)) + 32;
            var val_106 = ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 80) + (((long)(int)((((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 48 + 24 < 0x0 ? ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfo)) << 3);
            mem2[0] = ((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshInfoVertexData + 80 + ((long)(int)((((((long)(int)(index) * 328) + val_2.characterInfo + 80 * 72) + this.m_cachedMeshIn + 32;
            if(this.m_TextMeshPro == null)
            {
                
            }
        
        }
    
    }

}
