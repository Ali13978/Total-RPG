using UnityEngine;

namespace XftWeapon
{
    public class Spline
    {
        // Fields
        private System.Collections.Generic.List<XftWeapon.SplineControlPoint> mControlPoints;
        private System.Collections.Generic.List<XftWeapon.SplineControlPoint> mSegments;
        public int Granularity;
        
        // Properties
        public XftWeapon.SplineControlPoint Item { get; }
        public System.Collections.Generic.List<XftWeapon.SplineControlPoint> Segments { get; }
        public System.Collections.Generic.List<XftWeapon.SplineControlPoint> ControlPoints { get; }
        
        // Methods
        public Spline()
        {
            this.mControlPoints = new System.Collections.Generic.List<XftWeapon.SplineControlPoint>();
            this.Granularity = 20;
            this.mSegments = new System.Collections.Generic.List<XftWeapon.SplineControlPoint>();
        }
        public XftWeapon.SplineControlPoint get_Item(int index)
        {
            System.Collections.Generic.List<XftWeapon.SplineControlPoint> val_3;
            var val_4;
            if((index & 2147483648) == 0)
            {
                    val_3 = this.mSegments;
                if(val_3.Count > index)
            {
                    XftWeapon.SplineControlPoint val_2 = this.mSegments.Item[index];
                return (XftWeapon.SplineControlPoint)val_4;
            }
            
            }
            
            val_4 = 0;
            return (XftWeapon.SplineControlPoint)val_4;
        }
        public System.Collections.Generic.List<XftWeapon.SplineControlPoint> get_Segments()
        {
            return (System.Collections.Generic.List<XftWeapon.SplineControlPoint>)this.mSegments;
        }
        public System.Collections.Generic.List<XftWeapon.SplineControlPoint> get_ControlPoints()
        {
            return (System.Collections.Generic.List<XftWeapon.SplineControlPoint>)this.mControlPoints;
        }
        public XftWeapon.SplineControlPoint NextControlPoint(XftWeapon.SplineControlPoint controlpoint)
        {
            System.Collections.Generic.List<XftWeapon.SplineControlPoint> val_5;
            System.Collections.Generic.List<XftWeapon.SplineControlPoint> val_6;
            var val_7;
            val_5 = this;
            val_6 = this.mControlPoints;
            if(val_6.Count != 0)
            {
                    val_6 = this.mControlPoints;
                int val_2 = controlpoint.ControlPointIndex + 1;
                if(val_2 < val_6.Count)
            {
                    val_5 = this.mControlPoints;
                XftWeapon.SplineControlPoint val_4 = val_5.Item[val_2];
                return (XftWeapon.SplineControlPoint)val_7;
            }
            
            }
            
            val_7 = 0;
            return (XftWeapon.SplineControlPoint)val_7;
        }
        public XftWeapon.SplineControlPoint PreviousControlPoint(XftWeapon.SplineControlPoint controlpoint)
        {
            System.Collections.Generic.List<XftWeapon.SplineControlPoint> val_4;
            var val_5;
            val_4 = this;
            if(this.mControlPoints.Count != 0)
            {
                    int val_2 = controlpoint.ControlPointIndex - 1;
                if((val_2 & 2147483648) == 0)
            {
                    val_4 = this.mControlPoints;
                XftWeapon.SplineControlPoint val_3 = val_4.Item[val_2];
                return (XftWeapon.SplineControlPoint)val_5;
            }
            
            }
            
            val_5 = 0;
            return (XftWeapon.SplineControlPoint)val_5;
        }
        public UnityEngine.Vector3 NextPosition(XftWeapon.SplineControlPoint controlpoint)
        {
            if((this.NextControlPoint(controlpoint:  controlpoint)) == null)
            {
                    return new UnityEngine.Vector3() {x = controlpoint.Position};
            }
            
            return new UnityEngine.Vector3() {x = controlpoint.Position};
        }
        public UnityEngine.Vector3 PreviousPosition(XftWeapon.SplineControlPoint controlpoint)
        {
            if((this.PreviousControlPoint(controlpoint:  controlpoint)) == null)
            {
                    return new UnityEngine.Vector3() {x = controlpoint.Position};
            }
            
            return new UnityEngine.Vector3() {x = controlpoint.Position};
        }
        public UnityEngine.Vector3 PreviousNormal(XftWeapon.SplineControlPoint controlpoint)
        {
            if((this.PreviousControlPoint(controlpoint:  controlpoint)) == null)
            {
                    return new UnityEngine.Vector3() {x = controlpoint.Normal};
            }
            
            return new UnityEngine.Vector3() {x = controlpoint.Normal};
        }
        public UnityEngine.Vector3 NextNormal(XftWeapon.SplineControlPoint controlpoint)
        {
            if((this.NextControlPoint(controlpoint:  controlpoint)) == null)
            {
                    return new UnityEngine.Vector3() {x = controlpoint.Normal};
            }
            
            return new UnityEngine.Vector3() {x = controlpoint.Normal};
        }
        public XftWeapon.SplineControlPoint LenToSegment(float t, out float localF)
        {
            System.Collections.Generic.List<XftWeapon.SplineControlPoint> val_11;
            var val_12;
            System.Collections.Generic.List<XftWeapon.SplineControlPoint> val_13;
            var val_14;
            var val_15;
            float val_16;
            float val_17;
            float val_18;
            var val_19;
            val_11 = this.mSegments;
            float val_12 = UnityEngine.Mathf.Clamp01(value:  t);
            if(val_11 != null)
            {
                    val_12 = val_11.Count;
            }
            else
            {
                    val_12 = 0.Count;
                val_11 = 0;
            }
            
            XftWeapon.SplineControlPoint val_5 = val_11.Item[val_12 - 1];
            val_13 = 0;
            val_12 = val_12 * val_5.Dist;
            goto label_6;
            label_11:
            val_13 = 1;
            label_6:
            if(val_13 >= this.mSegments.Count)
            {
                goto label_8;
            }
            
            XftWeapon.SplineControlPoint val_7 = this.mSegments.Item[1];
            if(val_7.Dist < val_12)
            {
                goto label_11;
            }
            
            val_14 = this.mSegments.Item[1];
            goto label_13;
            label_8:
            val_15 = 0;
            label_13:
            if(val_13 == 0)
            {
                goto label_14;
            }
            
            val_13 = this.mSegments;
            XftWeapon.SplineControlPoint val_10 = val_13.Item[0 - 1];
            if(val_10 == null)
            {
                goto label_17;
            }
            
            val_16 = val_10.Dist;
            val_17 = val_16;
            goto label_18;
            label_14:
            val_18 = 0f;
            goto label_19;
            label_17:
            val_13 = 48;
            val_17 = 0f;
            val_16 = 0f;
            label_18:
            val_16 = val_12 - val_16;
            val_18 = val_16 / (0f - val_17);
            val_19 = val_10;
            label_19:
            localF = val_18;
            return (XftWeapon.SplineControlPoint)val_19;
        }
        public static UnityEngine.Vector3 CatmulRom(UnityEngine.Vector3 T0, UnityEngine.Vector3 P0, UnityEngine.Vector3 P1, UnityEngine.Vector3 T1, float f)
        {
            var val_1;
            var val_2;
            double val_20 = (double)T0.x;
            double val_33 = (double)P0.x;
            double val_21 = 2.5;
            double val_23 = -0.5;
            double val_26 = 1.5;
            double val_22 = (double)T0.y;
            double val_34 = (double)P0.y;
            double val_24 = (double)T0.z;
            double val_35 = (double)P0.z;
            double val_4 = val_20 * val_23;
            double val_5 = val_33 * val_26;
            val_20 = val_20 - (val_33 * val_21);
            double val_6 = val_34 * val_21;
            val_21 = val_35 * val_21;
            double val_25 = (double)P1.x;
            val_6 = val_22 - val_6;
            val_22 = val_22 * val_23;
            val_23 = val_24 * val_23;
            val_5 = val_4 + val_5;
            val_24 = val_24 - val_21;
            double val_7 = val_25 * val_26;
            double val_31 = 0.5;
            val_7 = val_5 - val_7;
            val_20 = val_20 + (val_25 + val_25);
            double val_9 = val_34 * val_26;
            double val_29 = (double)val_2;
            val_25 = val_25 * val_31;
            val_9 = val_22 + val_9;
            val_4 = val_4 + val_25;
            double val_10 = val_29 * val_26;
            val_10 = val_9 - val_10;
            double val_11 = val_29 + val_29;
            val_11 = val_6 + val_11;
            double val_12 = val_35 * val_26;
            double val_32 = (double)P1.y;
            val_12 = val_23 + val_12;
            double val_27 = (double)P1.z;
            double val_28 = (double)val_1;
            double val_30 = (double)T1.x;
            val_26 = val_32 * val_26;
            val_27 = val_27 * val_31;
            val_28 = val_28 * val_31;
            val_29 = val_29 * val_31;
            val_30 = val_30 * val_31;
            val_31 = val_32 * val_31;
            val_32 = val_32 + val_32;
            val_26 = val_12 - val_26;
            val_24 = val_24 + val_32;
            val_10 = val_10 + val_28;
            val_26 = val_26 + val_30;
            val_27 = val_20 - val_27;
            val_28 = val_11 - val_28;
            val_24 = val_24 - val_30;
            double val_15 = (double)T1.y * (val_7 + val_27);
            val_26 = (double)T1.y * val_26;
            val_15 = val_27 + val_15;
            val_28 = val_28 + ((double)T1.y * val_10);
            val_26 = val_24 + val_26;
            val_29 = val_22 + val_29;
            double val_17 = (double)T1.y * val_15;
            val_26 = (double)T1.y * val_26;
            val_17 = val_4 + val_17;
            double val_19 = val_29 + ((double)T1.y * val_28);
            val_26 = (val_23 + val_31) + val_26;
            val_17 = (double)T1.y * val_17;
            val_19 = (double)T1.y * val_19;
            val_26 = (double)T1.y * val_26;
            val_33 = val_33 + val_17;
            val_34 = val_34 + val_19;
            val_35 = val_35 + val_26;
            return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        public UnityEngine.Vector3 InterpolateByLen(float tl)
        {
            UnityEngine.Vector3 val_3 = this.LenToSegment(t:  tl, localF: out  float val_1 = -1.280829E+25f).Interpolate(localF:  0f);
            return new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        }
        public UnityEngine.Vector3 InterpolateNormalByLen(float tl)
        {
            UnityEngine.Vector3 val_3 = this.LenToSegment(t:  tl, localF: out  float val_1 = -1.294686E+25f).InterpolateNormal(localF:  0f);
            return new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        }
        public XftWeapon.SplineControlPoint AddControlPoint(UnityEngine.Vector3 pos, UnityEngine.Vector3 up)
        {
            object val_1 = null;
            typeof(XftWeapon.SplineControlPoint).__il2cppRuntimeField_28 = 0;
            typeof(XftWeapon.SplineControlPoint).__il2cppRuntimeField_2C = 0;
            val_1 = new System.Object();
            if(null != 0)
            {
                    typeof(XftWeapon.SplineControlPoint).__il2cppRuntimeField_38 = this;
                typeof(XftWeapon.SplineControlPoint).__il2cppRuntimeField_2C = 0;
            }
            else
            {
                    mem[56] = this;
                typeof(XftWeapon.SplineControlPoint).__il2cppRuntimeField_2C = 0;
            }
            
            typeof(XftWeapon.SplineControlPoint).__il2cppRuntimeField_10 = pos.x;
            typeof(XftWeapon.SplineControlPoint).__il2cppRuntimeField_14 = pos.y;
            typeof(XftWeapon.SplineControlPoint).__il2cppRuntimeField_18 = pos.z;
            typeof(XftWeapon.SplineControlPoint).__il2cppRuntimeField_1C = up.x;
            typeof(XftWeapon.SplineControlPoint).__il2cppRuntimeField_20 = up.y;
            typeof(XftWeapon.SplineControlPoint).__il2cppRuntimeField_24 = up.z;
            this.mControlPoints.Add(item:  val_1);
            typeof(XftWeapon.SplineControlPoint).__il2cppRuntimeField_28 = this.mControlPoints.Count - 1;
            return (XftWeapon.SplineControlPoint)val_1;
        }
        public void Clear()
        {
            this.mControlPoints.Clear();
        }
        private void RefreshDistance()
        {
            int val_12;
            if(this.mSegments.Count < 1)
            {
                    return;
            }
            
            XftWeapon.SplineControlPoint val_2 = this.mSegments.Item[0];
            val_2.Dist = 0f;
            val_12 = 1;
            goto label_5;
            label_18:
            mem[49] = S8 + S9;
            val_12 = W21 + 2;
            label_5:
            if(val_12 >= this.mSegments.Count)
            {
                    return;
            }
            
            XftWeapon.SplineControlPoint val_5 = this.mSegments.Item[val_12];
            val_12 = val_12 - 1;
            XftWeapon.SplineControlPoint val_6 = this.mSegments.Item[val_12];
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_5.Position, y = V9.16B, z = V10.16B}, b:  new UnityEngine.Vector3() {x = val_6.Position, y = V12.16B, z = V11.16B});
            int val_8 = val_12 + 1;
            val_8 = val_8 - 1;
            XftWeapon.SplineControlPoint val_10 = this.mSegments.Item[val_8];
            if(this.mSegments.Item[val_8] != null)
            {
                goto label_18;
            }
            
            goto label_18;
        }
        public void RefreshSpline()
        {
            var val_8;
            this.mSegments.Clear();
            val_8 = 0;
            goto label_2;
            label_13:
            val_8 = 1;
            label_2:
            if(val_8 >= this.mControlPoints.Count)
            {
                goto label_4;
            }
            
            if(this.mControlPoints.Item[1].NextControlPoint == null)
            {
                goto label_13;
            }
            
            this.mSegments.Add(item:  this.mControlPoints.Item[1]);
            XftWeapon.SplineControlPoint val_5 = this.mControlPoints.Item[1];
            val_5.SegmentIndex = this.mSegments.Count - 1;
            goto label_13;
            label_4:
            this.RefreshDistance();
        }
    
    }

}
