using UnityEngine;

namespace TzarGames.GameFramework
{
    public class FNetworkPredictionData_Client_Character : FNetworkPredictionData_Client
    {
        // Fields
        public float ClientUpdateTime;
        public float CurrentTimeStamp;
        public TzarGames.GameFramework.TArray<TzarGames.GameFramework.FSavedMove_Character> SavedMoves;
        public TzarGames.GameFramework.TArray<TzarGames.GameFramework.FSavedMove_Character> FreeMoves;
        public TzarGames.GameFramework.FSavedMove_Character PendingMove;
        public TzarGames.GameFramework.FSavedMove_Character LastAckedMove;
        public int MaxFreeMoveCount;
        public int MaxSavedMoveCount;
        public uint bUpdatePosition;
        public TzarGames.GameFramework.FRootMotionMovementParams RootMotionMovement;
        public uint bSmoothNetUpdates;
        public UnityEngine.Vector3 MeshTranslationOffset;
        public float MaxSmoothNetUpdateDist;
        public float NoSmoothNetUpdateDist;
        public float SmoothNetUpdateTime;
        public float MaxResponseTime;
        
        // Methods
        public FNetworkPredictionData_Client_Character()
        {
            this.SavedMoves = new TzarGames.GameFramework.TArray<TzarGames.GameFramework.FSavedMove_Character>();
            this.MaxFreeMoveCount = 96;
            this.MaxSavedMoveCount = 96;
            this.FreeMoves = new TzarGames.GameFramework.TArray<TzarGames.GameFramework.FSavedMove_Character>();
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            this.MeshTranslationOffset = val_3;
            mem[1152921511290152776] = val_3.y;
            mem[1152921511290152780] = val_3.z;
            this.MaxSmoothNetUpdateDist = ;
            this.NoSmoothNetUpdateDist = ;
            this.SmoothNetUpdateTime = 0.125f;
            this.MaxResponseTime = 0.125f;
        }
        public int GetSavedMoveIndex(float TimeStamp)
        {
            var val_4;
            if(this.SavedMoves.Num() < 1)
            {
                    return TzarGames.Common.FMath.INDEX_NONE;
            }
            
            if((this.LastAckedMove != null) && (this.LastAckedMove.bOldTimeStampBeforeReset != true))
            {
                    if(this.LastAckedMove.TimeStamp >= TimeStamp)
            {
                    return TzarGames.Common.FMath.INDEX_NONE;
            }
            
            }
            
            val_4 = 0;
            goto label_6;
            label_11:
            val_4 = 1;
            label_6:
            if(val_4 >= this.SavedMoves.Num())
            {
                    return TzarGames.Common.FMath.INDEX_NONE;
            }
            
            TzarGames.GameFramework.FSavedMove_Character val_3 = this.SavedMoves.Item[1];
            if(val_3.TimeStamp != TimeStamp)
            {
                goto label_11;
            }
            
            return (int)val_4;
        }
        public void AckMove(int AckedMoveIndex)
        {
            var val_5;
            if(TzarGames.Common.FMath.INDEX_NONE == AckedMoveIndex)
            {
                    return;
            }
            
            val_5 = 0;
            this.LastAckedMove = this.SavedMoves.Item[AckedMoveIndex];
            goto label_4;
            label_6:
            System.Action<System.Boolean, UnityEngine.SocialPlatforms.IUserProfile> val_3 = this.LastAckedMove.Item[0];
            val_5 = 1;
            label_4:
            if(val_5 < AckedMoveIndex)
            {
                goto label_6;
            }
            
            this.SavedMoves.RemoveRange(index:  0, count:  AckedMoveIndex + 1);
        }
        public virtual TzarGames.GameFramework.FSavedMove_Character AllocateNewMove()
        {
            return (TzarGames.GameFramework.FSavedMove_Character)new TzarGames.GameFramework.FSavedMove_Character();
        }
        public virtual void FreeMove(ref TzarGames.GameFramework.FSavedMove_Character Move)
        {
            TzarGames.GameFramework.TArray<TzarGames.GameFramework.FSavedMove_Character> val_2;
            TzarGames.GameFramework.FSavedMove_Character val_3;
            if(Move == null)
            {
                    return;
            }
            
            val_2 = this.FreeMoves;
            if(val_2.Num() < this.MaxFreeMoveCount)
            {
                    val_2 = this.FreeMoves;
                val_2.Push(item:  Move);
            }
            
            val_3 = Move;
            if(this.PendingMove == val_3)
            {
                    this.PendingMove = 0;
                val_3 = Move;
            }
            
            if(this.LastAckedMove != val_3)
            {
                    return;
            }
            
            this.LastAckedMove = 0;
        }
        public virtual TzarGames.GameFramework.FSavedMove_Character CreateSavedMove()
        {
            return (TzarGames.GameFramework.FSavedMove_Character)new TzarGames.GameFramework.FSavedMove_Character();
        }
        public float UpdateTimeStampAndDeltaTime(float DeltaTime, TzarGames.GameFramework.CharacterMovementU CharacterMovementComponent)
        {
            float val_9;
            var val_10;
            var val_11;
            TzarGames.GameFramework.TArray<TzarGames.GameFramework.FSavedMove_Character> val_12;
            var val_13;
            val_9 = DeltaTime;
            val_10 = null;
            val_10 = null;
            if(this.CurrentTimeStamp <= TzarGames.GameFramework.CharacterMovementU.MinTimeBetweenTimeStampResets)
            {
                goto label_3;
            }
            
            string val_1 = 0 + "Resetting client`s timeStamp ";
            UnityEngine.Debug.Log(message:  0);
            this.CurrentTimeStamp = 0f;
            val_11 = 0;
            val_12 = this.SavedMoves;
            goto label_8;
            label_14:
            val_11 = 1;
            mem2[0] = 1;
            label_8:
            if(val_11 >= mem[this.SavedMoves].Count)
            {
                goto label_10;
            }
            
            System.Action<System.Boolean, UnityEngine.SocialPlatforms.IUserProfile> val_3 = mem[this.SavedMoves].Item[1];
            if(mem[this.SavedMoves].Item[1] != null)
            {
                goto label_14;
            }
            
            goto label_14;
            label_3:
            val_12 = this.SavedMoves;
            goto label_16;
            label_10:
            if(this.LastAckedMove != null)
            {
                    this.LastAckedMove.bOldTimeStampBeforeReset = true;
            }
            
            label_16:
            float val_8 = this.CurrentTimeStamp;
            val_8 = val_8 + val_9;
            this.CurrentTimeStamp = val_8;
            val_13 = mem[this.SavedMoves];
            if(val_13.Count >= 1)
            {
                    val_13 = mem[this.SavedMoves].Last();
                if(val_6.bOldTimeStampBeforeReset != true)
            {
                    val_9 = this.CurrentTimeStamp - val_6.TimeStamp;
            }
            
            }
            
            float val_7 = UnityEngine.Mathf.Min(a:  val_9, b:  this.MaxResponseTime);
            val_7 = CharacterMovementComponent.CustomTimeDilation * val_7;
            return (float)val_7;
        }
    
    }

}
