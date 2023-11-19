using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    [UnityEngine.ExecuteInEditMode]
    [UnityEngine.RequireComponent]
    [UnityEngine.AddComponentMenu]
    public class ShineEffector : MonoBehaviour
    {
        // Fields
        public UnityEngine.UI.Extensions.ShineEffect effector;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        private UnityEngine.GameObject effectRoot;
        [UnityEngine.RangeAttribute]
        public float yOffset;
        [UnityEngine.RangeAttribute]
        public float width;
        private UnityEngine.RectTransform effectorRect;
        
        // Properties
        public float YOffset { get; set; }
        
        // Methods
        public ShineEffector()
        {
            this.yOffset = -1f;
            this.width = 0.5f;
        }
        public float get_YOffset()
        {
            return (float)this.yOffset;
        }
        public void set_YOffset(float value)
        {
            this.ChangeVal(value:  value);
            this.yOffset = value;
        }
        private void OnEnable()
        {
            if(0 != this.effector)
            {
                    return;
            }
            
            UnityEngine.GameObject val_2 = new UnityEngine.GameObject(name:  "effector");
            this.effectRoot = new UnityEngine.GameObject(name:  "ShineEffect");
            transform.SetParent(parent:  this.transform);
            this.effectRoot.AddComponent<UnityEngine.UI.Image>().sprite = this.gameObject.GetComponent<UnityEngine.UI.Image>().sprite;
            this.effectRoot.GetComponent<UnityEngine.UI.Image>().type = this.gameObject.GetComponent<UnityEngine.UI.Image>().type;
            this.effectRoot.AddComponent<UnityEngine.UI.Mask>().showMaskGraphic = false;
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.one;
            this.effectRoot.transform.localScale = new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z};
            UnityEngine.Vector3 val_18 = UnityEngine.Vector3.zero;
            this.effectRoot.GetComponent<UnityEngine.RectTransform>().anchoredPosition3D = new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z};
            UnityEngine.Vector2 val_20 = UnityEngine.Vector2.one;
            this.effectRoot.GetComponent<UnityEngine.RectTransform>().anchorMax = new UnityEngine.Vector2() {x = val_20.x, y = val_20.y};
            UnityEngine.Vector2 val_22 = UnityEngine.Vector2.zero;
            this.effectRoot.GetComponent<UnityEngine.RectTransform>().anchorMin = new UnityEngine.Vector2() {x = val_22.x, y = val_22.y};
            UnityEngine.Vector2 val_24 = UnityEngine.Vector2.zero;
            this.effectRoot.GetComponent<UnityEngine.RectTransform>().offsetMax = new UnityEngine.Vector2() {x = val_24.x, y = val_24.y};
            UnityEngine.Vector2 val_26 = UnityEngine.Vector2.zero;
            this.effectRoot.GetComponent<UnityEngine.RectTransform>().offsetMin = new UnityEngine.Vector2() {x = val_26.x, y = val_26.y};
            this.effectRoot.transform.SetAsFirstSibling();
            if(null != 0)
            {
                    UnityEngine.RectTransform val_28 = AddComponent<UnityEngine.RectTransform>();
            }
            else
            {
                    UnityEngine.RectTransform val_29 = AddComponent<UnityEngine.RectTransform>();
            }
            
            transform.SetParent(parent:  this.effectRoot.transform);
            UnityEngine.RectTransform val_32 = GetComponent<UnityEngine.RectTransform>();
            this.effectorRect = val_32;
            UnityEngine.Vector3 val_33 = UnityEngine.Vector3.one;
            val_32.localScale = new UnityEngine.Vector3() {x = val_33.x, y = val_33.y, z = val_33.z};
            UnityEngine.Vector3 val_34 = UnityEngine.Vector3.zero;
            this.effectorRect.anchoredPosition3D = new UnityEngine.Vector3() {x = val_34.x, y = val_34.y, z = val_34.z};
            UnityEngine.UI.Extensions.ShineEffect val_36 = this.effectorRect.gameObject.AddComponent<UnityEngine.UI.Extensions.ShineEffect>();
            UnityEngine.Vector2 val_37 = UnityEngine.Vector2.one;
            this.effectorRect.anchorMax = new UnityEngine.Vector2() {x = val_37.x, y = val_37.y};
            UnityEngine.Vector2 val_38 = UnityEngine.Vector2.zero;
            this.effectorRect.anchorMin = new UnityEngine.Vector2() {x = val_38.x, y = val_38.y};
            this.effectorRect.Rotate(xAngle:  0f, yAngle:  0f, zAngle:  -8f);
            this.effector = GetComponent<UnityEngine.UI.Extensions.ShineEffect>();
            UnityEngine.Vector2 val_40 = UnityEngine.Vector2.zero;
            this.effectorRect.offsetMax = new UnityEngine.Vector2() {x = val_40.x, y = val_40.y};
            UnityEngine.Vector2 val_41 = UnityEngine.Vector2.zero;
            this.effectorRect.offsetMin = new UnityEngine.Vector2() {x = val_41.x, y = val_41.y};
            this.OnValidate();
        }
        private void OnValidate()
        {
            UnityEngine.GameObject val_3;
            var val_4;
            val_3 = this;
            this.effector.SetVerticesDirty();
            this.effector.yoffset = this.yOffset;
            this.effector.SetAllDirty();
            this.effector.width = this.width;
            if((this.yOffset <= (-1f)) || (this.yOffset >= 1f))
            {
                goto label_3;
            }
            
            if(this.effectRoot.activeSelf == false)
            {
                goto label_5;
            }
            
            return;
            label_3:
            val_4 = 0;
            goto label_7;
            label_5:
            val_3 = this.effectRoot;
            val_4 = 1;
            label_7:
            val_3.SetActive(value:  true);
        }
        private void ChangeVal(float value)
        {
            UnityEngine.GameObject val_3;
            var val_4;
            val_3 = this;
            this.effector.SetVerticesDirty();
            this.effector.yoffset = value;
            if((value <= (-1f)) || (value >= 1f))
            {
                goto label_2;
            }
            
            if(this.effectRoot.activeSelf == false)
            {
                goto label_4;
            }
            
            return;
            label_2:
            val_4 = 0;
            goto label_6;
            label_4:
            val_3 = this.effectRoot;
            val_4 = 1;
            label_6:
            val_3.SetActive(value:  true);
        }
        private void OnDestroy()
        {
            if(UnityEngine.Application.isPlaying != false)
            {
                    UnityEngine.Object.Destroy(obj:  0);
                return;
            }
            
            UnityEngine.Object.DestroyImmediate(obj:  0);
        }
    
    }

}
