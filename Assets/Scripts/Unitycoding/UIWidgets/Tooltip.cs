using UnityEngine;

namespace Unitycoding.UIWidgets
{
    public class Tooltip : UIWidget
    {
        // Fields
        [UnityEngine.HeaderAttribute]
        public UnityEngine.UI.Text text;
        public UnityEngine.UI.Image icon;
        public UnityEngine.UI.Image background;
        public bool updatePosition;
        private float width;
        private UnityEngine.Canvas canvas;
        private bool _updatePosition;
        
        // Methods
        public Tooltip()
        {
            this.width = 300f;
        }
        protected override void OnStart()
        {
            this.canvas = this.GetComponentInParent<UnityEngine.Canvas>();
            UnityEngine.Vector2 val_2 = sizeDelta;
            this.width = val_2.x;
            if(this.IsVisible == false)
            {
                    return;
            }
            
            this = ???;
            goto typeof(Unitycoding.UIWidgets.Tooltip).__il2cppRuntimeField_180;
        }
        protected virtual void Update()
        {
            if(this.updatePosition == false)
            {
                    return;
            }
            
            if(X20.alpha <= 0f)
            {
                    return;
            }
            
            if(this._updatePosition == false)
            {
                    return;
            }
            
            this.UpdatePosition();
        }
        private void UpdatePosition()
        {
            UnityEngine.Camera val_24;
            float val_25;
            float val_26;
            UnityEngine.Transform val_1 = this.canvas.transform;
            UnityEngine.Vector3 val_2 = UnityEngine.Input.mousePosition;
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            UnityEngine.Camera val_4 = this.canvas.worldCamera;
            if(val_1 != null)
            {
                    var val_5 = (null == null) ? (val_1) : 0;
            }
            else
            {
                    val_24 = 0;
            }
            
            bool val_6 = UnityEngine.RectTransformUtility.ScreenPointToLocalPointInRectangle(rect:  0, screenPoint:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y}, cam:  val_24, localPoint: out  new UnityEngine.Vector2() {x = val_4, y = val_4});
            UnityEngine.Vector2 val_7 = UnityEngine.Vector2.zero;
            UnityEngine.Vector3 val_8 = UnityEngine.Input.mousePosition;
            UnityEngine.Vector2 val_9 = val_1.sizeDelta;
            UnityEngine.Vector2 val_10 = val_1.sizeDelta;
            if(val_8.x < 0)
            {
                    val_25 = 0.5f;
            }
            else
            {
                    val_25 = -0.5f;
            }
            
            val_10.x = val_10.x * val_25;
            CinemachineFreeLook.Orbit val_11 = new CinemachineFreeLook.Orbit(h:  val_10.x, r:  0f);
            UnityEngine.Vector2 val_12 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y}, b:  new UnityEngine.Vector2() {x = val_11.m_Height, y = val_11.m_Radius});
            UnityEngine.Vector3 val_14 = UnityEngine.Input.mousePosition;
            float val_24 = val_14.y;
            UnityEngine.Vector2 val_15 = val_4.sizeDelta;
            val_24 = (float)UnityEngine.Screen.height - val_24;
            UnityEngine.Vector2 val_16 = val_4.sizeDelta;
            if(val_24 > val_15.y)
            {
                    val_26 = 0.5f;
            }
            else
            {
                    val_26 = -0.5f;
            }
            
            val_16.y = val_16.y * val_26;
            CinemachineFreeLook.Orbit val_17 = new CinemachineFreeLook.Orbit(h:  0f, r:  val_16.y);
            UnityEngine.Vector2 val_18 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_12.x, y = val_12.y}, b:  new UnityEngine.Vector2() {x = val_17.m_Height, y = val_17.m_Radius});
            UnityEngine.Vector2 val_19 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = 0f, y = 0f}, b:  new UnityEngine.Vector2() {x = val_18.x, y = val_18.y});
            UnityEngine.Vector3 val_22 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_19.x, y = val_19.y});
            UnityEngine.Vector3 val_23 = this.canvas.transform.TransformPoint(position:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z});
            val_4.transform.position = new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z};
        }
        public override void Show()
        {
            this.Show();
            X20.interactable = false;
            this.blocksRaycasts = false;
        }
        public virtual void Show(string tooltipText)
        {
            goto typeof(Unitycoding.UIWidgets.Tooltip).__il2cppRuntimeField_1D0;
        }
        public virtual void Show(string tooltipText, float width, bool showBackground)
        {
            bool val_1 = showBackground;
            goto typeof(Unitycoding.UIWidgets.Tooltip).__il2cppRuntimeField_1E0;
        }
        public virtual void Show(string tooltipText, UnityEngine.Sprite icon, float width, bool showBackground)
        {
            var val_13;
            UnityEngine.Object val_14;
            var val_15;
            var val_16;
            val_14 = icon;
            if((System.String.IsNullOrEmpty(value:  0)) == true)
            {
                    return;
            }
            
            val_13 = UnityEngine.Object.op_Inequality(x:  0, y:  val_14);
            if(val_13 != false)
            {
                    this.icon.sprite = val_14;
                val_15 = this.icon.transform.parent.gameObject;
                val_16 = 1;
            }
            else
            {
                    val_15 = this.icon.transform.parent.gameObject;
                val_16 = 0;
            }
            
            val_15.SetActive(value:  false);
            UnityEngine.Vector2 val_10 = val_15.sizeDelta;
            CinemachineFreeLook.Orbit val_11 = new CinemachineFreeLook.Orbit(h:  width, r:  val_10.y);
            val_15.sizeDelta = new UnityEngine.Vector2() {x = val_11.m_Height, y = val_11.m_Radius};
            val_14 = this.background;
            val_14.enabled = showBackground;
            this._updatePosition = true;
            this.UpdatePosition();
        }
        public override void Close()
        {
            this.Close();
            this._updatePosition = false;
        }
    
    }

}
