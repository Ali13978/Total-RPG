using UnityEngine;

namespace Unitycoding
{
    public class FriendSlot : UISlot<Unitycoding.FriendInfo>
    {
        // Fields
        [UnityEngine.SerializeField]
        protected UnityEngine.UI.Text playerName;
        [UnityEngine.SerializeField]
        protected UnityEngine.UI.Image status;
        [UnityEngine.SerializeField]
        protected UnityEngine.Sprite online;
        [UnityEngine.SerializeField]
        protected UnityEngine.Sprite offline;
        [UnityEngine.SerializeField]
        protected UnityEngine.UI.Button message;
        
        // Methods
        public FriendSlot()
        {
        
        }
        public override void UpdateSlot(Unitycoding.FriendInfo item)
        {
            UnityEngine.UI.Image val_4;
            if(item == null)
            {
                    return;
            }
            
            bool val_1 = UnityEngine.Object.op_Inequality(x:  0, y:  this.playerName);
            val_4 = this.status;
            if(0 == val_4)
            {
                    return;
            }
            
            this.status.sprite = (item.m_Online == false) ? this.offline : this.online;
        }
    
    }

}
