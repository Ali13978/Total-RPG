using UnityEngine;

namespace FlurryAnalytics
{
    public enum EventRecordStatus
    {
        // Fields
        Failed = 0
        ,Recorded = 1
        ,UniqueCountExceeded = 2
        ,ParamsCountExceeded = 3
        ,LogCountExceeded = 4
        ,LoggingDelayed = 5
        
    
    }

}
