using UnityEngine;

namespace TzarGames.Endless.Maze
{
    public class MazeBuildObject : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Endless.Maze.MazeBuildObject.SpawnInfo[] objectsToSpawn;
        [UnityEngine.SerializeField]
        private UnityEngine.MeshRenderer mainRenderer;
        [UnityEngine.SerializeField]
        private bool activateByDistance;
        [UnityEngine.SerializeField]
        private UnityEngine.Component[] activableComponents;
        [UnityEngine.SerializeField]
        private UnityEngine.GameObject[] activableObjects;
        [UnityEngine.SerializeField]
        [UnityEngine.HideInInspector]
        private bool activated;
        
        // Properties
        public bool Activated { get; }
        public bool ActivateByDistance { get; }
        public UnityEngine.MeshRenderer MainRenderer { get; }
        
        // Methods
        public MazeBuildObject()
        {
            this.activateByDistance = true;
            this.activated = true;
        }
        public bool get_Activated()
        {
            return (bool)this.activated;
        }
        public bool get_ActivateByDistance()
        {
            return (bool)this.activateByDistance;
        }
        private void Start()
        {
            goto label_1;
            label_13:
            0 = 1;
            label_1:
            if(0 >= this.objectsToSpawn.Length)
            {
                    return;
            }
            
            SpawnInfo val_7 = this.objectsToSpawn[1];
            float val_1 = UnityEngine.Random.Range(min:  0f, max:  100f);
            if(this.objectsToSpawn[0x1][0].ChancePercent < 0)
            {
                goto label_13;
            }
            
            UnityEngine.Vector3 val_3 = this.objectsToSpawn[0x1][0].Parent.position;
            UnityEngine.Quaternion val_4 = this.objectsToSpawn[0x1][0].Parent.rotation;
            if((TzarGames.GameFramework.Instantiator.IsPoolableInstance(instanceObject:  0)) == false)
            {
                goto label_9;
            }
            
            UnityEngine.GameObject val_5 = TzarGames.GameFramework.Instantiator.InstantiateFromPool(originalObject:  0, position:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, rotation:  new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w}, parent:  this.objectsToSpawn[0x1][0].Prefab);
            goto label_13;
            label_9:
            TzarGames.TzarHero.DamageInfluenceBehaviour val_6 = UnityEngine.Object.Instantiate<TzarGames.TzarHero.DamageInfluenceBehaviour>(original:  0, position:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, rotation:  new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w}, parent:  this.objectsToSpawn[0x1][0].Prefab);
            goto label_13;
        }
        public void Activate()
        {
            if(this.activated != false)
            {
                    return;
            }
            
            this.set(active:  true);
        }
        private void set(bool active)
        {
            var val_17;
            var val_18;
            val_17 = 0;
            this.activated = active;
            goto label_1;
            label_33:
            val_17 = 1;
            label_1:
            if(val_17 >= this.activableComponents.Length)
            {
                goto label_3;
            }
            
            UnityEngine.Component val_17 = this.activableComponents[1];
            if((0 == val_17) || ((UnityEngine.Object.op_Implicit(exists:  0)) == false))
            {
                goto label_11;
            }
            
            if(val_17 == null)
            {
                goto label_33;
            }
            
            goto label_20;
            label_11:
            string val_9 = this.gameObject.name;
            UnityEngine.Debug.LogErrorFormat(format:  0, args:  0 + "Null reference in {0}");
            goto label_33;
            label_20:
            enabled = active;
            goto label_33;
            label_3:
            val_18 = 0;
            goto label_34;
            label_39:
            active = active;
            this.SetActive(value:  active);
            val_18 = 1;
            label_34:
            if(val_18 >= this.activableObjects.Length)
            {
                    return;
            }
            
            if(this.activableObjects[1] != null)
            {
                goto label_39;
            }
            
            goto label_39;
        }
        public void Deactivate()
        {
            if(this.activated == false)
            {
                    return;
            }
            
            this.set(active:  false);
        }
        public UnityEngine.MeshRenderer get_MainRenderer()
        {
            return (UnityEngine.MeshRenderer)this.mainRenderer;
        }
    
    }

}
