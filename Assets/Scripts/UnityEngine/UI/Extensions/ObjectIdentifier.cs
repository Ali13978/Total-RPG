using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    public class ObjectIdentifier : MonoBehaviour
    {
        // Fields
        public string prefabName;
        public string id;
        public string idParent;
        public bool dontSave;
        
        // Methods
        public ObjectIdentifier()
        {
        
        }
        public void SetID()
        {
            System.Guid val_1 = System.Guid.NewGuid();
            this.id = ;
            this.CheckForRelatives();
        }
        private void CheckForRelatives()
        {
            var val_9;
            if(0 == this.transform.parent)
            {
                    this.idParent = 0;
                return;
            }
            
            val_9 = 0;
            goto label_6;
            label_17:
            val_9 = 1;
            label_6:
            if(val_9 >= val_4.Length)
            {
                    return;
            }
            
            T val_9 = this.GetComponentsInChildren<UnityEngine.UI.Extensions.ObjectIdentifier>()[1];
            UnityEngine.GameObject val_7 = this.gameObject;
            if(0 == val_9.transform.gameObject)
            {
                goto label_17;
            }
            
            if(val_9 != 0)
            {
                    mem2[0] = this.id;
            }
            else
            {
                    mem[40] = this.id;
            }
            
            val_9.SetID();
            goto label_17;
        }
    
    }

}
