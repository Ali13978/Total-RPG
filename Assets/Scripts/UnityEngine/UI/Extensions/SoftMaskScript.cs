using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    [UnityEngine.ExecuteInEditMode]
    [UnityEngine.AddComponentMenu]
    public class SoftMaskScript : MonoBehaviour
    {
        // Fields
        private UnityEngine.Material mat;
        private UnityEngine.Canvas cachedCanvas;
        private UnityEngine.Transform cachedCanvasTransform;
        private readonly UnityEngine.Vector3[] m_WorldCorners;
        private readonly UnityEngine.Vector3[] m_CanvasCorners;
        [UnityEngine.TooltipAttribute]
        public UnityEngine.RectTransform MaskArea;
        [UnityEngine.TooltipAttribute]
        public UnityEngine.Texture AlphaMask;
        [UnityEngine.TooltipAttribute]
        [UnityEngine.RangeAttribute]
        public float CutOff;
        [UnityEngine.TooltipAttribute]
        public bool HardBlend;
        [UnityEngine.TooltipAttribute]
        public bool FlipAlphaMask;
        [UnityEngine.TooltipAttribute]
        public bool DontClipMaskScalingRect;
        private UnityEngine.Vector2 maskOffset;
        private UnityEngine.Vector2 maskScale;
        
        // Methods
        public SoftMaskScript()
        {
            this.m_WorldCorners = null;
            this.m_CanvasCorners = null;
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
            this.maskOffset = val_1;
            mem[1152921512722934988] = val_1.y;
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.one;
            this.maskScale = val_2;
            mem[1152921512722934996] = val_2.y;
        }
        private void Start()
        {
            if(0 == this.MaskArea)
            {
                    this.MaskArea = this.GetComponent<UnityEngine.RectTransform>();
            }
            
            UnityEngine.UI.Text val_3 = this.GetComponent<UnityEngine.UI.Text>();
            if(0 == val_3)
            {
                goto label_6;
            }
            
            UnityEngine.Material val_6 = new UnityEngine.Material(shader:  UnityEngine.Shader.Find(name:  0));
            this.mat = val_6;
            if(val_3 == null)
            {
                goto label_23;
            }
            
            val_3.material = val_6;
            UnityEngine.Canvas val_7 = val_3.canvas;
            this.cachedCanvas = val_7;
            this.cachedCanvasTransform = val_7.transform;
            if(0 == (this.transform.parent.GetComponent<UnityEngine.UI.Mask>()))
            {
                    UnityEngine.UI.Mask val_16 = this.transform.parent.gameObject.AddComponent<UnityEngine.UI.Mask>();
            }
            
            this.transform.parent.GetComponent<UnityEngine.UI.Mask>().enabled = false;
            return;
            label_6:
            UnityEngine.UI.Graphic val_20 = this.GetComponent<UnityEngine.UI.Graphic>();
            if(0 == val_20)
            {
                    return;
            }
            
            this.mat = new UnityEngine.Material(shader:  UnityEngine.Shader.Find(name:  0));
            if(val_20 != null)
            {
                    UnityEngine.Canvas val_24 = val_20.canvas;
                this.cachedCanvas = val_24;
                this.cachedCanvasTransform = val_24.transform;
                return;
            }
            
            label_23:
        }
        private void Update()
        {
            if(0 == this.cachedCanvas)
            {
                    return;
            }
            
            this.SetMask();
        }
        private void SetMask()
        {
            UnityEngine.Rect val_1 = this.GetCanvasRect();
            val_1.m_XMin = 1f / val_1.m_XMin;
            val_1.m_YMin = 1f / val_1.m_YMin;
            this.maskScale.Set(newX:  val_1.m_XMin, newY:  val_1.m_YMin);
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_UnaryNegation(a:  new UnityEngine.Vector2() {x = val_1.m_XMin, y = val_1.m_YMin});
            this.maskOffset = val_2;
            mem[1152921512723477420] = val_2.y;
            this.mat.SetTextureOffset(name:  "_AlphaMask", value:  new UnityEngine.Vector2() {x = this.maskOffset, y = mem[1152921512723477420]});
            this.mat.SetTextureScale(name:  "_AlphaMask", value:  new UnityEngine.Vector2() {x = this.maskScale, y = mem[1152921512723477420]});
            this.mat.SetTexture(name:  "_AlphaMask", value:  this.AlphaMask);
            this.mat.SetFloat(name:  "_HardBlend", value:  (this.HardBlend == true) ? 1f : 0f);
            this.mat.SetInt(name:  "_FlipAlphaMask", value:  this.FlipAlphaMask);
            this.mat.SetInt(name:  "_NoOuterClip", value:  this.DontClipMaskScalingRect);
            this.mat.SetFloat(name:  "_CutOff", value:  this.CutOff);
        }
        public UnityEngine.Rect GetCanvasRect()
        {
            UnityEngine.Vector3[] val_6;
            var val_7;
            val_6 = this;
            if(0 == this.cachedCanvas)
            {
                    return new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f};
            }
            
            this.MaskArea.GetWorldCorners(fourCornersArray:  this.m_WorldCorners);
            val_7 = 0;
            goto label_6;
            label_13:
            var val_2 = this.m_WorldCorners + (X24 * 12);
            val_7 = 1;
            mem2[0] = ???;
            mem2[0] = ???;
            mem2[0] = ???;
            label_6:
            if(val_7 >= 4)
            {
                goto label_8;
            }
            
            var val_3 = this.m_WorldCorners + (1 * 12);
            UnityEngine.Vector3 val_4 = this.cachedCanvasTransform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = (1 * 12) + this.m_WorldCorners + 32, y = (1 * 12) + this.m_WorldCorners + 32 + 4, z = (1 * 12) + this.m_WorldCorners + 40});
            if(val_7 < this.m_CanvasCorners.Length)
            {
                goto label_13;
            }
            
            goto label_13;
            label_8:
            UnityEngine.Vector3 val_7 = this.m_CanvasCorners[0];
            UnityEngine.Vector3 val_8 = this.m_CanvasCorners[0];
            val_6 = this.m_CanvasCorners;
            float val_5 = this.m_CanvasCorners[2] - this.m_CanvasCorners[0];
            float val_6 = this.m_CanvasCorners[2] - val_6[0];
            return new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f};
        }
    
    }

}
