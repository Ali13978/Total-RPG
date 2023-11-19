using UnityEngine;

namespace TzarGames.Common.UI
{
    public class CircleRaycastGraphic : Graphic
    {
        // Fields
        [UnityEngine.SerializeField]
        private float radius;
        private float radiusSquare;
        private UnityEngine.RectTransform cachedTransform;
        private UnityEngine.Vector2 position2D;
        
        // Properties
        public float Radius { get; set; }
        
        // Methods
        public CircleRaycastGraphic()
        {
            this.radius = 50f;
        }
        public float get_Radius()
        {
            return (float)this.radius;
        }
        public void set_Radius(float value)
        {
            this.radius = value;
            value = value * value;
            this.radiusSquare = value;
        }
        public override void SetMaterialDirty()
        {
        
        }
        public override void SetVerticesDirty()
        {
        
        }
        protected override void Awake()
        {
            this.Awake();
            float val_2 = this.radius;
            this.cachedTransform = this.rectTransform;
            val_2 = val_2 * val_2;
            this.radiusSquare = val_2;
        }
        protected override void OnPopulateMesh(UnityEngine.UI.VertexHelper vh)
        {
            vh.Clear();
        }
        public override bool Raycast(UnityEngine.Vector2 sp, UnityEngine.Camera eventCamera)
        {
            UnityEngine.Vector3 val_1 = this.cachedTransform.position;
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            this.position2D = val_2;
            mem[1152921511236495348] = val_2.y;
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y}, b:  new UnityEngine.Vector2() {x = sp.x, y = sp.y});
            float val_6 = this.canvas.scaleFactor;
            float val_8 = this.radiusSquare;
            val_8 = val_6 * val_8;
            val_6 = val_6 * val_8;
            return (bool)(val_3.x.sqrMagnitude <= val_6) ? 1 : 0;
        }
    
    }

}
