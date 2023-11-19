using UnityEngine;

namespace TzarGames.Common.Curves
{
    public class BezierCurve
    {
        // Fields
        private TzarGames.Common.Curves.BezierSpline baseSpline;
        private int pointIndex;
        private System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<float, UnityEngine.Vector3>> curveApprox;
        private System.Collections.Generic.List<float> lengths;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private double <Length>k__BackingField;
        
        // Properties
        public UnityEngine.Vector3 P0 { get; set; }
        public UnityEngine.Vector3 P1 { get; set; }
        public UnityEngine.Vector3 P2 { get; set; }
        public UnityEngine.Vector3 P3 { get; set; }
        public double Length { get; set; }
        
        // Methods
        public BezierCurve(TzarGames.Common.Curves.BezierSpline spline, int firstPointIndex, int interpolationStepCount = 50)
        {
            var val_3 = (long)firstPointIndex;
            val_3 = val_3 * 1431655766;
            val_3 = val_3 >> 32;
            val_3 = val_3 + (val_3 >> 63);
            val_3 = val_3 + (val_3 << 1);
            val_3 = firstPointIndex - val_3;
            if(val_3 == 0)
            {
                    this.baseSpline = spline;
                this.pointIndex = firstPointIndex;
                this.Compile(interpolationStepCount:  interpolationStepCount);
                return;
            }
            
            System.Exception val_2 = new System.Exception(message:  "Wrong index");
        }
        public UnityEngine.Vector3 get_P0()
        {
            if(this.baseSpline.points != null)
            {
                    return this.baseSpline.points.Item[this.pointIndex];
            }
            
            return this.baseSpline.points.Item[this.pointIndex];
        }
        public void set_P0(UnityEngine.Vector3 value)
        {
            this.baseSpline.points.set_Item(index:  this.pointIndex, value:  new UnityEngine.Vector3() {x = value.x, y = value.y, z = value.z});
        }
        public UnityEngine.Vector3 get_P1()
        {
            return this.baseSpline.points.Item[this.pointIndex + 1];
        }
        public void set_P1(UnityEngine.Vector3 value)
        {
            this.baseSpline.points.set_Item(index:  this.pointIndex + 1, value:  new UnityEngine.Vector3() {x = value.x, y = value.y, z = value.z});
        }
        public UnityEngine.Vector3 get_P2()
        {
            return this.baseSpline.points.Item[this.pointIndex + 2];
        }
        public void set_P2(UnityEngine.Vector3 value)
        {
            this.baseSpline.points.set_Item(index:  this.pointIndex + 2, value:  new UnityEngine.Vector3() {x = value.x, y = value.y, z = value.z});
        }
        public UnityEngine.Vector3 get_P3()
        {
            return this.baseSpline.points.Item[this.pointIndex + 3];
        }
        public void set_P3(UnityEngine.Vector3 value)
        {
            this.baseSpline.points.set_Item(index:  this.pointIndex + 3, value:  new UnityEngine.Vector3() {x = value.x, y = value.y, z = value.z});
        }
        public void Compile(int interpolationStepCount = 50)
        {
            float val_13;
            var val_1 = (interpolationStepCount < 2) ? 2 : interpolationStepCount;
            UnityEngine.Vector3 val_2 = this.P0;
            UnityEngine.Vector3 val_3 = this.P1;
            UnityEngine.Vector3 val_4 = this.P2;
            UnityEngine.Vector3 val_5 = this.P3;
            this.<Length>k__BackingField = 0;
            this.curveApprox = TzarGames.Common.Curves.BezierSpline.GetCurveApprox(p0:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, p1:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, p2:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.z, z = val_5.x}, p3:  new UnityEngine.Vector3() {x = val_5.z, y = 0f, z = 0f}, curveInterpolationStepCount:  -2115537232);
            this.lengths = new System.Collections.Generic.List<System.Single>();
            val_13 = 0f;
            Add(item:  val_13);
            int val_13 = 0;
            goto label_2;
            label_10:
            val_13 = (float)val_4.z;
            Add(item:  val_13);
            label_2:
            if(val_13 >= (this.curveApprox.Count - 1))
            {
                    return;
            }
            
            System.Collections.Generic.KeyValuePair<System.Single, UnityEngine.Vector3> val_10 = this.curveApprox.Item[0];
            val_13 = val_13 + 1;
            System.Collections.Generic.KeyValuePair<System.Single, UnityEngine.Vector3> val_11 = this.curveApprox.Item[val_13];
            float val_14 = val_13;
            val_14 = (this.<Length>k__BackingField) + ((double)UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_14, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_13, y = val_2.y, z = val_2.z}));
            this.<Length>k__BackingField = val_14;
            if(this.lengths != null)
            {
                goto label_10;
            }
            
            goto label_10;
        }
        public double get_Length()
        {
            return (double)this.<Length>k__BackingField;
        }
        private void set_Length(double value)
        {
            this.<Length>k__BackingField = value;
        }
        public UnityEngine.Vector3 GetPoint(float normalizedDistance)
        {
            UnityEngine.Vector3 val_1 = this.P0;
            UnityEngine.Vector3 val_2 = this.P1;
            UnityEngine.Vector3 val_3 = this.P2;
            UnityEngine.Vector3 val_4 = this.P3;
            UnityEngine.Vector3 val_5 = TzarGames.Common.Curves.BezierSpline.GetPointOnBezierCurve(p0:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, p1:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, p2:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.z, z = val_4.x}, p3:  new UnityEngine.Vector3() {x = val_4.z, y = normalizedDistance, z = val_1.y}, t:  ???);
            return new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
        }
        public UnityEngine.Vector3 GetClosestPoint(UnityEngine.Vector3 point)
        {
            var val_2;
            var val_3;
            float val_6;
            float val_7;
            float val_8;
            float val_9;
            float val_10;
            var val_11;
            List.Enumerator<T> val_1 = this.curveApprox.GetEnumerator();
            val_6 = 3.402823E+38f;
            val_7 = point.z;
            goto label_3;
            label_9:
            val_7 = point.z;
            val_6 = V11.16B;
            goto label_3;
            label_7:
            UnityEngine.Color val_4 = val_2.normalColor;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_4.r, y = val_4.g, z = val_4.b}, b:  new UnityEngine.Vector3() {x = point.x, y = point.y, z = point.z});
            if(val_5.x < 0)
            {
                goto label_9;
            }
            
            label_3:
            if((0 & 1) != 0)
            {
                goto label_7;
            }
            
            val_9 = val_2;
            val_8 = val_3;
            val_10 = 0;
            val_11 = 1;
            val_2.Dispose();
            if((val_11 & 1) != 0)
            {
                    return new UnityEngine.Vector3() {x = val_8, y = val_9, z = val_7};
            }
            
            if(val_10 == 0)
            {
                    return new UnityEngine.Vector3() {x = val_8, y = val_9, z = val_7};
            }
            
            return new UnityEngine.Vector3() {x = val_8, y = val_9, z = val_7};
        }
        public float GetClosestPointDistance(UnityEngine.Vector3 point, out UnityEngine.Vector3 pointOnCurve)
        {
            var val_5;
            pointOnCurve.x = point.x;
            pointOnCurve.y = point.y;
            pointOnCurve.z = point.z;
            val_5 = 0;
            goto label_1;
            label_9:
            val_5 = 1;
            label_1:
            if(val_5 >= this.curveApprox.Count)
            {
                    return -1f;
            }
            
            System.Collections.Generic.KeyValuePair<System.Single, UnityEngine.Vector3> val_2 = this.curveApprox.Item[1];
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = point.x, y = point.y, z = point.z}, b:  new UnityEngine.Vector3() {x = point.x, y = point.y, z = point.z});
            if(val_3.x >= 0)
            {
                goto label_9;
            }
            
            pointOnCurve.x = this.lengths.Item[1];
            pointOnCurve.y = val_3.y;
            pointOnCurve.z = val_3.z;
            goto label_9;
        }
        public UnityEngine.Vector3 GetFartherPointInRadius(UnityEngine.Vector3 center, float radius)
        {
            var val_3;
            var val_4;
            float val_7;
            float val_8;
            float val_9;
            float val_10;
            var val_11;
            List.Enumerator<T> val_2 = this.curveApprox.GetEnumerator();
            goto label_6;
            label_8:
            UnityEngine.Color val_5 = val_3.normalColor;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = center.x, y = center.y, z = center.z}, b:  new UnityEngine.Vector3() {x = val_5.r, y = val_5.g, z = val_5.b});
            if(val_6.x >= radius)
            {
                    if(val_6.x <= (radius * radius))
            {
                goto label_6;
            }
            
            }
            
            label_6:
            if((0 & 1) != 0)
            {
                goto label_8;
            }
            
            val_8 = val_3;
            val_7 = val_4;
            val_9 = center.z;
            val_10 = 0;
            val_11 = 1;
            val_3.Dispose();
            if((val_11 & 1) != 0)
            {
                    return new UnityEngine.Vector3() {x = val_7, y = val_8, z = val_9};
            }
            
            if(val_10 == 0)
            {
                    return new UnityEngine.Vector3() {x = val_7, y = val_8, z = val_9};
            }
            
            return new UnityEngine.Vector3() {x = val_7, y = val_8, z = val_9};
        }
        public UnityEngine.Vector3 GetPointAtDistance(float distance)
        {
            float val_16 = UnityEngine.Mathf.Clamp(value:  distance, min:  0f, max:  (float)this.<Length>k__BackingField);
            int val_15 = 0;
            label_6:
            if((val_15 + 1) >= (this.lengths.Count - 1))
            {
                goto label_4;
            }
            
            float val_6 = this.lengths.Item[val_15 + 2];
            val_15 = val_15 + 1;
            if(val_16 > val_6)
            {
                goto label_6;
            }
            
            System.Collections.Generic.KeyValuePair<System.Single, UnityEngine.Vector3> val_8 = this.curveApprox.Item[val_15];
            System.Collections.Generic.KeyValuePair<System.Single, UnityEngine.Vector3> val_9 = this.curveApprox.Item[val_15 + 1];
            float val_10 = val_16 - 0f;
            val_16 = val_10 / (val_6 - 0f);
            UnityEngine.Vector3 val_13 = this.GetPoint(normalizedDistance:  UnityEngine.Mathf.Lerp(a:  val_10, b:  val_10, t:  val_16));
            return new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z};
            label_4:
            System.Exception val_14 = new System.Exception(message:  "Failed to get point at curve");
        }
    
    }

}
