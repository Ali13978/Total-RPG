using UnityEngine;

namespace TzarGames.GameFramework
{
    public class NavMeshPathfinder : PathfinderBase, IPoolable
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.AI.NavMeshObstacle obstacle;
        [UnityEngine.SerializeField]
        private UnityEngine.Transform ownerTransform;
        [UnityEngine.SerializeField]
        private float nearestPointSearchDistance;
        private UnityEngine.AI.NavMeshPath path;
        private TzarGames.GameFramework.NavMeshPathResult result;
        
        // Methods
        public NavMeshPathfinder()
        {
            this.nearestPointSearchDistance = 5f;
        }
        private void Awake()
        {
            this.result = new TzarGames.GameFramework.NavMeshPathResult();
            this.path = new UnityEngine.AI.NavMeshPath();
        }
        public override void Initialize(float actorHeight, float actorRadius)
        {
            if(0 == this.obstacle)
            {
                    return;
            }
            
            this.obstacle.height = actorHeight;
            this.obstacle.radius = actorRadius;
        }
        public override bool CalculatePath(UnityEngine.Vector3 sourcePosition, UnityEngine.Vector3 targetPosition, UnityEngine.Events.UnityAction<TzarGames.GameFramework.IPathResult> pathResultCallback)
        {
            float val_11;
            float val_12;
            float val_13;
            float val_14;
            float val_15;
            float val_16;
            float val_17;
            TzarGames.GameFramework.NavMeshPathResult val_18;
            UnityEngine.AI.NavMeshPath val_19;
            val_11 = targetPosition.z;
            val_12 = targetPosition.y;
            val_13 = targetPosition.x;
            val_14 = sourcePosition.z;
            val_15 = sourcePosition.y;
            val_16 = sourcePosition.x;
            if(0 != this.obstacle)
            {
                    val_17 = this.obstacle.radius * 3f;
            }
            else
            {
                    val_17 = this.nearestPointSearchDistance;
            }
            
            bool val_3 = UnityEngine.AI.NavMesh.SamplePosition(sourcePosition:  new UnityEngine.Vector3() {x = val_16, y = val_15, z = val_14}, hit: out  new UnityEngine.AI.NavMeshHit() {m_Position = new UnityEngine.Vector3(), m_Normal = new UnityEngine.Vector3()}, maxDistance:  val_17, areaMask:  -1776954408);
            if(((-1776954408) & 1) != 0)
            {
                    val_16 = val_16;
                val_15 = val_15;
                val_14 = val_14;
            }
            
            bool val_4 = UnityEngine.AI.NavMesh.SamplePosition(sourcePosition:  new UnityEngine.Vector3() {x = val_13, y = val_12, z = val_11}, hit: out  new UnityEngine.AI.NavMeshHit() {m_Position = new UnityEngine.Vector3(), m_Normal = new UnityEngine.Vector3()}, maxDistance:  val_17, areaMask:  -1776954408);
            if(((-1776954408) & 1) != 0)
            {
                    val_13 = val_13;
                val_12 = val_12;
                val_11 = val_11;
            }
            
            this.result.<Success>k__BackingField = UnityEngine.AI.NavMesh.CalculatePath(sourcePosition:  new UnityEngine.Vector3() {x = val_16, y = val_15, z = val_14}, targetPosition:  new UnityEngine.Vector3() {x = val_13, y = val_12, z = val_11}, areaMask:  0, path:  0);
            val_18 = this.result;
            if(this.result == null)
            {
                    val_18 = this.result;
            }
            
            if((this.result.<Success>k__BackingField) != false)
            {
                    this.result.<ResultType>k__BackingField = (this.path.status != 0) ? 1 : 0;
                val_19 = this.path;
                this.result.AllocatedCornerCount = val_19.GetCornersNonAlloc(results:  this.result.PathPoints);
            }
            else
            {
                    this.result.AllocatedCornerCount = 0;
                val_19 = this.result;
                this.result.<ResultType>k__BackingField = 2;
            }
            
            pathResultCallback.Invoke(arg0:  this.result);
            return true;
        }
        public override bool GetNearestPosition(UnityEngine.Vector3 position, out UnityEngine.Vector3 result)
        {
            float val_2;
            float val_3;
            float val_4;
            var val_5;
            val_2 = position.z;
            val_3 = position.y;
            val_4 = position.x;
            if((UnityEngine.AI.NavMesh.SamplePosition(sourcePosition:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, hit: out  new UnityEngine.AI.NavMeshHit() {m_Position = new UnityEngine.Vector3(), m_Normal = new UnityEngine.Vector3()}, maxDistance:  this.nearestPointSearchDistance, areaMask:  -1776748168)) != false)
            {
                    val_4 = position.x;
                val_3 = position.y;
                val_2 = position.z;
                val_5 = 1;
            }
            else
            {
                    val_5 = 0;
            }
            
            result.x = val_4;
            result.y = val_3;
            result.z = val_2;
            return (bool)val_5;
        }
        public override void Activate()
        {
            if(0 == this.obstacle)
            {
                    return;
            }
            
            this.obstacle.enabled = false;
        }
        public override void Deactivate()
        {
            if(0 == this.obstacle)
            {
                    return;
            }
            
            this.obstacle.enabled = false;
        }
        public override void OnStartMovement()
        {
            if(0 == this.obstacle)
            {
                    return;
            }
            
            this.obstacle.enabled = false;
        }
        public override void OnStopMovement()
        {
            if(0 == this.obstacle)
            {
                    return;
            }
            
            this.obstacle.enabled = true;
        }
        private void Reset()
        {
            if(0 == this.obstacle)
            {
                    this.obstacle = this.GetComponent<UnityEngine.AI.NavMeshObstacle>();
            }
            
            if(0 != this.ownerTransform)
            {
                    return;
            }
            
            this.ownerTransform = this.GetComponent<UnityEngine.Transform>();
        }
        public override bool HasObstacleBetweenPoints(UnityEngine.Vector3 sourcePosition, UnityEngine.Vector3 targetPosition)
        {
            return (bool)UnityEngine.AI.NavMesh.Raycast(sourcePosition:  new UnityEngine.Vector3() {x = sourcePosition.x, y = sourcePosition.y, z = sourcePosition.z}, targetPosition:  new UnityEngine.Vector3() {x = targetPosition.x, y = targetPosition.y, z = targetPosition.z}, hit: out  new UnityEngine.AI.NavMeshHit() {m_Position = new UnityEngine.Vector3(), m_Normal = new UnityEngine.Vector3()}, areaMask:  -1775972728);
        }
        public void OnPushedToPool()
        {
            goto typeof(TzarGames.GameFramework.NavMeshPathfinder).__il2cppRuntimeField_190;
        }
        public void OnPulledFromPool()
        {
            goto typeof(TzarGames.GameFramework.NavMeshPathfinder).__il2cppRuntimeField_180;
        }
    
    }

}
