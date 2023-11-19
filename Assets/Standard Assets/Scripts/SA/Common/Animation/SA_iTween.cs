using UnityEngine;

namespace SA.Common.Animation
{
    public class SA_iTween : MonoBehaviour
    {
        // Fields
        public static System.Collections.Generic.List<System.Collections.Hashtable> tweens;
        private static UnityEngine.GameObject cameraFade;
        public string id;
        public string type;
        public string method;
        public SA.Common.Animation.EaseType easeType;
        public float time;
        public float delay;
        public SA.Common.Animation.SA_iTween.LoopType loopType;
        public bool isRunning;
        public bool isPaused;
        public string _name;
        private float runningTime;
        private float percentage;
        private float delayStarted;
        private bool kinematic;
        private bool isLocal;
        private bool loop;
        private bool reverse;
        private bool wasPaused;
        private bool physics;
        private System.Collections.Hashtable tweenArguments;
        private UnityEngine.Space space;
        private SA.Common.Animation.SA_iTween.EasingFunction ease;
        private SA.Common.Animation.SA_iTween.ApplyTween apply;
        private UnityEngine.AudioSource audioSource;
        private UnityEngine.Vector3[] vector3s;
        private UnityEngine.Vector2[] vector2s;
        private UnityEngine.Color[,] colors;
        private float[] floats;
        private UnityEngine.Rect[] rects;
        private SA.Common.Animation.SA_iTween.CRSpline path;
        private UnityEngine.Vector3 preUpdate;
        private UnityEngine.Vector3 postUpdate;
        private SA.Common.Animation.SA_iTween.NamedValueColor namedcolorvalue;
        private float lastRealTime;
        private bool useRealTime;
        private UnityEngine.Transform thisTransform;
        private static System.Collections.Generic.Dictionary<string, int> <>f__switch$map2;
        
        // Methods
        private SA_iTween(System.Collections.Hashtable h)
        {
            this.tweenArguments = h;
        }
        public static void Init(UnityEngine.GameObject target)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            SA.Common.Animation.SA_iTween.MoveBy(target:  null, amount:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, time:  0f);
        }
        public static void CameraFadeFrom(float amount, float time)
        {
            null = null;
            if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
            {
                    typeof(System.Object[]).__il2cppRuntimeField_20 = "amount";
                typeof(System.Object[]).__il2cppRuntimeField_28 = amount;
                typeof(System.Object[]).__il2cppRuntimeField_2C = 268435457;
                typeof(System.Object[]).__il2cppRuntimeField_30 = "time";
                typeof(System.Object[]).__il2cppRuntimeField_38 = time;
                typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
                SA.Common.Animation.SA_iTween.CameraFadeFrom(args:  SA.Common.Animation.SA_iTween.Hash(args:  null));
                return;
            }
            
            UnityEngine.Debug.LogError(message:  0);
        }
        public static void CameraFadeFrom(System.Collections.Hashtable args)
        {
            var val_2;
            UnityEngine.GameObject val_3;
            val_2 = null;
            val_2 = null;
            if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
            {
                    val_3 = null;
                val_3 = null;
                SA.Common.Animation.SA_iTween.ColorFrom(target:  val_3, args:  SA.Common.Animation.SA_iTween.cameraFade);
                return;
            }
            
            UnityEngine.Debug.LogError(message:  0);
        }
        public static void CameraFadeTo(float amount, float time)
        {
            null = null;
            if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
            {
                    typeof(System.Object[]).__il2cppRuntimeField_20 = "amount";
                typeof(System.Object[]).__il2cppRuntimeField_28 = amount;
                typeof(System.Object[]).__il2cppRuntimeField_2C = 268435457;
                typeof(System.Object[]).__il2cppRuntimeField_30 = "time";
                typeof(System.Object[]).__il2cppRuntimeField_38 = time;
                typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
                SA.Common.Animation.SA_iTween.CameraFadeTo(args:  SA.Common.Animation.SA_iTween.Hash(args:  null));
                return;
            }
            
            UnityEngine.Debug.LogError(message:  0);
        }
        public static void CameraFadeTo(System.Collections.Hashtable args)
        {
            var val_2;
            UnityEngine.GameObject val_3;
            val_2 = null;
            val_2 = null;
            if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
            {
                    val_3 = null;
                val_3 = null;
                SA.Common.Animation.SA_iTween.ColorTo(target:  val_3, args:  SA.Common.Animation.SA_iTween.cameraFade);
                return;
            }
            
            UnityEngine.Debug.LogError(message:  0);
        }
        public static void ValueTo(UnityEngine.GameObject target, System.Collections.Hashtable args)
        {
            var val_14;
            var val_15;
            object val_16;
            var val_17;
            var val_19;
            System.Collections.Hashtable val_1 = SA.Common.Animation.SA_iTween.CleanArgs(args:  null);
            if((((val_1 & 1) == 0) || ((val_1 & 1) == 0)) || (((val_1 & 1) & 1) == 0))
            {
                goto label_6;
            }
            
            if(val_1.GetType() == (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                goto label_11;
            }
            
            if(val_1.GetType() == (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                goto label_16;
            }
            
            if(val_1.GetType() == (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                goto label_21;
            }
            
            if(val_1.GetType() == (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                goto label_26;
            }
            
            val_14 = val_1.GetType();
            if(val_14 == (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                goto label_30;
            }
            
            val_15 = "iTween Error: ValueTo() only works with interpolating Vector3s, Vector2s, floats, ints, Rects and Colors!";
            val_16 = 0;
            goto label_33;
            label_6:
            val_15 = "iTween Error: ValueTo() requires an \'onupdate\' callback function and a \'from\' and \'to\' property.  The supplied \'onupdate\' callback must accept a single argument that is the same type as the supplied \'from\' and \'to\' properties!";
            val_16 = 0;
            label_33:
            UnityEngine.Debug.LogError(message:  val_16);
            return;
            label_11:
            val_17 = "method";
            val_19 = "vector2";
            goto label_39;
            label_16:
            val_17 = "method";
            val_19 = "vector3";
            goto label_39;
            label_21:
            val_17 = "method";
            val_19 = "rect";
            goto label_39;
            label_26:
            val_17 = "method";
            val_19 = "float";
            goto label_39;
            label_30:
            val_17 = "method";
            val_19 = "color";
            label_39:
            System.Collections.Hashtable val_13 = val_1 & 1;
            SA.Common.Animation.SA_iTween.Launch(target:  null, args:  args);
        }
        public static void FadeFrom(UnityEngine.GameObject target, float alpha, float time)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = "alpha";
            typeof(System.Object[]).__il2cppRuntimeField_28 = alpha;
            typeof(System.Object[]).__il2cppRuntimeField_2C = 268435457;
            typeof(System.Object[]).__il2cppRuntimeField_30 = "time";
            typeof(System.Object[]).__il2cppRuntimeField_38 = time;
            typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
            SA.Common.Animation.SA_iTween.FadeFrom(target:  SA.Common.Animation.SA_iTween.Hash(args:  null), args:  X1);
        }
        public static void FadeFrom(UnityEngine.GameObject target, System.Collections.Hashtable args)
        {
            SA.Common.Animation.SA_iTween.ColorFrom(target:  null, args:  args);
        }
        public static void FadeTo(UnityEngine.GameObject target, float alpha, float time)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = "alpha";
            typeof(System.Object[]).__il2cppRuntimeField_28 = alpha;
            typeof(System.Object[]).__il2cppRuntimeField_2C = 268435457;
            typeof(System.Object[]).__il2cppRuntimeField_30 = "time";
            typeof(System.Object[]).__il2cppRuntimeField_38 = time;
            typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
            SA.Common.Animation.SA_iTween.FadeTo(target:  SA.Common.Animation.SA_iTween.Hash(args:  null), args:  X1);
        }
        public static void FadeTo(UnityEngine.GameObject target, System.Collections.Hashtable args)
        {
            SA.Common.Animation.SA_iTween.ColorTo(target:  null, args:  args);
        }
        public static void ColorFrom(UnityEngine.GameObject target, UnityEngine.Color color, float time)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = "color";
            typeof(System.Object[]).__il2cppRuntimeField_28 = color;
            typeof(System.Object[]).__il2cppRuntimeField_30 = "time";
            typeof(System.Object[]).__il2cppRuntimeField_38 = time;
            typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
            SA.Common.Animation.SA_iTween.ColorFrom(target:  SA.Common.Animation.SA_iTween.Hash(args:  null), args:  X1);
        }
        public static void ColorFrom(UnityEngine.GameObject target, System.Collections.Hashtable args)
        {
            var val_45;
            var val_48;
            var val_49;
            var val_50;
            var val_51;
            var val_53;
            float val_56;
            float val_57;
            float val_58;
            float val_59;
            var val_60;
            var val_61;
            var val_62;
            var val_63;
            var val_64;
            var val_65;
            System.Collections.Hashtable val_1 = SA.Common.Animation.SA_iTween.CleanArgs(args:  null);
            if((val_1 & 1) == 0)
            {
                goto label_4;
            }
            
            val_45 = null;
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            if(null == null)
            {
                goto label_41;
            }
            
            label_4:
            System.Collections.IEnumerator val_4 = args.transform.GetEnumerator();
            label_33:
            var val_45 = 0;
            val_45 = val_45 + 1;
            val_48 = val_4;
            if(((val_4 & 1) & 1) == 0)
            {
                goto label_101;
            }
            
            var val_46 = 0;
            val_46 = val_46 + 1;
            val_49 = val_4;
            val_50 = val_4;
            val_50 = 0;
            val_51 = val_1;
            val_51 = 0;
            goto label_33;
            label_101:
            if(val_4 != null)
            {
                    var val_47 = 0;
                val_47 = val_47 + 1;
                val_53 = val_4;
            }
            
            label_41:
            System.Collections.Hashtable val_14 = val_1 & 1;
            UnityEngine.Renderer val_15 = args.GetComponent<UnityEngine.Renderer>();
            if((UnityEngine.Object.op_Implicit(exists:  0)) == false)
            {
                goto label_48;
            }
            
            UnityEngine.Color val_19 = args.GetComponent<UnityEngine.Renderer>().material.color;
            goto label_51;
            label_48:
            UnityEngine.Light val_20 = args.GetComponent<UnityEngine.Light>();
            if((UnityEngine.Object.op_Implicit(exists:  0)) == false)
            {
                goto label_54;
            }
            
            UnityEngine.Color val_23 = args.GetComponent<UnityEngine.Light>().color;
            label_51:
            val_56 = val_23.r;
            val_57 = val_23.g;
            val_58 = val_23.b;
            val_59 = val_23.a;
            goto label_57;
            label_54:
            val_56 = 0f;
            val_57 = val_56;
            val_58 = val_56;
            val_59 = val_56;
            label_57:
            if((val_1 & 1) != 0)
            {
                    val_45 = null;
                UnityEngine.Vector2 val_24 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y});
            }
            else
            {
                    val_60 = val_56;
                if((val_1 & 1) != 0)
            {
                    val_45 = null;
                UnityEngine.Vector2 val_25 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y});
            }
            
                val_61 = val_57;
                if((val_1 & 1) != 0)
            {
                    val_45 = null;
                UnityEngine.Vector2 val_26 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y});
            }
            
                val_62 = val_58;
                if((val_1 & 1) != 0)
            {
                    val_45 = null;
                UnityEngine.Vector2 val_27 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y});
            }
            
                if((val_1 & 1) != 0)
            {
                    val_45 = null;
                UnityEngine.Vector2 val_28 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y});
            }
            else
            {
                    val_63 = val_59;
            }
            
            }
            
            val_64 = "amount";
            if((val_1 & 1) != 0)
            {
                    val_65 = val_1;
            }
            
            val_64 = "alpha";
            if((val_1 & 1) != 0)
            {
                    val_65 = val_1;
                val_45 = null;
                UnityEngine.Vector2 val_30 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y});
            }
            
            UnityEngine.Renderer val_31 = args.GetComponent<UnityEngine.Renderer>();
            if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
            {
                    args.GetComponent<UnityEngine.Renderer>().material.color = new UnityEngine.Color() {r = 1.626636E-38f, g = 1.626636E-38f, b = 1.626636E-38f, a = 1.626636E-38f};
            }
            else
            {
                    UnityEngine.Light val_35 = args.GetComponent<UnityEngine.Light>();
                if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
            {
                    args.GetComponent<UnityEngine.Light>().color = new UnityEngine.Color() {r = 1.626636E-38f, g = 1.626636E-38f, b = 1.626636E-38f, a = 1.626636E-38f};
            }
            
            }
            
            if(val_1 != null)
            {
                
            }
            
            SA.Common.Animation.SA_iTween.Launch(target:  null, args:  args);
        }
        public static void ColorTo(UnityEngine.GameObject target, UnityEngine.Color color, float time)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = "color";
            typeof(System.Object[]).__il2cppRuntimeField_28 = color;
            typeof(System.Object[]).__il2cppRuntimeField_30 = "time";
            typeof(System.Object[]).__il2cppRuntimeField_38 = time;
            typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
            SA.Common.Animation.SA_iTween.ColorTo(target:  SA.Common.Animation.SA_iTween.Hash(args:  null), args:  X1);
        }
        public static void ColorTo(UnityEngine.GameObject target, System.Collections.Hashtable args)
        {
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            var val_21;
            System.Collections.Hashtable val_1 = SA.Common.Animation.SA_iTween.CleanArgs(args:  null);
            if((val_1 & 1) == 0)
            {
                goto label_4;
            }
            
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            if(null == null)
            {
                goto label_41;
            }
            
            label_4:
            System.Collections.IEnumerator val_4 = args.transform.GetEnumerator();
            label_33:
            var val_16 = 0;
            val_16 = val_16 + 1;
            val_16 = val_4;
            if(((val_4 & 1) & 1) == 0)
            {
                goto label_46;
            }
            
            var val_17 = 0;
            val_17 = val_17 + 1;
            val_17 = val_4;
            val_18 = val_4;
            val_18 = 0;
            val_19 = val_1;
            val_19 = 0;
            goto label_33;
            label_46:
            if(val_4 != null)
            {
                    var val_18 = 0;
                val_18 = val_18 + 1;
                val_21 = val_4;
            }
            
            label_41:
            if(((val_1 & 1) & 1) == 0)
            {
                
            }
            
            SA.Common.Animation.SA_iTween.Launch(target:  null, args:  args);
        }
        public static void AudioFrom(UnityEngine.GameObject target, float volume, float pitch, float time)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = "volume";
            typeof(System.Object[]).__il2cppRuntimeField_28 = volume;
            typeof(System.Object[]).__il2cppRuntimeField_2C = 268435457;
            typeof(System.Object[]).__il2cppRuntimeField_30 = "pitch";
            typeof(System.Object[]).__il2cppRuntimeField_38 = pitch;
            typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
            typeof(System.Object[]).__il2cppRuntimeField_40 = "time";
            typeof(System.Object[]).__il2cppRuntimeField_48 = time;
            typeof(System.Object[]).__il2cppRuntimeField_4C = 268435457;
            SA.Common.Animation.SA_iTween.AudioFrom(target:  SA.Common.Animation.SA_iTween.Hash(args:  null), args:  X1);
        }
        public static void AudioFrom(UnityEngine.GameObject target, System.Collections.Hashtable args)
        {
            var val_14;
            float val_15;
            var val_16;
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            System.Collections.Hashtable val_1 = SA.Common.Animation.SA_iTween.CleanArgs(args:  null);
            if((val_1 & 1) == 0)
            {
                goto label_4;
            }
            
            val_14 = val_1;
            if(val_14 != null)
            {
                    if(null == null)
            {
                goto label_6;
            }
            
            }
            
            val_14 = 0;
            goto label_13;
            label_4:
            UnityEngine.AudioSource val_3 = args.GetComponent<UnityEngine.AudioSource>();
            if((UnityEngine.Object.op_Implicit(exists:  0)) == false)
            {
                goto label_11;
            }
            
            val_14 = args.GetComponent<UnityEngine.AudioSource>();
            if(val_14 == null)
            {
                goto label_13;
            }
            
            label_6:
            val_15 = val_14.volume;
            val_16 = 0;
            goto label_14;
            label_13:
            val_15 = val_14.volume;
            val_16 = 1;
            label_14:
            float val_8 = val_14.pitch;
            val_18 = val_15;
            if((val_1 & 1) != 0)
            {
                    val_19 = val_1;
                val_20 = null;
                UnityEngine.Vector2 val_9 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_8});
            }
            
            val_21 = val_8;
            if((val_1 & 1) != 0)
            {
                    val_19 = val_1;
                val_20 = null;
                UnityEngine.Vector2 val_10 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y});
            }
            
            if((val_16 & 1) != 0)
            {
                    val_14.volume = 1.626636E-38f;
            }
            else
            {
                    val_14.volume = 1.626636E-38f;
            }
            
            val_14.pitch = 1.626636E-38f;
            System.Collections.Hashtable val_11 = val_1 & 1;
            SA.Common.Animation.SA_iTween.Launch(target:  null, args:  args);
            return;
            label_11:
            UnityEngine.Debug.LogError(message:  0);
            return;
            label_30:
            goto label_30;
        }
        public static void AudioTo(UnityEngine.GameObject target, float volume, float pitch, float time)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = "volume";
            typeof(System.Object[]).__il2cppRuntimeField_28 = volume;
            typeof(System.Object[]).__il2cppRuntimeField_2C = 268435457;
            typeof(System.Object[]).__il2cppRuntimeField_30 = "pitch";
            typeof(System.Object[]).__il2cppRuntimeField_38 = pitch;
            typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
            typeof(System.Object[]).__il2cppRuntimeField_40 = "time";
            typeof(System.Object[]).__il2cppRuntimeField_48 = time;
            typeof(System.Object[]).__il2cppRuntimeField_4C = 268435457;
            SA.Common.Animation.SA_iTween.AudioTo(target:  SA.Common.Animation.SA_iTween.Hash(args:  null), args:  X1);
        }
        public static void AudioTo(UnityEngine.GameObject target, System.Collections.Hashtable args)
        {
            System.Collections.Hashtable val_2 = (SA.Common.Animation.SA_iTween.CleanArgs(args:  null)) & 1;
            SA.Common.Animation.SA_iTween.Launch(target:  null, args:  args);
        }
        public static void Stab(UnityEngine.GameObject target, UnityEngine.AudioClip audioclip, float delay)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = "audioclip";
            typeof(System.Object[]).__il2cppRuntimeField_28 = X2;
            typeof(System.Object[]).__il2cppRuntimeField_30 = "delay";
            typeof(System.Object[]).__il2cppRuntimeField_38 = delay;
            typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
            SA.Common.Animation.SA_iTween.Stab(target:  SA.Common.Animation.SA_iTween.Hash(args:  null), args:  audioclip);
        }
        public static void Stab(UnityEngine.GameObject target, System.Collections.Hashtable args)
        {
            SA.Common.Animation.SA_iTween.Launch(target:  SA.Common.Animation.SA_iTween.CleanArgs(args:  null), args:  args);
        }
        public static void LookFrom(UnityEngine.GameObject target, UnityEngine.Vector3 looktarget, float time)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = "looktarget";
            typeof(System.Object[]).__il2cppRuntimeField_28 = looktarget;
            typeof(System.Object[]).__il2cppRuntimeField_30 = "time";
            typeof(System.Object[]).__il2cppRuntimeField_38 = time;
            typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
            SA.Common.Animation.SA_iTween.LookFrom(target:  SA.Common.Animation.SA_iTween.Hash(args:  null), args:  X1);
        }
        public static void LookFrom(UnityEngine.GameObject target, System.Collections.Hashtable args)
        {
            float val_10;
            float val_32;
            float val_33;
            var val_34;
            var val_35;
            float val_40;
            float val_41;
            UnityEngine.Vector3 val_42;
            var val_43;
            var val_44;
            UnityEngine.Transform val_45;
            var val_46;
            var val_47;
            float val_48;
            float val_49;
            float val_50;
            var val_51;
            System.Collections.Hashtable val_1 = SA.Common.Animation.SA_iTween.CleanArgs(args:  null);
            UnityEngine.Vector3 val_3 = args.transform.eulerAngles;
            val_32 = val_3.x;
            val_33 = val_3.z;
            val_34 = "looktarget";
            if(val_1.GetType() == (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                goto label_9;
            }
            
            if(val_1.GetType() != (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                goto label_40;
            }
            
            val_35 = null;
            val_34 = null;
            UnityEngine.Vector2 val_11 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_10, y = val_3.y, z = val_3.z});
            if((0 & 1) == 0)
            {
                goto label_22;
            }
            
            val_41 = val_32;
            val_42 = val_11.x;
            val_43 = val_11.y;
            val_44 = val_3.z;
            goto label_23;
            label_9:
            val_45 = val_1;
            val_34;
            if(val_45 != null)
            {
                    val_35 = val_45;
            }
            
            val_35 = 0;
            if((0 & 1) != 0)
            {
                    val_42 = val_10;
                val_46 = val_3.y;
                val_40 = val_3.z;
                val_45 = val_35;
            }
            else
            {
                    val_45 = 0;
                val_34 = 1152921504852160512;
                val_47 = null;
                val_47 = null;
                val_42 = SA_iTween.Defaults.up;
            }
            
            val_48 = val_42;
            val_49 = SA_iTween.Defaults.time.__il2cppRuntimeField_4C;
            val_50 = SA_iTween.Defaults.time.__il2cppRuntimeField_50;
            args.transform.LookAt(target:  val_45, worldUp:  new UnityEngine.Vector3() {x = val_48, y = val_49, z = val_50});
            goto label_40;
            label_22:
            UnityEngine.Vector2 val_18 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_3.z});
            val_51 = null;
            val_41 = val_32;
            val_42 = SA_iTween.Defaults.up;
            label_23:
            val_48 = 1.626636E-38f;
            val_49 = V13.16B;
            val_50 = V11.16B;
            args.transform.LookAt(worldPosition:  new UnityEngine.Vector3() {x = val_48, y = val_49, z = val_50}, worldUp:  new UnityEngine.Vector3() {x = val_42, y = SA_iTween.Defaults.time.__il2cppRuntimeField_4C, z = SA_iTween.Defaults.time.__il2cppRuntimeField_50});
            val_32 = ;
            val_33 = val_33;
            label_40:
            if((val_1 & 1) == 0)
            {
                goto label_48;
            }
            
            UnityEngine.Vector3 val_20 = args.transform.eulerAngles;
            val_40 = val_20.z;
            if(val_1 != null)
            {
                    if(null == null)
            {
                goto label_53;
            }
            
            }
            
            val_42 = val_20.y;
            label_69:
            val_32 = val_32;
            args.transform.eulerAngles = new UnityEngine.Vector3() {x = val_20.x, y = val_42, z = val_40};
            val_33 = val_33;
            label_48:
            if(val_1 != null)
            {
                
            }
            
            SA.Common.Animation.SA_iTween.Launch(target:  null, args:  args);
            return;
            label_53:
            if(((System.String.op_Equality(a:  0, b:  val_1)) == true) || ((System.String.op_Equality(a:  0, b:  val_1)) == true))
            {
                goto label_69;
            }
            
            bool val_27 = System.String.op_Equality(a:  0, b:  val_1);
            var val_28 = (val_27 != true) ? val_3.y : val_20.y;
            var val_29 = (val_27 != true) ? (val_32) : val_20.x;
            goto label_69;
            label_75:
            goto label_75;
        }
        public static void LookTo(UnityEngine.GameObject target, UnityEngine.Vector3 looktarget, float time)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = "looktarget";
            typeof(System.Object[]).__il2cppRuntimeField_28 = looktarget;
            typeof(System.Object[]).__il2cppRuntimeField_30 = "time";
            typeof(System.Object[]).__il2cppRuntimeField_38 = time;
            typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
            SA.Common.Animation.SA_iTween.LookTo(target:  SA.Common.Animation.SA_iTween.Hash(args:  null), args:  X1);
        }
        public static void LookTo(UnityEngine.GameObject target, System.Collections.Hashtable args)
        {
            var val_5;
            var val_16;
            var val_17;
            var val_18;
            System.Collections.Hashtable val_1 = SA.Common.Animation.SA_iTween.CleanArgs(args:  null);
            if((val_1 & 1) != 0)
            {
                    val_16 = val_1.GetType();
                if(val_16 == (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                    UnityEngine.Vector3 val_6 = 0.position;
                UnityEngine.Vector3 val_7 = 0.position;
                val_16 = 0;
                UnityEngine.Vector3 val_8 = val_16.position;
                val_5 = 0;
                if((1 & 1) != 0)
            {
                    UnityEngine.Vector3 val_9 = val_16.eulerAngles;
                val_17 = val_9.x;
                UnityEngine.Vector3 val_10 = val_16.eulerAngles;
                val_18 = val_10.y;
            }
            else
            {
                    UnityEngine.Vector3 val_11 = val_16.eulerAngles;
                val_17 = val_11.x;
                UnityEngine.Vector3 val_12 = val_16.eulerAngles;
                val_18 = val_12.y;
            }
            
                UnityEngine.Vector3 val_13 = val_16.eulerAngles;
            }
            
            }
            
            if(val_1 != null)
            {
                
            }
            
            SA.Common.Animation.SA_iTween.Launch(target:  null, args:  args);
        }
        public static void MoveTo(UnityEngine.GameObject target, UnityEngine.Vector3 position, float time)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = "position";
            typeof(System.Object[]).__il2cppRuntimeField_28 = position;
            typeof(System.Object[]).__il2cppRuntimeField_30 = "time";
            typeof(System.Object[]).__il2cppRuntimeField_38 = time;
            typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
            SA.Common.Animation.SA_iTween.MoveTo(target:  SA.Common.Animation.SA_iTween.Hash(args:  null), args:  X1);
        }
        public static void MoveTo(UnityEngine.GameObject target, System.Collections.Hashtable args)
        {
            var val_5;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            var val_25;
            System.Collections.Hashtable val_1 = SA.Common.Animation.SA_iTween.CleanArgs(args:  null);
            if((val_1 & 1) != 0)
            {
                    val_21 = val_1.GetType();
                if(val_21 == (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                    UnityEngine.Vector3 val_6 = 0.position;
                UnityEngine.Vector3 val_7 = 0.position;
                val_21 = 0;
                UnityEngine.Vector3 val_8 = val_21.position;
                val_5 = 0;
                if((1 & 1) != 0)
            {
                    UnityEngine.Vector3 val_9 = val_21.eulerAngles;
                val_22 = val_9.x;
                UnityEngine.Vector3 val_10 = val_21.eulerAngles;
                val_23 = val_10.y;
            }
            else
            {
                    UnityEngine.Vector3 val_11 = val_21.eulerAngles;
                val_22 = val_11.x;
                UnityEngine.Vector3 val_12 = val_21.eulerAngles;
                val_23 = val_12.y;
            }
            
                UnityEngine.Vector3 val_13 = val_21.eulerAngles;
                if((1 & 1) != 0)
            {
                    UnityEngine.Vector3 val_14 = val_21.localScale;
                val_24 = val_14.x;
                UnityEngine.Vector3 val_15 = val_21.localScale;
                val_25 = val_15.y;
            }
            else
            {
                    UnityEngine.Vector3 val_16 = val_21.localScale;
                val_24 = val_16.x;
                UnityEngine.Vector3 val_17 = val_21.localScale;
                val_25 = val_17.y;
            }
            
                UnityEngine.Vector3 val_18 = val_21.localScale;
            }
            
            }
            
            if(val_1 != null)
            {
                
            }
            
            SA.Common.Animation.SA_iTween.Launch(target:  null, args:  args);
        }
        public static void MoveFrom(UnityEngine.GameObject target, UnityEngine.Vector3 position, float time)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = "position";
            typeof(System.Object[]).__il2cppRuntimeField_28 = position;
            typeof(System.Object[]).__il2cppRuntimeField_30 = "time";
            typeof(System.Object[]).__il2cppRuntimeField_38 = time;
            typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
            SA.Common.Animation.SA_iTween.MoveFrom(target:  SA.Common.Animation.SA_iTween.Hash(args:  null), args:  X1);
        }
        public static void MoveFrom(UnityEngine.GameObject target, System.Collections.Hashtable args)
        {
            System.Collections.Hashtable val_42;
            UnityEngine.GameObject val_43;
            var val_44;
            bool val_45;
            var val_46;
            var val_47;
            var val_48;
            var val_49;
            UnityEngine.GameObject val_50;
            var val_51;
            var val_52;
            System.Array val_56;
            var val_57;
            float val_58;
            float val_59;
            var val_60;
            float val_61;
            float val_62;
            float val_63;
            System.Array val_64;
            var val_66;
            var val_67;
            val_42 = args;
            val_43 = 1152921504851894272;
            System.Collections.Hashtable val_1 = SA.Common.Animation.SA_iTween.CleanArgs(args:  null);
            if((val_1 & 1) != 0)
            {
                    val_44 = null;
                val_45 = val_1;
                UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            }
            else
            {
                    val_46 = null;
                val_46 = null;
                val_45 = 1152921504852164632;
            }
            
            val_48 = "path";
            if((val_1 & 1) == 0)
            {
                goto label_11;
            }
            
            if(val_1.GetType() == (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                goto label_16;
            }
            
            if(val_1 == null)
            {
                goto label_17;
            }
            
            val_49 = val_1;
            if(val_49 == null)
            {
                goto label_18;
            }
            
            val_50 = val_43;
            val_51 = 0;
            val_52 = val_49;
            goto label_19;
            label_11:
            UnityEngine.Transform val_5 = val_42.transform;
            if(val_45 == false)
            {
                goto label_22;
            }
            
            UnityEngine.Vector3 val_6 = val_5.localPosition;
            goto label_23;
            label_16:
            if(val_1 == null)
            {
                goto label_24;
            }
            
            val_56 = val_1;
            if(val_56 == null)
            {
                goto label_25;
            }
            
            val_57 = 0;
            goto label_26;
            label_22:
            UnityEngine.Vector3 val_7 = val_5.position;
            label_23:
            val_58 = val_7.x;
            val_59 = val_7.z;
            if((val_1 & 1) == 0)
            {
                goto label_29;
            }
            
            val_48 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            val_60 = val_1;
            if(val_1.GetType() == val_48)
            {
                goto label_34;
            }
            
            val_61 = val_59;
            val_62 = val_7.y;
            val_63 = val_58;
            if(val_60.GetType() != (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                goto label_53;
            }
            
            val_44 = null;
            UnityEngine.Vector2 val_12 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            goto label_53;
            label_29:
            val_63 = val_58;
            if((val_1 & 1) != 0)
            {
                    val_44 = null;
                UnityEngine.Vector2 val_13 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            }
            
            val_62 = val_7.y;
            if((val_1 & 1) != 0)
            {
                    val_44 = null;
                UnityEngine.Vector2 val_14 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_7.z});
            }
            
            if((val_1 & 1) == 0)
            {
                goto label_49;
            }
            
            val_44 = null;
            UnityEngine.Vector2 val_15 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_7.z});
            goto label_53;
            label_49:
            val_61 = val_59;
            goto label_53;
            label_34:
            val_60 = 0;
            UnityEngine.Vector3 val_18 = val_60.position;
            val_63 = val_18.x;
            val_62 = val_18.y;
            val_61 = val_18.z;
            label_53:
            UnityEngine.Transform val_19 = val_42.transform;
            if(val_45 != false)
            {
                    val_19.localPosition = new UnityEngine.Vector3() {x = val_63, y = val_62, z = val_61};
            }
            else
            {
                    val_19.position = new UnityEngine.Vector3() {x = val_63, y = val_62, z = val_61};
            }
            
            val_64 = val_7;
            if(val_1 != null)
            {
                goto label_62;
            }
            
            goto label_62;
            label_18:
            label_17:
            val_50 = val_43;
            val_49 = 0;
            val_52 = 0;
            val_51 = 1;
            label_19:
            val_48 = 7254272;
            val_64 = null;
            val_66 = 0;
            goto label_63;
            label_70:
            bool val_21 = val_64 + (val_45 * 12);
            val_66 = 1;
            (SA_iTween.Defaults.isLocal * 12) + val_64.__unknownFiledOffset_20 = ???;
            (SA_iTween.Defaults.isLocal * 12) + val_64.__unknownFiledOffset_24 = ???;
            (SA_iTween.Defaults.isLocal * 12) + val_64.__unknownFiledOffset_28 = ???;
            label_63:
            val_67 = 7254272;
            if(val_66 >= val_67)
            {
                goto label_65;
            }
            
            if(null == null)
            {
                    val_67 = 7254272;
            }
            
            var val_22 = val_49 + 8;
            UnityEngine.Vector3 val_23 = (val_49 + 8) + 32.position;
            goto label_70;
            label_25:
            label_24:
            val_56 = 0;
            val_57 = 1;
            label_26:
            val_48 = 7254272;
            val_50 = val_43;
            val_64 = null;
            System.Array.Copy(sourceArray:  0, destinationArray:  val_56, length:  1254012752);
            label_65:
            val_43 = val_50;
            val_42 = val_42;
            val_47 = "path";
            UnityEngine.Vector3 val_26 = val_42.transform.position;
            val_58 = val_26.x;
            val_59 = val_26.z;
            var val_42 = 12;
            val_42 = val_64 + ((((-4294967296 + (UnityEngine.Vector3[].__il2cppRuntimeField_namespaze) << 32)) >> 32) * val_42);
            if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = (((-4294967296 + (UnityEngine.Vector3[].__il2cppRuntimeField_namespaze) << 32) >> 32) * 12) + val_64 + 32, y = (((-4294967296 + (UnityEngine.Vector3[].__il2cppRuntimeField_namespaze) << 32) >> 32) * 12) + val_64 + 32 + 4, z = (((-4294967296 + (UnityEngine.Vector3[].__il2cppRuntimeField_namespaze) << 32) >> 32) * 12) + val_64 + 40}, rhs:  new UnityEngine.Vector3() {x = val_58, y = val_26.y, z = val_59})) == false)
            {
                goto label_78;
            }
            
            System.Array.Copy(sourceArray:  0, destinationArray:  val_64, length:  1254012752);
            UnityEngine.Transform val_29 = val_42.transform;
            if(val_45 == false)
            {
                goto label_82;
            }
            
            UnityEngine.Vector3 val_30 = val_29.localPosition;
            val_58 = val_30.x;
            val_59 = val_30.z;
            var val_43 = 12;
            val_43 = null + ((((-4294967296 + (UnityEngine.Vector3[].__il2cppRuntimeField_namespaze) << 32)) >> 32) * val_43);
            mem2[0] = val_58;
            mem2[0] = val_30.y;
            mem2[0] = val_59;
            val_64 = val_42.transform;
            val_64.localPosition = new UnityEngine.Vector3() {x = UnityEngine.Vector3[].__il2cppRuntimeField_byval_arg, y = typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_24, z = UnityEngine.Vector3[].__il2cppRuntimeField_this_arg};
            goto label_87;
            label_78:
            UnityEngine.Transform val_33 = val_42.transform;
            if(val_45 == false)
            {
                goto label_91;
            }
            
            val_33.localPosition = new UnityEngine.Vector3() {x = UnityEngine.Vector3[].__il2cppRuntimeField_byval_arg, y = typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_24, z = UnityEngine.Vector3[].__il2cppRuntimeField_this_arg};
            goto label_92;
            label_82:
            UnityEngine.Vector3 val_34 = val_29.position;
            val_58 = val_34.x;
            val_59 = val_34.z;
            var val_44 = 12;
            val_44 = null + ((((-4294967296 + (UnityEngine.Vector3[].__il2cppRuntimeField_namespaze) << 32)) >> 32) * val_44);
            mem2[0] = val_58;
            mem2[0] = val_34.y;
            mem2[0] = val_59;
            val_64 = val_42.transform;
            val_64.position = new UnityEngine.Vector3() {x = UnityEngine.Vector3[].__il2cppRuntimeField_byval_arg, y = typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_24, z = UnityEngine.Vector3[].__il2cppRuntimeField_this_arg};
            label_87:
            if(val_1 != null)
            {
                goto label_98;
            }
            
            goto label_98;
            label_91:
            val_33.position = new UnityEngine.Vector3() {x = UnityEngine.Vector3[].__il2cppRuntimeField_byval_arg, y = typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_24, z = UnityEngine.Vector3[].__il2cppRuntimeField_this_arg};
            label_92:
            label_62:
            label_98:
            SA.Common.Animation.SA_iTween.Launch(target:  val_43, args:  val_42);
            return;
            label_108:
            goto label_108;
        }
        public static void MoveAdd(UnityEngine.GameObject target, UnityEngine.Vector3 amount, float time)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = "amount";
            typeof(System.Object[]).__il2cppRuntimeField_28 = amount;
            typeof(System.Object[]).__il2cppRuntimeField_30 = "time";
            typeof(System.Object[]).__il2cppRuntimeField_38 = time;
            typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
            SA.Common.Animation.SA_iTween.MoveAdd(target:  SA.Common.Animation.SA_iTween.Hash(args:  null), args:  X1);
        }
        public static void MoveAdd(UnityEngine.GameObject target, System.Collections.Hashtable args)
        {
            SA.Common.Animation.SA_iTween.Launch(target:  SA.Common.Animation.SA_iTween.CleanArgs(args:  null), args:  args);
        }
        public static void MoveBy(UnityEngine.GameObject target, UnityEngine.Vector3 amount, float time)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = "amount";
            typeof(System.Object[]).__il2cppRuntimeField_28 = amount;
            typeof(System.Object[]).__il2cppRuntimeField_30 = "time";
            typeof(System.Object[]).__il2cppRuntimeField_38 = time;
            typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
            SA.Common.Animation.SA_iTween.MoveBy(target:  SA.Common.Animation.SA_iTween.Hash(args:  null), args:  X1);
        }
        public static void MoveBy(UnityEngine.GameObject target, System.Collections.Hashtable args)
        {
            SA.Common.Animation.SA_iTween.Launch(target:  SA.Common.Animation.SA_iTween.CleanArgs(args:  null), args:  args);
        }
        public static void ScaleTo(UnityEngine.GameObject target, UnityEngine.Vector3 scale, float time)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = "scale";
            typeof(System.Object[]).__il2cppRuntimeField_28 = scale;
            typeof(System.Object[]).__il2cppRuntimeField_30 = "time";
            typeof(System.Object[]).__il2cppRuntimeField_38 = time;
            typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
            SA.Common.Animation.SA_iTween.ScaleTo(target:  SA.Common.Animation.SA_iTween.Hash(args:  null), args:  X1);
        }
        public static void ScaleTo(UnityEngine.GameObject target, System.Collections.Hashtable args)
        {
            var val_5;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            var val_25;
            System.Collections.Hashtable val_1 = SA.Common.Animation.SA_iTween.CleanArgs(args:  null);
            if((val_1 & 1) != 0)
            {
                    val_21 = val_1.GetType();
                if(val_21 == (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                    UnityEngine.Vector3 val_6 = 0.position;
                UnityEngine.Vector3 val_7 = 0.position;
                val_21 = 0;
                UnityEngine.Vector3 val_8 = val_21.position;
                val_5 = 0;
                if((1 & 1) != 0)
            {
                    UnityEngine.Vector3 val_9 = val_21.eulerAngles;
                val_22 = val_9.x;
                UnityEngine.Vector3 val_10 = val_21.eulerAngles;
                val_23 = val_10.y;
            }
            else
            {
                    UnityEngine.Vector3 val_11 = val_21.eulerAngles;
                val_22 = val_11.x;
                UnityEngine.Vector3 val_12 = val_21.eulerAngles;
                val_23 = val_12.y;
            }
            
                UnityEngine.Vector3 val_13 = val_21.eulerAngles;
                if((1 & 1) != 0)
            {
                    UnityEngine.Vector3 val_14 = val_21.localScale;
                val_24 = val_14.x;
                UnityEngine.Vector3 val_15 = val_21.localScale;
                val_25 = val_15.y;
            }
            else
            {
                    UnityEngine.Vector3 val_16 = val_21.localScale;
                val_24 = val_16.x;
                UnityEngine.Vector3 val_17 = val_21.localScale;
                val_25 = val_17.y;
            }
            
                UnityEngine.Vector3 val_18 = val_21.localScale;
            }
            
            }
            
            if(val_1 != null)
            {
                
            }
            
            SA.Common.Animation.SA_iTween.Launch(target:  null, args:  args);
        }
        public static void ScaleFrom(UnityEngine.GameObject target, UnityEngine.Vector3 scale, float time)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = "scale";
            typeof(System.Object[]).__il2cppRuntimeField_28 = scale;
            typeof(System.Object[]).__il2cppRuntimeField_30 = "time";
            typeof(System.Object[]).__il2cppRuntimeField_38 = time;
            typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
            SA.Common.Animation.SA_iTween.ScaleFrom(target:  SA.Common.Animation.SA_iTween.Hash(args:  null), args:  X1);
        }
        public static void ScaleFrom(UnityEngine.GameObject target, System.Collections.Hashtable args)
        {
            var val_23;
            float val_24;
            float val_25;
            float val_26;
            var val_27;
            System.Collections.Hashtable val_1 = SA.Common.Animation.SA_iTween.CleanArgs(args:  null);
            UnityEngine.Vector3 val_3 = args.transform.localScale;
            if((val_1 & 1) == 0)
            {
                goto label_7;
            }
            
            val_23 = val_1;
            if(val_1.GetType() == (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                goto label_12;
            }
            
            val_24 = val_3.z;
            val_25 = val_3.y;
            val_26 = val_3.x;
            if(val_23.GetType() != (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                goto label_31;
            }
            
            val_27 = null;
            UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            goto label_31;
            label_7:
            val_26 = val_3.x;
            if((val_1 & 1) != 0)
            {
                    val_27 = null;
                UnityEngine.Vector2 val_9 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            }
            
            val_25 = val_3.y;
            if((val_1 & 1) != 0)
            {
                    val_27 = null;
                UnityEngine.Vector2 val_10 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_3.z});
            }
            
            if((val_1 & 1) == 0)
            {
                goto label_27;
            }
            
            val_27 = null;
            UnityEngine.Vector2 val_11 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_3.z});
            goto label_31;
            label_27:
            val_24 = val_3.z;
            goto label_31;
            label_12:
            val_23 = 0;
            UnityEngine.Vector3 val_14 = val_23.localScale;
            val_26 = val_14.x;
            val_25 = val_14.y;
            val_24 = val_14.z;
            label_31:
            args.transform.localScale = new UnityEngine.Vector3() {x = val_26, y = val_25, z = val_24};
            if(val_1 != null)
            {
                
            }
            
            SA.Common.Animation.SA_iTween.Launch(target:  null, args:  args);
            return;
            label_45:
            goto label_45;
        }
        public static void ScaleAdd(UnityEngine.GameObject target, UnityEngine.Vector3 amount, float time)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = "amount";
            typeof(System.Object[]).__il2cppRuntimeField_28 = amount;
            typeof(System.Object[]).__il2cppRuntimeField_30 = "time";
            typeof(System.Object[]).__il2cppRuntimeField_38 = time;
            typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
            SA.Common.Animation.SA_iTween.ScaleAdd(target:  SA.Common.Animation.SA_iTween.Hash(args:  null), args:  X1);
        }
        public static void ScaleAdd(UnityEngine.GameObject target, System.Collections.Hashtable args)
        {
            SA.Common.Animation.SA_iTween.Launch(target:  SA.Common.Animation.SA_iTween.CleanArgs(args:  null), args:  args);
        }
        public static void ScaleBy(UnityEngine.GameObject target, UnityEngine.Vector3 amount, float time)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = "amount";
            typeof(System.Object[]).__il2cppRuntimeField_28 = amount;
            typeof(System.Object[]).__il2cppRuntimeField_30 = "time";
            typeof(System.Object[]).__il2cppRuntimeField_38 = time;
            typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
            SA.Common.Animation.SA_iTween.ScaleBy(target:  SA.Common.Animation.SA_iTween.Hash(args:  null), args:  X1);
        }
        public static void ScaleBy(UnityEngine.GameObject target, System.Collections.Hashtable args)
        {
            SA.Common.Animation.SA_iTween.Launch(target:  SA.Common.Animation.SA_iTween.CleanArgs(args:  null), args:  args);
        }
        public static void RotateTo(UnityEngine.GameObject target, UnityEngine.Vector3 rotation, float time)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = "rotation";
            typeof(System.Object[]).__il2cppRuntimeField_28 = rotation;
            typeof(System.Object[]).__il2cppRuntimeField_30 = "time";
            typeof(System.Object[]).__il2cppRuntimeField_38 = time;
            typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
            SA.Common.Animation.SA_iTween.RotateTo(target:  SA.Common.Animation.SA_iTween.Hash(args:  null), args:  X1);
        }
        public static void RotateTo(UnityEngine.GameObject target, System.Collections.Hashtable args)
        {
            var val_5;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            var val_25;
            System.Collections.Hashtable val_1 = SA.Common.Animation.SA_iTween.CleanArgs(args:  null);
            if((val_1 & 1) != 0)
            {
                    val_21 = val_1.GetType();
                if(val_21 == (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                    UnityEngine.Vector3 val_6 = 0.position;
                UnityEngine.Vector3 val_7 = 0.position;
                val_21 = 0;
                UnityEngine.Vector3 val_8 = val_21.position;
                val_5 = 0;
                if((1 & 1) != 0)
            {
                    UnityEngine.Vector3 val_9 = val_21.eulerAngles;
                val_22 = val_9.x;
                UnityEngine.Vector3 val_10 = val_21.eulerAngles;
                val_23 = val_10.y;
            }
            else
            {
                    UnityEngine.Vector3 val_11 = val_21.eulerAngles;
                val_22 = val_11.x;
                UnityEngine.Vector3 val_12 = val_21.eulerAngles;
                val_23 = val_12.y;
            }
            
                UnityEngine.Vector3 val_13 = val_21.eulerAngles;
                if((1 & 1) != 0)
            {
                    UnityEngine.Vector3 val_14 = val_21.localScale;
                val_24 = val_14.x;
                UnityEngine.Vector3 val_15 = val_21.localScale;
                val_25 = val_15.y;
            }
            else
            {
                    UnityEngine.Vector3 val_16 = val_21.localScale;
                val_24 = val_16.x;
                UnityEngine.Vector3 val_17 = val_21.localScale;
                val_25 = val_17.y;
            }
            
                UnityEngine.Vector3 val_18 = val_21.localScale;
            }
            
            }
            
            if(val_1 != null)
            {
                
            }
            
            SA.Common.Animation.SA_iTween.Launch(target:  null, args:  args);
        }
        public static void RotateFrom(UnityEngine.GameObject target, UnityEngine.Vector3 rotation, float time)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = "rotation";
            typeof(System.Object[]).__il2cppRuntimeField_28 = rotation;
            typeof(System.Object[]).__il2cppRuntimeField_30 = "time";
            typeof(System.Object[]).__il2cppRuntimeField_38 = time;
            typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
            SA.Common.Animation.SA_iTween.RotateFrom(target:  SA.Common.Animation.SA_iTween.Hash(args:  null), args:  X1);
        }
        public static void RotateFrom(UnityEngine.GameObject target, System.Collections.Hashtable args)
        {
            var val_23;
            var val_24;
            var val_25;
            var val_29;
            float val_30;
            float val_31;
            float val_32;
            System.Collections.Hashtable val_1 = SA.Common.Animation.SA_iTween.CleanArgs(args:  null);
            if((val_1 & 1) != 0)
            {
                    val_23 = null;
                val_24 = val_1;
                UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            }
            else
            {
                    val_25 = null;
                val_25 = null;
                val_24 = 1152921504852164632;
            }
            
            UnityEngine.Transform val_3 = args.transform;
            if(val_24 != false)
            {
                    UnityEngine.Vector3 val_4 = val_3.localEulerAngles;
            }
            else
            {
                    UnityEngine.Vector3 val_5 = val_3.eulerAngles;
            }
            
            if((val_1 & 1) == 0)
            {
                goto label_16;
            }
            
            val_29 = val_1;
            if(val_1.GetType() == (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                goto label_21;
            }
            
            val_30 = val_5.z;
            val_31 = val_5.y;
            val_32 = val_5.x;
            if(val_29.GetType() != (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                goto label_40;
            }
            
            val_23 = null;
            UnityEngine.Vector2 val_10 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            goto label_40;
            label_16:
            val_32 = val_5.x;
            if((val_1 & 1) != 0)
            {
                    val_23 = null;
                UnityEngine.Vector2 val_11 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            }
            
            val_31 = val_5.y;
            if((val_1 & 1) != 0)
            {
                    val_23 = null;
                UnityEngine.Vector2 val_12 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_5.z});
            }
            
            if((val_1 & 1) == 0)
            {
                goto label_36;
            }
            
            val_23 = null;
            UnityEngine.Vector2 val_13 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_5.z});
            goto label_40;
            label_36:
            val_30 = val_5.z;
            goto label_40;
            label_21:
            val_29 = 0;
            UnityEngine.Vector3 val_16 = val_29.eulerAngles;
            val_32 = val_16.x;
            val_31 = val_16.y;
            val_30 = val_16.z;
            label_40:
            UnityEngine.Transform val_17 = args.transform;
            if(val_24 != false)
            {
                    val_17.localEulerAngles = new UnityEngine.Vector3() {x = val_32, y = val_31, z = val_30};
            }
            else
            {
                    val_17.eulerAngles = new UnityEngine.Vector3() {x = val_32, y = val_31, z = val_30};
            }
            
            if(val_1 != null)
            {
                
            }
            
            SA.Common.Animation.SA_iTween.Launch(target:  null, args:  args);
            return;
            label_57:
            goto label_57;
        }
        public static void RotateAdd(UnityEngine.GameObject target, UnityEngine.Vector3 amount, float time)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = "amount";
            typeof(System.Object[]).__il2cppRuntimeField_28 = amount;
            typeof(System.Object[]).__il2cppRuntimeField_30 = "time";
            typeof(System.Object[]).__il2cppRuntimeField_38 = time;
            typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
            SA.Common.Animation.SA_iTween.RotateAdd(target:  SA.Common.Animation.SA_iTween.Hash(args:  null), args:  X1);
        }
        public static void RotateAdd(UnityEngine.GameObject target, System.Collections.Hashtable args)
        {
            SA.Common.Animation.SA_iTween.Launch(target:  SA.Common.Animation.SA_iTween.CleanArgs(args:  null), args:  args);
        }
        public static void RotateBy(UnityEngine.GameObject target, UnityEngine.Vector3 amount, float time)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = "amount";
            typeof(System.Object[]).__il2cppRuntimeField_28 = amount;
            typeof(System.Object[]).__il2cppRuntimeField_30 = "time";
            typeof(System.Object[]).__il2cppRuntimeField_38 = time;
            typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
            SA.Common.Animation.SA_iTween.RotateBy(target:  SA.Common.Animation.SA_iTween.Hash(args:  null), args:  X1);
        }
        public static void RotateBy(UnityEngine.GameObject target, System.Collections.Hashtable args)
        {
            SA.Common.Animation.SA_iTween.Launch(target:  SA.Common.Animation.SA_iTween.CleanArgs(args:  null), args:  args);
        }
        public static void ShakePosition(UnityEngine.GameObject target, UnityEngine.Vector3 amount, float time)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = "amount";
            typeof(System.Object[]).__il2cppRuntimeField_28 = amount;
            typeof(System.Object[]).__il2cppRuntimeField_30 = "time";
            typeof(System.Object[]).__il2cppRuntimeField_38 = time;
            typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
            SA.Common.Animation.SA_iTween.ShakePosition(target:  SA.Common.Animation.SA_iTween.Hash(args:  null), args:  X1);
        }
        public static void ShakePosition(UnityEngine.GameObject target, System.Collections.Hashtable args)
        {
            SA.Common.Animation.SA_iTween.Launch(target:  SA.Common.Animation.SA_iTween.CleanArgs(args:  null), args:  args);
        }
        public static void ShakeScale(UnityEngine.GameObject target, UnityEngine.Vector3 amount, float time)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = "amount";
            typeof(System.Object[]).__il2cppRuntimeField_28 = amount;
            typeof(System.Object[]).__il2cppRuntimeField_30 = "time";
            typeof(System.Object[]).__il2cppRuntimeField_38 = time;
            typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
            SA.Common.Animation.SA_iTween.ShakeScale(target:  SA.Common.Animation.SA_iTween.Hash(args:  null), args:  X1);
        }
        public static void ShakeScale(UnityEngine.GameObject target, System.Collections.Hashtable args)
        {
            SA.Common.Animation.SA_iTween.Launch(target:  SA.Common.Animation.SA_iTween.CleanArgs(args:  null), args:  args);
        }
        public static void ShakeRotation(UnityEngine.GameObject target, UnityEngine.Vector3 amount, float time)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = "amount";
            typeof(System.Object[]).__il2cppRuntimeField_28 = amount;
            typeof(System.Object[]).__il2cppRuntimeField_30 = "time";
            typeof(System.Object[]).__il2cppRuntimeField_38 = time;
            typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
            SA.Common.Animation.SA_iTween.ShakeRotation(target:  SA.Common.Animation.SA_iTween.Hash(args:  null), args:  X1);
        }
        public static void ShakeRotation(UnityEngine.GameObject target, System.Collections.Hashtable args)
        {
            SA.Common.Animation.SA_iTween.Launch(target:  SA.Common.Animation.SA_iTween.CleanArgs(args:  null), args:  args);
        }
        public static void PunchPosition(UnityEngine.GameObject target, UnityEngine.Vector3 amount, float time)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = "amount";
            typeof(System.Object[]).__il2cppRuntimeField_28 = amount;
            typeof(System.Object[]).__il2cppRuntimeField_30 = "time";
            typeof(System.Object[]).__il2cppRuntimeField_38 = time;
            typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
            SA.Common.Animation.SA_iTween.PunchPosition(target:  SA.Common.Animation.SA_iTween.Hash(args:  null), args:  X1);
        }
        public static void PunchPosition(UnityEngine.GameObject target, System.Collections.Hashtable args)
        {
            SA.Common.Animation.SA_iTween.Launch(target:  SA.Common.Animation.SA_iTween.CleanArgs(args:  null), args:  args);
        }
        public static void PunchRotation(UnityEngine.GameObject target, UnityEngine.Vector3 amount, float time)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = "amount";
            typeof(System.Object[]).__il2cppRuntimeField_28 = amount;
            typeof(System.Object[]).__il2cppRuntimeField_30 = "time";
            typeof(System.Object[]).__il2cppRuntimeField_38 = time;
            typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
            SA.Common.Animation.SA_iTween.PunchRotation(target:  SA.Common.Animation.SA_iTween.Hash(args:  null), args:  X1);
        }
        public static void PunchRotation(UnityEngine.GameObject target, System.Collections.Hashtable args)
        {
            SA.Common.Animation.SA_iTween.Launch(target:  SA.Common.Animation.SA_iTween.CleanArgs(args:  null), args:  args);
        }
        public static void PunchScale(UnityEngine.GameObject target, UnityEngine.Vector3 amount, float time)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = "amount";
            typeof(System.Object[]).__il2cppRuntimeField_28 = amount;
            typeof(System.Object[]).__il2cppRuntimeField_30 = "time";
            typeof(System.Object[]).__il2cppRuntimeField_38 = time;
            typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
            SA.Common.Animation.SA_iTween.PunchScale(target:  SA.Common.Animation.SA_iTween.Hash(args:  null), args:  X1);
        }
        public static void PunchScale(UnityEngine.GameObject target, System.Collections.Hashtable args)
        {
            SA.Common.Animation.SA_iTween.Launch(target:  SA.Common.Animation.SA_iTween.CleanArgs(args:  null), args:  args);
        }
        private void GenerateTargets()
        {
            var val_48;
            var val_49;
            var val_50;
            System.Collections.Generic.Dictionary<System.String, System.Int32> val_51;
            int val_2 = 0;
            if(this.type == null)
            {
                    return;
            }
            
            val_48 = null;
            val_48 = null;
            if((SA.Common.Animation.SA_iTween.<>f__switch$map2) == null)
            {
                    if(null != 0)
            {
                    val_49 = 1152921510153291024;
                Add(key:  "value", value:  0);
                Add(key:  "color", value:  1);
                Add(key:  "audio", value:  2);
                Add(key:  "move", value:  3);
                Add(key:  "scale", value:  4);
                Add(key:  "rotate", value:  5);
                Add(key:  "shake", value:  6);
                Add(key:  "punch", value:  7);
                Add(key:  "look", value:  8);
            }
            else
            {
                    val_49 = 1152921510153291024;
                Add(key:  "value", value:  0);
                Add(key:  "color", value:  1);
                Add(key:  "audio", value:  2);
                Add(key:  "move", value:  3);
                Add(key:  "scale", value:  4);
                Add(key:  "rotate", value:  5);
                Add(key:  "shake", value:  6);
                Add(key:  "punch", value:  7);
                Add(key:  "look", value:  8);
            }
            
                Add(key:  "stab", value:  9);
                val_50 = null;
                val_50 = null;
                SA.Common.Animation.SA_iTween.<>f__switch$map2 = new System.Collections.Generic.Dictionary<System.String, System.Int32>(capacity:  10);
                val_48 = null;
            }
            
            val_48 = null;
            val_51 = SA.Common.Animation.SA_iTween.<>f__switch$map2;
            if((TryGetValue(key:  this.type, value: out  val_2)) == false)
            {
                    return;
            }
            
            var val_4 = (val_2 < 10) ? 11 : 0;
            val_4 = val_4 - 11;
            if(val_4 > 9)
            {
                    return;
            }
            
            var val_48 = 25975896 + ((val_2 < 0xA ? 11 : 0 - 11)) << 2;
            val_48 = val_48 + 25975896;
            goto (25975896 + ((val_2 < 0xA ? 11 : 0 - 11)) << 2 + 25975896);
        }
        private void GenerateRectTargets()
        {
            this.rects = null;
            UnityEngine.Rect[].__il2cppRuntimeField_byval_arg.__il2cppRuntimeField_FFFFFFFFFFFFFFFF = null;
            mem2[0] = null;
        }
        private void GenerateColorTargets()
        {
            this.colors = null;
            UnityEngine.Color[,].__il2cppRuntimeField_byval_arg.__il2cppRuntimeField_FFFFFFFFFFFFFFFF = null;
            mem2[0] = null;
        }
        private void GenerateVector3Targets()
        {
            var val_9;
            var val_12;
            var val_13;
            UnityEngine.Vector3[] val_14;
            this.vector3s = null;
            val_9 = 0;
            UnityEngine.Vector3[].__il2cppRuntimeField_byval_arg.__il2cppRuntimeField_8 = UnityEngine.Vector3.__il2cppRuntimeField_element_class;
            UnityEngine.Vector3[].__il2cppRuntimeField_byval_arg.__il2cppRuntimeField_FFFFFFFFFFFFFFFF = null;
            val_12 = 0;
            mem2[0] = UnityEngine.Vector3.__il2cppRuntimeField_element_class;
            mem2[0] = null;
            val_13 = "speed";
            if((this.tweenArguments & 1) == 0)
            {
                    return;
            }
            
            val_14 = this.vector3s;
            if(this.vector3s == null)
            {
                    val_14 = this.vector3s;
                if(val_14 == null)
            {
                    val_14 = 0;
            }
            
            }
            
            UnityEngine.Vector3 val_10 = this.vector3s[0];
            UnityEngine.Vector3 val_11 = this.vector3s[0];
            float val_5 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = this.vector3s[0], y = val_10, z = val_11}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 5.142877E-39f});
            val_13 = this.tweenArguments;
            UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_5, y = val_10, z = val_11});
            this.time = System.Math.Abs(val_5) / null;
            return;
            label_25:
            goto label_25;
        }
        private void GenerateVector2Targets()
        {
            UnityEngine.Vector2[] val_9;
            var val_10;
            var val_11;
            val_9 = null;
            this.vector2s = val_9;
            val_10 = this.tweenArguments;
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_20 = null;
            val_9 = this.tweenArguments;
            val_10 = null;
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y});
            this.vector2s[1] = new UnityEngine.Vector2();
            val_11 = "speed";
            if((this.tweenArguments & 1) == 0)
            {
                    return;
            }
            
            UnityEngine.Vector2 val_9 = this.vector2s[0];
            UnityEngine.Vector2 val_10 = this.vector2s[0];
            UnityEngine.Vector2 val_11 = this.vector2s[1];
            UnityEngine.Vector2 val_12 = this.vector2s[1];
            float val_3 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_11 = this.tweenArguments;
            val_9 = null;
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_3, y = 0f, z = 0f});
            this.time = System.Math.Abs(val_3) / null;
        }
        private void GenerateFloatTargets()
        {
            System.Single[] val_9;
            var val_10;
            var val_11;
            val_9 = null;
            this.floats = val_9;
            val_10 = this.tweenArguments;
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            typeof(System.Single[]).__il2cppRuntimeField_20 = null;
            val_9 = this.tweenArguments;
            val_10 = null;
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y});
            this.floats[1] = null;
            val_11 = "speed";
            if((this.tweenArguments & 1) == 0)
            {
                    return;
            }
            
            val_9 = null;
            val_11 = this.tweenArguments;
            float val_3 = this.floats[0] - this.floats[1];
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_3, y = val_2.y});
            this.time = System.Math.Abs(val_3) / null;
        }
        private void GenerateColorToTargets()
        {
            var val_49;
            var val_50;
            UnityEngine.Color[,] val_51;
            var val_55;
            var val_60;
            var val_64;
            val_49 = this;
            val_50 = 1152921509754282240;
            UnityEngine.Renderer val_1 = this.GetComponent<UnityEngine.Renderer>();
            if((UnityEngine.Object.op_Implicit(exists:  0)) == false)
            {
                goto label_3;
            }
            
            val_51 = 0;
            this.colors = null;
            goto label_6;
            label_28:
            UnityEngine.Color val_5 = X21.GetColor(name:  X23);
            var val_6 = X28 + 553891968;
            mem2[0] = val_5.r;
            mem2[0] = val_5.g;
            mem2[0] = val_5.b;
            mem2[0] = val_5.a;
            val_50 = 1152921509754282240;
            val_51 = 1;
            val_49 = this.GetComponent<UnityEngine.Renderer>().materials;
            label_6:
            val_55 = val_49.GetComponent<UnityEngine.Renderer>().materials;
            if(val_51 >= val_8.Length)
            {
                goto label_39;
            }
            
            UnityEngine.Vector2 val_13 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_5.r, y = val_5.g, z = val_5.b});
            mem2[0] = null;
            UnityEngine.Color val_14 = val_49.GetComponent<UnityEngine.Renderer>().materials[1].GetColor(name:  this.namedcolorvalue.ToString());
            UnityEngine.Material val_15 = val_49[16] + (((val_8.Length + 16 * 1)) << 4);
            mem2[0] = val_14.r;
            mem2[0] = val_14.g;
            mem2[0] = val_14.b;
            mem2[0] = val_14.a;
            UnityEngine.Material val_51 = val_49[16];
            var val_53 = 1;
            string val_18 = this.namedcolorvalue.ToString();
            val_53 = val_53 + (((val_8.Length + 16) * 1) * 1);
            UnityEngine.Vector2 val_19 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_14.r, y = val_14.g, z = val_14.b});
            mem2[0] = null;
            if((val_49.GetComponent<UnityEngine.Renderer>().materials[1]) != null)
            {
                goto label_28;
            }
            
            goto label_28;
            label_3:
            val_55 = 1152921510423027296;
            UnityEngine.Light val_20 = this.GetComponent<UnityEngine.Light>();
            if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
            {
                    this.colors = null;
                val_55 = this.GetComponent<UnityEngine.Light>();
                UnityEngine.Color val_23 = val_55.color;
                this.colors[1] = val_23;
                this.colors[1] = val_23.g;
                this.colors[1] = val_23.b;
                this.colors[1] = val_23.a;
                typeof(UnityEngine.Color[,]).__il2cppRuntimeField_20 = val_23.r;
                typeof(UnityEngine.Color[,]).__il2cppRuntimeField_24 = val_23.g;
                typeof(UnityEngine.Color[,]).__il2cppRuntimeField_28 = val_23.b;
                typeof(UnityEngine.Color[,]).__il2cppRuntimeField_2C = val_23.a;
            }
            else
            {
                    this.colors = null;
            }
            
            label_39:
            if((this.tweenArguments & 1) == 0)
            {
                goto label_41;
            }
            
            val_60 = 0;
            goto label_42;
            label_52:
            var val_24 = X25 + ((X26) << 4);
            val_60 = 1;
            mem2[0] = null;
            label_42:
            if(val_60 >= (this.colors.GetLength(dimension:  0)))
            {
                goto label_90;
            }
            
            long val_54 = 1;
            val_54 = ((X25 + (X26) << 4) + 48 + 16) * val_54;
            if(this.tweenArguments != null)
            {
                goto label_52;
            }
            
            goto label_52;
            label_41:
            if((this.tweenArguments & 1) != 0)
            {
                    val_60 = 0;
                if( < (this.colors.GetLength(dimension:  0)))
            {
                    val_51 = this.colors;
                val_55 = this.tweenArguments;
            }
            
            }
            
            if((this.tweenArguments & 1) != 0)
            {
                    val_60 = 0;
                if( < (this.colors.GetLength(dimension:  0)))
            {
                    val_51 = this.colors;
                val_64 = 1;
                val_55 = this.tweenArguments;
            }
            
            }
            
            if((this.tweenArguments & 1) != 0)
            {
                    val_60 = 0;
                if( < (this.colors.GetLength(dimension:  0)))
            {
                    val_51 = this.colors;
                val_64 = 1;
                val_55 = this.tweenArguments;
            }
            
            }
            
            if((this.tweenArguments & 1) != 0)
            {
                    val_60 = 0;
                if( < (this.colors.GetLength(dimension:  0)))
            {
                    val_51 = this.colors;
                val_64 = 1;
                val_55 = this.tweenArguments;
            }
            
            }
            
            label_90:
            if((this.tweenArguments & 1) != 0)
            {
                    val_60 = 0;
                if( >= (this.colors.GetLength(dimension:  0)))
            {
                    return;
            }
            
                val_51 = this.colors;
                val_64 = 1;
                val_55 = this.tweenArguments;
            }
            
            if((this.tweenArguments & 1) == 0)
            {
                    return;
            }
            
            val_60 = 0;
            if( >= (this.colors.GetLength(dimension:  0)))
            {
                    return;
            }
            
            val_51 = this.colors;
            val_64 = 1;
            val_55 = this.tweenArguments;
        }
        private void GenerateAudioToTargets()
        {
            var val_12;
            var val_13;
            UnityEngine.Vector2[] val_14;
            UnityEngine.Vector2[] val_16;
            var val_17;
            val_12 = this;
            this.vector2s = null;
            if((this.tweenArguments & 1) == 0)
            {
                goto label_2;
            }
            
            val_13 = this.tweenArguments;
            if(val_13 != null)
            {
                    if(null == null)
            {
                goto label_6;
            }
            
            }
            
            val_13 = 0;
            goto label_6;
            label_2:
            UnityEngine.AudioSource val_2 = this.GetComponent<UnityEngine.AudioSource>();
            if((UnityEngine.Object.op_Implicit(exists:  0)) == false)
            {
                goto label_9;
            }
            
            label_6:
            this.audioSource = this.GetComponent<UnityEngine.AudioSource>();
            goto label_10;
            label_9:
            UnityEngine.Debug.LogError(message:  0);
            this.Dispose();
            label_10:
            val_14 = this.vector2s;
            if(this.vector2s == null)
            {
                    val_14 = this.vector2s;
                if(val_14 == null)
            {
                    val_14 = 0;
            }
            
            }
            
            float val_5 = this.audioSource.volume;
            float val_6 = this.audioSource.pitch;
            CinemachineFreeLook.Orbit val_7 = new CinemachineFreeLook.Orbit(h:  val_5, r:  val_6);
            mem[40] = val_7.m_Height;
            this.vector2s[0] = val_7.m_Height;
            val_16 = "volume";
            if((this.tweenArguments & 1) != 0)
            {
                    val_17 = this.tweenArguments;
                val_16 = null;
                UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_5, y = val_6});
                this.vector2s[1] = new UnityEngine.Vector2();
            }
            
            if((this.tweenArguments & 1) == 0)
            {
                    return;
            }
            
            val_16 = this.vector2s;
            val_12 = this.tweenArguments;
            val_17 = null;
            UnityEngine.Vector2 val_9 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y});
            val_16[1] = new UnityEngine.Vector2();
            return;
            label_34:
            goto label_34;
        }
        private void GenerateStabTargets()
        {
            UnityEngine.AudioSource val_17;
            UnityEngine.AudioSource val_18;
            UnityEngine.AudioClip val_19;
            var val_20;
            if((this.tweenArguments & 1) == 0)
            {
                goto label_2;
            }
            
            val_17 = this.tweenArguments;
            if(val_17 == null)
            {
                goto label_4;
            }
            
            if(null == null)
            {
                goto label_5;
            }
            
            label_4:
            val_17 = 0;
            label_5:
            val_18 = this;
            this.audioSource = val_17;
            goto label_10;
            label_2:
            UnityEngine.AudioSource val_2 = this.GetComponent<UnityEngine.AudioSource>();
            if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
            {
                    val_17 = this.GetComponent<UnityEngine.AudioSource>();
                val_18 = this.audioSource;
                this.audioSource = val_17;
            }
            else
            {
                    UnityEngine.AudioSource val_6 = this.gameObject.AddComponent<UnityEngine.AudioSource>();
                UnityEngine.AudioSource val_7 = this.GetComponent<UnityEngine.AudioSource>();
                val_18 = this.audioSource;
                this.audioSource = val_7;
                val_7.playOnAwake = false;
                val_17 = mem[this.audioSource];
            }
            
            label_10:
            val_19 = this.tweenArguments;
            if(val_19 != null)
            {
                    if(null == null)
            {
                goto label_16;
            }
            
            }
            
            val_19 = 0;
            label_16:
            val_17.clip = val_19;
            if((this.tweenArguments & 1) != 0)
            {
                    val_19 = this.tweenArguments;
                val_20 = null;
                UnityEngine.Vector2 val_9 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
                this.audioSource.pitch = 1.626636E-38f;
            }
            
            if((this.tweenArguments & 1) != 0)
            {
                    val_19 = this.tweenArguments;
                val_20 = null;
                UnityEngine.Vector2 val_10 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = 1.626636E-38f, y = val_9.y});
                this.audioSource.volume = 1.626636E-38f;
            }
            
            float val_14 = mem[this.audioSource].pitch;
            val_14 = (this.GetComponent<UnityEngine.AudioSource>().clip.length) / val_14;
            this.time = val_14;
            return;
            label_34:
            goto label_34;
        }
        private void GenerateLookToTargets()
        {
            float val_7;
            var val_32;
            UnityEngine.Vector3 val_38;
            var val_39;
            var val_40;
            UnityEngine.Transform val_41;
            var val_42;
            UnityEngine.Vector3 val_43;
            var val_44;
            var val_45;
            var val_46;
            float val_47;
            float val_48;
            float val_49;
            var val_50;
            string val_51;
            UnityEngine.Vector3[] val_52;
            UnityEngine.Vector3[] val_53;
            UnityEngine.Vector3[] val_54;
            UnityEngine.Vector3[] val_55;
            float val_56;
            UnityEngine.Vector3 val_57;
            var val_58;
            UnityEngine.Vector3[] val_59;
            string val_60;
            UnityEngine.Vector3[] val_61;
            UnityEngine.Vector3[] val_62;
            var val_63;
            this.vector3s = null;
            UnityEngine.Vector3 val_1 = this.thisTransform.eulerAngles;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_20 = val_1.x;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_24 = val_1.y;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_28 = val_1.z;
            if((this.tweenArguments & 1) == 0)
            {
                goto label_5;
            }
            
            val_32 = 1152921504609562624;
            if(this.tweenArguments.GetType() == (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                goto label_10;
            }
            
            if(this.tweenArguments.GetType() != (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                goto label_42;
            }
            
            val_32;
            UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_7, y = val_1.y, z = val_1.z});
            if((0 & 1) == 0)
            {
                goto label_22;
            }
            
            val_38 = val_8.x;
            val_39 = val_8.y;
            val_40 = val_1.z;
            goto label_23;
            label_5:
            UnityEngine.Debug.LogError(message:  0);
            this.Dispose();
            goto label_42;
            label_10:
            val_41 = this.tweenArguments;
            val_32 = 1152921504722022400;
            if(val_41 != null)
            {
                    val_42 = val_41;
            }
            
            val_42 = 0;
            if((0 & 1) != 0)
            {
                    val_43 = val_7;
                val_44 = val_1.y;
                val_45 = val_1.z;
                val_41 = val_42;
            }
            else
            {
                    val_41 = 0;
                val_46 = null;
                val_46 = null;
                val_43 = SA_iTween.Defaults.up;
            }
            
            val_47 = val_43;
            val_48 = SA_iTween.Defaults.time.__il2cppRuntimeField_4C;
            val_49 = SA_iTween.Defaults.time.__il2cppRuntimeField_50;
            this.thisTransform.LookAt(target:  val_41, worldUp:  new UnityEngine.Vector3() {x = val_47, y = val_48, z = val_49});
            goto label_42;
            label_22:
            UnityEngine.Vector2 val_14 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_1.z});
            val_50 = null;
            val_50 = null;
            val_38 = SA_iTween.Defaults.up;
            label_23:
            val_47 = 1.626636E-38f;
            val_48 = val_1.z;
            val_49 = val_1.x;
            this.thisTransform.LookAt(worldPosition:  new UnityEngine.Vector3() {x = val_47, y = val_48, z = val_49}, worldUp:  new UnityEngine.Vector3() {x = val_38, y = SA_iTween.Defaults.time.__il2cppRuntimeField_4C, z = SA_iTween.Defaults.time.__il2cppRuntimeField_50});
            label_42:
            UnityEngine.Vector3 val_15 = this.thisTransform.eulerAngles;
            this.vector3s[1] = val_15;
            this.vector3s[1] = val_15.y;
            this.vector3s[1] = val_15.z;
            this.thisTransform.eulerAngles = new UnityEngine.Vector3() {x = this.vector3s[0], y = this.vector3s[0], z = this.vector3s[0]};
            val_51 = this.tweenArguments;
            if((val_51 & 1) == 0)
            {
                goto label_114;
            }
            
            val_51 = this.tweenArguments;
            if(val_51 == null)
            {
                goto label_114;
            }
            
            if(null == null)
            {
                goto label_57;
            }
            
            goto label_114;
            label_57:
            val_51 = 0;
            if((System.String.op_Equality(a:  val_51, b:  val_51)) == false)
            {
                goto label_61;
            }
            
            val_52 = this.vector3s;
            if(this.vector3s != null)
            {
                goto label_62;
            }
            
            val_52 = this.vector3s;
            if(val_52 == null)
            {
                goto label_111;
            }
            
            label_62:
            this.vector3s[1] = val_52[0];
            goto label_66;
            label_61:
            val_51 = 0;
            bool val_19 = System.String.op_Equality(a:  val_51, b:  val_51);
            if(val_19 == false)
            {
                goto label_69;
            }
            
            val_53 = this.vector3s;
            if(this.vector3s != null)
            {
                goto label_70;
            }
            
            val_53 = this.vector3s;
            if(val_53 == null)
            {
                goto label_111;
            }
            
            label_70:
            this.vector3s[1] = val_53[0];
            label_66:
            val_54 = this.vector3s;
            if(this.vector3s != null)
            {
                goto label_74;
            }
            
            val_54 = this.vector3s;
            if(val_54 == null)
            {
                goto label_111;
            }
            
            label_74:
            this.vector3s[1] = val_54[0];
            label_114:
            val_55 = this.vector3s;
            if(this.vector3s != null)
            {
                goto label_78;
            }
            
            val_55 = this.vector3s;
            if(val_55 == null)
            {
                goto label_111;
            }
            
            label_78:
            val_56 = val_19.clerp(start:  val_55[0], end:  this.vector3s[1], value:  1f);
            float val_22 = val_19.clerp(start:  this.vector3s[0], end:  this.vector3s[1], value:  1f);
            val_57 = this.vector3s[0];
            float val_23 = val_19.clerp(start:  val_57, end:  this.vector3s[1], value:  1f);
            this.vector3s[1] = 0;
            this.vector3s[1] = 0;
            val_58 = "speed";
            if((this.tweenArguments & 1) == 0)
            {
                    return;
            }
            
            val_59 = this.vector3s;
            if(this.vector3s == null)
            {
                    val_59 = this.vector3s;
                if(val_59 == null)
            {
                    val_59 = 0;
            }
            
            }
            
            UnityEngine.Vector3 val_44 = this.vector3s[0];
            val_57 = this.vector3s[0];
            float val_24 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = this.vector3s[0], y = val_44, z = val_57}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 5.142877E-39f});
            val_58 = this.tweenArguments;
            val_56 = System.Math.Abs(val_24);
            UnityEngine.Vector2 val_25 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_24, y = val_44, z = val_57});
            this.time = val_56 / null;
            return;
            label_69:
            val_60 = 0;
            if((System.String.op_Equality(a:  val_60, b:  val_51)) == false)
            {
                goto label_114;
            }
            
            val_61 = this.vector3s;
            if(this.vector3s != null)
            {
                goto label_106;
            }
            
            val_61 = this.vector3s;
            if(val_61 == null)
            {
                goto label_107;
            }
            
            label_106:
            this.vector3s[1] = val_61[0];
            val_62 = this.vector3s;
            if(this.vector3s != null)
            {
                goto label_110;
            }
            
            val_62 = this.vector3s;
            if(val_62 == null)
            {
                goto label_111;
            }
            
            label_110:
            this.vector3s[1] = val_62[0];
            goto label_114;
            label_111:
            val_63;
            label_121:
            label_107:
            goto label_121;
        }
        private void GenerateMoveToPathTargets()
        {
            var val_29;
            var val_30;
            var val_31;
            System.Array val_32;
            var val_33;
            var val_34;
            var val_35;
            var val_36;
            float val_40;
            var val_41;
            var val_42;
            UnityEngine.Vector3[] val_43;
            var val_44;
            UnityEngine.Vector3[] val_45;
            var val_46;
            var val_47;
            UnityEngine.Vector3[] val_48;
            var val_49;
            UnityEngine.Vector3[] val_50;
            UnityEngine.Vector3 val_51;
            var val_53;
            if(this.tweenArguments.GetType() == (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                goto label_6;
            }
            
            if(this.tweenArguments == null)
            {
                goto label_7;
            }
            
            val_29 = this.tweenArguments;
            if(val_29 == null)
            {
                goto label_8;
            }
            
            val_30 = 0;
            val_31 = val_29;
            goto label_9;
            label_6:
            if(this.tweenArguments == null)
            {
                goto label_10;
            }
            
            val_32 = this.tweenArguments;
            if(val_32 == null)
            {
                goto label_11;
            }
            
            val_33 = 0;
            goto label_12;
            label_8:
            label_7:
            val_29 = 0;
            val_31 = 0;
            val_30 = 1;
            label_9:
            if(7254272 == 1)
            {
                    UnityEngine.Debug.LogError(message:  0);
                this.Dispose();
            }
            
            val_34 = null;
            val_35 = 0;
            goto label_17;
            label_24:
            var val_4 = val_34 + (X27 * 12);
            val_35 = 1;
            mem2[0] = ???;
            mem2[0] = ???;
            mem2[0] = ???;
            label_17:
            val_36 = 7254272;
            if(val_35 >= val_36)
            {
                goto label_19;
            }
            
            if(null == null)
            {
                    val_36 = 7254272;
            }
            
            var val_5 = val_29 + 8;
            UnityEngine.Vector3 val_6 = (val_29 + 8) + 32.position;
            goto label_24;
            label_11:
            label_10:
            val_32 = 0;
            val_33 = 1;
            label_12:
            if(7254272 == 1)
            {
                    UnityEngine.Debug.LogError(message:  0);
                this.Dispose();
            }
            
            val_34 = null;
            System.Array.Copy(sourceArray:  0, destinationArray:  val_32, length:  1254012752);
            label_19:
            UnityEngine.Vector3 val_8 = this.thisTransform.position;
            val_40 = val_8.y;
            val_41 = 2;
            if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = val_8.x, y = val_40, z = val_8.z}, rhs:  new UnityEngine.Vector3() {x = UnityEngine.Vector3[].__il2cppRuntimeField_byval_arg, y = typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_24, z = UnityEngine.Vector3[].__il2cppRuntimeField_this_arg})) == false)
            {
                goto label_35;
            }
            
            val_41 = 3;
            if((this.tweenArguments & 1) == 0)
            {
                goto label_37;
            }
            
            UnityEngine.Vector2 val_10 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_8.x, y = val_40, z = val_8.z});
            var val_11 = (null != 0) ? (2 + 1) : 2;
            var val_12 = (null != 0) ? 1 : 0;
            goto label_42;
            label_35:
            val_42 = 0;
            goto label_42;
            label_37:
            val_42 = 1;
            label_42:
            val_43 = null;
            this.vector3s = val_43;
            if(val_42 != 0)
            {
                    UnityEngine.Vector3 val_13 = this.thisTransform.position;
                val_40 = val_13.y;
                typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_2C = val_13.x;
                typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_30 = val_40;
                typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_34 = val_13.z;
                val_43 = this.vector3s;
                val_44 = 2;
            }
            else
            {
                    val_44 = 1;
            }
            
            System.Array.Copy(sourceArray:  0, sourceIndex:  1254012752, destinationArray:  0, destinationIndex:  1254012752, length:  1);
            val_45 = this.vector3s;
            val_46 = this.vector3s;
            val_47 = this.vector3s;
            if(this.vector3s == null)
            {
                    val_45 = this.vector3s;
                val_46 = val_45;
                val_47 = val_45;
                if(val_45 == null)
            {
                    val_45 = this.vector3s;
                if(val_45 != null)
            {
                    val_46 = 0;
                val_47 = val_45;
            }
            else
            {
                    val_45 = this.vector3s;
                if(val_45 == null)
            {
                    val_45 = 0;
            }
            
                val_46 = 0;
                val_47 = 0;
            }
            
            }
            
            }
            
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 5.142877E-39f}, b:  new UnityEngine.Vector3() {x = 5.87748E-39f, y = 2.295924E-39f, z = 1.401298E-45f});
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 5.142877E-39f}, b:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
            this.vector3s[0] = val_15;
            this.vector3s[0] = val_15.y;
            this.vector3s[0] = val_15.z;
            val_48 = this.vector3s;
            val_49 = this.vector3s;
            if(this.vector3s == null)
            {
                    val_48 = this.vector3s;
                val_49 = val_48;
                if(val_48 == null)
            {
                    val_48 = this.vector3s;
                if(val_48 == null)
            {
                    val_48 = 0;
            }
            
                val_49 = 0;
            }
            
            }
            
            var val_32 = -8589934592;
            val_32 = val_32 + 31156860996288512;
            var val_33 = 12;
            val_33 = val_48 + ((val_32 >> 32) * val_33);
            var val_34 = 12;
            val_34 = val_48 + (0 * val_34);
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = (((-8589934592 + 31156860996288512) >> 32) * 12) + val_48 + 32, y = (((-8589934592 + 31156860996288512) >> 32) * 12) + val_48 + 32 + 4, z = (((-8589934592 + 31156860996288512) >> 32) * 12) + val_48 + 40}, b:  new UnityEngine.Vector3() {x = (0 * 12) + val_48 + 32, y = (0 * 12) + val_48 + 32 + 4, z = (0 * 12) + val_48 + 40});
            var val_35 = 12;
            val_35 = val_49 + (0 * val_35);
            UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = (0 * 12) + val_49 + 32, y = (0 * 12) + val_49 + 32 + 4, z = (0 * 12) + val_49 + 40}, b:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z});
            var val_36 = -4294967296;
            val_36 = val_36 + ((this.vector3s.Length) << 32);
            var val_37 = 12;
            val_37 = this.vector3s + ((val_36 >> 32) * val_37);
            mem2[0] = val_18.x;
            mem2[0] = val_18.y;
            mem2[0] = val_18.z;
            val_50 = this.vector3s;
            if(this.vector3s == null)
            {
                    val_50 = this.vector3s;
                if(val_50 == null)
            {
                    val_50 = 0;
            }
            
            }
            
            UnityEngine.Vector3 val_39 = this.vector3s[1];
            val_51 = this.vector3s[1];
            var val_40 = -8589934592;
            val_40 = val_40 + 31156860996288512;
            var val_41 = 12;
            val_41 = val_50 + ((val_40 >> 32) * val_41);
            if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = this.vector3s[1], y = val_39, z = val_51}, rhs:  new UnityEngine.Vector3() {x = (((-8589934592 + 31156860996288512) >> 32) * 12) + val_50 + 32, y = (((-8589934592 + 31156860996288512) >> 32) * 12) + val_50 + 32 + 4, z = (((-8589934592 + 31156860996288512) >> 32) * 12) + val_50 + 40})) != false)
            {
                    System.Array.Copy(sourceArray:  0, destinationArray:  this.vector3s, length:  1254012752);
                var val_42 = 12;
                val_42 = null + ((((-12884901888 + (UnityEngine.Vector3[].__il2cppRuntimeField_namespaze) << 32)) >> 32) * val_42);
                UnityEngine.Vector3[].__il2cppRuntimeField_byval_arg.__il2cppRuntimeField_8 = (((-12884901888 + (UnityEngine.Vector3[].__il2cppRuntimeField_namespaze) << 32) >> 32) * 12) + null + 40;
                UnityEngine.Vector3[].__il2cppRuntimeField_byval_arg.__il2cppRuntimeField_FFFFFFFFFFFFFFFF = (((-12884901888 + (UnityEngine.Vector3[].__il2cppRuntimeField_namespaze) << 32) >> 32) * 12) + null + 32;
                var val_43 = 12;
                val_43 = null + ((((-4294967296 + (UnityEngine.Vector3[].__il2cppRuntimeField_namespaze) << 32)) >> 32) * val_43);
                var val_25 = val_43 + 32;
                mem2[0] = UnityEngine.Vector3[].__il2cppRuntimeField_declaringType;
                mem2[0] = UnityEngine.Vector3[].__il2cppRuntimeField_castClass;
                this.vector3s = null;
                System.Array.Copy(sourceArray:  0, destinationArray:  null, length:  1254012752);
            }
            
            this.path = new SA_iTween.CRSpline(pts:  this.vector3s);
            val_53 = "speed";
            if((this.tweenArguments & 1) == 0)
            {
                    return;
            }
            
            float val_27 = SA.Common.Animation.SA_iTween.PathLength(path:  null);
            val_51 = val_27;
            val_53 = this.tweenArguments;
            UnityEngine.Vector2 val_28 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_27, y = val_39, z = val_51});
            this.time = val_51 / null;
            return;
            label_89:
            goto label_89;
        }
        private void GenerateMoveToTargets()
        {
            UnityEngine.Vector3[] val_24;
            float val_28;
            UnityEngine.Vector3 val_29;
            UnityEngine.Vector3 val_30;
            var val_31;
            var val_32;
            var val_33;
            var val_34;
            var val_35;
            UnityEngine.Vector3[] val_36;
            var val_37;
            val_24 = null;
            this.vector3s = null;
            if(null == null)
            {
                    val_24 = this.vector3s;
            }
            
            if(this.isLocal != false)
            {
                    UnityEngine.Vector3 val_1 = this.thisTransform.localPosition;
            }
            else
            {
                    UnityEngine.Vector3 val_2 = this.thisTransform.position;
            }
            
            val_28 = val_2.x;
            val_29 = val_2.y;
            val_30 = val_2.z;
            val_24[1] = val_2;
            val_24[1] = val_29;
            val_24[1] = val_30;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_20 = val_28;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_24 = val_29;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_28 = val_30;
            if((this.tweenArguments & 1) == 0)
            {
                goto label_10;
            }
            
            val_31 = this.tweenArguments;
            if(this.tweenArguments.GetType() == (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                goto label_15;
            }
            
            if(val_31.GetType() != (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                goto label_53;
            }
            
            val_32 = 0;
            goto label_25;
            label_10:
            if((this.tweenArguments & 1) != 0)
            {
                    val_33 = null;
                UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
                this.vector3s[1] = new UnityEngine.Vector3();
            }
            
            if((this.tweenArguments & 1) != 0)
            {
                    val_33 = null;
                UnityEngine.Vector2 val_9 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_2.z});
                this.vector3s[1] = new UnityEngine.Vector3();
            }
            
            if((this.tweenArguments & 1) == 0)
            {
                goto label_53;
            }
            
            val_33 = null;
            UnityEngine.Vector2 val_10 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_2.z});
            this.vector3s[1] = new UnityEngine.Vector3();
            goto label_53;
            label_15:
            val_31 = 0;
            UnityEngine.Vector3 val_13 = val_31.position;
            val_28 = val_13.x;
            val_29 = val_13.y;
            val_30 = val_13.z;
            this.vector3s[1] = val_13;
            this.vector3s[1] = val_29;
            this.vector3s[1] = val_30;
            goto label_53;
            label_25:
            mem2[0] = UnityEngine.Vector3.__il2cppRuntimeField_element_class;
            mem2[0] = null;
            label_53:
            if((this.tweenArguments & 1) != 0)
            {
                    val_33 = this.tweenArguments;
                val_34 = null;
                UnityEngine.Vector2 val_15 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_2.z});
                if(null != null)
            {
                    UnityEngine.Vector3 val_24 = this.vector3s[1];
                UnityEngine.Vector3 val_25 = this.vector3s[1];
            }
            
            }
            
            val_35 = "speed";
            if((this.tweenArguments & 1) == 0)
            {
                    return;
            }
            
            val_36 = this.vector3s;
            if(this.vector3s == null)
            {
                    val_36 = this.vector3s;
                if(val_36 == null)
            {
                    val_36 = 0;
            }
            
            }
            
            UnityEngine.Vector3 val_27 = this.vector3s[0];
            val_30 = this.vector3s[0];
            float val_16 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = this.vector3s[0], y = val_27, z = val_30}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 5.142877E-39f});
            val_37 = this.tweenArguments;
            val_34 = null;
            val_28 = System.Math.Abs(val_16);
            UnityEngine.Vector2 val_17 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_16, y = val_27, z = val_30});
            this.time = val_28 / null;
            return;
            label_79:
            goto label_79;
        }
        private void GenerateMoveByTargets()
        {
            UnityEngine.Vector3[] val_22;
            var val_23;
            var val_27;
            UnityEngine.Vector3[] val_28;
            var val_29;
            var val_30;
            var val_31;
            UnityEngine.Vector3[] val_32;
            UnityEngine.Vector3[] val_33;
            UnityEngine.Vector3[] val_34;
            float val_37;
            UnityEngine.Vector3 val_38;
            var val_39;
            UnityEngine.Vector3[] val_40;
            var val_41;
            var val_42;
            this.vector3s = null;
            UnityEngine.Vector3 val_1 = this.thisTransform.eulerAngles;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_50 = val_1.x;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_54 = val_1.y;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_58 = val_1.z;
            val_22 = this.vector3s;
            val_23 = this.vector3s;
            if(this.vector3s == null)
            {
                    val_22 = this.vector3s;
                val_23 = val_22;
                if(val_22 == null)
            {
                    val_22 = this.vector3s;
                if(val_22 == null)
            {
                    val_22 = 0;
            }
            
                val_23 = 0;
            }
            
            }
            
            UnityEngine.Vector3 val_2 = this.thisTransform.position;
            mem[68] = val_2.x;
            mem[72] = val_2.y;
            mem[76] = val_2.z;
            mem[44] = val_2.x;
            mem[48] = val_2.y;
            mem[52] = val_2.z;
            this.vector3s[0] = val_2;
            this.vector3s[0] = val_2.y;
            this.vector3s[0] = val_2.z;
            val_27 = "amount";
            if((this.tweenArguments & 1) == 0)
            {
                goto label_12;
            }
            
            val_28 = this.vector3s;
            if(this.vector3s == null)
            {
                    val_28 = this.vector3s;
                if(val_28 == null)
            {
                    val_28 = 0;
            }
            
            }
            
            val_27 = 1152921504719785984;
            val_29 = this.tweenArguments;
            val_30 = null;
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = 8.96831E-44f, y = 0f, z = 1.041983E-37f}, b:  new UnityEngine.Vector3() {x = 1.626636E-38f});
            this.vector3s[1] = val_4;
            this.vector3s[1] = val_4.y;
            this.vector3s[1] = val_4.z;
            goto label_42;
            label_12:
            val_31 = this.tweenArguments;
            if((val_31 & 1) == 0)
            {
                goto label_24;
            }
            
            val_32 = this.vector3s;
            if(this.vector3s != null)
            {
                goto label_25;
            }
            
            val_32 = this.vector3s;
            if(val_32 == null)
            {
                goto label_26;
            }
            
            label_25:
            val_30 = null;
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            float val_6 = val_32[0] + null;
            this.vector3s[1] = val_6;
            label_24:
            val_31 = this.tweenArguments;
            if((val_31 & 1) == 0)
            {
                goto label_33;
            }
            
            val_33 = this.vector3s;
            if(this.vector3s != null)
            {
                goto label_34;
            }
            
            val_33 = this.vector3s;
            if(val_33 == null)
            {
                goto label_35;
            }
            
            label_34:
            val_30 = null;
            UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_6, y = val_5.y, z = val_2.z});
            float val_8 = val_33[0] + null;
            this.vector3s[1] = val_8;
            label_33:
            val_31 = this.tweenArguments;
            if((val_31 & 1) == 0)
            {
                goto label_42;
            }
            
            val_34 = this.vector3s;
            if(this.vector3s != null)
            {
                goto label_43;
            }
            
            val_34 = this.vector3s;
            if(val_34 == null)
            {
                goto label_44;
            }
            
            label_43:
            val_30 = null;
            UnityEngine.Vector2 val_9 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_8, y = val_7.y, z = val_2.z});
            this.vector3s[1] = val_34[0] + null;
            label_42:
            this.thisTransform.Translate(translation:  new UnityEngine.Vector3() {x = this.vector3s[1], y = this.vector3s[1], z = this.vector3s[1]}, relativeTo:  this.space);
            UnityEngine.Vector3 val_11 = this.thisTransform.position;
            val_37 = val_11.x;
            val_38 = val_11.z;
            this.vector3s[5] = val_11;
            this.vector3s[5] = val_11.y;
            this.vector3s[5] = val_38;
            UnityEngine.Vector3 val_28 = this.vector3s[0];
            UnityEngine.Vector3 val_29 = this.vector3s[0];
            UnityEngine.Vector3 val_30 = this.vector3s[0];
            this.thisTransform.position = new UnityEngine.Vector3() {x = val_28, y = val_29, z = val_30};
            if((this.tweenArguments & 1) != 0)
            {
                    val_30 = this.tweenArguments;
                val_29 = null;
                UnityEngine.Vector2 val_12 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_28, y = val_29, z = val_30});
                if(null != null)
            {
                    UnityEngine.Vector3 val_31 = this.vector3s[1];
                UnityEngine.Vector3 val_32 = this.vector3s[1];
            }
            
            }
            
            val_39 = "speed";
            if((this.tweenArguments & 1) == 0)
            {
                    return;
            }
            
            val_40 = this.vector3s;
            if(this.vector3s == null)
            {
                    val_40 = this.vector3s;
                if(val_40 == null)
            {
                    val_40 = 0;
            }
            
            }
            
            UnityEngine.Vector3 val_34 = this.vector3s[0];
            val_38 = this.vector3s[0];
            float val_13 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = this.vector3s[0], y = val_34, z = val_38}, b:  new UnityEngine.Vector3() {x = mem[44], y = mem[48], z = mem[52]});
            val_41 = this.tweenArguments;
            val_29 = null;
            val_37 = System.Math.Abs(val_13);
            UnityEngine.Vector2 val_14 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_13, y = val_34, z = val_38});
            this.time = val_37 / null;
            return;
            label_26:
            label_35:
            label_44:
            val_42;
        }
        private void GenerateScaleToTargets()
        {
            UnityEngine.Vector3[] val_21;
            float val_25;
            UnityEngine.Vector3 val_26;
            UnityEngine.Vector3 val_27;
            var val_28;
            var val_29;
            var val_30;
            var val_31;
            UnityEngine.Vector3[] val_32;
            var val_33;
            val_21 = null;
            this.vector3s = null;
            if(null == null)
            {
                    val_21 = this.vector3s;
            }
            
            UnityEngine.Vector3 val_1 = this.thisTransform.localScale;
            val_25 = val_1.x;
            val_26 = val_1.y;
            val_27 = val_1.z;
            val_21[1] = val_1;
            val_21[1] = val_26;
            val_21[1] = val_27;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_20 = val_25;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_24 = val_26;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_28 = val_27;
            if((this.tweenArguments & 1) == 0)
            {
                goto label_8;
            }
            
            val_28 = this.tweenArguments;
            if(this.tweenArguments.GetType() == (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                goto label_13;
            }
            
            if(val_28.GetType() != (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                goto label_51;
            }
            
            val_29 = 0;
            goto label_23;
            label_8:
            if((this.tweenArguments & 1) != 0)
            {
                    val_30 = null;
                UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
                this.vector3s[1] = new UnityEngine.Vector3();
            }
            
            if((this.tweenArguments & 1) != 0)
            {
                    val_30 = null;
                UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_1.z});
                this.vector3s[1] = new UnityEngine.Vector3();
            }
            
            if((this.tweenArguments & 1) == 0)
            {
                goto label_51;
            }
            
            val_30 = null;
            UnityEngine.Vector2 val_9 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_1.z});
            this.vector3s[1] = new UnityEngine.Vector3();
            goto label_51;
            label_13:
            val_28 = 0;
            UnityEngine.Vector3 val_12 = val_28.localScale;
            val_25 = val_12.x;
            val_26 = val_12.y;
            val_27 = val_12.z;
            this.vector3s[1] = val_12;
            this.vector3s[1] = val_26;
            this.vector3s[1] = val_27;
            goto label_51;
            label_23:
            mem2[0] = UnityEngine.Vector3.__il2cppRuntimeField_element_class;
            mem2[0] = null;
            label_51:
            val_31 = "speed";
            if((this.tweenArguments & 1) == 0)
            {
                    return;
            }
            
            val_32 = this.vector3s;
            if(this.vector3s == null)
            {
                    val_32 = this.vector3s;
                if(val_32 == null)
            {
                    val_32 = 0;
            }
            
            }
            
            UnityEngine.Vector3 val_22 = this.vector3s[0];
            val_27 = this.vector3s[0];
            float val_14 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = this.vector3s[0], y = val_22, z = val_27}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 5.142877E-39f});
            val_33 = this.tweenArguments;
            val_25 = System.Math.Abs(val_14);
            UnityEngine.Vector2 val_15 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_14, y = val_22, z = val_27});
            this.time = val_25 / null;
            return;
            label_67:
            goto label_67;
        }
        private void GenerateScaleByTargets()
        {
            UnityEngine.Vector3[] val_18;
            float val_22;
            UnityEngine.Vector3 val_23;
            UnityEngine.Vector3 val_24;
            var val_25;
            UnityEngine.Vector3[] val_26;
            var val_27;
            var val_28;
            UnityEngine.Vector3[] val_29;
            val_18 = null;
            this.vector3s = null;
            if(null == null)
            {
                    val_18 = this.vector3s;
            }
            
            UnityEngine.Vector3 val_1 = this.thisTransform.localScale;
            val_22 = val_1.x;
            val_23 = val_1.y;
            val_24 = val_1.z;
            val_18[1] = val_1;
            val_18[1] = val_23;
            val_18[1] = val_24;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_20 = val_22;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_24 = val_23;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_28 = val_24;
            val_25 = "amount";
            if((this.tweenArguments & 1) != 0)
            {
                    val_26 = this.vector3s;
                if(this.vector3s == null)
            {
                    val_26 = this.vector3s;
                if(val_26 == null)
            {
                    val_26 = 0;
            }
            
            }
            
                val_25 = 1152921504719785984;
                val_27 = this.tweenArguments;
                UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
                UnityEngine.Vector3 val_3 = UnityEngine.Vector3.Scale(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 5.142877E-39f}, b:  new UnityEngine.Vector3() {x = 1.626636E-38f});
                val_22 = val_3.x;
                val_23 = val_3.y;
                val_24 = val_3.z;
                this.vector3s[1] = val_3;
                this.vector3s[1] = val_23;
                this.vector3s[1] = val_24;
            }
            else
            {
                    if((this.tweenArguments & 1) != 0)
            {
                    val_22 = this.vector3s[1];
                val_27 = null;
                UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
                float val_5 = val_22 * null;
                this.vector3s[1] = val_5;
            }
            
                if((this.tweenArguments & 1) != 0)
            {
                    val_22 = this.vector3s[1];
                val_27 = null;
                UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_5, y = val_4.y, z = val_1.z});
                float val_7 = val_22 * null;
                this.vector3s[1] = val_7;
            }
            
                if((this.tweenArguments & 1) != 0)
            {
                    val_22 = this.vector3s[1];
                val_27 = null;
                UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_7, y = val_6.y, z = val_1.z});
                this.vector3s[1] = val_22 * null;
            }
            
            }
            
            val_28 = "speed";
            if((this.tweenArguments & 1) == 0)
            {
                    return;
            }
            
            val_29 = this.vector3s;
            if(this.vector3s == null)
            {
                    val_29 = this.vector3s;
                if(val_29 == null)
            {
                    val_29 = 0;
            }
            
            }
            
            UnityEngine.Vector3 val_19 = this.vector3s[0];
            val_24 = this.vector3s[0];
            float val_10 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = this.vector3s[0], y = val_19, z = val_24}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 5.142877E-39f});
            val_28 = this.tweenArguments;
            val_27 = null;
            val_22 = System.Math.Abs(val_10);
            UnityEngine.Vector2 val_11 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_10, y = val_19, z = val_24});
            this.time = val_22 / null;
        }
        private void GenerateScaleAddTargets()
        {
            UnityEngine.Vector3[] val_18;
            float val_22;
            UnityEngine.Vector3 val_23;
            UnityEngine.Vector3 val_24;
            var val_25;
            var val_26;
            UnityEngine.Vector3[] val_27;
            val_18 = null;
            this.vector3s = null;
            if(null == null)
            {
                    val_18 = this.vector3s;
            }
            
            UnityEngine.Vector3 val_1 = this.thisTransform.localScale;
            val_22 = val_1.x;
            val_23 = val_1.y;
            val_24 = val_1.z;
            val_18[1] = val_1;
            val_18[1] = val_23;
            val_18[1] = val_24;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_20 = val_22;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_24 = val_23;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_28 = val_24;
            if((this.tweenArguments & 1) != 0)
            {
                    val_25 = null;
                val_25 = null;
                val_22 = this.vector3s[1];
                val_23 = this.vector3s[1];
                val_24 = this.vector3s[1];
                UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
                UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_22, y = val_23, z = val_24}, b:  new UnityEngine.Vector3() {x = 1.626636E-38f});
                this.vector3s[1] = val_3;
                this.vector3s[1] = val_3.y;
                this.vector3s[1] = val_3.z;
            }
            else
            {
                    if((this.tweenArguments & 1) != 0)
            {
                    val_22 = this.vector3s[1];
                val_25 = null;
                UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
                float val_5 = val_22 + null;
                this.vector3s[1] = val_5;
            }
            
                if((this.tweenArguments & 1) != 0)
            {
                    val_22 = this.vector3s[1];
                val_25 = null;
                UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_5, y = val_4.y, z = val_1.z});
                float val_7 = val_22 + null;
                this.vector3s[1] = val_7;
            }
            
                if((this.tweenArguments & 1) != 0)
            {
                    val_22 = this.vector3s[1];
                val_25 = null;
                UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_7, y = val_6.y, z = val_1.z});
                this.vector3s[1] = val_22 + null;
            }
            
            }
            
            val_26 = "speed";
            if((this.tweenArguments & 1) == 0)
            {
                    return;
            }
            
            val_27 = this.vector3s;
            if(this.vector3s == null)
            {
                    val_27 = this.vector3s;
                if(val_27 == null)
            {
                    val_27 = 0;
            }
            
            }
            
            UnityEngine.Vector3 val_19 = this.vector3s[0];
            val_24 = this.vector3s[0];
            float val_10 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = this.vector3s[0], y = val_19, z = val_24}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 5.142877E-39f});
            val_26 = this.tweenArguments;
            val_25 = null;
            val_22 = System.Math.Abs(val_10);
            UnityEngine.Vector2 val_11 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_10, y = val_19, z = val_24});
            this.time = val_22 / null;
        }
        private void GenerateRotateToTargets()
        {
            UnityEngine.Vector3[] val_25;
            var val_29;
            var val_30;
            var val_31;
            var val_32;
            UnityEngine.Vector3[] val_33;
            float val_34;
            UnityEngine.Vector3 val_35;
            var val_36;
            UnityEngine.Vector3[] val_37;
            var val_38;
            var val_39;
            val_25 = null;
            this.vector3s = null;
            if(null == null)
            {
                    val_25 = this.vector3s;
            }
            
            if(this.isLocal != false)
            {
                    UnityEngine.Vector3 val_1 = this.thisTransform.localEulerAngles;
            }
            else
            {
                    UnityEngine.Vector3 val_2 = this.thisTransform.eulerAngles;
            }
            
            val_25[1] = val_2;
            val_25[1] = val_2.y;
            val_25[1] = val_2.z;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_20 = val_2.x;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_24 = val_2.y;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_28 = val_2.z;
            if((this.tweenArguments & 1) == 0)
            {
                goto label_10;
            }
            
            val_29 = this.tweenArguments;
            if(this.tweenArguments.GetType() == (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                goto label_15;
            }
            
            if(val_29.GetType() != (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                goto label_53;
            }
            
            val_30 = 0;
            goto label_25;
            label_10:
            if((this.tweenArguments & 1) != 0)
            {
                    val_31 = null;
                UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
                this.vector3s[1] = new UnityEngine.Vector3();
            }
            
            if((this.tweenArguments & 1) != 0)
            {
                    val_31 = null;
                UnityEngine.Vector2 val_9 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_2.z});
                this.vector3s[1] = new UnityEngine.Vector3();
            }
            
            if((this.tweenArguments & 1) == 0)
            {
                goto label_53;
            }
            
            val_31 = null;
            UnityEngine.Vector2 val_10 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_2.z});
            this.vector3s[1] = new UnityEngine.Vector3();
            goto label_53;
            label_15:
            val_29 = 0;
            UnityEngine.Vector3 val_13 = val_29.eulerAngles;
            this.vector3s[1] = val_13;
            this.vector3s[1] = val_13.y;
            this.vector3s[1] = val_13.z;
            goto label_53;
            label_25:
            mem2[0] = UnityEngine.Vector3.__il2cppRuntimeField_element_class;
            mem2[0] = null;
            label_53:
            val_32 = this.vector3s;
            if(this.vector3s != null)
            {
                goto label_54;
            }
            
            val_33 = this.vector3s;
            if(val_33 == null)
            {
                goto label_55;
            }
            
            label_54:
            val_34 = clerp(start:  val_33[0], end:  this.vector3s[1], value:  1f);
            float val_16 = clerp(start:  this.vector3s[0], end:  this.vector3s[1], value:  1f);
            val_35 = this.vector3s[0];
            float val_17 = clerp(start:  val_35, end:  this.vector3s[1], value:  1f);
            this.vector3s[1] = 0;
            this.vector3s[1] = 0;
            val_36 = "speed";
            if((this.tweenArguments & 1) == 0)
            {
                    return;
            }
            
            val_37 = this.vector3s;
            if(this.vector3s == null)
            {
                    val_37 = this.vector3s;
                if(val_37 == null)
            {
                    val_37 = 0;
            }
            
            }
            
            UnityEngine.Vector3 val_31 = this.vector3s[0];
            val_35 = this.vector3s[0];
            float val_18 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = this.vector3s[0], y = val_31, z = val_35}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 5.142877E-39f});
            val_38 = this.tweenArguments;
            val_34 = System.Math.Abs(val_18);
            UnityEngine.Vector2 val_19 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_18, y = val_31, z = val_35});
            this.time = val_34 / null;
            return;
            label_55:
            val_39;
            label_83:
            goto label_83;
        }
        private void GenerateRotateAddTargets()
        {
            UnityEngine.Vector3[] val_18;
            UnityEngine.Vector3[] val_19;
            float val_23;
            UnityEngine.Vector3 val_24;
            UnityEngine.Vector3 val_25;
            var val_26;
            var val_27;
            UnityEngine.Vector3[] val_28;
            val_18 = null;
            this.vector3s = null;
            if(null == null)
            {
                    val_18 = this.vector3s;
            }
            
            val_19 = val_18;
            if(val_18 == null)
            {
                    val_19 = this.vector3s;
            }
            
            UnityEngine.Vector3 val_1 = this.thisTransform.eulerAngles;
            val_23 = val_1.x;
            val_24 = val_1.y;
            val_25 = val_1.z;
            val_19[3] = val_1;
            val_19[3] = val_24;
            val_19[3] = val_25;
            val_18[1] = val_1;
            val_18[1] = val_24;
            val_18[1] = val_25;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_20 = val_23;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_24 = val_24;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_28 = val_25;
            if((this.tweenArguments & 1) != 0)
            {
                    val_19 = 1152921504719785984;
                val_26 = null;
                val_26 = null;
                val_23 = this.vector3s[1];
                val_24 = this.vector3s[1];
                val_25 = this.vector3s[1];
                UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
                UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_23, y = val_24, z = val_25}, b:  new UnityEngine.Vector3() {x = 1.626636E-38f});
                this.vector3s[1] = val_3;
                this.vector3s[1] = val_3.y;
                this.vector3s[1] = val_3.z;
            }
            else
            {
                    if((this.tweenArguments & 1) != 0)
            {
                    val_23 = this.vector3s[1];
                val_26 = null;
                UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
                float val_5 = val_23 + null;
                this.vector3s[1] = val_5;
            }
            
                if((this.tweenArguments & 1) != 0)
            {
                    val_23 = this.vector3s[1];
                val_26 = null;
                UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_5, y = val_4.y, z = val_1.z});
                float val_7 = val_23 + null;
                this.vector3s[1] = val_7;
            }
            
                if((this.tweenArguments & 1) != 0)
            {
                    val_23 = this.vector3s[1];
                val_26 = null;
                UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_7, y = val_6.y, z = val_1.z});
                this.vector3s[1] = val_23 + null;
            }
            
            }
            
            val_27 = "speed";
            if((this.tweenArguments & 1) == 0)
            {
                    return;
            }
            
            val_28 = this.vector3s;
            if(this.vector3s == null)
            {
                    val_28 = this.vector3s;
                if(val_28 == null)
            {
                    val_28 = 0;
            }
            
            }
            
            UnityEngine.Vector3 val_19 = this.vector3s[0];
            val_25 = this.vector3s[0];
            float val_10 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = this.vector3s[0], y = val_19, z = val_25}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 5.142877E-39f});
            val_27 = this.tweenArguments;
            val_26 = null;
            val_23 = System.Math.Abs(val_10);
            UnityEngine.Vector2 val_11 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_10, y = val_19, z = val_25});
            this.time = val_23 / null;
        }
        private void GenerateRotateByTargets()
        {
            UnityEngine.Vector3[] val_19;
            UnityEngine.Vector3[] val_20;
            float val_24;
            UnityEngine.Vector3 val_25;
            var val_26;
            var val_27;
            var val_28;
            UnityEngine.Vector3[] val_29;
            val_19 = null;
            this.vector3s = null;
            if(null == null)
            {
                    val_19 = this.vector3s;
            }
            
            val_20 = val_19;
            if(val_19 == null)
            {
                    val_20 = this.vector3s;
            }
            
            UnityEngine.Vector3 val_1 = this.thisTransform.eulerAngles;
            val_24 = val_1.x;
            val_25 = val_1.z;
            val_20[3] = val_1;
            val_20[3] = val_1.y;
            val_20[3] = val_25;
            val_19[1] = val_1;
            val_19[1] = val_1.y;
            val_19[1] = val_25;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_20 = val_24;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_24 = val_1.y;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_28 = val_25;
            if((this.tweenArguments & 1) != 0)
            {
                    val_26 = this.tweenArguments;
                val_20 = 1152921504719785984;
                val_27 = null;
                val_27 = null;
                UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = 360f, y = 360f, z = 360f});
                UnityEngine.Vector3 val_3 = UnityEngine.Vector3.Scale(a:  new UnityEngine.Vector3() {x = 1.626636E-38f, y = val_2.y, z = 360f}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
                UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.vector3s[1], y = this.vector3s[1], z = this.vector3s[1]}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
                this.vector3s[1] = val_4;
                this.vector3s[1] = val_4.y;
                this.vector3s[1] = val_4.z;
            }
            else
            {
                    if((this.tweenArguments & 1) != 0)
            {
                    val_24 = this.vector3s[1];
                val_26 = null;
                UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
                float val_6 = null * 360f;
                val_6 = val_24 + val_6;
                this.vector3s[1] = val_6;
            }
            
                if((this.tweenArguments & 1) != 0)
            {
                    val_24 = this.vector3s[1];
                val_26 = null;
                UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_6, y = 360f, z = val_1.z});
                float val_8 = null * 360f;
                val_8 = val_24 + val_8;
                this.vector3s[1] = val_8;
            }
            
                if((this.tweenArguments & 1) != 0)
            {
                    val_24 = this.vector3s[1];
                val_26 = null;
                UnityEngine.Vector2 val_9 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_8, y = 360f, z = val_1.z});
                float val_10 = null * 360f;
                val_10 = val_24 + val_10;
                this.vector3s[1] = val_10;
            }
            
            }
            
            val_28 = "speed";
            if((this.tweenArguments & 1) == 0)
            {
                    return;
            }
            
            val_29 = this.vector3s;
            if(this.vector3s == null)
            {
                    val_29 = this.vector3s;
                if(val_29 == null)
            {
                    val_29 = 0;
            }
            
            }
            
            UnityEngine.Vector3 val_23 = this.vector3s[0];
            val_25 = this.vector3s[0];
            float val_11 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = this.vector3s[0], y = val_23, z = val_25}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 5.142877E-39f});
            val_28 = this.tweenArguments;
            val_26 = null;
            val_24 = System.Math.Abs(val_11);
            UnityEngine.Vector2 val_12 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_11, y = val_23, z = val_25});
            this.time = val_24 / null;
        }
        private void GenerateShakePositionTargets()
        {
            var val_11;
            UnityEngine.Vector3[] val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            val_11 = this;
            this.vector3s = null;
            UnityEngine.Vector3 val_1 = this.thisTransform.eulerAngles;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_44 = val_1.x;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_48 = val_1.y;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_4C = val_1.z;
            UnityEngine.Vector3 val_2 = this.thisTransform.position;
            this.vector3s[0] = val_2;
            this.vector3s[0] = val_2.y;
            this.vector3s[0] = val_2.z;
            if((this.tweenArguments & 1) != 0)
            {
                    val_14 = this.vector3s;
                val_11 = this.tweenArguments;
                val_15 = 0;
            }
            else
            {
                    if((this.tweenArguments & 1) != 0)
            {
                    val_16 = this.tweenArguments;
                val_17 = null;
                UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
                this.vector3s[1] = new UnityEngine.Vector3();
            }
            
                val_14 = "y";
                if((this.tweenArguments & 1) != 0)
            {
                    val_16 = this.tweenArguments;
                val_18 = null;
                UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_2.z});
                this.vector3s[1] = new UnityEngine.Vector3();
            }
            
                if((this.tweenArguments & 1) == 0)
            {
                    return;
            }
            
                val_14 = this.vector3s;
                val_11 = this.tweenArguments;
                val_16 = null;
                UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_2.z});
                val_14[1] = new UnityEngine.Vector3();
                return;
            }
            
            mem2[0] = UnityEngine.Vector3.__il2cppRuntimeField_element_class;
            mem2[0] = null;
            return;
            label_39:
            goto label_39;
        }
        private void GenerateShakeScaleTargets()
        {
            var val_10;
            UnityEngine.Vector3[] val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            val_10 = this;
            this.vector3s = null;
            UnityEngine.Vector3 val_1 = this.thisTransform.localScale;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_20 = val_1.x;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_24 = val_1.y;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_28 = val_1.z;
            if((this.tweenArguments & 1) != 0)
            {
                    val_13 = this.vector3s;
                val_10 = this.tweenArguments;
                val_14 = 0;
            }
            else
            {
                    if((this.tweenArguments & 1) != 0)
            {
                    val_15 = this.tweenArguments;
                val_16 = null;
                UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
                this.vector3s[1] = new UnityEngine.Vector3();
            }
            
                val_13 = "y";
                if((this.tweenArguments & 1) != 0)
            {
                    val_15 = this.tweenArguments;
                val_17 = null;
                UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_1.z});
                this.vector3s[1] = new UnityEngine.Vector3();
            }
            
                if((this.tweenArguments & 1) == 0)
            {
                    return;
            }
            
                val_13 = this.vector3s;
                val_10 = this.tweenArguments;
                val_15 = null;
                UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_1.z});
                val_13[1] = new UnityEngine.Vector3();
                return;
            }
            
            mem2[0] = UnityEngine.Vector3.__il2cppRuntimeField_element_class;
            mem2[0] = null;
            return;
            label_36:
            goto label_36;
        }
        private void GenerateShakeRotationTargets()
        {
            var val_10;
            UnityEngine.Vector3[] val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            val_10 = this;
            this.vector3s = null;
            UnityEngine.Vector3 val_1 = this.thisTransform.eulerAngles;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_20 = val_1.x;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_24 = val_1.y;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_28 = val_1.z;
            if((this.tweenArguments & 1) != 0)
            {
                    val_13 = this.vector3s;
                val_10 = this.tweenArguments;
                val_14 = 0;
            }
            else
            {
                    if((this.tweenArguments & 1) != 0)
            {
                    val_15 = this.tweenArguments;
                val_16 = null;
                UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
                this.vector3s[1] = new UnityEngine.Vector3();
            }
            
                val_13 = "y";
                if((this.tweenArguments & 1) != 0)
            {
                    val_15 = this.tweenArguments;
                val_17 = null;
                UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_1.z});
                this.vector3s[1] = new UnityEngine.Vector3();
            }
            
                if((this.tweenArguments & 1) == 0)
            {
                    return;
            }
            
                val_13 = this.vector3s;
                val_10 = this.tweenArguments;
                val_15 = null;
                UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_1.z});
                val_13[1] = new UnityEngine.Vector3();
                return;
            }
            
            mem2[0] = UnityEngine.Vector3.__il2cppRuntimeField_element_class;
            mem2[0] = null;
            return;
            label_36:
            goto label_36;
        }
        private void GeneratePunchPositionTargets()
        {
            var val_12;
            UnityEngine.Vector3[] val_13;
            UnityEngine.Vector3[] val_14;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            val_12 = this;
            this.vector3s = null;
            UnityEngine.Vector3 val_1 = this.thisTransform.eulerAngles;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_50 = val_1.x;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_54 = val_1.y;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_58 = val_1.z;
            UnityEngine.Vector3 val_2 = this.thisTransform.position;
            this.vector3s[0] = val_2;
            this.vector3s[0] = val_2.y;
            this.vector3s[0] = val_2.z;
            val_13 = this.vector3s;
            if(this.vector3s == null)
            {
                    val_13 = this.vector3s;
                if(val_13 == null)
            {
                    val_13 = 0;
            }
            
            }
            
            val_14 = 1152921504719785984;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            mem[68] = val_3.x;
            mem[72] = val_3.y;
            mem[76] = val_3.z;
            this.vector3s[1] = val_3;
            this.vector3s[1] = val_3.y;
            this.vector3s[1] = val_3.z;
            if((this.tweenArguments & 1) != 0)
            {
                    val_12 = this.tweenArguments;
                val_17 = 0;
            }
            else
            {
                    if((this.tweenArguments & 1) != 0)
            {
                    val_18 = this.tweenArguments;
                val_19 = null;
                UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
                this.vector3s[1] = new UnityEngine.Vector3();
            }
            
                val_14 = "y";
                if((this.tweenArguments & 1) != 0)
            {
                    val_18 = this.tweenArguments;
                val_20 = null;
                UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_3.z});
                this.vector3s[1] = new UnityEngine.Vector3();
            }
            
                if((this.tweenArguments & 1) == 0)
            {
                    return;
            }
            
                val_14 = this.vector3s;
                val_12 = this.tweenArguments;
                val_18 = null;
                UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_3.z});
                val_14[1] = new UnityEngine.Vector3();
                return;
            }
            
            mem2[0] = UnityEngine.Vector3.__il2cppRuntimeField_element_class;
            mem2[0] = null;
            return;
            label_45:
            goto label_45;
        }
        private void GeneratePunchRotationTargets()
        {
            var val_11;
            UnityEngine.Vector3[] val_12;
            UnityEngine.Vector3[] val_13;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            val_11 = this;
            this.vector3s = null;
            UnityEngine.Vector3 val_1 = this.thisTransform.eulerAngles;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_20 = val_1.x;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_24 = val_1.y;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_28 = val_1.z;
            val_12 = this.vector3s;
            if(this.vector3s == null)
            {
                    val_12 = this.vector3s;
                if(val_12 == null)
            {
                    val_12 = 0;
            }
            
            }
            
            val_13 = 1152921504719785984;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            mem[68] = val_2.x;
            mem[72] = val_2.y;
            mem[76] = val_2.z;
            this.vector3s[1] = val_2;
            this.vector3s[1] = val_2.y;
            this.vector3s[1] = val_2.z;
            if((this.tweenArguments & 1) != 0)
            {
                    val_11 = this.tweenArguments;
                val_16 = 0;
            }
            else
            {
                    if((this.tweenArguments & 1) != 0)
            {
                    val_17 = this.tweenArguments;
                val_18 = null;
                UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
                this.vector3s[1] = new UnityEngine.Vector3();
            }
            
                val_13 = "y";
                if((this.tweenArguments & 1) != 0)
            {
                    val_17 = this.tweenArguments;
                val_19 = null;
                UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_2.z});
                this.vector3s[1] = new UnityEngine.Vector3();
            }
            
                if((this.tweenArguments & 1) == 0)
            {
                    return;
            }
            
                val_13 = this.vector3s;
                val_11 = this.tweenArguments;
                val_17 = null;
                UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_2.z});
                val_13[1] = new UnityEngine.Vector3();
                return;
            }
            
            mem2[0] = UnityEngine.Vector3.__il2cppRuntimeField_element_class;
            mem2[0] = null;
            return;
            label_42:
            goto label_42;
        }
        private void GeneratePunchScaleTargets()
        {
            var val_11;
            UnityEngine.Vector3[] val_12;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            val_11 = this;
            this.vector3s = null;
            UnityEngine.Vector3 val_1 = this.thisTransform.localScale;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_20 = val_1.x;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_24 = val_1.y;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_28 = val_1.z;
            val_12 = 1152921504719785984;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            this.vector3s[1] = val_2;
            this.vector3s[1] = val_2.y;
            this.vector3s[1] = val_2.z;
            if((this.tweenArguments & 1) != 0)
            {
                    val_11 = this.tweenArguments;
                val_15 = 0;
            }
            else
            {
                    if((this.tweenArguments & 1) != 0)
            {
                    val_16 = this.tweenArguments;
                val_17 = null;
                UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
                this.vector3s[1] = new UnityEngine.Vector3();
            }
            
                val_12 = "y";
                if((this.tweenArguments & 1) != 0)
            {
                    val_16 = this.tweenArguments;
                val_18 = null;
                UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_2.z});
                this.vector3s[1] = new UnityEngine.Vector3();
            }
            
                if((this.tweenArguments & 1) == 0)
            {
                    return;
            }
            
                val_12 = this.vector3s;
                val_11 = this.tweenArguments;
                val_16 = null;
                UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_2.z});
                val_12[1] = new UnityEngine.Vector3();
                return;
            }
            
            mem2[0] = UnityEngine.Vector3.__il2cppRuntimeField_element_class;
            mem2[0] = null;
            return;
            label_40:
            goto label_40;
        }
        private void ApplyRectTargets()
        {
            var val_5;
            UnityEngine.Rect[] val_6;
            UnityEngine.Rect[] val_7;
            UnityEngine.Rect[] val_8;
            UnityEngine.Rect[] val_9;
            val_5 = this;
            val_6 = this.rects;
            if(this.rects != null)
            {
                goto label_1;
            }
            
            val_6 = this.rects;
            if(val_6 == null)
            {
                goto label_23;
            }
            
            label_1:
            float val_1 = this.ease.Invoke(start:  V0.16B, end:  V0.16B, Value:  this.percentage);
            this.rects[64].startFloat = val_1;
            val_7 = this.rects;
            if(this.rects != null)
            {
                goto label_8;
            }
            
            val_7 = this.rects;
            if(val_7 == null)
            {
                goto label_23;
            }
            
            label_8:
            float val_2 = this.ease.Invoke(start:  val_1, end:  val_1, Value:  this.percentage);
            val_8 = this.rects;
            if(this.rects != null)
            {
                goto label_15;
            }
            
            val_8 = this.rects;
            if(val_8 == null)
            {
                goto label_23;
            }
            
            label_15:
            float val_3 = this.ease.Invoke(start:  val_2, end:  val_2, Value:  this.percentage);
            val_9 = this.rects;
            if(this.rects != null)
            {
                goto label_22;
            }
            
            val_9 = this.rects;
            if(val_9 == null)
            {
                goto label_23;
            }
            
            label_22:
            float val_4 = this.ease.Invoke(start:  val_3, end:  val_3, Value:  this.percentage);
            UnityEngine.Rect val_5 = this.rects[2];
            if(this.percentage != 1f)
            {
                    return;
            }
            
            val_5 = this.rects[1];
            return;
            label_23:
        }
        private void ApplyColorTargets()
        {
            this.colors[2] = this.ease.Invoke(start:  this.colors[0], end:  this.colors[1], Value:  this.percentage);
            this.colors[2] = this.ease.Invoke(start:  this.colors[0], end:  this.colors[1], Value:  this.percentage);
            this.colors[2] = this.ease.Invoke(start:  this.colors[0], end:  this.colors[1], Value:  this.percentage);
            this.colors[2] = this.ease.Invoke(start:  this.colors[0], end:  this.colors[1], Value:  this.percentage);
            UnityEngine.Color val_13 = this.colors[2];
            if(this.percentage != 1f)
            {
                    return;
            }
            
            this = this.colors[1];
        }
        private void ApplyVector3Targets()
        {
            var val_4;
            UnityEngine.Vector3[] val_5;
            UnityEngine.Vector3[] val_6;
            UnityEngine.Vector3[] val_7;
            val_4 = this;
            val_5 = this.vector3s;
            if(this.vector3s != null)
            {
                goto label_1;
            }
            
            val_5 = this.vector3s;
            if(val_5 == null)
            {
                goto label_16;
            }
            
            label_1:
            this.vector3s[2] = this.ease.Invoke(start:  val_5[0], end:  this.vector3s[1], Value:  this.percentage);
            val_6 = this.vector3s;
            if(this.vector3s != null)
            {
                goto label_8;
            }
            
            val_6 = this.vector3s;
            if(val_6 == null)
            {
                goto label_16;
            }
            
            label_8:
            this.vector3s[2] = this.ease.Invoke(start:  val_6[0], end:  this.vector3s[1], Value:  this.percentage);
            val_7 = this.vector3s;
            if(this.vector3s != null)
            {
                goto label_15;
            }
            
            val_7 = this.vector3s;
            if(val_7 == null)
            {
                goto label_16;
            }
            
            label_15:
            this.vector3s[2] = this.ease.Invoke(start:  val_7[0], end:  this.vector3s[1], Value:  this.percentage);
            UnityEngine.Vector3 val_10 = this.vector3s[2];
            UnityEngine.Vector3 val_11 = this.vector3s[2];
            if(this.percentage != 1f)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_12 = this.vector3s[1];
            val_4 = this.vector3s[1];
            return;
            label_16:
        }
        private void ApplyVector2Targets()
        {
            var val_3;
            UnityEngine.Vector2[] val_4;
            UnityEngine.Vector2[] val_5;
            val_3 = this;
            val_4 = this.vector2s;
            if(this.vector2s != null)
            {
                goto label_1;
            }
            
            val_4 = this.vector2s;
            if(val_4 == null)
            {
                goto label_9;
            }
            
            label_1:
            this.vector2s[2] = this.ease.Invoke(start:  val_4[0], end:  this.vector2s[1], Value:  this.percentage);
            val_5 = this.vector2s;
            if(this.vector2s != null)
            {
                goto label_8;
            }
            
            val_5 = this.vector2s;
            if(val_5 == null)
            {
                goto label_9;
            }
            
            label_8:
            this.vector2s[2] = this.ease.Invoke(start:  val_5[0], end:  this.vector2s[1], Value:  this.percentage);
            UnityEngine.Vector2 val_7 = this.vector2s[2];
            if(this.percentage != 1f)
            {
                    return;
            }
            
            val_3 = this.vector2s[1];
            return;
            label_9:
        }
        private void ApplyFloatTargets()
        {
            this.floats[2] = this.ease.Invoke(start:  this.floats[0], end:  this.floats[1], Value:  this.percentage);
            float val_4 = this.floats[2];
            if(this.percentage != 1f)
            {
                    return;
            }
            
            this = this.floats[1];
        }
        private void ApplyColorToTargets()
        {
            var val_35;
            var val_48;
            UnityEngine.Color[,] val_49;
            var val_52;
            val_35 = 0;
            goto label_1;
            label_44:
            var val_2 = X23 + ((X22) << 4);
            val_35 = 1;
            mem2[0] = Invoke(start:  V8.16B, end:  V9.16B, Value:  V10.16B);
            label_1:
            if(val_35 >= (this.colors.GetLength(dimension:  0)))
            {
                goto label_3;
            }
            
            var val_37 = (X23 + (X22) << 4) + 16;
            long val_44 = 1;
            val_37 = 2 + (val_37 * val_44);
            this.colors[val_37] = this.ease.Invoke(start:  this.colors[((X23 + (X22) << 4) + 16) * val_44], end:  this.colors[((X23 + (X22) << 4) + 16) * val_44], Value:  this.percentage);
            val_37 = 2 + (val_37 * val_44);
            this.colors[val_37] = this.ease.Invoke(start:  this.colors[((X23 + (X22) << 4) + 16) * val_44], end:  this.colors[((X23 + (X22) << 4) + 16) * val_44], Value:  this.percentage);
            val_37 = 2 + (val_37 * val_44);
            this.colors[val_37] = this.ease.Invoke(start:  this.colors[((X23 + (X22) << 4) + 16) * val_44], end:  this.colors[((X23 + (X22) << 4) + 16) * val_44], Value:  this.percentage);
            UnityEngine.Color val_42 = this.colors[((X23 + (X22) << 4) + 16) * val_44];
            UnityEngine.Color val_43 = this.colors[((X23 + (X22) << 4) + 16) * val_44];
            val_44 = 2 + (val_37 * val_44);
            if(this.ease != null)
            {
                goto label_44;
            }
            
            goto label_44;
            label_3:
            UnityEngine.Renderer val_15 = this.GetComponent<UnityEngine.Renderer>();
            if((UnityEngine.Object.op_Implicit(exists:  0)) == false)
            {
                goto label_47;
            }
            
            val_48 = 0;
            goto label_48;
            label_60:
            val_35.SetColor(name:  1152921504721543168, value:  new UnityEngine.Color() {r = V8.16B, g = V9.16B, b = V10.16B, a = V11.16B});
            val_48 = 1;
            label_48:
            val_49 = this.colors;
            if(val_48 >= (val_49.GetLength(dimension:  0)))
            {
                goto label_63;
            }
            
            string val_20 = this.namedcolorvalue.ToString();
            UnityEngine.Vector2 val_21 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = V8.16B, y = V9.16B, z = V10.16B});
            this.namedcolorvalue = null;
            UnityEngine.Color val_46 = this.colors[1152921506863536976];
            UnityEngine.Color val_47 = this.colors[1152921506863536976];
            UnityEngine.Color val_48 = this.colors[1152921506863536976];
            UnityEngine.Color val_49 = this.colors[1152921506863536976];
            if((this.GetComponent<UnityEngine.Renderer>().materials[1]) != null)
            {
                goto label_60;
            }
            
            goto label_60;
            label_47:
            val_49 = 1152921510423027296;
            UnityEngine.Light val_22 = this.GetComponent<UnityEngine.Light>();
            if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
            {
                    val_49 = this.colors;
                UnityEngine.Color val_50 = val_49[2];
                UnityEngine.Color val_51 = val_49[2];
                UnityEngine.Color val_52 = val_49[2];
                UnityEngine.Color val_53 = val_49[2];
                this.GetComponent<UnityEngine.Light>().color = new UnityEngine.Color() {r = val_50, g = val_51, b = val_52, a = val_53};
            }
            
            label_63:
            if(this.percentage != 1f)
            {
                    return;
            }
            
            UnityEngine.Renderer val_25 = this.GetComponent<UnityEngine.Renderer>();
            if((UnityEngine.Object.op_Implicit(exists:  0)) == false)
            {
                goto label_71;
            }
            
            val_52 = 0;
            goto label_72;
            label_84:
            val_49.SetColor(name:  1152921504721543168, value:  new UnityEngine.Color() {r = val_50, g = val_51, b = val_52, a = val_53});
            val_52 = 1;
            label_72:
            val_49 = this.colors;
            if(val_52 >= (val_49.GetLength(dimension:  0)))
            {
                    return;
            }
            
            string val_30 = this.namedcolorvalue.ToString();
            UnityEngine.Vector2 val_31 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_50, y = val_51, z = val_52});
            this.namedcolorvalue = null;
            UnityEngine.Color val_55 = this.colors[1152921506863536976];
            UnityEngine.Color val_56 = this.colors[1152921506863536976];
            UnityEngine.Color val_57 = this.colors[1152921506863536976];
            UnityEngine.Color val_58 = this.colors[1152921506863536976];
            if((this.GetComponent<UnityEngine.Renderer>().materials[1]) != null)
            {
                goto label_84;
            }
            
            goto label_84;
            label_71:
            val_49 = 1152921510423027296;
            UnityEngine.Light val_32 = this.GetComponent<UnityEngine.Light>();
            if((UnityEngine.Object.op_Implicit(exists:  0)) == false)
            {
                    return;
            }
            
            this.GetComponent<UnityEngine.Light>().color = new UnityEngine.Color() {r = this.colors[1], g = this.colors[1], b = this.colors[1], a = this.colors[1]};
        }
        private void ApplyAudioToTargets()
        {
            UnityEngine.Vector2[] val_3;
            UnityEngine.Vector2[] val_4;
            val_3 = this.vector2s;
            if(this.vector2s != null)
            {
                goto label_0;
            }
            
            val_3 = this.vector2s;
            if(val_3 == null)
            {
                goto label_8;
            }
            
            label_0:
            this.vector2s[2] = this.ease.Invoke(start:  val_3[0], end:  this.vector2s[1], Value:  this.percentage);
            val_4 = this.vector2s;
            if(this.vector2s != null)
            {
                goto label_7;
            }
            
            val_4 = this.vector2s;
            if(val_4 == null)
            {
                goto label_8;
            }
            
            label_7:
            this.vector2s[2] = this.ease.Invoke(start:  val_4[0], end:  this.vector2s[1], Value:  this.percentage);
            this.audioSource.volume = this.vector2s[2];
            this.audioSource.pitch = this.vector2s[2];
            if(this.percentage != 1f)
            {
                    return;
            }
            
            this.audioSource.volume = this.vector2s[1];
            this.audioSource.pitch = this.vector2s[1];
            return;
            label_8:
        }
        private void ApplyStabTargets()
        {
        
        }
        private void ApplyMoveToPathTargets()
        {
            var val_20;
            float val_24;
            float val_25;
            float val_26;
            float val_27;
            float val_28;
            float val_29;
            var val_30;
            var val_31;
            float val_34;
            var val_35;
            val_20 = this;
            UnityEngine.Vector3 val_1 = this.thisTransform.position;
            this.preUpdate = val_1;
            mem[1152921510447028532] = val_1.y;
            mem[1152921510447028536] = val_1.z;
            float val_2 = this.ease.Invoke(start:  0f, end:  1f, Value:  this.percentage);
            if(this.isLocal != false)
            {
                    UnityEngine.Vector3 val_6 = this.path.Interp(t:  UnityEngine.Mathf.Clamp(value:  val_2, min:  0f, max:  1f));
                val_24 = val_6.x;
                val_25 = val_6.y;
                val_26 = val_6.z;
                val_27 = val_24;
                val_28 = val_25;
                val_29 = val_26;
                this.thisTransform.localPosition = new UnityEngine.Vector3() {x = val_27, y = val_28, z = val_29};
            }
            else
            {
                    UnityEngine.Vector3 val_8 = this.path.Interp(t:  UnityEngine.Mathf.Clamp(value:  val_2, min:  0f, max:  1f));
                val_24 = val_8.x;
                val_25 = val_8.y;
                val_26 = val_8.z;
                val_27 = val_24;
                val_28 = val_25;
                val_29 = val_26;
                this.thisTransform.position = new UnityEngine.Vector3() {x = val_27, y = val_28, z = val_29};
            }
            
            val_30 = "orienttopath";
            if((this.tweenArguments & 1) != 0)
            {
                    val_30 = this.tweenArguments;
                val_31 = null;
                UnityEngine.Vector2 val_9 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_27, y = val_28, z = val_29});
                if(null != null)
            {
                    if((this.tweenArguments & 1) != 0)
            {
                    val_31 = null;
                val_34 = this.tweenArguments;
                UnityEngine.Vector2 val_10 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_29});
            }
            else
            {
                    val_35 = null;
                val_35 = null;
                val_34 = 1152921504852164672;
            }
            
                val_25 = 0f;
                val_26 = 1f;
                val_28 = val_25;
                val_29 = val_26;
                val_24 = UnityEngine.Mathf.Clamp(value:  this.ease.Invoke(start:  val_25, end:  val_26, Value:  UnityEngine.Mathf.Min(a:  1f, b:  val_34 + this.percentage)), min:  val_28, max:  val_29);
                val_27 = val_24;
                UnityEngine.Vector3 val_15 = this.path.Interp(t:  val_27);
                val_30 = val_15;
            }
            
            }
            
            UnityEngine.Vector3 val_16 = this.thisTransform.position;
            this.postUpdate = val_16;
            mem[1152921510447028544] = val_16.y;
            mem[1152921510447028548] = val_16.z;
            if(this.physics == false)
            {
                    return;
            }
            
            this.thisTransform.position = new UnityEngine.Vector3() {x = this.preUpdate, y = val_25, z = val_26};
            val_24 = this.postUpdate;
            val_20 = this.GetComponent<UnityEngine.Rigidbody>();
            val_20.MovePosition(position:  new UnityEngine.Vector3() {x = val_24, y = val_25, z = val_26});
        }
        private void ApplyMoveToTargets()
        {
            UnityEngine.Vector3[] val_7;
            UnityEngine.Vector3[] val_8;
            UnityEngine.Vector3[] val_9;
            bool val_10;
            UnityEngine.Vector3 val_11;
            float val_12;
            float val_13;
            UnityEngine.Vector3 val_1 = this.thisTransform.position;
            this.preUpdate = val_1;
            mem[1152921510447645364] = val_1.y;
            mem[1152921510447645368] = val_1.z;
            val_7 = this.vector3s;
            if(this.vector3s != null)
            {
                goto label_2;
            }
            
            val_7 = this.vector3s;
            if(val_7 == null)
            {
                goto label_17;
            }
            
            label_2:
            this.vector3s[2] = this.ease.Invoke(start:  val_7[0], end:  this.vector3s[1], Value:  this.percentage);
            val_8 = this.vector3s;
            if(this.vector3s != null)
            {
                goto label_9;
            }
            
            val_8 = this.vector3s;
            if(val_8 == null)
            {
                goto label_17;
            }
            
            label_9:
            this.vector3s[2] = this.ease.Invoke(start:  val_8[0], end:  this.vector3s[1], Value:  this.percentage);
            val_9 = this.vector3s;
            if(this.vector3s != null)
            {
                goto label_16;
            }
            
            val_9 = this.vector3s;
            if(val_9 == null)
            {
                goto label_17;
            }
            
            label_16:
            UnityEngine.Vector3 val_12 = this.vector3s[1];
            this.vector3s[2] = this.ease.Invoke(start:  val_9[0], end:  val_12, Value:  this.percentage);
            val_10 = this.isLocal;
            UnityEngine.Vector3 val_13 = this.vector3s[2];
            UnityEngine.Vector3 val_14 = this.vector3s[2];
            val_11 = this.vector3s[2];
            if(val_10 != false)
            {
                    this.thisTransform.localPosition = new UnityEngine.Vector3() {x = val_13, y = val_14, z = val_11};
            }
            else
            {
                    this.thisTransform.position = new UnityEngine.Vector3() {x = val_13, y = val_14, z = val_11};
            }
            
            val_12 = this.percentage;
            val_13 = 1f;
            if(val_12 == val_13)
            {
                    val_10 = this.isLocal;
                val_12 = this.vector3s[1];
                val_13 = this.vector3s[1];
                val_11 = this.vector3s[1];
                if(val_10 != false)
            {
                    this.thisTransform.localPosition = new UnityEngine.Vector3() {x = val_12, y = val_13, z = val_11};
            }
            else
            {
                    this.thisTransform.position = new UnityEngine.Vector3() {x = val_12, y = val_13, z = val_11};
            }
            
            }
            
            UnityEngine.Vector3 val_5 = this.thisTransform.position;
            this.postUpdate = val_5;
            mem[1152921510447645376] = val_5.y;
            mem[1152921510447645380] = val_5.z;
            if(this.physics == false)
            {
                    return;
            }
            
            this.thisTransform.position = new UnityEngine.Vector3() {x = this.preUpdate, y = val_12, z = this.percentage};
            this.GetComponent<UnityEngine.Rigidbody>().MovePosition(position:  new UnityEngine.Vector3() {x = this.postUpdate, y = val_12, z = this.percentage});
            return;
            label_17:
        }
        private void ApplyMoveByTargets()
        {
            UnityEngine.Vector3[] val_13;
            float val_14;
            float val_15;
            float val_16;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            float val_21;
            float val_22;
            float val_23;
            var val_24;
            UnityEngine.Vector3 val_1 = this.thisTransform.position;
            this.preUpdate = val_1;
            mem[1152921510448326708] = val_1.y;
            mem[1152921510448326712] = val_1.z;
            if(((this.tweenArguments & 1) & 1) != 0)
            {
                    UnityEngine.Vector3 val_3 = this.thisTransform.eulerAngles;
                val_13 = this;
                val_14 = val_3.x;
                val_15 = val_3.y;
                val_16 = val_3.z;
                this.thisTransform.eulerAngles = new UnityEngine.Vector3() {x = this.vector3s[4], y = this.vector3s[4], z = this.vector3s[4]};
            }
            else
            {
                    val_16 = 0f;
                val_13 = this.vector3s;
                val_15 = val_16;
                val_14 = val_16;
            }
            
            val_17 = mem[this.vector3s];
            if(mem[this.vector3s] != 0)
            {
                goto label_9;
            }
            
            val_17 = mem[this.vector3s];
            if(val_17 == 0)
            {
                goto label_24;
            }
            
            label_9:
            mem2[0] = this.ease.Invoke(start:  mem[this.vector3s] + 32, end:  mem[this.vector3s] + 44, Value:  this.percentage);
            val_18 = mem[this.vector3s];
            if(mem[this.vector3s] != 0)
            {
                goto label_16;
            }
            
            val_18 = mem[this.vector3s];
            if(val_18 == 0)
            {
                goto label_24;
            }
            
            label_16:
            mem2[0] = this.ease.Invoke(start:  mem[this.vector3s] + 36, end:  mem[this.vector3s] + 48, Value:  this.percentage);
            val_19 = mem[this.vector3s];
            if(mem[this.vector3s] != 0)
            {
                goto label_23;
            }
            
            val_19 = mem[this.vector3s];
            if(val_19 == 0)
            {
                goto label_24;
            }
            
            label_23:
            mem2[0] = this.ease.Invoke(start:  mem[this.vector3s] + 40, end:  mem[this.vector3s] + 52, Value:  this.percentage);
            val_20 = this.vector3s;
            if(this.vector3s == null)
            {
                    val_20 = mem[this.vector3s];
                if(val_20 == 0)
            {
                    val_20 = 0;
            }
            
            }
            
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.vector3s[2], y = this.vector3s[2], z = this.vector3s[2]}, b:  new UnityEngine.Vector3() {x = 7.006492E-45f, y = 0f, z = 0f});
            val_21 = val_7.x;
            val_22 = val_7.y;
            val_23 = val_7.z;
            this.thisTransform.Translate(translation:  new UnityEngine.Vector3() {x = val_21, y = val_22, z = val_23}, relativeTo:  this.space);
            var val_16 = mem[this.vector3s];
            val_24 = val_16;
            if(val_16 == 0)
            {
                    val_24 = mem[this.vector3s];
                if(val_24 == 0)
            {
                    val_24 = 0;
            }
            
            }
            
            val_16 = val_16 + 68;
            mem2[0] = 1;
            mem2[0] = 4194310;
            if((this.tweenArguments & 1) != 0)
            {
                    val_21 = val_14;
                val_22 = val_15;
                val_23 = val_16;
                this.thisTransform.eulerAngles = new UnityEngine.Vector3() {x = val_21, y = val_22, z = val_23};
            }
            
            UnityEngine.Vector3 val_8 = this.thisTransform.position;
            this.postUpdate = val_8;
            mem[1152921510448326720] = val_8.y;
            mem[1152921510448326724] = val_8.z;
            if(this.physics == false)
            {
                    return;
            }
            
            this.thisTransform.position = new UnityEngine.Vector3() {x = this.preUpdate, y = val_15, z = val_14};
            this.GetComponent<UnityEngine.Rigidbody>().MovePosition(position:  new UnityEngine.Vector3() {x = this.postUpdate, y = val_15, z = val_14});
            return;
            label_24:
        }
        private void ApplyScaleToTargets()
        {
            UnityEngine.Vector3[] val_4;
            UnityEngine.Vector3[] val_5;
            UnityEngine.Vector3[] val_6;
            val_4 = this.vector3s;
            if(this.vector3s != null)
            {
                goto label_0;
            }
            
            val_4 = this.vector3s;
            if(val_4 == null)
            {
                goto label_15;
            }
            
            label_0:
            this.vector3s[2] = this.ease.Invoke(start:  val_4[0], end:  this.vector3s[1], Value:  this.percentage);
            val_5 = this.vector3s;
            if(this.vector3s != null)
            {
                goto label_7;
            }
            
            val_5 = this.vector3s;
            if(val_5 == null)
            {
                goto label_15;
            }
            
            label_7:
            this.vector3s[2] = this.ease.Invoke(start:  val_5[0], end:  this.vector3s[1], Value:  this.percentage);
            val_6 = this.vector3s;
            if(this.vector3s != null)
            {
                goto label_14;
            }
            
            val_6 = this.vector3s;
            if(val_6 == null)
            {
                goto label_15;
            }
            
            label_14:
            this.vector3s[2] = this.ease.Invoke(start:  val_6[0], end:  this.vector3s[1], Value:  this.percentage);
            this.thisTransform.localScale = new UnityEngine.Vector3() {x = this.vector3s[2], y = this.vector3s[2], z = this.vector3s[2]};
            if(this.percentage != 1f)
            {
                    return;
            }
            
            this.thisTransform.localScale = new UnityEngine.Vector3() {x = this.vector3s[1], y = this.vector3s[1], z = this.vector3s[1]};
            return;
            label_15:
        }
        private void ApplyLookToTargets()
        {
            UnityEngine.Vector3[] val_8;
            UnityEngine.Vector3[] val_9;
            UnityEngine.Vector3[] val_10;
            val_8 = this.vector3s;
            if(this.vector3s != null)
            {
                goto label_1;
            }
            
            val_8 = this.vector3s;
            if(val_8 == null)
            {
                goto label_16;
            }
            
            label_1:
            this.vector3s[2] = this.ease.Invoke(start:  val_8[0], end:  this.vector3s[1], Value:  this.percentage);
            val_9 = this.vector3s;
            if(this.vector3s != null)
            {
                goto label_8;
            }
            
            val_9 = this.vector3s;
            if(val_9 == null)
            {
                goto label_16;
            }
            
            label_8:
            this.vector3s[2] = this.ease.Invoke(start:  val_9[0], end:  this.vector3s[1], Value:  this.percentage);
            val_10 = this.vector3s;
            if(this.vector3s != null)
            {
                goto label_15;
            }
            
            val_10 = this.vector3s;
            if(val_10 == null)
            {
                goto label_16;
            }
            
            label_15:
            this.vector3s[2] = this.ease.Invoke(start:  val_10[0], end:  this.vector3s[1], Value:  this.percentage);
            if(this.isLocal != false)
            {
                    UnityEngine.Quaternion val_6 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = this.vector3s[2], y = this.vector3s[2], z = this.vector3s[2]});
                this.thisTransform.localRotation = new UnityEngine.Quaternion() {x = val_6.x, y = val_6.y, z = val_6.z, w = val_6.w};
                return;
            }
            
            UnityEngine.Quaternion val_7 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = this.vector3s[2], y = this.vector3s[2], z = this.vector3s[2]});
            this.thisTransform.rotation = new UnityEngine.Quaternion() {x = val_7.x, y = val_7.y, z = val_7.z, w = val_7.w};
            return;
            label_16:
        }
        private void ApplyRotateToTargets()
        {
            UnityEngine.Vector3[] val_16;
            UnityEngine.Vector3[] val_17;
            UnityEngine.Vector3[] val_18;
            bool val_19;
            float val_23;
            float val_24;
            float val_25;
            float val_26;
            float val_27;
            float val_28;
            float val_29;
            UnityEngine.Vector3 val_1 = this.thisTransform.eulerAngles;
            this.preUpdate = val_1;
            mem[1152921510450854068] = val_1.y;
            mem[1152921510450854072] = val_1.z;
            val_16 = this.vector3s;
            if(this.vector3s != null)
            {
                goto label_2;
            }
            
            val_16 = this.vector3s;
            if(val_16 == null)
            {
                goto label_17;
            }
            
            label_2:
            this.vector3s[2] = this.ease.Invoke(start:  val_16[0], end:  this.vector3s[1], Value:  this.percentage);
            val_17 = this.vector3s;
            if(this.vector3s != null)
            {
                goto label_9;
            }
            
            val_17 = this.vector3s;
            if(val_17 == null)
            {
                goto label_17;
            }
            
            label_9:
            this.vector3s[2] = this.ease.Invoke(start:  val_17[0], end:  this.vector3s[1], Value:  this.percentage);
            val_18 = this.vector3s;
            if(this.vector3s != null)
            {
                goto label_16;
            }
            
            val_18 = this.vector3s;
            if(val_18 == null)
            {
                goto label_17;
            }
            
            label_16:
            this.vector3s[2] = this.ease.Invoke(start:  val_18[0], end:  this.vector3s[1], Value:  this.percentage);
            val_19 = this.isLocal;
            if(val_19 != false)
            {
                    UnityEngine.Quaternion val_7 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = this.vector3s[2], y = this.vector3s[2], z = this.vector3s[2]});
                val_23 = val_7.x;
                val_24 = val_7.y;
                val_25 = val_7.z;
                val_26 = val_25;
                val_27 = val_7.w;
                this.thisTransform.localRotation = new UnityEngine.Quaternion() {x = val_23, y = val_24, z = val_26, w = val_27};
            }
            else
            {
                    UnityEngine.Quaternion val_8 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = this.vector3s[2], y = this.vector3s[2], z = this.vector3s[2]});
                val_23 = val_8.x;
                val_24 = val_8.y;
                val_25 = val_8.z;
                val_26 = val_25;
                val_27 = val_8.w;
                this.thisTransform.rotation = new UnityEngine.Quaternion() {x = val_23, y = val_24, z = val_26, w = val_27};
            }
            
            val_28 = this.percentage;
            val_29 = 1f;
            if(val_28 == val_29)
            {
                    val_19 = this.isLocal;
                if(val_19 != false)
            {
                    UnityEngine.Quaternion val_11 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = this.vector3s[1], y = this.vector3s[1], z = this.vector3s[1]});
                val_23 = val_11.x;
                val_24 = val_11.y;
                val_25 = val_11.z;
                val_28 = val_23;
                val_29 = val_24;
                val_26 = val_25;
                val_27 = val_11.w;
                this.thisTransform.localRotation = new UnityEngine.Quaternion() {x = val_28, y = val_29, z = val_26, w = val_27};
            }
            else
            {
                    UnityEngine.Quaternion val_12 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = this.vector3s[1], y = this.vector3s[1], z = this.vector3s[1]});
                val_23 = val_12.x;
                val_24 = val_12.y;
                val_25 = val_12.z;
                val_28 = val_23;
                val_29 = val_24;
                val_26 = val_25;
                val_27 = val_12.w;
                this.thisTransform.rotation = new UnityEngine.Quaternion() {x = val_28, y = val_29, z = val_26, w = val_27};
            }
            
            }
            
            UnityEngine.Vector3 val_13 = this.thisTransform.eulerAngles;
            this.postUpdate = val_13;
            mem[1152921510450854080] = val_13.y;
            mem[1152921510450854084] = val_13.z;
            if(this.physics == false)
            {
                    return;
            }
            
            this.thisTransform.eulerAngles = new UnityEngine.Vector3() {x = this.preUpdate, y = val_24, z = val_25};
            UnityEngine.Quaternion val_15 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = this.postUpdate, y = val_24, z = this.preUpdate});
            this.GetComponent<UnityEngine.Rigidbody>().MoveRotation(rot:  new UnityEngine.Quaternion() {x = val_15.x, y = val_15.y, z = val_15.z, w = val_15.w});
            return;
            label_17:
        }
        private void ApplyRotateAddTargets()
        {
            UnityEngine.Vector3[] val_9;
            UnityEngine.Vector3[] val_10;
            UnityEngine.Vector3[] val_11;
            UnityEngine.Vector3[] val_12;
            UnityEngine.Vector3[] val_13;
            UnityEngine.Vector3 val_1 = this.thisTransform.eulerAngles;
            this.preUpdate = val_1;
            mem[1152921510451924532] = val_1.y;
            mem[1152921510451924536] = val_1.z;
            val_9 = this.vector3s;
            if(this.vector3s != null)
            {
                goto label_2;
            }
            
            val_9 = this.vector3s;
            if(val_9 == null)
            {
                goto label_17;
            }
            
            label_2:
            this.vector3s[2] = this.ease.Invoke(start:  val_9[0], end:  this.vector3s[1], Value:  this.percentage);
            val_10 = this.vector3s;
            if(this.vector3s != null)
            {
                goto label_9;
            }
            
            val_10 = this.vector3s;
            if(val_10 == null)
            {
                goto label_17;
            }
            
            label_9:
            this.vector3s[2] = this.ease.Invoke(start:  val_10[0], end:  this.vector3s[1], Value:  this.percentage);
            val_11 = this.vector3s;
            if(this.vector3s != null)
            {
                goto label_16;
            }
            
            val_11 = this.vector3s;
            if(val_11 == null)
            {
                goto label_17;
            }
            
            label_16:
            this.vector3s[2] = this.ease.Invoke(start:  val_11[0], end:  this.vector3s[1], Value:  this.percentage);
            val_12 = this.vector3s;
            if(this.vector3s == null)
            {
                    val_12 = this.vector3s;
                if(val_12 == null)
            {
                    val_12 = 0;
            }
            
            }
            
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.vector3s[2], y = this.vector3s[2], z = this.vector3s[2]}, b:  new UnityEngine.Vector3() {x = 7.006492E-45f, y = 0f, z = 0f});
            this.thisTransform.Rotate(eulerAngles:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, relativeTo:  this.space);
            val_13 = this.vector3s;
            if(this.vector3s == null)
            {
                    val_13 = this.vector3s;
                if(val_13 == null)
            {
                    val_13 = 0;
            }
            
            }
            
            mem2[0] = 1;
            mem2[0] = 4194310;
            UnityEngine.Vector3 val_6 = this.thisTransform.eulerAngles;
            this.postUpdate = val_6;
            mem[1152921510451924544] = val_6.y;
            mem[1152921510451924548] = val_6.z;
            if(this.physics == false)
            {
                    return;
            }
            
            this.thisTransform.eulerAngles = new UnityEngine.Vector3() {x = this.preUpdate, y = val_5.y, z = val_5.z};
            UnityEngine.Quaternion val_8 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = this.postUpdate, y = val_5.y, z = this.preUpdate});
            this.GetComponent<UnityEngine.Rigidbody>().MoveRotation(rot:  new UnityEngine.Quaternion() {x = val_8.x, y = val_8.y, z = val_8.z, w = val_8.w});
            return;
            label_17:
        }
        private void ApplyShakePositionTargets()
        {
            float val_19;
            float val_20;
            float val_21;
            UnityEngine.Vector3 val_22;
            UnityEngine.Vector3[] val_23;
            var val_24;
            var val_25;
            var val_26;
            var val_27;
            float val_31;
            float val_32;
            float val_33;
            float val_34;
            if(this.isLocal != false)
            {
                    UnityEngine.Vector3 val_1 = this.thisTransform.localPosition;
            }
            else
            {
                    UnityEngine.Vector3 val_2 = this.thisTransform.position;
            }
            
            this.preUpdate = val_2;
            mem[1152921510452749236] = val_2.y;
            mem[1152921510452749240] = val_2.z;
            if((this.tweenArguments & 1) != 0)
            {
                    UnityEngine.Vector3 val_3 = this.thisTransform.eulerAngles;
                val_19 = val_3.x;
                val_20 = val_3.y;
                val_21 = val_3.z;
                val_22 = this.vector3s[3];
                this.thisTransform.eulerAngles = new UnityEngine.Vector3() {x = this.vector3s[3], y = val_22, z = this.vector3s[3]};
            }
            else
            {
                    val_21 = 0f;
                val_20 = val_21;
                val_19 = val_21;
            }
            
            if(this.percentage == 0f)
            {
                    val_23 = this;
                val_22 = this.vector3s[1];
                this.thisTransform.Translate(translation:  new UnityEngine.Vector3() {x = this.vector3s[1], y = val_22, z = this.vector3s[1]}, relativeTo:  this.space);
            }
            else
            {
                    val_23 = this.vector3s;
            }
            
            UnityEngine.Vector3 val_20 = this.vector3s[0];
            UnityEngine.Vector3 val_21 = this.vector3s[0];
            UnityEngine.Vector3 val_22 = this.vector3s[0];
            if(this.isLocal != false)
            {
                    this.thisTransform.localPosition = new UnityEngine.Vector3() {x = val_20, y = val_21, z = val_22};
            }
            else
            {
                    this.thisTransform.position = new UnityEngine.Vector3() {x = val_20, y = val_21, z = val_22};
            }
            
            val_24 = this.vector3s;
            if(this.vector3s != null)
            {
                goto label_21;
            }
            
            val_24 = mem[this.vector3s];
            if(val_24 == 0)
            {
                goto label_34;
            }
            
            label_21:
            float val_23 = 1f;
            val_23 = val_23 - this.percentage;
            float val_24 = mem[this.vector3s] + 44;
            val_24 = val_23 * val_24;
            this.vector3s[2] = UnityEngine.Random.Range(min:  -(val_23 * (mem[this.vector3s] + 44)), max:  val_24);
            val_25 = mem[this.vector3s];
            if(mem[this.vector3s] != 0)
            {
                goto label_27;
            }
            
            val_25 = mem[this.vector3s];
            if(val_25 == 0)
            {
                goto label_34;
            }
            
            label_27:
            float val_25 = mem[this.vector3s] + 48;
            val_25 = val_23 * val_25;
            mem2[0] = UnityEngine.Random.Range(min:  -(val_23 * (mem[this.vector3s] + 48)), max:  val_25);
            val_26 = mem[this.vector3s];
            if(mem[this.vector3s] != 0)
            {
                goto label_33;
            }
            
            val_26 = mem[this.vector3s];
            if(val_26 == 0)
            {
                goto label_34;
            }
            
            label_33:
            float val_26 = mem[this.vector3s] + 52;
            val_26 = val_23 * val_26;
            mem2[0] = UnityEngine.Random.Range(min:  -(val_23 * (mem[this.vector3s] + 52)), max:  val_26);
            if(this.isLocal != false)
            {
                    UnityEngine.Vector3 val_10 = this.thisTransform.localPosition;
                val_27 = mem[this.vector3s];
                UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, b:  new UnityEngine.Vector3() {x = mem[this.vector3s] + 56, y = mem[this.vector3s] + 56 + 4, z = mem[this.vector3s] + 64});
                val_31 = val_11.y;
                val_32 = val_11.x;
                val_33 = val_31;
                val_34 = val_11.z;
                this.thisTransform.localPosition = new UnityEngine.Vector3() {x = val_32, y = val_33, z = val_34};
            }
            else
            {
                    UnityEngine.Vector3 val_12 = this.thisTransform.position;
                val_27 = mem[this.vector3s];
                UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, b:  new UnityEngine.Vector3() {x = mem[this.vector3s] + 56, y = mem[this.vector3s] + 56 + 4, z = mem[this.vector3s] + 64});
                val_31 = val_13.y;
                val_32 = val_13.x;
                val_33 = val_31;
                val_34 = val_13.z;
                this.thisTransform.position = new UnityEngine.Vector3() {x = val_32, y = val_33, z = val_34};
            }
            
            if((this.tweenArguments & 1) != 0)
            {
                    val_32 = val_19;
                val_33 = val_20;
                val_34 = val_21;
                this.thisTransform.eulerAngles = new UnityEngine.Vector3() {x = val_32, y = val_33, z = val_34};
            }
            
            UnityEngine.Vector3 val_14 = this.thisTransform.position;
            this.postUpdate = val_14;
            mem[1152921510452749248] = val_14.y;
            mem[1152921510452749252] = val_14.z;
            if(this.physics == false)
            {
                    return;
            }
            
            this.thisTransform.position = new UnityEngine.Vector3() {x = this.preUpdate, y = val_21, z = val_19};
            this.GetComponent<UnityEngine.Rigidbody>().MovePosition(position:  new UnityEngine.Vector3() {x = this.postUpdate, y = val_21, z = val_19});
            return;
            label_34:
        }
        private void ApplyShakeScaleTargets()
        {
            UnityEngine.Vector3[] val_9;
            var val_10;
            var val_11;
            var val_12;
            if(this.percentage == 0f)
            {
                    val_9 = this;
                this.thisTransform.localScale = new UnityEngine.Vector3() {x = this.vector3s[1], y = this.vector3s[1], z = this.vector3s[1]};
            }
            else
            {
                    val_9 = this.vector3s;
            }
            
            this.thisTransform.localScale = new UnityEngine.Vector3() {x = this.vector3s[0], y = this.vector3s[0], z = this.vector3s[0]};
            val_10 = this.vector3s;
            if(this.vector3s != null)
            {
                goto label_9;
            }
            
            val_10 = mem[this.vector3s];
            if(val_10 == 0)
            {
                goto label_22;
            }
            
            label_9:
            float val_15 = 1f;
            val_15 = val_15 - this.percentage;
            float val_16 = mem[this.vector3s] + 44;
            val_16 = val_15 * val_16;
            this.vector3s[2] = UnityEngine.Random.Range(min:  -(val_15 * (mem[this.vector3s] + 44)), max:  val_16);
            val_11 = mem[this.vector3s];
            if(mem[this.vector3s] != 0)
            {
                goto label_15;
            }
            
            val_11 = mem[this.vector3s];
            if(val_11 == 0)
            {
                goto label_22;
            }
            
            label_15:
            float val_17 = mem[this.vector3s] + 48;
            val_17 = val_15 * val_17;
            mem2[0] = UnityEngine.Random.Range(min:  -(val_15 * (mem[this.vector3s] + 48)), max:  val_17);
            val_12 = mem[this.vector3s];
            if(mem[this.vector3s] != 0)
            {
                goto label_21;
            }
            
            val_12 = mem[this.vector3s];
            if(val_12 == 0)
            {
                goto label_22;
            }
            
            label_21:
            float val_18 = mem[this.vector3s] + 52;
            val_18 = val_15 * val_18;
            mem2[0] = UnityEngine.Random.Range(min:  -(val_15 * (mem[this.vector3s] + 52)), max:  val_18);
            UnityEngine.Vector3 val_7 = this.thisTransform.localScale;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, b:  new UnityEngine.Vector3() {x = mem[this.vector3s] + 56, y = mem[this.vector3s] + 56 + 4, z = mem[this.vector3s] + 64});
            this.thisTransform.localScale = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
            return;
            label_22:
        }
        private void ApplyShakeRotationTargets()
        {
            UnityEngine.Vector3[] val_11;
            var val_12;
            var val_13;
            var val_14;
            UnityEngine.Vector3 val_1 = this.thisTransform.eulerAngles;
            this.preUpdate = val_1;
            mem[1152921510453595828] = val_1.y;
            mem[1152921510453595832] = val_1.z;
            if(this.percentage == 0f)
            {
                    val_11 = this;
                this.thisTransform.Rotate(eulerAngles:  new UnityEngine.Vector3() {x = this.vector3s[1], y = this.vector3s[1], z = this.vector3s[1]}, relativeTo:  this.space);
            }
            else
            {
                    val_11 = this.vector3s;
            }
            
            this.thisTransform.eulerAngles = new UnityEngine.Vector3() {x = this.vector3s[0], y = this.vector3s[0], z = this.vector3s[0]};
            val_12 = this.vector3s;
            if(this.vector3s != null)
            {
                goto label_10;
            }
            
            val_12 = mem[this.vector3s];
            if(val_12 == 0)
            {
                goto label_23;
            }
            
            label_10:
            float val_17 = 1f;
            val_17 = val_17 - this.percentage;
            float val_18 = mem[this.vector3s] + 44;
            val_18 = val_17 * val_18;
            this.vector3s[2] = UnityEngine.Random.Range(min:  -(val_17 * (mem[this.vector3s] + 44)), max:  val_18);
            val_13 = mem[this.vector3s];
            if(mem[this.vector3s] != 0)
            {
                goto label_16;
            }
            
            val_13 = mem[this.vector3s];
            if(val_13 == 0)
            {
                goto label_23;
            }
            
            label_16:
            float val_19 = mem[this.vector3s] + 48;
            val_19 = val_17 * val_19;
            mem2[0] = UnityEngine.Random.Range(min:  -(val_17 * (mem[this.vector3s] + 48)), max:  val_19);
            val_14 = mem[this.vector3s];
            if(mem[this.vector3s] != 0)
            {
                goto label_22;
            }
            
            val_14 = mem[this.vector3s];
            if(val_14 == 0)
            {
                goto label_23;
            }
            
            label_22:
            float val_20 = mem[this.vector3s] + 52;
            val_20 = val_17 * val_20;
            mem2[0] = UnityEngine.Random.Range(min:  -(val_17 * (mem[this.vector3s] + 52)), max:  val_20);
            this.thisTransform.Rotate(eulerAngles:  new UnityEngine.Vector3() {x = this.vector3s[2], y = this.vector3s[2], z = this.vector3s[2]}, relativeTo:  this.space);
            UnityEngine.Vector3 val_8 = this.thisTransform.eulerAngles;
            this.postUpdate = val_8;
            mem[1152921510453595840] = val_8.y;
            mem[1152921510453595844] = val_8.z;
            if(this.physics == false)
            {
                    return;
            }
            
            this.thisTransform.eulerAngles = new UnityEngine.Vector3() {x = this.preUpdate, y = val_17, z = mem[this.vector3s] + 44};
            UnityEngine.Quaternion val_10 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = this.postUpdate, y = val_17, z = this.preUpdate});
            this.GetComponent<UnityEngine.Rigidbody>().MoveRotation(rot:  new UnityEngine.Quaternion() {x = val_10.x, y = val_10.y, z = val_10.z, w = val_10.w});
            return;
            label_23:
        }
        private void ApplyPunchPositionTargets()
        {
            UnityEngine.Vector3[] val_16;
            float val_17;
            float val_18;
            float val_19;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            float val_24;
            float val_25;
            float val_26;
            var val_27;
            UnityEngine.Vector3 val_1 = this.thisTransform.position;
            this.preUpdate = val_1;
            mem[1152921510454002740] = val_1.y;
            mem[1152921510454002744] = val_1.z;
            if(((this.tweenArguments & 1) & 1) != 0)
            {
                    UnityEngine.Vector3 val_3 = this.thisTransform.eulerAngles;
                val_16 = this;
                val_17 = val_3.x;
                val_18 = val_3.y;
                val_19 = val_3.z;
                this.thisTransform.eulerAngles = new UnityEngine.Vector3() {x = this.vector3s[4], y = this.vector3s[4], z = this.vector3s[4]};
            }
            else
            {
                    val_19 = 0f;
                val_16 = this.vector3s;
                val_18 = val_19;
                val_17 = val_19;
            }
            
            if((mem[this.vector3s] + 44) <= 0f)
            {
                goto label_12;
            }
            
            mem2[0] = this.tweenArguments.punch(amplitude:  mem[this.vector3s] + 44, value:  this.percentage);
            goto label_18;
            label_12:
            if((mem[this.vector3s] + 44) >= 0)
            {
                goto label_18;
            }
            
            val_20 = mem[this.vector3s];
            if(mem[this.vector3s] != 0)
            {
                goto label_19;
            }
            
            val_20 = mem[this.vector3s];
            if(val_20 == 0)
            {
                goto label_52;
            }
            
            label_19:
            mem2[0] = -(punch(amplitude:  System.Math.Abs(mem[this.vector3s] + 44), value:  this.percentage));
            label_18:
            if((mem[this.vector3s] + 48) <= 0f)
            {
                goto label_28;
            }
            
            mem2[0] = punch(amplitude:  mem[this.vector3s] + 48, value:  this.percentage);
            goto label_34;
            label_28:
            if((mem[this.vector3s] + 48) >= 0)
            {
                goto label_34;
            }
            
            val_21 = mem[this.vector3s];
            if(mem[this.vector3s] != 0)
            {
                goto label_35;
            }
            
            val_21 = mem[this.vector3s];
            if(val_21 == 0)
            {
                goto label_52;
            }
            
            label_35:
            mem2[0] = -(punch(amplitude:  System.Math.Abs(mem[this.vector3s] + 48), value:  this.percentage));
            label_34:
            if((mem[this.vector3s] + 52) <= 0f)
            {
                goto label_44;
            }
            
            mem2[0] = punch(amplitude:  mem[this.vector3s] + 52, value:  this.percentage);
            goto label_50;
            label_44:
            if((mem[this.vector3s] + 52) >= 0)
            {
                goto label_50;
            }
            
            val_22 = mem[this.vector3s];
            if(mem[this.vector3s] != 0)
            {
                goto label_51;
            }
            
            val_22 = mem[this.vector3s];
            if(val_22 == 0)
            {
                goto label_52;
            }
            
            label_51:
            mem2[0] = -(punch(amplitude:  System.Math.Abs(mem[this.vector3s] + 52), value:  this.percentage));
            label_50:
            val_23 = this.vector3s;
            if(this.vector3s == null)
            {
                    val_23 = mem[this.vector3s];
                if(val_23 == 0)
            {
                    val_23 = 0;
            }
            
            }
            
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.vector3s[2], y = this.vector3s[2], z = this.vector3s[2]}, b:  new UnityEngine.Vector3() {x = 7.006492E-45f, y = 0f, z = 0f});
            val_24 = val_10.x;
            val_25 = val_10.y;
            val_26 = val_10.z;
            this.thisTransform.Translate(translation:  new UnityEngine.Vector3() {x = val_24, y = val_25, z = val_26}, relativeTo:  this.space);
            var val_22 = mem[this.vector3s];
            val_27 = val_22;
            if(val_22 == 0)
            {
                    val_27 = mem[this.vector3s];
                if(val_27 == 0)
            {
                    val_27 = 0;
            }
            
            }
            
            val_22 = val_22 + 68;
            mem2[0] = 1;
            mem2[0] = 4194310;
            if((this.tweenArguments & 1) != 0)
            {
                    val_24 = val_17;
                val_25 = val_18;
                val_26 = val_19;
                this.thisTransform.eulerAngles = new UnityEngine.Vector3() {x = val_24, y = val_25, z = val_26};
            }
            
            UnityEngine.Vector3 val_11 = this.thisTransform.position;
            this.postUpdate = val_11;
            mem[1152921510454002752] = val_11.y;
            mem[1152921510454002756] = val_11.z;
            if(this.physics == false)
            {
                    return;
            }
            
            this.thisTransform.position = new UnityEngine.Vector3() {x = this.preUpdate, y = val_18, z = val_17};
            this.GetComponent<UnityEngine.Rigidbody>().MovePosition(position:  new UnityEngine.Vector3() {x = this.postUpdate, y = val_18, z = val_17});
            return;
            label_52:
        }
        private void ApplyPunchRotationTargets()
        {
            UnityEngine.Vector3[] val_13;
            UnityEngine.Vector3[] val_14;
            UnityEngine.Vector3[] val_15;
            UnityEngine.Vector3[] val_16;
            UnityEngine.Vector3[] val_17;
            UnityEngine.Vector3 val_1 = this.thisTransform.eulerAngles;
            this.preUpdate = val_1;
            mem[1152921510454954420] = val_1.y;
            mem[1152921510454954424] = val_1.z;
            if(this.vector3s[1] <= 0f)
            {
                goto label_5;
            }
            
            this.vector3s[2] = this.thisTransform.punch(amplitude:  this.vector3s[1], value:  this.percentage);
            goto label_11;
            label_5:
            if(this.vector3s[1] >= 0)
            {
                goto label_11;
            }
            
            val_13 = this.vector3s;
            if(this.vector3s != null)
            {
                goto label_12;
            }
            
            val_13 = this.vector3s;
            if(val_13 == null)
            {
                goto label_45;
            }
            
            label_12:
            this.vector3s[2] = -(punch(amplitude:  System.Math.Abs(val_13[1]), value:  this.percentage));
            label_11:
            if(this.vector3s[1] <= 0f)
            {
                goto label_21;
            }
            
            this.vector3s[2] = punch(amplitude:  this.vector3s[1], value:  this.percentage);
            goto label_27;
            label_21:
            if(this.vector3s[1] >= 0)
            {
                goto label_27;
            }
            
            val_14 = this.vector3s;
            if(this.vector3s != null)
            {
                goto label_28;
            }
            
            val_14 = this.vector3s;
            if(val_14 == null)
            {
                goto label_45;
            }
            
            label_28:
            this.vector3s[2] = -(punch(amplitude:  System.Math.Abs(val_14[1]), value:  this.percentage));
            label_27:
            if(this.vector3s[1] <= 0f)
            {
                goto label_37;
            }
            
            this.vector3s[2] = punch(amplitude:  this.vector3s[1], value:  this.percentage);
            goto label_43;
            label_37:
            if(this.vector3s[1] >= 0)
            {
                goto label_43;
            }
            
            val_15 = this.vector3s;
            if(this.vector3s != null)
            {
                goto label_44;
            }
            
            val_15 = this.vector3s;
            if(val_15 == null)
            {
                goto label_45;
            }
            
            label_44:
            this.vector3s[2] = -(punch(amplitude:  System.Math.Abs(val_15[1]), value:  this.percentage));
            label_43:
            val_16 = this.vector3s;
            if(this.vector3s == null)
            {
                    val_16 = this.vector3s;
                if(val_16 == null)
            {
                    val_16 = 0;
            }
            
            }
            
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.vector3s[2], y = this.vector3s[2], z = this.vector3s[2]}, b:  new UnityEngine.Vector3() {x = 7.006492E-45f, y = 0f, z = 0f});
            this.thisTransform.Rotate(eulerAngles:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, relativeTo:  this.space);
            val_17 = this.vector3s;
            if(this.vector3s == null)
            {
                    val_17 = this.vector3s;
                if(val_17 == null)
            {
                    val_17 = 0;
            }
            
            }
            
            mem2[0] = 1;
            mem2[0] = 4194310;
            UnityEngine.Vector3 val_9 = this.thisTransform.eulerAngles;
            this.postUpdate = val_9;
            mem[1152921510454954432] = val_9.y;
            mem[1152921510454954436] = val_9.z;
            if(this.physics == false)
            {
                    return;
            }
            
            this.thisTransform.eulerAngles = new UnityEngine.Vector3() {x = this.preUpdate, y = val_8.y, z = val_8.z};
            UnityEngine.Quaternion val_11 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = this.postUpdate, y = val_8.y, z = this.preUpdate});
            this.GetComponent<UnityEngine.Rigidbody>().MoveRotation(rot:  new UnityEngine.Quaternion() {x = val_11.x, y = val_11.y, z = val_11.z, w = val_11.w});
            return;
            label_45:
        }
        private void ApplyPunchScaleTargets()
        {
            UnityEngine.Vector3[] val_9;
            UnityEngine.Vector3[] val_10;
            UnityEngine.Vector3[] val_11;
            UnityEngine.Vector3[] val_12;
            if(this.vector3s[1] <= 0f)
            {
                goto label_4;
            }
            
            this.vector3s[2] = this.punch(amplitude:  this.vector3s[1], value:  this.percentage);
            goto label_10;
            label_4:
            if(this.vector3s[1] >= 0)
            {
                goto label_10;
            }
            
            val_9 = this.vector3s;
            if(this.vector3s != null)
            {
                goto label_11;
            }
            
            val_9 = this.vector3s;
            if(val_9 == null)
            {
                goto label_44;
            }
            
            label_11:
            this.vector3s[2] = -(punch(amplitude:  System.Math.Abs(val_9[1]), value:  this.percentage));
            label_10:
            if(this.vector3s[1] <= 0f)
            {
                goto label_20;
            }
            
            this.vector3s[2] = punch(amplitude:  this.vector3s[1], value:  this.percentage);
            goto label_26;
            label_20:
            if(this.vector3s[1] >= 0)
            {
                goto label_26;
            }
            
            val_10 = this.vector3s;
            if(this.vector3s != null)
            {
                goto label_27;
            }
            
            val_10 = this.vector3s;
            if(val_10 == null)
            {
                goto label_44;
            }
            
            label_27:
            this.vector3s[2] = -(punch(amplitude:  System.Math.Abs(val_10[1]), value:  this.percentage));
            label_26:
            if(this.vector3s[1] <= 0f)
            {
                goto label_36;
            }
            
            this.vector3s[2] = punch(amplitude:  this.vector3s[1], value:  this.percentage);
            goto label_42;
            label_36:
            if(this.vector3s[1] >= 0)
            {
                goto label_42;
            }
            
            val_11 = this.vector3s;
            if(this.vector3s != null)
            {
                goto label_43;
            }
            
            val_11 = this.vector3s;
            if(val_11 == null)
            {
                goto label_44;
            }
            
            label_43:
            this.vector3s[2] = -(punch(amplitude:  System.Math.Abs(val_11[1]), value:  this.percentage));
            label_42:
            val_12 = this.vector3s;
            if(this.vector3s == null)
            {
                    val_12 = this.vector3s;
                if(val_12 == null)
            {
                    val_12 = 0;
            }
            
            }
            
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.vector3s[0], y = this.vector3s[0], z = this.vector3s[0]}, b:  new UnityEngine.Vector3() {x = 5.87748E-39f, y = 2.295924E-39f, z = 1.401298E-45f});
            this.thisTransform.localScale = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
            return;
            label_44:
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator TweenDelay()
        {
            typeof(SA_iTween.<TweenDelay>c__Iterator0).__il2cppRuntimeField_10 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        private void TweenStart()
        {
            UnityEngine.AudioClip val_17;
            this.CallBack(callbackType:  "onstart");
            if(this.loop != true)
            {
                    this.ConflictCheck();
                this.GenerateTargets();
            }
            
            if((System.String.op_Equality(a:  0, b:  this.type)) != false)
            {
                    if(this.audioSource != null)
            {
                    val_17 = this.audioSource.clip;
            }
            else
            {
                    val_17 = 0.clip;
            }
            
                this.audioSource.PlayOneShot(clip:  val_17);
            }
            
            if((((((System.String.op_Equality(a:  0, b:  this.type)) != true) && ((System.String.op_Equality(a:  0, b:  this.type)) != true)) && ((System.String.op_Equality(a:  0, b:  this.type)) != true)) && ((System.String.op_Equality(a:  0, b:  this.type)) != true)) && ((System.String.op_Equality(a:  0, b:  this.type)) != true))
            {
                    if((System.String.op_Equality(a:  0, b:  this.type)) != true)
            {
                    bool val_16 = System.String.op_Equality(a:  0, b:  this.type);
            }
            
            }
            
            this.isRunning = true;
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator TweenRestart()
        {
            typeof(SA_iTween.<TweenRestart>c__Iterator1).__il2cppRuntimeField_10 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        private void TweenUpdate()
        {
            this.apply.Invoke();
            this.CallBack(callbackType:  "onupdate");
            this.UpdatePercentage();
        }
        private void TweenComplete()
        {
            this.isRunning = false;
            this.percentage = (this.percentage > 0.5f) ? 1f : 0f;
            this.apply.Invoke();
            if((System.String.op_Equality(a:  0, b:  this.type)) != false)
            {
                    this.CallBack(callbackType:  "onupdate");
            }
            
            if(this.loopType != 0)
            {
                    this.TweenLoop();
            }
            else
            {
                    this.Dispose();
            }
            
            this.CallBack(callbackType:  "oncomplete");
        }
        private void TweenLoop()
        {
            string val_2;
            if(this.loopType != 2)
            {
                    if(this.loopType != 1)
            {
                    return;
            }
            
                this.runningTime = 0f;
                this.percentage = 0f;
                this.apply.Invoke();
                val_2 = "TweenRestart";
            }
            else
            {
                    bool val_2 = this.reverse;
                this.runningTime = 0f;
                val_2 = val_2 ^ 1;
                this.reverse = val_2;
                val_2 = "TweenRestart";
            }
            
            UnityEngine.Coroutine val_1 = this.StartCoroutine(methodName:  val_2);
        }
        public static UnityEngine.Rect RectUpdate(UnityEngine.Rect currentValue, UnityEngine.Rect targetValue, float speed)
        {
            float val_11 = currentValue.m_XMin;
            float val_10 = currentValue.m_XMin;
            val_10 = val_10 - val_11;
            float val_1 = UnityEngine.Time.deltaTime;
            float val_2 = val_10 * speed;
            val_1 = val_2 * val_1;
            val_11 = val_11 + val_1;
            float val_12 = val_1;
            float val_4 = UnityEngine.Time.deltaTime;
            val_2 = (val_1 - val_12) * speed;
            val_4 = val_4 * val_2;
            val_12 = val_12 + val_4;
            float val_13 = val_4;
            float val_6 = UnityEngine.Time.deltaTime;
            val_2 = (val_4 - val_13) * speed;
            val_6 = val_6 * val_2;
            val_13 = val_13 + val_6;
            float val_8 = UnityEngine.Time.deltaTime;
            val_2 = (val_6 - val_6) * speed;
            val_8 = val_8 * val_2;
            float val_9 = val_6 + val_8;
            return new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f};
        }
        public static UnityEngine.Vector3 Vector3Update(UnityEngine.Vector3 currentValue, UnityEngine.Vector3 targetValue, float speed)
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = targetValue.x, y = targetValue.y, z = targetValue.z}, b:  new UnityEngine.Vector3() {x = currentValue.x, y = currentValue.y, z = currentValue.z});
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, d:  speed);
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  UnityEngine.Time.deltaTime);
            return UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = currentValue.x, y = currentValue.y, z = currentValue.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        }
        public static UnityEngine.Vector2 Vector2Update(UnityEngine.Vector2 currentValue, UnityEngine.Vector2 targetValue, float speed)
        {
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = targetValue.x, y = targetValue.y}, b:  new UnityEngine.Vector2() {x = currentValue.x, y = currentValue.y});
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y}, d:  speed);
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y}, d:  UnityEngine.Time.deltaTime);
            return UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = currentValue.x, y = currentValue.y}, b:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
        }
        public static float FloatUpdate(float currentValue, float targetValue, float speed)
        {
            float val_2 = UnityEngine.Time.deltaTime;
            targetValue = (targetValue - currentValue) * speed;
            val_2 = targetValue * val_2;
            val_2 = val_2 + currentValue;
            return (float)val_2;
        }
        public static void FadeUpdate(UnityEngine.GameObject target, System.Collections.Hashtable args)
        {
            SA.Common.Animation.SA_iTween.ColorUpdate(target:  null, args:  args);
        }
        public static void FadeUpdate(UnityEngine.GameObject target, float alpha, float time)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = "alpha";
            typeof(System.Object[]).__il2cppRuntimeField_28 = alpha;
            typeof(System.Object[]).__il2cppRuntimeField_2C = 268435457;
            typeof(System.Object[]).__il2cppRuntimeField_30 = "time";
            typeof(System.Object[]).__il2cppRuntimeField_38 = time;
            typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
            SA.Common.Animation.SA_iTween.FadeUpdate(target:  SA.Common.Animation.SA_iTween.Hash(args:  null), args:  X1);
        }
        public static void ColorUpdate(UnityEngine.GameObject target, System.Collections.Hashtable args)
        {
            float val_49;
            var val_50;
            var val_53;
            var val_54;
            SA.Common.Animation.SA_iTween val_56;
            var val_57;
            var val_58;
            float val_59;
            var val_60;
            var val_64;
            var val_69;
            System.Collections.Hashtable val_1 = SA.Common.Animation.SA_iTween.CleanArgs(args:  null);
            if((X2 & 1) == 0)
            {
                goto label_4;
            }
            
            val_49 = X2;
            val_50 = null;
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            if(val_49 == 0)
            {
                goto label_35;
            }
            
            label_4:
            System.Collections.IEnumerator val_4 = args.transform.GetEnumerator();
            label_27:
            var val_49 = 0;
            val_49 = val_49 + 1;
            val_53 = val_4;
            if(((val_4 & 1) & 1) == 0)
            {
                goto label_132;
            }
            
            var val_50 = 0;
            val_50 = val_50 + 1;
            val_54 = val_4;
            goto label_27;
            label_132:
            if(val_4 != null)
            {
                    var val_51 = 0;
                val_51 = val_51 + 1;
                val_57 = val_4;
            }
            
            label_35:
            if((X2 & 1) != 0)
            {
                    val_49 = X2;
                val_50 = null;
                UnityEngine.Vector2 val_12 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y});
                val_58 = null;
                val_58 = null;
                val_59 = val_49 * SA_iTween.Defaults.updateTimePercentage;
            }
            else
            {
                    val_60 = null;
                val_60 = null;
                val_59 = SA_iTween.Defaults.updateTime;
            }
            
            UnityEngine.Renderer val_13 = args.GetComponent<UnityEngine.Renderer>();
            if((UnityEngine.Object.op_Implicit(exists:  0)) == false)
            {
                goto label_48;
            }
            
            UnityEngine.Color val_17 = args.GetComponent<UnityEngine.Renderer>().material.color;
            goto label_53;
            label_48:
            val_56 = 1152921510413315856;
            UnityEngine.Light val_18 = args.GetComponent<UnityEngine.Light>();
            if((UnityEngine.Object.op_Implicit(exists:  0)) == false)
            {
                goto label_57;
            }
            
            UnityEngine.Color val_21 = args.GetComponent<UnityEngine.Light>().color;
            label_53:
            typeof(UnityEngine.Color[]).__il2cppRuntimeField_30 = val_21.r;
            typeof(UnityEngine.Color[]).__il2cppRuntimeField_34 = val_21.g;
            typeof(UnityEngine.Color[]).__il2cppRuntimeField_38 = val_21.b;
            typeof(UnityEngine.Color[]).__il2cppRuntimeField_3C = val_21.a;
            typeof(UnityEngine.Color[]).__il2cppRuntimeField_20 = val_21.r;
            typeof(UnityEngine.Color[]).__il2cppRuntimeField_24 = val_21.g;
            typeof(UnityEngine.Color[]).__il2cppRuntimeField_28 = val_21.b;
            typeof(UnityEngine.Color[]).__il2cppRuntimeField_2C = val_21.a;
            label_57:
            if((X2 & 1) == 0)
            {
                goto label_64;
            }
            
            if(X2 != 0)
            {
                goto label_69;
            }
            
            goto label_69;
            label_64:
            if((X2 & 1) != 0)
            {
                    val_50 = X2;
                val_49 = null;
                UnityEngine.Vector2 val_23 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_21.r, y = val_21.g, z = val_21.b});
                typeof(UnityEngine.Color[]).__il2cppRuntimeField_30 = val_50;
            }
            
            if((X2 & 1) != 0)
            {
                    val_50 = X2;
                val_49 = null;
                UnityEngine.Vector2 val_24 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_21.b});
                typeof(UnityEngine.Color[]).__il2cppRuntimeField_34 = val_50;
            }
            
            if((X2 & 1) != 0)
            {
                    val_50 = X2;
                val_49 = null;
                UnityEngine.Vector2 val_25 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_21.b});
                typeof(UnityEngine.Color[]).__il2cppRuntimeField_38 = val_50;
            }
            
            if((X2 & 1) == 0)
            {
                goto label_88;
            }
            
            val_50 = null;
            UnityEngine.Vector2 val_26 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_21.b});
            val_64 = 0;
            typeof(UnityEngine.Color[]).__il2cppRuntimeField_3C = X2;
            goto label_131;
            label_88:
            if(null == null)
            {
                goto label_131;
            }
            
            val_64 = 0;
            goto label_131;
            label_69:
            val_64 = 0;
            UnityEngine.Color[].__il2cppRuntimeField_element_class.__il2cppRuntimeField_FFFFFFFFFFFFFFFF = X2;
            label_131:
            typeof(UnityEngine.Color[]).__il2cppRuntimeField_50 = UnityEngine.Mathf.SmoothDamp(current:  typeof(UnityEngine.Color[]).__il2cppRuntimeField_20, target:  UnityEngine.Color[].__il2cppRuntimeField_element_class.__il2cppRuntimeField_FFFFFFFFFFFFFFFF, currentVelocity: ref  0f, smoothTime:  val_59);
            typeof(UnityEngine.Color[]).__il2cppRuntimeField_54 = UnityEngine.Mathf.SmoothDamp(current:  typeof(UnityEngine.Color[]).__il2cppRuntimeField_24, target:  UnityEngine.Color[].__il2cppRuntimeField_element_class.__il2cppRuntimeField_FFFFFFFFFFFFFFFF, currentVelocity: ref  0f, smoothTime:  val_59);
            typeof(UnityEngine.Color[]).__il2cppRuntimeField_58 = UnityEngine.Mathf.SmoothDamp(current:  typeof(UnityEngine.Color[]).__il2cppRuntimeField_28, target:  UnityEngine.Color[].__il2cppRuntimeField_element_class.__il2cppRuntimeField_FFFFFFFFFFFFFFFF, currentVelocity: ref  0f, smoothTime:  val_59);
            typeof(UnityEngine.Color[]).__il2cppRuntimeField_5C = UnityEngine.Mathf.SmoothDamp(current:  typeof(UnityEngine.Color[]).__il2cppRuntimeField_2C, target:  UnityEngine.Color[].__il2cppRuntimeField_element_class.__il2cppRuntimeField_FFFFFFFFFFFFFFFF, currentVelocity: ref  0f, smoothTime:  val_59);
            UnityEngine.Renderer val_36 = args.GetComponent<UnityEngine.Renderer>();
            val_69 = UnityEngine.Object.op_Implicit(exists:  0);
            if(val_69 != false)
            {
                    args.GetComponent<UnityEngine.Renderer>().material.color = new UnityEngine.Color() {r = typeof(UnityEngine.Color[]).__il2cppRuntimeField_50, g = typeof(UnityEngine.Color[]).__il2cppRuntimeField_54, b = typeof(UnityEngine.Color[]).__il2cppRuntimeField_58, a = typeof(UnityEngine.Color[]).__il2cppRuntimeField_5C};
                return;
            }
            
            val_56 = 1152921510413315856;
            val_69 = args.GetComponent<UnityEngine.Light>();
            if((UnityEngine.Object.op_Implicit(exists:  0)) == false)
            {
                    return;
            }
            
            args.GetComponent<UnityEngine.Light>().color = new UnityEngine.Color() {r = typeof(UnityEngine.Color[]).__il2cppRuntimeField_50, g = typeof(UnityEngine.Color[]).__il2cppRuntimeField_54, b = typeof(UnityEngine.Color[]).__il2cppRuntimeField_58, a = typeof(UnityEngine.Color[]).__il2cppRuntimeField_5C};
            return;
            label_139:
            goto label_139;
        }
        public static void ColorUpdate(UnityEngine.GameObject target, UnityEngine.Color color, float time)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = "color";
            typeof(System.Object[]).__il2cppRuntimeField_28 = color;
            typeof(System.Object[]).__il2cppRuntimeField_30 = "time";
            typeof(System.Object[]).__il2cppRuntimeField_38 = time;
            typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
            SA.Common.Animation.SA_iTween.ColorUpdate(target:  SA.Common.Animation.SA_iTween.Hash(args:  null), args:  X1);
        }
        public static void AudioUpdate(UnityEngine.GameObject target, System.Collections.Hashtable args)
        {
            float val_20;
            var val_21;
            var val_23;
            float val_24;
            var val_25;
            var val_26;
            float val_27;
            System.Collections.Hashtable val_1 = SA.Common.Animation.SA_iTween.CleanArgs(args:  null);
            if((X2 & 1) != 0)
            {
                    val_20 = X2;
                val_21 = null;
                UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
                val_23 = null;
                val_23 = null;
                val_24 = val_20 * SA_iTween.Defaults.updateTimePercentage;
            }
            else
            {
                    val_25 = null;
                val_25 = null;
                val_24 = SA_iTween.Defaults.updateTime;
            }
            
            if((X2 & 1) == 0)
            {
                goto label_13;
            }
            
            val_26 = X2;
            if(val_26 != 0)
            {
                    if(val_26 == null)
            {
                goto label_16;
            }
            
            }
            
            val_26 = 0;
            goto label_16;
            label_13:
            val_20 = 1152921510414032720;
            UnityEngine.AudioSource val_4 = args.GetComponent<UnityEngine.AudioSource>();
            if((UnityEngine.Object.op_Implicit(exists:  0)) == false)
            {
                goto label_20;
            }
            
            val_26 = args.GetComponent<UnityEngine.AudioSource>();
            label_16:
            if(val_26 != null)
            {
                    val_27 = val_26.volume;
            }
            else
            {
                    val_27 = val_26.volume;
            }
            
            float val_9 = val_26.pitch;
            CinemachineFreeLook.Orbit val_10 = new CinemachineFreeLook.Orbit(h:  val_27, r:  val_9);
            typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_28 = val_10.m_Height;
            typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_20 = val_10.m_Height;
            if((X2 & 1) != 0)
            {
                    val_21 = X2;
                val_20 = null;
                UnityEngine.Vector2 val_11 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_27, y = val_9});
                typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_28 = val_21;
            }
            
            if((X2 & 1) != 0)
            {
                    val_21 = null;
                UnityEngine.Vector2 val_12 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y});
                typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_2C = X2;
            }
            
            typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_38 = UnityEngine.Mathf.SmoothDampAngle(current:  typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_20, target:  typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_28, currentVelocity: ref  0f, smoothTime:  val_24);
            typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_3C = UnityEngine.Mathf.SmoothDampAngle(current:  typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_24, target:  typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_2C, currentVelocity: ref  0f, smoothTime:  val_24);
            val_26.volume = typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_38;
            val_26.pitch = typeof(UnityEngine.Vector2[]).__il2cppRuntimeField_3C;
            return;
            label_20:
            UnityEngine.Debug.LogError(message:  0);
            return;
            label_58:
            goto label_58;
        }
        public static void AudioUpdate(UnityEngine.GameObject target, float volume, float pitch, float time)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = "volume";
            typeof(System.Object[]).__il2cppRuntimeField_28 = volume;
            typeof(System.Object[]).__il2cppRuntimeField_2C = 268435457;
            typeof(System.Object[]).__il2cppRuntimeField_30 = "pitch";
            typeof(System.Object[]).__il2cppRuntimeField_38 = pitch;
            typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
            typeof(System.Object[]).__il2cppRuntimeField_40 = "time";
            typeof(System.Object[]).__il2cppRuntimeField_48 = time;
            typeof(System.Object[]).__il2cppRuntimeField_4C = 268435457;
            SA.Common.Animation.SA_iTween.AudioUpdate(target:  SA.Common.Animation.SA_iTween.Hash(args:  null), args:  X1);
        }
        public static void RotateUpdate(UnityEngine.GameObject target, System.Collections.Hashtable args)
        {
            var val_34;
            float val_37;
            float val_38;
            float val_39;
            var val_40;
            var val_41;
            float val_42;
            var val_43;
            var val_44;
            var val_45;
            float val_49;
            var val_50;
            var val_51;
            float val_55;
            val_34 = args;
            System.Collections.Hashtable val_1 = SA.Common.Animation.SA_iTween.CleanArgs(args:  null);
            UnityEngine.Vector3 val_3 = val_34.transform.eulerAngles;
            val_37 = val_3.x;
            val_38 = val_3.z;
            if((X2 & 1) != 0)
            {
                    val_39 = X2;
                val_40 = null;
                UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
                val_41 = null;
                val_41 = null;
                val_42 = val_39 * SA_iTween.Defaults.updateTimePercentage;
            }
            else
            {
                    val_43 = null;
                val_43 = null;
                val_42 = SA_iTween.Defaults.updateTime;
            }
            
            if((X2 & 1) != 0)
            {
                    val_39 = X2;
                val_40 = null;
                val_44 = val_39;
                UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            }
            else
            {
                    val_45 = null;
                val_45 = null;
                val_44 = 1152921504852164632;
            }
            
            UnityEngine.Transform val_6 = val_34.transform;
            if(val_44 != false)
            {
                    UnityEngine.Vector3 val_7 = val_6.localEulerAngles;
            }
            else
            {
                    UnityEngine.Vector3 val_8 = val_6.eulerAngles;
            }
            
            val_49 = val_8.z;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_20 = val_8.x;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_24 = val_8.y;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_28 = val_49;
            if((X2 & 1) == 0)
            {
                goto label_50;
            }
            
            val_39 = X2.GetType();
            val_50 = X2;
            if(val_39 == (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                goto label_33;
            }
            
            val_39 = null;
            if(val_50.GetType() != (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                goto label_50;
            }
            
            val_51 = 0;
            goto label_43;
            label_33:
            val_50 = 0;
            UnityEngine.Vector3 val_16 = val_50.eulerAngles;
            val_49 = val_16.z;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_2C = val_16.x;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_30 = val_16.y;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_34 = val_49;
            goto label_50;
            label_43:
            mem[1152921505860859780] = X2 + 8;
            mem[1152921505860859772] = ;
            label_50:
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_44 = UnityEngine.Mathf.SmoothDampAngle(current:  typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_20, target:  mem[1152921505860859772], currentVelocity: ref  0f, smoothTime:  val_42);
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_48 = UnityEngine.Mathf.SmoothDampAngle(current:  typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_24, target:  mem[1152921505860859772], currentVelocity: ref  0f, smoothTime:  val_42);
            val_55 = typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_28;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_4C = UnityEngine.Mathf.SmoothDampAngle(current:  val_55, target:  mem[1152921505860859780], currentVelocity: ref  0f, smoothTime:  val_42);
            UnityEngine.Transform val_24 = val_34.transform;
            if(val_44 != false)
            {
                    val_24.localEulerAngles = new UnityEngine.Vector3() {x = typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_44, y = typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_48, z = typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_4C};
            }
            else
            {
                    val_24.eulerAngles = new UnityEngine.Vector3() {x = typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_44, y = typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_48, z = typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_4C};
            }
            
            if(0 == (val_34.GetComponent<UnityEngine.Rigidbody>()))
            {
                    return;
            }
            
            UnityEngine.Vector3 val_28 = val_34.transform.eulerAngles;
            val_55 = val_28.y;
            val_34.transform.eulerAngles = new UnityEngine.Vector3() {x = val_37, y = val_3.y, z = val_38};
            val_34 = val_34.GetComponent<UnityEngine.Rigidbody>();
            UnityEngine.Quaternion val_31 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = val_28.x, y = val_55, z = val_28.z});
            val_37 = val_31.x;
            val_38 = val_31.z;
            val_34.MoveRotation(rot:  new UnityEngine.Quaternion() {x = val_37, y = val_31.y, z = val_38, w = val_31.w});
            return;
            label_85:
            goto label_85;
        }
        public static void RotateUpdate(UnityEngine.GameObject target, UnityEngine.Vector3 rotation, float time)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = "rotation";
            typeof(System.Object[]).__il2cppRuntimeField_28 = rotation;
            typeof(System.Object[]).__il2cppRuntimeField_30 = "time";
            typeof(System.Object[]).__il2cppRuntimeField_38 = time;
            typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
            SA.Common.Animation.SA_iTween.RotateUpdate(target:  SA.Common.Animation.SA_iTween.Hash(args:  null), args:  X1);
        }
        public static void ScaleUpdate(UnityEngine.GameObject target, System.Collections.Hashtable args)
        {
            float val_28;
            var val_29;
            var val_30;
            float val_31;
            var val_32;
            var val_37;
            var val_38;
            System.Collections.Hashtable val_1 = SA.Common.Animation.SA_iTween.CleanArgs(args:  null);
            if((X2 & 1) != 0)
            {
                    val_28 = X2;
                val_29 = null;
                UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
                val_30 = null;
                val_30 = null;
                val_31 = val_28 * SA_iTween.Defaults.updateTimePercentage;
            }
            else
            {
                    val_32 = null;
                val_32 = null;
                val_31 = SA_iTween.Defaults.updateTime;
            }
            
            UnityEngine.Vector3 val_4 = args.transform.localScale;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_2C = val_4.x;
            mem[1152921505860859776] = val_4.y;
            mem[1152921505860859780] = val_4.z;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_20 = val_4.x;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_24 = val_4.y;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_28 = val_4.z;
            if((X2 & 1) == 0)
            {
                goto label_19;
            }
            
            val_28 = X2.GetType();
            val_37 = X2;
            if(val_28 == (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                goto label_24;
            }
            
            val_28 = null;
            if(val_37.GetType() != (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                goto label_59;
            }
            
            val_38 = 0;
            goto label_34;
            label_19:
            if((X2 & 1) != 0)
            {
                    val_29 = X2;
                val_28 = null;
                UnityEngine.Vector2 val_10 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
                mem[1152921505860859772] = val_29;
            }
            
            if((X2 & 1) != 0)
            {
                    val_29 = X2;
                val_28 = null;
                UnityEngine.Vector2 val_11 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_4.z});
                typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_30 = val_29;
            }
            
            if((X2 & 1) == 0)
            {
                goto label_59;
            }
            
            val_29 = null;
            UnityEngine.Vector2 val_12 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_4.z});
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_34 = X2;
            goto label_59;
            label_24:
            val_37 = 0;
            UnityEngine.Vector3 val_15 = val_37.localScale;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_2C = val_15.x;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_30 = val_15.y;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_34 = val_15.z;
            goto label_59;
            label_34:
            mem[1152921505860859780] = X2 + 8;
            mem[1152921505860859772] = ;
            label_59:
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_44 = UnityEngine.Mathf.SmoothDamp(current:  typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_20, target:  mem[1152921505860859772], currentVelocity: ref  0f, smoothTime:  val_31);
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_48 = UnityEngine.Mathf.SmoothDamp(current:  typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_24, target:  mem[1152921505860859772], currentVelocity: ref  0f, smoothTime:  val_31);
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_4C = UnityEngine.Mathf.SmoothDamp(current:  typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_28, target:  mem[1152921505860859780], currentVelocity: ref  0f, smoothTime:  val_31);
            args.transform.localScale = new UnityEngine.Vector3() {x = typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_44, y = typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_48, z = typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_4C};
            return;
            label_82:
            goto label_82;
        }
        public static void ScaleUpdate(UnityEngine.GameObject target, UnityEngine.Vector3 scale, float time)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = "scale";
            typeof(System.Object[]).__il2cppRuntimeField_28 = scale;
            typeof(System.Object[]).__il2cppRuntimeField_30 = "time";
            typeof(System.Object[]).__il2cppRuntimeField_38 = time;
            typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
            SA.Common.Animation.SA_iTween.ScaleUpdate(target:  SA.Common.Animation.SA_iTween.Hash(args:  null), args:  X1);
        }
        public static void MoveUpdate(UnityEngine.GameObject target, System.Collections.Hashtable args)
        {
            System.Collections.Hashtable val_41;
            float val_44;
            var val_45;
            var val_46;
            float val_47;
            var val_48;
            var val_49;
            var val_50;
            float val_55;
            var val_56;
            var val_57;
            float val_61;
            val_41 = args;
            System.Collections.Hashtable val_1 = SA.Common.Animation.SA_iTween.CleanArgs(args:  null);
            UnityEngine.Vector3 val_3 = val_41.transform.position;
            if((X2 & 1) != 0)
            {
                    val_44 = X2;
                val_45 = null;
                UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
                val_46 = null;
                val_46 = null;
                val_47 = val_44 * SA_iTween.Defaults.updateTimePercentage;
            }
            else
            {
                    val_48 = null;
                val_48 = null;
                val_47 = SA_iTween.Defaults.updateTime;
            }
            
            if((X2 & 1) != 0)
            {
                    val_44 = X2;
                val_45 = null;
                val_49 = val_44;
                UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            }
            else
            {
                    val_50 = null;
                val_50 = null;
                val_49 = 1152921504852164632;
            }
            
            UnityEngine.Transform val_6 = val_41.transform;
            if(val_49 != false)
            {
                    UnityEngine.Vector3 val_7 = val_6.localPosition;
            }
            else
            {
                    UnityEngine.Vector3 val_8 = val_6.position;
            }
            
            val_55 = val_8.z;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_2C = val_8.x;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_30 = val_8.y;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_34 = val_55;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_20 = val_8.x;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_24 = val_8.y;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_28 = val_55;
            if((X2 & 1) == 0)
            {
                goto label_30;
            }
            
            val_44 = X2.GetType();
            val_56 = X2;
            if(val_44 == (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                goto label_35;
            }
            
            val_44 = null;
            if(val_56.GetType() != (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                goto label_70;
            }
            
            val_44 = null;
            val_57 = 0;
            goto label_45;
            label_30:
            if((X2 & 1) != 0)
            {
                    val_44 = null;
                UnityEngine.Vector2 val_14 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
                typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_2C = X2;
            }
            
            if((X2 & 1) != 0)
            {
                    val_44 = null;
                UnityEngine.Vector2 val_15 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_8.z});
                typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_30 = X2;
            }
            
            if((X2 & 1) == 0)
            {
                goto label_70;
            }
            
            val_44 = null;
            UnityEngine.Vector2 val_16 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_8.z});
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_34 = X2;
            goto label_70;
            label_35:
            val_56 = 0;
            UnityEngine.Vector3 val_19 = val_56.position;
            val_55 = val_19.z;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_2C = val_19.x;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_30 = val_19.y;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_34 = val_55;
            goto label_70;
            label_45:
            mem[1152921505860859780] = X2 + 8;
            mem[1152921505860859772] = ;
            label_70:
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_44 = UnityEngine.Mathf.SmoothDamp(current:  typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_20, target:  mem[1152921505860859772], currentVelocity: ref  0f, smoothTime:  val_47);
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_48 = UnityEngine.Mathf.SmoothDamp(current:  typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_24, target:  mem[1152921505860859772], currentVelocity: ref  0f, smoothTime:  val_47);
            val_61 = typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_28;
            float val_26 = UnityEngine.Mathf.SmoothDamp(current:  val_61, target:  mem[1152921505860859780], currentVelocity: ref  0f, smoothTime:  val_47);
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_4C = val_26;
            if((X2 & 1) != 0)
            {
                    val_44 = X2;
                val_45 = null;
                UnityEngine.Vector2 val_27 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_26, y = mem[1152921505860859780], z = val_47});
                if(val_44 != 0)
            {
                
            }
            
            }
            
            if((X2 & 1) != 0)
            {
                    SA.Common.Animation.SA_iTween.LookUpdate(target:  null, args:  val_41);
            }
            
            UnityEngine.Transform val_28 = val_41.transform;
            if(val_49 != false)
            {
                    val_28.localPosition = new UnityEngine.Vector3() {x = typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_44, y = typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_48, z = typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_4C};
            }
            else
            {
                    val_28.position = new UnityEngine.Vector3() {x = typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_44, y = typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_48, z = typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_4C};
            }
            
            if(0 == (val_41.GetComponent<UnityEngine.Rigidbody>()))
            {
                    return;
            }
            
            UnityEngine.Vector3 val_32 = val_41.transform.position;
            val_61 = val_32.y;
            val_41.transform.position = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            val_41 = val_41.GetComponent<UnityEngine.Rigidbody>();
            val_41.MovePosition(position:  new UnityEngine.Vector3() {x = val_32.x, y = val_61, z = val_32.z});
            return;
            label_119:
            goto label_119;
        }
        public static void MoveUpdate(UnityEngine.GameObject target, UnityEngine.Vector3 position, float time)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = "position";
            typeof(System.Object[]).__il2cppRuntimeField_28 = position;
            typeof(System.Object[]).__il2cppRuntimeField_30 = "time";
            typeof(System.Object[]).__il2cppRuntimeField_38 = time;
            typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
            SA.Common.Animation.SA_iTween.MoveUpdate(target:  SA.Common.Animation.SA_iTween.Hash(args:  null), args:  X1);
        }
        public static void LookUpdate(UnityEngine.GameObject target, System.Collections.Hashtable args)
        {
            float val_12;
            float val_46;
            var val_47;
            float val_48;
            var val_49;
            var val_50;
            float val_51;
            var val_52;
            float val_53;
            float val_54;
            float val_55;
            var val_56;
            float val_57;
            var val_58;
            float val_61;
            float val_62;
            float val_63;
            UnityEngine.Vector3 val_64;
            var val_65;
            var val_66;
            UnityEngine.Transform val_67;
            var val_68;
            UnityEngine.Vector3 val_69;
            var val_70;
            var val_71;
            var val_72;
            float val_73;
            var val_74;
            val_46 = X2;
            val_47 = args;
            System.Collections.Hashtable val_1 = SA.Common.Animation.SA_iTween.CleanArgs(args:  null);
            val_48 = "looktime";
            if((val_46 & 1) == 0)
            {
                goto label_5;
            }
            
            val_48 = val_46;
            val_49 = null;
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            val_50 = 1152921504852160512;
            val_51 = mem[X2];
            val_51 = val_48;
            val_52 = null;
            goto label_9;
            label_5:
            if((val_46 & 1) == 0)
            {
                goto label_10;
            }
            
            val_48 = val_46;
            val_49 = null;
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            val_50 = 1152921504852160512;
            val_52 = null;
            val_53 = 0.15f;
            val_51 = val_48 * val_53;
            label_9:
            val_54 = SA_iTween.Defaults.updateTimePercentage;
            val_55 = val_51 * val_54;
            goto label_15;
            label_10:
            val_56 = null;
            val_56 = null;
            val_55 = SA_iTween.Defaults.updateTime;
            label_15:
            UnityEngine.Vector3 val_5 = val_47.transform.eulerAngles;
            val_57 = val_5.y;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_20 = val_5.x;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_24 = val_57;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_28 = val_5.z;
            if((val_46 & 1) == 0)
            {
                goto label_23;
            }
            
            val_58 = 1152921504609562624;
            if(val_46.GetType() == (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                goto label_27;
            }
            
            if(val_46.GetType() != (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                goto label_61;
            }
            
            val_58;
            UnityEngine.Vector2 val_13 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_12, y = val_5.y, z = val_5.z});
            if((0 & 1) == 0)
            {
                goto label_40;
            }
            
            val_61 = mem[X2 + 4];
            val_61 = X2 + 4;
            val_62 = mem[X2 + 4 + 4];
            val_62 = X2 + 4 + 4;
            val_63 = mem[X2];
            val_63 = val_46;
            val_64 = val_13.x;
            val_65 = val_13.y;
            val_66 = val_5.z;
            goto label_41;
            label_23:
            UnityEngine.Debug.LogError(message:  0);
            return;
            label_27:
            val_67 = val_46;
            val_58 = 1152921504722022400;
            if(val_67 != 0)
            {
                    val_68 = val_67;
            }
            
            val_68 = 0;
            if((0 & 1) != 0)
            {
                    val_69 = val_12;
                val_70 = val_5.y;
                val_71 = val_5.z;
                val_67 = val_68;
            }
            else
            {
                    val_67 = 0;
                val_72 = null;
                val_72 = null;
                val_69 = SA_iTween.Defaults.up;
            }
            
            val_54 = val_69;
            val_53 = SA_iTween.Defaults.time.__il2cppRuntimeField_4C;
            val_73 = SA_iTween.Defaults.time.__il2cppRuntimeField_50;
            val_47.transform.LookAt(target:  val_67, worldUp:  new UnityEngine.Vector3() {x = val_54, y = val_53, z = val_73});
            goto label_61;
            label_40:
            UnityEngine.Vector2 val_20 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_5.z});
            val_74 = null;
            val_63 = mem[X2];
            val_63 = val_46;
            val_61 = mem[X2 + 4];
            val_61 = X2 + 4;
            val_62 = mem[X2 + 8];
            val_62 = X2 + 8;
            val_74 = null;
            val_64 = SA_iTween.Defaults.up;
            label_41:
            val_54 = val_63;
            val_53 = val_61;
            val_73 = val_62;
            val_47.transform.LookAt(worldPosition:  new UnityEngine.Vector3() {x = val_54, y = val_53, z = val_73}, worldUp:  new UnityEngine.Vector3() {x = val_64, y = SA_iTween.Defaults.time.__il2cppRuntimeField_4C, z = SA_iTween.Defaults.time.__il2cppRuntimeField_50});
            label_61:
            UnityEngine.Vector3 val_22 = val_47.transform.eulerAngles;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_2C = val_22.x;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_30 = val_22.y;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_34 = val_22.z;
            val_47.transform.eulerAngles = new UnityEngine.Vector3() {x = typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_20, y = typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_24, z = typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_28};
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_44 = UnityEngine.Mathf.SmoothDampAngle(current:  typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_20, target:  typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_2C, currentVelocity: ref  0f, smoothTime:  val_55);
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_48 = UnityEngine.Mathf.SmoothDampAngle(current:  typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_24, target:  typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_30, currentVelocity: ref  0f, smoothTime:  val_55);
            val_57 = typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_34;
            val_55 = UnityEngine.Mathf.SmoothDampAngle(current:  typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_28, target:  val_57, currentVelocity: ref  0f, smoothTime:  val_55);
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_4C = val_55;
            val_47.transform.eulerAngles = new UnityEngine.Vector3() {x = typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_44, y = typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_48, z = typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_4C};
            val_48 = "axis";
            if((val_46 & 1) == 0)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_32 = val_47.transform.eulerAngles;
            val_55 = val_32.x;
            val_57 = val_32.z;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_50 = val_55;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_54 = val_32.y;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_58 = val_57;
            val_46 = val_46;
            if(val_46 == 0)
            {
                goto label_128;
            }
            
            if(val_46 == null)
            {
                goto label_98;
            }
            
            goto label_128;
            label_98:
            if((System.String.op_Equality(a:  0, b:  val_46)) == false)
            {
                goto label_102;
            }
            
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_54 = typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_24;
            goto label_107;
            label_102:
            if((System.String.op_Equality(a:  0, b:  val_46)) == false)
            {
                goto label_110;
            }
            
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_50 = typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_20;
            label_107:
            val_46 = typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_28;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_58 = val_46;
            label_128:
            val_47 = val_47.transform;
            val_47.eulerAngles = new UnityEngine.Vector3() {x = typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_50, y = typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_54, z = typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_58};
            return;
            label_110:
            if((System.String.op_Equality(a:  0, b:  val_46)) == false)
            {
                goto label_128;
            }
            
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_50 = typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_20;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_54 = typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_24;
            goto label_128;
            label_136:
            goto label_136;
        }
        public static void LookUpdate(UnityEngine.GameObject target, UnityEngine.Vector3 looktarget, float time)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = "looktarget";
            typeof(System.Object[]).__il2cppRuntimeField_28 = looktarget;
            typeof(System.Object[]).__il2cppRuntimeField_30 = "time";
            typeof(System.Object[]).__il2cppRuntimeField_38 = time;
            typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
            SA.Common.Animation.SA_iTween.LookUpdate(target:  SA.Common.Animation.SA_iTween.Hash(args:  null), args:  X1);
        }
        public static float PathLength(UnityEngine.Transform[] path)
        {
            var val_10;
            var val_11;
            var val_12;
            float val_13;
            float val_15;
            val_10 = 0;
            val_11 = 12;
            goto label_2;
            label_9:
            var val_1 = null + (X24 * val_11);
            val_10 = 1;
            mem2[0] = ???;
            mem2[0] = ???;
            mem2[0] = ???;
            label_2:
            val_12 = mem[X1 + 24];
            val_12 = X1 + 24;
            if(val_10 >= val_12)
            {
                goto label_4;
            }
            
            if(null == null)
            {
                    val_12 = mem[X1 + 24];
                val_12 = X1 + 24;
            }
            
            var val_2 = X1 + 8;
            UnityEngine.Vector3 val_3 = (X1 + 8) + 32.position;
            goto label_9;
            label_4:
            val_13 = 0f;
            UnityEngine.Vector3 val_5 = SA.Common.Animation.SA_iTween.Interp(pts:  SA.Common.Animation.SA_iTween.PathControlPointGenerator(path:  null), t:  val_13);
            val_15 = val_5.y;
            var val_6 = (X1 + 24) * 20;
            if(val_6 < 1)
            {
                    return (float)val_13;
            }
            
            val_11 = 1152921504719785984;
            var val_11 = 0;
            do
            {
                UnityEngine.Vector3 val_9 = SA.Common.Animation.SA_iTween.Interp(pts:  null, t:  ((float)val_11 + 1) / (float)val_6);
                val_15 = val_9.y;
                val_13 = 0f + (UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_15, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_15, z = val_9.z}));
                val_11 = val_11 + 1;
            }
            while(val_11 < val_6);
            
            return (float)val_13;
        }
        public static float PathLength(UnityEngine.Vector3[] path)
        {
            float val_7;
            float val_9;
            val_7 = 0f;
            UnityEngine.Vector3 val_2 = SA.Common.Animation.SA_iTween.Interp(pts:  SA.Common.Animation.SA_iTween.PathControlPointGenerator(path:  null), t:  val_7);
            val_9 = val_2.y;
            var val_3 = (X1 + 24) * 20;
            if(val_3 < 1)
            {
                    return (float)val_7;
            }
            
            var val_8 = 0;
            do
            {
                UnityEngine.Vector3 val_6 = SA.Common.Animation.SA_iTween.Interp(pts:  null, t:  ((float)val_8 + 1) / (float)val_3);
                val_9 = val_6.y;
                val_7 = 0f + (UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_9, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_9, z = val_6.z}));
                val_8 = val_8 + 1;
            }
            while(val_8 < val_3);
            
            return (float)val_7;
        }
        public static UnityEngine.Texture2D CameraTexture(UnityEngine.Color color)
        {
            var val_7;
            var val_7 = UnityEngine.Screen.width;
            val_7 = UnityEngine.Screen.height * val_7;
            val_7 = 0;
            goto label_1;
            label_5:
            var val_6 = null + ((X22) << 4);
            val_7 = 1;
            mem2[0] = color.r;
            mem2[0] = color.g;
            mem2[0] = color.b;
            mem2[0] = color.a;
            label_1:
            if(null != null)
            {
                goto label_5;
            }
            
            goto label_5;
        }
        public static void PutOnPath(UnityEngine.GameObject target, UnityEngine.Vector3[] path, float percent)
        {
            UnityEngine.Vector3 val_3 = SA.Common.Animation.SA_iTween.Interp(pts:  SA.Common.Animation.SA_iTween.PathControlPointGenerator(path:  null = null), t:  percent);
            path.transform.position = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        }
        public static void PutOnPath(UnityEngine.Transform target, UnityEngine.Vector3[] path, float percent)
        {
            UnityEngine.Vector3 val_2 = SA.Common.Animation.SA_iTween.Interp(pts:  SA.Common.Animation.SA_iTween.PathControlPointGenerator(path:  null), t:  percent);
            path.position = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        }
        public static void PutOnPath(UnityEngine.GameObject target, UnityEngine.Transform[] path, float percent)
        {
            var val_7;
            var val_8;
            UnityEngine.Vector3[] val_9;
            val_7 = 0;
            goto label_2;
            label_9:
            var val_1 = null + (X25 * 12);
            val_7 = 1;
            mem2[0] = ???;
            mem2[0] = ???;
            mem2[0] = ???;
            label_2:
            val_8 = mem[X2 + 24];
            val_8 = X2 + 24;
            if(val_7 >= val_8)
            {
                goto label_4;
            }
            
            if(null == null)
            {
                    val_8 = mem[X2 + 24];
                val_8 = X2 + 24;
            }
            
            var val_2 = X2 + 8;
            UnityEngine.Vector3 val_3 = (X2 + 8) + 32.position;
            goto label_9;
            label_4:
            val_9 = null;
            UnityEngine.Vector3 val_6 = SA.Common.Animation.SA_iTween.Interp(pts:  SA.Common.Animation.SA_iTween.PathControlPointGenerator(path:  val_9), t:  percent);
            path.transform.position = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        }
        public static void PutOnPath(UnityEngine.Transform target, UnityEngine.Transform[] path, float percent)
        {
            var val_6;
            var val_7;
            val_6 = 0;
            goto label_2;
            label_9:
            var val_1 = null + (X25 * 12);
            val_6 = 1;
            mem2[0] = ???;
            mem2[0] = ???;
            mem2[0] = ???;
            label_2:
            val_7 = mem[X2 + 24];
            val_7 = X2 + 24;
            if(val_6 >= val_7)
            {
                goto label_4;
            }
            
            if(null == null)
            {
                    val_7 = mem[X2 + 24];
                val_7 = X2 + 24;
            }
            
            var val_2 = X2 + 8;
            UnityEngine.Vector3 val_3 = (X2 + 8) + 32.position;
            goto label_9;
            label_4:
            UnityEngine.Vector3 val_5 = SA.Common.Animation.SA_iTween.Interp(pts:  SA.Common.Animation.SA_iTween.PathControlPointGenerator(path:  null), t:  percent);
            path.position = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
        }
        public static UnityEngine.Vector3 PointOnPath(UnityEngine.Transform[] path, float percent)
        {
            var val_5;
            var val_6;
            val_5 = 0;
            goto label_2;
            label_9:
            var val_1 = null + (X24 * 12);
            val_5 = 1;
            mem2[0] = ???;
            mem2[0] = ???;
            mem2[0] = ???;
            label_2:
            val_6 = mem[X1 + 24];
            val_6 = X1 + 24;
            if(val_5 >= val_6)
            {
                    return SA.Common.Animation.SA_iTween.Interp(pts:  SA.Common.Animation.SA_iTween.PathControlPointGenerator(path:  null), t:  percent);
            }
            
            if(null == null)
            {
                    val_6 = mem[X1 + 24];
                val_6 = X1 + 24;
            }
            
            var val_2 = X1 + 8;
            UnityEngine.Vector3 val_3 = (X1 + 8) + 32.position;
            goto label_9;
        }
        public static void DrawLine(UnityEngine.Vector3[] line)
        {
            var val_1;
            if((X1 + 24) < 1)
            {
                    return;
            }
            
            val_1 = null;
            val_1 = null;
            SA.Common.Animation.SA_iTween.DrawLineHelper(line:  null, color:  new UnityEngine.Color() {r = SA_iTween.Defaults.color, g = SA_iTween.Defaults.time.__il2cppRuntimeField_28, b = SA_iTween.Defaults.time.__il2cppRuntimeField_2C, a = SA_iTween.Defaults.time.__il2cppRuntimeField_30}, method:  X1);
        }
        public static void DrawLine(UnityEngine.Vector3[] line, UnityEngine.Color color)
        {
            if((X1 + 24) < 1)
            {
                    return;
            }
            
            SA.Common.Animation.SA_iTween.DrawLineHelper(line:  null, color:  new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = color.a}, method:  X1);
        }
        public static void DrawLine(UnityEngine.Transform[] line)
        {
            var val_4;
            var val_5;
            var val_6;
            if((X1 + 24) < 1)
            {
                    return;
            }
            
            val_4 = 0;
            goto label_3;
            label_10:
            var val_1 = null + (X24 * 12);
            val_4 = 1;
            mem2[0] = ???;
            mem2[0] = ???;
            mem2[0] = ???;
            label_3:
            val_5 = mem[X1 + 24];
            val_5 = X1 + 24;
            if(val_4 >= val_5)
            {
                goto label_5;
            }
            
            if(null == null)
            {
                    val_5 = mem[X1 + 24];
                val_5 = X1 + 24;
            }
            
            var val_2 = X1 + 8;
            UnityEngine.Vector3 val_3 = (X1 + 8) + 32.position;
            goto label_10;
            label_5:
            val_6 = null;
            val_6 = null;
            SA.Common.Animation.SA_iTween.DrawLineHelper(line:  null, color:  new UnityEngine.Color() {r = SA_iTween.Defaults.color, g = SA_iTween.Defaults.time.__il2cppRuntimeField_28, b = SA_iTween.Defaults.time.__il2cppRuntimeField_2C, a = SA_iTween.Defaults.time.__il2cppRuntimeField_30}, method:  null);
        }
        public static void DrawLine(UnityEngine.Transform[] line, UnityEngine.Color color)
        {
            var val_4;
            var val_5;
            if((X1 + 24) < 1)
            {
                    return;
            }
            
            val_4 = 0;
            goto label_3;
            label_10:
            var val_1 = null + (X24 * 12);
            val_4 = 1;
            mem2[0] = ???;
            mem2[0] = ???;
            mem2[0] = ???;
            label_3:
            val_5 = mem[X1 + 24];
            val_5 = X1 + 24;
            if(val_4 >= val_5)
            {
                goto label_5;
            }
            
            if(null == null)
            {
                    val_5 = mem[X1 + 24];
                val_5 = X1 + 24;
            }
            
            var val_2 = X1 + 8;
            UnityEngine.Vector3 val_3 = (X1 + 8) + 32.position;
            goto label_10;
            label_5:
            SA.Common.Animation.SA_iTween.DrawLineHelper(line:  null, color:  new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = color.a}, method:  null);
        }
        public static void DrawLineGizmos(UnityEngine.Vector3[] line)
        {
            var val_1;
            if((X1 + 24) < 1)
            {
                    return;
            }
            
            val_1 = null;
            val_1 = null;
            SA.Common.Animation.SA_iTween.DrawLineHelper(line:  null, color:  new UnityEngine.Color() {r = SA_iTween.Defaults.color, g = SA_iTween.Defaults.time.__il2cppRuntimeField_28, b = SA_iTween.Defaults.time.__il2cppRuntimeField_2C, a = SA_iTween.Defaults.time.__il2cppRuntimeField_30}, method:  X1);
        }
        public static void DrawLineGizmos(UnityEngine.Vector3[] line, UnityEngine.Color color)
        {
            if((X1 + 24) < 1)
            {
                    return;
            }
            
            SA.Common.Animation.SA_iTween.DrawLineHelper(line:  null, color:  new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = color.a}, method:  X1);
        }
        public static void DrawLineGizmos(UnityEngine.Transform[] line)
        {
            var val_4;
            var val_5;
            var val_6;
            if((X1 + 24) < 1)
            {
                    return;
            }
            
            val_4 = 0;
            goto label_3;
            label_10:
            var val_1 = null + (X24 * 12);
            val_4 = 1;
            mem2[0] = ???;
            mem2[0] = ???;
            mem2[0] = ???;
            label_3:
            val_5 = mem[X1 + 24];
            val_5 = X1 + 24;
            if(val_4 >= val_5)
            {
                goto label_5;
            }
            
            if(null == null)
            {
                    val_5 = mem[X1 + 24];
                val_5 = X1 + 24;
            }
            
            var val_2 = X1 + 8;
            UnityEngine.Vector3 val_3 = (X1 + 8) + 32.position;
            goto label_10;
            label_5:
            val_6 = null;
            val_6 = null;
            SA.Common.Animation.SA_iTween.DrawLineHelper(line:  null, color:  new UnityEngine.Color() {r = SA_iTween.Defaults.color, g = SA_iTween.Defaults.time.__il2cppRuntimeField_28, b = SA_iTween.Defaults.time.__il2cppRuntimeField_2C, a = SA_iTween.Defaults.time.__il2cppRuntimeField_30}, method:  null);
        }
        public static void DrawLineGizmos(UnityEngine.Transform[] line, UnityEngine.Color color)
        {
            var val_4;
            var val_5;
            if((X1 + 24) < 1)
            {
                    return;
            }
            
            val_4 = 0;
            goto label_3;
            label_10:
            var val_1 = null + (X24 * 12);
            val_4 = 1;
            mem2[0] = ???;
            mem2[0] = ???;
            mem2[0] = ???;
            label_3:
            val_5 = mem[X1 + 24];
            val_5 = X1 + 24;
            if(val_4 >= val_5)
            {
                goto label_5;
            }
            
            if(null == null)
            {
                    val_5 = mem[X1 + 24];
                val_5 = X1 + 24;
            }
            
            var val_2 = X1 + 8;
            UnityEngine.Vector3 val_3 = (X1 + 8) + 32.position;
            goto label_10;
            label_5:
            SA.Common.Animation.SA_iTween.DrawLineHelper(line:  null, color:  new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = color.a}, method:  null);
        }
        public static void DrawLineHandles(UnityEngine.Vector3[] line)
        {
            var val_1;
            if((X1 + 24) < 1)
            {
                    return;
            }
            
            val_1 = null;
            val_1 = null;
            SA.Common.Animation.SA_iTween.DrawLineHelper(line:  null, color:  new UnityEngine.Color() {r = SA_iTween.Defaults.color, g = SA_iTween.Defaults.time.__il2cppRuntimeField_28, b = SA_iTween.Defaults.time.__il2cppRuntimeField_2C, a = SA_iTween.Defaults.time.__il2cppRuntimeField_30}, method:  X1);
        }
        public static void DrawLineHandles(UnityEngine.Vector3[] line, UnityEngine.Color color)
        {
            if((X1 + 24) < 1)
            {
                    return;
            }
            
            SA.Common.Animation.SA_iTween.DrawLineHelper(line:  null, color:  new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = color.a}, method:  X1);
        }
        public static void DrawLineHandles(UnityEngine.Transform[] line)
        {
            var val_4;
            var val_5;
            var val_6;
            if((X1 + 24) < 1)
            {
                    return;
            }
            
            val_4 = 0;
            goto label_3;
            label_10:
            var val_1 = null + (X24 * 12);
            val_4 = 1;
            mem2[0] = ???;
            mem2[0] = ???;
            mem2[0] = ???;
            label_3:
            val_5 = mem[X1 + 24];
            val_5 = X1 + 24;
            if(val_4 >= val_5)
            {
                goto label_5;
            }
            
            if(null == null)
            {
                    val_5 = mem[X1 + 24];
                val_5 = X1 + 24;
            }
            
            var val_2 = X1 + 8;
            UnityEngine.Vector3 val_3 = (X1 + 8) + 32.position;
            goto label_10;
            label_5:
            val_6 = null;
            val_6 = null;
            SA.Common.Animation.SA_iTween.DrawLineHelper(line:  null, color:  new UnityEngine.Color() {r = SA_iTween.Defaults.color, g = SA_iTween.Defaults.time.__il2cppRuntimeField_28, b = SA_iTween.Defaults.time.__il2cppRuntimeField_2C, a = SA_iTween.Defaults.time.__il2cppRuntimeField_30}, method:  null);
        }
        public static void DrawLineHandles(UnityEngine.Transform[] line, UnityEngine.Color color)
        {
            var val_4;
            var val_5;
            if((X1 + 24) < 1)
            {
                    return;
            }
            
            val_4 = 0;
            goto label_3;
            label_10:
            var val_1 = null + (X24 * 12);
            val_4 = 1;
            mem2[0] = ???;
            mem2[0] = ???;
            mem2[0] = ???;
            label_3:
            val_5 = mem[X1 + 24];
            val_5 = X1 + 24;
            if(val_4 >= val_5)
            {
                goto label_5;
            }
            
            if(null == null)
            {
                    val_5 = mem[X1 + 24];
                val_5 = X1 + 24;
            }
            
            var val_2 = X1 + 8;
            UnityEngine.Vector3 val_3 = (X1 + 8) + 32.position;
            goto label_10;
            label_5:
            SA.Common.Animation.SA_iTween.DrawLineHelper(line:  null, color:  new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = color.a}, method:  null);
        }
        public static UnityEngine.Vector3 PointOnPath(UnityEngine.Vector3[] path, float percent)
        {
            return SA.Common.Animation.SA_iTween.Interp(pts:  SA.Common.Animation.SA_iTween.PathControlPointGenerator(path:  null), t:  percent);
        }
        public static void DrawPath(UnityEngine.Vector3[] path)
        {
            var val_1;
            if((X1 + 24) < 1)
            {
                    return;
            }
            
            val_1 = null;
            val_1 = null;
            SA.Common.Animation.SA_iTween.DrawPathHelper(path:  null, color:  new UnityEngine.Color() {r = SA_iTween.Defaults.color, g = SA_iTween.Defaults.time.__il2cppRuntimeField_28, b = SA_iTween.Defaults.time.__il2cppRuntimeField_2C, a = SA_iTween.Defaults.time.__il2cppRuntimeField_30}, method:  X1);
        }
        public static void DrawPath(UnityEngine.Vector3[] path, UnityEngine.Color color)
        {
            if((X1 + 24) < 1)
            {
                    return;
            }
            
            SA.Common.Animation.SA_iTween.DrawPathHelper(path:  null, color:  new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = color.a}, method:  X1);
        }
        public static void DrawPath(UnityEngine.Transform[] path)
        {
            var val_4;
            var val_5;
            var val_6;
            if((X1 + 24) < 1)
            {
                    return;
            }
            
            val_4 = 0;
            goto label_3;
            label_10:
            var val_1 = null + (X24 * 12);
            val_4 = 1;
            mem2[0] = ???;
            mem2[0] = ???;
            mem2[0] = ???;
            label_3:
            val_5 = mem[X1 + 24];
            val_5 = X1 + 24;
            if(val_4 >= val_5)
            {
                goto label_5;
            }
            
            if(null == null)
            {
                    val_5 = mem[X1 + 24];
                val_5 = X1 + 24;
            }
            
            var val_2 = X1 + 8;
            UnityEngine.Vector3 val_3 = (X1 + 8) + 32.position;
            goto label_10;
            label_5:
            val_6 = null;
            val_6 = null;
            SA.Common.Animation.SA_iTween.DrawPathHelper(path:  null, color:  new UnityEngine.Color() {r = SA_iTween.Defaults.color, g = SA_iTween.Defaults.time.__il2cppRuntimeField_28, b = SA_iTween.Defaults.time.__il2cppRuntimeField_2C, a = SA_iTween.Defaults.time.__il2cppRuntimeField_30}, method:  null);
        }
        public static void DrawPath(UnityEngine.Transform[] path, UnityEngine.Color color)
        {
            var val_4;
            var val_5;
            if((X1 + 24) < 1)
            {
                    return;
            }
            
            val_4 = 0;
            goto label_3;
            label_10:
            var val_1 = null + (X24 * 12);
            val_4 = 1;
            mem2[0] = ???;
            mem2[0] = ???;
            mem2[0] = ???;
            label_3:
            val_5 = mem[X1 + 24];
            val_5 = X1 + 24;
            if(val_4 >= val_5)
            {
                goto label_5;
            }
            
            if(null == null)
            {
                    val_5 = mem[X1 + 24];
                val_5 = X1 + 24;
            }
            
            var val_2 = X1 + 8;
            UnityEngine.Vector3 val_3 = (X1 + 8) + 32.position;
            goto label_10;
            label_5:
            SA.Common.Animation.SA_iTween.DrawPathHelper(path:  null, color:  new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = color.a}, method:  null);
        }
        public static void DrawPathGizmos(UnityEngine.Vector3[] path)
        {
            var val_1;
            if((X1 + 24) < 1)
            {
                    return;
            }
            
            val_1 = null;
            val_1 = null;
            SA.Common.Animation.SA_iTween.DrawPathHelper(path:  null, color:  new UnityEngine.Color() {r = SA_iTween.Defaults.color, g = SA_iTween.Defaults.time.__il2cppRuntimeField_28, b = SA_iTween.Defaults.time.__il2cppRuntimeField_2C, a = SA_iTween.Defaults.time.__il2cppRuntimeField_30}, method:  X1);
        }
        public static void DrawPathGizmos(UnityEngine.Vector3[] path, UnityEngine.Color color)
        {
            if((X1 + 24) < 1)
            {
                    return;
            }
            
            SA.Common.Animation.SA_iTween.DrawPathHelper(path:  null, color:  new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = color.a}, method:  X1);
        }
        public static void DrawPathGizmos(UnityEngine.Transform[] path)
        {
            var val_4;
            var val_5;
            var val_6;
            if((X1 + 24) < 1)
            {
                    return;
            }
            
            val_4 = 0;
            goto label_3;
            label_10:
            var val_1 = null + (X24 * 12);
            val_4 = 1;
            mem2[0] = ???;
            mem2[0] = ???;
            mem2[0] = ???;
            label_3:
            val_5 = mem[X1 + 24];
            val_5 = X1 + 24;
            if(val_4 >= val_5)
            {
                goto label_5;
            }
            
            if(null == null)
            {
                    val_5 = mem[X1 + 24];
                val_5 = X1 + 24;
            }
            
            var val_2 = X1 + 8;
            UnityEngine.Vector3 val_3 = (X1 + 8) + 32.position;
            goto label_10;
            label_5:
            val_6 = null;
            val_6 = null;
            SA.Common.Animation.SA_iTween.DrawPathHelper(path:  null, color:  new UnityEngine.Color() {r = SA_iTween.Defaults.color, g = SA_iTween.Defaults.time.__il2cppRuntimeField_28, b = SA_iTween.Defaults.time.__il2cppRuntimeField_2C, a = SA_iTween.Defaults.time.__il2cppRuntimeField_30}, method:  null);
        }
        public static void DrawPathGizmos(UnityEngine.Transform[] path, UnityEngine.Color color)
        {
            var val_4;
            var val_5;
            if((X1 + 24) < 1)
            {
                    return;
            }
            
            val_4 = 0;
            goto label_3;
            label_10:
            var val_1 = null + (X24 * 12);
            val_4 = 1;
            mem2[0] = ???;
            mem2[0] = ???;
            mem2[0] = ???;
            label_3:
            val_5 = mem[X1 + 24];
            val_5 = X1 + 24;
            if(val_4 >= val_5)
            {
                goto label_5;
            }
            
            if(null == null)
            {
                    val_5 = mem[X1 + 24];
                val_5 = X1 + 24;
            }
            
            var val_2 = X1 + 8;
            UnityEngine.Vector3 val_3 = (X1 + 8) + 32.position;
            goto label_10;
            label_5:
            SA.Common.Animation.SA_iTween.DrawPathHelper(path:  null, color:  new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = color.a}, method:  null);
        }
        public static void DrawPathHandles(UnityEngine.Vector3[] path)
        {
            var val_1;
            if((X1 + 24) < 1)
            {
                    return;
            }
            
            val_1 = null;
            val_1 = null;
            SA.Common.Animation.SA_iTween.DrawPathHelper(path:  null, color:  new UnityEngine.Color() {r = SA_iTween.Defaults.color, g = SA_iTween.Defaults.time.__il2cppRuntimeField_28, b = SA_iTween.Defaults.time.__il2cppRuntimeField_2C, a = SA_iTween.Defaults.time.__il2cppRuntimeField_30}, method:  X1);
        }
        public static void DrawPathHandles(UnityEngine.Vector3[] path, UnityEngine.Color color)
        {
            if((X1 + 24) < 1)
            {
                    return;
            }
            
            SA.Common.Animation.SA_iTween.DrawPathHelper(path:  null, color:  new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = color.a}, method:  X1);
        }
        public static void DrawPathHandles(UnityEngine.Transform[] path)
        {
            var val_4;
            var val_5;
            var val_6;
            if((X1 + 24) < 1)
            {
                    return;
            }
            
            val_4 = 0;
            goto label_3;
            label_10:
            var val_1 = null + (X24 * 12);
            val_4 = 1;
            mem2[0] = ???;
            mem2[0] = ???;
            mem2[0] = ???;
            label_3:
            val_5 = mem[X1 + 24];
            val_5 = X1 + 24;
            if(val_4 >= val_5)
            {
                goto label_5;
            }
            
            if(null == null)
            {
                    val_5 = mem[X1 + 24];
                val_5 = X1 + 24;
            }
            
            var val_2 = X1 + 8;
            UnityEngine.Vector3 val_3 = (X1 + 8) + 32.position;
            goto label_10;
            label_5:
            val_6 = null;
            val_6 = null;
            SA.Common.Animation.SA_iTween.DrawPathHelper(path:  null, color:  new UnityEngine.Color() {r = SA_iTween.Defaults.color, g = SA_iTween.Defaults.time.__il2cppRuntimeField_28, b = SA_iTween.Defaults.time.__il2cppRuntimeField_2C, a = SA_iTween.Defaults.time.__il2cppRuntimeField_30}, method:  null);
        }
        public static void DrawPathHandles(UnityEngine.Transform[] path, UnityEngine.Color color)
        {
            var val_4;
            var val_5;
            if((X1 + 24) < 1)
            {
                    return;
            }
            
            val_4 = 0;
            goto label_3;
            label_10:
            var val_1 = null + (X24 * 12);
            val_4 = 1;
            mem2[0] = ???;
            mem2[0] = ???;
            mem2[0] = ???;
            label_3:
            val_5 = mem[X1 + 24];
            val_5 = X1 + 24;
            if(val_4 >= val_5)
            {
                goto label_5;
            }
            
            if(null == null)
            {
                    val_5 = mem[X1 + 24];
                val_5 = X1 + 24;
            }
            
            var val_2 = X1 + 8;
            UnityEngine.Vector3 val_3 = (X1 + 8) + 32.position;
            goto label_10;
            label_5:
            SA.Common.Animation.SA_iTween.DrawPathHelper(path:  null, color:  new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = color.a}, method:  null);
        }
        public static void CameraFadeDepth(int depth)
        {
            var val_7;
            var val_8;
            val_7 = null;
            val_7 = null;
            if((UnityEngine.Object.op_Implicit(exists:  0)) == false)
            {
                    return;
            }
            
            val_8 = null;
            val_8 = null;
            UnityEngine.Vector3 val_4 = SA.Common.Animation.SA_iTween.cameraFade.transform.position;
            UnityEngine.Vector3 val_6 = SA.Common.Animation.SA_iTween.cameraFade.transform.position;
            SA.Common.Animation.SA_iTween.cameraFade.transform.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        public static void CameraFadeDestroy()
        {
            var val_2;
            var val_3;
            val_2 = null;
            val_2 = null;
            if((UnityEngine.Object.op_Implicit(exists:  0)) == false)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            UnityEngine.Object.Destroy(obj:  0);
        }
        public static void CameraFadeSwap(UnityEngine.Texture2D texture)
        {
        
        }
        public static UnityEngine.GameObject CameraFadeAdd(UnityEngine.Texture2D texture, int depth)
        {
            var val_5;
            UnityEngine.GameObject val_6;
            var val_7;
            val_5 = null;
            val_5 = null;
            val_6 = 0;
            if((UnityEngine.Object.op_Implicit(exists:  0)) == true)
            {
                    return val_6;
            }
            
            val_7 = null;
            val_7 = null;
            SA.Common.Animation.SA_iTween.cameraFade = new UnityEngine.GameObject(name:  "iTween Camera Fade");
            transform.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            val_6 = SA.Common.Animation.SA_iTween.cameraFade;
            return val_6;
        }
        public static UnityEngine.GameObject CameraFadeAdd(UnityEngine.Texture2D texture)
        {
            var val_5;
            UnityEngine.GameObject val_6;
            UnityEngine.GameObject val_7;
            var val_8;
            var val_9;
            val_5 = null;
            val_5 = null;
            val_6 = SA.Common.Animation.SA_iTween.cameraFade;
            val_7 = 0;
            if((UnityEngine.Object.op_Implicit(exists:  0)) == true)
            {
                    return val_7;
            }
            
            val_8 = null;
            val_8 = null;
            SA.Common.Animation.SA_iTween.cameraFade = new UnityEngine.GameObject(name:  "iTween Camera Fade");
            val_6 = transform;
            val_9 = null;
            val_9 = null;
            val_6.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            val_7 = SA.Common.Animation.SA_iTween.cameraFade;
            return val_7;
        }
        public static UnityEngine.GameObject CameraFadeAdd()
        {
            var val_5;
            UnityEngine.GameObject val_6;
            UnityEngine.GameObject val_7;
            var val_8;
            var val_9;
            val_5 = null;
            val_5 = null;
            val_6 = SA.Common.Animation.SA_iTween.cameraFade;
            val_7 = 0;
            if((UnityEngine.Object.op_Implicit(exists:  0)) == true)
            {
                    return val_7;
            }
            
            val_8 = null;
            val_8 = null;
            SA.Common.Animation.SA_iTween.cameraFade = new UnityEngine.GameObject(name:  "iTween Camera Fade");
            val_6 = transform;
            val_9 = null;
            val_9 = null;
            val_6.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            val_7 = SA.Common.Animation.SA_iTween.cameraFade;
            return val_7;
        }
        public static void Resume(UnityEngine.GameObject target)
        {
            var val_4;
            T[] val_1 = X1.GetComponents<SA.Common.Animation.SA_iTween>();
            val_4 = 0;
            goto label_2;
            label_9:
            val_1.enabled = true;
            val_4 = 1;
            label_2:
            if(val_4 >= val_1.Length)
            {
                    return;
            }
            
            if(val_1[1] == 0)
            {
                goto label_9;
            }
            
            goto label_9;
        }
        public static void Resume(UnityEngine.GameObject target, bool includechildren)
        {
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            val_10 = includechildren;
            val_11 = 1152921504851894272;
            SA.Common.Animation.SA_iTween.Resume(target:  null);
            if((W2 & 1) == 0)
            {
                    return;
            }
            
            System.Collections.IEnumerator val_2 = val_10.transform.GetEnumerator();
            label_23:
            var val_10 = 0;
            val_10 = val_10 + 1;
            val_12 = val_2;
            if(((val_2 & 1) & 1) == 0)
            {
                goto label_32;
            }
            
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_13 = val_2;
            goto label_23;
            label_32:
            val_10 = val_2;
            if(val_10 != null)
            {
                    var val_12 = 0;
                val_12 = val_12 + 1;
                val_14 = val_10;
            }
            
            if( == 89)
            {
                    return;
            }
            
            if(null == 0)
            {
                    return;
            }
        
        }
        public static void Resume(UnityEngine.GameObject target, string type)
        {
            goto label_2;
            label_16:
            0 = 1;
            label_2:
            if(0 >= val_1.Length)
            {
                    return;
            }
            
            T val_10 = type.GetComponents<SA.Common.Animation.SA_iTween>()[1];
            if(val_10 == 0)
            {
                goto label_6;
            }
            
            string val_7 = X2.ToLower();
            if((System.String.op_Equality(a:  0, b:  0 + val_1[0x1][0] + 32(val_1[0x1][0] + 32).Substring(startIndex:  0, length:  X2.Length).ToLower())) == false)
            {
                goto label_16;
            }
            
            val_10.enabled = true;
            goto label_16;
            label_6:
        }
        public static void Resume(UnityEngine.GameObject target, string type, bool includechildren)
        {
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            val_20 = 0;
            goto label_2;
            label_16:
            val_20 = 1;
            label_2:
            if(val_20 >= val_1.Length)
            {
                goto label_4;
            }
            
            T val_19 = type.GetComponents<SA.Common.Animation.SA_iTween>()[1];
            if(val_19 == 0)
            {
                goto label_6;
            }
            
            string val_7 = includechildren.ToLower();
            if((System.String.op_Equality(a:  0, b:  0 + val_1[0x1][0] + 32(val_1[0x1][0] + 32).Substring(startIndex:  0, length:  includechildren.Length).ToLower())) == false)
            {
                goto label_16;
            }
            
            val_19.enabled = true;
            goto label_16;
            label_4:
            if((W3 & 1) == 0)
            {
                    return;
            }
            
            System.Collections.IEnumerator val_10 = type.transform.GetEnumerator();
            label_37:
            var val_20 = 0;
            val_20 = val_20 + 1;
            val_21 = val_10;
            if(((val_10 & 1) & 1) == 0)
            {
                goto label_46;
            }
            
            var val_21 = 0;
            val_21 = val_21 + 1;
            val_22 = val_10;
            goto label_37;
            label_46:
            if(val_10 != null)
            {
                    var val_22 = 0;
                val_22 = val_22 + 1;
                val_24 = val_10;
            }
            
            if(0 == 195)
            {
                    return;
            }
            
            if(null == 0)
            {
                    return;
            }
            
            return;
            label_6:
            val_23 = ;
        }
        public static void Resume()
        {
            var val_4;
            var val_5;
            var val_6;
            val_4 = 0;
            goto label_1;
            label_12:
            SA.Common.Animation.SA_iTween.Resume(target:  22203);
            val_4 = 1;
            label_1:
            val_5 = null;
            val_5 = null;
            if(val_4 >= SA.Common.Animation.SA_iTween.tweens.Count)
            {
                    return;
            }
            
            val_6 = null;
            val_6 = null;
            if((SA.Common.Animation.SA_iTween.tweens.Item[1] == null) || (null == null))
            {
                goto label_12;
            }
            
            goto label_12;
        }
        public static void Resume(string type)
        {
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            val_6 = 0;
            goto label_1;
            label_14:
            val_6 = 1;
            label_1:
            val_7 = null;
            val_7 = null;
            int val_2 = SA.Common.Animation.SA_iTween.tweens.Count;
            if(val_6 >= val_2)
            {
                goto label_5;
            }
            
            val_8 = null;
            val_8 = null;
            if(SA.Common.Animation.SA_iTween.tweens.Item[1] == null)
            {
                goto label_10;
            }
            
            if(null == null)
            {
                goto label_11;
            }
            
            label_10:
            label_11:
            if(null != 0)
            {
                goto label_14;
            }
            
            goto label_14;
            label_5:
            val_9 = 0;
            goto label_15;
            label_22:
            SA.Common.Animation.SA_iTween.Resume(target:  val_2, type:  SA.Common.Animation.SA_iTween.tweens);
            val_9 = 1;
            label_15:
            if(val_9 >= new System.Collections.ArrayList())
            {
                    return;
            }
            
            if((null == 0) || (null == null))
            {
                goto label_22;
            }
            
            goto label_22;
        }
        public static void Pause(UnityEngine.GameObject target)
        {
            var val_5;
            T val_6;
            val_5 = 0;
            goto label_2;
            label_10:
            enabled = false;
            val_5 = 1;
            label_2:
            if(val_5 >= val_1.Length)
            {
                    return;
            }
            
            val_6 = X1.GetComponents<SA.Common.Animation.SA_iTween>()[1];
            val_6 = 0;
            if((5.87748E-39f) <= 0f)
            {
                goto label_10;
            }
            
            float val_4 = UnityEngine.Time.time;
            val_4 = val_4 - 0f;
            val_4 = (5.87748E-39f) - val_4;
            mem[56] = val_4;
            val_6.StopCoroutine(methodName:  "TweenDelay");
            goto label_10;
        }
        public static void Pause(UnityEngine.GameObject target, bool includechildren)
        {
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            val_10 = includechildren;
            val_11 = 1152921504851894272;
            SA.Common.Animation.SA_iTween.Pause(target:  null);
            if((W2 & 1) == 0)
            {
                    return;
            }
            
            System.Collections.IEnumerator val_2 = val_10.transform.GetEnumerator();
            label_23:
            var val_10 = 0;
            val_10 = val_10 + 1;
            val_12 = val_2;
            if(((val_2 & 1) & 1) == 0)
            {
                goto label_32;
            }
            
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_13 = val_2;
            goto label_23;
            label_32:
            val_10 = val_2;
            if(val_10 != null)
            {
                    var val_12 = 0;
                val_12 = val_12 + 1;
                val_14 = val_10;
            }
            
            if( == 89)
            {
                    return;
            }
            
            if(null == 0)
            {
                    return;
            }
        
        }
        public static void Pause(UnityEngine.GameObject target, string type)
        {
            goto label_2;
            label_18:
            0 = 1;
            label_2:
            if(0 >= val_1.Length)
            {
                    return;
            }
            
            T val_11 = type.GetComponents<SA.Common.Animation.SA_iTween>()[1];
            string val_8 = X2.ToLower();
            if((System.String.op_Equality(a:  0, b:  0 + 64.Substring(startIndex:  0, length:  X2.Length).ToLower())) == false)
            {
                goto label_18;
            }
            
            if((5.87748E-39f) > 0f)
            {
                    float val_10 = UnityEngine.Time.time;
                val_10 = val_10 - 0f;
                val_10 = (5.87748E-39f) - val_10;
                mem[56] = val_10;
                0.StopCoroutine(methodName:  "TweenDelay");
            }
            
            mem[65] = 1;
            0.enabled = false;
            goto label_18;
        }
        public static void Pause(UnityEngine.GameObject target, string type, bool includechildren)
        {
            SA.Common.Animation.SA_iTween val_20;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            var val_26;
            val_20 = includechildren;
            val_21 = 1152921504608284672;
            val_22 = 0;
            goto label_2;
            label_18:
            val_22 = 1;
            label_2:
            if(val_22 >= val_1.Length)
            {
                goto label_4;
            }
            
            T val_20 = type.GetComponents<SA.Common.Animation.SA_iTween>()[1];
            string val_8 = val_20.ToLower();
            if((System.String.op_Equality(a:  0, b:  0 + 64.Substring(startIndex:  0, length:  val_20.Length).ToLower())) == false)
            {
                goto label_18;
            }
            
            if((5.87748E-39f) > 0f)
            {
                    float val_10 = UnityEngine.Time.time;
                val_10 = val_10 - 0f;
                val_10 = (5.87748E-39f) - val_10;
                mem[56] = val_10;
                0.StopCoroutine(methodName:  "TweenDelay");
            }
            
            mem[65] = 1;
            0.enabled = false;
            goto label_18;
            label_4:
            if(((???) & 1) == 0)
            {
                    return;
            }
            
            System.Collections.IEnumerator val_12 = type.transform.GetEnumerator();
            label_40:
            var val_21 = 0;
            val_21 = val_21 + 1;
            val_23 = val_12;
            if(((val_12 & 1) & 1) == 0)
            {
                goto label_49;
            }
            
            var val_22 = 0;
            val_22 = val_22 + 1;
            val_24 = val_12;
            goto label_40;
            label_49:
            if(val_12 != null)
            {
                    var val_23 = 0;
                val_23 = val_23 + 1;
                val_26 = val_12;
            }
            
            if( == 254)
            {
                    return;
            }
            
            if( == 0)
            {
                    return;
            }
        
        }
        public static void Pause()
        {
            var val_4;
            var val_5;
            var val_6;
            val_4 = 0;
            goto label_1;
            label_12:
            SA.Common.Animation.SA_iTween.Pause(target:  22185);
            val_4 = 1;
            label_1:
            val_5 = null;
            val_5 = null;
            if(val_4 >= SA.Common.Animation.SA_iTween.tweens.Count)
            {
                    return;
            }
            
            val_6 = null;
            val_6 = null;
            if((SA.Common.Animation.SA_iTween.tweens.Item[1] == null) || (null == null))
            {
                goto label_12;
            }
            
            goto label_12;
        }
        public static void Pause(string type)
        {
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            val_6 = 0;
            goto label_1;
            label_14:
            val_6 = 1;
            label_1:
            val_7 = null;
            val_7 = null;
            int val_2 = SA.Common.Animation.SA_iTween.tweens.Count;
            if(val_6 >= val_2)
            {
                goto label_5;
            }
            
            val_8 = null;
            val_8 = null;
            if(SA.Common.Animation.SA_iTween.tweens.Item[1] == null)
            {
                goto label_10;
            }
            
            if(null == null)
            {
                goto label_11;
            }
            
            label_10:
            label_11:
            if(null != 0)
            {
                goto label_14;
            }
            
            goto label_14;
            label_5:
            val_9 = 0;
            goto label_15;
            label_22:
            SA.Common.Animation.SA_iTween.Pause(target:  val_2, type:  SA.Common.Animation.SA_iTween.tweens);
            val_9 = 1;
            label_15:
            if(val_9 >= new System.Collections.ArrayList())
            {
                    return;
            }
            
            if((null == 0) || (null == null))
            {
                goto label_22;
            }
            
            goto label_22;
        }
        public static int Count()
        {
            null = null;
            if(SA.Common.Animation.SA_iTween.tweens != null)
            {
                    return SA.Common.Animation.SA_iTween.tweens.Count;
            }
            
            return SA.Common.Animation.SA_iTween.tweens.Count;
        }
        public static int Count(string type)
        {
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            string val_16;
            var val_17;
            var val_18;
            val_12 = 0;
            val_13 = 0;
            goto label_1;
            label_21:
            string val_1 = X1.ToLower();
            val_13 = (System.String.op_Equality(a:  0, b:  X22)) + val_13;
            val_12 = 1;
            label_1:
            val_14 = null;
            val_14 = null;
            if(val_12 >= SA.Common.Animation.SA_iTween.tweens.Count)
            {
                    return (int)val_13;
            }
            
            val_15 = null;
            val_15 = null;
            System.Collections.Hashtable val_5 = SA.Common.Animation.SA_iTween.tweens.Item[1];
            val_16 = val_5;
            val_17 = null;
            val_18 = val_5;
            val_17 = null;
            if(val_16 == null)
            {
                goto label_13;
            }
            
            if(null == val_17)
            {
                goto label_14;
            }
            
            val_17 = null;
            label_13:
            val_16 = 0;
            label_14:
            if(val_18 != null)
            {
                    if(null == val_17)
            {
                goto label_16;
            }
            
            }
            
            val_18 = 0;
            label_16:
            string val_11 = 0 + val_16.Substring(startIndex:  0, length:  X1.Length).ToLower();
            if(X1 != 0)
            {
                goto label_21;
            }
            
            goto label_21;
        }
        public static int Count(UnityEngine.GameObject target)
        {
            if((X1.GetComponents<SA.Common.Animation.SA_iTween>()) != null)
            {
                    return (int)val_1.Length;
            }
            
            return (int)val_1.Length;
        }
        public static int Count(UnityEngine.GameObject target, string type)
        {
            string val_11;
            var val_12;
            var val_13;
            val_12 = 0;
            val_13 = 0;
            goto label_2;
            label_15:
            string val_2 = X2.ToLower();
            val_11 = 0;
            val_13 = (System.String.op_Equality(a:  val_11, b:  X22)) + val_13;
            val_12 = 1;
            label_2:
            if(val_12 >= val_1.Length)
            {
                    return (int)val_13;
            }
            
            if((type.GetComponents<SA.Common.Animation.SA_iTween>()[1]) == 0)
            {
                goto label_6;
            }
            
            string val_9 = 0 + val_1[0x1][0] + 32(val_1[0x1][0] + 32).Substring(startIndex:  0, length:  X2.Length).ToLower();
            if(X2 != 0)
            {
                goto label_15;
            }
            
            goto label_15;
            label_6:
        }
        public static void Stop()
        {
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            val_7 = 0;
            goto label_1;
            label_12:
            SA.Common.Animation.SA_iTween.Stop(target:  22242);
            val_7 = 1;
            label_1:
            val_8 = null;
            val_8 = null;
            val_9 = null;
            if(val_7 >= SA.Common.Animation.SA_iTween.tweens.Count)
            {
                goto label_5;
            }
            
            val_10 = null;
            if((SA.Common.Animation.SA_iTween.tweens.Item[1] == null) || (null == null))
            {
                goto label_12;
            }
            
            goto label_12;
            label_5:
            val_11 = null;
            SA.Common.Animation.SA_iTween.tweens.Clear();
        }
        public static void Stop(string type)
        {
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            val_6 = 0;
            goto label_1;
            label_14:
            val_6 = 1;
            label_1:
            val_7 = null;
            val_7 = null;
            int val_2 = SA.Common.Animation.SA_iTween.tweens.Count;
            if(val_6 >= val_2)
            {
                goto label_5;
            }
            
            val_8 = null;
            val_8 = null;
            if(SA.Common.Animation.SA_iTween.tweens.Item[1] == null)
            {
                goto label_10;
            }
            
            if(null == null)
            {
                goto label_11;
            }
            
            label_10:
            label_11:
            if(null != 0)
            {
                goto label_14;
            }
            
            goto label_14;
            label_5:
            val_9 = 0;
            goto label_15;
            label_22:
            SA.Common.Animation.SA_iTween.Stop(target:  val_2, type:  SA.Common.Animation.SA_iTween.tweens);
            val_9 = 1;
            label_15:
            if(val_9 >= new System.Collections.ArrayList())
            {
                    return;
            }
            
            if((null == 0) || (null == null))
            {
                goto label_22;
            }
            
            goto label_22;
        }
        public static void StopByName(string name)
        {
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            val_6 = 0;
            goto label_1;
            label_14:
            val_6 = 1;
            label_1:
            val_7 = null;
            val_7 = null;
            int val_2 = SA.Common.Animation.SA_iTween.tweens.Count;
            if(val_6 >= val_2)
            {
                goto label_5;
            }
            
            val_8 = null;
            val_8 = null;
            if(SA.Common.Animation.SA_iTween.tweens.Item[1] == null)
            {
                goto label_10;
            }
            
            if(null == null)
            {
                goto label_11;
            }
            
            label_10:
            label_11:
            if(null != 0)
            {
                goto label_14;
            }
            
            goto label_14;
            label_5:
            val_9 = 0;
            goto label_15;
            label_22:
            SA.Common.Animation.SA_iTween.StopByName(target:  val_2, name:  SA.Common.Animation.SA_iTween.tweens);
            val_9 = 1;
            label_15:
            if(val_9 >= new System.Collections.ArrayList())
            {
                    return;
            }
            
            if((null == 0) || (null == null))
            {
                goto label_22;
            }
            
            goto label_22;
        }
        public static void Stop(UnityEngine.GameObject target)
        {
            var val_4;
            T[] val_1 = X1.GetComponents<SA.Common.Animation.SA_iTween>();
            val_4 = 0;
            goto label_2;
            label_9:
            val_1.Dispose();
            val_4 = 1;
            label_2:
            if(val_4 >= val_1.Length)
            {
                    return;
            }
            
            if(val_1[1] == 0)
            {
                goto label_9;
            }
            
            goto label_9;
        }
        public static void Stop(UnityEngine.GameObject target, bool includechildren)
        {
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            val_10 = includechildren;
            val_11 = 1152921504851894272;
            SA.Common.Animation.SA_iTween.Stop(target:  null);
            if((W2 & 1) == 0)
            {
                    return;
            }
            
            System.Collections.IEnumerator val_2 = val_10.transform.GetEnumerator();
            label_23:
            var val_10 = 0;
            val_10 = val_10 + 1;
            val_12 = val_2;
            if(((val_2 & 1) & 1) == 0)
            {
                goto label_32;
            }
            
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_13 = val_2;
            goto label_23;
            label_32:
            val_10 = val_2;
            if(val_10 != null)
            {
                    var val_12 = 0;
                val_12 = val_12 + 1;
                val_14 = val_10;
            }
            
            if( == 89)
            {
                    return;
            }
            
            if(null == 0)
            {
                    return;
            }
        
        }
        public static void Stop(UnityEngine.GameObject target, string type)
        {
            goto label_2;
            label_16:
            0 = 1;
            label_2:
            if(0 >= val_1.Length)
            {
                    return;
            }
            
            T val_10 = type.GetComponents<SA.Common.Animation.SA_iTween>()[1];
            if(val_10 == 0)
            {
                goto label_6;
            }
            
            string val_7 = X2.ToLower();
            if((System.String.op_Equality(a:  0, b:  0 + val_1[0x1][0] + 32(val_1[0x1][0] + 32).Substring(startIndex:  0, length:  X2.Length).ToLower())) == false)
            {
                goto label_16;
            }
            
            val_10.Dispose();
            goto label_16;
            label_6:
        }
        public static void StopByName(UnityEngine.GameObject target, string name)
        {
            goto label_2;
            label_12:
            0 = 1;
            label_2:
            if(0 >= val_1.Length)
            {
                    return;
            }
            
            T val_5 = name.GetComponents<SA.Common.Animation.SA_iTween>()[1];
            if(val_5 == 0)
            {
                goto label_6;
            }
            
            if((System.String.op_Equality(a:  0, b:  val_1[0x1][0] + 72)) == false)
            {
                goto label_12;
            }
            
            val_5.Dispose();
            goto label_12;
            label_6:
        }
        public static void Stop(UnityEngine.GameObject target, string type, bool includechildren)
        {
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            val_20 = 0;
            goto label_2;
            label_16:
            val_20 = 1;
            label_2:
            if(val_20 >= val_1.Length)
            {
                goto label_4;
            }
            
            T val_19 = type.GetComponents<SA.Common.Animation.SA_iTween>()[1];
            if(val_19 == 0)
            {
                goto label_6;
            }
            
            string val_7 = includechildren.ToLower();
            if((System.String.op_Equality(a:  0, b:  0 + val_1[0x1][0] + 32(val_1[0x1][0] + 32).Substring(startIndex:  0, length:  includechildren.Length).ToLower())) == false)
            {
                goto label_16;
            }
            
            val_19.Dispose();
            goto label_16;
            label_4:
            if((W3 & 1) == 0)
            {
                    return;
            }
            
            System.Collections.IEnumerator val_10 = type.transform.GetEnumerator();
            label_37:
            var val_20 = 0;
            val_20 = val_20 + 1;
            val_21 = val_10;
            if(((val_10 & 1) & 1) == 0)
            {
                goto label_46;
            }
            
            var val_21 = 0;
            val_21 = val_21 + 1;
            val_22 = val_10;
            goto label_37;
            label_46:
            if(val_10 != null)
            {
                    var val_22 = 0;
                val_22 = val_22 + 1;
                val_24 = val_10;
            }
            
            if(0 == 194)
            {
                    return;
            }
            
            if(null == 0)
            {
                    return;
            }
            
            return;
            label_6:
            val_23 = ;
        }
        public static void StopByName(UnityEngine.GameObject target, string name, bool includechildren)
        {
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            val_15 = 0;
            goto label_2;
            label_12:
            val_15 = 1;
            label_2:
            if(val_15 >= val_1.Length)
            {
                goto label_4;
            }
            
            T val_14 = name.GetComponents<SA.Common.Animation.SA_iTween>()[1];
            if(val_14 == 0)
            {
                goto label_6;
            }
            
            if((System.String.op_Equality(a:  0, b:  val_1[0x1][0] + 72)) == false)
            {
                goto label_12;
            }
            
            val_14.Dispose();
            goto label_12;
            label_4:
            if((W3 & 1) == 0)
            {
                    return;
            }
            
            System.Collections.IEnumerator val_5 = name.transform.GetEnumerator();
            label_33:
            var val_15 = 0;
            val_15 = val_15 + 1;
            val_16 = val_5;
            if(((val_5 & 1) & 1) == 0)
            {
                goto label_42;
            }
            
            var val_16 = 0;
            val_16 = val_16 + 1;
            val_17 = val_5;
            goto label_33;
            label_42:
            if(val_5 != null)
            {
                    var val_17 = 0;
                val_17 = val_17 + 1;
                val_19 = val_5;
            }
            
            if(0 == 153)
            {
                    return;
            }
            
            if(null == 0)
            {
                    return;
            }
            
            return;
            label_6:
            val_18 = ;
        }
        public static System.Collections.Hashtable Hash(object[] args)
        {
            var val_9;
            var val_10;
            var val_11;
            System.Collections.Hashtable val_3 = null;
            val_9 = val_3;
            val_3 = new System.Collections.Hashtable(capacity:  (((X1 + 24) < 0) ? ((X1 + 24) + 1) : (X1 + 24)) >> 1);
            if(((X1 + 24) & 1) != 0)
            {
                goto label_3;
            }
            
            val_10 = 0;
            goto label_4;
            label_10:
            val_10 = W23 + 1;
            label_4:
            val_11 = mem[X1 + 24];
            val_11 = X1 + 24;
            if(val_10 >= (val_11 - 1))
            {
                    return (System.Collections.Hashtable)val_9;
            }
            
            if(val_10 >= val_11)
            {
                    val_11 = mem[X1 + 24];
                val_11 = X1 + 24;
            }
            
            var val_5 = X1 + (((long)(int)((W23 + 1))) << 3);
            var val_6 = val_10 + 1;
            var val_7 = X1 + (((long)(int)(((W23 + 1) + 1))) << 3);
            if(null != 0)
            {
                goto label_10;
            }
            
            goto label_10;
            label_3:
            UnityEngine.Debug.LogError(message:  0);
            val_9 = 0;
            return (System.Collections.Hashtable)val_9;
        }
        private void Awake()
        {
            this.thisTransform = this.transform;
            this.RetrieveArgs();
            this.lastRealTime = UnityEngine.Time.realtimeSinceStartup;
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator Start()
        {
            typeof(SA_iTween.<Start>c__Iterator2).__il2cppRuntimeField_10 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        private void Update()
        {
            if(this.isRunning == false)
            {
                    return;
            }
            
            if(this.physics != false)
            {
                    return;
            }
            
            if(this.reverse == false)
            {
                goto label_2;
            }
            
            if(this.percentage > 0f)
            {
                goto label_3;
            }
            
            this.TweenComplete();
            return;
            label_2:
            if(this.percentage >= 0)
            {
                goto label_4;
            }
            
            label_3:
            this.TweenUpdate();
            return;
            label_4:
            this.TweenComplete();
        }
        private void FixedUpdate()
        {
            if(this.isRunning == false)
            {
                    return;
            }
            
            if(this.physics == false)
            {
                    return;
            }
            
            if(this.reverse == false)
            {
                goto label_2;
            }
            
            if(this.percentage > 0f)
            {
                goto label_3;
            }
            
            this.TweenComplete();
            return;
            label_2:
            if(this.percentage >= 0)
            {
                goto label_4;
            }
            
            label_3:
            this.TweenUpdate();
            return;
            label_4:
            this.TweenComplete();
        }
        private void LateUpdate()
        {
            UnityEngine.GameObject val_7;
            if((this.tweenArguments & 1) == 0)
            {
                    return;
            }
            
            if(this.isRunning == false)
            {
                    return;
            }
            
            if((System.String.op_Equality(a:  0, b:  this.type)) != true)
            {
                    if((System.String.op_Equality(a:  0, b:  this.type)) != true)
            {
                    if((System.String.op_Equality(a:  0, b:  this.type)) == false)
            {
                    return;
            }
            
            }
            
            }
            
            val_7 = null;
            SA.Common.Animation.SA_iTween.LookUpdate(target:  val_7, args:  this.gameObject);
        }
        private void OnEnable()
        {
            if(this.isPaused == false)
            {
                    return;
            }
            
            this.isPaused = false;
            if(this.delay <= 0f)
            {
                    return;
            }
            
            this.wasPaused = true;
            this.ResumeDelay();
        }
        private void OnDisable()
        {
        
        }
        private static void DrawLineHelper(UnityEngine.Vector3[] line, UnityEngine.Color color, string method)
        {
            var val_3;
            bool val_6 = true;
            UnityEngine.Gizmos.color = new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = color.a};
            val_3 = 0;
            goto label_1;
            label_16:
            val_3 = 1;
            label_1:
            val_6 = val_6 - 1;
            if(val_3 >= val_6)
            {
                    return;
            }
            
            if((System.String.op_Equality(a:  0, b:  X2)) == false)
            {
                goto label_6;
            }
            
            var val_2 = method + (1 * 12);
            var val_4 = method + (((long)val_3 + 1) * 12);
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = (1 * 12) + method + 32, y = (1 * 12) + method + 32 + 4, z = (1 * 12) + method + 40}, to:  new UnityEngine.Vector3() {x = ((long)(int)((val_3 + 1)) * 12) + method + 32, y = ((long)(int)((val_3 + 1)) * 12) + method + 32 + 4, z = ((long)(int)((val_3 + 1)) * 12) + method + 40});
            goto label_16;
            label_6:
            if((System.String.op_Equality(a:  0, b:  X2)) == false)
            {
                goto label_16;
            }
            
            UnityEngine.Debug.LogError(message:  0);
            goto label_16;
        }
        private static void DrawPathHelper(UnityEngine.Vector3[] path, UnityEngine.Color color, string method)
        {
            float val_8;
            float val_9;
            float val_10;
            float val_11;
            val_8 = color.b;
            val_9 = color.r;
            UnityEngine.Vector3 val_2 = SA.Common.Animation.SA_iTween.Interp(pts:  SA.Common.Animation.SA_iTween.PathControlPointGenerator(path:  null), t:  0f);
            val_10 = val_2.x;
            val_11 = val_2.z;
            UnityEngine.Gizmos.color = new UnityEngine.Color() {r = val_9, g = color.g, b = val_8, a = color.a};
            var val_9 = 0;
            val_9 = (float)(SA.Common.Animation.SA_iTween.__il2cppRuntimeField_cctor_finished * 20);
            val_8 = val_2.y;
            UnityEngine.Vector3 val_6 = SA.Common.Animation.SA_iTween.Interp(pts:  null, t:  ((float)val_9 + 1) / val_9);
            val_10 = val_6.x;
            val_11 = val_6.z;
            if((System.String.op_Equality(a:  0, b:  X2)) != false)
            {
                    UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_10, y = val_6.y, z = val_11}, to:  new UnityEngine.Vector3() {x = val_10, y = val_8, z = val_11});
            }
            else
            {
                    if((System.String.op_Equality(a:  0, b:  X2)) != false)
            {
                    UnityEngine.Debug.LogError(message:  0);
            }
            
            }
            
            val_9 = val_9 + 1;
        }
        private static UnityEngine.Vector3[] PathControlPointGenerator(UnityEngine.Vector3[] path)
        {
            var val_17;
            System.Array val_18;
            val_17 = (X1 + 24) + 2;
            val_18 = null;
            System.Array.Copy(sourceArray:  0, sourceIndex:  X1, destinationArray:  0, destinationIndex:  1254012752, length:  1);
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_2C, y = UnityEngine.Vector3[].__il2cppRuntimeField_element_class, z = typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_34}, b:  new UnityEngine.Vector3() {x = UnityEngine.Vector3[].__il2cppRuntimeField_castClass, y = typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_3C, z = UnityEngine.Vector3[].__il2cppRuntimeField_declaringType});
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_2C, y = UnityEngine.Vector3[].__il2cppRuntimeField_element_class, z = typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_34}, b:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_20 = val_2.x;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_24 = val_2.y;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_28 = val_2.z;
            var val_16 = 12;
            val_16 = val_18 + ((((-8589934592 + (UnityEngine.Vector3[].__il2cppRuntimeField_namespaze) << 32)) >> 32) * val_16);
            var val_17 = 12;
            val_17 = val_18 + ((((-12884901888 + (UnityEngine.Vector3[].__il2cppRuntimeField_namespaze) << 32)) >> 32) * val_17);
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = (((-8589934592 + (UnityEngine.Vector3[].__il2cppRuntimeField_namespaze) << 32) >> 32) * 12) + val_18 + 32, y = (((-8589934592 + (UnityEngine.Vector3[].__il2cppRuntimeField_namespaze) << 32) >> 32) * 12) + val_18 + 32 + 4, z = (((-8589934592 + (UnityEngine.Vector3[].__il2cppRuntimeField_namespaze) << 32) >> 32) * 12) + val_18 + 40}, b:  new UnityEngine.Vector3() {x = (((-12884901888 + (UnityEngine.Vector3[].__il2cppRuntimeField_namespaze) << 32) >> 32) * 12) + val_18 + 32, y = (((-12884901888 + (UnityEngine.Vector3[].__il2cppRuntimeField_namespaze) << 32) >> 32) * 12) + val_18 + 32 + 4, z = (((-12884901888 + (UnityEngine.Vector3[].__il2cppRuntimeField_namespaze) << 32) >> 32) * 12) + val_18 + 40});
            var val_18 = 12;
            val_18 = val_18 + ((((-8589934592 + (UnityEngine.Vector3[].__il2cppRuntimeField_namespaze) << 32)) >> 32) * val_18);
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = (((-8589934592 + (UnityEngine.Vector3[].__il2cppRuntimeField_namespaze) << 32) >> 32) * 12) + val_18 + 32, y = (((-8589934592 + (UnityEngine.Vector3[].__il2cppRuntimeField_namespaze) << 32) >> 32) * 12) + val_18 + 32 + 4, z = (((-8589934592 + (UnityEngine.Vector3[].__il2cppRuntimeField_namespaze) << 32) >> 32) * 12) + val_18 + 40}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            var val_19 = 12;
            val_19 = val_18 + ((((-4294967296 + (UnityEngine.Vector3[].__il2cppRuntimeField_namespaze) << 32)) >> 32) * val_19);
            mem2[0] = val_8.x;
            mem2[0] = val_8.y;
            mem2[0] = val_8.z;
            var val_20 = 12;
            val_20 = val_18 + ((((-8589934592 + (UnityEngine.Vector3[].__il2cppRuntimeField_namespaze) << 32)) >> 32) * val_20);
            if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_2C, y = UnityEngine.Vector3[].__il2cppRuntimeField_element_class, z = typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_34}, rhs:  new UnityEngine.Vector3() {x = (((-8589934592 + (UnityEngine.Vector3[].__il2cppRuntimeField_namespaze) << 32) >> 32) * 12) + val_18 + 32, y = (((-8589934592 + (UnityEngine.Vector3[].__il2cppRuntimeField_namespaze) << 32) >> 32) * 12) + val_18 + 32 + 4, z = (((-8589934592 + (UnityEngine.Vector3[].__il2cppRuntimeField_namespaze) << 32) >> 32) * 12) + val_18 + 40})) == false)
            {
                    return (UnityEngine.Vector3[])val_18;
            }
            
            System.Array.Copy(sourceArray:  0, destinationArray:  val_18, length:  1254012752);
            var val_21 = 12;
            val_21 = null + ((((-12884901888 + (UnityEngine.Vector3[].__il2cppRuntimeField_namespaze) << 32)) >> 32) * val_21);
            UnityEngine.Vector3[].__il2cppRuntimeField_byval_arg.__il2cppRuntimeField_8 = (((-12884901888 + (UnityEngine.Vector3[].__il2cppRuntimeField_namespaze) << 32) >> 32) * 12) + null + 40;
            UnityEngine.Vector3[].__il2cppRuntimeField_byval_arg.__il2cppRuntimeField_FFFFFFFFFFFFFFFF = (((-12884901888 + (UnityEngine.Vector3[].__il2cppRuntimeField_namespaze) << 32) >> 32) * 12) + null + 32;
            var val_22 = 12;
            val_22 = null + ((((-4294967296 + (UnityEngine.Vector3[].__il2cppRuntimeField_namespaze) << 32)) >> 32) * val_22);
            var val_15 = val_22 + 32;
            mem2[0] = UnityEngine.Vector3[].__il2cppRuntimeField_declaringType;
            mem2[0] = UnityEngine.Vector3[].__il2cppRuntimeField_castClass;
            val_18 = null;
            System.Array.Copy(sourceArray:  0, destinationArray:  null, length:  1254012752);
            return (UnityEngine.Vector3[])val_18;
        }
        private static UnityEngine.Vector3 Interp(UnityEngine.Vector3[] pts, float t)
        {
            var val_32;
            float val_2 = ((float)(X1 + 24) - 3) * t;
            var val_4 = (X1 + 24) - 4;
            int val_5 = UnityEngine.Mathf.Min(a:  0, b:  UnityEngine.Mathf.FloorToInt(f:  val_2));
            val_32 = mem[X1 + 24];
            val_32 = X1 + 24;
            if(val_5 >= val_32)
            {
                    val_32 = mem[X1 + 24];
                val_32 = X1 + 24;
            }
            
            var val_32 = 12;
            val_32 = X1 + ((long)val_5 * val_32);
            var val_6 = (long)val_5 + 1;
            if(val_6 >= val_32)
            {
                    val_32 = mem[X1 + 24];
                val_32 = X1 + 24;
            }
            
            var val_33 = 12;
            val_33 = X1 + ((long)val_6 * val_33);
            var val_7 = (long)val_5 + 2;
            if(val_7 >= val_32)
            {
                    val_32 = mem[X1 + 24];
                val_32 = X1 + 24;
            }
            
            var val_34 = 12;
            val_34 = X1 + ((long)val_7 * val_34);
            var val_35 = 12;
            val_35 = X1 + (((long)(long)val_5 + 3) * val_35);
            float val_9 = val_2 - (float)val_5;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = ((long)(int)(val_5) * 12) + X1 + 32, y = ((long)(int)(val_5) * 12) + X1 + 32 + 4, z = ((long)(int)(val_5) * 12) + X1 + 40});
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Multiply(d:  3f, a:  new UnityEngine.Vector3() {x = ((long)(int)(((long)(int)(val_5) + 1)) * 12) + X1 + 32, y = ((long)(int)(((long)(int)(val_5) + 1)) * 12) + X1 + 32 + 4, z = ((long)(int)(((long)(int)(val_5) + 1)) * 12) + X1 + 40});
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, b:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Multiply(d:  3f, a:  new UnityEngine.Vector3() {x = ((long)(int)(((long)(int)(val_5) + 2)) * 12) + X1 + 32, y = ((long)(int)(((long)(int)(val_5) + 2)) * 12) + X1 + 36, z = ((long)(int)(((long)(int)(val_5) + 2)) * 12) + X1 + 40});
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, b:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, b:  new UnityEngine.Vector3() {x = ((long)(int)(((long)(int)(val_5) + 3)) * 12) + X1 + 32, y = ((long)(int)(((long)(int)(val_5) + 3)) * 12) + X1 + 36, z = ((long)(int)(((long)(int)(val_5) + 3)) * 12) + X1 + 40});
            float val_36 = val_9;
            float val_16 = val_36 * val_36;
            val_36 = val_36 * val_16;
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, d:  val_36);
            UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Multiply(d:  2f, a:  new UnityEngine.Vector3() {x = ((long)(int)(val_5) * 12) + X1 + 32, y = ((long)(int)(val_5) * 12) + X1 + 32 + 4, z = ((long)(int)(val_5) * 12) + X1 + 40});
            UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Multiply(d:  5f, a:  new UnityEngine.Vector3() {x = ((long)(int)(((long)(int)(val_5) + 1)) * 12) + X1 + 32, y = ((long)(int)(((long)(int)(val_5) + 1)) * 12) + X1 + 32 + 4, z = ((long)(int)(((long)(int)(val_5) + 1)) * 12) + X1 + 40});
            UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z}, b:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z});
            UnityEngine.Vector3 val_21 = UnityEngine.Vector3.op_Multiply(d:  4f, a:  new UnityEngine.Vector3() {x = ((long)(int)(((long)(int)(val_5) + 2)) * 12) + X1 + 32, y = ((long)(int)(((long)(int)(val_5) + 2)) * 12) + X1 + 36, z = ((long)(int)(((long)(int)(val_5) + 2)) * 12) + X1 + 40});
            UnityEngine.Vector3 val_22 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z}, b:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z});
            UnityEngine.Vector3 val_23 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z}, b:  new UnityEngine.Vector3() {x = ((long)(int)(((long)(int)(val_5) + 3)) * 12) + X1 + 32, y = ((long)(int)(((long)(int)(val_5) + 3)) * 12) + X1 + 36, z = ((long)(int)(((long)(int)(val_5) + 3)) * 12) + X1 + 40});
            UnityEngine.Vector3 val_24 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z}, d:  val_16);
            UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z}, b:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z});
            UnityEngine.Vector3 val_26 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = ((long)(int)(val_5) * 12) + X1 + 32, y = ((long)(int)(val_5) * 12) + X1 + 32 + 4, z = ((long)(int)(val_5) * 12) + X1 + 40});
            UnityEngine.Vector3 val_27 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z}, b:  new UnityEngine.Vector3() {x = ((long)(int)(((long)(int)(val_5) + 2)) * 12) + X1 + 32, y = ((long)(int)(((long)(int)(val_5) + 2)) * 12) + X1 + 36, z = ((long)(int)(((long)(int)(val_5) + 2)) * 12) + X1 + 40});
            UnityEngine.Vector3 val_28 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z}, d:  val_9);
            UnityEngine.Vector3 val_29 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z}, b:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z});
            UnityEngine.Vector3 val_30 = UnityEngine.Vector3.op_Multiply(d:  2f, a:  new UnityEngine.Vector3() {x = ((long)(int)(((long)(int)(val_5) + 1)) * 12) + X1 + 32, y = ((long)(int)(((long)(int)(val_5) + 1)) * 12) + X1 + 32 + 4, z = ((long)(int)(((long)(int)(val_5) + 1)) * 12) + X1 + 40});
            UnityEngine.Vector3 val_31 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z}, b:  new UnityEngine.Vector3() {x = val_30.x, y = val_30.y, z = val_30.z});
            return UnityEngine.Vector3.op_Multiply(d:  0.5f, a:  new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_31.z});
        }
        private static void Launch(UnityEngine.GameObject target, System.Collections.Hashtable args)
        {
            var val_5;
            if(((X2 & 1) & 1) == 0)
            {
                    string val_2 = SA.Common.Animation.SA_iTween.GenerateID();
            }
            
            var val_3 = X2 & 1;
            val_5 = null;
            val_5 = null;
            SA.Common.Animation.SA_iTween.tweens.Insert(index:  0, item:  X2);
            SA.Common.Animation.SA_iTween val_4 = args.AddComponent<SA.Common.Animation.SA_iTween>();
        }
        private static System.Collections.Hashtable CleanArgs(System.Collections.Hashtable args)
        {
            var val_27;
            var val_28;
            var val_29;
            var val_31;
            var val_32;
            var val_33;
            var val_36;
            var val_37;
            var val_38;
            var val_39;
            System.Collections.Hashtable val_1 = new System.Collections.Hashtable(capacity:  X1);
            label_19:
            var val_28 = X1;
            if((X1 + 258) == 0)
            {
                goto label_5;
            }
            
            var val_25 = X1 + 152;
            var val_26 = 0;
            val_25 = val_25 + 8;
            label_7:
            if(((X1 + 152 + 8) + -8) == null)
            {
                goto label_6;
            }
            
            val_26 = val_26 + 1;
            val_25 = val_25 + 16;
            if(val_26 < (X1 + 258))
            {
                goto label_7;
            }
            
            label_5:
            val_27 = X1;
            goto label_8;
            label_6:
            var val_27 = val_25;
            val_27 = val_27 + 1;
            val_28 = val_28 + val_27;
            val_27 = val_28 + 272;
            label_8:
            if(((X1 & 1) & 1) == 0)
            {
                goto label_96;
            }
            
            var val_31 = X1;
            if((X1 + 258) == 0)
            {
                goto label_11;
            }
            
            var val_29 = X1 + 152;
            var val_30 = 0;
            val_29 = val_29 + 8;
            label_13:
            if(((X1 + 152 + 8) + -8) == null)
            {
                goto label_12;
            }
            
            val_30 = val_30 + 1;
            val_29 = val_29 + 16;
            if(val_30 < (X1 + 258))
            {
                goto label_13;
            }
            
            label_11:
            val_28 = X1;
            goto label_14;
            label_12:
            val_31 = val_31 + (((X1 + 152 + 8)) << 4);
            val_28 = val_31 + 272;
            label_14:
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_6 = X1.InitializationCallback;
            if(null != 0)
            {
                goto label_19;
            }
            
            goto label_19;
            label_96:
            if(X1 == 0)
            {
                goto label_21;
            }
            
            var val_34 = X1;
            if((X1 + 258) == 0)
            {
                goto label_22;
            }
            
            var val_32 = X1 + 152;
            var val_33 = 0;
            val_32 = val_32 + 8;
            label_24:
            if(((X1 + 152 + 8) + -8) == null)
            {
                goto label_23;
            }
            
            val_33 = val_33 + 1;
            val_32 = val_32 + 16;
            if(val_33 < (X1 + 258))
            {
                goto label_24;
            }
            
            label_22:
            val_31 = X1;
            goto label_25;
            label_23:
            val_34 = val_34 + (((X1 + 152 + 8)) << 4);
            val_31 = val_34 + 272;
            label_25:
            label_21:
            if(0 == 106)
            {
                
            }
            
            label_58:
            System.Collections.Hashtable val_38 = null;
            if((mem[null + 258]) == 0)
            {
                goto label_31;
            }
            
            var val_35 = mem[null + 152];
            var val_36 = 0;
            val_35 = val_35 + 8;
            label_33:
            if(((mem[null + 152] + 8) + -8) == null)
            {
                goto label_32;
            }
            
            val_36 = val_36 + 1;
            val_35 = val_35 + 16;
            if(val_36 < (mem[null + 258]))
            {
                goto label_33;
            }
            
            label_31:
            val_32 = val_1;
            goto label_34;
            label_32:
            var val_37 = val_35;
            val_37 = val_37 + 1;
            val_38 = val_38 + val_37;
            label_34:
            if((0 & 1) == 0)
            {
                goto label_100;
            }
            
            System.Collections.Hashtable val_41 = null;
            if((mem[null + 258]) == 0)
            {
                goto label_37;
            }
            
            var val_39 = mem[null + 152];
            var val_40 = 0;
            val_39 = val_39 + 8;
            label_39:
            if(((mem[null + 152] + 8) + -8) == null)
            {
                goto label_38;
            }
            
            val_40 = val_40 + 1;
            val_39 = val_39 + 16;
            if(val_40 < (mem[null + 258]))
            {
                goto label_39;
            }
            
            label_37:
            val_33 = val_1;
            goto label_40;
            label_38:
            val_41 = val_41 + (((mem[null + 152] + 8)) << 4);
            label_40:
            if(null.GetType() == (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                    val_29 = null;
                UnityEngine.Vector2 val_11 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {y = val_8.y});
                System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_12 = null.InitializationCallback;
            }
            
            if(null.GetType() != (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                goto label_58;
            }
            
            val_29 = null;
            UnityEngine.Vector2 val_15 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = (float)null, y = val_11.y});
            if(X1 != 0)
            {
                goto label_58;
            }
            
            goto label_58;
            label_99:
            val_29 = 1152921504608124928;
            if(null.InitializationCallback != 1)
            {
                goto label_87;
            }
            
            label_100:
            if(null == 0)
            {
                goto label_60;
            }
            
            System.Collections.Hashtable val_44 = null;
            if((mem[null + 258]) == 0)
            {
                goto label_61;
            }
            
            var val_42 = mem[null + 152];
            var val_43 = 0;
            val_42 = val_42 + 8;
            label_63:
            if(((mem[null + 152] + 8) + -8) == null)
            {
                goto label_62;
            }
            
            val_43 = val_43 + 1;
            val_42 = val_42 + 16;
            if(val_43 < (mem[null + 258]))
            {
                goto label_63;
            }
            
            label_61:
            val_36 = val_1;
            goto label_64;
            label_62:
            val_44 = val_44 + (((mem[null + 152] + 8)) << 4);
            label_64:
            label_60:
            if(0 == 305)
            {
                
            }
            
            label_86:
            var val_48 = X1;
            if((X1 + 258) == 0)
            {
                goto label_70;
            }
            
            var val_45 = X1 + 152;
            var val_46 = 0;
            val_45 = val_45 + 8;
            label_72:
            if(((X1 + 152 + 8) + -8) == null)
            {
                goto label_71;
            }
            
            val_46 = val_46 + 1;
            val_45 = val_45 + 16;
            if(val_46 < (X1 + 258))
            {
                goto label_72;
            }
            
            label_70:
            val_37 = X1;
            goto label_73;
            label_71:
            var val_47 = val_45;
            val_47 = val_47 + 1;
            val_48 = val_48 + val_47;
            val_37 = val_48 + 272;
            label_73:
            if(((X1 & 1) & 1) == 0)
            {
                goto label_98;
            }
            
            var val_51 = X1;
            if((X1 + 258) == 0)
            {
                goto label_76;
            }
            
            var val_49 = X1 + 152;
            var val_50 = 0;
            val_49 = val_49 + 8;
            label_78:
            if(((X1 + 152 + 8) + -8) == null)
            {
                goto label_77;
            }
            
            val_50 = val_50 + 1;
            val_49 = val_49 + 16;
            if(val_50 < (X1 + 258))
            {
                goto label_78;
            }
            
            label_76:
            val_38 = X1;
            goto label_79;
            label_77:
            val_51 = val_51 + (((X1 + 152 + 8)) << 4);
            val_38 = val_51 + 272;
            label_79:
            if(null != 0)
            {
                goto label_86;
            }
            
            goto label_86;
            label_98:
            if(X1 == 0)
            {
                goto label_88;
            }
            
            var val_54 = X1;
            if((X1 + 258) == 0)
            {
                goto label_89;
            }
            
            var val_52 = X1 + 152;
            var val_53 = 0;
            val_52 = val_52 + 8;
            label_91:
            if(((X1 + 152 + 8) + -8) == null)
            {
                goto label_90;
            }
            
            val_53 = val_53 + 1;
            val_52 = val_52 + 16;
            if(val_53 < (X1 + 258))
            {
                goto label_91;
            }
            
            label_89:
            val_39 = X1;
            goto label_92;
            label_90:
            val_54 = val_54 + (((X1 + 152 + 8)) << 4);
            val_39 = val_54 + 272;
            label_92:
            label_88:
            if(0 == 402)
            {
                    return (System.Collections.Hashtable)new System.Collections.Hashtable(capacity:  X1);
            }
            
            if(null == 0)
            {
                    return (System.Collections.Hashtable)new System.Collections.Hashtable(capacity:  X1);
            }
            
            return (System.Collections.Hashtable)new System.Collections.Hashtable(capacity:  X1);
            label_87:
            goto label_99;
        }
        private static string GenerateID()
        {
            System.Guid val_1 = System.Guid.NewGuid();
            return (string);
        }
        private void RetrieveArgs()
        {
            float val_3;
            var val_58;
            var val_59;
            UnityEngine.Object val_60;
            var val_61;
            var val_62;
            var val_63;
            var val_64;
            string val_65;
            string val_66;
            string val_67;
            string val_68;
            float val_71;
            var val_72;
            float val_73;
            var val_74;
            var val_75;
            var val_76;
            var val_77;
            SA_iTween.NamedValueColor val_78;
            SA_iTween.NamedValueColor val_79;
            var val_80;
            var val_81;
            var val_83;
            var val_84;
            SA.Common.Animation.EaseType val_85;
            var val_86;
            var val_87;
            var val_88;
            UnityEngine.Space val_89;
            var val_90;
            var val_91;
            bool val_92;
            var val_93;
            var val_94;
            bool val_95;
            var val_96;
            val_58 = null;
            val_58 = null;
            List.Enumerator<T> val_1 = SA.Common.Animation.SA_iTween.tweens.GetEnumerator();
            val_59 = 1152921510475137152;
            label_10:
            if((0 & 1) == 0)
            {
                goto label_4;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_4 = val_3.InitializationCallback;
            val_60 = val_4;
            UnityEngine.GameObject val_5 = this.gameObject;
            if(val_60 != null)
            {
                    if(null == null)
            {
                goto label_9;
            }
            
            }
            
            val_60 = 0;
            label_9:
            if(0 != val_60)
            {
                goto label_10;
            }
            
            val_61 = 0;
            this.tweenArguments = val_4;
            goto label_11;
            label_4:
            val_61 = 0;
            label_11:
            val_64 = 1;
            val_3.Dispose();
            val_65 = this.tweenArguments;
            if(val_65 != null)
            {
                    if(null == null)
            {
                goto label_18;
            }
            
            }
            
            val_65 = 0;
            label_18:
            this.id = val_65;
            val_66 = this.tweenArguments;
            if(val_66 != null)
            {
                    if(null == null)
            {
                goto label_21;
            }
            
            }
            
            val_66 = 0;
            label_21:
            this.type = val_66;
            val_67 = this.tweenArguments;
            if(val_67 != null)
            {
                    if(null == null)
            {
                goto label_24;
            }
            
            }
            
            val_67 = 0;
            label_24:
            this._name = val_67;
            val_68 = this.tweenArguments;
            if(val_68 != null)
            {
                    if(null == null)
            {
                goto label_27;
            }
            
            }
            
            val_68 = 0;
            label_27:
            this.method = val_68;
            if((this.tweenArguments & 1) != 0)
            {
                    val_62 = this.tweenArguments;
                val_63 = null;
                UnityEngine.Vector2 val_12 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_3});
            }
            else
            {
                    val_72 = null;
                val_72 = null;
                val_71 = SA_iTween.Defaults.time;
            }
            
            this.time = val_71;
            if(0 != (this.GetComponent<UnityEngine.Rigidbody>()))
            {
                    this.physics = true;
            }
            
            if((this.tweenArguments & 1) != 0)
            {
                    val_62 = this.tweenArguments;
                val_63 = null;
                UnityEngine.Vector2 val_15 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_3});
            }
            else
            {
                    val_74 = null;
                val_74 = null;
                val_73 = SA_iTween.Defaults.delay;
            }
            
            this.delay = val_73;
            if((this.tweenArguments & 1) == 0)
            {
                goto label_48;
            }
            
            val_59 = 1152921504852107264;
            if(this.tweenArguments.GetType() == (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                goto label_53;
            }
            
            val_75 = this.tweenArguments;
            if(val_75 != null)
            {
                    if(null == null)
            {
                goto label_60;
            }
            
            }
            
            val_75 = 0;
            label_60:
            val_62 = null;
            val_76 = System.Enum.Parse(enumType:  0, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), ignoreCase:  false);
            UnityEngine.Vector2 val_21 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_3});
            goto label_63;
            label_48:
            val_77 = null;
            val_77 = null;
            val_78 = SA_iTween.Defaults.namedColorValue;
            goto label_66;
            label_53:
            val_79 = null;
            val_76 = this.tweenArguments;
            UnityEngine.Vector2 val_22 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_3});
            label_63:
            label_66:
            this.namedcolorvalue = null;
            if((this.tweenArguments & 1) == 0)
            {
                goto label_71;
            }
            
            val_59 = 1152921504852054016;
            if(this.tweenArguments.GetType() == (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                goto label_76;
            }
            
            val_80 = this.tweenArguments;
            if(val_80 != null)
            {
                    if(null == null)
            {
                goto label_83;
            }
            
            }
            
            val_80 = 0;
            label_83:
            val_81 = System.Enum.Parse(enumType:  0, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), ignoreCase:  false);
            UnityEngine.Vector2 val_28 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y});
            goto label_86;
            label_76:
            val_79 = null;
            val_81 = this.tweenArguments;
            UnityEngine.Vector2 val_29 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y});
            label_86:
            this.loopType = null;
            goto label_90;
            label_71:
            this.loopType = 0;
            label_90:
            if((this.tweenArguments & 1) == 0)
            {
                goto label_105;
            }
            
            val_59 = 1152921504851787776;
            if(this.tweenArguments.GetType() == (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                goto label_110;
            }
            
            val_83 = this.tweenArguments;
            if(val_83 != null)
            {
                    if(null == null)
            {
                goto label_117;
            }
            
            }
            
            val_83 = 0;
            label_117:
            val_84 = System.Enum.Parse(enumType:  0, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), ignoreCase:  false);
            UnityEngine.Vector2 val_39 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y});
            goto label_124;
            label_110:
            val_79 = null;
            val_84 = this.tweenArguments;
            UnityEngine.Vector2 val_40 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y});
            goto label_124;
            label_105:
            val_86 = null;
            val_86 = null;
            val_85 = SA_iTween.Defaults.easeType;
            label_124:
            this.easeType = val_85;
            if((this.tweenArguments & 1) == 0)
            {
                goto label_132;
            }
            
            val_59 = 1152921504723832832;
            if(this.tweenArguments.GetType() == (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                goto label_137;
            }
            
            val_87 = this.tweenArguments;
            if(val_87 != null)
            {
                    if(null == null)
            {
                goto label_144;
            }
            
            }
            
            val_87 = 0;
            label_144:
            val_88 = System.Enum.Parse(enumType:  0, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), ignoreCase:  false);
            UnityEngine.Vector2 val_47 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y});
            goto label_151;
            label_137:
            val_79 = null;
            val_88 = this.tweenArguments;
            UnityEngine.Vector2 val_48 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y});
            goto label_151;
            label_132:
            val_90 = null;
            val_90 = null;
            val_89 = SA_iTween.Defaults.space;
            label_151:
            this.space = val_89;
            if((this.tweenArguments & 1) != 0)
            {
                    val_91 = null;
                UnityEngine.Vector2 val_50 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y});
            }
            else
            {
                    val_93 = null;
                val_93 = null;
                val_92 = SA_iTween.Defaults.isLocal;
            }
            
            this.isLocal = val_92;
            val_94 = "ignoretimescale";
            if((this.tweenArguments & 1) != 0)
            {
                    val_94 = this.tweenArguments;
                val_91 = null;
                UnityEngine.Vector2 val_51 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y});
            }
            else
            {
                    val_96 = null;
                val_96 = null;
                val_95 = SA_iTween.Defaults.useRealTime;
            }
            
            this.useRealTime = val_95;
            this.GetEasingFunction();
        }
        private void GetEasingFunction()
        {
            SA.Common.Animation.EaseType val_2 = this.easeType;
            val_2 = (val_2 < 32) ? (val_2 + 3) : 0;
            val_2 = val_2 - 3;
            if(val_2 > 31)
            {
                    return;
            }
            
            var val_3 = 25975936 + ((this.easeType < 0x20 ? (this.easeType + 3) : 0 - 3)) << 2;
            val_3 = val_3 + 25975936;
            goto (25975936 + ((this.easeType < 0x20 ? (this.easeType + 3) : 0 - 3)) << 2 + 25975936);
        }
        private void UpdatePercentage()
        {
            if(this.useRealTime != false)
            {
                    float val_1 = UnityEngine.Time.realtimeSinceStartup;
                val_1 = val_1 - this.lastRealTime;
            }
            else
            {
                    float val_2 = UnityEngine.Time.deltaTime;
            }
            
            float val_4 = this.time;
            val_2 = this.runningTime + val_2;
            this.runningTime = val_2;
            val_2 = val_2 / val_4;
            val_4 = 1f - val_2;
            val_2 = (this.reverse == false) ? (val_2) : (val_4);
            this.percentage = val_2;
            this.lastRealTime = UnityEngine.Time.realtimeSinceStartup;
        }
        private void CallBack(string callbackType)
        {
            string val_10;
            System.Collections.Hashtable val_11;
            val_10 = this;
            val_11 = this.tweenArguments;
            if((val_11 & 1) == 0)
            {
                    return;
            }
            
            val_11 = this.tweenArguments;
            if(((val_11 & 1) & 1) != 0)
            {
                    return;
            }
            
            string val_2 = 0 + callbackType;
            if((this.tweenArguments & 1) != 0)
            {
                    string val_3 = 0 + callbackType;
                val_11 = this.tweenArguments;
                if(val_11 != null)
            {
                    if(null == null)
            {
                goto label_14;
            }
            
            }
            
                val_11 = 0;
            }
            else
            {
                    val_11 = this.gameObject;
            }
            
            label_14:
            if(this.tweenArguments.GetType() != (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                    UnityEngine.Debug.LogError(message:  0);
                UnityEngine.Object.Destroy(obj:  0);
                return;
            }
            
            val_10 = this.tweenArguments;
            string val_8 = 0 + callbackType;
            if(val_10 == null)
            {
                goto label_30;
            }
            
            if(null == null)
            {
                goto label_31;
            }
            
            label_30:
            val_10 = 0;
            label_31:
            val_11.SendMessage(methodName:  val_10, value:  this.tweenArguments, options:  1);
        }
        private void Dispose()
        {
            var val_5;
            var val_6;
            System.Collections.Generic.List<System.Collections.Hashtable> val_7;
            var val_8;
            var val_9;
            string val_10;
            var val_11;
            val_5 = 0;
            goto label_1;
            label_14:
            val_5 = 1;
            label_1:
            val_6 = null;
            val_6 = null;
            val_7 = SA.Common.Animation.SA_iTween.tweens;
            if(val_5 >= val_7.Count)
            {
                goto label_5;
            }
            
            val_8 = null;
            val_8 = null;
            val_9 = null;
            val_10 = SA.Common.Animation.SA_iTween.tweens.Item[1];
            val_9 = null;
            if(val_10 != null)
            {
                    if(null == val_9)
            {
                goto label_13;
            }
            
            }
            
            val_10 = 0;
            label_13:
            if((System.String.op_Equality(a:  0, b:  val_10)) == false)
            {
                goto label_14;
            }
            
            val_11 = null;
            val_11 = null;
            val_7 = SA.Common.Animation.SA_iTween.tweens;
            val_7.RemoveAt(index:  1);
            label_5:
            UnityEngine.Object.Destroy(obj:  0);
        }
        private void ConflictCheck()
        {
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            string val_25;
            var val_26;
            var val_27;
            string val_28;
            var val_29;
            var val_31;
            val_21 = 0;
            val_22 = 0;
            val_23 = 0;
            goto label_1;
            label_65:
            val_23 = 1;
            label_1:
            if(val_23 >= val_1.Length)
            {
                    return;
            }
            
            T val_21 = this.GetComponents<SA.Common.Animation.SA_iTween>()[1];
            val_24 = 1;
            val_25 = 64;
            if((System.String.op_Equality(a:  0, b:  val_25)) == true)
            {
                    return;
            }
            
            if((1 == 0) || ((System.String.op_Equality(a:  0, b:  64)) == false))
            {
                goto label_65;
            }
            
            val_25 = this.method;
            if((System.String.op_Inequality(a:  0, b:  34460624)) == true)
            {
                    return;
            }
            
            val_25 = 31514328;
            if(val_25 != this.tweenArguments)
            {
                goto label_23;
            }
            
            label_51:
            var val_22 = 0;
            val_22 = val_22 + 1;
            val_26 = this.tweenArguments;
            if(((this.tweenArguments & 1) & 1) == 0)
            {
                goto label_69;
            }
            
            var val_23 = 0;
            val_23 = val_23 + 1;
            val_27 = this.tweenArguments;
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_14 = null.InitializationCallback;
            if((0 & 1) == 0)
            {
                goto label_41;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_15 = null.InitializationCallback;
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_16 = null.InitializationCallback;
            if((0 & 1) != 0)
            {
                goto label_51;
            }
            
            val_28 = null.InitializationCallback;
            val_29 = null;
            val_29 = null;
            if(val_28 != null)
            {
                    if(null == val_29)
            {
                goto label_50;
            }
            
            }
            
            val_28 = 0;
            label_50:
            if((System.String.op_Inequality(a:  0, b:  val_28)) == false)
            {
                goto label_51;
            }
            
            this.Dispose();
            label_69:
            if(this.tweenArguments != null)
            {
                    var val_24 = 0;
                val_24 = val_24 + 1;
                val_31 = this.tweenArguments;
            }
            
            if( != 327)
            {
                    if( == 346)
            {
                    return;
            }
            
                if( == 0)
            {
                goto label_64;
            }
            
            }
            
            label_64:
            this.Dispose();
            goto label_65;
            label_41:
            this.Dispose();
            goto label_69;
            label_23:
            this.Dispose();
        }
        private void EnableKinematic()
        {
        
        }
        private void DisableKinematic()
        {
        
        }
        private void ResumeDelay()
        {
            UnityEngine.Coroutine val_1 = this.StartCoroutine(methodName:  "TweenDelay");
        }
        private float linear(float start, float end, float value)
        {
            return UnityEngine.Mathf.Lerp(a:  start, b:  end, t:  value);
        }
        private float clerp(float start, float end, float value)
        {
            float val_1 = end - start;
            if(val_1 < 0)
            {
                    float val_1 = 360f;
                val_1 = val_1 - start;
                val_1 = val_1 + end;
            }
            else
            {
                    if(val_1 > 180f)
            {
                    float val_2 = 360f;
                val_2 = val_2 - end;
                val_2 = val_2 + start;
                val_2 = val_2 * value;
                val_2 = start - val_2;
                return (float)val_1;
            }
            
            }
            
            val_1 = val_1 * value;
            val_1 = val_1 + start;
            return (float)val_1;
        }
        private float spring(float start, float end, float value)
        {
            float val_1 = UnityEngine.Mathf.Clamp01(value:  value);
            float val_4 = 2.5f;
            float val_5 = 3.141593f;
            val_4 = val_1 * val_4;
            val_4 = val_1 * val_4;
            val_4 = val_1 * val_4;
            val_5 = val_1 * val_5;
            val_4 = val_4 + 0.2f;
            val_4 = val_5 * val_4;
            float val_2 = 1f - val_1;
            float val_6 = val_2;
            float val_7 = 1.2f;
            val_6 = val_4 * val_6;
            val_6 = val_1 + val_6;
            val_7 = val_2 * val_7;
            val_7 = val_7 + 1f;
            val_6 = val_7 * val_6;
            val_6 = (end - start) * val_6;
            val_6 = val_6 + start;
            return (float)val_6;
        }
        private float easeInQuad(float start, float end, float value)
        {
            end = end - start;
            end = end * value;
            end = end * value;
            start = end + start;
            return (float)start;
        }
        private float easeOutQuad(float start, float end, float value)
        {
            end = end - start;
            end = end * value;
            value = value + (-2f);
            end = end * value;
            start = start - end;
            return (float)start;
        }
        private float easeInOutQuad(float start, float end, float value)
        {
            float val_1;
            value = value + value;
            end = end - start;
            if(value < 0)
            {
                    end = end * 0.5f;
                end = end * value;
                val_1 = value * end;
            }
            else
            {
                    value = value + (-1f);
                end = end * (-0.5f);
                float val_1 = -2f;
                val_1 = value + val_1;
                value = value * val_1;
                value = value + (-1f);
                val_1 = end * value;
            }
            
            start = val_1 + start;
            return (float)start;
        }
        private float easeInCubic(float start, float end, float value)
        {
            end = end - start;
            end = end * value;
            end = end * value;
            end = end * value;
            start = end + start;
            return (float)start;
        }
        private float easeOutCubic(float start, float end, float value)
        {
            float val_1 = -1f;
            value = value + val_1;
            val_1 = value * value;
            value = value * val_1;
            end = end - start;
            value = value + 1f;
            end = end * value;
            start = end + start;
            return (float)start;
        }
        private float easeInOutCubic(float start, float end, float value)
        {
            float val_1;
            value = value + value;
            end = end - start;
            if(value < 0)
            {
                    end = end * 0.5f;
                end = end * value;
                end = value * end;
                val_1 = value * end;
            }
            else
            {
                    float val_1 = -2f;
                value = value + val_1;
                val_1 = value * value;
                value = value * val_1;
                end = end * 0.5f;
                value = value + 2f;
                val_1 = end * value;
            }
            
            start = val_1 + start;
            return (float)start;
        }
        private float easeInQuart(float start, float end, float value)
        {
            end = end - start;
            end = end * value;
            end = end * value;
            end = end * value;
            end = end * value;
            start = end + start;
            return (float)start;
        }
        private float easeOutQuart(float start, float end, float value)
        {
            value = value + (-1f);
            float val_1 = value * value;
            val_1 = value * val_1;
            value = value * val_1;
            end = end - start;
            value = value + (-1f);
            end = end * value;
            start = start - end;
            return (float)start;
        }
        private float easeInOutQuart(float start, float end, float value)
        {
            float val_2;
            value = value + value;
            end = end - start;
            if(value < 0)
            {
                    end = end * 0.5f;
                end = end * value;
                end = value * end;
                end = value * end;
                val_2 = value * end;
            }
            else
            {
                    value = value + (-2f);
                end = end * (-0.5f);
                float val_1 = value * value;
                val_1 = value * val_1;
                value = value * val_1;
                value = value + (-2f);
                val_2 = end * value;
            }
            
            start = val_2 + start;
            return (float)start;
        }
        private float easeInQuint(float start, float end, float value)
        {
            end = end - start;
            end = end * value;
            end = end * value;
            end = end * value;
            end = end * value;
            end = end * value;
            start = end + start;
            return (float)start;
        }
        private float easeOutQuint(float start, float end, float value)
        {
            float val_1 = -1f;
            value = value + val_1;
            val_1 = value * value;
            val_1 = value * val_1;
            val_1 = value * val_1;
            value = value * val_1;
            end = end - start;
            value = value + 1f;
            end = end * value;
            start = end + start;
            return (float)start;
        }
        private float easeInOutQuint(float start, float end, float value)
        {
            float val_1;
            value = value + value;
            end = end - start;
            if(value < 0)
            {
                    end = end * 0.5f;
                end = end * value;
                end = value * end;
                end = value * end;
                end = value * end;
                val_1 = value * end;
            }
            else
            {
                    float val_1 = -2f;
                value = value + val_1;
                val_1 = value * value;
                val_1 = value * val_1;
                val_1 = value * val_1;
                value = value * val_1;
                end = end * 0.5f;
                value = value + 2f;
                val_1 = end * value;
            }
            
            start = val_1 + start;
            return (float)start;
        }
        private float easeInSine(float start, float end, float value)
        {
            float val_1 = end;
            val_1 = val_1 - start;
            float val_2 = 1.570796f;
            val_2 = value * val_2;
            val_2 = val_1 * val_2;
            val_2 = val_1 - val_2;
            val_2 = val_2 + start;
            return (float)val_2;
        }
        private float easeOutSine(float start, float end, float value)
        {
            float val_1 = end;
            val_1 = val_1 - start;
            float val_2 = 1.570796f;
            val_2 = value * val_2;
            val_2 = val_1 * val_2;
            val_2 = val_2 + start;
            return (float)val_2;
        }
        private float easeInOutSine(float start, float end, float value)
        {
            float val_1 = end;
            val_1 = val_1 - start;
            float val_2 = 3.141593f;
            val_2 = value * val_2;
            float val_3 = -0.5f;
            val_3 = val_1 * val_3;
            val_2 = val_2 + (-1f);
            val_2 = val_3 * val_2;
            val_2 = val_2 + start;
            return (float)val_2;
        }
        private float easeInExpo(float start, float end, float value)
        {
            float val_1 = end;
            val_1 = val_1 - start;
            float val_2 = -1f;
            val_2 = value + val_2;
            val_2 = val_2 * 10f;
            val_2 = val_1 * val_2;
            val_2 = val_2 + start;
            return (float)val_2;
        }
        private float easeOutExpo(float start, float end, float value)
        {
            float val_1 = end;
            val_1 = val_1 - start;
            float val_2 = -10f;
            val_2 = value * val_2;
            val_2 = 1f - val_2;
            val_2 = val_1 * val_2;
            val_2 = val_2 + start;
            return (float)val_2;
        }
        private float easeInOutExpo(float start, float end, float value)
        {
            float val_1;
            float val_2;
            float val_3;
            float val_1 = end;
            val_1 = value + value;
            val_1 = val_1 - start;
            if(val_1 < 0)
            {
                    float val_2 = -1f;
                val_2 = val_1 + val_2;
                val_2 = val_2 * 10f;
                val_3 = val_1 * 0.5f;
            }
            else
            {
                    val_1 = val_1 + (-1f);
                float val_3 = -10f;
                val_3 = val_1 * val_3;
                val_3 = val_1 * 0.5f;
                val_2 = 2f - val_3;
            }
            
            val_2 = val_3 * val_2;
            val_2 = val_2 + start;
            return (float)val_2;
        }
        private float easeInCirc(float start, float end, float value)
        {
            float val_2;
            float val_3 = end;
            float val_1 = value * value;
            float val_2 = 1f;
            val_2 = val_2 - val_1;
            val_3 = val_3 - start;
            if(val_1 >= _TYPE_MAX_)
            {
                    val_2 = val_2;
            }
            
            val_2 = val_2 + (-1f);
            val_2 = val_3 * val_2;
            val_2 = start - val_2;
            return (float)val_2;
        }
        private float easeOutCirc(float start, float end, float value)
        {
            float val_1;
            float val_1 = value;
            float val_4 = end;
            float val_2 = -1f;
            val_1 = val_1 + val_2;
            val_2 = val_1 * val_1;
            float val_3 = 1f;
            val_3 = val_3 - val_2;
            val_4 = val_4 - start;
            if(val_2 >= _TYPE_MAX_)
            {
                    val_1 = val_3;
            }
            
            val_1 = val_4 * val_1;
            val_1 = val_1 + start;
            return (float)val_1;
        }
        private float easeInOutCirc(float start, float end, float value)
        {
            float val_5;
            float val_6;
            float val_7;
            float val_8;
            float val_5 = end;
            float val_1 = value + value;
            val_5 = val_5 - start;
            if(val_1 < 0)
            {
                    float val_2 = val_1 * val_1;
                if(val_2 >= _TYPE_MAX_)
            {
                    val_5 = 1f - val_2;
            }
            
                val_6 = val_5 * (-0.5f);
                val_7 = val_5 + (-1f);
            }
            else
            {
                    float val_6 = -2f;
                val_1 = val_1 + val_6;
                val_6 = val_1 * val_1;
                if(val_6 >= _TYPE_MAX_)
            {
                    val_8 = 1f - val_6;
            }
            
                val_6 = val_5 * 0.5f;
                val_7 = val_8 + 1f;
            }
            
            val_7 = val_6 * val_7;
            val_7 = val_7 + start;
            return (float)val_7;
        }
        private float easeInBounce(float start, float end, float value)
        {
            float val_1 = end - start;
            value = 1f - value;
            float val_2 = this.easeOutBounce(start:  0f, end:  val_1, value:  value);
            val_2 = val_1 - val_2;
            val_2 = val_2 + start;
            return (float)val_2;
        }
        private float easeOutBounce(float start, float end, float value)
        {
            float val_1;
            end = end - start;
            if(value < 0)
            {
                    float val_1 = 7.5625f;
                val_1 = value * val_1;
                val_1 = val_1 * value;
            }
            else
            {
                    if(value < 0)
            {
                    float val_2 = -0.5454546f;
                value = value + val_2;
                val_2 = value * 7.5625f;
                value = value * val_2;
                val_1 = value + 0.75f;
            }
            else
            {
                    if((double)value < 0)
            {
                    float val_3 = -0.8181818f;
                value = value + val_3;
                val_3 = value * 7.5625f;
                value = value * val_3;
                val_1 = value + 0.9375f;
            }
            else
            {
                    float val_4 = -0.9545454f;
                value = value + val_4;
                val_4 = value * 7.5625f;
                value = value * val_4;
                val_1 = value + 0.984375f;
            }
            
            }
            
            }
            
            end = end * val_1;
            start = end + start;
            return (float)start;
        }
        private float easeInOutBounce(float start, float end, float value)
        {
            float val_7;
            float val_1 = end - start;
            float val_2 = value + value;
            if(value < 0)
            {
                    value = 1f - val_2;
                float val_3 = this.easeOutBounce(start:  0f, end:  val_1, value:  value);
                val_3 = val_1 - val_3;
                val_3 = val_3 + 0f;
                val_7 = val_3 * 0.5f;
            }
            else
            {
                    value = val_2 + (-1f);
                float val_4 = this.easeOutBounce(start:  0f, end:  val_1, value:  value);
                val_4 = val_4 * 0.5f;
                val_7 = (val_1 * 0.5f) + val_4;
            }
            
            val_7 = val_7 + start;
            return (float)val_7;
        }
        private float easeInBack(float start, float end, float value)
        {
            end = end - start;
            end = end * value;
            end = end * value;
            value = value * 2.70158f;
            value = value + (-1.70158f);
            end = end * value;
            start = end + start;
            return (float)start;
        }
        private float easeOutBack(float start, float end, float value)
        {
            float val_1 = 2.70158f;
            value = value + (-1f);
            float val_2 = 1.70158f;
            val_1 = value * val_1;
            value = value * value;
            end = end - start;
            val_2 = val_1 + val_2;
            value = value * val_2;
            value = value + 1f;
            end = end * value;
            start = end + start;
            return (float)start;
        }
        private float easeInOutBack(float start, float end, float value)
        {
            float val_3;
            float val_4;
            end = end - start;
            value = value + value;
            if(value < 0)
            {
                    val_3 = end * 0.5f;
                value = value * 3.594909f;
                value = value + (-2.594909f);
                val_4 = (value * value) * value;
            }
            else
            {
                    value = value + (-2f);
                float val_3 = 2.594909f;
                val_3 = end * 0.5f;
                value = value * value;
                val_3 = (value * 3.594909f) + val_3;
                value = value * val_3;
                val_4 = value + 2f;
            }
            
            val_3 = val_3 * val_4;
            start = val_3 + start;
            return (float)start;
        }
        private float punch(float amplitude, float value)
        {
            if(value == 0f)
            {
                    return (float)val_1;
            }
            
            if(value == 1f)
            {
                    return (float)val_1;
            }
            
            float val_3 = -10f;
            val_3 = value * val_3;
            float val_1 = value * 6.283185f;
            val_1 = val_1 / 0.3f;
            val_1 = (val_3 * amplitude) * val_1;
            return (float)val_1;
        }
        private float easeInElastic(float start, float end, float value)
        {
            float val_4;
            float val_5;
            val_4 = end;
            val_5 = start;
            if(value == 0f)
            {
                    return (float)val_5;
            }
            
            val_4 = val_4 - val_5;
            if(value == 1f)
            {
                    val_5 = val_4 + val_5;
                return (float)val_5;
            }
            
            float val_1 = value + (-1f);
            float val_4 = 10f;
            val_4 = val_1 * val_4;
            float val_2 = val_1 + (-0.075f);
            val_2 = val_2 * 6.283185f;
            val_2 = val_2 / 0.3f;
            val_2 = (val_4 * val_4) * val_2;
            val_5 = val_5 - val_2;
            return (float)val_5;
        }
        private float easeOutElastic(float start, float end, float value)
        {
            float val_4;
            float val_5;
            val_4 = end;
            val_5 = start;
            if(value == 0f)
            {
                    return (float)val_5;
            }
            
            float val_1 = val_4 - val_5;
            if(value == 1f)
            {
                    val_5 = val_1 + val_5;
                return (float)val_5;
            }
            
            float val_4 = -10f;
            val_4 = value * val_4;
            val_4 = val_4;
            float val_2 = value + (-0.075f);
            val_2 = val_2 * 6.283185f;
            val_2 = val_2 / 0.3f;
            val_2 = (val_1 * val_4) * val_2;
            val_2 = val_1 + val_2;
            val_5 = val_2 + val_5;
            return (float)val_5;
        }
        private float easeInOutElastic(float start, float end, float value)
        {
            float val_9;
            float val_10;
            val_9 = end;
            val_10 = start;
            if(value == 0f)
            {
                    return (float)val_10;
            }
            
            val_9 = val_9 - val_10;
            float val_1 = value + value;
            if(val_1 == 2f)
            {
                    val_10 = val_9 + val_10;
                return (float)val_10;
            }
            
            float val_2 = val_1 + (-1f);
            if(val_1 < 0)
            {
                    float val_9 = 10f;
                val_9 = val_2 * val_9;
                float val_5 = val_2 + (-0.075f);
                val_5 = val_5 * 6.283185f;
                val_5 = val_5 / 0.3f;
                val_5 = (val_9 * val_9) * val_5;
                val_5 = val_5 * (-0.5f);
                val_10 = val_10 + val_5;
                return (float)val_10;
            }
            
            float val_10 = -10f;
            val_10 = val_2 * val_10;
            float val_7 = val_2 + (-0.075f);
            val_7 = val_7 * 6.283185f;
            val_7 = val_7 / 0.3f;
            val_7 = (val_9 * val_10) * val_7;
            val_7 = val_7 * 0.5f;
            val_7 = val_9 + val_7;
            val_10 = val_7 + val_10;
            return (float)val_10;
        }
        private static SA_iTween()
        {
            SA.Common.Animation.SA_iTween.tweens = new System.Collections.Generic.List<System.Collections.Hashtable>();
        }
    
    }

}
