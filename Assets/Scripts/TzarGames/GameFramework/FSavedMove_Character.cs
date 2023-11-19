using UnityEngine;

namespace TzarGames.GameFramework
{
    public class FSavedMove_Character
    {
        // Fields
        public uint bPressedJump;
        public uint bWantsToCrouch;
        public uint bForceMaxAccel;
        public bool bOldTimeStampBeforeReset;
        public float TimeStamp;
        public float DeltaTime;
        public float CustomTimeDilation;
        public UnityEngine.Vector3 StartLocation;
        public UnityEngine.Vector3 StartRelativeLocation;
        public UnityEngine.Vector3 Startvelocity;
        public TzarGames.GameFramework.FFindFloorResult StartFloor;
        public TzarGames.GameFramework.FRotator StartRotation;
        public TzarGames.GameFramework.FRotator StartControlRotation;
        public UnityEngine.Vector3 SavedLocation;
        public TzarGames.GameFramework.FRotator SavedRotation;
        public UnityEngine.Vector3 Savedvelocity;
        public UnityEngine.Vector3 SavedRelativeLocation;
        public UnityEngine.Vector3 Acceleration;
        public TzarGames.GameFramework.FRotator ControlRotation;
        public UnityEngine.Vector3 AccelNormal;
        public float AccelMag;
        public TzarGames.GameFramework.UPrimitiveComponent StartBase;
        public TzarGames.GameFramework.UPrimitiveComponent EndBase;
        public TzarGames.GameFramework.UAnimMontage RootMotionMontage;
        public float RootMotionTrackPosition;
        public TzarGames.GameFramework.FRootMotionMovementParams RootMotionMovement;
        public float AccelDotThreshold;
        public float AccelMagThreshold;
        private static uint s_savedMoveCount;
        
        // Methods
        public FSavedMove_Character()
        {
            var val_1;
            this.bPressedJump = 4294967297;
            this.bWantsToCrouch = 1;
            this.bForceMaxAccel = 1;
            this.AccelDotThreshold = 0.9f;
            this.AccelMagThreshold = 7.714148E-41f;
            val_1 = null;
            val_1 = null;
            uint val_1 = TzarGames.GameFramework.FSavedMove_Character.s_savedMoveCount;
            val_1 = val_1 + 1;
            TzarGames.GameFramework.FSavedMove_Character.s_savedMoveCount = val_1;
        }
        public void Dispose()
        {
            null = null;
            uint val_1 = TzarGames.GameFramework.FSavedMove_Character.s_savedMoveCount;
            val_1 = val_1 - 1;
            TzarGames.GameFramework.FSavedMove_Character.s_savedMoveCount = val_1;
        }
        public void Clear()
        {
            this.CustomTimeDilation = 1f;
            this.TimeStamp = 0f;
            this.DeltaTime = 0f;
            mem[1152921511288509157] = 0;
            this.bPressedJump = 0;
            this.bWantsToCrouch = 0;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            this.StartLocation = val_1;
            mem[1152921511288509184] = val_1.y;
            mem[1152921511288509188] = val_1.z;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            this.StartRelativeLocation = val_2;
            mem[1152921511288509196] = val_2.y;
            mem[1152921511288509200] = val_2.z;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            this.Startvelocity = val_3;
            mem[1152921511288509208] = val_3.y;
            mem[1152921511288509212] = val_3.z;
            this.StartFloor = new System.Object();
            mem[1152921511288509240] = 0;
            this.StartRotation = 0;
            mem[1152921511288509264] = 0;
            this.StartControlRotation = 0;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
            this.SavedLocation = val_5;
            mem[1152921511288509276] = val_5.y;
            mem[1152921511288509280] = val_5.z;
            mem[1152921511288509304] = 0;
            this.SavedRotation = 0;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
            this.SavedRelativeLocation = val_6;
            mem[1152921511288509328] = val_6.y;
            mem[1152921511288509332] = val_6.z;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.zero;
            this.Acceleration = val_7;
            mem[1152921511288509340] = val_7.y;
            mem[1152921511288509344] = val_7.z;
            mem[1152921511288509368] = 0;
            this.RootMotionTrackPosition = 0f;
            this.EndBase = 0;
            this.RootMotionMontage = 0;
            this.ControlRotation = 0;
            this.StartBase = 0;
            if(this.RootMotionMovement != null)
            {
                    return;
            }
        
        }
        public virtual void SetMoveFor(TzarGames.GameFramework.CharacterMovementU c, float InDeltaTime, UnityEngine.Vector3 NewAccel, TzarGames.GameFramework.FNetworkPredictionData_Client_Character ClientData)
        {
            var val_8;
            float val_9;
            float val_10;
            float val_11;
            this.DeltaTime = InDeltaTime;
            this.AccelMag = InDeltaTime;
            var val_1 = (InDeltaTime > (1E-08f)) ? 0 : (this);
            if(InDeltaTime > (1E-08f))
            {
                    UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = NewAccel.x, y = NewAccel.y, z = NewAccel.z}, d:  InDeltaTime);
                val_9 = val_2.x;
                val_10 = val_2.y;
                val_11 = val_2.z;
                val_8 = this;
            }
            else
            {
                    UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
                val_9 = val_3.x;
                val_10 = val_3.y;
                val_11 = val_3.z;
            }
            
            mem2[0] = val_9;
            mem2[0] = val_10;
            mem2[0] = val_11;
            this.Acceleration = NewAccel;
            mem[1152921511288633628] = NewAccel.y;
            mem[1152921511288633632] = NewAccel.z;
            if(c != null)
            {
                    this.bPressedJump = c.IsJumpPressed();
                this.bWantsToCrouch = c.bWantsToCrouch;
            }
            else
            {
                    this.bPressedJump = c.IsJumpPressed();
                this.bWantsToCrouch = 65536;
            }
            
            this.bForceMaxAccel = c.bForceMaxAccel;
            this.TimeStamp = ClientData.CurrentTimeStamp;
        }
        public virtual void SetInitialPosition(TzarGames.GameFramework.CharacterMovementU Character)
        {
            var val_4;
            TzarGames.GameFramework.FRotator val_5;
            var val_11;
            TzarGames.GameFramework.FRotator val_12;
            TzarGames.GameFramework.UPrimitiveComponent val_16;
            UnityEngine.Vector3 val_2 = Character.CachedTransform.position;
            this.StartLocation = val_2;
            mem[1152921511288790432] = val_2.y;
            mem[1152921511288790436] = val_2.z;
            TzarGames.GameFramework.FRotator val_3 = Character.Rotator;
            mem[1152921511288790488] = val_4;
            this.StartRotation = val_5;
            if(Character != null)
            {
                    UnityEngine.Vector3 val_6 = Character.Velocity;
                this.Startvelocity = val_6;
                mem[1152921511288790456] = val_6.y;
                mem[1152921511288790460] = val_6.z;
                val_16 = Character.GetMovementBase();
                this.StartBase = val_16;
                this.StartFloor = Character.CurrentFloor;
                this.CustomTimeDilation = Character.CustomTimeDilation;
            }
            else
            {
                    UnityEngine.Vector3 val_8 = 0.Velocity;
                this.Startvelocity = val_8;
                mem[1152921511288790456] = val_8.y;
                mem[1152921511288790460] = val_8.z;
                val_16 = 0.GetMovementBase();
                this.StartBase = val_16;
                this.StartFloor = 33348528;
                this.CustomTimeDilation = 2.802597E-45f;
            }
            
            TzarGames.GameFramework.FRotator val_10 = Character.Rotator;
            mem[1152921511288790512] = val_11;
            this.StartControlRotation = val_12;
            if((TzarGames.GameFramework.MovementBaseUtility.IsDynamicBase(MovementBase:  Character)) == false)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_14 = val_16.GetComponentLocation();
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.StartLocation, y = V9.16B, z = V10.16B}, b:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
            this.StartRelativeLocation = val_15;
            mem[1152921511288790444] = val_15.y;
            mem[1152921511288790448] = val_15.z;
        }
        public virtual void PostUpdate(TzarGames.GameFramework.CharacterMovementU Character)
        {
            var val_4;
            TzarGames.GameFramework.FRotator val_5;
            UnityEngine.Vector3 val_2 = Character.CachedTransform.position;
            this.SavedLocation = val_2;
            mem[1152921511288967868] = val_2.y;
            mem[1152921511288967872] = val_2.z;
            TzarGames.GameFramework.FRotator val_3 = Character.Rotator;
            mem[1152921511288967896] = val_4;
            this.SavedRotation = val_5;
            TzarGames.GameFramework.UPrimitiveComponent val_6 = Character.GetMovementBase();
            this.EndBase = val_6;
            if((TzarGames.GameFramework.MovementBaseUtility.IsDynamicBase(MovementBase:  val_6)) != false)
            {
                    UnityEngine.Vector3 val_8 = val_6.GetComponentLocation();
                UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.SavedLocation, y = V9.16B, z = V10.16B}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
                this.SavedRelativeLocation = val_9;
                mem[1152921511288967920] = val_9.y;
                mem[1152921511288967924] = val_9.z;
            }
            
            TzarGames.GameFramework.FRotator val_10 = Character.Rotator;
            mem[1152921511288967960] = val_4;
            this.ControlRotation = val_5;
        }
        public virtual bool IsImportantMove(TzarGames.GameFramework.FSavedMove_Character LastAckedMove)
        {
            uint val_4;
            UnityEngine.Vector3 val_5;
            var val_8;
            val_4 = this.bPressedJump;
            if(val_4 != LastAckedMove.bPressedJump)
            {
                goto label_9;
            }
            
            val_5 = this.Acceleration;
            val_4 = 1152921504719785984;
            if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = val_5, y = V9.16B, z = V10.16B}, rhs:  new UnityEngine.Vector3() {x = LastAckedMove.Acceleration, y = V12.16B, z = V11.16B})) == false)
            {
                goto label_13;
            }
            
            val_5 = this.AccelMag;
            if((System.Math.Abs(val_5 - LastAckedMove.AccelMag)) > this.AccelMagThreshold)
            {
                goto label_9;
            }
            
            val_5 = this.AccelNormal;
            if((UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_5, y = LastAckedMove.AccelMag, z = V10.16B}, rhs:  new UnityEngine.Vector3() {x = LastAckedMove.AccelNormal, y = V12.16B, z = V11.16B})) >= 0)
            {
                goto label_13;
            }
            
            label_9:
            val_8 = 1;
            return (bool)val_8;
            label_13:
            val_8 = 0;
            return (bool)val_8;
        }
        public virtual UnityEngine.Vector3 GetStartLocation()
        {
            if((TzarGames.GameFramework.MovementBaseUtility.IsDynamicBase(MovementBase:  10361)) == false)
            {
                    return new UnityEngine.Vector3() {x = this.StartLocation};
            }
            
            UnityEngine.Vector3 val_2 = this.StartBase.GetComponentLocation();
            return UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = this.StartRelativeLocation, y = V11.16B, z = V10.16B});
        }
        public virtual bool CanCombineWith(TzarGames.GameFramework.FSavedMove_Character NewMove, TzarGames.GameFramework.CharacterMovementU InPawn, float MaxDelta)
        {
            float val_11;
            TzarGames.GameFramework.UAnimMontage val_12;
            float val_13;
            var val_14;
            val_11 = MaxDelta;
            val_12 = this.RootMotionMontage;
            if(0 != val_12)
            {
                goto label_44;
            }
            
            val_12 = NewMove.RootMotionMontage;
            if(0 != val_12)
            {
                goto label_44;
            }
            
            val_13 = 0.0001f;
            float val_11 = System.Math.Abs(MaxDelta);
            if(val_11 >= 0)
            {
                goto label_11;
            }
            
            val_11 = val_11;
            float val_12 = System.Math.Abs(val_11);
            if(val_12 >= 0)
            {
                goto label_44;
            }
            
            val_11 = val_12;
            float val_13 = System.Math.Abs(val_11);
            if(val_13 >= 0)
            {
                goto label_44;
            }
            
            val_11 = val_13;
            if((System.Math.Abs(val_11) >= 0) || (this.bPressedJump != 0))
            {
                goto label_44;
            }
            
            uint val_15 = NewMove.bPressedJump;
            if(val_15 != 0)
            {
                goto label_44;
            }
            
            val_15 = val_15 >> 32;
            if(this.bWantsToCrouch != val_15)
            {
                goto label_44;
            }
            
            val_12 = NewMove.StartBase;
            if(0 != this.StartBase)
            {
                goto label_44;
            }
            
            val_11 = this.CustomTimeDilation;
            var val_7 = ((System.Math.Abs(val_11 - NewMove.CustomTimeDilation)) < 0) ? 1 : 0;
            return (bool)val_14;
            label_11:
            float val_17 = NewMove.DeltaTime;
            val_17 = val_17 + this.DeltaTime;
            if((val_17 < 0) && (this.bPressedJump == 0))
            {
                    uint val_18 = NewMove.bPressedJump;
                if(val_18 == 0)
            {
                    val_18 = val_18 >> 32;
                if(this.bWantsToCrouch == val_18)
            {
                    val_12 = NewMove.StartBase;
                if(0 == this.StartBase)
            {
                    val_11 = this.AccelNormal;
                if((UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_11, y = MaxDelta, z = val_13}, rhs:  new UnityEngine.Vector3() {x = NewMove.AccelNormal, y = V12.16B, z = V11.16B})) > 0.99f)
            {
                    val_11 = this.CustomTimeDilation;
                var val_10 = (val_11 == NewMove.CustomTimeDilation) ? 1 : 0;
                return (bool)val_14;
            }
            
            }
            
            }
            
            }
            
            }
            
            label_44:
            val_14 = 0;
            return (bool)val_14;
        }
        public virtual void PrepMoveFor(TzarGames.GameFramework.CharacterMovementU Character)
        {
            Character.bForceMaxAccel = this.bForceMaxAccel;
        }
        public virtual void ResetMoveFor(TzarGames.GameFramework.CharacterMovementU Character)
        {
            var val_4;
            TzarGames.GameFramework.FRotator val_5;
            UnityEngine.Vector3 val_2 = Character.CachedTransform.position;
            this.SavedLocation = val_2;
            mem[1152921511289679276] = val_2.y;
            mem[1152921511289679280] = val_2.z;
            TzarGames.GameFramework.FRotator val_3 = Character.Rotator;
            mem[1152921511289679304] = val_4;
            this.SavedRotation = val_5;
            TzarGames.GameFramework.UPrimitiveComponent val_6 = Character.GetMovementBase();
            this.EndBase = val_6;
            if((TzarGames.GameFramework.MovementBaseUtility.IsDynamicBase(MovementBase:  val_6)) == false)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_9 = Character.CachedTransform.position;
            UnityEngine.Vector3 val_10 = val_6.GetComponentLocation();
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, b:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
            this.SavedRelativeLocation = val_11;
            mem[1152921511289679328] = val_11.y;
            mem[1152921511289679332] = val_11.z;
        }
        public virtual byte GetCompressedFlags()
        {
            uint val_4 = this.bPressedJump;
            val_4 = val_4 >> 32;
            var val_1 = (val_4 == 1) ? 1 : 0;
            return (byte)(val_4 == 1) ? (val_1 | 2) : (val_1);
        }
        private static FSavedMove_Character()
        {
        
        }
    
    }

}
