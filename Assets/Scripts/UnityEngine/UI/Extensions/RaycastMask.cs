using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    [UnityEngine.RequireComponent]
    [UnityEngine.RequireComponent]
    [UnityEngine.AddComponentMenu]
    public class RaycastMask : MonoBehaviour, ICanvasRaycastFilter
    {
        // Fields
        private UnityEngine.UI.Image _image;
        private UnityEngine.Sprite _sprite;
        
        // Methods
        public RaycastMask()
        {
        
        }
        private void Start()
        {
            this._image = this.GetComponent<UnityEngine.UI.Image>();
        }
        public bool IsRaycastLocationValid(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera)
        {
            var val_37;
            UnityEngine.Camera val_38;
            float val_39;
            float val_40;
            float val_41;
            float val_43;
            float val_44;
            float val_45;
            int val_46;
            float val_47;
            float val_48;
            this._sprite = this._image.sprite;
            UnityEngine.Transform val_2 = this.transform;
            val_37 = 0;
            if(val_2 != null)
            {
                    val_37 = val_2;
                if(null != null)
            {
                    val_37 = 0;
            }
            
            }
            
            val_38 = this.transform;
            if(val_38 != null)
            {
                    if(null == null)
            {
                goto label_7;
            }
            
            }
            
            val_38 = 0;
            label_7:
            bool val_6 = UnityEngine.RectTransformUtility.ScreenPointToLocalPointInRectangle(rect:  0, screenPoint:  new UnityEngine.Vector2() {x = sp.x, y = sp.y}, cam:  val_38, localPoint: out  new UnityEngine.Vector2() {x = eventCamera, y = eventCamera});
            if(val_37 != 0)
            {
                    UnityEngine.Vector2 val_7 = val_37.pivot;
                val_39 = val_7.x;
            }
            else
            {
                    UnityEngine.Vector2 val_8 = val_37.pivot;
                val_39 = val_8.x;
            }
            
            UnityEngine.Rect val_9 = val_37.rect;
            val_40 = 0f;
            if(val_37 != 0)
            {
                    UnityEngine.Vector2 val_10 = val_37.pivot;
                val_41 = val_10.y;
            }
            else
            {
                    UnityEngine.Vector2 val_11 = val_37.pivot;
                val_41 = val_11.y;
            }
            
            UnityEngine.Rect val_12 = val_37.rect;
            CinemachineFreeLook.Orbit val_17 = new CinemachineFreeLook.Orbit(h:  0f + (val_39 * val_9.m_XMin), r:  val_40 + (val_41 * val_12.m_XMin));
            UnityEngine.Rect val_18 = this._sprite.textureRect;
            UnityEngine.Rect val_19 = val_37.rect;
            if(this._image.type != 1)
            {
                goto label_15;
            }
            
            UnityEngine.Vector4 val_21 = this._sprite.border;
            val_43 = val_21.y;
            val_40 = val_21.z;
            if(val_17.m_Height >= 0)
            {
                goto label_17;
            }
            
            val_44 = val_21.x;
            val_45 = val_44 + val_17.m_Height;
            goto label_27;
            label_15:
            val_19.m_XMin = val_19.m_XMin * val_17.m_Height;
            val_19.m_XMin = val_19.m_XMin / val_19.m_XMin;
            val_19.m_XMin = val_19.m_XMin + val_19.m_XMin;
            val_46 = UnityEngine.Mathf.FloorToInt(f:  val_19.m_XMin);
            val_43 = val_19.m_XMin;
            val_44 = val_17.m_Radius;
            val_19.m_XMin = (val_19.m_XMin * val_44) / val_19.m_XMin;
            val_19.m_XMin = val_43 + val_19.m_XMin;
            goto label_37;
            label_17:
            val_47 = val_21.x - val_40;
            val_44 = val_21.x;
            if(val_17.m_Height > val_47)
            {
                    val_40 = val_21.x;
                val_21.x = val_44 + val_21.x;
                val_45 = val_21.x - (val_40 - val_17.m_Height);
            }
            else
            {
                    val_47 = val_21.x;
                float val_25 = val_21.x - val_21.x;
                float val_26 = val_17.m_Height - val_21.x;
                val_48 = val_47 - val_21.x;
                val_25 = val_25 - val_40;
                val_26 = val_26 / val_25;
                float val_27 = val_48 - val_40;
                val_21.x = val_21.x + val_44;
                val_26 = val_26 * val_27;
                val_45 = val_21.x + val_26;
            }
            
            label_27:
            val_46 = UnityEngine.Mathf.FloorToInt(f:  val_45);
            if(val_17.m_Radius < 0)
            {
                    val_43 = val_45;
                val_45 = val_43 + val_17.m_Radius;
            }
            else
            {
                    val_40 = val_45 - val_21.w;
                val_44 = val_45;
                if(val_17.m_Radius > val_40)
            {
                    val_43 = val_45;
                val_45 = val_44 + val_43;
                val_26 = val_45 - val_17.m_Radius;
                val_45 = val_45 - val_26;
            }
            else
            {
                    val_40 = val_45;
                val_27 = val_45 - val_43;
                float val_29 = val_17.m_Radius - val_43;
                val_48 = val_40 - val_43;
                val_27 = val_27 - val_21.w;
                val_29 = val_29 / val_27;
                val_45 = val_43 + val_44;
                val_29 = val_29 * (val_48 - val_21.w);
                val_45 = val_45 + val_29;
            }
            
            }
            
            label_37:
            UnityEngine.Color val_33 = this._sprite.texture.GetPixel(x:  val_46, y:  UnityEngine.Mathf.FloorToInt(f:  val_45));
            return (bool)(val_33.a > 0f) ? 1 : 0;
        }
    
    }

}
