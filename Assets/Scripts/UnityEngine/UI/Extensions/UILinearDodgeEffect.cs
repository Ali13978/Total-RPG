using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    [UnityEngine.AddComponentMenu]
    [UnityEngine.ExecuteInEditMode]
    [UnityEngine.RequireComponent]
    public class UILinearDodgeEffect : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.MaskableGraphic mGraphic;
        
        // Methods
        public UILinearDodgeEffect()
        {
        
        }
        private void Start()
        {
            this.SetMaterial();
        }
        public void SetMaterial()
        {
            UnityEngine.UI.MaskableGraphic val_1 = this.GetComponent<UnityEngine.UI.MaskableGraphic>();
            this.mGraphic = val_1;
            if(0 != val_1)
            {
                    if(0 != this.mGraphic.material)
            {
                    if((System.String.op_Equality(a:  0, b:  this.mGraphic.material.name)) == false)
            {
                    return;
            }
            
            }
            
                this.mGraphic.material = new UnityEngine.Material(shader:  UnityEngine.Shader.Find(name:  0));
                return;
            }
            
            UnityEngine.Debug.LogError(message:  0);
        }
        public void OnValidate()
        {
            this.SetMaterial();
        }
    
    }

}
