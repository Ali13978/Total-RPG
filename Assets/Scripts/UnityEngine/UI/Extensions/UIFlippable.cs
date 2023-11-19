using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    [UnityEngine.RequireComponent]
    [UnityEngine.DisallowMultipleComponent]
    [UnityEngine.AddComponentMenu]
    public class UIFlippable : MonoBehaviour, IMeshModifier
    {
        // Fields
        [UnityEngine.SerializeField]
        private bool m_Horizontal;
        [UnityEngine.SerializeField]
        private bool m_Veritical;
        
        // Properties
        public bool horizontal { get; set; }
        public bool vertical { get; set; }
        
        // Methods
        public UIFlippable()
        {
        
        }
        public bool get_horizontal()
        {
            return (bool)this.m_Horizontal;
        }
        public void set_horizontal(bool value)
        {
            this.m_Horizontal = value;
        }
        public bool get_vertical()
        {
            return (bool)this.m_Veritical;
        }
        public void set_vertical(bool value)
        {
            this.m_Veritical = value;
        }
        protected void OnValidate()
        {
            if((this.GetComponent<UnityEngine.UI.Graphic>()) == null)
            {
                
            }
        
        }
        public void ModifyMesh(UnityEngine.UI.VertexHelper verts)
        {
            float val_4;
            float val_7;
            var val_9;
            var val_10;
            var val_11;
            float val_12;
            bool val_13;
            float val_14;
            UnityEngine.Transform val_1 = this.transform;
            val_10 = 0;
            if(val_1 != null)
            {
                    var val_2 = (null == null) ? (val_1) : 0;
            }
            
            val_11 = 0;
            goto label_2;
            label_12:
            verts.SetUIVertex(vertex:  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3(), normal = new UnityEngine.Vector3(), color = new UnityEngine.Color32(), uv0 = new UnityEngine.Vector2(), uv1 = new UnityEngine.Vector2(), uv2 = new UnityEngine.Vector2(), uv3 = new UnityEngine.Vector2(), tangent = new UnityEngine.Vector4()}, i:  0);
            val_11 = 1;
            label_2:
            if(val_11 >= verts.currentVertCount)
            {
                    return;
            }
            
            verts.PopulateUIVertex(vertex: ref  new UnityEngine.UIVertex() {position = new UnityEngine.Vector3(), normal = new UnityEngine.Vector3(), color = new UnityEngine.Color32(), uv0 = new UnityEngine.Vector2(), uv1 = new UnityEngine.Vector2(), uv2 = new UnityEngine.Vector2(), uv3 = new UnityEngine.Vector2(), tangent = new UnityEngine.Vector4()}, i:  1);
            val_12 = val_4;
            if((this.m_Horizontal & 255) != false)
            {
                    UnityEngine.Rect val_6 = val_2.rect;
                val_13 = this.m_Veritical;
                val_6.m_XMin = val_6.m_XMin - val_4;
                val_6.m_XMin = val_6.m_XMin + val_6.m_XMin;
                val_12 = val_12 + val_6.m_XMin;
            }
            else
            {
                    val_13 = this.m_Horizontal >> 8;
            }
            
            val_14 = val_7;
            if(val_13 != false)
            {
                    UnityEngine.Rect val_8 = val_2.rect;
                float val_10 = val_7;
                val_10 = val_8.m_YMin - val_10;
                val_10 = val_10 + val_10;
                val_14 = val_14 + val_10;
            }
            
            val_4 = 0;
            val_9 = 0;
            if(verts != null)
            {
                goto label_12;
            }
            
            goto label_12;
        }
        public void ModifyMesh(UnityEngine.Mesh mesh)
        {
        
        }
    
    }

}
