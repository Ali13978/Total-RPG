using UnityEngine;

namespace Cinemachine
{
    public sealed class CinemachineCore
    {
        // Fields
        public static readonly int kStreamingVersion;
        public static readonly string kVersionString;
        private static Cinemachine.CinemachineCore sInstance;
        public static bool sShowHiddenObjects;
        public static Cinemachine.CinemachineCore.AxisInputDelegate GetInputAxis;
        private System.Collections.Generic.List<Cinemachine.CinemachineBrain> mActiveBrains;
        private System.Collections.Generic.List<Cinemachine.ICinemachineCamera> mActiveCameras;
        private System.Collections.Generic.List<System.Collections.Generic.List<Cinemachine.ICinemachineCamera>> mChildCameras;
        private System.Collections.Generic.Dictionary<Cinemachine.ICinemachineCamera, Cinemachine.CinemachineCore.UpdateStatus> mUpdateStatus;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private Cinemachine.CinemachineCore.UpdateFilter <CurrentUpdateFilter>k__BackingField;
        private static Cinemachine.CinemachineCore.AxisInputDelegate <>f__mg$cache0;
        
        // Properties
        public static Cinemachine.CinemachineCore Instance { get; }
        public int BrainCount { get; }
        public int VirtualCameraCount { get; }
        internal Cinemachine.CinemachineCore.UpdateFilter CurrentUpdateFilter { get; set; }
        
        // Methods
        public CinemachineCore()
        {
            this.mActiveBrains = new System.Collections.Generic.List<Cinemachine.CinemachineBrain>();
            this.mActiveCameras = new System.Collections.Generic.List<Cinemachine.ICinemachineCamera>();
            this.mChildCameras = new System.Collections.Generic.List<System.Collections.Generic.List<Cinemachine.ICinemachineCamera>>();
        }
        public static Cinemachine.CinemachineCore get_Instance()
        {
            Cinemachine.CinemachineCore val_2;
            Cinemachine.CinemachineCore val_3;
            var val_4;
            val_3 = null;
            val_3 = null;
            if(Cinemachine.CinemachineCore.sInstance == null)
            {
                    val_2 = val_3;
                val_3 = new Cinemachine.CinemachineCore();
                val_4 = null;
                val_4 = null;
                Cinemachine.CinemachineCore.sInstance = val_2;
                val_3 = null;
            }
            
            val_3 = null;
            return (Cinemachine.CinemachineCore)Cinemachine.CinemachineCore.sInstance;
        }
        public int get_BrainCount()
        {
            if(this.mActiveBrains != null)
            {
                    return this.mActiveBrains.Count;
            }
            
            return this.mActiveBrains.Count;
        }
        public Cinemachine.CinemachineBrain GetActiveBrain(int index)
        {
            if(this.mActiveBrains != null)
            {
                    return this.mActiveBrains.Item[index];
            }
            
            return this.mActiveBrains.Item[index];
        }
        internal void AddActiveBrain(Cinemachine.CinemachineBrain brain)
        {
            this.RemoveActiveBrain(brain:  brain);
            this.mActiveBrains.Insert(index:  0, item:  brain);
        }
        internal void RemoveActiveBrain(Cinemachine.CinemachineBrain brain)
        {
            bool val_1 = this.mActiveBrains.Remove(item:  brain);
        }
        public int get_VirtualCameraCount()
        {
            if(this.mActiveCameras != null)
            {
                    return this.mActiveCameras.Count;
            }
            
            return this.mActiveCameras.Count;
        }
        public Cinemachine.ICinemachineCamera GetVirtualCamera(int index)
        {
            if(this.mActiveCameras != null)
            {
                    return this.mActiveCameras.Item[index];
            }
            
            return this.mActiveCameras.Item[index];
        }
        internal void AddActiveCamera(Cinemachine.ICinemachineCamera vcam)
        {
            var val_5;
            var val_6;
            var val_7;
            this.RemoveActiveCamera(vcam:  vcam);
            val_5 = 0;
            goto label_1;
            label_15:
            val_5 = 1;
            label_1:
            if(val_5 >= this.mActiveCameras.Count)
            {
                goto label_3;
            }
            
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_6 = vcam;
            Cinemachine.ICinemachineCamera val_3 = this.mActiveCameras.Item[1];
            var val_6 = 0;
            val_6 = val_6 + 1;
            val_7 = val_3;
            if(vcam < val_3)
            {
                goto label_15;
            }
            
            label_3:
            this.mActiveCameras.Insert(index:  1, item:  vcam);
        }
        internal void RemoveActiveCamera(Cinemachine.ICinemachineCamera vcam)
        {
            bool val_1 = this.mActiveCameras.Remove(item:  vcam);
        }
        internal void AddChildCamera(Cinemachine.ICinemachineCamera vcam)
        {
            var val_5;
            var val_6;
            this.RemoveChildCamera(vcam:  vcam);
            val_5 = 0;
            if(vcam == null)
            {
                goto label_7;
            }
            
            do
            {
                val_5 = val_5 + 1;
                var val_6 = 0;
                val_6 = val_6 + 1;
                val_6 = vcam;
            }
            while(vcam != null);
            
            goto label_7;
            label_11:
            vcam.Add(item:  1152921504932032512);
            label_7:
            if(this.mChildCameras.Count >= val_5)
            {
                goto label_9;
            }
            
            System.Collections.Generic.List<Cinemachine.ICinemachineCamera> val_3 = new System.Collections.Generic.List<Cinemachine.ICinemachineCamera>();
            if(this.mChildCameras != null)
            {
                goto label_11;
            }
            
            goto label_11;
            label_9:
            this.mChildCameras.Item[val_5 - 1].Add(item:  vcam);
        }
        internal void RemoveChildCamera(Cinemachine.ICinemachineCamera vcam)
        {
            goto label_1;
            label_6:
            bool val_1 = X22.Remove(item:  vcam);
            0 = 1;
            label_1:
            if(0 >= this.mChildCameras.Count)
            {
                    return;
            }
            
            if(this.mChildCameras.Item[1] != null)
            {
                goto label_6;
            }
            
            goto label_6;
        }
        internal void UpdateAllActiveVirtualCameras(UnityEngine.Vector3 worldUp, float deltaTime)
        {
            var val_10;
            System.Collections.Generic.List<System.Collections.Generic.List<Cinemachine.ICinemachineCamera>> val_10 = this.mChildCameras;
            val_10 = val_10.Count - 1;
            if((val_10 & 2147483648) == 0)
            {
                    do
            {
                val_10 = this.mChildCameras.Item[val_10].Count;
                if(val_10 >= 1)
            {
                    var val_11 = 0;
                do
            {
                bool val_6 = this.UpdateVirtualCamera(vcam:  this.mChildCameras.Item[val_10].Item[0], worldUp:  new UnityEngine.Vector3() {x = worldUp.x, y = worldUp.y, z = worldUp.z}, deltaTime:  deltaTime);
                val_11 = val_11 + 1;
            }
            while(val_10 != val_11);
            
            }
            
                val_10 = val_10 - 1;
            }
            while((val_10 & 2147483648) == 0);
            
            }
            
            int val_7 = this.VirtualCameraCount;
            if(val_7 < 1)
            {
                    return;
            }
            
            do
            {
                bool val_9 = this.UpdateVirtualCamera(vcam:  this.GetVirtualCamera(index:  0), worldUp:  new UnityEngine.Vector3() {x = worldUp.x, y = worldUp.y, z = worldUp.z}, deltaTime:  deltaTime);
                val_10 = 0 + 1;
            }
            while(val_7 != val_10);
        
        }
        internal bool UpdateVirtualCamera(Cinemachine.ICinemachineCamera vcam, UnityEngine.Vector3 worldUp, float deltaTime)
        {
            int val_15;
            var val_20;
            var val_21;
            var val_22;
            System.Collections.Generic.Dictionary<Cinemachine.ICinemachineCamera, UpdateStatus> val_23;
            var val_24;
            var val_25;
            var val_3 = ((this.<CurrentUpdateFilter>k__BackingField) == 1) ? 0 : (((this.<CurrentUpdateFilter>k__BackingField) != 3) ? 1 : 0);
            var val_4 = ((this.<CurrentUpdateFilter>k__BackingField) == 2) ? 1 : 0;
            val_21 = this.<CurrentUpdateFilter>k__BackingField;
            if(val_3 == 0)
            {
                    var val_5 = ((this.<CurrentUpdateFilter>k__BackingField) == 1) ? 0 : this.<CurrentUpdateFilter>k__BackingField;
            }
            
            if(this.mUpdateStatus == null)
            {
                    this.mUpdateStatus = new System.Collections.Generic.Dictionary<Cinemachine.ICinemachineCamera, UpdateStatus>();
            }
            
            var val_19 = 0;
            val_19 = val_19 + 1;
            val_22 = vcam;
            val_23 = this.mUpdateStatus;
            if(0 == vcam)
            {
                    if((val_23.ContainsKey(key:  vcam)) != false)
            {
                    bool val_11 = this.mUpdateStatus.Remove(key:  vcam);
            }
            
                val_24 = 0;
                return (bool)val_24;
            }
            
            if((val_23.TryGetValue(key:  vcam, value: out  new UpdateStatus() {targetPos = new UnityEngine.Matrix4x4()})) != true)
            {
                    this.mUpdateStatus.Add(key:  vcam, value:  new UpdateStatus() {targetPos = new UnityEngine.Matrix4x4()});
            }
            
            if((this.<CurrentUpdateFilter>k__BackingField) == 2)
            {
                    val_23 = 1;
            }
            else
            {
                    val_23 = Cinemachine.CinemachineBrain.GetSubframeCount();
            }
            
            if(val_3 == 0)
            {
                goto label_22;
            }
            
            if((Cinemachine.CinemachineCore.GetTargetPosition(vcam:  null, targetPos: out  new UnityEngine.Matrix4x4() {m00 = vcam, m10 = vcam, m20 = vcam, m30 = vcam, m01 = vcam, m11 = vcam, m21 = vcam, m31 = vcam, m02 = vcam, m12 = vcam, m22 = vcam, m32 = vcam, m03 = vcam, m13 = vcam, m23 = vcam, m33 = vcam})) == false)
            {
                goto label_25;
            }
            
            if((-1462915936) != ((val_5 == 3) ? 2 : (val_5)))
            {
                goto label_28;
            }
            
            goto label_27;
            label_22:
            val_20 = (val_3 == 0) ? 1 : 0;
            label_25:
            if(val_20 == 0)
            {
                goto label_28;
            }
            
            label_27:
            val_25 = 0;
            goto label_29;
            label_36:
            val_25 = 1;
            label_29:
            if(val_25 >= val_23)
            {
                goto label_30;
            }
            
            var val_20 = 0;
            val_20 = val_20 + 1;
            goto label_36;
            label_30:
            val_15 = UnityEngine.Time.frameCount;
            label_28:
            this.mUpdateStatus.set_Item(key:  vcam, value:  new UpdateStatus() {targetPos = new UnityEngine.Matrix4x4()});
            val_24 = 1;
            return (bool)val_24;
        }
        internal Cinemachine.CinemachineCore.UpdateFilter get_CurrentUpdateFilter()
        {
            return (UpdateFilter)this.<CurrentUpdateFilter>k__BackingField;
        }
        internal void set_CurrentUpdateFilter(Cinemachine.CinemachineCore.UpdateFilter value)
        {
            this.<CurrentUpdateFilter>k__BackingField = value;
        }
        private static bool GetTargetPosition(Cinemachine.ICinemachineCamera vcam, out UnityEngine.Matrix4x4 targetPos)
        {
            var val_3;
            var val_4;
            var val_5;
            var val_6;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            float val_25;
            var val_26;
            var val_27;
            var val_28;
            var val_29;
            var val_30;
            float val_16 = targetPos.m00;
            if((targetPos.m00 + 258) == 0)
            {
                goto label_2;
            }
            
            var val_13 = targetPos.m00 + 152;
            var val_14 = 0;
            val_13 = val_13 + 8;
            label_4:
            if(((targetPos.m00 + 152 + 8) + -8) == null)
            {
                goto label_3;
            }
            
            val_14 = val_14 + 1;
            val_13 = val_13 + 16;
            if(val_14 < (targetPos.m00 + 258))
            {
                goto label_4;
            }
            
            label_2:
            val_20 = 1152921511734323872;
            goto label_5;
            label_3:
            var val_15 = val_13;
            val_15 = val_15 + 10;
            val_16 = val_16 + val_15;
            val_20 = val_16 + 272;
            label_5:
            if(targetPos.m00 == 0)
            {
                goto label_6;
            }
            
            float val_20 = targetPos.m00;
            if((targetPos.m00 + 258) == 0)
            {
                goto label_7;
            }
            
            var val_17 = targetPos.m00 + 152;
            var val_18 = 0;
            val_17 = val_17 + 8;
            label_9:
            if(((targetPos.m00 + 152 + 8) + -8) == null)
            {
                goto label_8;
            }
            
            val_18 = val_18 + 1;
            val_17 = val_17 + 16;
            if(val_18 < (targetPos.m00 + 258))
            {
                goto label_9;
            }
            
            label_7:
            val_21 = 1152921511734323872;
            goto label_10;
            label_8:
            var val_19 = val_17;
            val_19 = val_19 + 9;
            val_20 = val_20 + val_19;
            val_21 = val_20 + 272;
            label_10:
            if(0 != targetPos.m00)
            {
                goto label_13;
            }
            
            label_6:
            UnityEngine.Matrix4x4 val_2 = UnityEngine.Matrix4x4.identity;
            val_22 = 0;
            mem2[0] = val_3;
            mem2[0] = val_4;
            mem2[0] = val_5;
            mem2[0] = val_6;
            return (bool)val_22;
            label_13:
            float val_24 = targetPos.m00;
            if((targetPos.m00 + 258) == 0)
            {
                goto label_17;
            }
            
            var val_21 = targetPos.m00 + 152;
            var val_22 = 0;
            val_21 = val_21 + 8;
            label_19:
            if(((targetPos.m00 + 152 + 8) + -8) == null)
            {
                goto label_18;
            }
            
            val_22 = val_22 + 1;
            val_21 = val_21 + 16;
            if(val_22 < (targetPos.m00 + 258))
            {
                goto label_19;
            }
            
            label_17:
            val_23 = 1152921511734323872;
            goto label_20;
            label_18:
            var val_23 = val_21;
            val_23 = val_23 + 9;
            val_24 = val_24 + val_23;
            val_23 = val_24 + 272;
            label_20:
            UnityEngine.Matrix4x4 val_8 = targetPos.m00.transform.localToWorldMatrix;
            mem2[0] = val_3;
            mem2[0] = val_4;
            mem2[0] = val_5;
            mem2[0] = val_6;
            float val_28 = targetPos.m00;
            if((targetPos.m00 + 258) == 0)
            {
                goto label_23;
            }
            
            var val_25 = targetPos.m00 + 152;
            var val_26 = 0;
            val_25 = val_25 + 8;
            label_25:
            if(((targetPos.m00 + 152 + 8) + -8) == null)
            {
                goto label_24;
            }
            
            val_26 = val_26 + 1;
            val_25 = val_25 + 16;
            if(val_26 < (targetPos.m00 + 258))
            {
                goto label_25;
            }
            
            label_23:
            val_24 = 1152921511734323872;
            goto label_26;
            label_24:
            var val_27 = val_25;
            val_27 = val_27 + 4;
            val_28 = val_28 + val_27;
            val_24 = val_28 + 272;
            label_26:
            val_25 = targetPos.m00;
            if(0 == targetPos.m00)
            {
                goto label_29;
            }
            
            if((targetPos.m00 + 258) == 0)
            {
                goto label_33;
            }
            
            var val_29 = targetPos.m00 + 152;
            var val_30 = 0;
            val_29 = val_29 + 8;
            label_32:
            if(((targetPos.m00 + 152 + 8) + -8) == null)
            {
                goto label_31;
            }
            
            val_30 = val_30 + 1;
            val_29 = val_29 + 16;
            if(val_30 < (targetPos.m00 + 258))
            {
                goto label_32;
            }
            
            goto label_33;
            label_29:
            if((targetPos.m00 + 258) == 0)
            {
                goto label_34;
            }
            
            var val_31 = targetPos.m00 + 152;
            var val_32 = 0;
            val_31 = val_31 + 8;
            label_36:
            if(((targetPos.m00 + 152 + 8) + -8) == null)
            {
                goto label_35;
            }
            
            val_32 = val_32 + 1;
            val_31 = val_31 + 16;
            if(val_32 < (targetPos.m00 + 258))
            {
                goto label_36;
            }
            
            label_34:
            val_26 = 1152921511734323872;
            goto label_37;
            label_31:
            val_27 = val_29 + 4;
            goto label_38;
            label_35:
            var val_33 = val_31;
            val_33 = val_33 + 6;
            val_25 = val_25 + val_33;
            val_26 = val_25 + 272;
            label_37:
            if(0 == targetPos.m00)
            {
                goto label_41;
            }
            
            val_25 = targetPos.m00;
            if((targetPos.m00 + 258) == 0)
            {
                goto label_42;
            }
            
            var val_34 = targetPos.m00 + 152;
            var val_35 = 0;
            val_34 = val_34 + 8;
            label_44:
            if(((targetPos.m00 + 152 + 8) + -8) == null)
            {
                goto label_43;
            }
            
            val_35 = val_35 + 1;
            val_34 = val_34 + 16;
            if(val_35 < (targetPos.m00 + 258))
            {
                goto label_44;
            }
            
            label_42:
            label_33:
            val_28 = 1152921511734323872;
            goto label_45;
            label_41:
            float val_39 = targetPos.m00;
            if((targetPos.m00 + 258) == 0)
            {
                goto label_47;
            }
            
            var val_36 = targetPos.m00 + 152;
            var val_37 = 0;
            val_36 = val_36 + 8;
            label_49:
            if(((targetPos.m00 + 152 + 8) + -8) == null)
            {
                goto label_48;
            }
            
            val_37 = val_37 + 1;
            val_36 = val_36 + 16;
            if(val_37 < (targetPos.m00 + 258))
            {
                goto label_49;
            }
            
            label_47:
            val_29 = 1152921511734323872;
            goto label_50;
            label_43:
            val_27 = val_34 + 6;
            label_38:
            val_25 = val_25 + val_27;
            val_28 = val_25 + 272;
            label_45:
            val_30 = 1152921511734323872;
            goto label_51;
            label_48:
            var val_38 = val_36;
            val_38 = val_38 + 9;
            val_39 = val_39 + val_38;
            val_29 = val_39 + 272;
            label_50:
            label_51:
            UnityEngine.Matrix4x4 val_12 = targetPos.m00.transform.localToWorldMatrix;
            val_22 = 1;
            mem2[0] = val_3;
            mem2[0] = val_4;
            mem2[0] = val_5;
            mem2[0] = val_6;
            return (bool)val_22;
        }
        public Cinemachine.CinemachineCore.UpdateFilter GetVcamUpdateStatus(Cinemachine.ICinemachineCamera vcam)
        {
            var val_2;
            var val_3;
            if(this.mUpdateStatus != null)
            {
                    if((this.mUpdateStatus.TryGetValue(key:  vcam, value: out  new UpdateStatus() {targetPos = new UnityEngine.Matrix4x4()})) != false)
            {
                    val_3 = val_2;
                return (UpdateFilter)val_3;
            }
            
            }
            
            val_3 = 2;
            return (UpdateFilter)val_3;
        }
        public bool IsLive(Cinemachine.ICinemachineCamera vcam)
        {
            var val_7;
            var val_8;
            if(vcam != null)
            {
                    val_8 = 0;
                if(this.BrainCount < 1)
            {
                    return (bool)val_8;
            }
            
                val_7 = 0;
                do
            {
                Cinemachine.CinemachineBrain val_2 = this.GetActiveBrain(index:  0);
                if(0 != val_2)
            {
                    if((val_2.IsLive(vcam:  vcam)) == true)
            {
                goto label_7;
            }
            
            }
            
                val_7 = val_7 + 1;
            }
            while(val_7 < this.BrainCount);
            
            }
            
            val_8 = 0;
            return (bool)val_8;
            label_7:
            val_8 = 1;
            return (bool)val_8;
        }
        public void GenerateCameraActivationEvent(Cinemachine.ICinemachineCamera vcam)
        {
            var val_6;
            if(vcam == null)
            {
                    return;
            }
            
            if(this.BrainCount < 1)
            {
                    return;
            }
            
            do
            {
                Cinemachine.CinemachineBrain val_2 = this.GetActiveBrain(index:  0);
                if(0 != val_2)
            {
                    if((val_2.IsLive(vcam:  vcam)) != false)
            {
                    val_2.m_CameraActivatedEvent.Invoke(arg0:  vcam);
            }
            
            }
            
                val_6 = 0 + 1;
            }
            while(val_6 < this.BrainCount);
        
        }
        public void GenerateCameraCutEvent(Cinemachine.ICinemachineCamera vcam)
        {
            var val_6;
            if(vcam == null)
            {
                    return;
            }
            
            if(this.BrainCount < 1)
            {
                    return;
            }
            
            do
            {
                Cinemachine.CinemachineBrain val_2 = this.GetActiveBrain(index:  0);
                if(0 != val_2)
            {
                    if((val_2.IsLive(vcam:  vcam)) != false)
            {
                    val_2.m_CameraCutEvent.Invoke(arg0:  val_2);
            }
            
            }
            
                val_6 = 0 + 1;
            }
            while(val_6 < this.BrainCount);
        
        }
        public Cinemachine.CinemachineBrain FindPotentialTargetBrain(Cinemachine.ICinemachineCamera vcam)
        {
            UnityEngine.Object val_13;
            UnityEngine.Object val_14;
            int val_1 = this.BrainCount;
            if((val_1 > 1) && (vcam != null))
            {
                    val_13 = 0;
                do
            {
                val_14 = this.GetActiveBrain(index:  0);
                if(0 != val_14)
            {
                    if(0 != val_14.OutputCamera)
            {
                    if((val_14.IsLive(vcam:  vcam)) == true)
            {
                    return (Cinemachine.CinemachineBrain)val_14;
            }
            
            }
            
            }
            
                val_13 = val_13 + 1;
            }
            while(val_13 < val_1);
            
            }
            
            if(val_1 >= 1)
            {
                    var val_13 = 0;
                do
            {
                val_14 = this.GetActiveBrain(index:  0);
                if(0 != val_14)
            {
                    val_13 = val_14.OutputCamera;
                if(0 != val_13)
            {
                    return (Cinemachine.CinemachineBrain)val_14;
            }
            
            }
            
                val_13 = val_13 + 1;
            }
            while(val_13 < val_1);
            
            }
            
            val_14 = 0;
            return (Cinemachine.CinemachineBrain)val_14;
        }
        private static CinemachineCore()
        {
            Cinemachine.CinemachineCore.kStreamingVersion = 20170927;
            Cinemachine.CinemachineCore.kVersionString = "2.1";
            Cinemachine.CinemachineCore.sInstance = 0;
            Cinemachine.CinemachineCore.sShowHiddenObjects = false;
            if((Cinemachine.CinemachineCore.<>f__mg$cache0) == null)
            {
                    typeof(CinemachineCore.AxisInputDelegate).__il2cppRuntimeField_20 = 0;
                typeof(CinemachineCore.AxisInputDelegate).__il2cppRuntimeField_28 = public static System.Single UnityEngine.Input::GetAxis(string axisName);
                typeof(CinemachineCore.AxisInputDelegate).__il2cppRuntimeField_10 = public static System.Single UnityEngine.Input::GetAxis(string axisName);
                Cinemachine.CinemachineCore.<>f__mg$cache0 = null;
            }
            
            Cinemachine.CinemachineCore.GetInputAxis = Cinemachine.CinemachineCore.<>f__mg$cache0;
        }
    
    }

}
