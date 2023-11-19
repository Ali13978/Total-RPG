using UnityEngine;

namespace Unitycoding.UIWidgets
{
    [UnityEngine.RequireComponent]
    public class UICursor : MonoBehaviour
    {
        // Fields
        private static Unitycoding.UIWidgets.UICursor instance;
        private UnityEngine.RectTransform rectTransform;
        private UnityEngine.UI.Image image;
        private UnityEngine.CanvasGroup canvasGroup;
        private UnityEngine.Canvas canvas;
        
        // Methods
        public UICursor()
        {
        
        }
        private void Awake()
        {
            Unitycoding.UIWidgets.UICursor.instance = this;
        }
        private void OnDestroy()
        {
            Unitycoding.UIWidgets.UICursor.instance = 0;
        }
        private void Start()
        {
            this.rectTransform = this.GetComponent<UnityEngine.RectTransform>();
            this.image = this.GetComponent<UnityEngine.UI.Image>();
            this.canvas = this.GetComponentInParent<UnityEngine.Canvas>();
            UnityEngine.CanvasGroup val_4 = this.GetComponent<UnityEngine.CanvasGroup>();
            this.canvasGroup = val_4;
            val_4.alpha = 0f;
            this.canvasGroup.blocksRaycasts = false;
            this.canvasGroup.interactable = false;
        }
        private void Update()
        {
            var val_12;
            UnityEngine.Camera val_13;
            val_12 = this;
            if(alpha <= 0f)
            {
                    return;
            }
            
            UnityEngine.Transform val_2 = this.canvas.transform;
            UnityEngine.Vector3 val_3 = UnityEngine.Input.mousePosition;
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            UnityEngine.Camera val_5 = this.canvas.worldCamera;
            if(val_2 != null)
            {
                    var val_6 = (null == null) ? (val_2) : 0;
            }
            else
            {
                    val_13 = 0;
            }
            
            bool val_7 = UnityEngine.RectTransformUtility.ScreenPointToLocalPointInRectangle(rect:  0, screenPoint:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y}, cam:  val_13, localPoint: out  new UnityEngine.Vector2() {x = val_5, y = val_5});
            val_12 = val_5.transform;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = 0f, y = 0f});
            UnityEngine.Vector3 val_11 = this.canvas.transform.TransformPoint(position:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
            val_12.position = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
        }
        public static void Clear()
        {
            Unitycoding.UIWidgets.UICursor.Set(sprite:  0);
        }
        public static void Set(UnityEngine.Sprite sprite)
        {
            UnityEngine.CanvasGroup val_4;
            if(0 == Unitycoding.UIWidgets.UICursor.instance)
            {
                    return;
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  0)) == false)
            {
                    return;
            }
            
            if(0 != X1)
            {
                    SetAsLastSibling();
                sprite = X1;
                val_4 = mem[Unitycoding.UIWidgets.UICursor.instance + 40];
                val_4 = Unitycoding.UIWidgets.UICursor.instance.canvasGroup;
                if(null != 0)
            {
                goto label_17;
            }
            
            }
            else
            {
                    val_4 = mem[Unitycoding.UIWidgets.UICursor.instance + 40];
                val_4 = Unitycoding.UIWidgets.UICursor.instance.canvasGroup;
            }
            
            label_17:
            alpha = 0f;
        }
    
    }

}
