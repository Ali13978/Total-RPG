using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    [UnityEngine.RequireComponent]
    [UnityEngine.AddComponentMenu]
    public class PPIViewer : MonoBehaviour
    {
        // Fields
        private UnityEngine.UI.Text label;
        
        // Methods
        public PPIViewer()
        {
        
        }
        private void Awake()
        {
            this.label = this.GetComponent<UnityEngine.UI.Text>();
        }
        private void Start()
        {
            if(0 == this.label)
            {
                    return;
            }
            
            this = this.label;
            float val_2 = UnityEngine.Screen.dpi;
            string val_3 = 0 + "PPI: "("PPI: ");
        }
    
    }

}
