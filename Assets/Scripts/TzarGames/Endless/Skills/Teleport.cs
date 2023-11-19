using UnityEngine;

namespace TzarGames.Endless.Skills
{
    public class Teleport : EndlessCharacterSkill
    {
        // Fields
        [UnityEngine.SerializeField]
        private float maxDistance;
        [UnityEngine.SerializeField]
        private float minDistance;
        [UnityEngine.SerializeField]
        private float upOffset;
        [UnityEngine.SerializeField]
        private bool needsPath;
        [UnityEngine.SerializeField]
        private bool runOutFromTarget;
        [UnityEngine.SerializeField]
        private float minimumTargetDistance;
        [UnityEngine.SerializeField]
        private UnityEngine.GameObject oldPositionEffect;
        [UnityEngine.SerializeField]
        private UnityEngine.GameObject newPositionEffect;
        private UnityEngine.Coroutine teleportCoroutine;
        private TzarGames.GameFramework.IPathResult lastPathResult;
        private bool prevNoRandomAttemptFailed;
        
        // Methods
        public Teleport()
        {
            this.maxDistance = 6f;
            this.minDistance = 2f;
            this.upOffset = 0.2f;
            this.needsPath = true;
            this.runOutFromTarget = true;
            this.minimumTargetDistance = 3f;
        }
        public override bool Validate()
        {
            if(0 != this.Character.Pathfinder)
            {
                    return this.Validate();
            }
            
            return false;
        }
        protected override void OnStarted()
        {
            this.OnStarted();
            this.teleportCoroutine = this.Character.StartCoroutine(routine:  this.teleportingProcess());
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator teleportingProcess()
        {
            typeof(Teleport.<teleportingProcess>c__Iterator0).__il2cppRuntimeField_A8 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        private bool canContinue()
        {
            return this.IsPerforming;
        }
        protected override void OnStopped()
        {
            this.OnStopped();
            if(this.teleportCoroutine == null)
            {
                    return;
            }
            
            this.Character.StopCoroutine(routine:  this.teleportCoroutine);
            this.teleportCoroutine = 0;
        }
        private bool isTargetPointTooClose(UnityEngine.Vector3 targetPoint)
        {
            UnityEngine.Vector3 val_2 = this.Character.GroundPivotPosition;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = targetPoint.x, y = targetPoint.y, z = targetPoint.z});
            float val_5 = this.minDistance;
            val_5 = val_5 * val_5;
            return (bool)(val_3.x < 0) ? 1 : 0;
        }
        private void teleport(UnityEngine.Vector3 targetPosition)
        {
            float val_17;
            float val_18;
            val_17 = targetPosition.z;
            val_18 = targetPosition.y;
            UnityEngine.Vector3 val_2 = this.Character.GroundPivotPosition;
            if(0 != this.oldPositionEffect)
            {
                    UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.identity;
                TzarGames.GameFramework.TzarBehaviour val_5 = UnityEngine.Object.Instantiate<TzarGames.GameFramework.TzarBehaviour>(original:  0, position:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, rotation:  new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w});
                val_17 = val_17;
                val_18 = val_18;
            }
            
            UnityEngine.Vector3 val_7 = this.Character.Position;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = targetPosition.x, y = val_18, z = val_17}, b:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, d:  this.upOffset);
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, b:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
            this.Character.Position = new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z};
            if(0 == this.newPositionEffect)
            {
                    return;
            }
            
            UnityEngine.Quaternion val_15 = UnityEngine.Quaternion.identity;
            TzarGames.GameFramework.TzarBehaviour val_16 = UnityEngine.Object.Instantiate<TzarGames.GameFramework.TzarBehaviour>(original:  0, position:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, rotation:  new UnityEngine.Quaternion() {x = val_15.x, y = val_15.y, z = val_15.z, w = val_15.w});
        }
        private void pathCalculationCallback(TzarGames.GameFramework.IPathResult result)
        {
            if(this.IsPerforming == false)
            {
                    return;
            }
            
            this.lastPathResult = result;
        }
    
    }

}
