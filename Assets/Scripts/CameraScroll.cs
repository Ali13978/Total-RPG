using UnityEngine;
public class CameraScroll : MonoBehaviour
{
    // Fields
    public UnityEngine.UI.Slider speedSlider;
    public float moveSpeed;
    
    // Methods
    public CameraScroll()
    {
        this.moveSpeed = 0.5f;
    }
    private void Start()
    {
        this.speedSlider.onValueChanged.AddListener(call:  new UnityEngine.Events.UnityAction<System.Single>(object:  this, method:  System.Void CameraScroll::<Start>m__0(float )));
    }
    private void Update()
    {
        var val_13;
        float val_14;
        val_13 = this;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.left;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  UnityEngine.Time.deltaTime * this.moveSpeed);
        val_14 = val_5.x;
        this.transform.Translate(translation:  new UnityEngine.Vector3() {x = val_14, y = val_5.y, z = val_5.z});
        UnityEngine.Vector3 val_7 = this.transform.position;
        if(val_7.x <= 110f)
        {
                return;
        }
        
        UnityEngine.Vector3 val_10 = this.transform.position;
        val_14 = val_10.y;
        val_13 = this.transform;
        UnityEngine.Vector3 val_12 = val_13.position;
        this.transform.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    private void ChangeSpeed()
    {
        this.moveSpeed = ;
    }
    private void <Start>m__0(float )
    {
        this.moveSpeed = ;
    }

}
