using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    [UnityEngine.RequireComponent]
    [UnityEngine.AddComponentMenu]
    public class ToolTip : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Text _text;
        private UnityEngine.RectTransform _rectTransform;
        private bool _inside;
        private float width;
        private float height;
        private float YShift;
        private float xShift;
        private UnityEngine.RenderMode _guiMode;
        private UnityEngine.Camera _guiCamera;
        
        // Methods
        public ToolTip()
        {
        
        }
        public void Awake()
        {
            UnityEngine.Canvas val_1 = this.GetComponentInParent<UnityEngine.Canvas>();
            if(val_1 != null)
            {
                    this._guiCamera = val_1.worldCamera;
            }
            else
            {
                    this._guiCamera = val_1.worldCamera;
            }
            
            this._guiMode = val_1.renderMode;
            this._rectTransform = this.GetComponent<UnityEngine.RectTransform>();
            this._text = this.GetComponentInChildren<UnityEngine.UI.Text>();
            this._inside = false;
            this.YShift = -30f;
            this.xShift = 0f;
            this.gameObject.SetActive(value:  false);
        }
        public void SetTooltip(string ttext)
        {
            if(this._guiMode != 1)
            {
                    return;
            }
            
            CinemachineFreeLook.Orbit val_3 = new CinemachineFreeLook.Orbit(h:  V0.16B + 40f, r:  S0 + 25f);
            this._rectTransform.sizeDelta = new UnityEngine.Vector2() {x = val_3.m_Height, y = val_3.m_Radius};
            this.OnScreenSpaceCamera();
        }
        public void HideTooltip()
        {
            if(this._guiMode != 1)
            {
                    return;
            }
            
            this.gameObject.SetActive(value:  false);
            this._inside = false;
        }
        private void FixedUpdate()
        {
            if(this._inside == false)
            {
                    return;
            }
            
            if(this._guiMode != 1)
            {
                    return;
            }
            
            this.OnScreenSpaceCamera();
        }
        public void OnScreenSpaceCamera()
        {
            float val_20;
            float val_21;
            float val_22;
            float val_23;
            float val_24;
            float val_28;
            float val_29;
            UnityEngine.Vector3 val_1 = UnityEngine.Input.mousePosition;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Vector3 val_3 = this._guiCamera.ScreenToViewportPoint(position:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            val_20 = val_3.x;
            val_21 = val_3.y;
            UnityEngine.Vector3 val_4 = this._guiCamera.ViewportToWorldPoint(position:  new UnityEngine.Vector3() {x = val_20, y = val_21, z = val_3.z});
            val_22 = val_4.x;
            val_23 = val_4.y;
            UnityEngine.Vector2 val_5 = this._rectTransform.sizeDelta;
            this.width = val_5.x;
            UnityEngine.Vector2 val_6 = this._rectTransform.sizeDelta;
            this.height = val_6.x;
            UnityEngine.Vector3 val_7 = this._guiCamera.ViewportToWorldPoint(position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_24 = val_7.y;
            UnityEngine.Vector3 val_8 = this._guiCamera.ViewportToWorldPoint(position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_28 = this.width;
            float val_20 = 0.5f;
            val_20 = val_28 * val_20;
            val_20 = val_22 + val_20;
            if(val_20 > val_8.x)
            {
                    val_8.x = val_20 - val_8.x;
                float val_21 = 0f;
                val_21 = val_22 - val_21;
                UnityEngine.Vector3 val_9 = this._guiCamera.WorldToViewportPoint(position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                val_28 = this.width;
                val_21 = val_21;
                val_22 = val_22;
                val_23 = val_23;
                val_20 = val_9.x;
                val_24 = val_24;
            }
            
            float val_22 = -0.5f;
            val_22 = val_28 * val_22;
            val_22 = val_22 + val_22;
            if(val_22 < 0)
            {
                    val_22 = val_7.x - val_22;
                float val_23 = 0f;
                val_23 = val_22 + val_23;
                val_21 = 0f;
                UnityEngine.Vector3 val_10 = this._guiCamera.WorldToViewportPoint(position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = val_21});
                val_20 = val_10.x;
            }
            
            val_29 = this.height;
            float val_11 = val_29 * 0.5f;
            if((val_23 + val_11) > val_8.y)
            {
                    val_11 = val_11 + 35f;
                float val_13 = val_23 - 0f;
                val_21 = 0f;
                UnityEngine.Vector3 val_14 = this._guiCamera.WorldToViewportPoint(position:  new UnityEngine.Vector3() {x = 0f, y = val_21, z = 0f});
                val_29 = this.height;
            }
            
            val_29 = val_29 * 0.5f;
            if((val_23 - val_29) < 0)
            {
                    float val_24 = 35f;
                val_24 = val_29 + val_24;
                float val_16 = val_23 + 0f;
                val_20 = 0f;
                val_21 = 0f;
                UnityEngine.Vector3 val_17 = this._guiCamera.WorldToViewportPoint(position:  new UnityEngine.Vector3() {x = val_20, y = 0f, z = val_21});
            }
            
            this.transform.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.gameObject.SetActive(value:  true);
            this._inside = true;
        }
    
    }

}
