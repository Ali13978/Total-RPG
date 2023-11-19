using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    public class BezierPath
    {
        // Fields
        public int SegmentsPerCurve;
        public float MINIMUM_SQR_DISTANCE;
        public float DIVISION_THRESHOLD;
        private System.Collections.Generic.List<UnityEngine.Vector2> controlPoints;
        private int curveCount;
        
        // Methods
        public BezierPath()
        {
            this.SegmentsPerCurve = 10;
            this.MINIMUM_SQR_DISTANCE = 0.01f;
            this.DIVISION_THRESHOLD = 4.040784E-41f;
            this.controlPoints = new System.Collections.Generic.List<UnityEngine.Vector2>();
        }
        public void SetControlPoints(System.Collections.Generic.List<UnityEngine.Vector2> newControlPoints)
        {
            this.controlPoints.Clear();
            this.controlPoints.AddRange(collection:  newControlPoints);
            int val_4 = (long)this.controlPoints.Count - 1;
            val_4 = val_4 * 1431655766;
            val_4 = val_4 >> 32;
            val_4 = val_4 + (val_4 >> 63);
            this.curveCount = val_4;
        }
        public void SetControlPoints(UnityEngine.Vector2[] newControlPoints)
        {
            this.controlPoints.Clear();
            this.controlPoints.AddRange(collection:  newControlPoints);
            int val_4 = (long)this.controlPoints.Count - 1;
            val_4 = val_4 * 1431655766;
            val_4 = val_4 >> 32;
            val_4 = val_4 + (val_4 >> 63);
            this.curveCount = val_4;
        }
        public System.Collections.Generic.List<UnityEngine.Vector2> GetControlPoints()
        {
            return (System.Collections.Generic.List<UnityEngine.Vector2>)this.controlPoints;
        }
        public void Interpolate(System.Collections.Generic.List<UnityEngine.Vector2> segmentPoints, float scale)
        {
            System.Collections.Generic.List<UnityEngine.Vector2> val_27 = this.controlPoints;
            val_27.Clear();
            if(segmentPoints.Count < 2)
            {
                    return;
            }
            
            val_27 = 0;
            goto label_4;
            label_29:
            val_27 = 1;
            label_4:
            int val_2 = val_27 + 1;
            if(val_2 >= segmentPoints.Count)
            {
                goto label_6;
            }
            
            if(val_27 == 1)
            {
                goto label_8;
            }
            
            var val_29 = segmentPoints.Count;
            val_29 = val_29 - 1;
            UnityEngine.Vector2 val_5 = segmentPoints.Item[1];
            UnityEngine.Vector2 val_6 = segmentPoints.Item[val_2];
            if(val_2 != val_29)
            {
                goto label_11;
            }
            
            UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y}, b:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y});
            UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Multiply(d:  scale, a:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y});
            UnityEngine.Vector2 val_9 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y}, b:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y});
            this.controlPoints.Add(item:  new UnityEngine.Vector2() {x = val_9.x, y = val_9.y});
            this.controlPoints.Add(item:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y});
            goto label_29;
            label_8:
            UnityEngine.Vector2 val_10 = segmentPoints.Item[0];
            UnityEngine.Vector2 val_11 = segmentPoints.Item[1];
            UnityEngine.Vector2 val_12 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_11.x, y = val_11.y}, b:  new UnityEngine.Vector2() {x = val_10.x, y = val_10.y});
            UnityEngine.Vector2 val_13 = UnityEngine.Vector2.op_Multiply(d:  scale, a:  new UnityEngine.Vector2() {x = val_12.x, y = val_12.y});
            UnityEngine.Vector2 val_14 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_10.x, y = val_10.y}, b:  new UnityEngine.Vector2() {x = val_13.x, y = val_13.y});
            this.controlPoints.Add(item:  new UnityEngine.Vector2() {x = val_10.x, y = val_10.y});
            this.controlPoints.Add(item:  new UnityEngine.Vector2() {x = val_14.x, y = val_14.y});
            goto label_29;
            label_11:
            UnityEngine.Vector2 val_16 = segmentPoints.Item[val_27 + 2];
            UnityEngine.Vector2 val_17 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_16.x, y = val_16.y}, b:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y});
            UnityEngine.Vector2 val_18 = UnityEngine.Vector2.op_Multiply(d:  scale, a:  new UnityEngine.Vector2() {x = val_17.x, y = val_17.y});
            UnityEngine.Vector2 val_19 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y}, b:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y});
            UnityEngine.Vector2 val_20 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_18.x, y = val_18.y}, d:  val_19.x);
            UnityEngine.Vector2 val_21 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y}, b:  new UnityEngine.Vector2() {x = val_20.x, y = val_20.y});
            UnityEngine.Vector2 val_22 = UnityEngine.Vector2.op_Multiply(d:  scale, a:  new UnityEngine.Vector2() {x = val_17.x, y = val_17.y});
            UnityEngine.Vector2 val_23 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_16.x, y = val_16.y}, b:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y});
            UnityEngine.Vector2 val_24 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_22.x, y = val_22.y}, d:  val_23.x);
            UnityEngine.Vector2 val_25 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y}, b:  new UnityEngine.Vector2() {x = val_24.x, y = val_24.y});
            this.controlPoints.Add(item:  new UnityEngine.Vector2() {x = val_21.x, y = val_21.y});
            this.controlPoints.Add(item:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y});
            this.controlPoints.Add(item:  new UnityEngine.Vector2() {x = val_25.x, y = val_25.y});
            goto label_29;
            label_6:
            int val_30 = (long)this.controlPoints.Count - 1;
            val_30 = val_30 * 1431655766;
            val_30 = val_30 >> 32;
            val_30 = val_30 + (val_30 >> 63);
            this.curveCount = val_30;
        }
        public void SamplePoints(System.Collections.Generic.List<UnityEngine.Vector2> sourcePoints, float minSqrDistance, float maxSqrDistance, float scale)
        {
            float val_23;
            float val_24;
            System.Collections.Generic.List<UnityEngine.Vector2> val_25;
            float val_26;
            float val_27;
            var val_28;
            val_23 = scale;
            val_24 = minSqrDistance;
            val_25 = sourcePoints;
            if(val_25.Count < 2)
            {
                    return;
            }
            
            UnityEngine.Vector2 val_3 = val_25.Item[0];
            Push(t:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y});
            UnityEngine.Vector2 val_4 = val_25.Item[1];
            val_26 = val_4.x;
            val_27 = val_4.y;
            val_28 = 2;
            goto label_6;
            label_20:
            UnityEngine.Vector2 val_5 = val_25.Item[2];
            val_26 = val_5.x;
            val_27 = val_5.y;
            val_28 = 3;
            label_6:
            if(val_28 >= val_25.Count)
            {
                goto label_8;
            }
            
            UnityEngine.Vector2 val_7 = val_25.Item[3];
            UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_26, y = val_27}, b:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y});
            if(val_8.x.sqrMagnitude > val_24)
            {
                    UnityEngine.Vector2 val_10 = Peek();
                UnityEngine.Vector2 val_11 = val_25.Item[3];
                UnityEngine.Vector2 val_12 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_10.x, y = val_10.y}, b:  new UnityEngine.Vector2() {x = val_11.x, y = val_11.y});
                if(val_12.x.sqrMagnitude > maxSqrDistance)
            {
                    Push(t:  new UnityEngine.Vector2() {x = val_26, y = val_27});
            }
            
            }
            
            if(val_25 != null)
            {
                goto label_20;
            }
            
            goto label_20;
            label_8:
            UnityEngine.Vector2 val_14 = Pop();
            val_24 = val_14.y;
            UnityEngine.Vector2 val_15 = Peek();
            UnityEngine.Vector2 val_16 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_15.x, y = val_15.y}, b:  new UnityEngine.Vector2() {x = val_26, y = val_27});
            UnityEngine.Vector2 val_17 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_26, y = val_27}, b:  new UnityEngine.Vector2() {x = val_14.x, y = val_24});
            UnityEngine.Vector2 val_18 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_14.x, y = val_24}, b:  new UnityEngine.Vector2() {x = val_15.x, y = val_15.y});
            val_18.x = val_18.x - val_17.x;
            UnityEngine.Vector2 val_20 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_16.x, y = val_16.y}, d:  val_18.x * 0.5f);
            UnityEngine.Vector2 val_21 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_14.x, y = val_24}, b:  new UnityEngine.Vector2() {x = val_20.x, y = val_20.y});
            val_23 = val_21.y;
            if(null != 0)
            {
                    Push(t:  new UnityEngine.Vector2() {x = val_21.x, y = val_23});
            }
            else
            {
                    Push(t:  new UnityEngine.Vector2() {x = val_21.x, y = val_23});
            }
            
            Push(t:  new UnityEngine.Vector2() {x = val_26, y = val_27});
            System.Collections.Generic.List<UnityEngine.Vector2> val_22 = null;
            val_25 = val_22;
            val_22 = new System.Collections.Generic.List<UnityEngine.Vector2>(collection:  new System.Collections.Generic.Stack<UnityEngine.Vector2>());
            this.Interpolate(segmentPoints:  val_25, scale:  val_23);
        }
        public UnityEngine.Vector2 CalculateBezierPoint(int curveIndex, float t)
        {
            int val_9 = curveIndex;
            val_9 = val_9 + (val_9 << 1);
            UnityEngine.Vector2 val_1 = this.controlPoints.Item[val_9];
            UnityEngine.Vector2 val_3 = this.controlPoints.Item[val_9 + 1];
            UnityEngine.Vector2 val_5 = this.controlPoints.Item[val_9 + 2];
            UnityEngine.Vector2 val_7 = this.controlPoints.Item[val_9 + 3];
            UnityEngine.Vector2 val_8 = this.controlPoints.CalculateBezierPoint(t:  t, p0:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y}, p1:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y}, p2:  new UnityEngine.Vector2() {x = val_5.x, y = val_5.y}, p3:  new UnityEngine.Vector2() {x = val_7.x});
            return new UnityEngine.Vector2() {x = val_8.x, y = val_8.y};
        }
        public System.Collections.Generic.List<UnityEngine.Vector2> GetDrawingPoints0()
        {
            float val_4;
            if(this.curveCount < 1)
            {
                    return (System.Collections.Generic.List<UnityEngine.Vector2>)new System.Collections.Generic.List<UnityEngine.Vector2>();
            }
            
            var val_6 = 0;
            do
            {
                if(val_6 == 0)
            {
                    UnityEngine.Vector2 val_2 = this.CalculateBezierPoint(curveIndex:  0, t:  0f);
                val_4 = val_2.y;
                Add(item:  new UnityEngine.Vector2() {x = val_2.x, y = val_4});
            }
            
                if(this.SegmentsPerCurve >= 1)
            {
                    var val_5 = 1;
                do
            {
                float val_4 = 1f;
                val_4 = val_4 / (float)this.SegmentsPerCurve;
                UnityEngine.Vector2 val_3 = this.CalculateBezierPoint(curveIndex:  0, t:  val_4);
                val_4 = val_3.y;
                Add(item:  new UnityEngine.Vector2() {x = val_3.x, y = val_4});
                val_5 = val_5 + 1;
            }
            while(val_5 <= this.SegmentsPerCurve);
            
            }
            
                val_6 = val_6 + 1;
            }
            while(val_6 < this.curveCount);
            
            return (System.Collections.Generic.List<UnityEngine.Vector2>)new System.Collections.Generic.List<UnityEngine.Vector2>();
        }
        public System.Collections.Generic.List<UnityEngine.Vector2> GetDrawingPoints1()
        {
            int val_13 = 0;
            goto label_2;
            label_15:
            val_13 = W22;
            goto label_2;
            label_11:
            UnityEngine.Vector2 val_2 = this.controlPoints.Item[val_13];
            UnityEngine.Vector2 val_4 = this.controlPoints.Item[val_13 + 1];
            UnityEngine.Vector2 val_6 = this.controlPoints.Item[val_13 + 2];
            int val_7 = val_13 + 3;
            UnityEngine.Vector2 val_8 = this.controlPoints.Item[val_7];
            if(val_13 == 0)
            {
                    UnityEngine.Vector2 val_9 = this.controlPoints.CalculateBezierPoint(t:  0f, p0:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y}, p1:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y}, p2:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y}, p3:  new UnityEngine.Vector2() {x = val_8.x, y = val_2.y});
                Add(item:  new UnityEngine.Vector2() {x = val_9.x, y = val_9.y});
            }
            
            val_13 = val_7;
            if(this.SegmentsPerCurve >= 1)
            {
                goto label_9;
            }
            
            label_2:
            if(val_13 < (this.controlPoints.Count - 3))
            {
                goto label_11;
            }
            
            return (System.Collections.Generic.List<UnityEngine.Vector2>)new System.Collections.Generic.List<UnityEngine.Vector2>();
            label_9:
            var val_14 = 1;
            do
            {
                float val_13 = 1f;
                val_13 = val_13 / (float)this.SegmentsPerCurve;
                UnityEngine.Vector2 val_12 = CalculateBezierPoint(t:  val_13, p0:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y}, p1:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y}, p2:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y}, p3:  new UnityEngine.Vector2() {x = val_8.x, y = val_2.y});
                Add(item:  new UnityEngine.Vector2() {x = val_12.x, y = val_12.y});
                val_14 = val_14 + 1;
            }
            while(val_14 <= this.SegmentsPerCurve);
            
            goto label_15;
        }
        public System.Collections.Generic.List<UnityEngine.Vector2> GetDrawingPoints2()
        {
            if(this.curveCount < 1)
            {
                    return (System.Collections.Generic.List<UnityEngine.Vector2>)new System.Collections.Generic.List<UnityEngine.Vector2>();
            }
            
            var val_3 = 0;
            do
            {
                System.Collections.Generic.List<UnityEngine.Vector2> val_2 = this.FindDrawingPoints(curveIndex:  0);
                if(val_3 != 0)
            {
                    val_2.RemoveAt(index:  0);
            }
            
                AddRange(collection:  val_2);
                val_3 = val_3 + 1;
            }
            while(val_3 < this.curveCount);
            
            return (System.Collections.Generic.List<UnityEngine.Vector2>)new System.Collections.Generic.List<UnityEngine.Vector2>();
        }
        private System.Collections.Generic.List<UnityEngine.Vector2> FindDrawingPoints(int curveIndex)
        {
            System.Collections.Generic.List<UnityEngine.Vector2> val_1 = new System.Collections.Generic.List<UnityEngine.Vector2>();
            UnityEngine.Vector2 val_2 = this.CalculateBezierPoint(curveIndex:  curveIndex, t:  0f);
            UnityEngine.Vector2 val_3 = this.CalculateBezierPoint(curveIndex:  curveIndex, t:  1f);
            if(null != 0)
            {
                    Add(item:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
            }
            else
            {
                    Add(item:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
            }
            
            Add(item:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y});
            int val_4 = this.FindDrawingPoints(curveIndex:  curveIndex, t0:  0f, t1:  1f, pointList:  val_1, insertionIndex:  1);
            return val_1;
        }
        private int FindDrawingPoints(int curveIndex, float t0, float t1, System.Collections.Generic.List<UnityEngine.Vector2> pointList, int insertionIndex)
        {
            float val_12;
            float val_13;
            var val_14;
            var val_15;
            val_12 = t1;
            UnityEngine.Vector2 val_1 = this.CalculateBezierPoint(curveIndex:  curveIndex, t:  t0);
            val_13 = val_1.y;
            UnityEngine.Vector2 val_2 = this.CalculateBezierPoint(curveIndex:  curveIndex, t:  val_12);
            val_14 = 1152921504730062848;
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_1.x, y = val_13}, b:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y});
            if(val_3.x.sqrMagnitude < 0)
            {
                goto label_9;
            }
            
            val_12 = (t0 + val_12) * 0.5f;
            UnityEngine.Vector2 val_6 = this.CalculateBezierPoint(curveIndex:  curveIndex, t:  val_12);
            UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_1.x, y = val_13}, b:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y});
            val_13 = val_7.x;
            UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y}, b:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y});
            if((UnityEngine.Vector2.Dot(lhs:  new UnityEngine.Vector2() {x = val_13, y = val_7.y}, rhs:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y})) > this.DIVISION_THRESHOLD)
            {
                goto label_6;
            }
            
            float val_12 = -0.5f;
            val_12 = val_12 + val_12;
            if(System.Math.Abs(val_12) >= 0)
            {
                goto label_9;
            }
            
            label_6:
            pointList.Insert(index:  this + insertionIndex, item:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y});
            val_14 = 1152921512776982113;
            UnityEngine.UI.Extensions.BezierPath val_11 = val_14 + insertionIndex;
            val_15 = 2305843025553964225;
            return (int)val_15;
            label_9:
            val_15 = 0;
            return (int)val_15;
        }
        private UnityEngine.Vector2 CalculateBezierPoint(float t, UnityEngine.Vector2 p0, UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, UnityEngine.Vector2 p3)
        {
            float val_1;
            float val_2 = 1f - t;
            float val_3 = t * t;
            float val_4 = val_2 * val_2;
            UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Multiply(d:  val_2 * val_4, a:  new UnityEngine.Vector2() {x = p0.x, y = p0.y});
            float val_8 = val_4 * 3f;
            val_8 = val_8 * t;
            UnityEngine.Vector2 val_9 = UnityEngine.Vector2.op_Multiply(d:  val_8, a:  new UnityEngine.Vector2() {x = p1.x, y = p1.y});
            UnityEngine.Vector2 val_10 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y}, b:  new UnityEngine.Vector2() {x = val_9.x, y = val_9.y});
            float val_11 = val_2 * 3f;
            val_11 = val_3 * val_11;
            UnityEngine.Vector2 val_12 = UnityEngine.Vector2.op_Multiply(d:  val_11, a:  new UnityEngine.Vector2() {x = p2.x, y = p2.y});
            UnityEngine.Vector2 val_13 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_10.x, y = val_10.y}, b:  new UnityEngine.Vector2() {x = val_12.x, y = val_12.y});
            UnityEngine.Vector2 val_14 = UnityEngine.Vector2.op_Multiply(d:  val_3 * t, a:  new UnityEngine.Vector2() {x = p3.x, y = val_1});
            return UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_13.x, y = val_13.y}, b:  new UnityEngine.Vector2() {x = val_14.x, y = val_14.y});
        }
    
    }

}
