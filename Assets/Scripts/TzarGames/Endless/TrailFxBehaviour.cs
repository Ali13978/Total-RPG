using UnityEngine;

namespace TzarGames.Endless
{
    public class TrailFxBehaviour : MonoBehaviour, IPoolable
    {
        // Fields
        [UnityEngine.SerializeField]
        private XftWeapon.XWeaponTrail trail;
        private UnityEngine.Color defaultColor;
        
        // Methods
        public TrailFxBehaviour()
        {
        
        }
        private void Awake()
        {
            this.defaultColor = this.trail.MyColor;
        }
        private void Start()
        {
            this.trail.Init();
            this.trail.Deactivate();
        }
        public void SetColor(UnityEngine.Color color)
        {
            this.trail.MyColor = color;
            mem2[0] = color.g;
            mem2[0] = color.b;
            mem2[0] = color.a;
        }
        public void ResetColor()
        {
            this.trail.MyColor = this.defaultColor;
        }
        public void Activate()
        {
            UnityEngine.Camera val_5;
            UnityEngine.Camera val_6;
            this.trail.Activate();
            if(this.trail != null)
            {
                    val_5 = this.trail.MyCamera;
            }
            else
            {
                    val_5 = 0.MyCamera;
            }
            
            this.trail.MyPreRender(cam:  val_5);
            if(this.trail != null)
            {
                    val_6 = this.trail.MyCamera;
            }
            else
            {
                    val_6 = 0.MyCamera;
            }
            
            this.trail.MyPostRender(cam:  val_6);
        }
        public void Deactivate()
        {
            this.trail.Deactivate();
        }
        public void DeactivateSmoothly()
        {
            this.trail.StopSmoothly(fadeTime:  0.1f);
        }
        private void Reset()
        {
            this.trail = this.GetComponentInChildren<XftWeapon.XWeaponTrail>();
        }
        public void OnPushedToPool()
        {
            this.trail.MyColor = this.defaultColor;
            this.trail.Deactivate();
        }
        public void OnPulledFromPool()
        {
        
        }
    
    }

}
