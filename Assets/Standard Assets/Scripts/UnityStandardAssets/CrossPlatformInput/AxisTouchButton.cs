using UnityEngine;

namespace UnityStandardAssets.CrossPlatformInput
{
    public class AxisTouchButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IEventSystemHandler
    {
        // Fields
        public string axisName;
        public float axisValue;
        public float responseSpeed;
        public float returnToCentreSpeed;
        private UnityStandardAssets.CrossPlatformInput.AxisTouchButton m_PairedWith;
        private UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.VirtualAxis m_Axis;
        
        // Methods
        public AxisTouchButton()
        {
            this.axisName = "Horizontal";
            this.axisValue = 1f;
            this.responseSpeed = 0f;
            this.returnToCentreSpeed = 3f;
        }
        private void OnEnable()
        {
            if((UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.AxisExists(name:  null)) != false)
            {
                    this.m_Axis = UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.VirtualAxisReference(name:  null);
            }
            else
            {
                    typeof(CrossPlatformInputManager.VirtualAxis).__il2cppRuntimeField_10 = this.axisName;
                typeof(CrossPlatformInputManager.VirtualAxis).__il2cppRuntimeField_1C = 1;
                this.m_Axis = new System.Object();
                UnityStandardAssets.CrossPlatformInput.CrossPlatformInputManager.RegisterVirtualAxis(axis:  null);
            }
            
            this.FindPairedButton();
        }
        private void FindPairedButton()
        {
            string val_5;
            System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            UnityEngine.Object[] val_2 = UnityEngine.Object.FindObjectsOfType(type:  0);
            if(val_2 == null)
            {
                    return;
            }
            
            if(val_2.Length < 1)
            {
                    return;
            }
            
            do
            {
                UnityEngine.Object val_6 = val_2[0];
                val_5 = this.axisName;
                if((System.String.op_Equality(a:  0, b:  X22)) != false)
            {
                    val_5 = mem[val_2[0x0] + 32];
                val_5 = val_2[0x0] + 32;
                if(0 != val_5)
            {
                    this.m_PairedWith = val_2[0x0] + 32;
            }
            
            }
            
            }
            while((0 + 1) < val_2.Length);
        
        }
        private void OnDisable()
        {
            this.m_Axis.Remove();
        }
        public void OnPointerDown(UnityEngine.EventSystems.PointerEventData data)
        {
            if(0 == this.m_PairedWith)
            {
                    this.FindPairedButton();
            }
            
            this.m_Axis.m_Value = UnityEngine.Mathf.MoveTowards(current:  this.m_Axis.m_Value, target:  this.axisValue, maxDelta:  this.responseSpeed * UnityEngine.Time.deltaTime);
        }
        public void OnPointerUp(UnityEngine.EventSystems.PointerEventData data)
        {
            this.m_Axis.m_Value = UnityEngine.Mathf.MoveTowards(current:  this.m_Axis.m_Value, target:  0f, maxDelta:  this.responseSpeed * UnityEngine.Time.deltaTime);
        }
    
    }

}
