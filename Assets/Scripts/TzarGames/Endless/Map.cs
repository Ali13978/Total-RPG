using UnityEngine;

namespace TzarGames.Endless
{
    public class Map : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.Transform followTarget;
        [UnityEngine.SerializeField]
        private float minimapSize;
        [UnityEngine.SerializeField]
        private float extendedSize;
        [UnityEngine.SerializeField]
        private float height;
        [UnityEngine.SerializeField]
        private UnityEngine.Camera mapCamera;
        private TzarGames.Endless.MapBounds mapBounds;
        private UnityEngine.Vector3 displacement;
        private UnityEngine.Transform cachedTransform;
        
        // Properties
        public float Height { get; }
        public UnityEngine.Camera Camera { get; }
        
        // Methods
        public Map()
        {
            this.minimapSize = 18f;
            this.extendedSize = 36f;
            this.height = 50f;
        }
        public float get_Height()
        {
            return (float)this.height;
        }
        public UnityEngine.Camera get_Camera()
        {
            return (UnityEngine.Camera)this.mapCamera;
        }
        private void Start()
        {
            UnityEngine.Transform val_1 = this.transform;
            this.cachedTransform = val_1;
            if(0 != val_1.parent)
            {
                    this.cachedTransform.SetParent(parent:  0);
            }
            
            this.mapBounds = UnityEngine.Object.FindObjectOfType<UnityEngine.UI.Extensions.BoundTooltipItem>();
            this.displacement = 0;
            mem[1152921510724730724] = 0;
            mem[1152921510724730728] = 0;
            this.SetMinimapMode();
            if(0 == TzarGames.Endless.EndlessGameManager.LocalPlayerCharacter)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_8 = this.mapCamera.transform.eulerAngles;
            this = this.mapCamera.transform;
            this.eulerAngles = new UnityEngine.Vector3() {x = val_8.x, y = TzarGames.Endless.EndlessGameManager.LocalPlayerCharacter.PlayerCamera.CameraYaw, z = val_8.z};
        }
        private void Update()
        {
            float val_15;
            float val_16;
            float val_17;
            float val_18;
            float val_19;
            UnityEngine.Vector3 val_1 = this.cachedTransform.eulerAngles;
            UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.Euler(x:  0f, y:  val_1.y, z:  0f);
            UnityEngine.Vector3 val_3 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w}, point:  new UnityEngine.Vector3() {x = this.displacement});
            UnityEngine.Vector3 val_4 = this.followTarget.position;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            val_15 = val_5.x;
            val_16 = val_5.z;
            if(0 == this.mapBounds)
            {
                goto label_9;
            }
            
            val_17 = val_15;
            val_18 = val_5.y;
            val_19 = val_16;
            if((this.clampBounds(pos: ref  new UnityEngine.Vector3() {x = val_15, y = val_5.y, z = val_16})) == false)
            {
                goto label_15;
            }
            
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_17, y = val_18, z = val_19}, b:  new UnityEngine.Vector3() {x = val_15, y = val_5.y, z = val_16});
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
            val_15 = val_9.x;
            val_16 = val_9.z;
            UnityEngine.Quaternion val_10 = UnityEngine.Quaternion.Inverse(rotation:  new UnityEngine.Quaternion() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w});
            UnityEngine.Vector3 val_11 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_10.x, y = val_10.y, z = val_10.z, w = val_10.w}, point:  new UnityEngine.Vector3() {x = val_15, y = val_9.y, z = val_16});
            this.displacement = val_11;
            mem[1152921510724904164] = val_11.y;
            mem[1152921510724904168] = val_11.z;
            goto label_15;
            label_9:
            val_19 = val_16;
            val_18 = val_5.y;
            val_17 = val_15;
            label_15:
            this.cachedTransform.position = new UnityEngine.Vector3() {x = val_17, y = val_18, z = val_19};
        }
        [UnityEngine.ContextMenu]
        public void SetMinimapMode()
        {
            this.mapCamera.orthographicSize = this.minimapSize;
            mem[1152921510725036648] = 0;
            this.displacement = 0;
        }
        [UnityEngine.ContextMenu]
        public void SetExtendedMode()
        {
            this.mapCamera.orthographicSize = this.extendedSize;
        }
        public void MoveHorizontally(float deltaX, float deltaZ)
        {
            if(0 == this.mapBounds)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_3 = this.displacement;
            val_3 = val_3 + deltaX;
            deltaZ = deltaZ + deltaZ;
            this.displacement = val_3;
            mem[1152921510725277032] = deltaZ;
        }
        public void ResetHorizontalDisplacement()
        {
            this.displacement = 0;
            mem[1152921510725393128] = 0;
        }
        private bool clampBounds(ref UnityEngine.Vector3 pos)
        {
            var val_1;
            if(pos.x >= 0)
            {
                goto label_1;
            }
            
            pos.x = this.mapBounds.bounds;
            goto label_2;
            label_1:
            if(pos.x <= this.mapBounds.bounds)
            {
                goto label_3;
            }
            
            pos.x = this.mapBounds.bounds;
            label_2:
            val_1 = 1;
            goto label_4;
            label_3:
            val_1 = 0;
            label_4:
            if(pos.z < 0)
            {
                    pos.z = V2.16B;
            }
            else
            {
                    if(pos.z <= S2)
            {
                    return (bool)val_1;
            }
            
                pos.z = ;
            }
            
            val_1 = 1;
            return (bool)val_1;
        }
    
    }

}
