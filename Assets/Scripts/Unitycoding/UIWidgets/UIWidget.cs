using UnityEngine;

namespace Unitycoding.UIWidgets
{
    [UnityEngine.RequireComponent]
    public class UIWidget : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private string name;
        [UnityEngine.HeaderAttribute]
        [UnityEngine.SerializeField]
        private bool focus;
        [UnityEngine.SerializeField]
        private Unitycoding.UIWidgets.EasingEquations.EaseType easeType;
        [UnityEngine.SerializeField]
        private float duration;
        public UnityEngine.AudioClip showSound;
        public UnityEngine.AudioClip closeSound;
        [UnityEngine.SerializeField]
        protected bool deactivateOnClose;
        [UnityEngine.SerializeField]
        private System.Collections.Generic.List<Unitycoding.UIWidgets.UIWidget.Entry> m_Delegates;
        [UnityEngine.HideInInspector]
        public Unitycoding.UIWidgets.UIWidget.WidgetEvent onShow;
        [UnityEngine.HideInInspector]
        public Unitycoding.UIWidgets.UIWidget.WidgetEvent onClose;
        [UnityEngine.HideInInspector]
        public Unitycoding.UIWidgets.UIWidget.WidgetEvent onShowFinished;
        [UnityEngine.HideInInspector]
        public Unitycoding.UIWidgets.UIWidget.WidgetEvent onCloseFinished;
        protected UnityEngine.RectTransform rectTransform;
        protected UnityEngine.CanvasGroup canvasGroup;
        private Unitycoding.UIWidgets.TweenRunner<Unitycoding.UIWidgets.FloatTween> m_AlphaTweenRunner;
        private Unitycoding.UIWidgets.TweenRunner<Unitycoding.UIWidgets.Vector3Tween> m_ScaleTweenRunner;
        private Unitycoding.UIWidgets.FloatTween alphaTween;
        private bool deactivate;
        private Unitycoding.UIWidgets.Vector3Tween scaleTween;
        
        // Properties
        public string Name { get; set; }
        public System.Collections.Generic.List<Unitycoding.UIWidgets.UIWidget.Entry> triggers { get; set; }
        public bool IsVisible { get; }
        
        // Methods
        public UIWidget()
        {
            this.focus = true;
            this.deactivateOnClose = true;
            this.duration = 1f;
            this.m_Delegates = new System.Collections.Generic.List<Entry>();
        }
        public string get_Name()
        {
            return (string)this.name;
        }
        public void set_Name(string value)
        {
            this.name = value;
        }
        public System.Collections.Generic.List<Unitycoding.UIWidgets.UIWidget.Entry> get_triggers()
        {
            System.Collections.Generic.List<Entry> val_2 = this.m_Delegates;
            if(val_2 != null)
            {
                    return val_2;
            }
            
            System.Collections.Generic.List<Entry> val_1 = null;
            val_2 = val_1;
            val_1 = new System.Collections.Generic.List<Entry>();
            this.m_Delegates = val_2;
            return val_2;
        }
        public void set_triggers(System.Collections.Generic.List<Unitycoding.UIWidgets.UIWidget.Entry> value)
        {
            this.m_Delegates = value;
        }
        public bool get_IsVisible()
        {
            return (bool)(this.canvasGroup.alpha == 1f) ? 1 : 0;
        }
        private void Awake()
        {
            Unitycoding.UIWidgets.TweenRunner<Unitycoding.UIWidgets.FloatTween> val_12;
            Unitycoding.UIWidgets.TweenRunner<Unitycoding.UIWidgets.Vector3Tween> val_13;
            this.rectTransform = this.GetComponent<UnityEngine.RectTransform>();
            this.canvasGroup = this.GetComponent<UnityEngine.CanvasGroup>();
            if(this.IsVisible != true)
            {
                    UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
                this.rectTransform.localScale = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            }
            
            val_12 = this.m_AlphaTweenRunner;
            if(val_12 == null)
            {
                    Unitycoding.UIWidgets.TweenRunner<Unitycoding.UIWidgets.FloatTween> val_6 = null;
                val_12 = val_6;
                val_6 = new Unitycoding.UIWidgets.TweenRunner<Unitycoding.UIWidgets.FloatTween>();
                this.m_AlphaTweenRunner = val_12;
                if(null == 0)
            {
                    val_12 = 0;
            }
            
            }
            
            val_12.Init(coroutineContainer:  this);
            val_13 = this.m_ScaleTweenRunner;
            if(val_13 == null)
            {
                    Unitycoding.UIWidgets.TweenRunner<Unitycoding.UIWidgets.Vector3Tween> val_7 = null;
                val_13 = val_7;
                val_7 = new Unitycoding.UIWidgets.TweenRunner<Unitycoding.UIWidgets.Vector3Tween>();
                this.m_ScaleTweenRunner = val_13;
                if(null == 0)
            {
                    val_13 = 0;
            }
            
            }
            
            val_13.Init(coroutineContainer:  this);
            this.onShow.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void Unitycoding.UIWidgets.UIWidget::<Awake>m__0()));
            this.onClose.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void Unitycoding.UIWidgets.UIWidget::<Awake>m__1()));
            this.onCloseFinished.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void Unitycoding.UIWidgets.UIWidget::<Awake>m__2()));
            this.onShowFinished.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void Unitycoding.UIWidgets.UIWidget::<Awake>m__3()));
            goto typeof(Unitycoding.UIWidgets.UIWidget).__il2cppRuntimeField_150;
        }
        protected virtual void OnAwake()
        {
        
        }
        private void Start()
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.OnDelayedStart());
        }
        protected virtual void OnStart()
        {
        
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator OnDelayedStart()
        {
            typeof(UIWidget.<OnDelayedStart>c__Iterator0).__il2cppRuntimeField_10 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        public virtual void Show()
        {
            this.deactivate = false;
            this.gameObject.SetActive(value:  true);
            this.TweenCanvasGroupAlpha(startValue:  this.canvasGroup.alpha, targetValue:  1f);
            UnityEngine.Vector3 val_3 = this.rectTransform.localScale;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.ClampMagnitude(vector:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, maxLength:  1.9f);
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.one;
            this.TweenTransformScale(startValue:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, targetValue:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            Unitycoding.UIWidgets.UIUtility.PlaySound(clip:  null, volume:  1f);
            this.canvasGroup.interactable = true;
            this.canvasGroup.blocksRaycasts = true;
            if(this.onShow == null)
            {
                    return;
            }
            
            if(this.canvasGroup.alpha >= 0)
            {
                    return;
            }
            
            this.onShow.Invoke();
        }
        public virtual void Close()
        {
            this.deactivate = true;
            this.TweenCanvasGroupAlpha(startValue:  this.canvasGroup.alpha, targetValue:  0f);
            UnityEngine.Vector3 val_2 = this.rectTransform.localScale;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            this.TweenTransformScale(startValue:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, targetValue:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            Unitycoding.UIWidgets.UIUtility.PlaySound(clip:  null, volume:  1f);
            this.canvasGroup.interactable = false;
            this.canvasGroup.blocksRaycasts = false;
            if(this.onClose == null)
            {
                    return;
            }
            
            if(this.canvasGroup.alpha <= 0f)
            {
                    return;
            }
            
            this.onClose.Invoke();
        }
        private void TweenCanvasGroupAlpha(float startValue, float targetValue)
        {
            if(this.alphaTween != 0)
            {
                    mem[1152921512657382564] = startValue;
                mem[1152921512657382568] = targetValue;
            }
            else
            {
                    this.alphaTween = 0;
                mem[1152921512657382560] = this.easeType;
                mem[1152921512657382572] = this.duration;
                mem[1152921512657382564] = startValue;
                mem[1152921512657382568] = targetValue;
                mem[1152921512657382576] = 0;
                UnityEngine.Events.UnityAction<System.Single> val_1 = new UnityEngine.Events.UnityAction<System.Single>(object:  this, method:  System.Void Unitycoding.UIWidgets.UIWidget::<TweenCanvasGroupAlpha>m__4(float value));
                UnityEngine.Events.UnityAction val_2 = new UnityEngine.Events.UnityAction(object:  this, method:  System.Void Unitycoding.UIWidgets.UIWidget::<TweenCanvasGroupAlpha>m__5());
            }
            
            this.m_AlphaTweenRunner.StartTween(info:  new Unitycoding.UIWidgets.FloatTween() {m_EaseType = mem[1152921512657382560], m_StartValue = mem[1152921512657382560], m_TargetValue = mem[1152921512657382560], m_Duration = 0f, m_IgnoreTimeScale = false});
        }
        private void TweenTransformScale(UnityEngine.Vector3 startValue, UnityEngine.Vector3 targetValue)
        {
            if(this.scaleTween != 0)
            {
                    mem[1152921512657515092] = startValue.x;
                mem[1152921512657515096] = startValue.y;
                mem[1152921512657515100] = startValue.z;
                mem[1152921512657515104] = targetValue.x;
                mem[1152921512657515108] = targetValue.y;
                mem[1152921512657515112] = targetValue.z;
            }
            else
            {
                    this.scaleTween = 0;
                mem[1152921512657515088] = this.easeType;
                mem[1152921512657515116] = this.duration;
                mem[1152921512657515092] = startValue.x;
                mem[1152921512657515096] = startValue.y;
                mem[1152921512657515100] = startValue.z;
                mem[1152921512657515104] = targetValue.x;
                mem[1152921512657515108] = targetValue.y;
                mem[1152921512657515112] = targetValue.z;
                mem[1152921512657515120] = 0;
                UnityEngine.Events.UnityAction<UnityEngine.Vector3> val_1 = new UnityEngine.Events.UnityAction<UnityEngine.Vector3>(object:  this, method:  System.Void Unitycoding.UIWidgets.UIWidget::<TweenTransformScale>m__6(UnityEngine.Vector3 value));
            }
            
            this.m_ScaleTweenRunner.StartTween(info:  new Unitycoding.UIWidgets.Vector3Tween() {m_EaseType = mem[1152921512657515088], m_StartValue = new UnityEngine.Vector3() {x = mem[1152921512657515088], y = mem[1152921512657515088], z = mem[1152921512657515104]}, m_TargetValue = new UnityEngine.Vector3(), m_Duration = 0f, m_IgnoreTimeScale = false});
        }
        public virtual void Toggle()
        {
            if(this.IsVisible != false)
            {
                
            }
        
        }
        public virtual void Focus()
        {
            this.rectTransform.SetAsLastSibling();
        }
        private void Execute(Unitycoding.UIWidgets.UIWidget.TriggerType id)
        {
            int val_2 = this.triggers.Count;
            if(val_2 < 1)
            {
                    return;
            }
            
            var val_5 = 0;
            do
            {
                Entry val_4 = this.triggers.Item[0];
                if((val_4.eventID == id) && (val_4.callback != null))
            {
                    val_4.callback.Invoke();
            }
            
                val_5 = val_5 + 1;
            }
            while(val_2 != val_5);
        
        }
        private void <Awake>m__0()
        {
            this.Execute(id:  0);
        }
        private void <Awake>m__1()
        {
            this.Execute(id:  1);
        }
        private void <Awake>m__2()
        {
            this.Execute(id:  3);
        }
        private void <Awake>m__3()
        {
            this.Execute(id:  2);
        }
        private void <TweenCanvasGroupAlpha>m__4(float value)
        {
            this.canvasGroup.alpha = value;
        }
        private void <TweenCanvasGroupAlpha>m__5()
        {
            if(S0 > S1)
            {
                    this.onCloseFinished.Invoke();
                if(this.deactivateOnClose == false)
            {
                    return;
            }
            
                if(this.deactivate == false)
            {
                    return;
            }
            
                this.gameObject.SetActive(value:  false);
                return;
            }
            
            this.onShowFinished.Invoke();
        }
        private void <TweenTransformScale>m__6(UnityEngine.Vector3 value)
        {
            this.rectTransform.localScale = new UnityEngine.Vector3() {x = value.x, y = value.y, z = value.z};
        }
    
    }

}
