using UnityEngine;
private sealed class MiniJSON.Serializer
{
    // Fields
    private System.Text.StringBuilder builder;
    
    // Methods
    private MiniJSON.Serializer()
    {
        this.builder = new System.Text.StringBuilder();
    }
    public static string Serialize(object obj)
    {
        object val_2;
        MiniJSON.Serializer val_1 = new MiniJSON.Serializer();
        if(null != 0)
        {
                val_2 = X1;
            SerializeValue(value:  val_2, indentationLevel:  1);
        }
        else
        {
                val_2 = X1;
            SerializeValue(value:  val_2, indentationLevel:  1);
        }
    
    }
    private void SerializeValue(object value, int indentationLevel)
    {
        System.Text.StringBuilder val_6;
        string val_7;
        if(value == null)
        {
            goto label_1;
        }
        
        if(null == null)
        {
            goto label_2;
        }
        
        if(null == null)
        {
            goto label_3;
        }
        
        if(value == null)
        {
            goto label_4;
        }
        
        this.SerializeArray(anArray:  value, indentationLevel:  indentationLevel);
        return;
        label_1:
        val_6 = this.builder;
        val_7 = "null";
        goto label_6;
        label_2:
        label_10:
        this.SerializeString(str:  value);
        return;
        label_3:
        val_6 = this.builder;
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
        val_7 = (null == 0) ? "false" : "true";
        label_6:
        System.Text.StringBuilder val_3 = val_6.Append(value:  val_7);
        return;
        label_4:
        if(value != null)
        {
                this.SerializeObject(obj:  value, indentationLevel:  indentationLevel);
            return;
        }
        
        if(null != null)
        {
                this.SerializeOther(value:  value);
            return;
        }
        
        UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
        string val_5 = 0.CreateString(c:  '퀀', count:  1);
        goto label_10;
    }
    private void SerializeObject(System.Collections.IDictionary obj, int indentationLevel)
    {
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        System.Text.StringBuilder val_1 = this.builder.Append(value:  '{');
        System.Text.StringBuilder val_2 = this.builder.Append(value:  '
        ');
        if(indentationLevel >= 1)
        {
                int val_21 = indentationLevel;
            do
        {
            System.Text.StringBuilder val_3 = this.builder.Append(value:  '	');
            val_21 = val_21 - 1;
        }
        while(val_21 != 0);
        
        }
        
        var val_22 = 0;
        val_22 = val_22 + 1;
        val_20 = obj;
        var val_23 = 0;
        val_23 = val_23 + 1;
        val_21 = obj;
        int val_6 = indentationLevel + 1;
        label_40:
        var val_24 = 0;
        val_24 = val_24 + 1;
        val_22 = obj;
        if(((obj & 1) & 1) == 0)
        {
            goto label_53;
        }
        
        var val_25 = 0;
        val_25 = val_25 + 1;
        val_23 = obj;
        if(((1 & 1) & 1) == 0)
        {
                System.Text.StringBuilder val_11 = this.builder.Append(value:  ',');
            val_24 = 10;
            System.Text.StringBuilder val_12 = this.builder.Append(value:  '
        ');
            if(indentationLevel >= 1)
        {
                var val_26 = 0;
            do
        {
            val_24 = 9;
            System.Text.StringBuilder val_13 = this.builder.Append(value:  '	');
            val_26 = val_26 + 1;
        }
        while(val_26 < indentationLevel);
        
        }
        
        }
        
        this.SerializeString(str:  obj);
        val_25 = 0;
        System.Text.StringBuilder val_14 = this.builder.Append(value:  ':');
        var val_27 = 0;
        val_27 = val_27 + 1;
        val_25 = 2;
        val_26 = obj;
        this.SerializeValue(value:  obj, indentationLevel:  val_6);
        goto label_40;
        label_53:
        if(obj != null)
        {
                var val_28 = 0;
            val_28 = val_28 + 1;
            val_27 = obj;
        }
        
        System.Text.StringBuilder val_17 = this.builder.Append(value:  '
        ');
        var val_29 = 0;
        goto label_50;
        label_52:
        System.Text.StringBuilder val_19 = val_6.Append(value:  '	');
        label_50:
        val_29 = val_29 + 1;
        if(val_29 < (val_6 - 1))
        {
            goto label_52;
        }
        
        System.Text.StringBuilder val_20 = this.builder.Append(value:  '}');
    }
    private void SerializeArray(System.Collections.IList anArray, int indentationLevel)
    {
        int val_6;
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        val_6 = 0;
        System.Text.StringBuilder val_1 = this.builder.Append(value:  '[');
        val_7 = 0;
        val_8 = 1;
        goto label_2;
        label_16:
        val_6 = indentationLevel;
        this.SerializeValue(value:  X23, indentationLevel:  val_6);
        val_8 = 0;
        val_7 = 1;
        label_2:
        var val_7 = 0;
        val_7 = val_7 + 1;
        val_6 = 0;
        val_9 = anArray;
        if(val_7 >= anArray)
        {
            goto label_8;
        }
        
        var val_8 = 0;
        val_8 = val_8 + 1;
        val_6 = 2;
        val_10 = anArray;
        if(((val_8 & 1) & 1) != 0)
        {
            goto label_16;
        }
        
        System.Text.StringBuilder val_5 = this.builder.Append(value:  ',');
        goto label_16;
        label_8:
        System.Text.StringBuilder val_6 = this.builder.Append(value:  ']');
    }
    private void SerializeString(string str)
    {
        System.Text.StringBuilder val_13;
        System.Text.StringBuilder val_14;
        var val_15;
        val_13 = this;
        val_14 = this.builder;
        System.Text.StringBuilder val_1 = val_14.Append(value:  '"');
        val_15 = 0;
        if( < val_2.Length)
        {
                val_14 = str.ToCharArray()[1];
            str.ToCharArray()[1] = val_14 - 8;
            if(((str.ToCharArray()[1] < '') ? (val_14 - 3) : 0) > 10)
        {
                return;
        }
        
            var val_13 = 25805476 + (val_2[1] < '' ? (val_2[0x1][0] - 3) : 0) << 2;
            val_13 = val_13 + 25805476;
        }
        else
        {
                val_13 = this.builder;
            System.Text.StringBuilder val_12 = val_13.Append(value:  '"');
        }
    
    }
    private void SerializeOther(object value)
    {
        var val_28;
        System.Text.StringBuilder val_29;
        var val_30;
        var val_31;
        var val_32;
        var val_33;
        val_29 = this;
        if(value == null)
        {
            goto label_1;
        }
        
        if(null == null)
        {
            goto label_2;
        }
        
        if((((((((null == null) || (null == null)) || (null == null)) || (null == null)) || (null == null)) || (null == null)) || (null == null)) || (null == null))
        {
            goto label_10;
        }
        
        if((null == null) || (null == null))
        {
            goto label_12;
        }
        
        if(null == null)
        {
            goto label_13;
        }
        
        if(null == null)
        {
            goto label_14;
        }
        
        if(null == null)
        {
            goto label_15;
        }
        
        if(null == null)
        {
            goto label_16;
        }
        
        if(null != null)
        {
            goto label_17;
        }
        
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
        val_29 = this.builder;
        val_30 = null;
        typeof(System.String[]).__il2cppRuntimeField_20 = "\"c(";
        System.Globalization.CultureInfo val_2 = System.Globalization.CultureInfo.InvariantCulture;
        val_31 = "R";
        typeof(System.String[]).__il2cppRuntimeField_28 = ;
        val_32 = ",";
        typeof(System.String[]).__il2cppRuntimeField_30 = ",";
        System.Globalization.CultureInfo val_3 = System.Globalization.CultureInfo.InvariantCulture;
        typeof(System.String[]).__il2cppRuntimeField_38 = ;
        typeof(System.String[]).__il2cppRuntimeField_40 = ",";
        System.Globalization.CultureInfo val_4 = System.Globalization.CultureInfo.InvariantCulture;
        typeof(System.String[]).__il2cppRuntimeField_48 = ;
        typeof(System.String[]).__il2cppRuntimeField_50 = ",";
        val_33;
        goto label_122;
        label_1:
        label_17:
        this.SerializeString(str:  value);
        return;
        label_2:
        val_29 = this.builder;
        UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
        System.Globalization.CultureInfo val_6 = System.Globalization.CultureInfo.InvariantCulture;
        goto label_53;
        label_10:
        val_29 = this.builder;
        System.Text.StringBuilder val_7 = val_29.Append(value:  value);
        return;
        label_12:
        val_29 = this.builder;
        double val_8 = System.Convert.ToDouble(value:  0);
        System.Globalization.CultureInfo val_9 = System.Globalization.CultureInfo.InvariantCulture;
        goto label_53;
        label_13:
        UnityEngine.Vector2 val_10 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
        val_29 = this.builder;
        val_30 = null;
        typeof(System.String[]).__il2cppRuntimeField_20 = "\"v2(";
        System.Globalization.CultureInfo val_11 = System.Globalization.CultureInfo.InvariantCulture;
        typeof(System.String[]).__il2cppRuntimeField_28 = ;
        typeof(System.String[]).__il2cppRuntimeField_30 = ",";
        System.Globalization.CultureInfo val_12 = System.Globalization.CultureInfo.InvariantCulture;
        typeof(System.String[]).__il2cppRuntimeField_38 = ;
        val_28 = ")\"";
        typeof(System.String[]).__il2cppRuntimeField_40 = val_28;
        goto label_97;
        label_14:
        UnityEngine.Vector2 val_13 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
        val_29 = this.builder;
        val_30 = null;
        typeof(System.String[]).__il2cppRuntimeField_20 = "\"v3(";
        System.Globalization.CultureInfo val_14 = System.Globalization.CultureInfo.InvariantCulture;
        typeof(System.String[]).__il2cppRuntimeField_28 = ;
        val_32 = ",";
        typeof(System.String[]).__il2cppRuntimeField_30 = ",";
        System.Globalization.CultureInfo val_15 = System.Globalization.CultureInfo.InvariantCulture;
        typeof(System.String[]).__il2cppRuntimeField_38 = ;
        typeof(System.String[]).__il2cppRuntimeField_40 = ",";
        System.Globalization.CultureInfo val_16 = System.Globalization.CultureInfo.InvariantCulture;
        typeof(System.String[]).__il2cppRuntimeField_48 = ;
        val_28 = ")\"";
        typeof(System.String[]).__il2cppRuntimeField_50 = val_28;
        goto label_97;
        label_15:
        UnityEngine.Vector2 val_17 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
        val_29 = this.builder;
        val_30 = null;
        typeof(System.String[]).__il2cppRuntimeField_20 = "\"(";
        System.Globalization.CultureInfo val_18 = System.Globalization.CultureInfo.InvariantCulture;
        val_31 = "R";
        typeof(System.String[]).__il2cppRuntimeField_28 = ;
        val_32 = ",";
        typeof(System.String[]).__il2cppRuntimeField_30 = ",";
        System.Globalization.CultureInfo val_19 = System.Globalization.CultureInfo.InvariantCulture;
        typeof(System.String[]).__il2cppRuntimeField_38 = ;
        typeof(System.String[]).__il2cppRuntimeField_40 = ",";
        System.Globalization.CultureInfo val_20 = System.Globalization.CultureInfo.InvariantCulture;
        typeof(System.String[]).__il2cppRuntimeField_48 = ;
        typeof(System.String[]).__il2cppRuntimeField_50 = ",";
        goto label_122;
        label_16:
        UnityEngine.Vector2 val_21 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
        val_29 = this.builder;
        val_30 = null;
        typeof(System.String[]).__il2cppRuntimeField_20 = "\"(";
        System.Globalization.CultureInfo val_22 = System.Globalization.CultureInfo.InvariantCulture;
        val_31 = "R";
        typeof(System.String[]).__il2cppRuntimeField_28 = ;
        val_32 = ",";
        typeof(System.String[]).__il2cppRuntimeField_30 = ",";
        System.Globalization.CultureInfo val_23 = System.Globalization.CultureInfo.InvariantCulture;
        typeof(System.String[]).__il2cppRuntimeField_38 = ;
        typeof(System.String[]).__il2cppRuntimeField_40 = ",";
        System.Globalization.CultureInfo val_24 = System.Globalization.CultureInfo.InvariantCulture;
        typeof(System.String[]).__il2cppRuntimeField_48 = ;
        typeof(System.String[]).__il2cppRuntimeField_50 = ",";
        label_122:
        System.Globalization.CultureInfo val_25 = System.Globalization.CultureInfo.InvariantCulture;
        typeof(System.String[]).__il2cppRuntimeField_58 = ;
        val_28 = ")\"";
        typeof(System.String[]).__il2cppRuntimeField_60 = val_28;
        label_97:
        label_53:
        System.Text.StringBuilder val_27 = val_29.Append(value:  +0);
    }

}
