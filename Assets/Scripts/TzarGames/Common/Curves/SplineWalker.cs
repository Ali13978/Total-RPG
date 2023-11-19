using UnityEngine;

namespace TzarGames.Common.Curves
{
    public class SplineWalker : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private float speed;
        private double currentDistance;
        private float currentSpeed;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private TzarGames.Common.Curves.BezierSpline <Spline>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private bool <MoveEnabled>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private bool <IsGoingToDestination>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private float <DestinationDistance>k__BackingField;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private bool <ReverseDestination>k__BackingField;
        public System.Action<float> OnReachedSplineEnd;
        public System.Action OnReachedDestinationDistance;
        
        // Properties
        public TzarGames.Common.Curves.BezierSpline Spline { get; set; }
        public double CurrentDistance { get; set; }
        public bool MoveEnabled { get; set; }
        public bool IsGoingToDestination { get; set; }
        public float DestinationDistance { get; set; }
        public bool ReverseDestination { get; set; }
        
        // Methods
        public SplineWalker()
        {
            this.speed = 1f;
        }
        public TzarGames.Common.Curves.BezierSpline get_Spline()
        {
            return (TzarGames.Common.Curves.BezierSpline)this.<Spline>k__BackingField;
        }
        public void set_Spline(TzarGames.Common.Curves.BezierSpline value)
        {
            this.<Spline>k__BackingField = value;
        }
        public double get_CurrentDistance()
        {
            return (double)this.currentDistance;
        }
        public void set_CurrentDistance(double value)
        {
            this.currentDistance = value;
        }
        public bool get_MoveEnabled()
        {
            return (bool)this.<MoveEnabled>k__BackingField;
        }
        public void set_MoveEnabled(bool value)
        {
            this.<MoveEnabled>k__BackingField = value;
        }
        public bool get_IsGoingToDestination()
        {
            return (bool)this.<IsGoingToDestination>k__BackingField;
        }
        public void set_IsGoingToDestination(bool value)
        {
            this.<IsGoingToDestination>k__BackingField = value;
        }
        public float get_DestinationDistance()
        {
            return (float)this.<DestinationDistance>k__BackingField;
        }
        public void set_DestinationDistance(float value)
        {
            this.<DestinationDistance>k__BackingField = value;
        }
        public bool get_ReverseDestination()
        {
            return (bool)this.<ReverseDestination>k__BackingField;
        }
        public void set_ReverseDestination(bool value)
        {
            this.<ReverseDestination>k__BackingField = value;
        }
        protected virtual void onReachedSplineEnd(float diff)
        {
        
        }
        protected virtual void onReachedDestinationDistance()
        {
        
        }
        protected virtual void Update()
        {
            double val_6;
            if((this.<Spline>k__BackingField) == null)
            {
                    return;
            }
            
            if((this.<MoveEnabled>k__BackingField) == false)
            {
                    return;
            }
            
            val_6 = this.currentDistance;
            if(val_6 >= 0)
            {
                    return;
            }
            
            float val_1 = UnityEngine.Time.deltaTime;
            float val_7 = this.speed;
            val_1 = val_1 * val_7;
            double val_6 = (double)val_1;
            val_6 = val_6 + val_6;
            val_7 = (val_6 > (this.<Spline>k__BackingField.<Length>k__BackingField)) ? this.<Spline>k__BackingField.<Length>k__BackingField : (val_6);
            this.currentDistance = val_7;
            if((((this.<IsGoingToDestination>k__BackingField) != false) && (val_6 < 0)) && (val_7 >= ((double)this.<DestinationDistance>k__BackingField)))
            {
                    this.currentDistance = (double)this.<DestinationDistance>k__BackingField;
                if(this.OnReachedDestinationDistance != null)
            {
                    this.OnReachedDestinationDistance.Invoke();
            }
            
            }
            
            UnityEngine.Vector3 val_5 = this.<Spline>k__BackingField.GetPoint(distance:  (float)((this.<ReverseDestination>k__BackingField) == true) ? ((this.<Spline>k__BackingField.<Length>k__BackingField) - this.currentDistance) : this.currentDistance);
            val_6 = val_5.x;
            this.transform.position = new UnityEngine.Vector3() {x = val_6, y = val_5.y, z = val_5.z};
            double val_8 = this.currentDistance;
            if(val_8 < (this.<Spline>k__BackingField.<Length>k__BackingField))
            {
                    return;
            }
            
            val_8 = val_8 - (this.<Spline>k__BackingField.<Length>k__BackingField);
            val_6 = (float)val_8;
            if(this.OnReachedSplineEnd == null)
            {
                    return;
            }
            
            this.OnReachedSplineEnd.Invoke(obj:  val_6);
        }
        private void OnDrawGizmos()
        {
        
        }
    
    }

}
