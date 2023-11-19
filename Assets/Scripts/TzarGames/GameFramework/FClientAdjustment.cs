using UnityEngine;

namespace TzarGames.GameFramework
{
    public struct FClientAdjustment
    {
        // Fields
        public float TimeStamp;
        public float DeltaTime;
        public UnityEngine.Vector3 NewLoc;
        public UnityEngine.Vector3 NewVel;
        public TzarGames.GameFramework.FRotator NewRot;
        public TzarGames.GameFramework.UPrimitiveComponent NewBase;
        public ushort bAckGoodMove;
        public bool bBaseRelativePosition;
        
        // Methods
        public void Init()
        {
        
        }
    
    }

}
