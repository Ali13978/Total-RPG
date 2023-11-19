using UnityEngine;
internal enum Status.ResponseStatus
{
    // Fields
    VALID = 1
    ,VALID_BUT_STALE = 2
    ,ERROR_LICENSE_CHECK_FAILED = -1
    ,ERROR_INTERNAL = -2
    ,ERROR_NOT_AUTHORIZED = -3
    ,ERROR_VERSION_UPDATE_REQUIRED = -4
    ,ERROR_TIMEOUT = -5
    

}
