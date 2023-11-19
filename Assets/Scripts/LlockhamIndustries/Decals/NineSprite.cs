using UnityEngine;

namespace LlockhamIndustries.Decals
{
    [UnityEngine.ExecuteInEditMode]
    public class NineSprite : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private LlockhamIndustries.Decals.ProjectionRenderer sprite;
        [UnityEngine.SerializeField]
        private float borderPixelSize;
        [UnityEngine.SerializeField]
        private float borderWorldSize;
        [UnityEngine.SerializeField]
        private LlockhamIndustries.Decals.ProjectionRenderer[] spritePieces;
        
        // Properties
        public LlockhamIndustries.Decals.ProjectionRenderer Sprite { get; set; }
        public float BorderPixelSize { get; set; }
        public float BorderWorldSize { get; set; }
        
        // Methods
        public NineSprite()
        {
            this.borderPixelSize = 0.4f;
            this.borderWorldSize = 7.346868E-41f;
        }
        public LlockhamIndustries.Decals.ProjectionRenderer get_Sprite()
        {
            return (LlockhamIndustries.Decals.ProjectionRenderer)this.sprite;
        }
        public void set_Sprite(LlockhamIndustries.Decals.ProjectionRenderer value)
        {
            if(0 == this.sprite)
            {
                    return;
            }
            
            this.sprite = value;
            this.UpdateProperties();
        }
        public float get_BorderPixelSize()
        {
            return (float)this.borderPixelSize;
        }
        public void set_BorderPixelSize(float value)
        {
            if(this.borderPixelSize == value)
            {
                    return;
            }
            
            this.borderPixelSize = value;
            this.UpdateProperties();
        }
        public float get_BorderWorldSize()
        {
            return (float)this.borderWorldSize;
        }
        public void set_BorderWorldSize(float value)
        {
            if(this.borderWorldSize == value)
            {
                    return;
            }
            
            this.borderWorldSize = value;
            this.UpdateTransforms();
        }
        private void OnDestroy()
        {
            this.ClearSprite();
        }
        public void UpdateProperties()
        {
            goto label_0;
            label_42:
            X22.UpdateProperties();
            0 = 1;
            label_0:
            if(0 >= this.spritePieces.Length)
            {
                    return;
            }
            
            this.spritePieces[1].Projection = this.sprite.Projection;
            UnityEngine.Vector2 val_2 = this.Tiling(Index:  1);
            this.spritePieces[1].Tiling = new UnityEngine.Vector2() {x = val_2.x, y = val_2.y};
            UnityEngine.Vector2 val_3 = this.Offset(Index:  1);
            this.spritePieces[1].Offset = new UnityEngine.Vector2() {x = val_3.x, y = val_3.y};
            LlockhamIndustries.Decals.ProjectionRenderer val_15 = this.spritePieces[1];
            if(this.spritePieces[0x1][0].maskMethod != this.sprite.maskMethod)
            {
                    this.spritePieces[0x1][0].maskMethod = this.sprite.maskMethod;
                this.spritePieces[0x1][0].marked = true;
            }
            
            this.spritePieces[1].MaskLayer1 = this.sprite.MaskLayer1;
            this.spritePieces[1].MaskLayer2 = this.sprite.MaskLayer2;
            this.spritePieces[1].MaskLayer3 = this.sprite.MaskLayer3;
            this.spritePieces[1].MaskLayer4 = this.sprite.MaskLayer4;
            this.spritePieces[1].Properties = this.sprite.properties;
            if(this.spritePieces[1] != null)
            {
                goto label_42;
            }
            
            goto label_42;
        }
        public void UpdateTransforms()
        {
            goto label_1;
            label_18:
            X21.localScale = new UnityEngine.Vector3() {x = V8.16B, y = V9.16B, z = V10.16B};
            0 = 1;
            label_1:
            if(0 >= this.spritePieces.Length)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_2 = this.LocalPosition(Index:  1);
            this.spritePieces[1].transform.localPosition = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
            UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.identity;
            this.spritePieces[1].transform.localRotation = new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w};
            UnityEngine.Vector3 val_6 = this.LocalScale(Index:  1);
            if(this.spritePieces[1].transform != null)
            {
                goto label_18;
            }
            
            goto label_18;
        }
        private UnityEngine.Vector2 Tiling(int Index)
        {
            var val_2 = (Index < 9) ? (Index + 3) : 0;
            val_2 = val_2 - 3;
            if(val_2 <= 8)
            {
                    var val_6 = 25815152 + ((Index < 9 ? (Index + 3) : 0 - 3)) << 2;
                val_6 = val_6 + 25815152;
            }
            else
            {
                    UnityEngine.Vector2 val_4 = UnityEngine.Vector2.zero;
                return new UnityEngine.Vector2() {x = val_5.m_Height, y = val_5.m_Radius};
            }
        
        }
        private UnityEngine.Vector2 Offset(int Index)
        {
            var val_2 = (Index < 9) ? (Index + 3) : 0;
            val_2 = val_2 - 3;
            if(val_2 <= 8)
            {
                    var val_6 = 25815188 + ((Index < 9 ? (Index + 3) : 0 - 3)) << 2;
                val_6 = val_6 + 25815188;
            }
            else
            {
                    UnityEngine.Vector2 val_3 = UnityEngine.Vector2.zero;
                return new UnityEngine.Vector2() {x = val_5.m_Height, y = val_5.m_Radius};
            }
        
        }
        private UnityEngine.Vector3 LocalPosition(int Index)
        {
            float val_12;
            UnityEngine.Vector3 val_2 = this.transform.localScale;
            UnityEngine.Vector3 val_4 = this.transform.localScale;
            if(((Index < 9) ? (Index + 3) : 0) > 11)
            {
                    return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            }
            
            var val_9 = 25815224 + (Index < 9 ? (Index + 3) : 0) << 2;
            float val_7 = this.borderWorldSize / val_2.x;
            val_4.y = this.borderWorldSize / val_4.y;
            val_9 = val_9 + 25815224;
            val_7 = val_7 * 0.5f;
            val_12 = val_4.y * 0.5f;
            goto (25815224 + (Index < 9 ? (Index + 3) : 0) << 2 + 25815224);
        }
        private UnityEngine.Vector3 LocalScale(int Index)
        {
            float val_12;
            UnityEngine.Vector3 val_2 = this.transform.localScale;
            UnityEngine.Vector3 val_4 = this.transform.localScale;
            if(((Index < 9) ? (Index + 3) : 0) > 11)
            {
                    return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            }
            
            var val_9 = 25815272 + (Index < 9 ? (Index + 3) : 0) << 2;
            float val_7 = this.borderWorldSize / val_2.x;
            val_12 = this.borderWorldSize / val_4.y;
            val_9 = val_9 + 25815272;
            goto (25815272 + (Index < 9 ? (Index + 3) : 0) << 2 + 25815272);
        }
        private void Generate()
        {
            this.spritePieces = null;
            typeof(LlockhamIndustries.Decals.ProjectionRenderer[]).__il2cppRuntimeField_20 = this.GenerateRenderer(Name:  "TopLeft");
            this.spritePieces[1] = this.GenerateRenderer(Name:  "TopMiddle");
            this.spritePieces[2] = this.GenerateRenderer(Name:  "TopRight");
            this.spritePieces[3] = this.GenerateRenderer(Name:  "MiddleLeft");
            this.spritePieces[4] = this.GenerateRenderer(Name:  "MiddleMiddle");
            this.spritePieces[5] = this.GenerateRenderer(Name:  "MiddleRight");
            this.spritePieces[6] = this.GenerateRenderer(Name:  "BottomLeft");
            this.spritePieces[7] = this.GenerateRenderer(Name:  "BottomMiddle");
            this.spritePieces[8] = this.GenerateRenderer(Name:  "BottomRight");
        }
        private LlockhamIndustries.Decals.ProjectionRenderer GenerateRenderer(string Name)
        {
            var val_7;
            UnityEngine.GameObject val_1 = new UnityEngine.GameObject(name:  Name);
            transform.parent = this.transform;
            if(null != 0)
            {
                    hideFlags = 3;
                SetActive(value:  false);
                val_7 = AddComponent<LlockhamIndustries.Decals.ProjectionRenderer>();
            }
            else
            {
                    0.hideFlags = 3;
                SetActive(value:  false);
                val_7 = AddComponent<LlockhamIndustries.Decals.ProjectionRenderer>();
            }
            
            LlockhamIndustries.Decals.NineSpritePiece val_6 = AddComponent<LlockhamIndustries.Decals.NineSpritePiece>();
            return (LlockhamIndustries.Decals.ProjectionRenderer)val_7;
        }
        public void UpdateNineSprite()
        {
            var val_5;
            if(0 == this.sprite)
            {
                goto label_7;
            }
            
            LlockhamIndustries.Decals.Projection val_2 = this.sprite.Projection;
            if(0 == val_2)
            {
                goto label_7;
            }
            
            if((this.spritePieces == null) || (this.spritePieces.Length != 9))
            {
                goto label_9;
            }
            
            this.UpdateProperties();
            this.UpdateTransforms();
            return;
            label_7:
            this.ClearSprite();
            return;
            label_9:
            this.Generate();
            this.UpdateProperties();
            this.UpdateTransforms();
            val_5 = 0;
            goto label_10;
            label_17:
            val_2.SetActive(value:  true);
            val_5 = 1;
            label_10:
            if(val_5 >= this.spritePieces.Length)
            {
                    return;
            }
            
            if(this.spritePieces[1].gameObject != null)
            {
                goto label_17;
            }
            
            goto label_17;
        }
        private void ClearSprite()
        {
            LlockhamIndustries.Decals.ProjectionRenderer[] val_1;
            var val_2;
            val_1 = this.spritePieces;
            if(val_1 == null)
            {
                    return;
            }
            
            val_2 = 0;
            goto label_2;
            label_9:
            UnityEngine.Object.DestroyImmediate(obj:  0);
            val_1 = this.spritePieces;
            val_2 = 1;
            label_2:
            if(val_2 >= this.spritePieces.Length)
            {
                goto label_4;
            }
            
            LlockhamIndustries.Decals.ProjectionRenderer val_1 = this.spritePieces[1];
            goto label_9;
            label_4:
            this.spritePieces = 0;
        }
    
    }

}
