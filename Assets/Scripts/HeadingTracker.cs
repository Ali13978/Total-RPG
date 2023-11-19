using UnityEngine;
private class CinemachineOrbitalTransposer.HeadingTracker
{
    // Fields
    private Cinemachine.CinemachineOrbitalTransposer.HeadingTracker.Item[] mHistory;
    private int mTop;
    private int mBottom;
    private int mCount;
    private UnityEngine.Vector3 mHeadingSum;
    private float mWeightSum;
    private float mWeightTime;
    private UnityEngine.Vector3 mLastGoodHeading;
    private static float mDecayExponent;
    
    // Properties
    public int FilterSize { get; }
    
    // Methods
    public CinemachineOrbitalTransposer.HeadingTracker(int filterSize)
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this.mLastGoodHeading = val_1;
        mem[1152921511717736588] = val_1.y;
        mem[1152921511717736592] = val_1.z;
        this.mHistory = null;
        float val_3 = -0.6931472f;
        val_3 = val_3 / ((float)filterSize / 5f);
        CinemachineOrbitalTransposer.HeadingTracker.mDecayExponent = val_3;
        this.ClearHistory();
    }
    public int get_FilterSize()
    {
        if(this.mHistory != null)
        {
                return (int)this.mHistory.Length;
        }
        
        return (int)this.mHistory.Length;
    }
    private void ClearHistory()
    {
        this.mWeightSum = 0f;
        this.mCount = 0;
        this.mTop = 0;
        this.mBottom = 0;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this.mHeadingSum = val_1;
        mem[1152921511718034296] = val_1.y;
        mem[1152921511718034300] = val_1.z;
    }
    private static float Decay(float time)
    {
        time = CinemachineOrbitalTransposer.HeadingTracker.mDecayExponent * time;
    }
    public void Add(UnityEngine.Vector3 velocity)
    {
        float val_6;
        float val_7;
        val_6 = velocity.z;
        val_7 = velocity.x;
        if(this.mHistory.Length != 0)
        {
                if(velocity.x <= 0.0001f)
        {
                return;
        }
        
            val_6 = val_7;
            val_7 = val_6;
            float val_1 = UnityEngine.Time.time;
            if(this.mCount == this.mHistory.Length)
        {
                this.PopBottom();
        }
        
            int val_6 = this.mCount;
            val_6 = val_6 + 1;
            this.mCount = val_6;
            int val_2 = this.mHistory + (this.mTop * 20);
            mem2[0] = val_6;
            mem2[0] = velocity.y;
            mem2[0] = val_7;
            mem2[0] = velocity.x;
            mem2[0] = val_1;
            int val_3 = this.mTop + 1;
            this.mTop = val_3;
            if(val_3 == this.mHistory.Length)
        {
                this.mTop = 0;
        }
        
            float val_7 = this.mWeightTime;
            val_7 = val_1 - val_7;
            float val_4 = CinemachineOrbitalTransposer.HeadingTracker.Decay(time:  val_7);
            val_4 = this.mWeightSum * val_4;
            val_4 = velocity.x + val_4;
            this.mWeightSum = val_4;
            this.mWeightTime = val_1;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.mHeadingSum, y = val_1, z = velocity.x}, b:  new UnityEngine.Vector3() {x = val_6, y = velocity.y, z = val_7});
            this.mHeadingSum = val_5;
            mem[1152921511718405752] = val_5.y;
            mem[1152921511718405756] = val_5.z;
            return;
        }
        
        this.mLastGoodHeading = velocity;
        mem[1152921511718405772] = velocity.y;
        mem[1152921511718405776] = val_6;
    }
    private void PopBottom()
    {
        if(this.mCount < 1)
        {
                return;
        }
        
        float val_1 = UnityEngine.Time.time;
        int val_2 = this.mHistory + (this.mBottom * 20);
        int val_3 = this.mBottom + 1;
        this.mBottom = val_3;
        if(val_3 == this.mHistory.Length)
        {
                this.mBottom = 0;
        }
        
        int val_8 = this.mCount;
        val_1 = val_1 - ((this.mBottom * 20) + this.mHistory + 48);
        val_8 = val_8 - 1;
        this.mCount = val_8;
        float val_4 = CinemachineOrbitalTransposer.HeadingTracker.Decay(time:  val_1);
        float val_9 = this.mWeightSum;
        val_9 = val_9 - (((this.mBottom * 20) + this.mHistory + 40 + 4) * val_4);
        this.mWeightSum = val_9;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = (this.mBottom * 20) + this.mHistory + 32, y = (this.mBottom * 20) + this.mHistory + 32 + 4, z = (this.mBottom * 20) + this.mHistory + 40}, d:  val_4);
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.mHeadingSum, y = (this.mBottom * 20) + this.mHistory + 40 + 4, z = val_1}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
        this.mHeadingSum = val_7;
        mem[1152921511718738936] = val_7.y;
        mem[1152921511718738940] = val_7.z;
        if((this.mWeightSum > 0.0001f) && (this.mCount != 0))
        {
                return;
        }
        
        this.ClearHistory();
    }
    public void DecayHistory()
    {
        float val_1 = UnityEngine.Time.time;
        val_1 = val_1 - this.mWeightTime;
        float val_2 = CinemachineOrbitalTransposer.HeadingTracker.Decay(time:  val_1);
        float val_4 = this.mWeightSum;
        val_4 = val_2 * val_4;
        this.mWeightSum = val_4;
        this.mWeightTime = val_1;
        if(val_4 < 0)
        {
                this.ClearHistory();
            return;
        }
        
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.mHeadingSum, y = V10.16B, z = val_1}, d:  val_2);
        this.mHeadingSum = val_3;
        mem[1152921511718924664] = val_3.y;
        mem[1152921511718924668] = val_3.z;
    }
    public UnityEngine.Vector3 GetReliableHeading()
    {
        float val_5 = 0.0001f;
        if(this.mWeightSum <= val_5)
        {
                return new UnityEngine.Vector3() {x = this.mLastGoodHeading, y = val_2.y, z = val_2.z};
        }
        
        if(this.mCount != this.mHistory.Length)
        {
                if((Cinemachine.Utility.UnityVectorExtensions.AlmostZero(v:  new UnityEngine.Vector3() {x = this.mLastGoodHeading, y = val_5})) == false)
        {
                return new UnityEngine.Vector3() {x = this.mLastGoodHeading, y = val_2.y, z = val_2.z};
        }
        
        }
        
        val_5 = V10.16B;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = this.mHeadingSum, y = val_5, z = V9.16B}, d:  this.mWeightSum);
        if((Cinemachine.Utility.UnityVectorExtensions.AlmostZero(v:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z})) == true)
        {
                return new UnityEngine.Vector3() {x = this.mLastGoodHeading, y = val_2.y, z = val_2.z};
        }
        
        this.mLastGoodHeading = val_2;
        mem[1152921511719073548] = val_2.y;
        mem[1152921511719073552] = val_2.z;
        return new UnityEngine.Vector3() {x = this.mLastGoodHeading, y = val_2.y, z = val_2.z};
    }

}
