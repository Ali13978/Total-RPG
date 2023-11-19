using UnityEngine;

namespace TMPro.Examples
{
    public class TMP_FrameRateCounter : MonoBehaviour
    {
        // Fields
        public float UpdateInterval;
        private float m_LastInterval;
        private int m_Frames;
        public TMPro.Examples.TMP_FrameRateCounter.FpsCounterAnchorPositions AnchorPosition;
        private string htmlColorTag;
        private const string fpsLabel = "{0:2}</color> FPS \n{1:2} <#8080ff>MS";
        private TMPro.TextMeshPro m_TextMeshPro;
        private UnityEngine.Transform m_frameCounter_transform;
        private UnityEngine.Camera m_camera;
        private TMPro.Examples.TMP_FrameRateCounter.FpsCounterAnchorPositions last_AnchorPosition;
        
        // Methods
        public TMP_FrameRateCounter()
        {
            this.UpdateInterval = 5f;
            this.AnchorPosition = 2;
        }
        private void Awake()
        {
            var val_12;
            if(this.enabled == false)
            {
                    return;
            }
            
            this.m_camera = UnityEngine.Camera.main;
            UnityEngine.Application.targetFrameRate = 0;
            UnityEngine.GameObject val_3 = new UnityEngine.GameObject(name:  "Frame Counter");
            TMPro.TextMeshPro val_4 = AddComponent<TMPro.TextMeshPro>();
            this.m_TextMeshPro = val_4;
            System.Type val_5 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            UnityEngine.Object val_6 = UnityEngine.Resources.Load(path:  0, systemTypeInstance:  "Fonts & Materials/LiberationSans SDF");
            val_12 = 0;
            val_4.font = ;
            System.Type val_7 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            UnityEngine.Transform val_9 = transform;
            this.m_frameCounter_transform = val_9;
            val_9.SetParent(parent:  this.m_camera.transform);
            UnityEngine.Quaternion val_11 = UnityEngine.Quaternion.identity;
            this.m_frameCounter_transform.localRotation = new UnityEngine.Quaternion() {x = val_11.x, y = val_11.y, z = val_11.z, w = val_11.w};
            this.m_TextMeshPro.enableWordWrapping = false;
            this.m_TextMeshPro.fontSize = 24f;
            this.m_TextMeshPro.isOverlay = true;
            this.Set_FrameCounter_Position(anchor_position:  this.AnchorPosition);
            this.last_AnchorPosition = this.AnchorPosition;
        }
        private void Start()
        {
            this.m_Frames = 0;
            this.m_LastInterval = UnityEngine.Time.realtimeSinceStartup;
        }
        private void Update()
        {
            FpsCounterAnchorPositions val_6;
            string val_7;
            val_6 = this.AnchorPosition;
            if(val_6 != this.last_AnchorPosition)
            {
                    this.Set_FrameCounter_Position(anchor_position:  val_6);
                val_6 = this.AnchorPosition;
            }
            
            int val_6 = this.m_Frames;
            this.last_AnchorPosition = val_6;
            val_6 = val_6 + 1;
            this.m_Frames = val_6;
            float val_1 = UnityEngine.Time.realtimeSinceStartup;
            float val_7 = this.m_LastInterval;
            if(val_1 <= (val_7 + this.UpdateInterval))
            {
                    return;
            }
            
            val_7 = val_1 - val_7;
            float val_3 = (float)this.m_Frames / val_7;
            float val_8 = UnityEngine.Mathf.Max(a:  val_3, b:  1E-05f);
            if(val_3 < 0)
            {
                    val_7 = "<color=yellow>";
            }
            else
            {
                    if(val_3 < 0)
            {
                    val_7 = "<color=red>";
            }
            else
            {
                    val_7 = "<color=green>";
            }
            
            }
            
            this.htmlColorTag = val_7;
            val_8 = 1000f / val_8;
            this.m_TextMeshPro.SetText(text:  0 + val_7, arg0:  val_3, arg1:  val_8);
            this.m_Frames = 0;
            this.m_LastInterval = val_1;
        }
        private void Set_FrameCounter_Position(TMPro.Examples.TMP_FrameRateCounter.FpsCounterAnchorPositions anchor_position)
        {
            UnityEngine.Camera val_12 = this;
            var val_2 = (anchor_position < 4) ? (anchor_position + 3) : 0;
            val_2 = val_2 - 3;
            if(val_2 > 3)
            {
                    return;
            }
            
            var val_12 = 25805156 + ((anchor_position < 0x4 ? (anchor_position + 3) : 0 - 3)) << 2;
            val_12 = val_12 + 25805156;
            goto (25805156 + ((anchor_position < 0x4 ? (anchor_position + 3) : 0 - 3)) << 2 + 25805156);
        }
    
    }

}
