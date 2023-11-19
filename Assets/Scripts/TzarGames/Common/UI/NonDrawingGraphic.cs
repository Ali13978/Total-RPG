using UnityEngine;

namespace TzarGames.Common.UI
{
    public class NonDrawingGraphic : Graphic
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
