using UnityEngine;

namespace Cinemachine
{
    public struct CameraState
    {
        // Fields
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private Cinemachine.LensSettings <Lens>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private UnityEngine.Vector3 <ReferenceUp>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private UnityEngine.Vector3 <ReferenceLookAt>k__BackingField;
        public static UnityEngine.Vector3 kNoPoint;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private UnityEngine.Vector3 <RawPosition>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private UnityEngine.Quaternion <RawOrientation>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private UnityEngine.Vector3 <PositionDampingBypass>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private float <ShotQuality>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private UnityEngine.Vector3 <PositionCorrection>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private UnityEngine.Quaternion <OrientationCorrection>k__BackingField;
        private Cinemachine.CameraState.CustomBlendable mCustom0;
        private Cinemachine.CameraState.CustomBlendable mCustom1;
        private Cinemachine.CameraState.CustomBlendable mCustom2;
        private Cinemachine.CameraState.CustomBlendable mCustom3;
        private System.Collections.Generic.List<Cinemachine.CameraState.CustomBlendable> m_CustomOverflow;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private int <NumCustomBlendables>k__BackingField;
        
        // Properties
        public Cinemachine.LensSettings Lens { get; set; }
        public UnityEngine.Vector3 ReferenceUp { get; set; }
        public UnityEngine.Vector3 ReferenceLookAt { get; set; }
        public bool HasLookAt { get; }
        public UnityEngine.Vector3 RawPosition { get; set; }
        public UnityEngine.Quaternion RawOrientation { get; set; }
        internal UnityEngine.Vector3 PositionDampingBypass { get; set; }
        public float ShotQuality { get; set; }
        public UnityEngine.Vector3 PositionCorrection { get; set; }
        public UnityEngine.Quaternion OrientationCorrection { get; set; }
        public UnityEngine.Vector3 CorrectedPosition { get; }
        public UnityEngine.Quaternion CorrectedOrientation { get; }
        public UnityEngine.Vector3 FinalPosition { get; }
        public UnityEngine.Quaternion FinalOrientation { get; }
        public static Cinemachine.CameraState Default { get; }
        public int NumCustomBlendables { get; set; }
        
        // Methods
        public Cinemachine.LensSettings get_Lens()
        {
            Cinemachine.LensSettings val_0;
            val_0.FarClipPlane = this.<ReferenceUp>k__BackingField;
            val_0.FieldOfView = this.<ReferenceUp>k__BackingField;
            return val_0;
        }
        public void set_Lens(Cinemachine.LensSettings value)
        {
            this.<ReferenceLookAt>k__BackingField = value.<Aspect>k__BackingField;
            mem[1152921511724223664] = value.Dutch;
            mem[1152921511724223648] = value.FieldOfView;
        }
        public UnityEngine.Vector3 get_ReferenceUp()
        {
            return new UnityEngine.Vector3() {z = this.<RawPosition>k__BackingField};
        }
        public void set_ReferenceUp(UnityEngine.Vector3 value)
        {
            mem[1152921511724451740] = value.x;
            mem[1152921511724451744] = value.y;
            this.<RawPosition>k__BackingField = value.z;
        }
        public UnityEngine.Vector3 get_ReferenceLookAt()
        {
            return new UnityEngine.Vector3() {z = this.<RawOrientation>k__BackingField};
        }
        public void set_ReferenceLookAt(UnityEngine.Vector3 value)
        {
            mem[1152921511724675752] = value.x;
            mem[1152921511724675756] = value.y;
            this.<RawOrientation>k__BackingField = value.z;
        }
        public bool get_HasLookAt()
        {
            return true;
        }
        public UnityEngine.Vector3 get_RawPosition()
        {
            return new UnityEngine.Vector3();
        }
        public void set_RawPosition(UnityEngine.Vector3 value)
        {
            mem[1152921511725011764] = value.x;
            mem[1152921511725011768] = value.y;
            mem[1152921511725011772] = value.z;
        }
        public UnityEngine.Quaternion get_RawOrientation()
        {
            return new UnityEngine.Quaternion() {x = this.<PositionDampingBypass>k__BackingField, w = this.<ShotQuality>k__BackingField};
        }
        public void set_RawOrientation(UnityEngine.Quaternion value)
        {
            this.<PositionDampingBypass>k__BackingField = value.x;
            mem[1152921511725235780] = value.y;
            mem[1152921511725235784] = value.z;
            this.<ShotQuality>k__BackingField = value.w;
        }
        internal UnityEngine.Vector3 get_PositionDampingBypass()
        {
            return new UnityEngine.Vector3() {x = this.<PositionCorrection>k__BackingField};
        }
        internal void set_PositionDampingBypass(UnityEngine.Vector3 value)
        {
            this.<PositionCorrection>k__BackingField = value;
            mem[1152921511725459796] = value.y;
            mem[1152921511725459800] = value.z;
        }
        public float get_ShotQuality()
        {
            return (float)this.<OrientationCorrection>k__BackingField;
        }
        public void set_ShotQuality(float value)
        {
            this.<OrientationCorrection>k__BackingField = value;
        }
        public UnityEngine.Vector3 get_PositionCorrection()
        {
            return new UnityEngine.Vector3();
        }
        public void set_PositionCorrection(UnityEngine.Vector3 value)
        {
            mem[1152921511725907808] = value.x;
            mem[1152921511725907812] = value.y;
            mem[1152921511725907816] = value.z;
        }
        public UnityEngine.Quaternion get_OrientationCorrection()
        {
            return new UnityEngine.Quaternion() {y = this.mCustom0};
        }
        public void set_OrientationCorrection(UnityEngine.Quaternion value)
        {
            mem[1152921511726131820] = value.x;
            this.mCustom0 = value.y;
            mem[1152921511726131828] = value.z;
            mem[1152921511726131832] = value.w;
        }
        public UnityEngine.Vector3 get_CorrectedPosition()
        {
            return UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = this.<PositionDampingBypass>k__BackingField, y = V9.16B, z = V10.16B, w = this.<ShotQuality>k__BackingField}, rhs:  new UnityEngine.Quaternion() {x = V15.16B, y = this.mCustom0, z = V13.16B, w = V12.16B});
        }
        public UnityEngine.Quaternion get_CorrectedOrientation()
        {
            return UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = V8.16B, y = V9.16B, z = V10.16B}, b:  new UnityEngine.Vector3() {x = V13.16B, y = V12.16B, z = V11.16B});
        }
        public UnityEngine.Vector3 get_FinalPosition()
        {
            float val_4;
            float val_5;
            float val_6;
            float val_7;
            float val_8;
            val_4 = System.Math.Abs(S8);
            val_5 = V0.16B;
            val_6 = V1.16B;
            val_7 = V2.16B;
            val_8 = V3.16B;
            if(val_4 <= 0.0001f)
            {
                    return new UnityEngine.Vector3() {x = val_5, y = val_6, z = val_7};
            }
            
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.forward;
            UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.AngleAxis(angle:  val_4, axis:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = val_5, y = val_6, z = val_7, w = val_8}, rhs:  new UnityEngine.Quaternion() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w});
            val_5 = val_3.x;
            val_6 = val_3.y;
            val_7 = val_3.z;
            val_8 = val_3.w;
            return new UnityEngine.Vector3() {x = val_5, y = val_6, z = val_7};
        }
        public UnityEngine.Quaternion get_FinalOrientation()
        {
        
        }
        public static Cinemachine.CameraState get_Default()
        {
            var val_7;
            var val_8;
            Cinemachine.CameraState val_0;
            val_7 = null;
            val_7 = null;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.up;
            val_8 = null;
            val_8 = null;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.identity;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
            UnityEngine.Quaternion val_5 = UnityEngine.Quaternion.identity;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
            val_0.<ReferenceUp>k__BackingField.x = val_1.x;
            val_0.<ReferenceUp>k__BackingField.y = val_1.y;
            val_0.<ReferenceUp>k__BackingField.z = val_1.z;
            val_0.<Lens>k__BackingField.FarClipPlane = Cinemachine.LensSettings.Default;
            val_0.<ReferenceLookAt>k__BackingField.x = Cinemachine.CameraState.kNoPoint;
            val_0.<ReferenceLookAt>k__BackingField.y = Cinemachine.CameraState.kNoPoint.__il2cppRuntimeField_4;
            val_0.<ReferenceLookAt>k__BackingField.z = Cinemachine.CameraState.kNoPoint.__il2cppRuntimeField_8;
            val_0.<RawPosition>k__BackingField.x = val_2.x;
            val_0.<RawPosition>k__BackingField.y = val_2.y;
            val_0.<RawPosition>k__BackingField.z = val_2.z;
            val_0.<RawOrientation>k__BackingField.x = val_3.x;
            val_0.<RawOrientation>k__BackingField.y = val_3.y;
            val_0.<RawOrientation>k__BackingField.z = val_3.z;
            val_0.<RawOrientation>k__BackingField.w = val_3.w;
            val_0.<PositionDampingBypass>k__BackingField.x = val_6.x;
            val_0.<PositionDampingBypass>k__BackingField.y = val_6.y;
            val_0.<PositionDampingBypass>k__BackingField.z = val_6.z;
            val_0.<PositionCorrection>k__BackingField.x = val_4.x;
            val_0.<PositionCorrection>k__BackingField.y = val_4.y;
            val_0.<PositionCorrection>k__BackingField.z = val_4.z;
            val_0.<OrientationCorrection>k__BackingField.x = val_5.x;
            val_0.<OrientationCorrection>k__BackingField.y = val_5.y;
            val_0.<OrientationCorrection>k__BackingField.z = val_5.z;
            val_0.<OrientationCorrection>k__BackingField.w = val_5.w;
            val_0.<ShotQuality>k__BackingField = 1f;
            val_0.<Lens>k__BackingField.FieldOfView = Cinemachine.LensSettings.Default;
            return val_0;
        }
        public int get_NumCustomBlendables()
        {
            return (int)this;
        }
        private void set_NumCustomBlendables(int value)
        {
            mem[1152921511726964872] = value;
        }
        public Cinemachine.CameraState.CustomBlendable GetCustomBlendable(int index)
        {
            CustomBlendable val_12;
            UnityEngine.Object val_13;
            UnityEngine.Object val_14;
            val_12 = this.mCustom1;
            val_13 = val_12;
            if(0 == val_13)
            {
                    val_14 = 0;
                return new CustomBlendable() {m_Custom = val_14, m_Weight = val_13};
            }
            
            val_12 = this.mCustom2;
            val_13 = val_12;
            if(0 == val_13)
            {
                    val_14 = 1;
                return new CustomBlendable() {m_Custom = val_14, m_Weight = val_13};
            }
            
            val_12 = this.mCustom3;
            val_13 = val_12;
            if(0 == val_13)
            {
                    val_14 = 2;
                return new CustomBlendable() {m_Custom = val_14, m_Weight = val_13};
            }
            
            val_12 = this.m_CustomOverflow;
            val_13 = val_12;
            if(0 == val_13)
            {
                    val_14 = 3;
                return new CustomBlendable() {m_Custom = val_14, m_Weight = val_13};
            }
            
            if(X22 == 0)
            {
                goto label_20;
            }
            
            val_12 = 0;
            goto label_18;
            label_24:
            val_12 = 1;
            label_18:
            val_13 = public System.Int32 System.Collections.Generic.List<CustomBlendable>::get_Count();
            if(val_12 >= X22.Count)
            {
                goto label_20;
            }
            
            CustomBlendable val_10 = X22.Item[1];
            val_13 = val_10.m_Custom;
            if(0 != val_13)
            {
                goto label_24;
            }
            
            val_14 = val_12 + 4;
            return new CustomBlendable() {m_Custom = val_14, m_Weight = val_13};
            label_20:
            val_14 = 0;
            return new CustomBlendable() {m_Custom = val_14, m_Weight = val_13};
        }
        private int FindCustomBlendable(UnityEngine.Object custom)
        {
            var val_8;
            float val_9;
            var val_10;
            val_8 = 1152921511727205056;
            val_9 = X2;
            val_10 = val_8;
            if((val_10 & 2147483648) == 0)
            {
                    val_8 = 1152921511727205056;
                val_9 = val_9 + (-1.288092E-14f);
            }
            else
            {
                    .<NumCustomBlendables>k__BackingField = 1152921511727205057;
            }
            
            if(((val_10 < 4) ? 1152921511727205061 : 0) > 8)
            {
                    return (int)val_8;
            }
            
            var val_8 = 25807916 + (val_10 < 0x4 ? 1152921511727205061 : 0) << 2;
            val_8 = val_8 + 25807916;
            goto (25807916 + (val_10 < 0x4 ? 1152921511727205061 : 0) << 2 + 25807916);
        }
        public void AddCustomBlendable(Cinemachine.CameraState.CustomBlendable b)
        {
        
        }
        public static Cinemachine.CameraState Lerp(Cinemachine.CameraState stateA, Cinemachine.CameraState stateB, float t)
        {
            float val_4;
            var val_51;
            float val_54;
            float val_55;
            float val_56;
            float val_57;
            float val_58;
            float val_62;
            float val_63;
            float val_64;
            float val_68;
            float val_69;
            float val_73;
            var val_74;
            var val_75;
            Cinemachine.CameraState val_0;
            float val_1 = UnityEngine.Mathf.Clamp01(value:  t);
            Cinemachine.LensSettings val_2 = Cinemachine.LensSettings.Lerp(lensA:  new Cinemachine.LensSettings() {<Orthographic>k__BackingField = false}, lensB:  new Cinemachine.LensSettings() {FieldOfView = stateB.<Lens>k__BackingField.FieldOfView, FarClipPlane = stateB.<Lens>k__BackingField.FarClipPlane, <Orthographic>k__BackingField = false}, t:  val_1);
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.Slerp(a:  new UnityEngine.Vector3() {x = stateB.<ReferenceUp>k__BackingField.x, y = stateB.<ReferenceUp>k__BackingField.y, z = stateB.<ReferenceUp>k__BackingField.z}, b:  new UnityEngine.Vector3() {x = X2 + 28, y = X2 + 28 + 4, z = X2 + 36}, t:  val_1);
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = stateB.<RawPosition>k__BackingField.x, y = stateB.<RawPosition>k__BackingField.y, z = stateB.<RawPosition>k__BackingField.z}, b:  new UnityEngine.Vector3() {x = X2 + 52, y = X2 + 52 + 4, z = X2 + 60}, t:  val_1);
            float val_7 = UnityEngine.Mathf.Lerp(a:  stateB.<ShotQuality>k__BackingField, b:  X2 + 92, t:  val_1);
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = stateB.<PositionCorrection>k__BackingField.x, y = stateB.<PositionCorrection>k__BackingField.y, z = stateB.<PositionCorrection>k__BackingField.z}, b:  new UnityEngine.Vector3() {x = X2 + 96, y = X2 + 96 + 4, z = X2 + 104}, t:  val_1);
            val_55 = stateB.<OrientationCorrection>k__BackingField.x;
            val_54 = stateB.<OrientationCorrection>k__BackingField.y;
            val_56 = stateB.<OrientationCorrection>k__BackingField.z;
            val_57 = stateB.<OrientationCorrection>k__BackingField.w;
            val_58 = mem[X2 + 116];
            val_58 = X2 + 116;
            UnityEngine.Quaternion val_9 = UnityEngine.Quaternion.Slerp(a:  new UnityEngine.Quaternion() {x = val_55, y = val_54, z = val_56, w = val_57}, b:  new UnityEngine.Quaternion() {x = X2 + 108, y = X2 + 108 + 4, z = val_58, w = X2 + 116 + 4}, t:  val_1);
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.zero;
            if(((1152921511727569184 & 1) == 0) || (((X2 & 1) & 1) == 0))
            {
                goto label_10;
            }
            
            val_62 = val_1;
            val_63 = val_62;
            if(((val_4.Size & 1) & 1) == 0)
            {
                    val_63 = val_62;
                if((UnityEngine.Mathf.Approximately(a:  stateB.<Lens>k__BackingField.FieldOfView, b:  X2)) != true)
            {
                    val_64 = val_4;
                val_54 = X2;
                UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = stateB.<ReferenceLookAt>k__BackingField.x, y = stateB.<ReferenceLookAt>k__BackingField.y, z = stateB.<ReferenceLookAt>k__BackingField.z}, b:  new UnityEngine.Vector3() {x = val_64, y = val_54, z = val_10.z});
                UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = X2 + 40, y = X2 + 40 + 4, z = X2 + 48}, b:  new UnityEngine.Vector3() {x = UnityEngine.Mathf.Max(a:  val_16.x, b:  stateB.<Lens>k__BackingField.NearClipPlane), y = stateB.<Lens>k__BackingField.NearClipPlane, z = val_16.z});
                float val_19 = UnityEngine.Mathf.Max(a:  val_18.x, b:  X2 + 8);
                val_62 = val_1;
                float val_51 = stateB.<Lens>k__BackingField.FieldOfView;
                val_51 = val_51 - (stateB.<Lens>k__BackingField.FieldOfView);
                val_51 = val_51 / (X2 - (stateB.<Lens>k__BackingField.FieldOfView));
                val_63 = System.Math.Abs(val_51);
            }
            
            }
            
            UnityEngine.Vector3 val_21 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = stateB.<ReferenceLookAt>k__BackingField.x, y = stateB.<ReferenceLookAt>k__BackingField.y, z = stateB.<ReferenceLookAt>k__BackingField.z}, b:  new UnityEngine.Vector3() {x = X2 + 40, y = X2 + 40 + 4, z = X2 + 48}, t:  val_63);
            val_55 = mem[X2 + 64 + 4];
            val_55 = X2 + 64 + 4;
            float val_22 = UnityEngine.Quaternion.Angle(a:  new UnityEngine.Quaternion() {x = stateB.<RawOrientation>k__BackingField.x, y = stateB.<RawOrientation>k__BackingField.y, z = stateB.<RawOrientation>k__BackingField.z, w = stateB.<RawOrientation>k__BackingField.w}, b:  new UnityEngine.Quaternion() {x = X2 + 64, y = val_55, z = X2 + 72, w = X2 + 72 + 4});
            if(val_22 <= 0.0001f)
            {
                goto label_43;
            }
            
            val_58 = val_21.x;
            val_57 = val_21.z;
            val_68 = val_63;
            val_69 = 0.0001f;
            UnityEngine.Vector3 val_23 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_58, y = val_21.y, z = val_57}, b:  new UnityEngine.Vector3() {x = val_22, y = val_69, z = stateB.<RawOrientation>k__BackingField.z});
            val_73 = val_62;
            goto label_43;
            label_10:
            val_74 = null;
            val_74 = null;
            val_73 = val_62;
            val_68 = val_73;
            label_43:
            if((Cinemachine.Utility.UnityVectorExtensions.AlmostZero(v:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z})) == true)
            {
                goto label_33;
            }
            
            val_58 = val_23.x;
            val_57 = val_23.z;
            val_55 = val_5.x;
            val_69 = val_5.y;
            UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_58, y = val_23.y, z = val_57}, b:  new UnityEngine.Vector3() {x = val_55, y = val_69, z = val_5.z});
            if((Cinemachine.Utility.UnityVectorExtensions.AlmostZero(v:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z})) == true)
            {
                goto label_33;
            }
            
            val_58 = val_58;
            val_57 = val_57;
            val_55 = val_5.x;
            val_69 = val_5.y;
            UnityEngine.Vector3 val_28 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_58, y = val_23.y, z = val_57}, b:  new UnityEngine.Vector3() {x = val_55, y = val_69, z = val_5.z});
            if((Cinemachine.Utility.UnityVectorExtensions.AlmostZero(v:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z})) == false)
            {
                goto label_36;
            }
            
            label_33:
            UnityEngine.Quaternion val_30 = Cinemachine.Utility.UnityQuaternionExtensions.SlerpWithReferenceUp(qA:  new UnityEngine.Quaternion() {x = stateB.<RawOrientation>k__BackingField.x, y = stateB.<RawOrientation>k__BackingField.y, z = stateB.<RawOrientation>k__BackingField.z, w = stateB.<RawOrientation>k__BackingField.w}, qB:  new UnityEngine.Quaternion() {x = X2 + 64, y = X2 + 68, z = X2 + 72, w = X2 + 76}, t:  val_73, up:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.z});
            label_50:
            if((stateB.<NumCustomBlendables>k__BackingField) >= 1)
            {
                    val_55 = 0.0001f;
                var val_53 = 0;
                do
            {
                float val_52 = 0f;
                val_52 = (1f - val_73) * val_52;
                if(val_52 > val_55)
            {
                    float val_32 = val_52 | 0;
            }
            
                val_53 = val_53 + 1;
            }
            while(val_53 < (stateB.<NumCustomBlendables>k__BackingField));
            
            }
            
            val_75 = mem[X2 + 200];
            val_75 = X2 + 200;
            if(val_75 < 1)
            {
                    return val_0;
            }
            
            val_55 = 0.0001f;
            do
            {
                float val_54 = 0f;
                val_54 = val_73 * val_54;
                if(val_54 > val_55)
            {
                    float val_33 = val_54 | 0;
            }
            
                val_75 = mem[X2 + 200];
                val_75 = X2 + 200;
                val_51 = 0 + 1;
            }
            while(val_51 < val_75);
            
            return val_0;
            label_36:
            UnityEngine.Quaternion val_34 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = val_58, y = val_23.y, z = val_57}, upwards:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            UnityEngine.Vector3 val_35 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = stateB.<ReferenceLookAt>k__BackingField.x, y = stateB.<ReferenceLookAt>k__BackingField.y, z = stateB.<ReferenceLookAt>k__BackingField.z}, b:  new UnityEngine.Vector3() {x = stateB.<RawOrientation>k__BackingField.w, y = val_34.y, z = val_34.z});
            UnityEngine.Vector2 val_36 = Cinemachine.Utility.UnityQuaternionExtensions.GetCameraRotationToTarget(orient:  new UnityEngine.Quaternion() {x = stateB.<RawOrientation>k__BackingField.x, y = stateB.<RawOrientation>k__BackingField.y, z = stateB.<RawOrientation>k__BackingField.z, w = stateB.<RawOrientation>k__BackingField.w}, lookAtDir:  new UnityEngine.Vector3() {x = val_35.x, y = val_35.y, z = val_35.z}, worldUp:  new UnityEngine.Vector3() {x = stateB.<ReferenceUp>k__BackingField.x, y = stateB.<ReferenceUp>k__BackingField.z, z = val_5.z});
            UnityEngine.Vector2 val_37 = UnityEngine.Vector2.op_UnaryNegation(a:  new UnityEngine.Vector2() {x = val_36.x, y = val_36.y});
            UnityEngine.Vector3 val_38 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = X2 + 40, y = X2 + 40 + 4, z = X2 + 48}, b:  new UnityEngine.Vector3() {x = val_37.x, y = val_37.y, z = stateB.<RawOrientation>k__BackingField.z});
            UnityEngine.Vector2 val_39 = Cinemachine.Utility.UnityQuaternionExtensions.GetCameraRotationToTarget(orient:  new UnityEngine.Quaternion() {x = X2 + 64, y = X2 + 64 + 4, z = X2 + 72, w = X2 + 72 + 4}, lookAtDir:  new UnityEngine.Vector3() {x = val_38.x, y = val_38.y, z = val_38.z}, worldUp:  new UnityEngine.Vector3() {x = X2 + 28, y = X2 + 36, z = val_5.z});
            UnityEngine.Vector2 val_40 = UnityEngine.Vector2.op_UnaryNegation(a:  new UnityEngine.Vector2() {x = val_39.x, y = val_39.y});
            UnityEngine.Vector2 val_41 = UnityEngine.Vector2.Lerp(a:  new UnityEngine.Vector2() {x = val_37.x, y = val_37.y}, b:  new UnityEngine.Vector2() {x = val_40.x, y = val_40.y}, t:  val_68);
            UnityEngine.Quaternion val_42 = Cinemachine.Utility.UnityQuaternionExtensions.ApplyCameraRotation(orient:  new UnityEngine.Quaternion() {x = val_34.x, y = val_34.y, z = val_34.z, w = val_34.w}, rot:  new UnityEngine.Vector2() {x = val_41.x, y = val_41.y}, worldUp:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.z, z = val_5.z});
            goto label_50;
        }
        private float InterpolateFOV(float fovA, float fovB, float dA, float dB, float t)
        {
        
        }
        private static CameraState()
        {
            Cinemachine.CameraState.kNoPoint = 0;
            Cinemachine.CameraState.kNoPoint.__il2cppRuntimeField_8 = 0;
        }
    
    }

}
