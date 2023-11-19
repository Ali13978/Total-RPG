using UnityEngine;
public class Region
{
    // Fields
    public CloudRegionCode Code;
    public string Cluster;
    public string HostAndPort;
    public int Ping;
    
    // Methods
    public Region(CloudRegionCode code)
    {
        this.Code = code;
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
        this.Cluster = code.ToString();
    }
    public Region(CloudRegionCode code, string regionCodeString, string address)
    {
        val_1 = new System.Object();
        this.Code = code;
        this.Cluster = val_1;
        this.HostAndPort = address;
    }
    public static CloudRegionCode Parse(string codeAsString)
    {
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        val_10 = X1;
        if(val_10 != 0)
        {
                int val_1 = val_10.IndexOf(value:  '/');
            if(val_1 >= 1)
        {
                val_11 = val_10.Substring(startIndex:  0, length:  val_1);
            if(val_11 == null)
        {
                val_11 = 0;
        }
        
        }
        
            val_12 = val_11.ToLower();
            if((System.Enum.IsDefined(enumType:  0, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) != false)
        {
                object val_7 = System.Enum.Parse(enumType:  0, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_12 = null;
            UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            return (CloudRegionCode)val_13;
        }
        
        }
        
        val_13 = 4;
        return (CloudRegionCode)val_13;
    }
    internal static CloudRegionFlag ParseFlag(CloudRegionCode region)
    {
        object val_11;
        var val_12;
        var val_13;
        val_11 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        val_12 = ???;
        string val_2 = ???.ToString();
        UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
        if((System.Enum.IsDefined(enumType:  0, value:  val_11)) != false)
        {
                val_12 = null;
            string val_6 = null.ToString();
            UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y});
            object val_8 = System.Enum.Parse(enumType:  0, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_11 = null;
            UnityEngine.Vector2 val_9 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y});
            return (CloudRegionFlag)val_13;
        }
        
        val_13 = 0;
        return (CloudRegionFlag)val_13;
    }
    [System.ObsoleteAttribute]
    internal static CloudRegionFlag ParseFlag(string codeAsString)
    {
        var val_8;
        var val_9;
        val_8 = X1.ToLower();
        if((System.Enum.IsDefined(enumType:  0, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) != false)
        {
                object val_5 = System.Enum.Parse(enumType:  0, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            val_8 = null;
            UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
            return (CloudRegionFlag)val_9;
        }
        
        val_9 = 0;
        return (CloudRegionFlag)val_9;
    }
    public override string ToString()
    {
        return (string)System.String.Format(format:  0, arg0:  "\'{0}\' \t{1}ms \t{2}", arg1:  this.Cluster, arg2:  this.Ping);
    }

}
