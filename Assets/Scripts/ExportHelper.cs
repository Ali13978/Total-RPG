using UnityEngine;
public class ExportHelper
{
    // Methods
    public ExportHelper()
    {
    
    }
    public static UnityEngine.Vector3 UnityToMayaPosition(UnityEngine.Vector3 t)
    {
        return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    public static UnityEngine.Vector3 UnityToMayaRotation(UnityEngine.Quaternion q)
    {
        UnityEngine.Vector3 val_1 = ExportHelper.WikiQuaternionToRotation(q:  new UnityEngine.Quaternion() {x = q.x, y = q.y, z = q.z, w = q.w}, axisMultiplier:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        return new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
    }
    public static UnityEngine.Vector3 WikiQuaternionToRotation(UnityEngine.Quaternion q, UnityEngine.Vector3 axisMultiplier)
    {
        float val_12;
        q.x = q.w * q.x;
        q.y = q.y * q.z;
        q.x = q.x + q.y;
        float val_1 = q.y * q.y;
        float val_3 = q.x * q.x;
        val_3 = val_3 + val_1;
        val_3 = val_3 + val_3;
        val_12 = 1f;
        float val_4 = val_12 - val_3;
        float val_5 = q.w * q.y;
        q.z = q.z * q.x;
        val_5 = val_5 - q.z;
        val_5 = val_5 + val_5;
        if(val_5 <= val_12)
        {
                val_12 = val_5;
            if(val_5 < 0)
        {
                val_12 = -1f;
        }
        
        }
        
        val_12 = val_12 * 57.29578f;
        float val_7 = q.w * q.z;
        val_7 = val_7 + (q.x * q.y);
        float val_10 = val_1 + (q.z * q.z);
        val_10 = val_10 + val_10;
        val_7 = val_7 + val_7;
        val_10 = 1f - val_10;
        float val_11 = val_7 * 57.29578f;
        float val_12 = axisMultiplier.x;
        float val_13 = axisMultiplier.y;
        val_12 = val_12 * ((q.x + q.x) * 57.29578f);
        val_13 = val_13 * val_12;
        val_11 = axisMultiplier.z * val_11;
        return new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }

}
