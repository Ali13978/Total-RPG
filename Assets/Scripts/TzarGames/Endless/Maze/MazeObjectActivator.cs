using UnityEngine;

namespace TzarGames.Endless.Maze
{
    public class MazeObjectActivator : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private float radius;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private UnityEngine.Transform <Target>k__BackingField;
        private TzarGames.Endless.Maze.MazeObjectActivator.ObjectInfo[] objects;
        
        // Properties
        public UnityEngine.Transform Target { get; set; }
        
        // Methods
        public MazeObjectActivator()
        {
            this.radius = 30f;
        }
        public UnityEngine.Transform get_Target()
        {
            return (UnityEngine.Transform)this.<Target>k__BackingField;
        }
        public void set_Target(UnityEngine.Transform value)
        {
            this.<Target>k__BackingField = value;
        }
        public void StartWork()
        {
            var val_12;
            System.Collections.Generic.List<ObjectInfo> val_2 = new System.Collections.Generic.List<ObjectInfo>();
            val_12 = 0;
            goto label_3;
            label_15:
            val_12 = 1;
            label_3:
            if(val_12 >= val_1.Length)
            {
                goto label_5;
            }
            
            T val_12 = UnityEngine.Object.FindObjectsOfType<UnityEngine.Component>()[1];
            if((val_12.ActivateByDistance == false) || (val_12.enabled == false))
            {
                goto label_15;
            }
            
            UnityEngine.Vector3 val_6 = val_12.transform.position;
            Add(item:  new ObjectInfo() {Object = val_12, Position = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, Activated = val_12.Activated});
            goto label_15;
            label_5:
            this.objects = ToArray();
            UnityEngine.Coroutine val_11 = this.StartCoroutine(routine:  this.updateRoutine());
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator updateRoutine()
        {
            typeof(MazeObjectActivator.<updateRoutine>c__Iterator0).__il2cppRuntimeField_20 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
    
    }

}
