using UnityEngine;

namespace TzarGames.Common.Curves
{
    [Serializable]
    public class BezierSpline
    {
        // Fields
        public const int DEFAULT_CURVE_INTERPOLATION_STEP_COUNT = 50;
        [UnityEngine.SerializeField]
        private System.Collections.Generic.List<UnityEngine.Vector3> points;
        private System.Collections.Generic.List<double> lengths;
        private System.Collections.Generic.List<TzarGames.Common.Curves.BezierCurve> curves;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private double <Length>k__BackingField;
        
        // Properties
        public System.Collections.Generic.IEnumerable<TzarGames.Common.Curves.BezierCurve> Curves { get; }
        public double Length { get; set; }
        public System.Collections.Generic.List<UnityEngine.Vector3> Points { get; set; }
        
        // Methods
        public BezierSpline()
        {
            this.lengths = new System.Collections.Generic.List<System.Double>();
            this.curves = new System.Collections.Generic.List<TzarGames.Common.Curves.BezierCurve>();
        }
        public BezierSpline(UnityEngine.Vector3[] splinePoints)
        {
            this.lengths = new System.Collections.Generic.List<System.Double>();
            this.curves = new System.Collections.Generic.List<TzarGames.Common.Curves.BezierCurve>();
            this.Points = new System.Collections.Generic.List<UnityEngine.Vector3>(collection:  splinePoints);
        }
        public System.Collections.Generic.IEnumerable<TzarGames.Common.Curves.BezierCurve> get_Curves()
        {
            return (System.Collections.Generic.IEnumerable<TzarGames.Common.Curves.BezierCurve>)this.curves;
        }
        public double get_Length()
        {
            return (double)this.<Length>k__BackingField;
        }
        private void set_Length(double value)
        {
            this.<Length>k__BackingField = value;
        }
        public void Compile(int curveInterpolationStepCount = 50)
        {
            int val_8;
            this.lengths.Clear();
            this.curves.Clear();
            this.<Length>k__BackingField = 0;
            UnityEngine.Vector3 val_1 = this.points.Item[0];
            val_8 = 1;
            goto label_4;
            label_13:
            X22.Add(item:  this.points);
            val_8 = 2;
            label_4:
            if(val_8 >= this.points.Count)
            {
                    return;
            }
            
            val_8 = val_8 - 1;
            null = new TzarGames.Common.Curves.BezierCurve(spline:  this, firstPointIndex:  val_8, interpolationStepCount:  50);
            val_8 = val_8 + 1;
            UnityEngine.Vector3 val_4 = this.points.Item[val_8];
            val_8 = val_8 + 1;
            UnityEngine.Vector3 val_5 = this.points.Item[val_8];
            val_8 = val_8 + 1;
            UnityEngine.Vector3 val_6 = this.points.Item[val_8];
            double val_7 = TzarGames.Common.Curves.BezierCurve.__il2cppRuntimeField_element_class + (this.<Length>k__BackingField);
            this.<Length>k__BackingField = val_7;
            this.lengths.Add(item:  val_7);
            if(this.curves != null)
            {
                goto label_13;
            }
            
            goto label_13;
        }
        public UnityEngine.Vector3 GetPoint(float distance)
        {
            System.Collections.Generic.List<System.Double> val_6;
            float val_7;
            val_6 = this;
            int val_6 = this.GetCurveIndexAtDistance(distance:  distance);
            TzarGames.Common.Curves.BezierCurve val_2 = this.curves.Item[val_6];
            val_7 = distance;
            float val_7 = UnityEngine.Mathf.Clamp(value:  val_7, min:  0f, max:  (float)this.<Length>k__BackingField);
            double val_4 = this.lengths.Item[val_6];
            val_6 = val_6 - 1;
            if()
            {
                    val_6 = this.lengths;
                double val_5 = val_6.Item[val_6];
            }
            else
            {
                    val_7 = 0;
            }
            
            val_7 = (double)val_7 - val_7;
            if(val_2 != null)
            {
                    return val_2.GetPointAtDistance(distance:  (float)val_7);
            }
            
            return val_2.GetPointAtDistance(distance:  (float)val_7);
        }
        public UnityEngine.Vector3 GetClosestPoint(UnityEngine.Vector3 point)
        {
            float val_5;
            var val_6;
            List.Enumerator<T> val_1 = this.curves.GetEnumerator();
            label_7:
            label_6:
            if((0 & 1) == 0)
            {
                goto label_2;
            }
            
            UnityEngine.Vector3 val_3 = 0.InitializationCallback.GetClosestPoint(point:  new UnityEngine.Vector3() {x = point.x, y = point.y, z = point.z});
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = point.x, y = point.y, z = point.z});
            if(val_4.x >= 0)
            {
                goto label_6;
            }
            
            goto label_7;
            label_2:
            val_5 = 0;
            val_6 = 1;
            0.Dispose();
            if((val_6 & 1) != 0)
            {
                    return new UnityEngine.Vector3() {x = point.x, y = point.y, z = point.z};
            }
            
            if(val_5 == 0)
            {
                    return new UnityEngine.Vector3() {x = point.x, y = point.y, z = point.z};
            }
            
            return new UnityEngine.Vector3() {x = point.x, y = point.y, z = point.z};
        }
        public float GetClosestPointDistance(UnityEngine.Vector3 point, out UnityEngine.Vector3 pointOnCurve)
        {
            var val_6;
            var val_7;
            pointOnCurve.x = point.x;
            pointOnCurve.y = point.y;
            pointOnCurve.z = point.z;
            List.Enumerator<T> val_1 = this.curves.GetEnumerator();
            goto label_5;
            label_8:
            pointOnCurve.z = point.z;
            pointOnCurve.x = point.x;
            goto label_5;
            label_9:
            if((0.InitializationCallback.GetClosestPointDistance(point:  new UnityEngine.Vector3() {x = point.x, y = point.y, z = point.z}, pointOnCurve: out  new UnityEngine.Vector3() {x = point.x, y = point.y, z = point.z})) == (-1f))
            {
                goto label_5;
            }
            
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = point.x, y = point.y, z = point.z}, b:  new UnityEngine.Vector3() {x = point.x, y = point.y, z = point.z});
            if(val_4.x < 0)
            {
                goto label_8;
            }
            
            label_5:
            if((0 & 1) != 0)
            {
                goto label_9;
            }
            
            val_6 = 0;
            val_7 = 1;
            0.Dispose();
            if(( & 1) != 0)
            {
                    return (float)???;
            }
            
            if( == 0)
            {
                    return (float)???;
            }
            
            return (float)???;
        }
        public UnityEngine.Vector3 GetFartherPointInRadius(UnityEngine.Vector3 center, float radius)
        {
            List.Enumerator<T> val_1 = this.curves.GetEnumerator();
            goto label_2;
            label_7:
            var val_2 = (S10 < radius) ? 1 : 0;
            val_2 = val_2 | (~val_1.current);
            label_2:
            if((0 & 1) == 0)
            {
                goto label_10;
            }
            
            UnityEngine.Vector3 val_7 = 0.InitializationCallback.GetFartherPointInRadius(center:  new UnityEngine.Vector3() {x = center.x, y = center.y, z = center.z}, radius:  radius);
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, b:  new UnityEngine.Vector3() {x = center.x, y = center.y, z = center.z});
            goto label_7;
            label_10:
            0.Dispose();
            if((0 & 1) != 0)
            {
                    return new UnityEngine.Vector3() {x = (val_2 != 1) ? center.x : (S15), y = (val_2 != 1) ? center.y : (S8), z = (val_2 != 1) ? center.z : (S9)};
            }
            
            if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, rhs:  new UnityEngine.Vector3() {x = center.x, y = center.y, z = center.z})) == false)
            {
                    return new UnityEngine.Vector3() {x = (val_2 != 1) ? center.x : (S15), y = (val_2 != 1) ? center.y : (S8), z = (val_2 != 1) ? center.z : (S9)};
            }
            
            return new UnityEngine.Vector3() {x = (val_2 != 1) ? center.x : (S15), y = (val_2 != 1) ? center.y : (S8), z = (val_2 != 1) ? center.z : (S9)};
        }
        public TzarGames.Common.Curves.BezierCurve GetCurveAtDistance(float distance)
        {
            System.Collections.Generic.List<TzarGames.Common.Curves.BezierCurve> val_3;
            var val_4;
            val_3 = this;
            int val_1 = this.GetCurveIndexAtDistance(distance:  distance);
            if(val_1 != 1)
            {
                    val_3 = this.curves;
                TzarGames.Common.Curves.BezierCurve val_2 = val_3.Item[val_1];
                return (TzarGames.Common.Curves.BezierCurve)val_4;
            }
            
            val_4 = 0;
            return (TzarGames.Common.Curves.BezierCurve)val_4;
        }
        public int GetCurveIndexAtDistance(float distance)
        {
            float val_5;
            System.Collections.Generic.List<TzarGames.Common.Curves.BezierCurve> val_6;
            var val_7;
            float val_8;
            System.Collections.Generic.List<System.Double> val_9;
            val_5 = distance;
            val_6 = this;
            if(val_5 <= 0f)
            {
                goto label_1;
            }
            
            val_5 = (double)val_5;
            if(val_5 >= (this.<Length>k__BackingField))
            {
                goto label_2;
            }
            
            val_7 = 0;
            val_8 = 0;
            goto label_3;
            label_8:
            val_7 = 1;
            val_8 = this.<Length>k__BackingField;
            label_3:
            val_9 = this.lengths;
            if(val_7 >= val_9.Count)
            {
                goto label_5;
            }
            
            val_9 = this.lengths;
            if((val_5 < val_8) || (val_5 > val_9.Item[1]))
            {
                goto label_8;
            }
            
            return (int)val_7;
            label_1:
            val_7 = 0;
            return (int)val_7;
            label_2:
            val_6 = this.curves;
            val_7 = val_6.Count - 1;
            return (int)val_7;
            label_5:
            val_7 = 0;
            return (int)val_7;
        }
        public System.Collections.Generic.List<UnityEngine.Vector3> get_Points()
        {
            return (System.Collections.Generic.List<UnityEngine.Vector3>)this.points;
        }
        public void set_Points(System.Collections.Generic.List<UnityEngine.Vector3> value)
        {
            int val_1 = value.Count;
            var val_4 = (long)val_1;
            val_4 = val_4 * 1431655766;
            val_4 = val_4 >> 32;
            val_4 = val_4 + (val_4 >> 63);
            val_4 = val_4 + (val_4 << 1);
            val_4 = val_1 - val_4;
            if(val_4 == 1)
            {
                    this.points = value;
                return;
            }
            
            System.Exception val_3 = new System.Exception(message:  "Count of Bezier points must satisfy the condition (n % 3) == 1");
        }
        public void AppendCurve(UnityEngine.Vector3 p1, UnityEngine.Vector3 p2, UnityEngine.Vector3 p3)
        {
            float val_1;
            this.points.Add(item:  new UnityEngine.Vector3() {x = p1.x, y = p1.y, z = p1.z});
            this.points.Add(item:  new UnityEngine.Vector3() {x = p2.x, y = p2.y, z = p2.z});
            this.points.Add(item:  new UnityEngine.Vector3() {x = p3.x, y = val_1, z = p3.y});
        }
        public void PrependCurve(UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, UnityEngine.Vector3 p2)
        {
            var val_1;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_20 = p0.x;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_24 = p0.y;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_28 = p0.z;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_2C = p1.x;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_30 = p1.y;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_34 = p1.z;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_38 = p2.x;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_3C = val_1;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_40 = p2.y;
            this.points.InsertRange(index:  0, collection:  null);
        }
        public static UnityEngine.Vector3 GetPointOnBezierCurve(UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, UnityEngine.Vector3 p2, UnityEngine.Vector3 p3, float t)
        {
            float val_1;
            var val_2;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = p1.x, y = p1.y, z = p1.z}, b:  new UnityEngine.Vector3() {x = p0.x, y = p0.y, z = p0.z});
            float val_4 = p3.y * 3f;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(d:  val_4, a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = p0.x, y = p0.y, z = p0.z}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(d:  2f, a:  new UnityEngine.Vector3() {x = p1.x, y = p1.y, z = p1.z});
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = p2.x, y = val_2, z = p2.y}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, b:  new UnityEngine.Vector3() {x = p0.x, y = p0.y, z = p0.z});
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Multiply(d:  val_4 * p3.y, a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, b:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Multiply(d:  3f, a:  new UnityEngine.Vector3() {x = p2.x, y = val_2, z = p2.y});
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = p2.z, y = val_1, z = p3.x}, b:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Multiply(d:  3f, a:  new UnityEngine.Vector3() {x = p1.x, y = p1.y, z = p1.z});
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, b:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, b:  new UnityEngine.Vector3() {x = p0.x, y = p0.y, z = p0.z});
            float val_18 = p3.y * p3.y;
            val_18 = val_18 * p3.y;
            UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Multiply(d:  val_18, a:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z});
            return UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, b:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z});
        }
        public static double GetBezierCurveLength(UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, UnityEngine.Vector3 p2, UnityEngine.Vector3 p3, int curveInterpolationStepCount = 50)
        {
            var val_6 = W1;
            if(val_6 < 1)
            {
                    return (double)val_10;
            }
            
            float val_6 = 1f;
            val_6 = val_6 / (float)val_6;
            do
            {
                double val_7 = (double)val_6;
                val_7 = val_7 * 0;
                UnityEngine.Vector3 val_3 = TzarGames.Common.Curves.BezierSpline.GetPointOnBezierCurve(p0:  new UnityEngine.Vector3() {x = p0.x, y = p0.y, z = p0.z}, p1:  new UnityEngine.Vector3() {x = p1.x, y = p1.y, z = p1.z}, p2:  new UnityEngine.Vector3() {x = p2.x, y = p2.y, z = p2.z}, p3:  new UnityEngine.Vector3() {x = p3.x, y = (float)val_7}, t:  p2.y);
                double val_8 = (double)val_6;
                val_8 = val_8 + val_7;
                UnityEngine.Vector3 val_4 = TzarGames.Common.Curves.BezierSpline.GetPointOnBezierCurve(p0:  new UnityEngine.Vector3() {x = p0.x, y = p0.y, z = p0.z}, p1:  new UnityEngine.Vector3() {x = p1.x, y = p1.y, z = p1.z}, p2:  new UnityEngine.Vector3() {x = p2.x, y = p2.y, z = p2.z}, p3:  new UnityEngine.Vector3() {x = p3.x, y = (float)val_8}, t:  p2.y);
                double val_9 = 0;
                val_6 = val_6 - 1;
                val_9 = val_9 + 1;
                double val_10 = 0;
                val_10 = val_10 + ((double)UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}));
            }
            while(val_6 != 0);
            
            return (double)val_10;
        }
        public static System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<float, UnityEngine.Vector3>> GetCurveApprox(UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, UnityEngine.Vector3 p2, UnityEngine.Vector3 p3, int curveInterpolationStepCount = 50)
        {
            if(W1 >= 1)
            {
                    var val_8 = 0;
                do
            {
                UnityEngine.Vector3 val_6 = TzarGames.Common.Curves.BezierSpline.GetPointOnBezierCurve(p0:  new UnityEngine.Vector3() {x = p0.x, y = p0.y, z = p0.z}, p1:  new UnityEngine.Vector3() {x = p1.x, y = p1.y, z = p1.z}, p2:  new UnityEngine.Vector3() {x = p2.x, y = p2.y, z = p2.z}, p3:  new UnityEngine.Vector3() {x = p3.x, y = (1f / (float)W1) * 0f}, t:  p2.y);
                Add(item:  new System.Collections.Generic.KeyValuePair<System.Single, UnityEngine.Vector3>() {Value = new UnityEngine.Vector3() {x = -1.136254E-37f, y = 2.524355E-29f}});
                val_8 = val_8 + 1;
            }
            while(W1 != val_8);
            
            }
            
            UnityEngine.Vector3 val_7 = TzarGames.Common.Curves.BezierSpline.GetPointOnBezierCurve(p0:  new UnityEngine.Vector3() {x = p0.x, y = p0.y, z = p0.z}, p1:  new UnityEngine.Vector3() {x = p1.x, y = p1.y, z = p1.z}, p2:  new UnityEngine.Vector3() {x = p2.x, y = p2.y, z = p2.z}, p3:  new UnityEngine.Vector3() {x = p3.x, y = 1f}, t:  p2.y);
            Add(item:  new System.Collections.Generic.KeyValuePair<System.Single, UnityEngine.Vector3>() {Value = new UnityEngine.Vector3() {x = -1.136254E-37f, y = 2.524355E-29f}});
            return (System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<System.Single, UnityEngine.Vector3>>)new System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<System.Single, UnityEngine.Vector3>>();
        }
        public static UnityEngine.Vector3[] SplitAt(UnityEngine.Vector3 p0, UnityEngine.Vector3 p1, UnityEngine.Vector3 p2, UnityEngine.Vector3 p3, float t)
        {
            var val_1;
            float val_2;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = p0.x, y = p0.y, z = p0.z}, b:  new UnityEngine.Vector3() {x = p1.x, y = p1.y, z = p1.z}, t:  p3.y);
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = p1.x, y = p1.y, z = p1.z}, b:  new UnityEngine.Vector3() {x = p2.x, y = val_2, z = p2.y}, t:  p3.y);
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = p2.x, y = val_2, z = p2.y}, b:  new UnityEngine.Vector3() {x = p2.z, y = val_1, z = p3.x}, t:  p3.y);
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, t:  p3.y);
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, t:  p3.y);
            UnityEngine.Vector3 val_8 = TzarGames.Common.Curves.BezierSpline.GetPointOnBezierCurve(p0:  new UnityEngine.Vector3() {x = p0.x, y = p0.y, z = p0.z}, p1:  new UnityEngine.Vector3() {x = p1.x, y = p1.y, z = p1.z}, p2:  new UnityEngine.Vector3() {x = p2.x, y = p2.y, z = p2.z}, p3:  new UnityEngine.Vector3() {x = p3.x, y = p3.y}, t:  null);
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_20 = p0.x;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_24 = p0.y;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_28 = p0.z;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_2C = val_3.x;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_30 = val_3.y;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_34 = val_3.z;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_38 = val_6.x;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_3C = val_6.y;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_40 = val_6.z;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_44 = val_8.x;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_48 = val_8.y;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_4C = val_8.z;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_50 = val_8.x;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_54 = val_8.y;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_58 = val_8.z;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_5C = val_7.x;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_60 = val_7.y;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_64 = val_7.z;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_68 = val_5.x;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_6C = val_5.y;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_70 = val_5.z;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_74 = p2.z;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_78 = val_1;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_7C = p3.x;
            return (UnityEngine.Vector3[])null;
        }
    
    }

}
