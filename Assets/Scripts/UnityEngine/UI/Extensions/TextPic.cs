using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    [UnityEngine.AddComponentMenu]
    [UnityEngine.ExecuteInEditMode]
    public class TextPic : Text, IPointerClickHandler, IPointerExitHandler, IPointerEnterHandler, ISelectHandler, IEventSystemHandler
    {
        // Fields
        private readonly System.Collections.Generic.List<UnityEngine.UI.Image> m_ImagesPool;
        private readonly System.Collections.Generic.List<UnityEngine.GameObject> culled_ImagesPool;
        private bool clearImages;
        private UnityEngine.Object thisLock;
        private readonly System.Collections.Generic.List<int> m_ImagesVertexIndex;
        private static readonly System.Text.RegularExpressions.Regex s_Regex;
        private string fixedString;
        private string m_OutputText;
        public UnityEngine.UI.Extensions.TextPic.IconName[] inspectorIconList;
        private System.Collections.Generic.Dictionary<string, UnityEngine.Sprite> iconList;
        public float ImageScalingFactor;
        public string hyperlinkColor;
        [UnityEngine.SerializeField]
        public UnityEngine.Vector2 imageOffset;
        private UnityEngine.UI.Button button;
        private System.Collections.Generic.List<UnityEngine.Vector2> positions;
        private string previousText;
        public bool isCreating_m_HrefInfos;
        private readonly System.Collections.Generic.List<UnityEngine.UI.Extensions.TextPic.HrefInfo> m_HrefInfos;
        private static readonly System.Text.StringBuilder s_TextBuilder;
        private static readonly System.Text.RegularExpressions.Regex s_HrefRegex;
        [UnityEngine.SerializeField]
        private UnityEngine.UI.Extensions.TextPic.HrefClickEvent m_OnHrefClick;
        private static System.Predicate<UnityEngine.UI.Image> <>f__am$cache0;
        
        // Properties
        public UnityEngine.UI.Extensions.TextPic.HrefClickEvent onHrefClick { get; set; }
        
        // Methods
        public TextPic()
        {
            var val_10;
            this.m_ImagesPool = new System.Collections.Generic.List<UnityEngine.UI.Image>();
            this.culled_ImagesPool = new System.Collections.Generic.List<UnityEngine.GameObject>();
            this.thisLock = new UnityEngine.Object();
            this.m_ImagesVertexIndex = new System.Collections.Generic.List<System.Int32>();
            this.iconList = new System.Collections.Generic.Dictionary<System.String, UnityEngine.Sprite>();
            this.ImageScalingFactor = 1f;
            this.hyperlinkColor = "blue";
            UnityEngine.Vector2 val_6 = UnityEngine.Vector2.zero;
            mem[1152921512707226044] = val_6.y;
            this.imageOffset = val_6;
            this.positions = new System.Collections.Generic.List<UnityEngine.Vector2>();
            val_10 = null;
            val_10 = null;
            this.isCreating_m_HrefInfos = true;
            this.previousText = System.String.Empty;
            this.m_HrefInfos = new System.Collections.Generic.List<HrefInfo>();
            this.m_OnHrefClick = new TextPic.HrefClickEvent();
        }
        public override void SetVerticesDirty()
        {
            this.SetVerticesDirty();
            this.UpdateQuadImage();
        }
        private void Start()
        {
            this.button = this.GetComponent<UnityEngine.UI.Button>();
            if(((this.inspectorIconList != null) && (this.inspectorIconList.Length >= 1)) && (this.inspectorIconList.Length >= 1))
            {
                    do
            {
                this.iconList.Add(key:  this.inspectorIconList[0], value:  this.inspectorIconList[0]);
            }
            while((0 + 1) < this.inspectorIconList.Length);
            
            }
            
            this.Reset_m_HrefInfos();
        }
        protected void UpdateQuadImage()
        {
            var val_62;
            System.Collections.IEnumerator val_63;
            System.Collections.IEnumerator val_64;
            var val_65;
            var val_66;
            UnityEngine.UI.Image val_67;
            var val_68;
            UnityEngine.Object val_69;
            var val_70;
            int val_71;
            System.Collections.Generic.List<UnityEngine.UI.Image> val_72;
            UnityEngine.UI.Image val_73;
            this.m_OutputText = this.GetOutputText();
            this.m_ImagesVertexIndex.Clear();
            val_62 = null;
            val_62 = null;
            System.Collections.IEnumerator val_3 = UnityEngine.UI.Extensions.TextPic.s_Regex.Matches(input:  this.m_OutputText).GetEnumerator();
            label_87:
            var val_63 = val_3;
            if((val_3 + 258) == 0)
            {
                goto label_7;
            }
            
            var val_60 = val_3 + 152;
            var val_61 = 0;
            val_60 = val_60 + 8;
            label_9:
            if(((val_3 + 152 + 8) + -8) == null)
            {
                goto label_8;
            }
            
            val_61 = val_61 + 1;
            val_60 = val_60 + 16;
            if(val_61 < (val_3 + 258))
            {
                goto label_9;
            }
            
            label_7:
            val_63 = val_3;
            goto label_10;
            label_8:
            var val_62 = val_60;
            val_62 = val_62 + 1;
            val_63 = val_63 + val_62;
            val_63 = val_63 + 272;
            label_10:
            if(((val_3 & 1) & 1) == 0)
            {
                goto label_119;
            }
            
            var val_66 = val_3;
            if((val_3 + 258) == 0)
            {
                goto label_13;
            }
            
            var val_64 = val_3 + 152;
            var val_65 = 0;
            val_64 = val_64 + 8;
            label_15:
            if(((val_3 + 152 + 8) + -8) == null)
            {
                goto label_14;
            }
            
            val_65 = val_65 + 1;
            val_64 = val_64 + 16;
            if(val_65 < (val_3 + 258))
            {
                goto label_15;
            }
            
            label_13:
            val_64 = val_3;
            goto label_16;
            label_14:
            val_66 = val_66 + (((val_3 + 152 + 8)) << 4);
            val_64 = val_66 + 272;
            label_16:
            int val_7 = 0.Index;
            this.m_ImagesVertexIndex.Add(item:  3);
            val_65 = null;
            val_65 = null;
            if((UnityEngine.UI.Extensions.TextPic.<>f__am$cache0) == null)
            {
                    System.Predicate<UnityEngine.UI.Image> val_8 = new System.Predicate<UnityEngine.UI.Image>(object:  0, method:  static System.Boolean UnityEngine.UI.Extensions.TextPic::<UpdateQuadImage>m__0(UnityEngine.UI.Image image));
                val_66 = null;
                val_66 = null;
                UnityEngine.UI.Extensions.TextPic.<>f__am$cache0 = null;
                val_65 = null;
            }
            
            val_65 = null;
            int val_9 = this.m_ImagesPool.RemoveAll(match:  UnityEngine.UI.Extensions.TextPic.<>f__am$cache0);
            if(this.m_ImagesPool.Count == 0)
            {
                    this.GetComponentsInChildren<UnityEngine.UI.Image>(results:  this.m_ImagesPool);
            }
            
            val_67 = public System.Int32 System.Collections.Generic.List<UnityEngine.UI.Image>::get_Count();
            if(this.m_ImagesVertexIndex.Count > this.m_ImagesPool.Count)
            {
                    UnityEngine.GameObject val_13 = UnityEngine.UI.DefaultControls.CreateImage(resources:  new Resources());
                val_13.layer = this.gameObject.layer;
                UnityEngine.Transform val_16 = val_13.transform;
                if(val_16 != null)
            {
                    var val_17 = (null == null) ? (val_16) : 0;
            }
            else
            {
                    val_68 = 0;
            }
            
                if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
            {
                    val_68.SetParent(parent:  this.rectTransform);
                UnityEngine.Vector3 val_20 = UnityEngine.Vector3.zero;
                val_68.localPosition = new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z};
                UnityEngine.Quaternion val_21 = UnityEngine.Quaternion.identity;
                val_68.localRotation = new UnityEngine.Quaternion() {x = val_21.x, y = val_21.y, z = val_21.z, w = val_21.w};
                UnityEngine.Vector3 val_22 = UnityEngine.Vector3.one;
                val_68.localScale = new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z};
            }
            
                val_67 = val_13.GetComponent<UnityEngine.UI.Image>();
                this.m_ImagesPool.Add(item:  val_67);
            }
            
            string val_25 = 0.Item[1].Value;
            UnityEngine.UI.Image val_28 = this.m_ImagesPool.Item[this.m_ImagesVertexIndex.Count - 1];
            val_69 = val_28.sprite;
            if(0 == val_69)
            {
                goto label_63;
            }
            
            val_69 = val_28.sprite.name;
            if((System.String.op_Inequality(a:  0, b:  val_69)) == false)
            {
                goto label_71;
            }
            
            label_63:
            if((this.inspectorIconList == null) || (this.inspectorIconList.Length < 1))
            {
                goto label_71;
            }
            
            var val_69 = 0;
            label_75:
            if(val_69 >= this.inspectorIconList.Length)
            {
                goto label_71;
            }
            
            val_69 = val_69 + 1;
            if((System.String.op_Equality(a:  0, b:  this.inspectorIconList[0])) == false)
            {
                goto label_75;
            }
            
            val_28.sprite = this.inspectorIconList[0];
            label_71:
            float val_71 = this.ImageScalingFactor;
            float val_70 = (float)this.fontSize;
            val_70 = val_70 * this.ImageScalingFactor;
            val_71 = (float)this.fontSize * val_71;
            CinemachineFreeLook.Orbit val_39 = new CinemachineFreeLook.Orbit(h:  val_70, r:  val_71);
            val_28.rectTransform.sizeDelta = new UnityEngine.Vector2() {x = val_39.m_Height, y = val_39.m_Radius};
            val_28.enabled = true;
            if(this.positions.Count != this.m_ImagesPool.Count)
            {
                goto label_87;
            }
            
            UnityEngine.Vector2 val_45 = this.positions.Item[this.m_ImagesVertexIndex.Count - 1];
            val_28.rectTransform.anchoredPosition = new UnityEngine.Vector2() {x = val_45.x, y = val_45.y};
            goto label_87;
            label_119:
            if(val_3 == 0)
            {
                goto label_89;
            }
            
            var val_74 = val_3;
            if((val_3 + 258) == 0)
            {
                goto label_90;
            }
            
            var val_72 = val_3 + 152;
            var val_73 = 0;
            val_72 = val_72 + 8;
            label_92:
            if(((val_3 + 152 + 8) + -8) == null)
            {
                goto label_91;
            }
            
            val_73 = val_73 + 1;
            val_72 = val_72 + 16;
            if(val_73 < (val_3 + 258))
            {
                goto label_92;
            }
            
            label_90:
            val_70 = val_3;
            goto label_93;
            label_91:
            val_74 = val_74 + (((val_3 + 152 + 8)) << 4);
            val_70 = val_74 + 272;
            label_93:
            label_89:
            val_71 = this.m_ImagesVertexIndex.Count;
            goto label_97;
            label_115:
            val_71 = val_71 + 1;
            label_97:
            if(val_71 >= this.m_ImagesPool.Count)
            {
                goto label_99;
            }
            
            UnityEngine.UI.Image val_48 = this.m_ImagesPool.Item[val_71];
            if((UnityEngine.Object.op_Implicit(exists:  0)) == false)
            {
                goto label_115;
            }
            
            this.m_ImagesPool.Item[val_71].gameObject.SetActive(value:  false);
            this.m_ImagesPool.Item[val_71].gameObject.hideFlags = 61;
            this.culled_ImagesPool.Add(item:  this.m_ImagesPool.Item[val_71].gameObject);
            val_72 = this.m_ImagesPool;
            if(val_72 != null)
            {
                    val_73 = val_72.Item[val_71];
            }
            else
            {
                    val_73 = 0.Item[val_71];
                val_72 = 0;
            }
            
            bool val_58 = val_72.Remove(item:  val_73);
            goto label_115;
            label_99:
            if(this.culled_ImagesPool.Count < 2)
            {
                    return;
            }
            
            this.clearImages = true;
        }
        protected override void OnPopulateMesh(UnityEngine.UI.VertexHelper toFill)
        {
            float val_8;
            float val_9;
            float val_15;
            var val_28;
            int val_29;
            mem[1152921512708304696] = this.GetOutputText();
            this.OnPopulateMesh(toFill:  toFill);
            mem[1152921512708304696] = ???;
            this.positions.Clear();
            val_28 = 0;
            goto label_2;
            label_20:
            val_28 = 1;
            label_2:
            int val_2 = this.m_ImagesVertexIndex.Count;
            if(val_28 >= val_2)
            {
                goto label_5;
            }
            
            int val_3 = this.m_ImagesVertexIndex.Item[1];
            UnityEngine.Vector2 val_6 = this.m_ImagesPool.Item[1].rectTransform.sizeDelta;
            if(val_3 >= toFill.currentVertCount)
            {
                goto label_20;
            }
            
            toFill.PopulateUIVertex(vertex: ref  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3(), normal = new UnityEngine.Vector3(), color = new UnityEngine.Color32(), uv0 = new UnityEngine.Vector2(), uv1 = new UnityEngine.Vector2(), uv2 = new UnityEngine.Vector2(), uv3 = new UnityEngine.Vector2(), tangent = new UnityEngine.Vector4()}, i:  val_3);
            float val_28 = val_8;
            float val_29 = val_9;
            val_28 = (val_6.x * 0.5f) + val_28;
            val_29 = (val_6.y * 0.5f) + val_29;
            CinemachineFreeLook.Orbit val_12 = new CinemachineFreeLook.Orbit(h:  val_28, r:  val_29);
            UnityEngine.Vector2 val_13 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_12.m_Height, y = val_12.m_Radius}, b:  new UnityEngine.Vector2() {x = this.imageOffset, y = val_6.y});
            this.positions.Add(item:  new UnityEngine.Vector2() {x = val_13.x, y = val_13.y});
            int val_14 = val_3 - 3;
            toFill.PopulateUIVertex(vertex: ref  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3(), normal = new UnityEngine.Vector3(), color = new UnityEngine.Color32(), uv0 = new UnityEngine.Vector2(), uv1 = new UnityEngine.Vector2(), uv2 = new UnityEngine.Vector2(), uv3 = new UnityEngine.Vector2(), tangent = new UnityEngine.Vector4()}, i:  val_14);
            if(val_3 < (-2147483645))
            {
                goto label_20;
            }
            
            int val_30 = val_3;
            do
            {
                if(toFill != null)
            {
                    toFill.PopulateUIVertex(vertex: ref  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3(), normal = new UnityEngine.Vector3(), color = new UnityEngine.Color32(), uv0 = new UnityEngine.Vector2(), uv1 = new UnityEngine.Vector2(), uv2 = new UnityEngine.Vector2(), uv3 = new UnityEngine.Vector2(), tangent = new UnityEngine.Vector4()}, i:  val_3);
                val_8 = val_8;
                val_9 = val_9;
                val_15 = val_15;
            }
            else
            {
                    0.PopulateUIVertex(vertex: ref  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3() {x = val_8, y = val_9, z = val_15}, normal = new UnityEngine.Vector3(), color = new UnityEngine.Color32(), uv0 = new UnityEngine.Vector2(), uv1 = new UnityEngine.Vector2(), uv2 = new UnityEngine.Vector2(), uv3 = new UnityEngine.Vector2(), tangent = new UnityEngine.Vector4()}, i:  val_3);
                val_8 = val_8;
                val_9 = val_9;
                val_15 = val_15;
            }
            
                toFill.SetUIVertex(vertex:  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3(), normal = new UnityEngine.Vector3(), color = new UnityEngine.Color32(), uv0 = new UnityEngine.Vector2(), uv1 = new UnityEngine.Vector2(), uv2 = new UnityEngine.Vector2(), uv3 = new UnityEngine.Vector2(), tangent = new UnityEngine.Vector4()}, i:  val_30);
                val_30 = val_30 - 1;
            }
            while(val_30 > val_14);
            
            goto label_20;
            label_5:
            if(this.m_ImagesVertexIndex.Count != 0)
            {
                    this.m_ImagesVertexIndex.Clear();
            }
            
            List.Enumerator<T> val_17 = this.m_HrefInfos.GetEnumerator();
            do
            {
                label_54:
                if((0 & 1) == 0)
            {
                goto label_58;
            }
            
                System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_19 = val_12.m_Height.InitializationCallback;
                this.m_ImagesVertexIndex.Clear();
            }
            while(this.m_ImagesVertexIndex >= toFill.currentVertCount);
            
            toFill.PopulateUIVertex(vertex: ref  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3() {x = val_8, y = val_9, z = val_15}, normal = new UnityEngine.Vector3(), color = new UnityEngine.Color32(), uv0 = new UnityEngine.Vector2(), uv1 = new UnityEngine.Vector2(), uv2 = new UnityEngine.Vector2(), uv3 = new UnityEngine.Vector2(), tangent = new UnityEngine.Vector4()}, i:  this.m_ImagesVertexIndex);
            UnityEngine.Vector3 val_21 = UnityEngine.Vector3.zero;
            if(val_19 == null)
            {
                goto label_36;
            }
            
            goto label_36;
            label_49:
            val_29 = this.m_ImagesVertexIndex + 1;
            label_36:
            if((val_29 >= W28) || (val_29 >= toFill.currentVertCount))
            {
                goto label_39;
            }
            
            toFill.PopulateUIVertex(vertex: ref  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3() {x = val_8, y = val_9, z = val_15}, normal = new UnityEngine.Vector3(), color = new UnityEngine.Color32(), uv0 = new UnityEngine.Vector2(), uv1 = new UnityEngine.Vector2(), uv2 = new UnityEngine.Vector2(), uv3 = new UnityEngine.Vector2(), tangent = new UnityEngine.Vector4()}, i:  val_29);
            if(val_8 >= 0)
            {
                goto label_49;
            }
            
            UnityEngine.Vector2 val_23 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_8, y = val_9, z = val_15});
            UnityEngine.Vector2 val_24 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_15});
            val_2.Add(item:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f});
            UnityEngine.Vector3 val_25 = UnityEngine.Vector3.zero;
            goto label_49;
            label_39:
            UnityEngine.Vector2 val_26 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_8, y = val_9, z = val_15});
            UnityEngine.Vector2 val_27 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_15});
            val_19.Add(item:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f});
            goto label_54;
            label_58:
            val_12.m_Height.Dispose();
            this.UpdateQuadImage();
        }
        public UnityEngine.UI.Extensions.TextPic.HrefClickEvent get_onHrefClick()
        {
            return (HrefClickEvent)this.m_OnHrefClick;
        }
        public void set_onHrefClick(UnityEngine.UI.Extensions.TextPic.HrefClickEvent value)
        {
            this.m_OnHrefClick = value;
        }
        protected string GetOutputText()
        {
            var val_50;
            var val_51;
            var val_52;
            int val_53;
            var val_54;
            var val_55;
            var val_56;
            var val_57;
            var val_58;
            HrefInfo val_59;
            var val_60;
            var val_61;
            var val_62;
            var val_63;
            var val_64;
            val_50 = null;
            val_50 = null;
            UnityEngine.UI.Extensions.TextPic.s_TextBuilder.Length = 0;
            this.fixedString = this.text;
            if(((this.inspectorIconList != null) && (this.inspectorIconList.Length >= 1)) && (this.inspectorIconList.Length >= 1))
            {
                    do
            {
                IconName val_50 = this.inspectorIconList[0];
                if(val_50 != 0)
            {
                    val_51 = null;
                val_51 = null;
                if((System.String.op_Inequality(a:  0, b:  val_50)) != false)
            {
                    typeof(System.Object[]).__il2cppRuntimeField_20 = "<quad name=";
                typeof(System.Object[]).__il2cppRuntimeField_28 = val_50;
                typeof(System.Object[]).__il2cppRuntimeField_30 = " size=";
                typeof(System.Object[]).__il2cppRuntimeField_38 = this.fontSize;
                typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
                typeof(System.Object[]).__il2cppRuntimeField_40 = " width=1 />";
                this.fixedString = this.fixedString.Replace(oldValue:  val_50, newValue:  +0);
            }
            
            }
            
            }
            while((0 + 1) < this.inspectorIconList.Length);
            
            }
            
            val_52 = null;
            val_52 = null;
            System.Collections.IEnumerator val_8 = UnityEngine.UI.Extensions.TextPic.s_HrefRegex.Matches(input:  this.fixedString).GetEnumerator();
            val_53 = 0;
            goto label_35;
            label_96:
            val_53 = val_8 + this.inspectorIconList;
            label_35:
            var val_51 = 0;
            val_51 = val_51 + 1;
            val_54 = val_8;
            if(((val_8 & 1) & 1) == 0)
            {
                goto label_112;
            }
            
            var val_52 = 0;
            val_52 = val_52 + 1;
            val_55 = val_8;
            val_56 = val_8;
            val_56 = 0;
            val_57 = null;
            val_57 = null;
            System.Text.StringBuilder val_17 = UnityEngine.UI.Extensions.TextPic.s_TextBuilder.Append(value:  this.fixedString.Substring(startIndex:  val_53, length:  val_56.Index - val_53));
            System.Text.StringBuilder val_19 = UnityEngine.UI.Extensions.TextPic.s_TextBuilder.Append(value:  0 + "<color="("<color=") + this.hyperlinkColor);
            if(this.isCreating_m_HrefInfos != false)
            {
                    TextPic.HrefInfo val_21 = new TextPic.HrefInfo();
                val_58 = null;
                val_58 = null;
                typeof(TextPic.HrefInfo).__il2cppRuntimeField_10 = UnityEngine.UI.Extensions.TextPic.s_TextBuilder.Length << 2;
                int val_27 = val_56.Item[2].Length + UnityEngine.UI.Extensions.TextPic.s_TextBuilder.Length;
                val_27 = val_27 << 2;
                val_27 = val_27 - 1;
                typeof(TextPic.HrefInfo).__il2cppRuntimeField_14 = val_27;
                typeof(TextPic.HrefInfo).__il2cppRuntimeField_18 = val_56.Item[1].Value;
                val_59 = null;
                this.m_HrefInfos.Add(item:  val_59);
            }
            else
            {
                    val_59 = public System.Int32 System.Collections.Generic.List<HrefInfo>::get_Count();
                if(this.m_HrefInfos.Count >= 1)
            {
                    HrefInfo val_30 = this.m_HrefInfos.Item[0];
                val_60 = null;
                val_60 = null;
                val_30.startIndex = UnityEngine.UI.Extensions.TextPic.s_TextBuilder.Length << 2;
                HrefInfo val_33 = this.m_HrefInfos.Item[0];
                val_59 = 0;
                int val_37 = val_56.Item[2].Length + UnityEngine.UI.Extensions.TextPic.s_TextBuilder.Length;
                val_37 = val_37 << 2;
                val_37 = val_37 - 1;
                val_33.endIndex = val_37;
            }
            
            }
            
            val_61 = null;
            val_61 = null;
            System.Text.StringBuilder val_40 = UnityEngine.UI.Extensions.TextPic.s_TextBuilder.Append(value:  val_56.Item[2].Value);
            System.Text.StringBuilder val_41 = UnityEngine.UI.Extensions.TextPic.s_TextBuilder.Append(value:  "</color>");
            int val_42 = val_56.Index;
            int val_43 = val_56.Length;
            goto label_96;
            label_112:
            if(val_8 != null)
            {
                    var val_53 = 0;
                val_53 = val_53 + 1;
                val_62 = val_8;
            }
            
            if(this.isCreating_m_HrefInfos != false)
            {
                    this.isCreating_m_HrefInfos = false;
            }
            
            val_63 = null;
            val_63 = null;
            if(this.fixedString != null)
            {
                    val_64 = this.fixedString.Length;
            }
            else
            {
                    val_64 = 0.Length;
            }
            
            System.Text.StringBuilder val_49 = UnityEngine.UI.Extensions.TextPic.s_TextBuilder.Append(value:  this.fixedString.Substring(startIndex:  val_53, length:  val_64 - val_53));
            if(UnityEngine.UI.Extensions.TextPic.s_TextBuilder != null)
            {
                    return (string)UnityEngine.UI.Extensions.TextPic.s_TextBuilder;
            }
            
            return (string)UnityEngine.UI.Extensions.TextPic.s_TextBuilder;
        }
        public void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
        {
            UnityEngine.Camera val_10;
            float val_13;
            float val_14;
            var val_15;
            var val_16;
            val_10 = this.rectTransform;
            if(eventData != null)
            {
                    UnityEngine.Vector2 val_2 = eventData.position;
                val_13 = val_2.x;
                val_14 = val_2.y;
            }
            else
            {
                    UnityEngine.Vector2 val_3 = 0.position;
                val_13 = val_3.x;
                val_14 = val_3.y;
            }
            
            bool val_5 = UnityEngine.RectTransformUtility.ScreenPointToLocalPointInRectangle(rect:  0, screenPoint:  new UnityEngine.Vector2() {x = val_13, y = val_14}, cam:  val_10, localPoint: out  new UnityEngine.Vector2() {x = eventData.pressEventCamera, y = eventData.pressEventCamera});
            List.Enumerator<T> val_6 = this.m_HrefInfos.GetEnumerator();
            label_9:
            if((0 & 1) == 0)
            {
                goto label_6;
            }
            
            var val_10 = 0;
            label_11:
            if(val_10 >= val_10.Count)
            {
                goto label_9;
            }
            
            UnityEngine.Rect val_9 = val_10.Item[0];
            val_10 = val_10 + 1;
            if(( & 1) == 0)
            {
                goto label_11;
            }
            
            this.m_OnHrefClick.Invoke(arg0:  0.InitializationCallback);
            label_6:
            val_15 = 0;
            val_16 = 1;
            0.Dispose();
            if(( & 1) != 0)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
        
        }
        public void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData)
        {
            var val_8;
            var val_9;
            val_8 = this;
            if(this.m_ImagesPool.Count < 1)
            {
                    return;
            }
            
            List.Enumerator<T> val_2 = this.m_ImagesPool.GetEnumerator();
            label_12:
            if((0 & 1) == 0)
            {
                goto label_4;
            }
            
            if((0 == this.button) || (this.button.isActiveAndEnabled == false))
            {
                goto label_12;
            }
            
            UnityEngine.UI.ColorBlock val_6 = this.button.colors;
            UnityEngine.Color val_7 = normalColor;
            if(0.InitializationCallback != null)
            {
                goto label_12;
            }
            
            goto label_12;
            label_4:
            val_8 = 0;
            val_9 = 1;
            0.Dispose();
            if((val_9 & 1) != 0)
            {
                    return;
            }
            
            if(val_8 == 0)
            {
                    return;
            }
        
        }
        public void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData)
        {
            var val_4;
            var val_10 = this;
            if(this.m_ImagesPool.Count < 1)
            {
                    return;
            }
            
            List.Enumerator<T> val_2 = this.m_ImagesPool.GetEnumerator();
            label_14:
            if((0 & 1) == 0)
            {
                goto label_17;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_5 = val_4.InitializationCallback;
            if((0 == this.button) || (this.button.isActiveAndEnabled == false))
            {
                goto label_9;
            }
            
            UnityEngine.UI.ColorBlock val_8 = this.button.colors;
            if(val_5 != null)
            {
                goto label_14;
            }
            
            goto label_14;
            label_9:
            UnityEngine.Color val_9 = this.color;
            if(val_5 != null)
            {
                goto label_14;
            }
            
            goto label_14;
            label_17:
            val_4.Dispose();
            if((0 & 1) != 0)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
        
        }
        public void OnSelect(UnityEngine.EventSystems.BaseEventData eventData)
        {
            var val_8;
            var val_9;
            val_8 = this;
            if(this.m_ImagesPool.Count < 1)
            {
                    return;
            }
            
            List.Enumerator<T> val_2 = this.m_ImagesPool.GetEnumerator();
            label_12:
            if((0 & 1) == 0)
            {
                goto label_4;
            }
            
            if((0 == this.button) || (this.button.isActiveAndEnabled == false))
            {
                goto label_12;
            }
            
            UnityEngine.UI.ColorBlock val_6 = this.button.colors;
            UnityEngine.Color val_7 = normalColor;
            if(0.InitializationCallback != null)
            {
                goto label_12;
            }
            
            goto label_12;
            label_4:
            val_8 = 0;
            val_9 = 1;
            0.Dispose();
            if((val_9 & 1) != 0)
            {
                    return;
            }
            
            if(val_8 == 0)
            {
                    return;
            }
        
        }
        private void Update()
        {
            var val_5;
            System.Threading.Monitor.Enter(obj:  0);
            if(this.clearImages == false)
            {
                goto label_1;
            }
            
            val_5 = 0;
            goto label_2;
            label_8:
            val_5 = 1;
            label_2:
            if(val_5 >= this.culled_ImagesPool.Count)
            {
                goto label_4;
            }
            
            UnityEngine.GameObject val_2 = this.culled_ImagesPool.Item[1];
            UnityEngine.Object.DestroyImmediate(obj:  0);
            goto label_8;
            label_4:
            this.culled_ImagesPool.Clear();
            this.clearImages = false;
            label_1:
            System.Threading.Monitor.Exit(obj:  0);
            string val_3 = this.text;
            if((System.String.op_Inequality(a:  0, b:  this.previousText)) == false)
            {
                    return;
            }
            
            this.Reset_m_HrefInfos();
        }
        private void Reset_m_HrefInfos()
        {
            this.previousText = this.text;
            this.m_HrefInfos.Clear();
            this.isCreating_m_HrefInfos = true;
        }
        private static TextPic()
        {
            UnityEngine.UI.Extensions.TextPic.s_Regex = new System.Text.RegularExpressions.Regex(pattern:  "<quad name=(.+?) size=(\\d*\\.?\\d+%?) width=(\\d*\\.?\\d+%?) />", options:  16);
            UnityEngine.UI.Extensions.TextPic.s_TextBuilder = new System.Text.StringBuilder();
            UnityEngine.UI.Extensions.TextPic.s_HrefRegex = new System.Text.RegularExpressions.Regex(pattern:  "<a href=([^>\\n\\s]+)>(.*?)(</a>)", options:  16);
        }
        private static bool <UpdateQuadImage>m__0(UnityEngine.UI.Image image)
        {
            return UnityEngine.Object.op_Equality(x:  0, y:  X1);
        }
    
    }

}
