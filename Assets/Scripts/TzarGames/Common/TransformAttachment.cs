using UnityEngine;

namespace TzarGames.Common
{
    public class TransformAttachment
    {
        // Fields
        private UnityEngine.Transform _parent;
        private UnityEngine.Transform _child;
        private UnityEngine.Vector3 localOffset;
        private UnityEngine.Vector3 localDirection;
        
        // Properties
        public UnityEngine.Transform Parent { get; }
        public UnityEngine.Transform Child { get; }
        
        // Methods
        public TransformAttachment()
        {
        
        }
        public UnityEngine.Transform get_Parent()
        {
            return (UnityEngine.Transform)this._parent;
        }
        public UnityEngine.Transform get_Child()
        {
            return (UnityEngine.Transform)this._child;
        }
        public void SetAttachment(UnityEngine.Transform parent, UnityEngine.Transform child)
        {
            this._parent = parent;
            UnityEngine.Vector3 val_1 = child.position;
            UnityEngine.Vector3 val_2 = parent.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            this.localOffset = val_2;
            mem[1152921511219957252] = val_2.y;
            mem[1152921511219957256] = val_2.z;
            UnityEngine.Vector3 val_3 = child.forward;
            UnityEngine.Vector3 val_4 = parent.InverseTransformDirection(direction:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            this.localDirection = val_4;
            mem[1152921511219957264] = val_4.y;
            this._child = child;
            mem[1152921511219957268] = val_4.z;
        }
        public void Reset()
        {
            this._parent = 0;
            this._child = 0;
        }
        public void Update()
        {
            if(0 == this._parent)
            {
                    return;
            }
            
            if(0 == this._child)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_5 = this._parent.TransformPoint(position:  new UnityEngine.Vector3() {x = this.localOffset, y = V9.16B, z = V10.16B});
            this._child.position = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            UnityEngine.Vector3 val_6 = this._parent.TransformDirection(direction:  new UnityEngine.Vector3() {x = this.localDirection, y = val_5.y, z = val_5.z});
            this._child.forward = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        }
    
    }

}
