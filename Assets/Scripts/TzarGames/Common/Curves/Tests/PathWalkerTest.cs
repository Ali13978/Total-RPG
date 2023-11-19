using UnityEngine;

namespace TzarGames.Common.Curves.Tests
{
    public class PathWalkerTest : MonoBehaviour
    {
        // Fields
        private TzarGames.Common.Curves.SplineEntity spline1;
        private TzarGames.Common.Curves.SplineEntity spline2;
        private TzarGames.Common.Curves.SplineEntity spline3;
        private TzarGames.Common.Curves.PathWalker walker;
        [UnityEngine.SerializeField]
        private float traverseDistanceRange;
        [UnityEngine.SerializeField]
        private bool useTraverseRangeAsDistance;
        [UnityEngine.SerializeField]
        private bool zeroStartPoint;
        [UnityEngine.SerializeField]
        private TzarGames.Common.Curves.Tests.PathWalkerTest.PathWalkerTestType testType;
        
        // Methods
        public PathWalkerTest()
        {
            this.traverseDistanceRange = 50f;
        }
        private void Start()
        {
            object val_16;
            IntPtr val_17;
            TzarGames.Common.Curves.PathWalker val_18;
            TzarGames.Common.Curves.SplineEntity val_19;
            val_16 = this;
            TzarGames.Common.Curves.BezierSplineContainer val_2 = this.gameObject.AddComponent<TzarGames.Common.Curves.BezierSplineContainer>();
            this.walker = this.gameObject.AddComponent<TzarGames.Common.Curves.PathWalker>();
            val_17 = System.Void TzarGames.Common.Curves.Tests.PathWalkerTest::onDestinationReached();
            mem2[0] = new System.Action(object:  this, method:  val_17);
            val_18 = this.walker;
            this.walker.splineContainer = val_2;
            if(this.testType != 1)
            {
                    if(this.testType != 0)
            {
                    return;
            }
            
                val_17 = 1152921505860859728;
                typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_28 = 0;
                typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_20 = 0;
                typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_34 = 0;
                typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_2C = 0;
                typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_40 = 0;
                typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_38 = 0;
                typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_4C = 0;
                typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_44 = 0;
                this.spline1 = val_2.AddNewSpline(spline:  new TzarGames.Common.Curves.BezierSpline(splinePoints:  null));
                typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_28 = 0;
                typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_20 = 0;
                typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_34 = 0;
                typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_2C = 0;
                typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_40 = 0;
                typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_38 = 0;
                typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_4C = 0;
                typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_44 = 0;
                val_19 = val_2.AddNewSpline(spline:  new TzarGames.Common.Curves.BezierSpline(splinePoints:  null));
                this.spline2 = val_19;
                if(this.spline1 == null)
            {
                    val_19 = this.spline2;
            }
            
                val_2.AddConnection(firstSplineId:  this.spline1.Id, firstTail:  true, secondSplineId:  this.spline2.Id, secondTail:  true);
                val_2.AddConnection(firstSplineId:  this.spline1.Id, firstTail:  false, secondSplineId:  this.spline2.Id, secondTail:  false);
                val_18 = null;
                typeof(System.Int32[]).__il2cppRuntimeField_20 = this.spline1.Id;
                typeof(System.Int32[]).__il2cppRuntimeField_24 = this.spline2.Id;
                val_16 = this.spline2.Spline;
                float val_16 = 0.2f;
                float val_17 = 0.9f;
                val_16 = ((float)this.spline1.Spline.<Length>k__BackingField) * val_16;
                val_17 = ((float)this.spline2.Spline.<Length>k__BackingField) * val_17;
                this.walker.Go(newPath:  val_18, startPointDistance:  val_16, endPointDistance:  val_17);
                return;
            }
            
            val_17 = 1152921505860859728;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_28 = 0;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_20 = 0;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_34 = 0;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_2C = 0;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_40 = 0;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_38 = 0;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_4C = 0;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_44 = 0;
            this.spline1 = val_2.AddNewSpline(spline:  new TzarGames.Common.Curves.BezierSpline(splinePoints:  null));
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_28 = 0;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_20 = 0;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_34 = 0;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_2C = 0;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_40 = 0;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_38 = 0;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_4C = 0;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_44 = 0;
            this.spline2 = val_2.AddNewSpline(spline:  new TzarGames.Common.Curves.BezierSpline(splinePoints:  null));
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_28 = 0;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_20 = 0;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_34 = 0;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_2C = 0;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_40 = 0;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_38 = 0;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_4C = 0;
            typeof(UnityEngine.Vector3[]).__il2cppRuntimeField_44 = 0;
            this.spline3 = val_2.AddNewSpline(spline:  new TzarGames.Common.Curves.BezierSpline(splinePoints:  null));
            val_2.AddConnection(firstSplineId:  this.spline1.Id, firstTail:  true, secondSplineId:  this.spline2.Id, secondTail:  true);
            val_18 = this.spline2.Id;
            val_16 = this.spline3.Id;
            val_2.AddConnection(firstSplineId:  val_18, firstTail:  false, secondSplineId:  val_16, secondTail:  false);
        }
        private void OnGUI()
        {
            var val_9;
            System.Int32[] val_10;
            float val_12;
            float val_13;
            val_9 = this;
            if(this.testType != 1)
            {
                    return;
            }
            
            val_10 = null;
            if((UnityEngine.GUILayout.Button(text:  0, options:  "Test traverse")) == false)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            if(this.zeroStartPoint != false)
            {
                    val_12 = 0f;
            }
            else
            {
                    val_12 = UnityEngine.Random.Range(min:  0f, max:  (float)this.spline1.Spline.<Length>k__BackingField);
            }
            
            val_13 = this.traverseDistanceRange;
            if(this.useTraverseRangeAsDistance != true)
            {
                    val_13 = UnityEngine.Random.Range(min:  0f, max:  val_13);
            }
            
            val_10 = null;
            typeof(System.Int32[]).__il2cppRuntimeField_20 = this.spline1.Id;
            typeof(System.Int32[]).__il2cppRuntimeField_24 = this.spline2.Id;
            typeof(System.Int32[]).__il2cppRuntimeField_28 = this.spline3.Id;
            if((this.walker.TraversePath(targetPath:  val_10, startPointDistance:  val_12, distance:  val_13, result: out  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z})) != false)
            {
                    this.transform.position = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
            }
            else
            {
                    UnityEngine.Debug.LogError(message:  0);
            }
            
            val_9 = 0 + "Start point: "("Start point: ");
            UnityEngine.Debug.Log(message:  0);
            string val_8 = 0 + "Dist: "("Dist: ");
            UnityEngine.Debug.Log(message:  0);
        }
        private void onDestinationReached()
        {
            if(this.testType != 0)
            {
                    return;
            }
            
            this.spline1 = this.spline2;
            this.spline2 = this.spline1;
            typeof(System.Int32[]).__il2cppRuntimeField_20 = this.spline1.Id;
            typeof(System.Int32[]).__il2cppRuntimeField_24 = this.spline2.Id;
            float val_2 = (float)this.spline1.Spline.<Length>k__BackingField;
            val_2 = val_2 * 0.2f;
            this.walker.Go(newPath:  null, startPointDistance:  val_2, endPointDistance:  ((float)this.spline2.Spline.<Length>k__BackingField) * 0.9f);
        }
    
    }

}
