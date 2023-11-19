using UnityEngine;
public class TG_ThirdPersonCamera_Mouse : TG_ThirdPersonCamera
{
    // Fields
    public float MouseSensitivityX;
    public float MouseSensitivityY;
    public float MinCamPitch;
    public float MaxCamPitch;
    private bool bRightMousePressed;
    private float mouseAxisX;
    private float mouseAxisY;
    
    // Methods
    public TG_ThirdPersonCamera_Mouse()
    {
        this.MouseSensitivityX = ;
        this.MouseSensitivityY = ;
        this.MinCamPitch = 15f;
        this.MaxCamPitch = 85f;
    }
    private void Update()
    {
        if((UnityEngine.Input.GetMouseButtonDown(button:  0)) != false)
        {
                if(this.bRightMousePressed == false)
        {
            goto label_4;
        }
        
        }
        
        if((UnityEngine.Input.GetMouseButtonUp(button:  0)) != false)
        {
                if(this.bRightMousePressed == false)
        {
                return;
        }
        
            this.bRightMousePressed = false;
            return;
        }
        
        if(this.bRightMousePressed == true)
        {
            goto label_10;
        }
        
        return;
        label_4:
        this.bRightMousePressed = true;
        label_10:
        this.mouseAxisX = UnityEngine.Input.GetAxis(axisName:  0);
        this.mouseAxisY = UnityEngine.Input.GetAxis(axisName:  0);
    }
    public override void UpdateCamera()
    {
        bool val_8 = this.bRightMousePressed;
        if((val_8 & 255) != false)
        {
                val_8 = val_8 >> 32;
            float val_2 = UnityEngine.Time.deltaTime;
            val_2 = (val_8 * this.MouseSensitivityX) * val_2;
            val_2 = S8 + val_2;
            mem[1152921511458601636] = val_2;
            float val_4 = UnityEngine.Time.deltaTime;
            val_4 = (this.mouseAxisY * this.MouseSensitivityY) * val_4;
            float val_6 = this.MouseSensitivityX - val_4;
            mem[1152921511458601632] = val_6;
            mem[1152921511458601632] = UnityEngine.Mathf.Clamp(value:  val_6, min:  this.MinCamPitch, max:  this.MaxCamPitch);
        }
        
        this.UpdateCamera();
    }

}
