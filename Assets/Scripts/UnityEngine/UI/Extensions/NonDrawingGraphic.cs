using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    [UnityEngine.AddComponentMenu]
    public class NonDrawingGraphic : MaskableGraphic
    {
        // Methods
        public NonDrawingGraphic()
        {
        
        }
        public override void SetMaterialDirty()
        {
        
        }
        public override void SetVerticesDirty()
        {
        
        }
        protected override void OnPopulateMesh(UnityEngine.UI.VertexHelper vh)
        {
            vh.Clear();
        }
    
    }

}
