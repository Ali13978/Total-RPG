using UnityEngine;

namespace TzarGames.Endless
{
    public class Gate : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private bool isBlocked;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.EndlessSpawner firstRoom;
        [UnityEngine.SerializeField]
        private TzarGames.Endless.EndlessSpawner secondRoom;
        [UnityEngine.SerializeField]
        private UnityEngine.Events.UnityEvent OnBlocked;
        [UnityEngine.SerializeField]
        private UnityEngine.Events.UnityEvent OnUnblocked;
        
        // Properties
        public bool IsBlocked { get; }
        public TzarGames.Endless.EndlessSpawner FirstRoom { get; }
        public TzarGames.Endless.EndlessSpawner SecondRoom { get; }
        
        // Methods
        public Gate()
        {
        
        }
        public bool get_IsBlocked()
        {
            return (bool)this.isBlocked;
        }
        public TzarGames.Endless.EndlessSpawner get_FirstRoom()
        {
            return (TzarGames.Endless.EndlessSpawner)this.firstRoom;
        }
        public TzarGames.Endless.EndlessSpawner get_SecondRoom()
        {
            return (TzarGames.Endless.EndlessSpawner)this.secondRoom;
        }
        private void Start()
        {
            this.invokeBlockedEvents();
        }
        private void invokeBlockedEvents()
        {
            UnityEngine.Events.UnityEvent val_1;
            if(this.isBlocked == false)
            {
                goto label_0;
            }
            
            val_1 = this.OnBlocked;
            if(val_1 != null)
            {
                goto label_3;
            }
            
            goto label_2;
            label_0:
            val_1 = this.OnUnblocked;
            if(val_1 != null)
            {
                goto label_3;
            }
            
            label_2:
            label_3:
            val_1.Invoke();
        }
        public void SetBlocked(bool blocked)
        {
            var val_1 = (this.isBlocked == true) ? 1 : 0;
            val_1 = val_1 ^ blocked;
            if(val_1 == false)
            {
                    return;
            }
            
            this.isBlocked = blocked;
            this.invokeBlockedEvents();
        }
        private void OnDrawGizmos()
        {
            UnityEngine.Color val_1 = UnityEngine.Color.green;
            UnityEngine.Gizmos.color = new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a};
            if(0 != this.firstRoom)
            {
                    UnityEngine.Vector3 val_4 = this.transform.position;
                UnityEngine.Vector3 val_6 = this.firstRoom.transform.position;
                UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, to:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
                UnityEngine.Vector3 val_8 = this.firstRoom.transform.position;
                UnityEngine.Gizmos.DrawSphere(center:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, radius:  0.25f);
            }
            
            if(0 == this.secondRoom)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_11 = this.transform.position;
            UnityEngine.Vector3 val_13 = this.secondRoom.transform.position;
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, to:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
            UnityEngine.Vector3 val_15 = this.secondRoom.transform.position;
            UnityEngine.Gizmos.DrawSphere(center:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, radius:  0.25f);
        }
    
    }

}
