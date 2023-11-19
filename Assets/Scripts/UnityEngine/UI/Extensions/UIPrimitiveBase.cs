using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    public class UIPrimitiveBase : MaskableGraphic, ILayoutElement, ICanvasRaycastFilter
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.Sprite m_Sprite;
        private UnityEngine.Sprite m_OverrideSprite;
        internal float m_EventAlphaThreshold;
        
        // Properties
        public UnityEngine.Sprite sprite { get; set; }
        public UnityEngine.Sprite overrideSprite { get; set; }
        public float eventAlphaThreshold { get; set; }
        public override UnityEngine.Texture mainTexture { get; }
        public float pixelsPerUnit { get; }
        public virtual float minWidth { get; }
        public virtual float preferredWidth { get; }
        public virtual float flexibleWidth { get; }
        public virtual float minHeight { get; }
        public virtual float preferredHeight { get; }
        public virtual float flexibleHeight { get; }
        public virtual int layoutPriority { get; }
        
        // Methods
        public UIPrimitiveBase()
        {
            this.m_EventAlphaThreshold = 1f;
        }
        public UnityEngine.Sprite get_sprite()
        {
            return (UnityEngine.Sprite)this.m_Sprite;
        }
        public void set_sprite(UnityEngine.Sprite value)
        {
            if((UnityEngine.UI.Extensions.SetPropertyUtility.SetClass<UnityEngine.Sprite>(currentValue: ref  0, newValue:  this.m_Sprite)) == false)
            {
                    return;
            }
            
            this.SetAllDirty();
        }
        public UnityEngine.Sprite get_overrideSprite()
        {
            return (UnityEngine.Sprite)(0 != this.m_OverrideSprite) ? this.m_Sprite : (this.m_OverrideSprite);
        }
        public void set_overrideSprite(UnityEngine.Sprite value)
        {
            if((UnityEngine.UI.Extensions.SetPropertyUtility.SetClass<UnityEngine.Sprite>(currentValue: ref  0, newValue:  this.m_OverrideSprite)) == false)
            {
                    return;
            }
            
            this.SetAllDirty();
        }
        public float get_eventAlphaThreshold()
        {
            return (float)this.m_EventAlphaThreshold;
        }
        public void set_eventAlphaThreshold(float value)
        {
            this.m_EventAlphaThreshold = value;
        }
        public override UnityEngine.Texture get_mainTexture()
        {
            var val_11;
            UnityEngine.Texture2D val_12;
            var val_13;
            if(0 != this.overrideSprite)
            {
                goto label_3;
            }
            
            if((0 == this.material) || (0 == this.material.mainTexture))
            {
                goto label_10;
            }
            
            UnityEngine.Material val_8 = this.material;
            if(val_8 != null)
            {
                    return val_8.mainTexture;
            }
            
            return val_8.mainTexture;
            label_3:
            val_11 = this.overrideSprite;
            UnityEngine.Texture2D val_10 = val_11.texture;
            return (UnityEngine.Texture)val_12;
            label_10:
            val_11 = 1152921504781926400;
            val_13 = null;
            val_13 = null;
            val_12 = UnityEngine.UI.Graphic.s_WhiteTexture;
            return (UnityEngine.Texture)val_12;
        }
        public float get_pixelsPerUnit()
        {
            var val_7;
            float val_9;
            val_7 = this;
            if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
            {
                    val_9 = this.m_Sprite.pixelsPerUnit;
            }
            else
            {
                    val_9 = 100f;
            }
            
            UnityEngine.Canvas val_3 = this.canvas;
            if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
            {
                    val_7 = this.canvas;
                float val_6 = val_7.referencePixelsPerUnit;
            }
            else
            {
                    float val_7 = 100f;
            }
            
            val_7 = val_9 / val_7;
            return (float)val_7;
        }
        protected UnityEngine.UIVertex[] SetVbo(UnityEngine.Vector2[] vertices, UnityEngine.Vector2[] uvs)
        {
            var val_2;
            var val_3;
            var val_4;
            var val_5;
            var val_6;
            var val_11;
            var val_12;
            val_11 = 0;
            goto label_1;
            label_13:
            var val_1 = null + (X28 * 76);
            mem2[0] = ???;
            mem2[0] = ???;
            mem2[0] = ???;
            val_11 = 1;
            mem2[0] = val_2;
            mem2[0] = ???;
            mem2[0] = ???;
            mem2[0] = ???;
            mem2[0] = val_3;
            mem2[0] = val_4;
            mem2[0] = val_5;
            mem2[0] = val_6;
            label_1:
            if(val_11 >= vertices.Length)
            {
                    return (UnityEngine.UIVertex[])null;
            }
            
            val_12 = null;
            val_12 = null;
            UnityEngine.Color val_7 = this.color;
            UnityEngine.Color32 val_8 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = val_7.r, g = val_7.g, b = val_7.b, a = val_7.a});
            UnityEngine.Vector3 val_9 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = vertices[1], y = vertices[1]});
            UnityEngine.Vector2 val_12 = uvs[1];
            UnityEngine.Vector2 val_13 = uvs[1];
            val_2 = UnityEngine.UIVertex.s_DefaultColor.__il2cppRuntimeField_28;
            val_3 = UnityEngine.UIVertex.s_DefaultColor.__il2cppRuntimeField_20;
            val_4 = UnityEngine.UIVertex.s_DefaultColor.__il2cppRuntimeField_58;
            val_6 = UnityEngine.UIVertex.s_DefaultColor.__il2cppRuntimeField_38;
            val_5 = UnityEngine.UIVertex.s_DefaultColor.__il2cppRuntimeField_48;
            goto label_13;
        }
        public virtual void CalculateLayoutInputHorizontal()
        {
        
        }
        public virtual void CalculateLayoutInputVertical()
        {
        
        }
        public virtual float get_minWidth()
        {
            return 0f;
        }
        public virtual float get_preferredWidth()
        {
            if(0 == this.overrideSprite)
            {
                    return (float)val_6;
            }
            
            UnityEngine.Rect val_5 = this.overrideSprite.rect;
            float val_6 = this.pixelsPerUnit;
            val_6 = val_5.m_XMin / val_6;
            return (float)val_6;
        }
        public virtual float get_flexibleWidth()
        {
            return -1f;
        }
        public virtual float get_minHeight()
        {
            return 0f;
        }
        public virtual float get_preferredHeight()
        {
            if(0 == this.overrideSprite)
            {
                    return (float)val_6;
            }
            
            UnityEngine.Rect val_5 = this.overrideSprite.rect;
            float val_6 = this.pixelsPerUnit;
            val_6 = val_5.m_YMin / val_6;
            return (float)val_6;
        }
        public virtual float get_flexibleHeight()
        {
            return -1f;
        }
        public virtual int get_layoutPriority()
        {
            return 0;
        }
        public virtual bool IsRaycastLocationValid(UnityEngine.Vector2 screenPoint, UnityEngine.Camera eventCamera)
        {
            UnityEngine.Vector2 val_26;
            float val_27;
            var val_28;
            val_26 = eventCamera;
            val_27 = screenPoint.y;
            if(this.m_EventAlphaThreshold < 1f)
            {
                    UnityEngine.Sprite val_1 = this.overrideSprite;
                if(0 != val_1)
            {
                    bool val_5 = UnityEngine.RectTransformUtility.ScreenPointToLocalPointInRectangle(rect:  0, screenPoint:  new UnityEngine.Vector2() {x = screenPoint.x, y = val_27}, cam:  this.rectTransform, localPoint: out  new UnityEngine.Vector2() {x = val_26, y = val_26});
                UnityEngine.Rect val_6 = this.GetPixelAdjustedRect();
                UnityEngine.Vector2 val_8 = this.rectTransform.pivot;
                val_8.x = val_8.x * val_8.x;
                val_8.x = 0f + val_8.x;
                UnityEngine.Vector2 val_10 = this.rectTransform.pivot;
                val_10.x = val_10.y * val_10.x;
                val_10.y = 0f + val_10.x;
                UnityEngine.Vector2 val_11 = this.MapCoordinate(local:  new UnityEngine.Vector2() {x = val_8.x, y = val_10.y}, rect:  new UnityEngine.Rect() {m_XMin = val_6.m_XMin, m_YMin = val_6.m_YMin, m_Width = val_6.m_Width, m_Height = val_6.m_Height});
                UnityEngine.Rect val_12 = val_1.textureRect;
                float val_13 = val_11.x / val_12.m_XMin;
                CinemachineFreeLook.Orbit val_15 = new CinemachineFreeLook.Orbit(h:  val_13, r:  val_11.y / val_12.m_XMin);
                float val_16 = UnityEngine.Mathf.Lerp(a:  val_13, b:  val_13, t:  val_15.m_Height);
                val_27 = val_16;
                val_26 = val_1.texture.width;
                float val_26 = (float)val_26;
                float val_27 = (float)val_1.texture.height;
                val_26 = val_27 / val_26;
                val_27 = (UnityEngine.Mathf.Lerp(a:  val_16, b:  val_16, t:  val_15.m_Radius)) / val_27;
                UnityEngine.Color val_23 = val_1.texture.GetPixelBilinear(u:  val_26, v:  val_27);
                string val_24 = (val_23.a >= this.m_EventAlphaThreshold) ? 1 : 0;
                return (bool)val_28;
            }
            
            }
            
            val_28 = 1;
            return (bool)val_28;
        }
        private UnityEngine.Vector2 MapCoordinate(UnityEngine.Vector2 local, UnityEngine.Rect rect)
        {
            UnityEngine.Rect val_1 = this.m_Sprite.rect;
            CinemachineFreeLook.Orbit val_6 = new CinemachineFreeLook.Orbit(h:  (local.x * val_1.m_XMin) / val_1.m_XMin, r:  (local.y * val_1.m_XMin) / val_1.m_XMin);
            return new UnityEngine.Vector2() {x = val_6.m_Height, y = val_6.m_Radius};
        }
        private UnityEngine.Vector4 GetAdjustedBorders(UnityEngine.Vector4 border, UnityEngine.Rect rect)
        {
            float val_1;
            var val_2 = 0;
            do
            {
                var val_1 = val_2 + 2;
                val_1 = border.x + border.x;
                if((val_1 != 0f) && (border.x < 0))
            {
                    val_1 = border.x / val_1;
                border.x = border.x * val_1;
                border.x = val_1 * border.x;
            }
            
                val_2 = val_2 + 1;
            }
            while(val_2 != 2);
            
            return new UnityEngine.Vector4() {x = border.x, y = border.y, z = border.z, w = border.w};
        }
    
    }

}
