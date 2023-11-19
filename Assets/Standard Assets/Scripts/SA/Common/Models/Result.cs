using UnityEngine;

namespace SA.Common.Models
{
    public class Result
    {
        // Fields
        protected SA.Common.Models.Error _Error;
        
        // Properties
        public SA.Common.Models.Error Error { get; }
        public bool HasError { get; }
        public bool IsSucceeded { get; }
        public bool IsFailed { get; }
        
        // Methods
        public Result()
        {
        
        }
        public Result(SA.Common.Models.Error error)
        {
            this._Error = error;
        }
        public SA.Common.Models.Error get_Error()
        {
            return (SA.Common.Models.Error)this._Error;
        }
        public bool get_HasError()
        {
            return (bool)(this._Error != 0) ? 1 : 0;
        }
        public bool get_IsSucceeded()
        {
            return (bool)(this._Error == 0) ? 1 : 0;
        }
        public bool get_IsFailed()
        {
            return (bool)(this._Error != 0) ? 1 : 0;
        }
    
    }

}
