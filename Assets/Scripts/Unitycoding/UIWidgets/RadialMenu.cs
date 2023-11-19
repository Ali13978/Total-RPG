using UnityEngine;

namespace Unitycoding.UIWidgets
{
    public class RadialMenu : UIWidget
    {
        // Fields
        [UnityEngine.SerializeField]
        private float m_Radius;
        [UnityEngine.SerializeField]
        private float m_Angle;
        [UnityEngine.HeaderAttribute]
        [UnityEngine.SerializeField]
        private Unitycoding.UIWidgets.RadialMenuItem m_Item;
        private System.Collections.Generic.List<Unitycoding.UIWidgets.RadialMenuItem> itemCache;
        private static System.Predicate<Unitycoding.UIWidgets.RadialMenuItem> <>f__am$cache0;
        
        // Methods
        public RadialMenu()
        {
            this.m_Radius = 100f;
            this.m_Angle = 360f;
            this.itemCache = new System.Collections.Generic.List<Unitycoding.UIWidgets.RadialMenuItem>();
        }
        private void Update()
        {
            string val_16;
            if(alpha <= 0f)
            {
                    return;
            }
            
            if((UnityEngine.Input.GetMouseButtonUp(button:  0)) != true)
            {
                    if((UnityEngine.Input.GetMouseButtonUp(button:  0)) != true)
            {
                    if((UnityEngine.Input.GetMouseButtonUp(button:  0)) == false)
            {
                    return;
            }
            
            }
            
            }
            
            UnityEngine.Vector3 val_9 = UnityEngine.Input.mousePosition;
            UnityEngine.Vector2 val_10 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
            position = new UnityEngine.Vector2() {x = val_10.x, y = val_10.y};
            UnityEngine.EventSystems.EventSystem.current.RaycastAll(eventData:  new UnityEngine.EventSystems.PointerEventData(eventSystem:  UnityEngine.EventSystems.EventSystem.current), raycastResults:  new System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult>());
            val_16 = public System.Int32 System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult>::get_Count();
            if(Count < 1)
            {
                    return;
            }
            
            UnityEngine.EventSystems.RaycastResult val_14 = Item[0];
            val_16 = "Press";
            InitializationCallback.SendMessage(methodName:  val_16, options:  1);
        }
        public virtual void Show(UnityEngine.Sprite[] icons, UnityEngine.Events.UnityAction<int> result)
        {
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            object val_1 = new System.Object();
            if(null != 0)
            {
                    typeof(RadialMenu.<Show>c__AnonStorey0).__il2cppRuntimeField_10 = result;
            }
            else
            {
                    mem[16] = result;
            }
            
            typeof(RadialMenu.<Show>c__AnonStorey0).__il2cppRuntimeField_18 = this;
            val_11 = 0;
            goto label_3;
            label_9:
            X23.SetActive(value:  false);
            val_11 = 1;
            label_3:
            if(val_11 >= this.itemCache.Count)
            {
                goto label_5;
            }
            
            if(this.itemCache.Item[1].gameObject != null)
            {
                goto label_9;
            }
            
            goto label_9;
            label_5:
            val_12 = 0;
            goto label_10;
            label_25:
            this.itemCache.AddListener(call:  1152921512632170720);
            val_12 = 1;
            label_10:
            if(val_12 >= icons.Length)
            {
                    return;
            }
            
            object val_5 = new System.Object();
            if(null != 0)
            {
                    val_13 = val_5;
                typeof(RadialMenu.<Show>c__AnonStorey1).__il2cppRuntimeField_18 = val_1;
                typeof(RadialMenu.<Show>c__AnonStorey1).__il2cppRuntimeField_10 = val_12;
                val_14 = val_12;
            }
            else
            {
                    mem[24] = val_1;
                mem[16] = val_12;
                val_14 = mem[16];
                val_13 = 16;
            }
            
            Unitycoding.UIWidgets.RadialMenuItem val_6 = this.AddRadialMenuItem(icon:  icons[1]);
            float val_13 = this.m_Angle;
            float val_12 = (float)icons.Length;
            val_12 = val_13 / val_12;
            val_12 = val_12 * 0.01745329f;
            val_13 = 1f * val_12;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, d:  this.m_Radius);
            val_6.transform.localPosition = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
            UnityEngine.Events.UnityAction val_10 = new UnityEngine.Events.UnityAction(object:  val_5, method:  System.Void RadialMenu.<Show>c__AnonStorey1::<>m__0());
            if(val_6.onTrigger != null)
            {
                goto label_25;
            }
            
            goto label_25;
        }
        public override void Show()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Input.mousePosition;
            position = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
            this.Show();
        }
        private Unitycoding.UIWidgets.RadialMenuItem AddRadialMenuItem(UnityEngine.Sprite icon)
        {
            var val_12;
            var val_13;
            UnityEngine.Object val_14;
            var val_15;
            val_12 = null;
            if((Unitycoding.UIWidgets.RadialMenu.<>f__am$cache0) == null)
            {
                    Unitycoding.UIWidgets.RadialMenu.<>f__am$cache0 = new System.Predicate<Unitycoding.UIWidgets.RadialMenuItem>(object:  0, method:  static System.Boolean Unitycoding.UIWidgets.RadialMenu::<AddRadialMenuItem>m__0(Unitycoding.UIWidgets.RadialMenuItem x));
                val_12 = null;
            }
            
            val_13 = 1152921504721543168;
            val_14 = this.itemCache.Find(match:  Unitycoding.UIWidgets.RadialMenu.<>f__am$cache0);
            if(0 == val_14)
            {
                    val_14 = UnityEngine.Object.Instantiate<Unitycoding.UIWidgets.RadialMenuItem>(original:  0);
                this.itemCache.Add(item:  val_14);
            }
            
            if((0 != val_14.targetGraphic) && (val_14.targetGraphic != null))
            {
                    val_13 = 1152921504782192640;
                UnityEngine.UI.Graphic val_8 = val_14.targetGraphic;
                if(val_8 != null)
            {
                    val_15 = null;
                val_15 = null;
                val_8 = (((UnityEngine.UI.Graphic.__il2cppRuntimeField_typeHierarchy + (UnityEngine.UI.Image.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_15) ? (val_8) : 0;
            }
            
                0.sprite = icon;
            }
            
            val_14.onTrigger.RemoveAllListeners();
            val_14.gameObject.SetActive(value:  true);
            val_14.transform.SetParent(parent:  this, worldPositionStays:  false);
            return val_14;
        }
        private static bool <AddRadialMenuItem>m__0(Unitycoding.UIWidgets.RadialMenuItem x)
        {
            bool val_1 = X1.isActiveAndEnabled;
            val_1 = (~val_1) & 1;
            return (bool)val_1;
        }
    
    }

}
