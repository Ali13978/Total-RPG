using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    [UnityEngine.RequireComponent]
    [UnityEngine.AddComponentMenu]
    public class AccordionElement : Toggle
    {
        // Fields
        [UnityEngine.SerializeField]
        private float m_MinHeight;
        private UnityEngine.UI.Extensions.Accordion m_Accordion;
        private UnityEngine.RectTransform m_RectTransform;
        private UnityEngine.UI.LayoutElement m_LayoutElement;
        private readonly UnityEngine.UI.Extensions.Tweens.TweenRunner<UnityEngine.UI.Extensions.Tweens.FloatTween> m_FloatTweenRunner;
        
        // Methods
        protected AccordionElement()
        {
            UnityEngine.UI.Extensions.Tweens.TweenRunner<UnityEngine.UI.Extensions.Tweens.FloatTween> val_2;
            this.m_MinHeight = 18f;
            val_2 = this.m_FloatTweenRunner;
            if(val_2 == null)
            {
                    UnityEngine.UI.Extensions.Tweens.TweenRunner<UnityEngine.UI.Extensions.Tweens.FloatTween> val_1 = null;
                val_2 = val_1;
                val_1 = new UnityEngine.UI.Extensions.Tweens.TweenRunner<UnityEngine.UI.Extensions.Tweens.FloatTween>();
                this.m_FloatTweenRunner = val_2;
                if(null == 0)
            {
                    val_2 = 0;
            }
            
            }
            
            val_2.Init(coroutineContainer:  this);
        }
        protected override void Awake()
        {
            var val_8;
            this.Awake();
            this.transition = 0;
            mem[1152921512663512520] = 0;
            this.m_Accordion = this.gameObject.GetComponentInParent<UnityEngine.UI.Extensions.Accordion>();
            val_8 = 0;
            this.m_RectTransform = (null == null) ? this.transform : 0;
            UnityEngine.GameObject val_5 = this.gameObject;
            this.m_LayoutElement = val_5.GetComponent<UnityEngine.UI.LayoutElement>();
            val_5.AddListener(call:  new UnityEngine.Events.UnityAction<System.Boolean>(object:  this, method:  public System.Void UnityEngine.UI.Extensions.AccordionElement::OnValueChanged(bool state)));
        }
        public void OnValueChanged(bool state)
        {
            UnityEngine.UI.LayoutElement val_6;
            float val_7;
            val_6 = this.m_LayoutElement;
            if(0 == val_6)
            {
                    return;
            }
            
            if(0 == this.m_Accordion)
            {
                goto label_6;
            }
            
            val_6 = this.m_Accordion;
            if(this.m_Accordion.m_Transition == 1)
            {
                goto label_8;
            }
            
            if(this.m_Accordion.m_Transition != 0)
            {
                    return;
            }
            
            label_6:
            val_6 = this.m_LayoutElement;
            if(state != false)
            {
                    if(val_6 != null)
            {
                    return;
            }
            
                return;
            }
            
            val_7 = this.m_MinHeight;
            if(val_6 != null)
            {
                    return;
            }
            
            return;
            label_8:
            if(state != false)
            {
                    val_7 = this.m_MinHeight;
                float val_4 = this.GetExpandedHeight();
            }
            else
            {
                    UnityEngine.Rect val_5 = this.m_RectTransform.rect;
            }
            
            this.StartTween(startFloat:  val_5.m_XMin, targetFloat:  this.m_MinHeight);
        }
        protected float GetExpandedHeight()
        {
            UnityEngine.UI.LayoutElement val_3;
            float val_4;
            val_3 = this;
            if(0 == this.m_LayoutElement)
            {
                    val_4 = this.m_MinHeight;
                return (float)val_4;
            }
            
            val_3 = this.m_LayoutElement;
            val_4 = UnityEngine.UI.LayoutUtility.GetPreferredHeight(rect:  0);
            return (float)val_4;
        }
        protected void StartTween(float startFloat, float targetFloat)
        {
            if(0 != this.m_Accordion)
            {
                    if(this.m_Accordion != null)
            {
                goto label_5;
            }
            
            }
            
            label_5:
            0.startFloat = startFloat;
            UnityEngine.Events.UnityAction<System.Single> val_2 = new UnityEngine.Events.UnityAction<System.Single>(object:  this, method:  System.Void UnityEngine.UI.Extensions.AccordionElement::SetHeight(float height));
            this.m_FloatTweenRunner.StartTween(info:  new UnityEngine.UI.Extensions.Tweens.FloatTween() {m_StartFloat = 0f, m_TargetFloat = 0f, m_Duration = 0f, m_IgnoreTimeScale = false});
        }
        protected void SetHeight(float height)
        {
            if(0 == this.m_LayoutElement)
            {
                    return;
            }
            
            if(this.m_LayoutElement == null)
            {
                
            }
        
        }
    
    }

}
