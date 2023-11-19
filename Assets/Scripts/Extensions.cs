using UnityEngine;
[System.Runtime.CompilerServices.ExtensionAttribute]
public static class Extensions
{
    // Fields
    public static System.Collections.Generic.Dictionary<System.Reflection.MethodInfo, System.Reflection.ParameterInfo[]> ParametersOfMethods;
    
    // Methods
    [System.Runtime.CompilerServices.ExtensionAttribute]
    public static System.Reflection.ParameterInfo[] GetCachedParemeters(System.Reflection.MethodInfo mo)
    {
        System.Collections.Generic.Dictionary<System.Reflection.MethodInfo, System.Reflection.ParameterInfo[]> val_4;
        var val_5;
        var val_6;
        System.Reflection.ParameterInfo[] val_7;
        val_4 = 1152921504971223040;
        val_5 = null;
        val_5 = null;
        if((Extensions.ParametersOfMethods.TryGetValue(key:  X1, value: out  0)) == true)
        {
                return val_7;
        }
        
        val_6 = null;
        val_7 = X1;
        val_6 = null;
        val_7 = val_7;
        val_4 = Extensions.ParametersOfMethods;
        val_4.set_Item(key:  X1, value:  val_7);
        return val_7;
    }
    [System.Runtime.CompilerServices.ExtensionAttribute]
    public static PhotonView[] GetPhotonViewsInChildren(UnityEngine.GameObject go)
    {
        if(X1 != 0)
        {
                return X1.GetComponentsInChildren<PhotonView>(includeInactive:  true);
        }
        
        return X1.GetComponentsInChildren<PhotonView>(includeInactive:  true);
    }
    [System.Runtime.CompilerServices.ExtensionAttribute]
    public static PhotonView GetPhotonView(UnityEngine.GameObject go)
    {
        if(X1 != 0)
        {
                return X1.GetComponent<PhotonView>();
        }
        
        return X1.GetComponent<PhotonView>();
    }
    [System.Runtime.CompilerServices.ExtensionAttribute]
    public static bool AlmostEquals(UnityEngine.Vector3 target, UnityEngine.Vector3 second, float sqrMagnitudePrecision)
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = target.x, y = target.y, z = target.z}, b:  new UnityEngine.Vector3() {x = second.x, y = second.y, z = second.z});
        return (bool)(val_1.x < 0) ? 1 : 0;
    }
    [System.Runtime.CompilerServices.ExtensionAttribute]
    public static bool AlmostEquals(UnityEngine.Vector2 target, UnityEngine.Vector2 second, float sqrMagnitudePrecision)
    {
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = target.x, y = target.y}, b:  new UnityEngine.Vector2() {x = second.x, y = second.y});
        return (bool)(val_1.x.sqrMagnitude < 0) ? 1 : 0;
    }
    [System.Runtime.CompilerServices.ExtensionAttribute]
    public static bool AlmostEquals(UnityEngine.Quaternion target, UnityEngine.Quaternion second, float maxAngle)
    {
        return (bool)((UnityEngine.Quaternion.Angle(a:  new UnityEngine.Quaternion() {x = target.x, y = target.y, z = target.z, w = target.w}, b:  new UnityEngine.Quaternion() {x = second.x, y = second.y, z = second.z, w = second.w})) < 0) ? 1 : 0;
    }
    [System.Runtime.CompilerServices.ExtensionAttribute]
    public static bool AlmostEquals(float target, float second, float floatDiff)
    {
        target = target - second;
        return (bool)(System.Math.Abs(target) < 0) ? 1 : 0;
    }
    [System.Runtime.CompilerServices.ExtensionAttribute]
    public static void Merge(System.Collections.IDictionary target, System.Collections.IDictionary addHash)
    {
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        val_18 = X2;
        if(val_18 == 0)
        {
                return;
        }
        
        if(((addHash & 1) & 1) != 0)
        {
                return;
        }
        
        var val_17 = val_18;
        if((X2 + 258) == 0)
        {
            goto label_4;
        }
        
        var val_14 = X2 + 152;
        var val_15 = 0;
        val_14 = val_14 + 8;
        label_6:
        if(((X2 + 152 + 8) + -8) == null)
        {
            goto label_5;
        }
        
        val_15 = val_15 + 1;
        val_14 = val_14 + 16;
        if(val_15 < (X2 + 258))
        {
            goto label_6;
        }
        
        label_4:
        val_19 = 4;
        val_20 = val_18;
        goto label_7;
        label_5:
        var val_16 = val_14;
        val_16 = val_16 + 4;
        val_17 = val_17 + val_16;
        val_20 = val_17 + 272;
        label_7:
        var val_20 = val_18;
        if((X2 + 258) == 0)
        {
            goto label_9;
        }
        
        var val_18 = X2 + 152;
        var val_19 = 0;
        val_18 = val_18 + 8;
        label_11:
        if(((X2 + 152 + 8) + -8) == null)
        {
            goto label_10;
        }
        
        val_19 = val_19 + 1;
        val_18 = val_18 + 16;
        if(val_19 < (X2 + 258))
        {
            goto label_11;
        }
        
        label_9:
        val_19 = 0;
        val_21 = val_18;
        goto label_12;
        label_10:
        val_20 = val_20 + (((X2 + 152 + 8)) << 4);
        val_21 = val_20 + 272;
        label_12:
        label_33:
        var val_24 = val_18;
        if((X2 + 258) == 0)
        {
            goto label_14;
        }
        
        var val_21 = X2 + 152;
        var val_22 = 0;
        val_21 = val_21 + 8;
        label_16:
        if(((X2 + 152 + 8) + -8) == null)
        {
            goto label_15;
        }
        
        val_22 = val_22 + 1;
        val_21 = val_21 + 16;
        if(val_22 < (X2 + 258))
        {
            goto label_16;
        }
        
        label_14:
        val_19 = 1;
        val_22 = val_18;
        goto label_17;
        label_15:
        var val_23 = val_21;
        val_23 = val_23 + 1;
        val_24 = val_24 + val_23;
        val_22 = val_24 + 272;
        label_17:
        if(((val_18 & 1) & 1) == 0)
        {
            goto label_41;
        }
        
        var val_27 = val_18;
        if((X2 + 258) == 0)
        {
            goto label_20;
        }
        
        var val_25 = X2 + 152;
        var val_26 = 0;
        val_25 = val_25 + 8;
        label_22:
        if(((X2 + 152 + 8) + -8) == null)
        {
            goto label_21;
        }
        
        val_26 = val_26 + 1;
        val_25 = val_25 + 16;
        if(val_26 < (X2 + 258))
        {
            goto label_22;
        }
        
        label_20:
        val_19 = 0;
        val_23 = val_18;
        goto label_23;
        label_21:
        val_27 = val_27 + (((X2 + 152 + 8)) << 4);
        val_23 = val_27 + 272;
        label_23:
        var val_31 = val_18;
        if((X2 + 258) == 0)
        {
            goto label_24;
        }
        
        var val_28 = X2 + 152;
        var val_29 = 0;
        val_28 = val_28 + 8;
        label_26:
        if(((X2 + 152 + 8) + -8) == null)
        {
            goto label_25;
        }
        
        val_29 = val_29 + 1;
        val_28 = val_28 + 16;
        if(val_29 < (X2 + 258))
        {
            goto label_26;
        }
        
        label_24:
        val_19 = 2;
        val_24 = val_18;
        goto label_27;
        label_25:
        var val_30 = val_28;
        val_30 = val_30 + 2;
        val_31 = val_31 + val_30;
        val_24 = val_31 + 272;
        label_27:
        var val_32 = 0;
        val_32 = val_32 + 1;
        val_25 = addHash;
        goto label_33;
        label_41:
        val_26 = 1152921504608124928;
        if(val_18 == 0)
        {
            goto label_34;
        }
        
        var val_35 = val_18;
        if((X2 + 258) == 0)
        {
            goto label_35;
        }
        
        var val_33 = X2 + 152;
        var val_34 = 0;
        val_33 = val_33 + 8;
        label_37:
        if(((X2 + 152 + 8) + -8) == null)
        {
            goto label_36;
        }
        
        val_34 = val_34 + 1;
        val_33 = val_33 + 16;
        if(val_34 < (X2 + 258))
        {
            goto label_37;
        }
        
        label_35:
        val_27 = val_18;
        goto label_38;
        label_36:
        val_35 = val_35 + (((X2 + 152 + 8)) << 4);
        val_27 = val_35 + 272;
        label_38:
        label_34:
        if(0 == 93)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_18 = ???;
        val_17 = ???;
        val_26 = ???;
    }
    [System.Runtime.CompilerServices.ExtensionAttribute]
    public static void MergeStringKeys(System.Collections.IDictionary target, System.Collections.IDictionary addHash)
    {
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        val_18 = X2;
        if(val_18 == 0)
        {
                return;
        }
        
        if(((addHash & 1) & 1) != 0)
        {
                return;
        }
        
        var val_17 = val_18;
        if((X2 + 258) == 0)
        {
            goto label_4;
        }
        
        var val_14 = X2 + 152;
        var val_15 = 0;
        val_14 = val_14 + 8;
        label_6:
        if(((X2 + 152 + 8) + -8) == null)
        {
            goto label_5;
        }
        
        val_15 = val_15 + 1;
        val_14 = val_14 + 16;
        if(val_15 < (X2 + 258))
        {
            goto label_6;
        }
        
        label_4:
        val_19 = 4;
        val_20 = val_18;
        goto label_7;
        label_5:
        var val_16 = val_14;
        val_16 = val_16 + 4;
        val_17 = val_17 + val_16;
        val_20 = val_17 + 272;
        label_7:
        var val_20 = val_18;
        if((X2 + 258) == 0)
        {
            goto label_9;
        }
        
        var val_18 = X2 + 152;
        var val_19 = 0;
        val_18 = val_18 + 8;
        label_11:
        if(((X2 + 152 + 8) + -8) == null)
        {
            goto label_10;
        }
        
        val_19 = val_19 + 1;
        val_18 = val_18 + 16;
        if(val_19 < (X2 + 258))
        {
            goto label_11;
        }
        
        label_9:
        val_19 = 0;
        val_21 = val_18;
        goto label_12;
        label_10:
        val_20 = val_20 + (((X2 + 152 + 8)) << 4);
        val_21 = val_20 + 272;
        label_12:
        val_22 = 1152921504608018432;
        val_17 = val_18;
        label_35:
        var val_24 = val_17;
        if((X2 + 258) == 0)
        {
            goto label_14;
        }
        
        var val_21 = X2 + 152;
        var val_22 = 0;
        val_21 = val_21 + 8;
        label_16:
        if(((X2 + 152 + 8) + -8) == null)
        {
            goto label_15;
        }
        
        val_22 = val_22 + 1;
        val_21 = val_21 + 16;
        if(val_22 < (X2 + 258))
        {
            goto label_16;
        }
        
        label_14:
        val_19 = 1;
        val_23 = val_17;
        goto label_17;
        label_15:
        var val_23 = val_21;
        val_23 = val_23 + 1;
        val_24 = val_24 + val_23;
        val_23 = val_24 + 272;
        label_17:
        if(((val_17 & 1) & 1) == 0)
        {
            goto label_18;
        }
        
        var val_27 = val_17;
        if((X2 + 258) == 0)
        {
            goto label_20;
        }
        
        var val_25 = X2 + 152;
        var val_26 = 0;
        val_25 = val_25 + 8;
        label_22:
        if(((X2 + 152 + 8) + -8) == null)
        {
            goto label_21;
        }
        
        val_26 = val_26 + 1;
        val_25 = val_25 + 16;
        if(val_26 < (X2 + 258))
        {
            goto label_22;
        }
        
        label_20:
        val_19 = 0;
        val_24 = val_17;
        goto label_23;
        label_21:
        val_27 = val_27 + (((X2 + 152 + 8)) << 4);
        val_24 = val_27 + 272;
        label_23:
        if((val_17 == 0) || (val_17 != null))
        {
            goto label_35;
        }
        
        var val_31 = val_18;
        if((X2 + 258) == 0)
        {
            goto label_26;
        }
        
        var val_28 = X2 + 152;
        var val_29 = 0;
        val_28 = val_28 + 8;
        label_28:
        if(((X2 + 152 + 8) + -8) == null)
        {
            goto label_27;
        }
        
        val_29 = val_29 + 1;
        val_28 = val_28 + 16;
        if(val_29 < (X2 + 258))
        {
            goto label_28;
        }
        
        label_26:
        val_19 = 2;
        val_25 = val_18;
        goto label_29;
        label_27:
        var val_30 = val_28;
        val_30 = val_30 + 2;
        val_31 = val_31 + val_30;
        val_25 = val_31 + 272;
        label_29:
        var val_32 = 0;
        val_32 = val_32 + 1;
        val_26 = addHash;
        goto label_35;
        label_18:
        val_18 = 0;
        val_27 = 104;
        val_28 = 1152921504608124928;
        if(val_17 == 0)
        {
            goto label_37;
        }
        
        var val_35 = val_17;
        if((X2 + 258) == 0)
        {
            goto label_38;
        }
        
        var val_33 = X2 + 152;
        var val_34 = 0;
        val_33 = val_33 + 8;
        label_40:
        if(((X2 + 152 + 8) + -8) == null)
        {
            goto label_39;
        }
        
        val_34 = val_34 + 1;
        val_33 = val_33 + 16;
        if(val_34 < (X2 + 258))
        {
            goto label_40;
        }
        
        label_38:
        val_29 = val_17;
        goto label_41;
        label_39:
        val_35 = val_35 + (((X2 + 152 + 8)) << 4);
        val_29 = val_35 + 272;
        label_41:
        label_37:
        if(104 == 104)
        {
                return;
        }
        
        if(val_18 == 0)
        {
                return;
        }
        
        val_18 = ???;
        val_17 = ???;
        val_28 = ???;
        val_22 = ???;
    }
    [System.Runtime.CompilerServices.ExtensionAttribute]
    public static string ToStringFull(System.Collections.IDictionary origin)
    {
        return ExitGames.Client.Photon.SupportClass.DictionaryToString(dictionary:  0, includeTypes:  X1);
    }
    [System.Runtime.CompilerServices.ExtensionAttribute]
    public static string ToStringFull(object[] data)
    {
        var val_2;
        var val_3;
        if(X1 == 0)
        {
                return "null";
        }
        
        val_2 = mem[X1 + 24];
        val_2 = X1 + 24;
        val_3 = val_2;
        if((X1 + 24) < 1)
        {
                return System.String.Join(separator:  0, value:  ", ");
        }
        
        do
        {
            if(0 >= (X1 + 24))
        {
                val_3 = 0;
        }
        
            var val_1 = X1 + 0;
            if(((X1 + 0) + 32) != 0)
        {
                val_2 = (X1 + 0) + 32;
        }
        else
        {
                val_2 = "null";
        }
        
            typeof(System.String[]).__il2cppRuntimeField_20 = val_2;
        }
        while((0 + 1) < (X1 + 24));
        
        return System.String.Join(separator:  0, value:  ", ");
    }
    [System.Runtime.CompilerServices.ExtensionAttribute]
    public static ExitGames.Client.Photon.Hashtable StripToStringKeys(System.Collections.IDictionary original)
    {
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        ExitGames.Client.Photon.Hashtable val_12;
        var val_13;
        var val_14;
        if(X1 == 0)
        {
                return (ExitGames.Client.Photon.Hashtable)new ExitGames.Client.Photon.Hashtable();
        }
        
        var val_6 = X1;
        if((X1 + 258) == 0)
        {
            goto label_2;
        }
        
        var val_3 = X1 + 152;
        var val_4 = 0;
        val_3 = val_3 + 8;
        label_4:
        if(((X1 + 152 + 8) + -8) == null)
        {
            goto label_3;
        }
        
        val_4 = val_4 + 1;
        val_3 = val_3 + 16;
        if(val_4 < (X1 + 258))
        {
            goto label_4;
        }
        
        label_2:
        val_6 = 4;
        val_7 = X1;
        goto label_5;
        label_3:
        var val_5 = val_3;
        val_5 = val_5 + 4;
        val_6 = val_6 + val_5;
        val_7 = val_6 + 272;
        label_5:
        var val_9 = X1;
        if((X1 + 258) == 0)
        {
            goto label_7;
        }
        
        var val_7 = X1 + 152;
        var val_8 = 0;
        val_7 = val_7 + 8;
        label_9:
        if(((X1 + 152 + 8) + -8) == null)
        {
            goto label_8;
        }
        
        val_8 = val_8 + 1;
        val_7 = val_7 + 16;
        if(val_8 < (X1 + 258))
        {
            goto label_9;
        }
        
        label_7:
        val_6 = 0;
        val_8 = X1;
        goto label_10;
        label_8:
        val_9 = val_9 + (((X1 + 152 + 8)) << 4);
        val_8 = val_9 + 272;
        label_10:
        label_29:
        var val_13 = X1;
        if((X1 + 258) == 0)
        {
            goto label_12;
        }
        
        var val_10 = X1 + 152;
        var val_11 = 0;
        val_10 = val_10 + 8;
        label_14:
        if(((X1 + 152 + 8) + -8) == null)
        {
            goto label_13;
        }
        
        val_11 = val_11 + 1;
        val_10 = val_10 + 16;
        if(val_11 < (X1 + 258))
        {
            goto label_14;
        }
        
        label_12:
        val_6 = 1;
        val_9 = X1;
        goto label_15;
        label_13:
        var val_12 = val_10;
        val_12 = val_12 + 1;
        val_13 = val_13 + val_12;
        val_9 = val_13 + 272;
        label_15:
        if(((X1 & 1) & 1) == 0)
        {
            goto label_16;
        }
        
        var val_16 = X1;
        if((X1 + 258) == 0)
        {
            goto label_18;
        }
        
        var val_14 = X1 + 152;
        var val_15 = 0;
        val_14 = val_14 + 8;
        label_20:
        if(((X1 + 152 + 8) + -8) == null)
        {
            goto label_19;
        }
        
        val_15 = val_15 + 1;
        val_14 = val_14 + 16;
        if(val_15 < (X1 + 258))
        {
            goto label_20;
        }
        
        label_18:
        val_6 = 0;
        val_10 = X1;
        goto label_21;
        label_19:
        val_16 = val_16 + (((X1 + 152 + 8)) << 4);
        val_10 = val_16 + 272;
        label_21:
        if((X1 == 0) || (X1 != null))
        {
            goto label_29;
        }
        
        var val_20 = X1;
        if((X1 + 258) == 0)
        {
            goto label_24;
        }
        
        var val_17 = X1 + 152;
        var val_18 = 0;
        val_17 = val_17 + 8;
        label_26:
        if(((X1 + 152 + 8) + -8) == null)
        {
            goto label_25;
        }
        
        val_18 = val_18 + 1;
        val_17 = val_17 + 16;
        if(val_18 < (X1 + 258))
        {
            goto label_26;
        }
        
        label_24:
        val_6 = 2;
        val_11 = X1;
        goto label_27;
        label_25:
        var val_19 = val_17;
        val_19 = val_19 + 2;
        val_20 = val_20 + val_19;
        val_11 = val_20 + 272;
        label_27:
        set_Item(key:  X1, value:  X1);
        goto label_29;
        label_16:
        val_12 = 0;
        val_13 = 97;
        if(X1 == 0)
        {
            goto label_31;
        }
        
        var val_23 = X1;
        if((X1 + 258) == 0)
        {
            goto label_32;
        }
        
        var val_21 = X1 + 152;
        var val_22 = 0;
        val_21 = val_21 + 8;
        label_34:
        if(((X1 + 152 + 8) + -8) == null)
        {
            goto label_33;
        }
        
        val_22 = val_22 + 1;
        val_21 = val_21 + 16;
        if(val_22 < (X1 + 258))
        {
            goto label_34;
        }
        
        label_32:
        val_14 = X1;
        goto label_35;
        label_33:
        val_23 = val_23 + (((X1 + 152 + 8)) << 4);
        val_14 = val_23 + 272;
        label_35:
        label_31:
        if(97 == 97)
        {
                return (ExitGames.Client.Photon.Hashtable)new ExitGames.Client.Photon.Hashtable();
        }
        
        if(val_12 == 0)
        {
                return (ExitGames.Client.Photon.Hashtable)new ExitGames.Client.Photon.Hashtable();
        }
        
        return (ExitGames.Client.Photon.Hashtable)new ExitGames.Client.Photon.Hashtable();
    }
    [System.Runtime.CompilerServices.ExtensionAttribute]
    public static void StripKeysWithNullValues(System.Collections.IDictionary original)
    {
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_4 = X1;
        if((X1 + 258) == 0)
        {
            goto label_2;
        }
        
        var val_2 = X1 + 152;
        var val_3 = 0;
        val_2 = val_2 + 8;
        label_4:
        if(((X1 + 152 + 8) + -8) == null)
        {
            goto label_3;
        }
        
        val_3 = val_3 + 1;
        val_2 = val_2 + 16;
        if(val_3 < (X1 + 258))
        {
            goto label_4;
        }
        
        label_2:
        val_7 = X1;
        goto label_5;
        label_3:
        val_4 = val_4 + (((X1 + 152 + 8)) << 4);
        val_7 = val_4 + 272;
        label_5:
        var val_8 = X1;
        if((X1 + 258) == 0)
        {
            goto label_7;
        }
        
        var val_5 = X1 + 152;
        var val_6 = 0;
        val_5 = val_5 + 8;
        label_9:
        if(((X1 + 152 + 8) + -8) == null)
        {
            goto label_8;
        }
        
        val_6 = val_6 + 1;
        val_5 = val_5 + 16;
        if(val_6 < (X1 + 258))
        {
            goto label_9;
        }
        
        label_7:
        val_8 = X1;
        goto label_10;
        label_8:
        var val_7 = val_5;
        val_7 = val_7 + 4;
        val_8 = val_8 + val_7;
        val_8 = val_8 + 272;
        label_10:
        var val_11 = X1;
        if((X1 + 258) == 0)
        {
            goto label_12;
        }
        
        var val_9 = X1 + 152;
        var val_10 = 0;
        val_9 = val_9 + 8;
        label_14:
        if(((X1 + 152 + 8) + -8) == null)
        {
            goto label_13;
        }
        
        val_10 = val_10 + 1;
        val_9 = val_9 + 16;
        if(val_10 < (X1 + 258))
        {
            goto label_14;
        }
        
        label_12:
        val_9 = X1;
        goto label_15;
        label_13:
        val_11 = val_11 + (((X1 + 152 + 8)) << 4);
        val_9 = val_11 + 272;
        label_15:
        val_10 = 0;
        goto label_16;
        label_32:
        val_10 = 1;
        typeof(System.Object[]).__il2cppRuntimeField_20 = ???;
        label_16:
        var val_15 = X1;
        if((X1 + 258) == 0)
        {
            goto label_18;
        }
        
        var val_12 = X1 + 152;
        var val_13 = 0;
        val_12 = val_12 + 8;
        label_20:
        if(((X1 + 152 + 8) + -8) == null)
        {
            goto label_19;
        }
        
        val_13 = val_13 + 1;
        val_12 = val_12 + 16;
        if(val_13 < (X1 + 258))
        {
            goto label_20;
        }
        
        label_18:
        val_11 = X1;
        goto label_21;
        label_19:
        var val_14 = val_12;
        val_14 = val_14 + 1;
        val_15 = val_15 + val_14;
        val_11 = val_15 + 272;
        label_21:
        if(((X1 & 1) & 1) == 0)
        {
            goto label_56;
        }
        
        var val_18 = X1;
        if((X1 + 258) == 0)
        {
            goto label_24;
        }
        
        var val_16 = X1 + 152;
        var val_17 = 0;
        val_16 = val_16 + 8;
        label_26:
        if(((X1 + 152 + 8) + -8) == null)
        {
            goto label_25;
        }
        
        val_17 = val_17 + 1;
        val_16 = val_16 + 16;
        if(val_17 < (X1 + 258))
        {
            goto label_26;
        }
        
        label_24:
        val_12 = X1;
        goto label_27;
        label_25:
        val_18 = val_18 + (((X1 + 152 + 8)) << 4);
        val_12 = val_18 + 272;
        label_27:
        if((X1 == 0) || (X1 != 0))
        {
            goto label_32;
        }
        
        goto label_32;
        label_56:
        if(X1 == 0)
        {
            goto label_33;
        }
        
        var val_21 = X1;
        if((X1 + 258) == 0)
        {
            goto label_34;
        }
        
        var val_19 = X1 + 152;
        var val_20 = 0;
        val_19 = val_19 + 8;
        label_36:
        if(((X1 + 152 + 8) + -8) == null)
        {
            goto label_35;
        }
        
        val_20 = val_20 + 1;
        val_19 = val_19 + 16;
        if(val_20 < (X1 + 258))
        {
            goto label_36;
        }
        
        label_34:
        val_13 = 0;
        val_14 = X1;
        goto label_37;
        label_35:
        val_21 = val_21 + (((X1 + 152 + 8)) << 4);
        val_14 = val_21 + 272;
        label_37:
        label_33:
        val_15 = 0;
        if((0 == 84) || (X1 == 0))
        {
            goto label_40;
        }
        
        val_15 = 0;
        goto label_40;
        label_55:
        val_15 = 1;
        label_40:
        var val_25 = X1;
        if((X1 + 258) == 0)
        {
            goto label_45;
        }
        
        var val_22 = X1 + 152;
        var val_23 = 0;
        val_22 = val_22 + 8;
        label_47:
        if(((X1 + 152 + 8) + -8) == null)
        {
            goto label_46;
        }
        
        val_23 = val_23 + 1;
        val_22 = val_22 + 16;
        if(val_23 < (X1 + 258))
        {
            goto label_47;
        }
        
        label_45:
        val_13 = 2;
        val_16 = X1;
        goto label_48;
        label_46:
        var val_24 = val_22;
        val_24 = val_24 + 2;
        val_25 = val_25 + val_24;
        val_16 = val_25 + 272;
        label_48:
        val_17 = mem[((X1 + ((X1 + 152 + 8) + 2)) + 272) + 8];
        val_17 = ((X1 + ((X1 + 152 + 8) + 2)) + 272) + 8;
        if(X1 != 0)
        {
            goto label_55;
        }
        
        var val_29 = X1;
        if((X1 + 258) == 0)
        {
            goto label_51;
        }
        
        var val_26 = X1 + 152;
        var val_27 = 0;
        val_26 = val_26 + 8;
        label_53:
        if(((X1 + 152 + 8) + -8) == null)
        {
            goto label_52;
        }
        
        val_27 = val_27 + 1;
        val_26 = val_26 + 16;
        if(val_27 < (X1 + 258))
        {
            goto label_53;
        }
        
        label_51:
        val_17 = 10;
        val_18 = X1;
        goto label_55;
        label_52:
        var val_28 = val_26;
        val_28 = val_28 + 10;
        val_29 = val_29 + val_28;
        val_18 = val_29 + 272;
        goto label_55;
    }
    [System.Runtime.CompilerServices.ExtensionAttribute]
    public static bool Contains(int[] target, int nr)
    {
        var val_2;
        var val_3;
        if(nr == 0)
        {
            goto label_1;
        }
        
        val_2 = 0;
        label_3:
        if(val_2 >= (nr + 24))
        {
            goto label_1;
        }
        
        int val_1 = nr + 0;
        val_2 = val_2 + 1;
        if(((nr + 0) + 32) != W2)
        {
            goto label_3;
        }
        
        val_3 = 1;
        return (bool)val_3;
        label_1:
        val_3 = 0;
        return (bool)val_3;
    }
    private static Extensions()
    {
        Extensions.ParametersOfMethods = new System.Collections.Generic.Dictionary<System.Reflection.MethodInfo, System.Reflection.ParameterInfo[]>();
    }

}
