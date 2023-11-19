using UnityEngine;

namespace SA.Common.Animation
{
    public class ValuesTween : MonoBehaviour
    {
        // Fields
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private System.Action OnComplete;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private System.Action<float> OnValueChanged;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private System.Action<UnityEngine.Vector3> OnVectorValueChanged;
        public bool DestoryGameObjectOnComplete;
        private float FinalFloatValue;
        private UnityEngine.Vector3 FinalVectorValue;
        private static System.Action <>f__am$cache0;
        private static System.Action<float> <>f__am$cache1;
        private static System.Action<UnityEngine.Vector3> <>f__am$cache2;
        
        // Methods
        public ValuesTween()
        {
            var val_4;
            System.Action val_5;
            val_4 = null;
            if((SA.Common.Animation.ValuesTween.<>f__am$cache0) == null)
            {
                    System.Action val_1 = null;
                val_5 = val_1;
                val_1 = new System.Action(object:  0, method:  static System.Void SA.Common.Animation.ValuesTween::<OnComplete>m__0());
                SA.Common.Animation.ValuesTween.<>f__am$cache0 = val_5;
                val_4 = null;
            }
            
            this.OnComplete = SA.Common.Animation.ValuesTween.<>f__am$cache0;
            if((SA.Common.Animation.ValuesTween.<>f__am$cache1) == null)
            {
                    System.Action<System.Single> val_2 = null;
                val_5 = val_2;
                val_2 = new System.Action<System.Single>(object:  0, method:  static System.Void SA.Common.Animation.ValuesTween::<OnValueChanged>m__1(float ));
                SA.Common.Animation.ValuesTween.<>f__am$cache1 = val_5;
            }
            
            this.OnValueChanged = SA.Common.Animation.ValuesTween.<>f__am$cache1;
            if((SA.Common.Animation.ValuesTween.<>f__am$cache2) == null)
            {
                    System.Action<UnityEngine.Vector3> val_3 = null;
                val_5 = val_3;
                val_3 = new System.Action<UnityEngine.Vector3>(object:  0, method:  static System.Void SA.Common.Animation.ValuesTween::<OnVectorValueChanged>m__2(UnityEngine.Vector3 ));
                SA.Common.Animation.ValuesTween.<>f__am$cache2 = val_5;
            }
            
            this.DestoryGameObjectOnComplete = true;
            this.OnVectorValueChanged = SA.Common.Animation.ValuesTween.<>f__am$cache2;
        }
        public void add_OnComplete(System.Action value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnComplete);
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
            while(1152921510409183560 != this.OnComplete);
        
        }
        public void remove_OnComplete(System.Action value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnComplete);
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
            while(1152921510409320136 != this.OnComplete);
        
        }
        public void add_OnValueChanged(System.Action<float> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnValueChanged);
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
            while(1152921510409456720 != this.OnValueChanged);
        
        }
        public void remove_OnValueChanged(System.Action<float> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnValueChanged);
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
            while(1152921510409593296 != this.OnValueChanged);
        
        }
        public void add_OnVectorValueChanged(System.Action<UnityEngine.Vector3> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnVectorValueChanged);
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
            while(1152921510409729880 != this.OnVectorValueChanged);
        
        }
        public void remove_OnVectorValueChanged(System.Action<UnityEngine.Vector3> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnVectorValueChanged);
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
            while(1152921510409866456 != this.OnVectorValueChanged);
        
        }
        public static SA.Common.Animation.ValuesTween Create()
        {
            UnityEngine.GameObject val_1 = new UnityEngine.GameObject(name:  "SA.Common.Animation.ValuesTween");
            if(null != 0)
            {
                    return AddComponent<SA.Common.Animation.ValuesTween>();
            }
            
            return AddComponent<SA.Common.Animation.ValuesTween>();
        }
        private void Update()
        {
            UnityEngine.Vector3 val_2 = this.transform.position;
            this.OnValueChanged.Invoke(obj:  val_2.x);
            UnityEngine.Vector3 val_4 = this.transform.position;
            this.OnVectorValueChanged.Invoke(obj:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        }
        public void ValueTo(float from, float to, float time, SA.Common.Animation.EaseType easeType = 21)
        {
            UnityEngine.Vector3 val_2 = this.transform.position;
            this.transform.position = new UnityEngine.Vector3() {x = from, y = val_2.y, z = val_2.z};
            this.FinalFloatValue = to;
            typeof(System.Object[]).__il2cppRuntimeField_20 = "x";
            typeof(System.Object[]).__il2cppRuntimeField_28 = to;
            typeof(System.Object[]).__il2cppRuntimeField_2C = 268435457;
            typeof(System.Object[]).__il2cppRuntimeField_30 = "time";
            typeof(System.Object[]).__il2cppRuntimeField_38 = time;
            typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
            typeof(System.Object[]).__il2cppRuntimeField_40 = "easeType";
            UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = from, y = val_2.y, z = val_2.z});
            typeof(System.Object[]).__il2cppRuntimeField_48 = easeType.ToString();
            typeof(System.Object[]).__il2cppRuntimeField_50 = "oncomplete";
            typeof(System.Object[]).__il2cppRuntimeField_58 = "onTweenComplete";
            typeof(System.Object[]).__il2cppRuntimeField_60 = "oncompletetarget";
            typeof(System.Object[]).__il2cppRuntimeField_68 = this.gameObject;
            SA.Common.Animation.SA_iTween.MoveTo(target:  SA.Common.Animation.SA_iTween.Hash(args:  null), args:  this.gameObject);
        }
        public void VectorTo(UnityEngine.Vector3 from, UnityEngine.Vector3 to, float time, SA.Common.Animation.EaseType easeType = 21)
        {
            this.transform.position = new UnityEngine.Vector3() {x = from.x, y = from.y, z = from.z};
            this.FinalVectorValue = to;
            mem[1152921510410483148] = to.y;
            mem[1152921510410483152] = to.z;
            typeof(System.Object[]).__il2cppRuntimeField_20 = "position";
            typeof(System.Object[]).__il2cppRuntimeField_28 = to;
            typeof(System.Object[]).__il2cppRuntimeField_30 = "time";
            typeof(System.Object[]).__il2cppRuntimeField_38 = time;
            typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
            typeof(System.Object[]).__il2cppRuntimeField_40 = "easeType";
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = from.x, y = from.y, z = from.z});
            typeof(System.Object[]).__il2cppRuntimeField_48 = easeType.ToString();
            typeof(System.Object[]).__il2cppRuntimeField_50 = "oncomplete";
            typeof(System.Object[]).__il2cppRuntimeField_58 = "onTweenComplete";
            typeof(System.Object[]).__il2cppRuntimeField_60 = "oncompletetarget";
            typeof(System.Object[]).__il2cppRuntimeField_68 = this.gameObject;
            SA.Common.Animation.SA_iTween.MoveTo(target:  SA.Common.Animation.SA_iTween.Hash(args:  null), args:  this.gameObject);
        }
        public void ScaleTo(UnityEngine.Vector3 from, UnityEngine.Vector3 to, float time, SA.Common.Animation.EaseType easeType = 21)
        {
            this.transform.localScale = new UnityEngine.Vector3() {x = from.x, y = from.y, z = from.z};
            this.FinalVectorValue = to;
            mem[1152921510410671004] = to.y;
            mem[1152921510410671008] = to.z;
            typeof(System.Object[]).__il2cppRuntimeField_20 = "scale";
            typeof(System.Object[]).__il2cppRuntimeField_28 = to;
            typeof(System.Object[]).__il2cppRuntimeField_30 = "time";
            typeof(System.Object[]).__il2cppRuntimeField_38 = time;
            typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
            typeof(System.Object[]).__il2cppRuntimeField_40 = "easeType";
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = from.x, y = from.y, z = from.z});
            typeof(System.Object[]).__il2cppRuntimeField_48 = easeType.ToString();
            typeof(System.Object[]).__il2cppRuntimeField_50 = "oncomplete";
            typeof(System.Object[]).__il2cppRuntimeField_58 = "onTweenComplete";
            typeof(System.Object[]).__il2cppRuntimeField_60 = "oncompletetarget";
            typeof(System.Object[]).__il2cppRuntimeField_68 = this.gameObject;
            SA.Common.Animation.SA_iTween.ScaleTo(target:  SA.Common.Animation.SA_iTween.Hash(args:  null), args:  this.gameObject);
        }
        public void VectorToS(UnityEngine.Vector3 from, UnityEngine.Vector3 to, float speed, SA.Common.Animation.EaseType easeType = 21)
        {
            this.transform.position = new UnityEngine.Vector3() {x = from.x, y = from.y, z = from.z};
            this.FinalVectorValue = to;
            mem[1152921510410858860] = to.y;
            mem[1152921510410858864] = to.z;
            typeof(System.Object[]).__il2cppRuntimeField_20 = "position";
            typeof(System.Object[]).__il2cppRuntimeField_28 = to;
            typeof(System.Object[]).__il2cppRuntimeField_30 = "speed";
            typeof(System.Object[]).__il2cppRuntimeField_38 = speed;
            typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
            typeof(System.Object[]).__il2cppRuntimeField_40 = "easeType";
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = from.x, y = from.y, z = from.z});
            typeof(System.Object[]).__il2cppRuntimeField_48 = easeType.ToString();
            typeof(System.Object[]).__il2cppRuntimeField_50 = "oncomplete";
            typeof(System.Object[]).__il2cppRuntimeField_58 = "onTweenComplete";
            typeof(System.Object[]).__il2cppRuntimeField_60 = "oncompletetarget";
            typeof(System.Object[]).__il2cppRuntimeField_68 = this.gameObject;
            SA.Common.Animation.SA_iTween.MoveTo(target:  SA.Common.Animation.SA_iTween.Hash(args:  null), args:  this.gameObject);
        }
        public void Stop()
        {
            UnityEngine.GameObject val_3;
            UnityEngine.GameObject val_1 = this.gameObject;
            val_3 = null;
            SA.Common.Animation.SA_iTween.Stop(target:  val_3);
            UnityEngine.GameObject val_2 = this.gameObject;
            UnityEngine.Object.Destroy(obj:  0);
        }
        private void onTweenComplete()
        {
            this.OnValueChanged.Invoke(obj:  this.FinalFloatValue);
            this.OnVectorValueChanged.Invoke(obj:  new UnityEngine.Vector3() {x = this.FinalVectorValue, y = V9.16B, z = V10.16B});
            this.OnComplete.Invoke();
            if(this.DestoryGameObjectOnComplete != false)
            {
                    this = this.gameObject;
            }
            
            UnityEngine.Object.Destroy(obj:  0);
        }
        private static void <OnComplete>m__0()
        {
        
        }
        private static void <OnValueChanged>m__1(float )
        {
        
        }
        private static void <OnVectorValueChanged>m__2(UnityEngine.Vector3 )
        {
        
        }
    
    }

}
