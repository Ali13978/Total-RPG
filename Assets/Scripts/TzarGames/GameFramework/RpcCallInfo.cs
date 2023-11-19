using UnityEngine;

namespace TzarGames.GameFramework
{
    internal struct RpcCallInfo
    {
        // Fields
        public System.Delegate methodDelegate;
        public TzarGames.GameFramework.NetworkViewBase caller;
        public object relatedObject;
        public TzarGames.GameFramework.TzarRPCModes mode;
        public int SessionID;
        public object[] parameters;
        public TzarGames.GameFramework.GameManager.dlgGetParameters paramGetFunc;
        
        // Methods
        public void MakeZero()
        {
            this.relatedObject = 0;
            this.parameters = 0;
            mem[1152921511365033856] = 0;
            mem[1152921511365033864] = 0;
        }
    
    }

}
