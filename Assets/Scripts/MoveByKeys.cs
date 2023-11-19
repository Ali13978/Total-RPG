using UnityEngine;
[UnityEngine.RequireComponent]
public class MoveByKeys : MonoBehaviour
{
    // Fields
    public float Speed;
    public float JumpForce;
    public float JumpTimeout;
    private bool isSprite;
    private float jumpingTime;
    private UnityEngine.Rigidbody body;
    private UnityEngine.Rigidbody2D body2d;
    
    // Methods
    public MoveByKeys()
    {
        this.Speed = 10f;
        this.JumpForce = 200f;
        this.JumpTimeout = 0.5f;
    }
    public void Start()
    {
        this.isSprite = UnityEngine.Object.op_Inequality(x:  0, y:  this.GetComponent<UnityEngine.SpriteRenderer>());
        this.body2d = this.GetComponent<UnityEngine.Rigidbody2D>();
        this.body = this.GetComponent<UnityEngine.Rigidbody>();
    }
    public void FixedUpdate()
    {
        float val_35;
        float val_36;
        float val_37;
        float val_38;
        float val_39;
        if(this.photonView.isMine == false)
        {
                return;
        }
        
        if((UnityEngine.Input.GetAxisRaw(axisName:  0)) < 0)
        {
            goto label_5;
        }
        
        val_35 = 0.1f;
        if((UnityEngine.Input.GetAxisRaw(axisName:  0)) <= val_35)
        {
            goto label_8;
        }
        
        label_5:
        UnityEngine.Transform val_5 = this.transform;
        UnityEngine.Vector3 val_6 = val_5.position;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.right;
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, d:  this.Speed * UnityEngine.Time.deltaTime);
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, d:  UnityEngine.Input.GetAxisRaw(axisName:  0));
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, b:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
        val_36 = val_13.z;
        val_37 = val_13.x;
        val_35 = val_13.y;
        val_38 = val_36;
        val_5.position = new UnityEngine.Vector3() {x = val_37, y = val_35, z = val_38};
        label_8:
        val_39 = this.jumpingTime;
        if(val_39 > 0f)
        {
                val_37 = val_39 - UnityEngine.Time.deltaTime;
            this.jumpingTime = val_37;
        }
        else
        {
                if(0 == this.body)
        {
                if(0 == this.body2d)
        {
            goto label_35;
        }
        
        }
        
            if((UnityEngine.Input.GetKey(key:  0)) != false)
        {
                this.jumpingTime = this.JumpTimeout;
            UnityEngine.Vector2 val_19 = UnityEngine.Vector2.up;
            val_38 = this.JumpForce;
            UnityEngine.Vector2 val_20 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_19.x, y = val_19.y}, d:  val_38);
            val_39 = val_20.x;
            if(0 != this.body2d)
        {
                val_37 = val_39;
            val_35 = val_20.y;
            this.body2d.AddForce(force:  new UnityEngine.Vector2() {x = val_37, y = val_35});
        }
        else
        {
                if(0 != this.body)
        {
                UnityEngine.Vector3 val_23 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_39, y = val_20.y});
            val_39 = val_23.x;
            val_36 = val_23.z;
            val_37 = val_39;
            val_35 = val_23.y;
            val_38 = val_36;
            this.body.AddForce(force:  new UnityEngine.Vector3() {x = val_37, y = val_35, z = val_38});
        }
        
        }
        
        }
        
        }
        
        label_35:
        if(this.isSprite == true)
        {
                return;
        }
        
        if((UnityEngine.Input.GetAxisRaw(axisName:  0)) >= 0)
        {
                val_35 = 0.1f;
            if((UnityEngine.Input.GetAxisRaw(axisName:  0)) <= val_35)
        {
                return;
        }
        
        }
        
        UnityEngine.Transform val_26 = this.transform;
        UnityEngine.Vector3 val_27 = val_26.position;
        UnityEngine.Vector3 val_28 = UnityEngine.Vector3.forward;
        UnityEngine.Vector3 val_31 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z}, d:  this.Speed * UnityEngine.Time.deltaTime);
        UnityEngine.Vector3 val_33 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_31.z}, d:  UnityEngine.Input.GetAxisRaw(axisName:  0));
        UnityEngine.Vector3 val_34 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z}, b:  new UnityEngine.Vector3() {x = val_33.x, y = val_33.y, z = val_33.z});
        val_26.position = new UnityEngine.Vector3() {x = val_34.x, y = val_34.y, z = val_34.z};
    }

}
