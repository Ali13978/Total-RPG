using UnityEngine;

namespace TzarGames.Common.Curves
{
    public class PathWalker : SplineWalker
    {
        // Fields
        [UnityEngine.SerializeField]
        private TzarGames.Common.Curves.BezierSplineContainer splineContainer;
        private int currentPathSplineIndex;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private int[] <Path>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private float <StartPointDistance>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private float <EndPointDistance>k__BackingField;
        
        // Properties
        public TzarGames.Common.Curves.BezierSplineContainer SplineContainer { get; set; }
        public int[] Path { get; set; }
        public float StartPointDistance { get; set; }
        public float EndPointDistance { get; set; }
        
        // Methods
        public PathWalker()
        {
            this.currentPathSplineIndex = 0;
            mem[1152921511089384296] = 1065353216;
            val_1 = new UnityEngine.MonoBehaviour();
        }
        public TzarGames.Common.Curves.BezierSplineContainer get_SplineContainer()
        {
            return (TzarGames.Common.Curves.BezierSplineContainer)this.splineContainer;
        }
        public void set_SplineContainer(TzarGames.Common.Curves.BezierSplineContainer value)
        {
            this.splineContainer = value;
        }
        public int[] get_Path()
        {
            return (System.Int32[])this.<Path>k__BackingField;
        }
        private void set_Path(int[] value)
        {
            this.<Path>k__BackingField = value;
        }
        public float get_StartPointDistance()
        {
            return (float)this.<StartPointDistance>k__BackingField;
        }
        private void set_StartPointDistance(float value)
        {
            this.<StartPointDistance>k__BackingField = value;
        }
        public float get_EndPointDistance()
        {
            return (float)this.<EndPointDistance>k__BackingField;
        }
        private void set_EndPointDistance(float value)
        {
            this.<EndPointDistance>k__BackingField = value;
        }
        public bool TraversePath(int[] targetPath, float startPointDistance, float distance, out UnityEngine.Vector3 result)
        {
            float val_18;
            int val_19;
            int val_20;
            var val_21;
            float val_22;
            var val_23;
            float val_24;
            float val_25;
            var val_26;
            var val_27;
            val_18 = startPointDistance;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            result.x = val_1.x;
            result.y = val_1.y;
            result.z = val_1.z;
            val_19 = targetPath.Length;
            if(val_19 < 1)
            {
                goto label_4;
            }
            
            val_19 = targetPath.Length;
            val_20 = targetPath[0];
            TzarGames.Common.Curves.SplineEntity val_2 = this.splineContainer.GetSplineEntityById(splineId:  val_20);
            if(targetPath.Length >= 2)
            {
                goto label_9;
            }
            
            if(distance < 0)
            {
                goto label_10;
            }
            
            val_21 = 0;
            goto label_23;
            label_9:
            TzarGames.Common.Curves.Connection val_5 = 0;
            TzarGames.Common.Curves.Connection val_3 = 0;
            bool val_4 = this.splineContainer.TryGetSplineConnection(splineId:  val_2.Id, tail:  false, connection: out  val_3);
            bool val_6 = this.splineContainer.TryGetSplineConnection(splineId:  val_2.Id, tail:  true, connection: out  val_5);
            val_22 = 3.402823E+38f;
            val_20 = targetPath[1];
            val_23 = val_22;
            if(val_3 != 0)
            {
                    float val_8 = ((val_3.ContainsSplineId(id:  val_20)) != true) ? (val_18) : 3.402823E+38f;
            }
            
            if(val_5 != 0)
            {
                    if((val_5.ContainsSplineId(id:  val_20)) != false)
            {
                    val_20 = val_2.Spline;
                val_22 = ((float)val_2.Spline.<Length>k__BackingField) - val_18;
            }
            
            }
            
            val_21 = 0;
            if((val_8 <= 0f) || (val_8 >= 0))
            {
                goto label_23;
            }
            
            label_10:
            val_21 = 1;
            val_24 = ((float)val_2.Spline.<Length>k__BackingField) - val_18;
            label_23:
            var val_21 = 0;
            val_25 = System.Math.Abs(distance) + val_24;
            goto label_26;
            label_44:
            var val_10 = (targetPath.Length != 0) ? 1 : 0;
            label_26:
            if(val_21 >= targetPath.Length)
            {
                goto label_28;
            }
            
            TzarGames.Common.Curves.SplineEntity val_11 = this.splineContainer.GetSplineEntityById(splineId:  targetPath[0]);
            val_20 = val_11.Spline;
            double val_19 = val_11.Spline.<Length>k__BackingField;
            val_19 = val_25 - (float)val_19;
            val_25 = ((float)val_19 < val_25) ? (val_19) : (-val_25);
            if(val_25 > 0f)
            {
                    int val_20 = targetPath.Length;
                val_20 = val_20 - 1;
                float val_12 = (val_21 == val_20) ? (-(float)val_19) : (val_25);
            }
            
            if(val_12 <= 0f)
            {
                goto label_35;
            }
            
            TzarGames.Common.Curves.Connection val_13 = 0;
            val_20 = this.splineContainer;
            if((val_10 & 1) != 0)
            {
                    val_26 = 0;
            }
            else
            {
                    val_26 = 1;
            }
            
            bool val_14 = val_20.TryGetSplineConnection(splineId:  val_11.Id, tail:  true, connection: out  val_13);
            if(val_13 == 0)
            {
                goto label_40;
            }
            
            val_21 = val_21 + 1;
            if((val_13.GetSplineInfoById(id:  targetPath[(long)val_21])) != null)
            {
                goto label_44;
            }
            
            goto label_44;
            label_35:
            val_25 = System.Math.Abs(val_12);
            if((val_10 & 1) == 0)
            {
                goto label_48;
            }
            
            val_25 = ((float)val_11.Spline.<Length>k__BackingField) - val_25;
            goto label_54;
            label_40:
            UnityEngine.Debug.LogError(message:  0);
            label_4:
            val_27 = 0;
            return (bool)val_27;
            label_48:
            label_54:
            UnityEngine.Vector3 val_16 = val_11.Spline.GetPoint(distance:  val_25);
            result.x = val_16.x;
            result.y = val_16.y;
            result.z = val_16.z;
            label_28:
            val_27 = 1;
            return (bool)val_27;
        }
        public void Go(int[] newPath, float startPointDistance, float endPointDistance)
        {
            float val_11;
            var val_12;
            float val_13;
            var val_14;
            val_11 = startPointDistance;
            if(newPath.Length < 1)
            {
                    return;
            }
            
            this.<Path>k__BackingField = newPath;
            this.<StartPointDistance>k__BackingField = val_11;
            this.<EndPointDistance>k__BackingField = endPointDistance;
            this.currentPathSplineIndex = 0;
            TzarGames.Common.Curves.SplineEntity val_1 = this.splineContainer.GetSplineEntityById(splineId:  newPath[0]);
            mem[1152921511091024624] = 0;
            if((this.<Path>k__BackingField.Length) >= 2)
            {
                goto label_5;
            }
            
            if(val_11 <= endPointDistance)
            {
                goto label_19;
            }
            
            val_12 = 1;
            goto label_7;
            label_5:
            TzarGames.Common.Curves.Connection val_4 = 0;
            TzarGames.Common.Curves.Connection val_2 = 0;
            bool val_3 = this.splineContainer.TryGetSplineConnection(splineId:  val_1.Id, tail:  false, connection: out  val_2);
            bool val_5 = this.splineContainer.TryGetSplineConnection(splineId:  val_1.Id, tail:  true, connection: out  val_4);
            int val_11 = this.<Path>k__BackingField[1];
            val_13 = -1f;
            val_14 = val_13;
            if(val_2 != 0)
            {
                    float val_7 = ((val_2.ContainsSplineId(id:  val_11)) != true) ? (val_11) : -1f;
            }
            
            if(val_4 != 0)
            {
                    if((val_4.ContainsSplineId(id:  val_11)) != false)
            {
                    val_13 = ((float)val_1.Spline.<Length>k__BackingField) - val_11;
            }
            
            }
            
            if((val_7 <= 0f) || (val_7 >= 0))
            {
                goto label_19;
            }
            
            val_12 = 1;
            val_11 = ((float)val_1.Spline.<Length>k__BackingField) - val_11;
            label_7:
            mem[1152921511091024624] = val_12;
            label_19:
            mem[1152921511091024608] = val_1.Spline;
            mem[1152921511091024592] = (double)val_11;
            int val_12 = this.<Path>k__BackingField.Length;
            mem[1152921511091024620] = endPointDistance;
            mem[1152921511091024616] = 1;
            val_12 = val_12 - 1;
            mem[1152921511091024617] = (this.currentPathSplineIndex == val_12) ? 1 : 0;
        }
        protected override void onReachedDestinationDistance()
        {
            mem[1152921511091312856] = 0;
            UnityEngine.Debug.Log(message:  0);
        }
        protected override void onReachedSplineEnd(float diff)
        {
            int val_9;
            TzarGames.Common.Curves.Connection val_3 = 0;
            UnityEngine.Debug.Log(message:  0);
            val_9 = this.currentPathSplineIndex + 1;
            this.currentPathSplineIndex = val_9;
            if(val_9 >= (this.<Path>k__BackingField.Length))
            {
                goto label_6;
            }
            
            val_9 = this.<Path>k__BackingField[this.currentPathSplineIndex];
            TzarGames.Common.Curves.SplineEntity val_1 = this.splineContainer.GetSplineEntityById(splineId:  val_9);
            bool val_4 = this.splineContainer.TryGetSplineConnection(splineId:  this.<Path>k__BackingField[this.currentPathSplineIndex], tail:  (W25 == 0) ? 1 : 0, connection: out  val_3);
            if(val_3 == 0)
            {
                goto label_12;
            }
            
            this.<Path>k__BackingField[this.currentPathSplineIndex] = val_3.ContainsSplineId(id:  val_9);
            if((this.<Path>k__BackingField[this.currentPathSplineIndex]) == false)
            {
                goto label_12;
            }
            
            TzarGames.Common.Curves.ConnectedSplineInfo val_6 = val_3.GetSplineInfoById(id:  val_9);
            mem[1152921511091593008] = val_1.Spline;
            val_9 = this.<Path>k__BackingField;
            mem[1152921511091593024] = val_6.IsTail;
            mem[1152921511091592992] = (double)diff;
            int val_9 = this.<Path>k__BackingField.Length;
            val_9 = val_9 - 1;
            mem[1152921511091593017] = (this.currentPathSplineIndex == val_9) ? 1 : 0;
            return;
            label_6:
            mem[1152921511091593016] = 0;
            return;
            label_12:
            UnityEngine.Debug.LogError(message:  0);
        }
        private void checkGoingToDestination()
        {
            int val_2 = this.<Path>k__BackingField.Length;
            val_2 = val_2 - 1;
            mem[1152921511091909817] = (this.currentPathSplineIndex == val_2) ? 1 : 0;
        }
    
    }

}
