using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    [UnityEngine.AddComponentMenu]
    public class UICornerCut : UIPrimitiveBase
    {
        // Fields
        public UnityEngine.Vector2 cornerSize;
        [UnityEngine.HeaderAttribute]
        public bool cutUL;
        public bool cutUR;
        public bool cutLL;
        public bool cutLR;
        [UnityEngine.TooltipAttribute]
        public bool makeColumns;
        [UnityEngine.HeaderAttribute]
        public bool useColorUp;
        public UnityEngine.Color32 colorUp;
        public bool useColorDown;
        public UnityEngine.Color32 colorDown;
        
        // Methods
        public UICornerCut()
        {
            CinemachineFreeLook.Orbit val_1 = new CinemachineFreeLook.Orbit(h:  16f, r:  16f);
            this.cornerSize = val_1.m_Height;
            mem[1152921512758198920] = val_1.m_Height >> 32;
            this.cutUL = true;
            UnityEngine.Color val_3 = UnityEngine.Color.blue;
            UnityEngine.Color32 val_4 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a});
            this.colorUp = val_4;
            UnityEngine.Color val_5 = UnityEngine.Color.green;
            UnityEngine.Color32 val_6 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = val_5.r, g = val_5.g, b = val_5.b, a = val_5.a});
            this.colorDown = val_6;
            mem[1152921512758198912] = 1065353216;
            this = new UnityEngine.UI.MaskableGraphic();
        }
        protected override void OnPopulateMesh(UnityEngine.UI.VertexHelper vh)
        {
            float val_39;
            float val_40;
            float val_41;
            UnityEngine.Color32 val_42;
            float val_43;
            float val_44;
            float val_45;
            float val_46;
            float val_47;
            float val_49;
            float val_50;
            float val_51;
            float val_52;
            UnityEngine.Color32 val_53;
            float val_54;
            var val_55;
            var val_56;
            var val_57;
            UnityEngine.Rect val_2 = this.rectTransform.rect;
            UnityEngine.Color val_3 = this.color;
            UnityEngine.Color32 val_4 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a});
            bool val_39 = this.cutUL;
            bool val_5 = val_39 & 65280;
            bool val_6 = val_39 >> 24;
            bool val_7 = val_39 | (val_5 >> 8);
            bool val_8 = val_6 | (val_39 >> 16);
            bool val_9 = val_8 | val_7;
            val_9 = val_9 & 255;
            if(val_9 == false)
            {
                    return;
            }
            
            float val_10 = this.cornerSize.sqrMagnitude;
            if(val_10 <= 0f)
            {
                    return;
            }
            
            val_39 = val_39 | (val_39 >> 16);
            vh.Clear();
            if((val_39 & 255) != false)
            {
                    val_10 = val_10 + this.cornerSize.x;
            }
            
            if((val_8 & 255) != false)
            {
                    val_10 = val_10 + this.cornerSize.x;
            }
            
            val_5 = val_6 | (val_5 >> 8);
            if((val_7 & 255) != false)
            {
                    val_39 = val_10 - this.cornerSize.x;
            }
            
            if(val_5 != false)
            {
                    val_39 = val_39 - this.cornerSize.x;
            }
            
            if(this.makeColumns == false)
            {
                goto label_8;
            }
            
            if(this.cutUL == false)
            {
                goto label_9;
            }
            
            goto label_10;
            label_8:
            if(this.cutUL == false)
            {
                goto label_11;
            }
            
            goto label_12;
            label_9:
            label_10:
            CinemachineFreeLook.Orbit val_14 = new CinemachineFreeLook.Orbit(h:  val_39, r:  val_39);
            if(this.cutUR != false)
            {
                
            }
            
            CinemachineFreeLook.Orbit val_15 = new CinemachineFreeLook.Orbit(h:  val_39, r:  val_39);
            if(this.cutLL != false)
            {
                
            }
            
            CinemachineFreeLook.Orbit val_16 = new CinemachineFreeLook.Orbit(h:  val_39, r:  val_39);
            if(this.cutLR != false)
            {
                
            }
            
            val_40 = val_39;
            CinemachineFreeLook.Orbit val_18 = new CinemachineFreeLook.Orbit(h:  val_40, r:  val_39);
            if((val_39 & 255) != false)
            {
                    CinemachineFreeLook.Orbit val_19 = new CinemachineFreeLook.Orbit(h:  val_40, r:  val_40);
                val_41 = val_40;
                val_42 = val_4.r;
                if(this.useColorUp != false)
            {
                    val_42 = this.colorUp;
            }
            
                val_43 = val_16.m_Height;
                UnityEngine.UI.Extensions.UICornerCut.AddSquare(a:  new UnityEngine.Vector2() {x = val_43, y = val_16.m_Radius}, b:  new UnityEngine.Vector2() {x = val_14.m_Height, y = val_14.m_Radius}, c:  new UnityEngine.Vector2() {x = val_19.m_Height, y = val_19.m_Radius}, d:  new UnityEngine.Vector2() {x = val_20.m_Height, y = val_20.m_Radius}, rectUV:  new UnityEngine.Rect() {m_XMin = val_2.m_XMin, m_YMin = val_2.m_Width, m_Height = val_19.m_Height}, color32:  new UnityEngine.Color32() {r = new CinemachineFreeLook.Orbit(h:  val_41, r:  val_40), g = new CinemachineFreeLook.Orbit(h:  val_41, r:  val_40), b = new CinemachineFreeLook.Orbit(h:  val_41, r:  val_40), a = new CinemachineFreeLook.Orbit(h:  val_41, r:  val_40)}, vh:  val_42 & 4294967295);
            }
            
            if(val_5 == false)
            {
                goto label_30;
            }
            
            val_44 = val_15.m_Height;
            val_45 = val_15.m_Radius;
            val_46 = val_18.m_Height;
            val_47 = val_18.m_Radius;
            CinemachineFreeLook.Orbit val_22 = new CinemachineFreeLook.Orbit(h:  val_43, r:  val_43);
            val_41 = val_43;
            CinemachineFreeLook.Orbit val_23 = new CinemachineFreeLook.Orbit(h:  val_41, r:  val_43);
            val_49 = val_2.m_XMin;
            val_50 = val_2.m_YMin;
            val_51 = val_2.m_Width;
            val_52 = val_2.m_Height;
            bool val_40 = this.useColorDown;
            val_40 = ((val_40 & true) != 0) ? val_4.r : (val_40 >> 32);
            goto label_31;
            label_11:
            label_12:
            CinemachineFreeLook.Orbit val_25 = new CinemachineFreeLook.Orbit(h:  val_39, r:  val_39);
            if(this.cutUR != false)
            {
                
            }
            
            CinemachineFreeLook.Orbit val_26 = new CinemachineFreeLook.Orbit(h:  val_39, r:  val_39);
            if(this.cutLL != false)
            {
                
            }
            
            CinemachineFreeLook.Orbit val_27 = new CinemachineFreeLook.Orbit(h:  val_39, r:  val_39);
            if(this.cutLR != false)
            {
                
            }
            
            val_54 = val_39;
            CinemachineFreeLook.Orbit val_29 = new CinemachineFreeLook.Orbit(h:  val_54, r:  val_39);
            if((val_8 & 255) != false)
            {
                    CinemachineFreeLook.Orbit val_30 = new CinemachineFreeLook.Orbit(h:  val_54, r:  val_54);
                val_41 = val_54;
                bool val_41 = this.useColorDown;
                val_41 = ((val_41 & true) != 0) ? val_4.r : (val_41 >> 32);
                val_54 = val_29.m_Height;
                UnityEngine.UI.Extensions.UICornerCut.AddSquare(a:  new UnityEngine.Vector2() {x = val_54, y = val_29.m_Radius}, b:  new UnityEngine.Vector2() {x = val_27.m_Height, y = val_27.m_Radius}, c:  new UnityEngine.Vector2() {x = val_30.m_Height, y = val_30.m_Radius}, d:  new UnityEngine.Vector2() {x = val_31.m_Height, y = val_31.m_Radius}, rectUV:  new UnityEngine.Rect() {m_XMin = val_2.m_XMin, m_YMin = val_2.m_Width, m_Height = val_30.m_Height}, color32:  new UnityEngine.Color32() {r = new CinemachineFreeLook.Orbit(h:  val_41, r:  val_54), g = new CinemachineFreeLook.Orbit(h:  val_41, r:  val_54), b = new CinemachineFreeLook.Orbit(h:  val_41, r:  val_54), a = new CinemachineFreeLook.Orbit(h:  val_41, r:  val_54)}, vh:  val_41 & 4294967295);
            }
            
            if((val_7 & 255) == false)
            {
                goto label_30;
            }
            
            val_44 = val_25.m_Height;
            val_45 = val_25.m_Radius;
            val_46 = val_26.m_Height;
            val_47 = val_26.m_Radius;
            CinemachineFreeLook.Orbit val_35 = new CinemachineFreeLook.Orbit(h:  val_54, r:  val_54);
            val_41 = val_54;
            val_49 = val_2.m_XMin;
            val_50 = val_2.m_YMin;
            val_51 = val_2.m_Width;
            val_52 = val_2.m_Height;
            val_53 = val_4.r;
            if(this.useColorUp != false)
            {
                    val_53 = this.colorUp;
            }
            
            label_31:
            val_54 = val_44;
            UnityEngine.UI.Extensions.UICornerCut.AddSquare(a:  new UnityEngine.Vector2() {x = val_54, y = val_45}, b:  new UnityEngine.Vector2() {x = val_46, y = val_47}, c:  new UnityEngine.Vector2() {x = val_35.m_Height, y = val_35.m_Radius}, d:  new UnityEngine.Vector2() {x = val_36.m_Height, y = val_36.m_Radius}, rectUV:  new UnityEngine.Rect() {m_XMin = val_49, m_YMin = val_51, m_Height = val_35.m_Height}, color32:  new UnityEngine.Color32() {r = new CinemachineFreeLook.Orbit(h:  val_41, r:  val_54), g = new CinemachineFreeLook.Orbit(h:  val_41, r:  val_54), b = new CinemachineFreeLook.Orbit(h:  val_41, r:  val_54), a = new CinemachineFreeLook.Orbit(h:  val_41, r:  val_54)}, vh:  val_53 & 4294967295);
            label_30:
            if(this.makeColumns != false)
            {
                    val_55 = val_54;
                val_56 = val_54;
                val_57 = val_54;
            }
            else
            {
                    val_55 = val_54;
                val_56 = val_54;
                val_57 = val_54;
            }
            
            UnityEngine.UI.Extensions.UICornerCut.AddSquare(rect:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, rectUV:  new UnityEngine.Rect() {m_XMin = val_2.m_XMin, m_YMin = val_2.m_YMin, m_Width = val_2.m_Width, m_Height = val_2.m_Height}, color32:  new UnityEngine.Color32() {r = 120, g = 103, b = 221, a = 229}, vh:  val_4.r & 4294967295);
        }
        private static void AddSquare(UnityEngine.Rect rect, UnityEngine.Rect rectUV, UnityEngine.Color32 color32, UnityEngine.UI.VertexHelper vh)
        {
            UnityEngine.UI.VertexHelper val_1 = vh & 4294967295;
            int val_2 = UnityEngine.UI.Extensions.UICornerCut.AddVert(x:  rect.m_XMin, y:  rect.m_XMin, area:  new UnityEngine.Rect() {m_XMin = rectUV.m_XMin, m_YMin = rectUV.m_YMin, m_Width = rectUV.m_Width, m_Height = rectUV.m_Height}, color32:  new UnityEngine.Color32() {r = 96, g = 77, b = 223, a = 229}, vh:  val_1);
            int val_3 = UnityEngine.UI.Extensions.UICornerCut.AddVert(x:  rect.m_XMin, y:  rect.m_XMin, area:  new UnityEngine.Rect() {m_XMin = rectUV.m_XMin, m_YMin = rectUV.m_YMin, m_Width = rectUV.m_Width, m_Height = rectUV.m_Height}, color32:  new UnityEngine.Color32() {r = 96, g = 77, b = 223, a = 229}, vh:  val_1);
            int val_4 = UnityEngine.UI.Extensions.UICornerCut.AddVert(x:  rect.m_XMin, y:  rect.m_XMin, area:  new UnityEngine.Rect() {m_XMin = rectUV.m_XMin, m_YMin = rectUV.m_YMin, m_Width = rectUV.m_Width, m_Height = rectUV.m_Height}, color32:  new UnityEngine.Color32() {r = 96, g = 77, b = 223, a = 229}, vh:  val_1);
            if(X2 != 0)
            {
                    X2.AddTriangle(idx0:  val_2, idx1:  val_3, idx2:  val_4);
            }
            else
            {
                    0.AddTriangle(idx0:  val_2, idx1:  val_3, idx2:  val_4);
            }
            
            X2.AddTriangle(idx0:  val_4, idx1:  UnityEngine.UI.Extensions.UICornerCut.AddVert(x:  rect.m_XMin, y:  rect.m_XMin, area:  new UnityEngine.Rect() {m_XMin = rectUV.m_XMin, m_YMin = rectUV.m_YMin, m_Width = rectUV.m_Width, m_Height = rectUV.m_Height}, color32:  new UnityEngine.Color32() {r = 96, g = 77, b = 223, a = 229}, vh:  val_1), idx2:  val_2);
        }
        private static void AddSquare(UnityEngine.Vector2 a, UnityEngine.Vector2 b, UnityEngine.Vector2 c, UnityEngine.Vector2 d, UnityEngine.Rect rectUV, UnityEngine.Color32 color32, UnityEngine.UI.VertexHelper vh)
        {
            float val_1;
            float val_2;
            UnityEngine.UI.VertexHelper val_3 = vh & 4294967295;
            int val_4 = UnityEngine.UI.Extensions.UICornerCut.AddVert(x:  a.x, y:  a.y, area:  new UnityEngine.Rect() {m_XMin = rectUV.m_XMin, m_YMin = val_1, m_Width = rectUV.m_YMin, m_Height = val_2}, color32:  new UnityEngine.Color32() {r = color32.r, g = color32.g, b = color32.b, a = color32.a}, vh:  val_3);
            int val_5 = UnityEngine.UI.Extensions.UICornerCut.AddVert(x:  b.x, y:  b.y, area:  new UnityEngine.Rect() {m_XMin = rectUV.m_XMin, m_YMin = val_1, m_Width = rectUV.m_YMin, m_Height = val_2}, color32:  new UnityEngine.Color32() {r = val_4, g = val_4, b = val_4, a = val_4}, vh:  val_3);
            int val_6 = UnityEngine.UI.Extensions.UICornerCut.AddVert(x:  c.x, y:  c.y, area:  new UnityEngine.Rect() {m_XMin = rectUV.m_XMin, m_YMin = val_1, m_Width = rectUV.m_YMin, m_Height = val_2}, color32:  new UnityEngine.Color32() {r = val_5, g = val_5, b = val_5, a = val_5}, vh:  val_3);
            if(X2 != 0)
            {
                    X2.AddTriangle(idx0:  val_4, idx1:  val_5, idx2:  val_6);
            }
            else
            {
                    0.AddTriangle(idx0:  val_4, idx1:  val_5, idx2:  val_6);
            }
            
            X2.AddTriangle(idx0:  val_6, idx1:  UnityEngine.UI.Extensions.UICornerCut.AddVert(x:  d.x, y:  d.y, area:  new UnityEngine.Rect() {m_XMin = rectUV.m_XMin, m_YMin = val_1, m_Width = rectUV.m_YMin, m_Height = val_2}, color32:  new UnityEngine.Color32() {r = val_6, g = val_6, b = val_6, a = val_6}, vh:  val_3), idx2:  val_4);
        }
        private static int AddVert(float x, float y, UnityEngine.Rect area, UnityEngine.Color32 color32, UnityEngine.UI.VertexHelper vh)
        {
            float val_1 = UnityEngine.Mathf.InverseLerp(a:  x, b:  x, value:  x);
            CinemachineFreeLook.Orbit val_3 = new CinemachineFreeLook.Orbit(h:  val_1, r:  UnityEngine.Mathf.InverseLerp(a:  val_1, b:  val_1, value:  y));
            X2.AddVert(position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, color:  new UnityEngine.Color32() {r = vh & 4294967295, g = vh & 4294967295, b = vh & 4294967295, a = vh & 4294967295}, uv0:  new UnityEngine.Vector2() {x = val_3.m_Height, y = val_3.m_Radius});
            int val_5 = X2.currentVertCount;
            val_5 = val_5 - 1;
            return (int)val_5;
        }
    
    }

}
