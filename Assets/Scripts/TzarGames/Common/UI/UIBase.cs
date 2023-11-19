using UnityEngine;

namespace TzarGames.Common.UI
{
    public class UIBase : MonoBehaviour
    {
        // Fields
        private readonly int animatorParam;
        [UnityEngine.SerializeField]
        private bool visibleAtStart;
        [UnityEngine.SerializeField]
        private UnityEngine.Animator animator;
        [UnityEngine.SerializeField]
        private UnityEngine.CanvasGroup canvasGroup;
        [UnityEngine.SerializeField]
        private UnityEngine.Events.UnityEvent _onVisible;
        [UnityEngine.SerializeField]
        private UnityEngine.Events.UnityEvent _onHidden;
        private TzarGames.Common.UI.UIBaseStateBehaviour[] stateBehaviours;
        private UnityEngine.Coroutine stateExitCoroutine;
        private bool visibilityInitialized;
        private System.Nullable<bool> animVisibilityState;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private bool <IsVisible>k__BackingField;
        
        // Properties
        public bool IsVisible { get; set; }
        
        // Methods
        public UIBase()
        {
            this.visibleAtStart = true;
            this.animatorParam = UnityEngine.Animator.StringToHash(name:  0);
        }
        public bool get_IsVisible()
        {
            return (bool)this.<IsVisible>k__BackingField;
        }
        private void set_IsVisible(bool value)
        {
            this.<IsVisible>k__BackingField = value;
        }
        public void ToogleVisibility()
        {
            var val_1 = ((this.<IsVisible>k__BackingField) == false) ? 1 : 0;
            goto typeof(TzarGames.Common.UI.UIBase).__il2cppRuntimeField_160;
        }
        private void Reset()
        {
            this.animator = this.GetComponent<UnityEngine.Animator>();
            this.canvasGroup = this.GetComponent<UnityEngine.CanvasGroup>();
        }
        protected virtual void Start()
        {
            var val_3;
            T[] val_1 = this.animator.GetBehaviours<TzarGames.Common.UI.UIBaseStateBehaviour>();
            this.stateBehaviours = val_1;
            val_3 = 0;
            goto label_2;
            label_7:
            X21.add_OnEnteredToState(value:  X22);
            val_3 = 1;
            label_2:
            if(val_3 >= val_1.Length)
            {
                goto label_4;
            }
            
            null = new System.Action<System.Boolean>(object:  this, method:  System.Void TzarGames.Common.UI.UIBase::OnDisableAnimatorEvent(bool state));
            if(val_1[1] != 0)
            {
                goto label_7;
            }
            
            goto label_7;
            label_4:
            if(this.visibilityInitialized != false)
            {
                    return;
            }
            
            this.visibilityInitialized = true;
            goto typeof(TzarGames.Common.UI.UIBase).__il2cppRuntimeField_160;
        }
        private void OnDestroy()
        {
            TzarGames.Common.UI.UIBaseStateBehaviour[] val_4;
            var val_5;
            val_4 = this.stateBehaviours;
            if(val_4 == null)
            {
                    return;
            }
            
            val_5 = 0;
            goto label_2;
            label_11:
            val_4 = this.stateBehaviours;
            val_5 = 1;
            label_2:
            if(val_5 >= this.stateBehaviours.Length)
            {
                    return;
            }
            
            TzarGames.Common.UI.UIBaseStateBehaviour val_4 = this.stateBehaviours[1];
            if(0 == val_4)
            {
                goto label_11;
            }
            
            val_4.remove_OnEnteredToState(value:  new System.Action<System.Boolean>(object:  this, method:  System.Void TzarGames.Common.UI.UIBase::OnDisableAnimatorEvent(bool state)));
            goto label_11;
        }
        private void OnDisableAnimatorEvent(bool state)
        {
            state = state;
            this.animVisibilityState = 0;
            if(this.stateExitCoroutine != null)
            {
                    this.StopCoroutine(routine:  this.stateExitCoroutine);
            }
            
            this.stateExitCoroutine = this.StartCoroutine(routine:  this.stateExit());
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator stateExit()
        {
            typeof(UIBase.<stateExit>c__Iterator0).__il2cppRuntimeField_10 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        private void setAnimatorVisibility(bool visible)
        {
            UnityEngine.Animator val_14;
            var val_15;
            val_14 = this.animator;
            if(0 == val_14)
            {
                    return;
            }
            
            val_14 = 1152921509353867984;
            if(((-1967681522) & 1) != 0)
            {
                    if(1152921511229100044 ^ visible != true)
            {
                    if((0 & 1) != 0)
            {
                    return;
            }
            
            }
            
            }
            
            this.animVisibilityState = 0;
            if(this.animator.enabled != true)
            {
                    this.animator.enabled = true;
            }
            
            if(this.stateExitCoroutine != null)
            {
                    this.StopCoroutine(routine:  this.stateExitCoroutine);
                this.stateExitCoroutine = 0;
            }
            
            val_14 = this.animator;
            if(val_14.enabled == false)
            {
                    return;
            }
            
            val_14 = this.animator.gameObject;
            if(val_14.activeInHierarchy == false)
            {
                    return;
            }
            
            val_14 = this.animator.parameters;
            val_15 = 0;
            goto label_17;
            label_24:
            val_15 = 1;
            label_17:
            if(val_15 >= val_10.Length)
            {
                    return;
            }
            
            UnityEngine.AnimatorControllerParameter val_14 = val_14[1];
            if((val_14.nameHash != this.animatorParam) || (val_14.type != 4))
            {
                goto label_24;
            }
            
            val_14 = this.animator;
            val_14.SetBool(id:  this.animatorParam, value:  visible);
        }
        private void OnEnable()
        {
            if(0 == this.animator)
            {
                    return;
            }
            
            if((0 & 1) != 0)
            {
                    return;
            }
            
            this.animator.enabled = true;
            var val_3 = ((this.<IsVisible>k__BackingField) == true) ? 1 : 0;
            val_3 = (this.animator.GetBool(id:  this.animatorParam)) ^ val_3;
            if(val_3 == false)
            {
                    return;
            }
            
            this.setAnimatorVisibility(visible:  ((this.<IsVisible>k__BackingField) == true) ? 1 : 0);
        }
        public virtual void SetVisible(bool visible)
        {
            UnityEngine.CanvasGroup val_3;
            UnityEngine.Object val_4;
            UnityEngine.Events.UnityEvent val_5;
            visible = visible;
            this.<IsVisible>k__BackingField = visible;
            if(this.visibilityInitialized != true)
            {
                    this.visibilityInitialized = true;
            }
            
            this.setAnimatorVisibility(visible:  visible);
            val_3 = this.canvasGroup;
            val_4 = val_3;
            if(0 != val_4)
            {
                    val_3 = this.canvasGroup;
                val_4 = visible;
                val_3.interactable = val_4;
            }
            
            if(visible == false)
            {
                goto label_6;
            }
            
            val_5 = this._onVisible;
            if(val_5 != null)
            {
                goto label_9;
            }
            
            goto label_8;
            label_6:
            val_5 = this._onHidden;
            if(val_5 != null)
            {
                goto label_9;
            }
            
            label_8:
            label_9:
            val_5.Invoke();
        }
        protected virtual void OnVisible()
        {
        
        }
        protected virtual void OnHidden()
        {
        
        }
    
    }

}
