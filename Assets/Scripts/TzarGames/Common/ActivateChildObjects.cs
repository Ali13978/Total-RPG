using UnityEngine;

namespace TzarGames.Common
{
    public class ActivateChildObjects : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.GameObject[] childs;
        
        // Methods
        public ActivateChildObjects()
        {
        
        }
        private void Reset()
        {
            var val_7;
            UnityEngine.GameObject[] val_8;
            val_7 = this.transform.childCount;
            val_8 = null;
            this.childs = val_8;
            if()
            {
                    return;
            }
            
            val_7 = 0;
            goto label_3;
            label_10:
            val_8 = this.childs;
            val_7 = 1;
            label_3:
            val_8[val_7] = this.transform.GetChild(index:  1).gameObject;
            if((val_7 - 1) != val_7)
            {
                goto label_10;
            }
        
        }
        public void SetState(bool active)
        {
            if(this.childs.Length < 1)
            {
                    return;
            }
            
            var val_2 = 0;
            do
            {
                this.childs = this.childs[val_2];
                this.childs.SetActive(value:  active);
                val_2 = val_2 + 1;
            }
            while(this.childs.Length != val_2);
        
        }
    
    }

}
