using UnityEngine;
public class ISN_GestureRecognizer : Singleton<ISN_GestureRecognizer>
{
    // Fields
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private System.Action<ISN_SwipeDirection> OnSwipe;
    private static System.Action<ISN_SwipeDirection> <>f__am$cache0;
    
    // Methods
    public ISN_GestureRecognizer()
    {
        if((ISN_GestureRecognizer.<>f__am$cache0) == null)
        {
                ISN_GestureRecognizer.<>f__am$cache0 = new System.Action<ISN_SwipeDirection>(object:  0, method:  static System.Void ISN_GestureRecognizer::<OnSwipe>m__0(ISN_SwipeDirection ));
            null = null;
        }
        
        this.OnSwipe = ISN_GestureRecognizer.<>f__am$cache0;
    }
    public void add_OnSwipe(System.Action<ISN_SwipeDirection> value)
    {
        var val_3;
        do
        {
            System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnSwipe);
            val_3 = 0;
            if(val_1 != null)
        {
                val_3 = val_1;
            if(null != null)
        {
                val_3 = 0;
        }
        
        }
        
        }
        while(1152921510347489016 != this.OnSwipe);
    
    }
    public void remove_OnSwipe(System.Action<ISN_SwipeDirection> value)
    {
        var val_3;
        do
        {
            System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnSwipe);
            val_3 = 0;
            if(val_1 != null)
        {
                val_3 = val_1;
            if(null != null)
        {
                val_3 = 0;
        }
        
        }
        
        }
        while(1152921510347625592 != this.OnSwipe);
    
    }
    private void Awake()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        UnityEngine.Object.DontDestroyOnLoad(target:  0);
    }
    private void OnSwipeAction(string data)
    {
        this.OnSwipe.Invoke(obj:  System.Convert.ToInt32(value:  0));
    }
    private static void <OnSwipe>m__0(ISN_SwipeDirection )
    {
    
    }

}
