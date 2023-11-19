using UnityEngine;

namespace TzarGames.GameFramework.Database
{
    public class DatabaseRequest
    {
        // Properties
        public bool IsDone { get; }
        public bool IsSuccessful { get; }
        public bool IsCanceled { get; }
        
        // Methods
        public DatabaseRequest()
        {
        
        }
        public UnityEngine.Coroutine WaitUntilDone()
        {
            return 0;
        }
        public bool HasFailed()
        {
            return true;
        }
        public bool get_IsDone()
        {
            return false;
        }
        public bool get_IsSuccessful()
        {
            return false;
        }
        public bool get_IsCanceled()
        {
            return false;
        }
        public TzarGames.GameFramework.Database.DatabaseRequestError GetError()
        {
            return 0;
        }
    
    }

}
