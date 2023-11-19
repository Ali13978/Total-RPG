using UnityEngine;
public class CircleTouchable : MonoBehaviour
{
    // Fields
    public float TouchCircleScaleFactor;
    public UnityEngine.Vector3 CirclePivotDisplacement;
    private static System.Collections.Generic.List<CircleTouchable> allTouchables;
    
    // Properties
    public static System.Collections.Generic.List<CircleTouchable> touchables { get; }
    
    // Methods
    public CircleTouchable()
    {
        this.TouchCircleScaleFactor = 1f;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this.CirclePivotDisplacement = val_1;
        mem[1152921511059283872] = val_1.y;
        mem[1152921511059283876] = val_1.z;
    }
    public static System.Collections.Generic.List<CircleTouchable> get_touchables()
    {
        System.Collections.Generic.List<CircleTouchable> val_2;
        System.Collections.Generic.List<CircleTouchable> val_3 = CircleTouchable.allTouchables;
        if(val_3 != null)
        {
                return val_3;
        }
        
        System.Collections.Generic.List<CircleTouchable> val_1 = null;
        val_2 = val_1;
        val_1 = new System.Collections.Generic.List<CircleTouchable>();
        CircleTouchable.allTouchables = val_2;
        val_3 = CircleTouchable.allTouchables;
        return val_3;
    }
    private void Awake()
    {
        CircleTouchable.touchables.Add(item:  this);
    }
    private void OnDestroy()
    {
        bool val_2 = CircleTouchable.touchables.Remove(item:  this);
    }

}
