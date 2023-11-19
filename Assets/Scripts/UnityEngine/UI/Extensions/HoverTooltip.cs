using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    [UnityEngine.AddComponentMenu]
    public class HoverTooltip : MonoBehaviour
    {
        // Fields
        public int horizontalPadding;
        public int verticalPadding;
        public UnityEngine.UI.Text thisText;
        public UnityEngine.UI.HorizontalLayoutGroup hlG;
        public UnityEngine.RectTransform bgImage;
        private UnityEngine.UI.Image bgImageSource;
        private bool firstUpdate;
        private bool inside;
        private UnityEngine.RenderMode GUIMode;
        private UnityEngine.Camera GUICamera;
        private UnityEngine.Vector3 lowerLeft;
        private UnityEngine.Vector3 upperRight;
        private float currentYScaleFactor;
        private float currentXScaleFactor;
        private float defaultYOffset;
        private float defaultXOffset;
        private float tooltipRealHeight;
        private float tooltipRealWidth;
        
        // Methods
        public HoverTooltip()
        {
        
        }
        private void Start()
        {
            this.GUICamera = UnityEngine.GameObject.Find(name:  0).GetComponent<UnityEngine.Camera>();
            this.GUIMode = this.transform.parent.parent.GetComponent<UnityEngine.Canvas>().renderMode;
            this.bgImageSource = this.bgImage.GetComponent<UnityEngine.UI.Image>();
            this.inside = false;
            this.HideTooltipVisibility();
            this.transform.parent.gameObject.SetActive(value:  false);
        }
        public void SetTooltip(string text)
        {
            this.NewTooltip();
            this.OnScreenSpaceCamera();
        }
        public void SetTooltip(string[] texts)
        {
            string val_5;
            var val_6;
            string val_7;
            this.NewTooltip();
            val_5 = null;
            val_5 = null;
            val_6 = 0;
            val_7 = System.String.Empty;
            goto label_3;
            label_13:
            val_7 = val_5;
            val_6 = 1;
            label_3:
            if(val_6 >= texts.Length)
            {
                goto label_5;
            }
            
            string val_5 = texts[1];
            if(val_6 == 0)
            {
                goto label_7;
            }
            
            string val_3 = 0 + val_7 + "\n";
            goto label_13;
            label_7:
            string val_4 = 0 + val_7;
            goto label_13;
            label_5:
            this.OnScreenSpaceCamera();
        }
        public void SetTooltip(string text, bool test)
        {
            this.NewTooltip();
            this.OnScreenSpaceCamera();
        }
        public void OnScreenSpaceCamera()
        {
            float val_39;
            float val_40;
            float val_44;
            float val_51;
            float val_53;
            UnityEngine.Vector3 val_1 = UnityEngine.Input.mousePosition;
            UnityEngine.Vector3 val_2 = this.GUICamera.ScreenToViewportPoint(position:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            val_39 = val_2.x;
            val_40 = val_2.y;
            UnityEngine.Vector3 val_3 = this.GUICamera.ViewportToScreenPoint(position:  new UnityEngine.Vector3() {x = val_39, y = val_40, z = val_2.z});
            UnityEngine.Vector2 val_4 = this.bgImage.pivot;
            val_4.x = this.tooltipRealWidth * val_4.x;
            float val_5 = val_3.x + val_4.x;
            if(val_5 > this.upperRight)
            {
                    val_44 = this.upperRight - val_5;
                double val_37 = (double)this.defaultXOffset;
                val_37 = val_37 * 0.75;
                if((double)val_44 <= val_37)
            {
                    float val_38 = this.tooltipRealWidth;
                val_38 = val_38 * (-2f);
                val_44 = this.defaultXOffset + val_38;
            }
            
                UnityEngine.Vector3 val_6 = this.GUICamera.ViewportToScreenPoint(position:  new UnityEngine.Vector3() {x = val_39, y = val_40, z = val_2.z});
                val_6.x = val_44 + val_6.x;
                UnityEngine.Vector3 val_7 = this.GUICamera.ScreenToViewportPoint(position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                val_39 = val_7.x;
            }
            
            UnityEngine.Vector3 val_8 = this.GUICamera.ViewportToScreenPoint(position:  new UnityEngine.Vector3() {x = val_39, y = val_40, z = val_2.z});
            float val_41 = val_8.x;
            UnityEngine.Vector2 val_9 = this.bgImage.pivot;
            val_9.x = this.tooltipRealWidth * val_9.x;
            val_9.x = val_41 - val_9.x;
            if(val_9.x < 0)
            {
                    val_9.x = this.lowerLeft - val_9.x;
                float val_40 = this.tooltipRealWidth;
                double val_39 = (double)this.defaultXOffset;
                val_39 = val_39 * 0.75;
                val_39 = val_39 - (double)val_40;
                val_40 = val_40 + val_40;
                val_41 = ((double)val_9.x < 0) ? (-val_9.x) : (val_40);
                UnityEngine.Vector3 val_10 = this.GUICamera.ViewportToScreenPoint(position:  new UnityEngine.Vector3() {x = val_39, y = val_40, z = val_2.z});
                val_10.x = val_10.x - val_41;
                UnityEngine.Vector3 val_11 = this.GUICamera.ScreenToViewportPoint(position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                val_39 = val_11.x;
            }
            
            UnityEngine.Vector3 val_12 = this.GUICamera.ViewportToScreenPoint(position:  new UnityEngine.Vector3() {x = val_39, y = val_40, z = val_2.z});
            float val_43 = val_12.y;
            UnityEngine.Vector2 val_13 = this.bgImage.sizeDelta;
            UnityEngine.Vector2 val_14 = this.bgImage.pivot;
            float val_42 = this.tooltipRealHeight;
            val_14.y = (val_13.y * this.currentYScaleFactor) * val_14.y;
            val_42 = val_14.y - val_42;
            val_43 = val_43 - val_42;
            if(val_43 > val_13.y)
            {
                    val_51 = val_13.y - val_43;
                UnityEngine.Vector2 val_16 = this.bgImage.sizeDelta;
                UnityEngine.Vector2 val_17 = this.bgImage.pivot;
                double val_44 = (double)this.defaultYOffset;
                val_44 = val_44 * 0.75;
                if((double)val_51 <= val_44)
            {
                    float val_45 = this.tooltipRealHeight;
                val_45 = val_45 * (-2f);
                val_51 = this.defaultYOffset + val_45;
            }
            
                UnityEngine.Vector3 val_18 = this.GUICamera.ViewportToScreenPoint(position:  new UnityEngine.Vector3() {x = val_39, y = val_40, z = val_2.z});
                val_18.y = val_51 + val_18.y;
                UnityEngine.Vector3 val_19 = this.GUICamera.ScreenToViewportPoint(position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                val_40 = val_19.y;
            }
            
            UnityEngine.Vector3 val_20 = this.GUICamera.ViewportToScreenPoint(position:  new UnityEngine.Vector3() {x = val_39, y = val_40, z = val_2.z});
            float val_46 = val_20.y;
            UnityEngine.Vector2 val_21 = this.bgImage.sizeDelta;
            val_53 = val_21.y;
            UnityEngine.Vector2 val_22 = this.bgImage.pivot;
            float val_23 = val_53 * this.currentYScaleFactor;
            val_23 = val_23 * val_22.y;
            val_46 = val_46 - val_23;
            if(val_46 < 0)
            {
                    val_46 = S14 - val_46;
                UnityEngine.Vector2 val_24 = this.bgImage.sizeDelta;
                UnityEngine.Vector2 val_25 = this.bgImage.pivot;
                float val_48 = this.tooltipRealHeight;
                double val_47 = (double)this.defaultYOffset;
                val_47 = val_47 * 0.75;
                val_47 = val_47 - (double)val_48;
                val_48 = val_48 + val_48;
                UnityEngine.Vector3 val_27 = this.GUICamera.ViewportToScreenPoint(position:  new UnityEngine.Vector3() {x = val_39, y = val_40, z = val_2.z});
                val_27.y = (((double)val_46 < 0) ? (val_46) : (val_48)) + val_27.y;
                val_53 = 0f;
                UnityEngine.Vector3 val_28 = this.GUICamera.ScreenToViewportPoint(position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = val_53});
                val_40 = val_28.y;
            }
            
            UnityEngine.Vector3 val_32 = this.GUICamera.ViewportToWorldPoint(position:  new UnityEngine.Vector3() {x = val_39, y = val_40, z = val_2.z});
            UnityEngine.Vector3 val_33 = this.GUICamera.ViewportToWorldPoint(position:  new UnityEngine.Vector3() {x = val_39, y = val_40, z = val_2.z});
            this.transform.parent.transform.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this.transform.parent.gameObject.SetActive(value:  true);
            this.inside = true;
        }
        public void HideTooltip()
        {
            if(this.GUIMode != 1)
            {
                    return;
            }
            
            if(0 == this)
            {
                    return;
            }
            
            this.transform.parent.gameObject.SetActive(value:  false);
            this.inside = false;
            this.HideTooltipVisibility();
        }
        private void Update()
        {
            this.LayoutInit();
            if(this.inside == false)
            {
                    return;
            }
            
            if(this.GUIMode != 1)
            {
                    return;
            }
            
            this.OnScreenSpaceCamera();
        }
        private void LayoutInit()
        {
            if(this.firstUpdate == false)
            {
                    return;
            }
            
            this.firstUpdate = false;
            float val_10 = (float)this.horizontalPadding;
            val_10 = V0.16B + val_10;
            float val_11 = (float)this.verticalPadding;
            val_11 = S0 + val_11;
            CinemachineFreeLook.Orbit val_1 = new CinemachineFreeLook.Orbit(h:  val_10, r:  val_11);
            this.bgImage.sizeDelta = new UnityEngine.Vector2() {x = val_1.m_Height, y = val_1.m_Radius};
            UnityEngine.Vector2 val_2 = this.bgImage.sizeDelta;
            UnityEngine.Vector2 val_3 = this.bgImage.pivot;
            float val_4 = val_2.y * this.currentYScaleFactor;
            val_4 = val_4 * val_3.y;
            this.defaultYOffset = val_4;
            UnityEngine.Vector2 val_5 = this.bgImage.sizeDelta;
            UnityEngine.Vector2 val_6 = this.bgImage.pivot;
            val_6.x = (val_5.x * this.currentXScaleFactor) * val_6.x;
            this.defaultXOffset = val_6.x;
            UnityEngine.Vector2 val_8 = this.bgImage.sizeDelta;
            float val_12 = this.currentYScaleFactor;
            val_12 = val_8.y * val_12;
            this.tooltipRealHeight = val_12;
            UnityEngine.Vector2 val_9 = this.bgImage.sizeDelta;
            val_9.x = val_9.x * this.currentXScaleFactor;
            this.tooltipRealWidth = val_9.x;
            this.ActivateTooltipVisibility();
        }
        private void NewTooltip()
        {
            this.firstUpdate = true;
            UnityEngine.Vector3 val_1 = this.GUICamera.ViewportToScreenPoint(position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            this.lowerLeft = val_1;
            mem[1152921512772794996] = val_1.y;
            mem[1152921512772795000] = val_1.z;
            UnityEngine.Vector3 val_2 = this.GUICamera.ViewportToScreenPoint(position:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            this.upperRight = val_2;
            mem[1152921512772795008] = val_2.y;
            mem[1152921512772795012] = val_2.z;
            UnityEngine.Vector2 val_7 = this.transform.root.GetComponent<UnityEngine.UI.CanvasScaler>().referenceResolution;
            float val_13 = (float)UnityEngine.Screen.height;
            val_13 = val_13 / val_7.y;
            this.currentYScaleFactor = val_13;
            UnityEngine.Vector2 val_12 = this.transform.root.GetComponent<UnityEngine.UI.CanvasScaler>().referenceResolution;
            val_12.x = (float)UnityEngine.Screen.width / val_12.x;
            this.currentXScaleFactor = val_12.x;
        }
        public void ActivateTooltipVisibility()
        {
            UnityEngine.Color val_1 = this.thisText.color;
            this.thisText.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
            UnityEngine.Color val_2 = this.bgImageSource.color;
            UnityEngine.Color val_3 = this.bgImageSource.color;
            UnityEngine.Color val_4 = this.bgImageSource.color;
            this.bgImageSource.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        }
        public void HideTooltipVisibility()
        {
            UnityEngine.Color val_1 = this.thisText.color;
            this.thisText.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
            UnityEngine.Color val_2 = this.bgImageSource.color;
            UnityEngine.Color val_3 = this.bgImageSource.color;
            UnityEngine.Color val_4 = this.bgImageSource.color;
            this.bgImageSource.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        }
    
    }

}
