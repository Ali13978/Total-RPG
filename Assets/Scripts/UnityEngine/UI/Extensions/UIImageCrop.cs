using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    [UnityEngine.AddComponentMenu]
    [UnityEngine.ExecuteInEditMode]
    [UnityEngine.RequireComponent]
    public class UIImageCrop : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.MaskableGraphic mGraphic;
        private UnityEngine.Material mat;
        private int XCropProperty;
        private int YCropProperty;
        public float XCrop;
        public float YCrop;
        
        // Methods
        public UIImageCrop()
        {
        
        }
        private void Start()
        {
            this.SetMaterial();
        }
        public void SetMaterial()
        {
            UnityEngine.Material val_14;
            this.mGraphic = this.GetComponent<UnityEngine.UI.MaskableGraphic>();
            this.XCropProperty = UnityEngine.Shader.PropertyToID(name:  0);
            this.YCropProperty = UnityEngine.Shader.PropertyToID(name:  0);
            val_14 = 1152921504721543168;
            if(0 == this.mGraphic)
            {
                goto label_3;
            }
            
            if(0 != this.mGraphic.material)
            {
                    if((System.String.op_Equality(a:  0, b:  this.mGraphic.material.name)) == false)
            {
                goto label_12;
            }
            
            }
            
            UnityEngine.Material val_12 = null;
            val_14 = val_12;
            val_12 = new UnityEngine.Material(shader:  UnityEngine.Shader.Find(name:  0));
            this.mGraphic.material = val_14;
            label_12:
            this.mat = this.mGraphic.material;
            return;
            label_3:
            UnityEngine.Debug.LogError(message:  0);
        }
        public void OnValidate()
        {
            this.SetMaterial();
            this.SetXCrop(xcrop:  this.XCrop);
            this.SetYCrop(ycrop:  this.YCrop);
        }
        public void SetXCrop(float xcrop)
        {
            float val_1 = UnityEngine.Mathf.Clamp01(value:  xcrop);
            this.XCrop = val_1;
            this.mat.SetFloat(nameID:  this.XCropProperty, value:  val_1);
        }
        public void SetYCrop(float ycrop)
        {
            float val_1 = UnityEngine.Mathf.Clamp01(value:  ycrop);
            this.YCrop = val_1;
            this.mat.SetFloat(nameID:  this.YCropProperty, value:  val_1);
        }
    
    }

}
