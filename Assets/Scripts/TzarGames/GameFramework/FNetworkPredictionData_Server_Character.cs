using UnityEngine;

namespace TzarGames.GameFramework
{
    public class FNetworkPredictionData_Server_Character : FNetworkPredictionData_Server
    {
        // Fields
        public TzarGames.GameFramework.FClientAdjustment PendingAdjustment;
        public float CurrentClientTimeStamp;
        public float LastUpdateTime;
        public float MaxResponseTime;
        
        // Methods
        public FNetworkPredictionData_Server_Character()
        {
            this.MaxResponseTime = 0.125f;
        }
        public float GetServerMoveDeltaTime(float TimeStamp)
        {
            return UnityEngine.Mathf.Min(a:  this.MaxResponseTime, b:  TimeStamp - this.CurrentClientTimeStamp);
        }
    
    }

}
