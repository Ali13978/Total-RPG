using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    [UnityEngine.RequireComponent]
    [UnityEngine.AddComponentMenu]
    public class Accordion : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.UI.Extensions.Accordion.Transition m_Transition;
        [UnityEngine.SerializeField]
        private float m_TransitionDuration;
        
        // Properties
        public UnityEngine.UI.Extensions.Accordion.Transition transition { get; set; }
        public float transitionDuration { get; set; }
        
        // Methods
        public Accordion()
        {
            this.m_TransitionDuration = 0.3f;
        }
        public UnityEngine.UI.Extensions.Accordion.Transition get_transition()
        {
            return (Transition)this.m_Transition;
        }
        public void set_transition(UnityEngine.UI.Extensions.Accordion.Transition value)
        {
            this.m_Transition = value;
        }
        public float get_transitionDuration()
        {
            return (float)this.m_TransitionDuration;
        }
        public void set_transitionDuration(float value)
        {
            this.m_TransitionDuration = value;
        }
    
    }

}
