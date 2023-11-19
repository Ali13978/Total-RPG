using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    [UnityEngine.RequireComponent]
    [UnityEngine.AddComponentMenu]
    public class DragCorrector : MonoBehaviour
    {
        // Fields
        public int baseTH;
        public int basePPI;
        public int dragTH;
        
        // Methods
        public DragCorrector()
        {
            this.baseTH = 6;
            this.basePPI = 210;
        }
        private void Start()
        {
            int val_5 = this.basePPI;
            int val_4 = (int)UnityEngine.Screen.dpi;
            val_4 = val_4 * this.baseTH;
            val_5 = val_4 / val_5;
            this.dragTH = val_5;
            if((UnityEngine.Object.op_Implicit(exists:  0)) == false)
            {
                    return;
            }
            
            this.GetComponent<UnityEngine.EventSystems.EventSystem>().pixelDragThreshold = this.dragTH;
        }
    
    }

}
