using UnityEngine;

namespace TzarGames.Endless.Maze
{
    [UnityEngine.ExecuteInEditMode]
    public class MazeLightController : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.Transform target;
        [UnityEngine.SerializeField]
        private float maxRadius;
        [UnityEngine.SerializeField]
        private UnityEngine.LayerMask tracelayers;
        [UnityEngine.SerializeField]
        private float lightIntensityChangeSpeed;
        private int maxLightCount;
        private TzarGames.Endless.Maze.MazeLight[] lights;
        private System.Collections.Generic.List<TzarGames.Endless.Maze.MazeLight> nearLights;
        private System.Collections.Generic.Dictionary<TzarGames.Endless.Maze.MazeLight, float> nearLightDistances;
        
        // Properties
        public UnityEngine.Transform Target { get; set; }
        public UnityEngine.LayerMask TraceLayers { get; set; }
        
        // Methods
        public MazeLightController()
        {
            this.maxRadius = 30f;
            this.lightIntensityChangeSpeed = 1f;
            this.maxLightCount = 4;
        }
        public UnityEngine.Transform get_Target()
        {
            return (UnityEngine.Transform)this.target;
        }
        public void set_Target(UnityEngine.Transform value)
        {
            this.target = value;
        }
        public UnityEngine.LayerMask get_TraceLayers()
        {
            return (UnityEngine.LayerMask)this.tracelayers;
        }
        public void set_TraceLayers(UnityEngine.LayerMask value)
        {
            this.tracelayers = value;
        }
        public void Initialize(float maxLightRadius, int maxLightCount)
        {
            var val_4;
            this.maxLightCount = maxLightCount;
            this.maxRadius = maxLightRadius;
            T[] val_1 = this.GetComponentsInChildren<TzarGames.Endless.Maze.MazeLight>();
            val_4 = 0;
            this.lights = val_1;
            goto label_1;
            label_6:
            IntensityScale = 0f;
            val_4 = 1;
            label_1:
            if(val_4 >= val_1.Length)
            {
                goto label_3;
            }
            
            if(val_1[1] != 0)
            {
                goto label_6;
            }
            
            goto label_6;
            label_3:
            this.nearLights = new System.Collections.Generic.List<TzarGames.Endless.Maze.MazeLight>();
            this.nearLightDistances = new System.Collections.Generic.Dictionary<TzarGames.Endless.Maze.MazeLight, System.Single>();
        }
        private static bool isLightVisible(UnityEngine.Vector3 lightPos, UnityEngine.Vector3 targetPos, UnityEngine.LayerMask mask, float sqrDistance, float maxDistance)
        {
            var val_8;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = lightPos.x, y = lightPos.y, z = lightPos.z}, b:  new UnityEngine.Vector3() {x = targetPos.x, y = targetPos.y, z = targetPos.z});
            var val_2 = X1 & 4294967295;
            int val_3 = UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask());
            if((UnityEngine.Physics.Raycast(origin:  new UnityEngine.Vector3() {x = targetPos.x, y = targetPos.y, z = targetPos.z}, direction:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3(), m_Normal = new UnityEngine.Vector3(), m_UV = new UnityEngine.Vector2()}, maxDistance:  maxDistance, layerMask:  1835033328)) != false)
            {
                    float val_6 = 0.targetValue;
                val_6 = 0.targetValue * val_6;
                var val_7 = (val_6 >= sqrDistance) ? 1 : 0;
                return (bool)val_8;
            }
            
            val_8 = 1;
            return (bool)val_8;
        }
        private void Update()
        {
            var val_13;
            int val_16;
            var val_17;
            if(0 == this.target)
            {
                    return;
            }
            
            float val_3 = UnityEngine.Time.deltaTime;
            UnityEngine.Vector3 val_4 = this.target.position;
            this.nearLights.Clear();
            this.nearLightDistances.Clear();
            val_13 = 0;
            goto label_7;
            label_23:
            val_13 = 1;
            label_7:
            if(val_13 >= this.lights.Length)
            {
                goto label_9;
            }
            
            TzarGames.Endless.Maze.MazeLight val_13 = this.lights[1];
            UnityEngine.Vector3 val_6 = this.lights[0x1][0].CachedTransform.position;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            val_16;
            if(val_7.x > (this.maxRadius * this.maxRadius))
            {
                goto label_19;
            }
            
            val_16 = this.lights[0x1][0].CachedTransform;
            UnityEngine.Vector3 val_8 = val_16.position;
            if((TzarGames.Endless.Maze.MazeLightController.isLightVisible(lightPos:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, targetPos:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, mask:  new UnityEngine.LayerMask() {m_Mask = val_16}, sqrDistance:  val_7.x, maxDistance:  this.maxRadius)) == false)
            {
                goto label_19;
            }
            
            this.nearLights.Add(item:  val_13);
            this.nearLightDistances.Add(key:  val_13, value:  val_7.x);
            goto label_23;
            label_19:
            TzarGames.Endless.Maze.MazeLightController.decreaseIntensity(light:  val_7.x, speed:  this.lightIntensityChangeSpeed, dt:  val_3);
            goto label_23;
            label_9:
            this.nearLights.Sort(comparison:  new System.Comparison<TzarGames.Endless.Maze.MazeLight>(object:  this, method:  System.Int32 TzarGames.Endless.Maze.MazeLightController::<Update>m__0(TzarGames.Endless.Maze.MazeLight x, TzarGames.Endless.Maze.MazeLight y)));
            val_17 = 0;
            goto label_25;
            label_33:
            val_17 = 1;
            label_25:
            if(val_17 >= this.nearLights.Count)
            {
                    return;
            }
            
            TzarGames.Endless.Maze.MazeLight val_12 = this.nearLights.Item[1];
            if(val_17 >= this.maxLightCount)
            {
                goto label_29;
            }
            
            float val_15 = val_12.intensityScale;
            if(val_15 >= 0)
            {
                goto label_33;
            }
            
            float val_14 = this.lightIntensityChangeSpeed;
            val_14 = val_3 * val_14;
            val_15 = val_15 + val_14;
            val_12.IntensityScale = val_15;
            goto label_33;
            label_29:
            TzarGames.Endless.Maze.MazeLightController.decreaseIntensity(light:  val_12, speed:  this.lightIntensityChangeSpeed, dt:  val_3);
            goto label_33;
        }
        private static void decreaseIntensity(TzarGames.Endless.Maze.MazeLight light, float speed, float dt)
        {
            float val_1 = X1 + 48;
            if(val_1 <= 0f)
            {
                    return;
            }
            
            dt = speed * dt;
            val_1 = val_1 - dt;
            X1.IntensityScale = val_1;
        }
        private int <Update>m__0(TzarGames.Endless.Maze.MazeLight x, TzarGames.Endless.Maze.MazeLight y)
        {
            var val_4;
            float val_1 = this.nearLightDistances.Item[x];
            if(val_1 >= 0)
            {
                    var val_3 = (val_1 > this.nearLightDistances.Item[y]) ? 0 : 0;
                return (int)val_4;
            }
            
            val_4 = 1;
            return (int)val_4;
        }
    
    }

}
