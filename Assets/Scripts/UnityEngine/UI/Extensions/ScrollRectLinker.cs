using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    [UnityEngine.RequireComponent]
    [UnityEngine.AddComponentMenu]
    public class ScrollRectLinker : MonoBehaviour
    {
        // Fields
        public bool clamp;
        [UnityEngine.SerializeField]
        private UnityEngine.UI.ScrollRect controllingScrollRect;
        private UnityEngine.UI.ScrollRect scrollRect;
        
        // Methods
        public ScrollRectLinker()
        {
            this.clamp = true;
        }
        private void Awake()
        {
            this.scrollRect = this.GetComponent<UnityEngine.UI.ScrollRect>();
            if(0 == this.controllingScrollRect)
            {
                    return;
            }
            
            this.controllingScrollRect.onValueChanged.AddListener(call:  new UnityEngine.Events.UnityAction<UnityEngine.Vector2>(object:  this, method:  System.Void UnityEngine.UI.Extensions.ScrollRectLinker::MirrorPos(UnityEngine.Vector2 scrollPos)));
        }
        private void MirrorPos(UnityEngine.Vector2 scrollPos)
        {
            if(this.clamp != false)
            {
                    CinemachineFreeLook.Orbit val_3 = new CinemachineFreeLook.Orbit(h:  UnityEngine.Mathf.Clamp01(value:  scrollPos.x), r:  UnityEngine.Mathf.Clamp01(value:  scrollPos.y));
                this.scrollRect.normalizedPosition = new UnityEngine.Vector2() {x = val_3.m_Height, y = val_3.m_Radius};
                return;
            }
            
            this.scrollRect.normalizedPosition = new UnityEngine.Vector2() {x = scrollPos.x, y = scrollPos.y};
        }
    
    }

}
