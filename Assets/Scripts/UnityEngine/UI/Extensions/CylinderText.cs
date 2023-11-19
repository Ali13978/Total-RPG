using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    [UnityEngine.RequireComponent]
    [UnityEngine.AddComponentMenu]
    public class CylinderText : BaseMeshEffect
    {
        // Fields
        public float radius;
        private UnityEngine.RectTransform rectTrans;
        
        // Methods
        public CylinderText()
        {
        
        }
        protected override void Awake()
        {
            this.Awake();
            this.rectTrans = this.GetComponent<UnityEngine.RectTransform>();
            this.OnRectTransformDimensionsChange();
        }
        protected override void OnEnable()
        {
            this.OnEnable();
            this.rectTrans = this.GetComponent<UnityEngine.RectTransform>();
            this.OnRectTransformDimensionsChange();
        }
        public override void ModifyMesh(UnityEngine.UI.VertexHelper vh)
        {
            float val_7;
            var val_10;
            if(this.IsActive() == false)
            {
                    return;
            }
            
            val_10 = vh.currentVertCount;
            if(val_10 == 0)
            {
                    return;
            }
            
            if(this.IsActive() ^ 1 == true)
            {
                    return;
            }
            
            val_10 = 0;
            goto label_5;
            label_12:
            vh.SetUIVertex(vertex:  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3(), normal = new UnityEngine.Vector3(), color = new UnityEngine.Color32(), uv0 = new UnityEngine.Vector2(), uv1 = new UnityEngine.Vector2(), uv2 = new UnityEngine.Vector2(), uv3 = new UnityEngine.Vector2(), tangent = new UnityEngine.Vector4()}, i:  0);
            val_10 = 1;
            label_5:
            if(val_10 >= vh.currentVertCount)
            {
                    return;
            }
            
            vh.PopulateUIVertex(vertex: ref  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3(), normal = new UnityEngine.Vector3(), color = new UnityEngine.Color32(), uv0 = new UnityEngine.Vector2(), uv1 = new UnityEngine.Vector2(), uv2 = new UnityEngine.Vector2(), uv3 = new UnityEngine.Vector2(), tangent = new UnityEngine.Vector4()}, i:  1);
            float val_8 = val_7 / this.radius;
            val_8 = -(this.radius * val_8);
            float val_9 = val_7 / this.radius;
            val_9 = this.radius * val_9;
            val_7 = val_9;
            if(vh != null)
            {
                goto label_12;
            }
            
            goto label_12;
        }
    
    }

}
