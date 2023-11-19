using UnityEngine;

namespace TzarGames.Endless.Skills
{
    public class LightningBolts : AnimationBasedSkill
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.LineRenderer lightning;
        [UnityEngine.SerializeField]
        private UnityEngine.LayerMask traceLayers;
        [UnityEngine.SerializeField]
        private float spawnInterval;
        private float lastSpawnTime;
        [UnityEngine.SerializeField]
        private float yOffset;
        [UnityEngine.SerializeField]
        private float traceDistance;
        [UnityEngine.SerializeField]
        private float jitterAmplitude;
        [UnityEngine.SerializeField]
        private float boltUpdateInterval;
        [UnityEngine.SerializeField]
        private int lineResolution;
        private UnityEngine.Transform[] sockets;
        private System.Collections.Generic.List<TzarGames.Endless.Skills.LightningBolts.BoltInfo> bolts;
        
        // Methods
        public LightningBolts()
        {
            this.yOffset = ;
            this.traceDistance = ;
            this.jitterAmplitude = 0.5f;
            this.boltUpdateInterval = 0.1f;
            this.spawnInterval = 0.3f;
            this.lineResolution = 10;
            this.bolts = new System.Collections.Generic.List<BoltInfo>();
        }
        protected override void OnCharacterAssigned()
        {
            this.OnCharacterAssigned();
            TzarGames.Endless.Skills.LightningSockets val_2 = this.Character.GetComponent<TzarGames.Endless.Skills.LightningSockets>();
            this.sockets = val_2.Sockets;
        }
        public override void UpdatePerformingSkill(float deltaTime)
        {
            this.UpdatePerformingSkill(deltaTime:  deltaTime);
            float val_1 = UnityEngine.Time.time;
            val_1 = val_1 - this.lastSpawnTime;
            if(val_1 < this.spawnInterval)
            {
                    return;
            }
            
            this.createBolt();
            this.lastSpawnTime = UnityEngine.Time.time;
        }
        public override void UpdateSkill(float deltaTime)
        {
            UnityEngine.Vector3[] val_4;
            float val_5;
            UnityEngine.Object val_6;
            float val_7;
            UnityEngine.Object val_12;
            this.UpdateSkill(deltaTime:  deltaTime);
            float val_1 = UnityEngine.Time.time;
            System.Collections.Generic.List<BoltInfo> val_12 = this.bolts;
            val_12 = val_12.Count - 1;
            if((val_12 & 2147483648) != 0)
            {
                    return;
            }
            
            label_14:
            BoltInfo val_3 = this.bolts.Item[val_12];
            val_12 = val_6;
            if((0 == val_12) || ((UnityEngine.Object.op_Implicit(exists:  0)) == false))
            {
                goto label_9;
            }
            
            float val_13 = val_7;
            val_13 = val_1 - val_13;
            if(val_13 < this.boltUpdateInterval)
            {
                goto label_12;
            }
            
            val_12 = this.bolts;
            val_4 = val_4;
            val_5 = val_5;
            val_6 = val_6;
            val_7 = val_1;
            val_12.set_Item(index:  val_12, value:  new BoltInfo() {LastUpdateTime = val_7, End = new UnityEngine.Vector3() {x = val_5, y = val_5, z = val_5}, Bolt = val_6, BoltTransform = val_6, Points = val_4});
            this.updateBolt(boltInfo: ref  new BoltInfo() {LastUpdateTime = val_1, Start = val_7, End = new UnityEngine.Vector3() {x = val_5, y = val_5, z = val_5}, Bolt = val_6, BoltTransform = val_6, Points = val_4});
            goto label_12;
            label_9:
            val_12 = this.bolts;
            val_12.RemoveAt(index:  val_12);
            label_12:
            val_12 = val_12 - 1;
            if((val_12 & 2147483648) == 0)
            {
                goto label_14;
            }
        
        }
        private void updateBolt(ref TzarGames.Endless.Skills.LightningBolts.BoltInfo boltInfo)
        {
            int val_16;
            var val_17;
            float val_21;
            float val_22;
            float val_23;
            float val_24;
            float val_25;
            float val_26;
            UnityEngine.Vector3 val_1 = boltInfo.Start.position;
            boltInfo.BoltTransform.position = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = boltInfo.End.x, y = boltInfo.End.y, z = boltInfo.End.z}, b:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            UnityEngine.Vector3 val_3 = boltInfo.Start.position;
            val_16 = boltInfo.Points.Length;
            if(val_16 == 0)
            {
                    val_16 = boltInfo.Points.Length;
            }
            
            boltInfo.Points[0] = val_3;
            boltInfo.Points[0] = val_3.y;
            boltInfo.Points[0] = val_3.z;
            var val_16 = -4294967296;
            val_16 = val_16 + ((boltInfo.Points.Length) << 32);
            var val_4 = val_16 >> 32;
            var val_17 = 12;
            val_17 = boltInfo.Points + (val_4 * val_17);
            mem2[0] = boltInfo.End.x;
            mem2[0] = boltInfo.End.y;
            mem2[0] = boltInfo.End.z;
            UnityEngine.Quaternion val_5 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            boltInfo.BoltTransform.rotation = new UnityEngine.Quaternion() {x = val_5.x, y = val_5.y, z = val_5.z, w = val_5.w};
            val_17 = 1;
            goto label_12;
            label_26:
            var val_6 = boltInfo.Points + (val_4 * 12);
            val_17 = 2;
            mem2[0] = val_2.z;
            mem2[0] = val_2.y;
            mem2[0] = val_2.x;
            label_12:
            int val_18 = boltInfo.Points.Length;
            val_18 = val_18 - 1;
            if(val_17 >= val_18)
            {
                goto label_14;
            }
            
            UnityEngine.Vector3 val_7 = UnityEngine.Random.onUnitSphere;
            if(val_7.x < 0)
            {
                    UnityEngine.Vector3 val_8 = UnityEngine.Vector3.up;
                val_21 = val_8.x;
                val_22 = val_8.y;
                val_23 = val_8.z;
            }
            else
            {
                    val_21 = val_21;
                val_22 = val_22;
                val_23 = val_23;
            }
            
            UnityEngine.Vector3 val_9 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_5.x, y = val_5.y, z = val_5.z, w = val_5.w}, point:  new UnityEngine.Vector3() {x = val_21, y = val_22, z = val_23});
            if(boltInfo.Points != null)
            {
                    val_24 = val_2.x;
                val_25 = val_2.y;
                val_26 = val_2.z;
            }
            else
            {
                    val_24 = val_2.x;
                val_25 = val_2.y;
                val_26 = val_2.z;
            }
            
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_24, y = val_25, z = val_26}, d:  2f / (float)boltInfo.Points.Length);
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, d:  val_2.x);
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, d:  this.jitterAmplitude);
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, b:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
            if(val_17 < boltInfo.Points.Length)
            {
                goto label_26;
            }
            
            goto label_26;
            label_14:
            boltInfo.Bolt.positionCount = this.lineResolution;
            boltInfo.Bolt.SetPositions(positions:  boltInfo.Points);
        }
        private void createBolt()
        {
            UnityEngine.Transform[] val_16;
            float val_17;
            float val_18;
            float val_19;
            float val_20;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            float val_2 = UnityEngine.Random.Range(min:  -1f, max:  1f);
            float val_3 = UnityEngine.Random.Range(min:  -1f, max:  1f);
            if((UnityEngine.Random.Range(min:  -0.5f, max:  0f)) < 0)
            {
                    UnityEngine.Vector3 val_5 = UnityEngine.Vector3.forward;
            }
            
            val_16 = this.sockets;
            UnityEngine.Transform val_16 = val_16[(long)UnityEngine.Random.Range(min:  0, max:  0)];
            UnityEngine.Vector3 val_7 = val_16.position;
            val_17 = val_5.x;
            val_18 = val_5.z;
            val_19 = val_7.x;
            val_20 = val_7.z;
            int val_8 = UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask());
            if((UnityEngine.Physics.Raycast(origin:  new UnityEngine.Vector3() {x = val_19, y = val_7.y, z = val_20}, direction:  new UnityEngine.Vector3() {x = val_17, y = val_5.y, z = val_18}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3(), m_Normal = new UnityEngine.Vector3(), m_UV = new UnityEngine.Vector2()}, maxDistance:  this.traceDistance, layerMask:  1924502448)) == false)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_10 = val_16.position;
            UnityEngine.Quaternion val_11 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            val_18 = val_11.y;
            val_20 = val_11.z;
            val_16 = UnityEngine.Object.Instantiate<TzarGames.GameFramework.TzarBehaviour>(original:  0, position:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, rotation:  new UnityEngine.Quaternion() {x = val_11.x, y = val_18, z = val_20, w = val_11.w});
            val_17 = val_10.z;
            this.bolts.Add(item:  new BoltInfo() {LastUpdateTime = 0f, End = new UnityEngine.Vector3() {x = val_10.x}, Bolt = val_16, BoltTransform = val_16});
            val_19 = 0.targetValue;
            val_16.GetComponentInChildren<TzarGames.Endless.Laser>().TraceDistance = val_19;
            this.updateBolt(boltInfo: ref  new BoltInfo() {LastUpdateTime = 0f, Start = val_16, End = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_17}, Bolt = val_16, BoltTransform = val_16.transform});
        }
        protected override void action(TzarGames.Common.StringID animationEvent)
        {
        
        }
    
    }

}
