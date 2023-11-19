using UnityEngine;
private enum MiniParser.ActionCode
{
    // Fields
    START_ELEM = 0
    ,END_ELEM = 1
    ,END_NAME = 2
    ,SET_ATTR_NAME = 3
    ,SET_ATTR_VAL = 4
    ,SEND_CHARS = 5
    ,START_CDATA = 6
    ,END_CDATA = 7
    ,ERROR = 8
    ,STATE_CHANGE = 9
    ,FLUSH_CHARS_STATE_CHANGE = 10
    ,ACC_CHARS_STATE_CHANGE = 11
    ,ACC_CDATA = 12
    ,PROC_CHAR_REF = 13
    ,UNKNOWN = 15
    

}
