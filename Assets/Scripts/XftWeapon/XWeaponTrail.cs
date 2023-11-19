using UnityEngine;

namespace XftWeapon
{
    public class XWeaponTrail : MonoBehaviour
    {
        // Fields
        public static string Version;
        public bool UseWith2D;
        public bool UseWithSRP;
        public string SortingLayerName;
        public int SortingOrder;
        public UnityEngine.Transform PointStart;
        public UnityEngine.Transform PointEnd;
        public int MaxFrame;
        public int Granularity;
        public float Fps;
        public UnityEngine.Color MyColor;
        public UnityEngine.Material MyMaterial;
        protected float mTrailWidth;
        protected XftWeapon.XWeaponTrail.Element mHeadElem;
        protected System.Collections.Generic.List<XftWeapon.XWeaponTrail.Element> mSnapshotList;
        protected XftWeapon.XWeaponTrail.ElementPool mElemPool;
        protected XftWeapon.Spline mSpline;
        protected float mFadeT;
        protected bool mIsFading;
        protected float mFadeTime;
        protected float mElapsedTime;
        protected float mFadeElapsedime;
        protected UnityEngine.GameObject mMeshObj;
        protected XftWeapon.VertexPool mVertexPool;
        protected XftWeapon.VertexPool.VertexSegment mVertexSegment;
        protected bool mInited;
        protected bool mActivated;
        protected UnityEngine.Camera _myCamera;
        
        // Properties
        public float UpdateInterval { get; }
        public UnityEngine.Vector3 CurHeadPos { get; }
        public float TrailWidth { get; }
        public UnityEngine.Camera MyCamera { get; }
        
        // Methods
        public XWeaponTrail()
        {
            this.MaxFrame = 62;
            this.Granularity = 60;
            this.Fps = 60f;
            UnityEngine.Color val_1 = UnityEngine.Color.white;
            this.MyColor = val_1;
            mem[1152921512818559824] = val_1.g;
            mem[1152921512818559828] = val_1.b;
            mem[1152921512818559832] = val_1.a;
            this.mHeadElem = new System.Object();
            this.mSnapshotList = new System.Collections.Generic.List<Element>();
            this.mFadeTime = 1f;
            this.mSpline = new XftWeapon.Spline();
            this.mFadeT = 1f;
        }
        public float get_UpdateInterval()
        {
            float val_1 = this.Fps;
            val_1 = 1f / val_1;
            return (float)val_1;
        }
        public UnityEngine.Vector3 get_CurHeadPos()
        {
            UnityEngine.Vector3 val_1 = this.PointStart.position;
            UnityEngine.Vector3 val_2 = this.PointEnd.position;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            return UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  2f);
        }
        public float get_TrailWidth()
        {
            return (float)this.mTrailWidth;
        }
        public UnityEngine.Camera get_MyCamera()
        {
            UnityEngine.Camera val_4;
            if(0 == this._myCamera)
            {
                    this._myCamera = this.FindMyCamera();
                return val_4;
            }
            
            val_4 = this._myCamera;
            return val_4;
        }
        protected UnityEngine.Camera FindMyCamera()
        {
            var val_11;
            var val_12;
            val_11 = this;
            if(val_3.Length >= 1)
            {
                    var val_11 = 0;
                do
            {
                if((1152921505857659536.cullingMask & (1 << (this.gameObject.layer & 31))) != 0)
            {
                    return (UnityEngine.Camera)val_12;
            }
            
                val_11 = val_11 + 1;
            }
            while(val_11 < (long)val_3.Length);
            
            }
            
            int val_9 = this.gameObject.layer;
            val_11 = 0 + "can\'t find proper camera for layer:"("can\'t find proper camera for layer:");
            UnityEngine.Debug.LogError(message:  0);
            val_12 = 0;
            return (UnityEngine.Camera)val_12;
        }
        public void Init()
        {
            if(this.mInited == true)
            {
                    return;
            }
            
            this.mElemPool = new XWeaponTrail.ElementPool(preCount:  this.MaxFrame);
            UnityEngine.Vector3 val_2 = this.PointStart.position;
            UnityEngine.Vector3 val_3 = this.PointEnd.position;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            this.mTrailWidth = val_4.x;
            this.InitMeshObj();
            this.InitOriginalElements();
            this.InitSpline();
            this.mInited = true;
        }
        public void Activate()
        {
            var val_14;
            if(this.mActivated != false)
            {
                    return;
            }
            
            this.Init();
            this.mActivated = true;
            this.gameObject.SetActive(value:  true);
            this.mFadeElapsedime = 0f;
            this.mIsFading = false;
            this.mFadeTime = 1f;
            this.mElapsedTime = 0f;
            this.mFadeT = 1f;
            val_14 = 0;
            goto label_3;
            label_26:
            val_14 = 1;
            mem2[0] = ???;
            mem2[0] = ???;
            mem2[0] = ???;
            label_3:
            if(val_14 >= this.mSnapshotList.Count)
            {
                goto label_5;
            }
            
            Element val_3 = this.mSnapshotList.Item[1];
            UnityEngine.Vector3 val_4 = this.PointStart.position;
            val_3.PointStart = val_4;
            mem2[0] = val_4.y;
            mem2[0] = val_4.z;
            Element val_5 = this.mSnapshotList.Item[1];
            UnityEngine.Vector3 val_6 = this.PointEnd.position;
            val_5.PointEnd = val_6;
            mem2[0] = val_6.y;
            mem2[0] = val_6.z;
            XftWeapon.SplineControlPoint val_7 = this.mSpline.mControlPoints.Item[1];
            UnityEngine.Vector3 val_9 = this.mSnapshotList.Item[1].Pos;
            val_7.Position = val_9;
            mem2[0] = val_9.y;
            mem2[0] = val_9.z;
            Element val_11 = this.mSnapshotList.Item[1];
            Element val_12 = this.mSnapshotList.Item[1];
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_11.PointEnd, y = val_9.y, z = val_9.z}, b:  new UnityEngine.Vector3() {x = val_12.PointStart, y = V12.16B, z = V11.16B});
            if(this.mSpline.mControlPoints.Item[1] != null)
            {
                goto label_26;
            }
            
            goto label_26;
            label_5:
            this.RefreshSpline();
            this.UpdateVertex();
        }
        public void Deactivate()
        {
            this.mActivated = false;
            this.gameObject.SetActive(value:  false);
            this.mVertexPool.SetMeshObjectActive(flag:  false);
        }
        public void StopSmoothly(float fadeTime)
        {
            this.mIsFading = true;
            this.mFadeTime = fadeTime;
        }
        private void OnEnable()
        {
            object val_7;
            CameraCallback val_8;
            CameraCallback val_9;
            val_7 = this;
            this.Activate();
            if(this.UseWithSRP == true)
            {
                    return;
            }
            
            Camera.CameraCallback val_1 = new Camera.CameraCallback(object:  this, method:  public System.Void XftWeapon.XWeaponTrail::MyPostRender(UnityEngine.Camera cam));
            System.Delegate val_2 = System.Delegate.Combine(a:  0, b:  UnityEngine.Camera.onPostRender);
            val_8 = 0;
            if(val_2 != null)
            {
                    val_8 = val_2;
                if(null != null)
            {
                    val_8 = 0;
            }
            
            }
            
            UnityEngine.Camera.onPostRender = val_8;
            Camera.CameraCallback val_4 = new Camera.CameraCallback(object:  this, method:  public System.Void XftWeapon.XWeaponTrail::MyPreRender(UnityEngine.Camera cam));
            System.Delegate val_5 = System.Delegate.Combine(a:  0, b:  UnityEngine.Camera.onPreRender);
            val_9 = 0;
            if(val_5 != null)
            {
                    val_9 = val_5;
                if(null != null)
            {
                    val_9 = 0;
            }
            
            }
            
            UnityEngine.Camera.onPreRender = val_9;
        }
        private void OnDisable()
        {
            object val_7;
            CameraCallback val_8;
            CameraCallback val_9;
            val_7 = this;
            this.Deactivate();
            if(this.UseWithSRP == true)
            {
                    return;
            }
            
            Camera.CameraCallback val_1 = new Camera.CameraCallback(object:  this, method:  public System.Void XftWeapon.XWeaponTrail::MyPostRender(UnityEngine.Camera cam));
            System.Delegate val_2 = System.Delegate.Remove(source:  0, value:  UnityEngine.Camera.onPostRender);
            val_8 = 0;
            if(val_2 != null)
            {
                    val_8 = val_2;
                if(null != null)
            {
                    val_8 = 0;
            }
            
            }
            
            UnityEngine.Camera.onPostRender = val_8;
            Camera.CameraCallback val_4 = new Camera.CameraCallback(object:  this, method:  public System.Void XftWeapon.XWeaponTrail::MyPreRender(UnityEngine.Camera cam));
            System.Delegate val_5 = System.Delegate.Remove(source:  0, value:  UnityEngine.Camera.onPreRender);
            val_9 = 0;
            if(val_5 != null)
            {
                    val_9 = val_5;
                if(null != null)
            {
                    val_9 = 0;
            }
            
            }
            
            UnityEngine.Camera.onPreRender = val_9;
        }
        private void Update()
        {
            if(this.UseWithSRP == false)
            {
                    return;
            }
            
            this.MyPreRender(cam:  this.MyCamera);
        }
        private void LateUpdate()
        {
            if(this.UseWithSRP == false)
            {
                    return;
            }
            
            this.MyPostRender(cam:  this.MyCamera);
        }
        public void MyPreRender(UnityEngine.Camera cam)
        {
            var val_5;
            if(this.mInited == false)
            {
                    return;
            }
            
            val_5 = this.MyCamera;
            if(0 != cam)
            {
                    return;
            }
            
            this.UpdateHeadElem();
            float val_4 = UnityEngine.Time.deltaTime;
            float val_5 = this.Fps;
            val_4 = this.mElapsedTime + val_4;
            this.mElapsedTime = val_4;
            val_5 = 1f / val_5;
            if(val_4 > val_5)
            {
                    this.mElapsedTime = 0f;
                this.RecordCurElem();
            }
            
            this.RefreshSpline();
            this.UpdateFade();
            this.UpdateVertex();
        }
        public void MyPostRender(UnityEngine.Camera cam)
        {
            var val_4;
            if(this.mInited == false)
            {
                    return;
            }
            
            val_4 = this.MyCamera;
            if(0 != cam)
            {
                    return;
            }
            
            this.mVertexPool.SetMeshObjectActive(flag:  true);
            this.mVertexPool.LateUpdate();
        }
        private void OnDestroy()
        {
            if(this.mInited == false)
            {
                    return;
            }
            
            if(this.mVertexPool == null)
            {
                    return;
            }
            
            this.mVertexPool.Destroy();
        }
        private void Start()
        {
            this.mInited = false;
            this.Init();
        }
        private void OnDrawGizmos()
        {
            UnityEngine.Transform val_12;
            float val_13;
            var val_14;
            val_12 = this;
            if(0 == this.PointEnd)
            {
                    return;
            }
            
            if(0 == this.PointStart)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_5 = this.PointStart.position;
            UnityEngine.Vector3 val_6 = this.PointEnd.position;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            val_13 = val_7.x;
            val_14 = null;
            val_14 = null;
            if(val_13 < 0)
            {
                    return;
            }
            
            UnityEngine.Color val_8 = UnityEngine.Color.red;
            UnityEngine.Gizmos.color = new UnityEngine.Color() {r = val_8.r, g = val_8.g, b = val_8.b, a = val_8.a};
            UnityEngine.Vector3 val_9 = this.PointStart.position;
            val_13 = val_13 * 0.04f;
            UnityEngine.Gizmos.DrawSphere(center:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, radius:  val_13);
            UnityEngine.Color val_10 = UnityEngine.Color.blue;
            UnityEngine.Gizmos.color = new UnityEngine.Color() {r = val_10.r, g = val_10.g, b = val_10.b, a = val_10.a};
            val_12 = this.PointEnd;
            UnityEngine.Vector3 val_11 = val_12.position;
            UnityEngine.Gizmos.DrawSphere(center:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, radius:  val_13);
        }
        private void InitSpline()
        {
            int val_6 = this.Granularity;
            this.mSpline.Granularity = val_6;
            this.mSpline.Clear();
            if(this.MaxFrame < 1)
            {
                    return;
            }
            
            var val_6 = 0;
            do
            {
                UnityEngine.Vector3 val_1 = this.CurHeadPos;
                UnityEngine.Vector3 val_2 = this.PointStart.position;
                val_6 = this.PointEnd;
                UnityEngine.Vector3 val_3 = val_6.position;
                UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
                XftWeapon.SplineControlPoint val_5 = this.mSpline.AddControlPoint(pos:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, up:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
                val_6 = val_6 + 1;
            }
            while(val_6 < this.MaxFrame);
        
        }
        private void RefreshSpline()
        {
            goto label_1;
            label_18:
            0 = 1;
            mem2[0] = ???;
            mem2[0] = ???;
            mem2[0] = ???;
            label_1:
            if(0 >= this.mSnapshotList.Count)
            {
                goto label_4;
            }
            
            XftWeapon.SplineControlPoint val_2 = this.mSpline.mControlPoints.Item[1];
            UnityEngine.Vector3 val_4 = this.mSnapshotList.Item[1].Pos;
            val_2.Position = val_4;
            mem2[0] = val_4.y;
            mem2[0] = val_4.z;
            Element val_6 = this.mSnapshotList.Item[1];
            Element val_7 = this.mSnapshotList.Item[1];
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_6.PointEnd, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = val_7.PointStart, y = V12.16B, z = V11.16B});
            if(this.mSpline.mControlPoints.Item[1] != null)
            {
                goto label_18;
            }
            
            goto label_18;
            label_4:
            this.mSpline.RefreshSpline();
        }
        private void UpdateVertex()
        {
            var val_19;
            var val_20;
            val_19 = 0;
            val_20 = 0;
            goto label_2;
            label_38:
            var val_1 = X24 + ((this.mVertexSegment) << 3);
            val_20 = 1;
            val_19 = 3;
            mem2[0] = 1065353216;
            mem2[0] = ???;
            label_2:
            if(val_20 >= this.Granularity)
            {
                goto label_4;
            }
            
            float val_18 = this.mFadeT;
            float val_2 = 1f / (float)this.Granularity;
            val_18 = val_18 * val_2;
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.zero;
            UnityEngine.Vector3 val_4 = this.mSpline.InterpolateByLen(tl:  val_18);
            UnityEngine.Vector3 val_5 = this.mSpline.InterpolateNormalByLen(tl:  val_18);
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, d:  this.mTrailWidth);
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, d:  0.5f);
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, d:  this.mTrailWidth);
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, d:  0.5f);
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
            var val_13 = this.mVertexSegment.Pool.Vertices + (((long)val_19 + this.mVertexSegment.VertStart) * 12);
            mem2[0] = val_8.x;
            mem2[0] = val_8.y;
            mem2[0] = val_8.z;
            this.mVertexSegment.Pool.Colors[(long)val_19 + this.mVertexSegment.VertStart] = this.MyColor;
            this.mVertexSegment.Pool.UVs[(long)val_19 + this.mVertexSegment.VertStart] = 0;
            this.mVertexSegment.Pool.UVs[(long)val_19 + this.mVertexSegment.VertStart] = val_2;
            int val_14 = val_19 + this.mVertexSegment.VertStart;
            val_14 = val_14 + 1;
            var val_15 = this.mVertexSegment.Pool.Vertices + ((long)val_14 * 12);
            mem2[0] = val_4.x;
            mem2[0] = val_4.y;
            mem2[0] = val_4.z;
            this.mVertexSegment.Pool.Colors[(long)val_14] = this.MyColor;
            this.mVertexSegment.Pool.Colors[(long)val_14] = 12;
            this.mVertexSegment.Pool.Colors[(long)val_14] = this.Granularity;
            this.mVertexSegment.Pool.Colors[(long)val_14] = new UnityEngine.Color();
            this.mVertexSegment.Pool.UVs[(long)val_14] = 1056964608;
            this.mVertexSegment.Pool.UVs[(long)val_14] = val_2;
            int val_16 = val_19 + this.mVertexSegment.VertStart;
            val_16 = val_16 + 2;
            var val_17 = this.mVertexSegment.Pool.Vertices + ((long)val_16 * 12);
            mem2[0] = val_11.x;
            mem2[0] = val_11.y;
            mem2[0] = val_11.z;
            this.mVertexSegment.Pool.Colors[(long)val_16] = this.MyColor;
            this.mVertexSegment.Pool.Colors[(long)val_16] = this.MyColor;
            this.mVertexSegment.Pool.Colors[(long)val_16] = this.Granularity;
            this.mVertexSegment.Pool.Colors[(long)val_16] = new UnityEngine.Color();
            if((long)val_16 < this.mVertexSegment.Pool.UVs.Length)
            {
                goto label_38;
            }
            
            goto label_38;
            label_4:
            this.mVertexSegment.Pool.UVChanged = true;
            this.mVertexSegment.Pool.VertChanged = true;
            this.mVertexSegment.Pool.ColorChanged = true;
        }
        private void UpdateIndices()
        {
            VertexPool.VertexSegment val_6;
            int val_7;
            int val_8;
            int val_19 = this.Granularity;
            val_19 = val_19 - 1;
            if(val_19 < 1)
            {
                goto label_1;
            }
            
            var val_20 = 0;
            goto label_44;
            label_7:
            val_6 = this.mVertexSegment;
            if(val_6 == null)
            {
                goto label_3;
            }
            
            val_7 = mem[X21 + 16];
            val_7 = X21 + 16;
            goto label_4;
            label_44:
            val_6 = this.mVertexSegment;
            if(val_6 == null)
            {
                goto label_5;
            }
            
            val_8 = this.mVertexSegment.VertStart + (val_20 + 0);
            goto label_6;
            label_5:
            val_8 = this.mVertexSegment.VertStart + (val_20 + 0);
            if(this.mVertexSegment == null)
            {
                goto label_7;
            }
            
            val_6 = this.mVertexSegment;
            label_6:
            val_7 = this.mVertexSegment.VertStart;
            label_4:
            var val_3 = val_20 + 1;
            int val_5 = val_7 + (val_3 + (val_3 << 1));
            val_20 = this.mVertexSegment.IndexStart + (val_20 * 12);
            this.mVertexSegment.Pool.Indices[(long)val_20] = val_5;
            int val_7 = val_5 + 1;
            this.mVertexSegment.Pool.Indices[(long)val_20 + 1] = val_7;
            this.mVertexSegment.Pool.Indices[(long)val_20 + 2] = val_8;
            this.mVertexSegment.Pool.Indices[(long)val_20 + 3] = val_7;
            int val_11 = val_8 + 1;
            this.mVertexSegment.Pool.Indices[(long)val_20 + 4] = val_11;
            this.mVertexSegment.Pool.Indices[(long)val_20 + 5] = val_8;
            this.mVertexSegment.Pool.Indices[(long)val_20 + 6] = val_7;
            val_5 = val_5 + 2;
            this.mVertexSegment.Pool.Indices[(long)val_20 + 7] = val_5;
            this.mVertexSegment.Pool.Indices[(long)val_20 + 8] = val_11;
            this.mVertexSegment.Pool.Indices[(long)val_20 + 9] = val_5;
            val_8 = val_8 + 2;
            this.mVertexSegment.Pool.Indices[(long)val_20 + 10] = val_8;
            this.mVertexSegment.Pool.Indices[(long)val_20 + 11] = val_11;
            int val_21 = this.Granularity;
            val_21 = val_21 - 1;
            if(val_3 < val_21)
            {
                goto label_44;
            }
            
            label_1:
            this.mVertexSegment.Pool.IndiceChanged = true;
            return;
            label_3:
        }
        private void UpdateHeadElem()
        {
            Element val_1 = this.mSnapshotList.Item[0];
            UnityEngine.Vector3 val_2 = this.PointStart.position;
            val_1.PointStart = val_2;
            mem2[0] = val_2.y;
            mem2[0] = val_2.z;
            Element val_3 = this.mSnapshotList.Item[0];
            UnityEngine.Vector3 val_4 = this.PointEnd.position;
            val_3.PointEnd = val_4;
            mem2[0] = val_4.y;
            mem2[0] = val_4.z;
        }
        private void UpdateFade()
        {
            if(this.mIsFading == false)
            {
                    return;
            }
            
            float val_1 = UnityEngine.Time.deltaTime;
            val_1 = this.mFadeElapsedime + val_1;
            this.mFadeElapsedime = val_1;
            val_1 = val_1 / this.mFadeTime;
            val_1 = 1f - val_1;
            this.mFadeT = val_1;
            if(val_1 >= 0)
            {
                    return;
            }
            
            this.Deactivate();
        }
        private void RecordCurElem()
        {
            System.Collections.Generic.List<Element> val_12;
            System.Collections.Generic.List<Element> val_13;
            var val_14;
            var val_15;
            UnityEngine.Vector3 val_2 = this.PointStart.position;
            val_1.PointStart = val_2;
            mem2[0] = val_2.y;
            mem2[0] = val_2.z;
            UnityEngine.Vector3 val_3 = this.PointEnd.position;
            val_1.PointEnd = val_3;
            mem2[0] = val_3.y;
            mem2[0] = val_3.z;
            val_12 = this.mSnapshotList;
            if(val_12.Count >= this.MaxFrame)
            {
                    val_13 = this.mSnapshotList;
                if(val_13 != null)
            {
                    val_14 = val_13.Count;
            }
            else
            {
                    val_14 = 0.Count;
                val_13 = 0;
            }
            
                this.mElemPool.Release(element:  val_13.Item[val_14 - 1]);
                val_12 = this.mSnapshotList;
                if(val_12 != null)
            {
                    val_15 = val_12.Count;
            }
            else
            {
                    val_15 = 0.Count;
                val_12 = 0;
            }
            
                val_12.RemoveAt(index:  val_15 - 1);
            }
            
            this.mSnapshotList.Insert(index:  1, item:  this.mElemPool.Get());
        }
        private void InitOriginalElements()
        {
            this.mSnapshotList.Clear();
            UnityEngine.Vector3 val_1 = this.PointStart.position;
            UnityEngine.Vector3 val_2 = this.PointEnd.position;
            typeof(XWeaponTrail.Element).__il2cppRuntimeField_10 = val_1.x;
            typeof(XWeaponTrail.Element).__il2cppRuntimeField_14 = val_1.y;
            typeof(XWeaponTrail.Element).__il2cppRuntimeField_18 = val_1.z;
            typeof(XWeaponTrail.Element).__il2cppRuntimeField_1C = val_2.x;
            typeof(XWeaponTrail.Element).__il2cppRuntimeField_20 = val_2.y;
            typeof(XWeaponTrail.Element).__il2cppRuntimeField_24 = val_2.z;
            this.mSnapshotList.Add(item:  new System.Object());
            UnityEngine.Vector3 val_4 = this.PointStart.position;
            UnityEngine.Vector3 val_5 = this.PointEnd.position;
            typeof(XWeaponTrail.Element).__il2cppRuntimeField_10 = val_4.x;
            typeof(XWeaponTrail.Element).__il2cppRuntimeField_14 = val_4.y;
            typeof(XWeaponTrail.Element).__il2cppRuntimeField_18 = val_4.z;
            typeof(XWeaponTrail.Element).__il2cppRuntimeField_1C = val_5.x;
            typeof(XWeaponTrail.Element).__il2cppRuntimeField_20 = val_5.y;
            typeof(XWeaponTrail.Element).__il2cppRuntimeField_24 = val_5.z;
            this.mSnapshotList.Add(item:  new System.Object());
        }
        private void InitMeshObj()
        {
            this.mVertexPool = new XftWeapon.VertexPool(material:  this.MyMaterial, owner:  this);
            var val_5 = 12;
            val_5 = this.Granularity * val_5;
            this.mVertexSegment = GetVertices(vcount:  this.Granularity + (this.Granularity << 1), icount:  val_5 - 12);
            this.UpdateIndices();
        }
        private static XWeaponTrail()
        {
            XftWeapon.XWeaponTrail.Version = "1.4.3";
        }
    
    }

}
