using UnityEngine;
private class SA_iTween.CRSpline
{
    // Fields
    public UnityEngine.Vector3[] pts;
    
    // Methods
    public SA_iTween.CRSpline(UnityEngine.Vector3[] pts)
    {
        this.pts = null;
        System.Array.Copy(sourceArray:  0, destinationArray:  pts, length:  1254012752);
    }
    public UnityEngine.Vector3 Interp(float t)
    {
        float val_2 = ((float)this.pts.Length - 3) * t;
        int val_4 = this.pts.Length - 4;
        int val_5 = UnityEngine.Mathf.Min(a:  0, b:  UnityEngine.Mathf.FloorToInt(f:  val_2));
        var val_32 = 12;
        val_32 = this.pts + ((long)val_5 * val_32);
        var val_33 = 12;
        val_33 = this.pts + (((long)val_5 + 1) * val_33);
        var val_34 = 12;
        val_34 = this.pts + (((long)val_5 + 2) * val_34);
        var val_35 = 12;
        val_35 = this.pts + (((long)val_5 + 3) * val_35);
        float val_9 = val_2 - (float)val_5;
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = ((long)(int)(val_5) * 12) + this.pts + 32, y = ((long)(int)(val_5) * 12) + this.pts + 32 + 4, z = ((long)(int)(val_5) * 12) + this.pts + 40});
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Multiply(d:  3f, a:  new UnityEngine.Vector3() {x = ((long)(int)((val_5 + 1)) * 12) + this.pts + 32, y = ((long)(int)((val_5 + 1)) * 12) + this.pts + 32 + 4, z = ((long)(int)((val_5 + 1)) * 12) + this.pts + 40});
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, b:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Multiply(d:  3f, a:  new UnityEngine.Vector3() {x = ((long)(int)((val_5 + 2)) * 12) + this.pts + 32, y = ((long)(int)((val_5 + 2)) * 12) + this.pts + 36, z = ((long)(int)((val_5 + 2)) * 12) + this.pts + 40});
        UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, b:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
        UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, b:  new UnityEngine.Vector3() {x = ((long)(int)((val_5 + 3)) * 12) + this.pts + 32, y = ((long)(int)((val_5 + 3)) * 12) + this.pts + 36, z = ((long)(int)((val_5 + 3)) * 12) + this.pts + 40});
        float val_36 = val_9;
        float val_16 = val_36 * val_36;
        val_36 = val_36 * val_16;
        UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, d:  val_36);
        UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Multiply(d:  2f, a:  new UnityEngine.Vector3() {x = ((long)(int)(val_5) * 12) + this.pts + 32, y = ((long)(int)(val_5) * 12) + this.pts + 32 + 4, z = ((long)(int)(val_5) * 12) + this.pts + 40});
        UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Multiply(d:  5f, a:  new UnityEngine.Vector3() {x = ((long)(int)((val_5 + 1)) * 12) + this.pts + 32, y = ((long)(int)((val_5 + 1)) * 12) + this.pts + 32 + 4, z = ((long)(int)((val_5 + 1)) * 12) + this.pts + 40});
        UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z}, b:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z});
        UnityEngine.Vector3 val_21 = UnityEngine.Vector3.op_Multiply(d:  4f, a:  new UnityEngine.Vector3() {x = ((long)(int)((val_5 + 2)) * 12) + this.pts + 32, y = ((long)(int)((val_5 + 2)) * 12) + this.pts + 36, z = ((long)(int)((val_5 + 2)) * 12) + this.pts + 40});
        UnityEngine.Vector3 val_22 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z}, b:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z});
        UnityEngine.Vector3 val_23 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z}, b:  new UnityEngine.Vector3() {x = ((long)(int)((val_5 + 3)) * 12) + this.pts + 32, y = ((long)(int)((val_5 + 3)) * 12) + this.pts + 36, z = ((long)(int)((val_5 + 3)) * 12) + this.pts + 40});
        UnityEngine.Vector3 val_24 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z}, d:  val_16);
        UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z}, b:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z});
        UnityEngine.Vector3 val_26 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = ((long)(int)(val_5) * 12) + this.pts + 32, y = ((long)(int)(val_5) * 12) + this.pts + 32 + 4, z = ((long)(int)(val_5) * 12) + this.pts + 40});
        UnityEngine.Vector3 val_27 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z}, b:  new UnityEngine.Vector3() {x = ((long)(int)((val_5 + 2)) * 12) + this.pts + 32, y = ((long)(int)((val_5 + 2)) * 12) + this.pts + 36, z = ((long)(int)((val_5 + 2)) * 12) + this.pts + 40});
        UnityEngine.Vector3 val_28 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z}, d:  val_9);
        UnityEngine.Vector3 val_29 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z}, b:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z});
        UnityEngine.Vector3 val_30 = UnityEngine.Vector3.op_Multiply(d:  2f, a:  new UnityEngine.Vector3() {x = ((long)(int)((val_5 + 1)) * 12) + this.pts + 32, y = ((long)(int)((val_5 + 1)) * 12) + this.pts + 32 + 4, z = ((long)(int)((val_5 + 1)) * 12) + this.pts + 40});
        UnityEngine.Vector3 val_31 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z}, b:  new UnityEngine.Vector3() {x = val_30.x, y = val_30.y, z = val_30.z});
        return UnityEngine.Vector3.op_Multiply(d:  0.5f, a:  new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_31.z});
    }

}
