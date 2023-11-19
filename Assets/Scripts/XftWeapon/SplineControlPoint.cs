using UnityEngine;

namespace XftWeapon
{
    public class SplineControlPoint
    {
        // Fields
        public UnityEngine.Vector3 Position;
        public UnityEngine.Vector3 Normal;
        public int ControlPointIndex;
        public int SegmentIndex;
        public float Dist;
        protected XftWeapon.Spline mSpline;
        
        // Properties
        public XftWeapon.SplineControlPoint NextControlPoint { get; }
        public XftWeapon.SplineControlPoint PreviousControlPoint { get; }
        public UnityEngine.Vector3 NextPosition { get; }
        public UnityEngine.Vector3 PreviousPosition { get; }
        public UnityEngine.Vector3 NextNormal { get; }
        public UnityEngine.Vector3 PreviousNormal { get; }
        public bool IsValid { get; }
        
        // Methods
        public SplineControlPoint()
        {
            this.ControlPointIndex = 0;
            this.SegmentIndex = 0;
        }
        public XftWeapon.SplineControlPoint get_NextControlPoint()
        {
            if(this.mSpline != null)
            {
                    return this.mSpline.NextControlPoint(controlpoint:  this);
            }
            
            return this.mSpline.NextControlPoint(controlpoint:  this);
        }
        public XftWeapon.SplineControlPoint get_PreviousControlPoint()
        {
            if(this.mSpline != null)
            {
                    return this.mSpline.PreviousControlPoint(controlpoint:  this);
            }
            
            return this.mSpline.PreviousControlPoint(controlpoint:  this);
        }
        public UnityEngine.Vector3 get_NextPosition()
        {
            if(this.mSpline != null)
            {
                    return this.mSpline.NextPosition(controlpoint:  this);
            }
            
            return this.mSpline.NextPosition(controlpoint:  this);
        }
        public UnityEngine.Vector3 get_PreviousPosition()
        {
            if(this.mSpline != null)
            {
                    return this.mSpline.PreviousPosition(controlpoint:  this);
            }
            
            return this.mSpline.PreviousPosition(controlpoint:  this);
        }
        public UnityEngine.Vector3 get_NextNormal()
        {
            if(this.mSpline != null)
            {
                    return this.mSpline.NextNormal(controlpoint:  this);
            }
            
            return this.mSpline.NextNormal(controlpoint:  this);
        }
        public UnityEngine.Vector3 get_PreviousNormal()
        {
            if(this.mSpline != null)
            {
                    return this.mSpline.PreviousNormal(controlpoint:  this);
            }
            
            return this.mSpline.PreviousNormal(controlpoint:  this);
        }
        public bool get_IsValid()
        {
            return (bool)(this.NextControlPoint != 0) ? 1 : 0;
        }
        private UnityEngine.Vector3 GetNext2Position()
        {
            if(this.NextControlPoint != null)
            {
                    return this.NextPosition;
            }
            
            return this.NextPosition;
        }
        private UnityEngine.Vector3 GetNext2Normal()
        {
            XftWeapon.SplineControlPoint val_1 = this.NextControlPoint;
            if(val_1 == null)
            {
                    return new UnityEngine.Vector3() {x = this.Normal};
            }
            
            return val_1.NextNormal;
        }
        public UnityEngine.Vector3 Interpolate(float localF)
        {
            UnityEngine.Vector3 val_2 = this.PreviousPosition;
            UnityEngine.Vector3 val_3 = this.NextPosition;
            UnityEngine.Vector3 val_4 = this.GetNext2Position();
            UnityEngine.Vector3 val_5 = XftWeapon.Spline.CatmulRom(T0:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, P0:  new UnityEngine.Vector3() {x = this.Position, y = V12.16B, z = V13.16B}, P1:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.z, z = val_4.x}, T1:  new UnityEngine.Vector3() {x = val_4.z, y = UnityEngine.Mathf.Clamp01(value:  localF), z = val_2.y}, f:  ???);
            return new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
        }
        public UnityEngine.Vector3 InterpolateNormal(float localF)
        {
            UnityEngine.Vector3 val_2 = this.PreviousNormal;
            UnityEngine.Vector3 val_3 = this.NextNormal;
            UnityEngine.Vector3 val_4 = this.GetNext2Normal();
            UnityEngine.Vector3 val_5 = XftWeapon.Spline.CatmulRom(T0:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, P0:  new UnityEngine.Vector3() {x = this.Normal, y = V12.16B, z = V13.16B}, P1:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.z, z = val_4.x}, T1:  new UnityEngine.Vector3() {x = val_4.z, y = UnityEngine.Mathf.Clamp01(value:  localF), z = val_2.y}, f:  ???);
            return new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
        }
        public void Init(XftWeapon.Spline owner)
        {
            this.mSpline = owner;
            this.SegmentIndex = 0;
        }
    
    }

}
