using UnityEngine;

namespace SA.IOSNative.Gestures
{
    public class ForceTouch : Singleton<SA.IOSNative.Gestures.ForceTouch>
    {
        // Fields
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private System.Action OnForceTouchStarted;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private System.Action OnForceTouchFinished;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private System.Action<SA.IOSNative.Gestures.ForceInfo> OnForceChanged;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private System.Action<string> OnAppShortcutClick;
        private static bool _IsTouchTrigerred;
        private static System.Action <>f__am$cache0;
        private static System.Action <>f__am$cache1;
        private static System.Action<SA.IOSNative.Gestures.ForceInfo> <>f__am$cache2;
        private static System.Action<string> <>f__am$cache3;
        
        // Properties
        public static string AppOpenshortcutItem { get; }
        
        // Methods
        public ForceTouch()
        {
            var val_5;
            IntPtr val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            val_5 = null;
            val_5 = null;
            if((SA.IOSNative.Gestures.ForceTouch.<>f__am$cache0) == null)
            {
                    val_6 = static System.Void SA.IOSNative.Gestures.ForceTouch::<OnForceTouchStarted>m__0();
                val_7 = null;
                val_7 = null;
                SA.IOSNative.Gestures.ForceTouch.<>f__am$cache0 = new System.Action(object:  0, method:  val_6);
                val_5 = null;
            }
            
            val_5 = null;
            this.OnForceTouchStarted = SA.IOSNative.Gestures.ForceTouch.<>f__am$cache0;
            val_8 = null;
            if((SA.IOSNative.Gestures.ForceTouch.<>f__am$cache1) == null)
            {
                    val_6 = static System.Void SA.IOSNative.Gestures.ForceTouch::<OnForceTouchFinished>m__1();
                val_9 = null;
                val_9 = null;
                SA.IOSNative.Gestures.ForceTouch.<>f__am$cache1 = new System.Action(object:  0, method:  val_6);
                val_8 = null;
            }
            
            val_8 = null;
            this.OnForceTouchFinished = SA.IOSNative.Gestures.ForceTouch.<>f__am$cache1;
            val_10 = null;
            if((SA.IOSNative.Gestures.ForceTouch.<>f__am$cache2) == null)
            {
                    val_6 = static System.Void SA.IOSNative.Gestures.ForceTouch::<OnForceChanged>m__2(SA.IOSNative.Gestures.ForceInfo );
                val_11 = null;
                val_11 = null;
                SA.IOSNative.Gestures.ForceTouch.<>f__am$cache2 = new System.Action<SA.IOSNative.Gestures.ForceInfo>(object:  0, method:  val_6);
                val_10 = null;
            }
            
            val_10 = null;
            this.OnForceChanged = SA.IOSNative.Gestures.ForceTouch.<>f__am$cache2;
            val_12 = null;
            if((SA.IOSNative.Gestures.ForceTouch.<>f__am$cache3) == null)
            {
                    val_6 = static System.Void SA.IOSNative.Gestures.ForceTouch::<OnAppShortcutClick>m__3(string );
                val_13 = null;
                val_13 = null;
                SA.IOSNative.Gestures.ForceTouch.<>f__am$cache3 = new System.Action<System.String>(object:  0, method:  val_6);
                val_12 = null;
            }
            
            val_12 = null;
            this.OnAppShortcutClick = SA.IOSNative.Gestures.ForceTouch.<>f__am$cache3;
        }
        public void add_OnForceTouchStarted(System.Action value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnForceTouchStarted);
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
            while(1152921510344756088 != this.OnForceTouchStarted);
        
        }
        public void remove_OnForceTouchStarted(System.Action value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnForceTouchStarted);
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
            while(1152921510344892664 != this.OnForceTouchStarted);
        
        }
        public void add_OnForceTouchFinished(System.Action value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnForceTouchFinished);
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
            while(1152921510345029248 != this.OnForceTouchFinished);
        
        }
        public void remove_OnForceTouchFinished(System.Action value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnForceTouchFinished);
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
            while(1152921510345165824 != this.OnForceTouchFinished);
        
        }
        public void add_OnForceChanged(System.Action<SA.IOSNative.Gestures.ForceInfo> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnForceChanged);
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
            while(1152921510345302408 != this.OnForceChanged);
        
        }
        public void remove_OnForceChanged(System.Action<SA.IOSNative.Gestures.ForceInfo> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnForceChanged);
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
            while(1152921510345438984 != this.OnForceChanged);
        
        }
        public void add_OnAppShortcutClick(System.Action<string> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnAppShortcutClick);
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
            while(1152921510345575568 != this.OnAppShortcutClick);
        
        }
        public void remove_OnAppShortcutClick(System.Action<string> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnAppShortcutClick);
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
            while(1152921510345712144 != this.OnAppShortcutClick);
        
        }
        private void Awake()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            UnityEngine.Object.DontDestroyOnLoad(target:  0);
        }
        public void Setup(float forceTouchDelay, float baseForceTouchPressure, float triggeringForceTouchPressure)
        {
        
        }
        public static string get_AppOpenshortcutItem()
        {
            null = null;
            return (string)System.String.Empty;
        }
        private void didStartForce(string array)
        {
            null = null;
            SA.IOSNative.Gestures.ForceTouch._IsTouchTrigerred = true;
            this.OnForceTouchStarted.Invoke();
        }
        private void didForceChanged(string array)
        {
            null = null;
            if(SA.IOSNative.Gestures.ForceTouch._IsTouchTrigerred == false)
            {
                    return;
            }
            
            typeof(System.Char[]).__il2cppRuntimeField_20 = 124;
            System.String[] val_1 = array.Split(separator:  null);
            string val_5 = val_1[0];
            string val_6 = val_1[1];
            typeof(SA.IOSNative.Gestures.ForceInfo).__il2cppRuntimeField_10 = System.Convert.ToSingle(value:  0);
            typeof(SA.IOSNative.Gestures.ForceInfo).__il2cppRuntimeField_14 = System.Convert.ToSingle(value:  0);
            this.OnForceChanged.Invoke(obj:  new System.Object());
        }
        private void didForceEnded(string array)
        {
            null = null;
            SA.IOSNative.Gestures.ForceTouch._IsTouchTrigerred = false;
            this.OnForceTouchFinished.Invoke();
        }
        private void performActionForShortcutItem(string action)
        {
            this.OnAppShortcutClick.Invoke(obj:  action);
        }
        private static ForceTouch()
        {
        
        }
        private static void <OnForceTouchStarted>m__0()
        {
        
        }
        private static void <OnForceTouchFinished>m__1()
        {
        
        }
        private static void <OnForceChanged>m__2(SA.IOSNative.Gestures.ForceInfo )
        {
        
        }
        private static void <OnAppShortcutClick>m__3(string )
        {
        
        }
    
    }

}
