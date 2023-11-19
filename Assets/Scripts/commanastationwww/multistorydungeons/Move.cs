using UnityEngine;

namespace commanastationwww.multistorydungeons
{
    public class Move : MonoBehaviour
    {
        // Fields
        private float speed;
        private float gravity;
        private float horizontalMovement;
        private float verticalMovement;
        private UnityEngine.CharacterController character;
        private UnityEngine.Vector3 destination;
        
        // Methods
        public Move()
        {
            this.speed = 7f;
            this.gravity = 300f;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            this.destination = val_1;
            mem[1152921512332542132] = val_1.y;
            mem[1152921512332542136] = val_1.z;
        }
        private void Start()
        {
            this.character = this.GetComponent<UnityEngine.CharacterController>();
        }
        private void Update()
        {
            this.horizontalMovement = UnityEngine.Input.GetAxis(axisName:  0);
            this.verticalMovement = UnityEngine.Input.GetAxis(axisName:  0);
            UnityEngine.Vector3 val_4 = this.transform.TransformDirection(direction:  new UnityEngine.Vector3() {x = this.destination, y = V9.16B, z = V10.16B});
            this.destination = val_4;
            mem[1152921512332786612] = val_4.y;
            mem[1152921512332786616] = val_4.z;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  this.speed);
            float val_10 = val_5.y;
            this.destination = val_5;
            mem[1152921512332786612] = val_10;
            mem[1152921512332786616] = val_5.z;
            float val_6 = UnityEngine.Time.deltaTime;
            val_6 = this.gravity * val_6;
            val_10 = val_10 - val_6;
            mem[1152921512332786612] = val_10;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.destination, y = val_10, z = val_4.z}, d:  UnityEngine.Time.deltaTime);
            UnityEngine.CollisionFlags val_9 = this.character.Move(motion:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
        }
    
    }

}
