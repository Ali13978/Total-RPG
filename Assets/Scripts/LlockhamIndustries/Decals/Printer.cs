using UnityEngine;

namespace LlockhamIndustries.Decals
{
    public class Printer : MonoBehaviour
    {
        // Fields
        public LlockhamIndustries.Decals.ProjectionRenderer[] prints;
        public UnityEngine.LayerMask[] printLayers;
        public string[] printTags;
        public LlockhamIndustries.Decals.PrintSelection printMethod;
        private LlockhamIndustries.Decals.ProjectionPool pool;
        [UnityEngine.SerializeField]
        private int poolID;
        public LlockhamIndustries.Decals.PrintParent parent;
        public bool printBehaviours;
        public bool destroyOnPrint;
        public float frequencyTime;
        public float frequencyDistance;
        [UnityEngine.SerializeField]
        protected LlockhamIndustries.Decals.PrinterOverlap[] overlaps;
        private float timeSincePrint;
        private UnityEngine.Vector3 lastPrintPos;
        
        // Properties
        public LlockhamIndustries.Decals.ProjectionPool Pool { get; set; }
        
        // Methods
        public Printer()
        {
            this.prints = null;
            this.timeSincePrint = Infinityf;
            this.overlaps = null;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            this.lastPrintPos = val_1;
            mem[1152921511821089944] = val_1.y;
            mem[1152921511821089948] = val_1.z;
        }
        public LlockhamIndustries.Decals.ProjectionPool get_Pool()
        {
            if(this.pool != null)
            {
                    return val_2;
            }
            
            LlockhamIndustries.Decals.ProjectionPool val_2 = LlockhamIndustries.Decals.DynamicDecals.System.GetPool(ID:  this.poolID);
            this.pool = val_2;
            return val_2;
        }
        public void set_Pool(LlockhamIndustries.Decals.ProjectionPool value)
        {
            this.poolID = value.instance.id;
        }
        private void Update()
        {
            float val_1 = UnityEngine.Time.deltaTime;
            val_1 = this.timeSincePrint + val_1;
            this.timeSincePrint = val_1;
        }
        public void Print(UnityEngine.Vector3 Position, UnityEngine.Quaternion Rotation, UnityEngine.Transform Surface, int Layer = 0)
        {
            LlockhamIndustries.Decals.ProjectionRenderer[] val_17;
            float val_18;
            float val_19;
            float val_20;
            var val_21;
            var val_22;
            LlockhamIndustries.Decals.PrinterOverlap[] val_23;
            var val_24;
            LlockhamIndustries.Decals.ProjectionRenderer val_25;
            UnityEngine.LayerMask[] val_26;
            var val_27;
            val_17 = Layer;
            val_18 = Rotation.z;
            val_19 = Position.z;
            if((this.prints == null) || (this.prints.Length <= 0))
            {
                goto label_2;
            }
            
            val_20 = Position.y;
            if(this.timeSincePrint < this.frequencyTime)
            {
                    return;
            }
            
            val_19 = val_18;
            val_18 = Rotation.w;
            if((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = Position.x, y = val_20, z = val_19}, b:  new UnityEngine.Vector3() {x = this.lastPrintPos, y = Rotation.w, z = V15.16B})) < this.frequencyDistance)
            {
                    return;
            }
            
            val_19 = val_19;
            val_20 = Position.x;
            if(this.overlaps.Length < 1)
            {
                goto label_11;
            }
            
            val_21 = 0;
            goto label_9;
            label_23:
            val_21 = 1;
            label_9:
            if(val_21 >= this.overlaps.Length)
            {
                goto label_11;
            }
            
            val_22 = 1;
            if(val_3.instance.id != this.overlaps[val_22])
            {
                goto label_23;
            }
            
            val_23 = this.overlaps;
            if((LlockhamIndustries.Decals.DynamicDecals.System.GetPool(ID:  this.overlaps[val_22]).CheckIntersecting(Point:  new UnityEngine.Vector3() {x = val_20, y = val_20, z = val_19}, intersectionStrength:  val_23[val_22])) == false)
            {
                goto label_23;
            }
            
            if(this.destroyOnPrint == false)
            {
                    return;
            }
            
            UnityEngine.GameObject val_5 = this.gameObject;
            UnityEngine.Object.Destroy(obj:  0);
            return;
            label_2:
            UnityEngine.Debug.LogError(message:  0);
            return;
            label_11:
            LlockhamIndustries.Decals.PrintSelection val_20 = this.printMethod;
            var val_7 = (val_20 < 4) ? (val_20 + 17) : 0;
            val_20 = val_7 - 17;
            if(val_20 > 3)
            {
                goto label_29;
            }
            
            var val_21 = 25815112 + ((this.printMethod < 0x4 ? (this.printMethod + 17) : 0 - 17)) << 2;
            val_21 = val_21 + 25815112;
            goto (25815112 + ((this.printMethod < 0x4 ? (this.printMethod + 17) : 0 - 17)) << 2 + 25815112);
            label_34:
            this.PrintProjection(Projection:  null, Position:  new UnityEngine.Vector3() {x = val_20, y = val_20, z = val_19}, Rotation:  new UnityEngine.Quaternion() {x = Rotation.x, y = Rotation.y, z = val_19, w = val_18}, Surface:  Surface);
            val_24 = 1;
            if(val_24 >= this.prints.Length)
            {
                goto label_68;
            }
            
            if(val_24 < this.prints.Length)
            {
                goto label_34;
            }
            
            goto label_34;
            label_29:
            if(val_7 == 0)
            {
                goto label_68;
            }
            
            return;
            label_53:
            val_26 = this.printLayers;
            val_27 = 1;
            if(val_27 >= this.printLayers.Length)
            {
                goto label_68;
            }
            
            UnityEngine.LayerMask val_23 = this.printLayers[1];
            UnityEngine.LayerMask val_24 = this.printLayers[1];
            if((UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask())) != ((UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask())) | ))
            {
                goto label_53;
            }
            
            this.PrintProjection(Projection:  this.prints[1], Position:  new UnityEngine.Vector3() {x = val_20, y = val_20, z = val_19}, Rotation:  new UnityEngine.Quaternion() {x = Rotation.x, y = Rotation.y, z = val_19, w = val_18}, Surface:  Surface);
            goto label_53;
            label_67:
            val_23 = 2;
            val_17 = this.printTags;
            if(val_23 >= this.printTags.Length)
            {
                goto label_58;
            }
            
            string val_13 = Surface.tag;
            if((System.String.op_Equality(a:  0, b:  this.printTags[2])) == false)
            {
                goto label_67;
            }
            
            this.PrintProjection(Projection:  this.prints[2], Position:  new UnityEngine.Vector3() {x = val_20, y = val_20, z = val_19}, Rotation:  new UnityEngine.Quaternion() {x = Rotation.x, y = Rotation.y, z = val_19, w = val_18}, Surface:  Surface);
            goto label_67;
            label_58:
            if((( & 1) & 1) == 0)
            {
                    val_17 = this.prints;
                val_25 = val_17[0];
                this.PrintProjection(Projection:  val_25, Position:  new UnityEngine.Vector3() {x = val_20, y = val_20, z = val_19}, Rotation:  new UnityEngine.Quaternion() {x = Rotation.x, y = Rotation.y, z = val_19, w = val_18}, Surface:  Surface);
            }
            
            label_68:
            if(this.destroyOnPrint != false)
            {
                    UnityEngine.GameObject val_16 = Surface.gameObject;
                UnityEngine.Object.Destroy(obj:  0);
            }
            
            this.timeSincePrint = 0f;
            this.lastPrintPos = Position;
            mem[1152921511822336872] = val_20;
            mem[1152921511822336876] = val_19;
        }
        private void PrintProjection(LlockhamIndustries.Decals.ProjectionRenderer Projection, UnityEngine.Vector3 Position, UnityEngine.Quaternion Rotation, UnityEngine.Transform Surface)
        {
            UnityEngine.Transform val_21;
            UnityEngine.Transform val_22;
            bool val_23;
            var val_24;
            var val_25;
            var val_26;
            val_21 = Surface;
            val_22 = this;
            if(0 == Projection)
            {
                    return;
            }
            
            val_23 = this.printBehaviours;
            LlockhamIndustries.Decals.ProjectionRenderer val_4 = this.Pool.Request(Renderer:  Projection, IncludeBehaviours:  (val_23 == true) ? 1 : 0);
            val_4.transform.position = new UnityEngine.Vector3() {x = Position.x, y = Position.y, z = Position.z};
            val_4.transform.rotation = new UnityEngine.Quaternion() {x = Rotation.x, y = Rotation.y, z = Rotation.z, w = Rotation.w};
            if(this.parent != 1)
            {
                    return;
            }
            
            System.Collections.IEnumerator val_7 = val_21.GetEnumerator();
            goto label_11;
            label_28:
            label_11:
            var val_21 = 0;
            val_21 = val_21 + 1;
            val_24 = val_7;
            if(((val_7 & 1) & 1) == 0)
            {
                goto label_45;
            }
            
            var val_22 = 0;
            val_22 = val_22 + 1;
            val_25 = val_7;
            bool val_15 = System.String.op_Equality(a:  0, b:  0.name);
            goto label_28;
            label_45:
            if(val_7 != null)
            {
                    var val_23 = 0;
                val_23 = val_23 + 1;
                val_26 = val_7;
            }
            
            if(0 == ((val_7 != 1) ? (X26) : 0))
            {
                    UnityEngine.GameObject val_18 = new UnityEngine.GameObject(name:  "Projections");
                val_22 = transform;
                val_22.SetParent(parent:  val_21);
            }
            
            val_21 = val_4.transform;
            val_21.SetParent(parent:  val_22);
        }
    
    }

}
