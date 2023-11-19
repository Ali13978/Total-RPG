using UnityEngine;

namespace LlockhamIndustries.Decals
{
    [UnityEngine.RequireComponent]
    public class SheetAnimator : MonoBehaviour
    {
        // Fields
        [UnityEngine.HeaderAttribute]
        [UnityEngine.TooltipAttribute]
        public int collumns;
        [UnityEngine.TooltipAttribute]
        public int rows;
        [UnityEngine.TooltipAttribute]
        public float speed;
        [UnityEngine.HeaderAttribute]
        [UnityEngine.TooltipAttribute]
        public int skipFirst;
        [UnityEngine.TooltipAttribute]
        public int skipLast;
        [UnityEngine.TooltipAttribute]
        public bool invertY;
        [UnityEngine.TooltipAttribute]
        public bool destroyOnComplete;
        private LlockhamIndustries.Decals.ProjectionRenderer projection;
        private float time;
        private bool paused;
        
        // Methods
        public SheetAnimator()
        {
            this.collumns = 4294967297;
            this.rows = 1;
            this.speed = 30f;
        }
        private void Awake()
        {
            this.projection = this.GetComponent<LlockhamIndustries.Decals.ProjectionRenderer>();
        }
        private void Update()
        {
            float val_11;
            LlockhamIndustries.Decals.ProjectionRenderer val_12;
            float val_13;
            float val_14;
            int val_10 = this.collumns;
            val_11 = this.time;
            val_10 = (-this.skipFirst) + (this.rows * val_10);
            if(this.paused != true)
            {
                    float val_2 = UnityEngine.Time.deltaTime;
                val_2 = val_2 * this.speed;
                val_11 = val_11 + val_2;
                this.time = val_11;
            }
            
            if(val_11 > ((float)val_10 - this.skipLast))
            {
                    if(this.destroyOnComplete != false)
            {
                    val_12 = this.projection;
                val_12.Destroy();
                return;
            }
            
                val_13 = val_11 - ((float)val_10 - this.skipLast);
                this.time = val_13;
            }
            
            int val_11 = this.skipFirst;
            val_11 = (UnityEngine.Mathf.FloorToInt(f:  val_13)) + val_11;
            float val_12 = (float)this.collumns;
            float val_13 = (float)this.rows;
            val_12 = 1f / val_12;
            val_13 = 1f / val_13;
            CinemachineFreeLook.Orbit val_4 = new CinemachineFreeLook.Orbit(h:  val_12, r:  val_13);
            int val_14 = this.collumns;
            int val_5 = val_11 / val_14;
            val_14 = val_11 - (val_5 * val_14);
            float val_15 = (float)val_5;
            float val_6 = 1f - val_4.m_Radius;
            val_15 = val_15 * val_4.m_Radius;
            val_6 = val_6 - val_15;
            val_14 = val_4.m_Height * (float)val_14;
            CinemachineFreeLook.Orbit val_8 = new CinemachineFreeLook.Orbit(h:  val_4.m_Height, r:  val_4.m_Radius);
            this.projection.Tiling = new UnityEngine.Vector2() {x = val_8.m_Height, y = val_8.m_Radius};
            CinemachineFreeLook.Orbit val_9 = new CinemachineFreeLook.Orbit(h:  val_14, r:  (this.invertY == true) ? (val_15) : (val_6));
            this.projection.Offset = new UnityEngine.Vector2() {x = val_9.m_Height, y = val_9.m_Radius};
            val_12 = this.projection;
            val_12.UpdateProperties();
        }
        public void Play()
        {
            this.paused = false;
        }
        public void Pause()
        {
            this.paused = true;
        }
        public void Stop()
        {
            this.paused = true;
            this.time = 0f;
        }
    
    }

}
