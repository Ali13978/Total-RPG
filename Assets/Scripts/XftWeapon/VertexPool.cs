using UnityEngine;

namespace XftWeapon
{
    public class VertexPool
    {
        // Fields
        public UnityEngine.Vector3[] Vertices;
        public int[] Indices;
        public UnityEngine.Vector2[] UVs;
        public UnityEngine.Color[] Colors;
        public bool IndiceChanged;
        public bool ColorChanged;
        public bool UVChanged;
        public bool VertChanged;
        public bool UV2Changed;
        protected int VertexTotal;
        protected int VertexUsed;
        protected int IndexTotal;
        protected int IndexUsed;
        public bool FirstUpdate;
        protected bool VertCountChanged;
        public const int BlockSize = 108;
        public float BoundsScheduleTime;
        public float ElapsedTime;
        protected XftWeapon.XWeaponTrail _owner;
        protected UnityEngine.MeshFilter _meshFilter;
        protected UnityEngine.Mesh _mesh2d;
        protected UnityEngine.Material _material;
        
        // Properties
        public UnityEngine.Mesh MyMesh { get; }
        
        // Methods
        public VertexPool(UnityEngine.Material material, XftWeapon.XWeaponTrail owner)
        {
            XftWeapon.XWeaponTrail val_3 = owner;
            this.FirstUpdate = true;
            this.BoundsScheduleTime = 1f;
            this.VertexTotal = 0;
            this.VertexUsed = 0;
            this.VertCountChanged = false;
            this._owner = val_3;
            if(((owner.UseWith2D & 255) != true) && (owner.UseWith2D < true))
            {
                    UnityEngine.Mesh val_2 = null;
                val_3 = val_2;
                val_2 = new UnityEngine.Mesh();
                this._mesh2d = val_3;
            }
            else
            {
                    this.CreateMeshObj(owner:  val_3 = owner, material:  material);
            }
            
            this._material = material;
            this.InitArrays();
            this.IndiceChanged = true;
            this.ColorChanged = true;
            this.UVChanged = true;
            this.VertChanged = true;
            this.UV2Changed = true;
        }
        public UnityEngine.Mesh get_MyMesh()
        {
            UnityEngine.Mesh val_6;
            if(this._owner.UseWith2D != true)
            {
                    if(this._owner.UseWithSRP == false)
            {
                goto label_4;
            }
            
            }
            
            val_6 = 0;
            if(0 == this._meshFilter)
            {
                    return val_6;
            }
            
            val_6 = 0;
            if(0 == this._meshFilter.gameObject)
            {
                    return val_6;
            }
            
            if(this._meshFilter != null)
            {
                    return this._meshFilter.sharedMesh;
            }
            
            return this._meshFilter.sharedMesh;
            label_4:
            val_6 = this._mesh2d;
            return val_6;
        }
        public void RecalculateBounds()
        {
            this.MyMesh.RecalculateBounds();
        }
        public void SetMeshObjectActive(bool flag)
        {
            if(0 == this._meshFilter)
            {
                    return;
            }
            
            this._meshFilter.gameObject.SetActive(value:  flag);
        }
        private void CreateMeshObj(XftWeapon.XWeaponTrail owner, UnityEngine.Material material)
        {
            UnityEngine.MeshFilter val_23;
            string val_1 = material.name;
            UnityEngine.GameObject val_3 = new UnityEngine.GameObject(name:  0 + "_XWeaponTrailMesh:|material:"("_XWeaponTrailMesh:|material:"));
            int val_5 = owner.gameObject.layer;
            if(null != 0)
            {
                    layer = val_5;
                UnityEngine.MeshFilter val_6 = AddComponent<UnityEngine.MeshFilter>();
                UnityEngine.MeshRenderer val_7 = AddComponent<UnityEngine.MeshRenderer>();
            }
            else
            {
                    layer = val_5;
                UnityEngine.MeshFilter val_8 = AddComponent<UnityEngine.MeshFilter>();
                UnityEngine.MeshRenderer val_9 = AddComponent<UnityEngine.MeshRenderer>();
            }
            
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.zero;
            transform.position = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
            UnityEngine.Quaternion val_13 = UnityEngine.Quaternion.identity;
            transform.rotation = new UnityEngine.Quaternion() {x = val_13.x, y = val_13.y, z = val_13.z, w = val_13.w};
            UnityEngine.Component val_15 = GetComponent(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_23 = 0;
            if(val_15 != null)
            {
                    val_23 = val_15;
                if(null != null)
            {
                    val_23 = 0;
            }
            
            }
            
            this._meshFilter = val_23;
            UnityEngine.Component val_18 = GetComponent(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            0.shadowCastingMode = 0;
            0.receiveShadows = false;
            0.GetComponent<UnityEngine.Renderer>().sharedMaterial = material;
            0.sortingLayerName = this._owner.SortingLayerName;
            0.sortingOrder = this._owner.SortingOrder;
            this._meshFilter.sharedMesh = new UnityEngine.Mesh();
        }
        public void Destroy()
        {
            if(this._owner.UseWith2D != true)
            {
                    if(this._owner.UseWithSRP == false)
            {
                goto label_4;
            }
            
            }
            
            if(0 == this._meshFilter)
            {
                    return;
            }
            
            UnityEngine.GameObject val_2 = this._meshFilter.gameObject;
            UnityEngine.Object.Destroy(obj:  0);
            return;
            label_4:
            UnityEngine.Object.DestroyImmediate(obj:  0);
        }
        public XftWeapon.VertexPool.VertexSegment GetVertices(int vcount, int icount)
        {
            bool val_14;
            int val_15;
            int val_16;
            int val_17;
            int val_18;
            int val_19;
            val_14 = static_value_02139AC1;
            val_14 = true;
            val_15 = this.VertexTotal;
            if((this.VertexUsed + vcount) < val_15)
            {
                    val_16 = 0;
            }
            else
            {
                    var val_10 = (long)vcount;
                val_10 = val_10 * 1272582903;
                val_10 = val_10 >> 37;
                val_10 = val_10 + (val_10 >> 63);
                val_15 = vcount - (val_10 * 108);
                val_16 = (vcount + 108) - val_15;
            }
            
            val_17 = this.IndexUsed + icount;
            if(val_17 < this.IndexTotal)
            {
                    val_18 = 0;
            }
            else
            {
                    var val_11 = (long)icount;
                val_11 = val_11 * 1272582903;
                val_11 = val_11 >> 37;
                val_11 = val_11 + (val_11 >> 63);
                val_11 = icount - (val_11 * 108);
                val_18 = (icount + 108) - val_11;
            }
            
            val_19 = this.VertexUsed + vcount;
            this.IndexUsed = val_17;
            this.VertexUsed = val_19;
            if((val_18 | val_16) != 0)
            {
                    this.EnlargeArrays(count:  val_16, icount:  val_18);
                int val_12 = this.VertexTotal;
                val_19 = this.VertexUsed;
                val_17 = this.IndexUsed;
                val_12 = val_12 + val_16;
                this.VertexTotal = val_12;
                this.IndexTotal = this.IndexTotal + val_18;
            }
            
            object val_9 = null;
            val_17 = val_17 - icount;
            val_9 = new System.Object();
            typeof(VertexPool.VertexSegment).__il2cppRuntimeField_10 = val_19 - vcount;
            typeof(VertexPool.VertexSegment).__il2cppRuntimeField_18 = vcount;
            typeof(VertexPool.VertexSegment).__il2cppRuntimeField_1C = icount;
            typeof(VertexPool.VertexSegment).__il2cppRuntimeField_20 = this;
            typeof(VertexPool.VertexSegment).__il2cppRuntimeField_14 = val_17;
            return (VertexSegment)val_9;
        }
        protected void InitArrays()
        {
            this.Vertices = null;
            this.UVs = null;
            this.Colors = null;
            this.Indices = null;
            this.VertexTotal = 4;
            this.IndexTotal = 6;
        }
        public void EnlargeArrays(int count, int icount)
        {
            int val_4 = icount;
            int val_3 = count;
            int val_1 = this.Vertices.Length + val_3;
            this.Vertices = null;
            this.Vertices.CopyTo(array:  null, index:  0);
            int val_2 = this.UVs.Length + val_3;
            this.UVs = null;
            this.UVs.CopyTo(array:  null, index:  0);
            val_3 = this.Colors.Length + val_3;
            this.Colors = null;
            this.Colors.CopyTo(array:  null, index:  0);
            val_4 = this.Indices.Length + val_4;
            this.Indices = null;
            this.Indices.CopyTo(array:  null, index:  0);
            this.IndiceChanged = true;
            this.ColorChanged = true;
            this.UVChanged = true;
            this.VertChanged = true;
            this.VertCountChanged = true;
            this.UV2Changed = true;
        }
        public void LateUpdate()
        {
            var val_14;
            var val_15;
            UnityEngine.Material val_16;
            var val_17;
            UnityEngine.Camera val_25;
            bool val_26;
            float val_27;
            float val_28;
            float val_29;
            var val_30;
            val_25 = this;
            if(0 == this.MyMesh)
            {
                    return;
            }
            
            if(this.VertCountChanged != false)
            {
                    this.MyMesh.Clear();
            }
            
            val_26 = this.MyMesh;
            val_26.vertices = this.Vertices;
            if(this.UVChanged != false)
            {
                    val_26 = this.MyMesh;
                val_26.uv = this.UVs;
            }
            
            if(this.ColorChanged != false)
            {
                    val_26 = this.MyMesh;
                val_26.colors = this.Colors;
            }
            
            if(this.IndiceChanged != false)
            {
                    val_26 = this.MyMesh;
                val_26.triangles = this.Indices;
            }
            
            val_27 = this.ElapsedTime;
            val_28 = val_27 + UnityEngine.Time.deltaTime;
            this.ElapsedTime = val_28;
            if(val_28 <= this.BoundsScheduleTime)
            {
                    if(this.FirstUpdate == false)
            {
                goto label_14;
            }
            
            }
            
            this.RecalculateBounds();
            val_29 = this.BoundsScheduleTime;
            val_28 = 0f;
            this.ElapsedTime = 0f;
            goto label_15;
            label_14:
            val_29 = this.BoundsScheduleTime;
            label_15:
            if(val_28 > val_29)
            {
                    this.FirstUpdate = false;
            }
            
            this.VertCountChanged = false;
            mem[1152921512817915476] = 0;
            this.IndiceChanged = false;
            this.ColorChanged = false;
            this.UVChanged = false;
            mem[1152921512817915475] = 0;
            if(this._owner.UseWith2D == true)
            {
                    return;
            }
            
            if(this._owner.UseWithSRP == true)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.zero;
            UnityEngine.Quaternion val_11 = UnityEngine.Quaternion.identity;
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.one;
            val_27 = val_12.y;
            UnityEngine.Matrix4x4 val_13 = UnityEngine.Matrix4x4.TRS(pos:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, q:  new UnityEngine.Quaternion() {x = val_11.x, y = val_11.y, z = val_11.z, w = val_11.w}, s:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.z});
            val_30 = 0;
            goto label_27;
            label_31:
            bool val_18 = val_26.SetPass(pass:  0);
            val_30 = 1;
            label_27:
            if(val_30 >= this._material.passCount)
            {
                goto label_29;
            }
            
            if(this._material != null)
            {
                goto label_31;
            }
            
            goto label_31;
            label_29:
            val_26 = this._owner.UseWithSRP;
            UnityEngine.Mesh val_20 = this.MyMesh;
            if(val_26 != false)
            {
                    UnityEngine.Matrix4x4 val_21 = UnityEngine.Matrix4x4.identity;
                val_26 = this._material;
                val_25 = this._owner.gameObject.layer;
                UnityEngine.Graphics.DrawMesh(mesh:  0, matrix:  new UnityEngine.Matrix4x4() {m00 = val_20, m10 = val_20, m20 = val_20, m30 = val_20, m01 = val_20, m11 = val_20, m21 = val_20, m31 = val_20, m02 = val_20, m12 = val_20, m22 = val_20, m32 = val_20, m03 = val_20, m13 = val_20, m23 = val_20, m33 = val_20}, material:  val_16, layer:  val_26, camera:  val_25, submeshIndex:  0, properties:  0, castShadows:  false, receiveShadows:  false);
                return;
            }
            
            val_14 = val_14;
            val_15 = val_15;
            val_16 = val_16;
            val_17 = val_17;
            UnityEngine.Graphics.DrawMeshNow(mesh:  0, matrix:  new UnityEngine.Matrix4x4() {m00 = val_20, m10 = val_20, m20 = val_20, m30 = val_20, m01 = val_20, m11 = val_20, m21 = val_20, m31 = val_20, m02 = val_20, m12 = val_20, m22 = val_20, m32 = val_20, m03 = val_20, m13 = val_20, m23 = val_20, m33 = val_20});
        }
    
    }

}
