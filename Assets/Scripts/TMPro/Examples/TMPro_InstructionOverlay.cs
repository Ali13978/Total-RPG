using UnityEngine;

namespace TMPro.Examples
{
    public class TMPro_InstructionOverlay : MonoBehaviour
    {
        // Fields
        public TMPro.Examples.TMPro_InstructionOverlay.FpsCounterAnchorPositions AnchorPosition;
        private const string instructions = "Camera Control - <#ffff00>Shift + RMB\n</color>Zoom - <#ffff00>Mouse wheel.";
        private TMPro.TextMeshPro m_TextMeshPro;
        private TMPro.TextContainer m_textContainer;
        private UnityEngine.Transform m_frameCounter_transform;
        private UnityEngine.Camera m_camera;
        
        // Methods
        public TMPro_InstructionOverlay()
        {
            this.AnchorPosition = 1;
        }
        private void Awake()
        {
            var val_13;
            if(this.enabled == false)
            {
                    return;
            }
            
            this.m_camera = UnityEngine.Camera.main;
            UnityEngine.GameObject val_3 = new UnityEngine.GameObject(name:  "Frame Counter");
            UnityEngine.Transform val_4 = transform;
            this.m_frameCounter_transform = val_4;
            val_4.parent = this.m_camera.transform;
            UnityEngine.Quaternion val_6 = UnityEngine.Quaternion.identity;
            this.m_frameCounter_transform.localRotation = new UnityEngine.Quaternion() {x = val_6.x, y = val_6.y, z = val_6.z, w = val_6.w};
            TMPro.TextMeshPro val_7 = AddComponent<TMPro.TextMeshPro>();
            this.m_TextMeshPro = val_7;
            System.Type val_8 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            UnityEngine.Object val_9 = UnityEngine.Resources.Load(path:  0, systemTypeInstance:  "Fonts & Materials/LiberationSans SDF");
            val_13 = 0;
            val_7.font = ;
            System.Type val_10 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            this.m_TextMeshPro.fontSize = 30f;
            this.m_TextMeshPro.isOverlay = true;
            this.m_textContainer = GetComponent<TMPro.TextContainer>();
            this.Set_FrameCounter_Position(anchor_position:  this.AnchorPosition);
            this.m_TextMeshPro.text = "Camera Control - <#ffff00>Shift + RMB\n</color>Zoom - <#ffff00>Mouse wheel.";
        }
        private void Set_FrameCounter_Position(TMPro.Examples.TMPro_InstructionOverlay.FpsCounterAnchorPositions anchor_position)
        {
            UnityEngine.Camera val_4 = this;
            var val_2 = (anchor_position < 4) ? (anchor_position + 3) : 0;
            val_2 = val_2 - 3;
            if(val_2 > 3)
            {
                    return;
            }
            
            var val_4 = 25805188 + ((anchor_position < 0x4 ? (anchor_position + 3) : 0 - 3)) << 2;
            val_4 = val_4 + 25805188;
            goto (25805188 + ((anchor_position < 0x4 ? (anchor_position + 3) : 0 - 3)) << 2 + 25805188);
        }
    
    }

}
