using UnityEngine;
public static class SA_EditorTesting
{
    // Fields
    public const int DEFAULT_SORT_ORDER = 10000;
    
    // Properties
    public static bool IsInsideEditor { get; }
    
    // Methods
    public static bool get_IsInsideEditor()
    {
        var val_3;
        if(UnityEngine.Application.platform != 7)
        {
                if(UnityEngine.Application.platform != 0)
        {
                val_3 = 0;
            return (bool)val_3;
        }
        
        }
        
        val_3 = 1;
        return (bool)val_3;
    }
    public static bool HasFill(float fillRate)
    {
        return (bool)(((float)UnityEngine.Random.Range(min:  0, max:  1)) <= fillRate) ? 1 : 0;
    }
    public static void CheckForEventSystem()
    {
        UnityEngine.Object val_6;
        System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        UnityEngine.Object val_2 = UnityEngine.Object.FindObjectOfType(type:  0);
        val_6 = 0;
        if(val_2 != null)
        {
                val_6 = val_2;
            val_6 = 0;
        }
        
        bool val_5 = UnityEngine.Object.op_Equality(x:  0, y:  val_6);
    }

}
