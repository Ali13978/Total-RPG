using UnityEngine;

namespace TzarGames.Endless.UI
{
    public class MapScrollUI : GameUIBase, IDragHandler, IEventSystemHandler
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.RectTransform mapRect;
        [UnityEngine.SerializeField]
        private UnityEngine.UI.Graphic graphic;
        private TzarGames.Endless.Map map;
        
        // Methods
        public MapScrollUI()
        {
        
        }
        protected override void OnPlayerOwnerSet(TzarGames.GameFramework.Player owner)
        {
            this.OnPlayerOwnerSet(owner:  owner);
            this.map = UnityEngine.Object.FindObjectOfType<UnityEngine.UI.Extensions.BoundTooltipItem>();
        }
        public void OnDrag(UnityEngine.EventSystems.PointerEventData eventData)
        {
            UnityEngine.Rect val_1 = this.mapRect.rect;
            float val_10 = val_1.m_XMin;
            UnityEngine.Vector2 val_4 = eventData.delta;
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_UnaryNegation(a:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
            val_10 = val_10 * this.graphic.canvas.scaleFactor;
            float val_8 = this.map.Camera.orthographicSize + this.map.Camera.orthographicSize;
            float val_9 = val_5.x / val_10;
            val_5.y = val_5.y / val_10;
            val_9 = val_9 * val_8;
            val_5.y = val_5.y * val_8;
            this.map.MoveHorizontally(deltaX:  val_9, deltaZ:  val_5.y);
        }
    
    }

}
