using UnityEngine;
private sealed class Json.Serializer
{
    // Fields
    private System.Text.StringBuilder builder;
    
    // Methods
    private Json.Serializer()
    {
        this.builder = new System.Text.StringBuilder();
    }
    public static string Serialize(object obj)
    {
        object val_2;
        Json.Serializer val_1 = new Json.Serializer();
        if(null != 0)
        {
                val_2 = X1;
            SerializeValue(value:  val_2);
        }
        else
        {
                val_2 = X1;
            SerializeValue(value:  val_2);
        }
        
        if(Json.Serializer == null)
        {
            
        }
    
    }
    private void SerializeValue(object value)
    {
        System.Text.StringBuilder val_3;
        string val_4;
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
        
        this.SerializeArray(anArray:  value);
        return;
        label_1:
        val_3 = this.builder;
        val_4 = "null";
        goto label_6;
        label_2:
        label_11:
        this.SerializeString(str:  value);
        return;
        label_3:
        val_3 = this.builder;
        val_4 = value.ToLower();
        label_6:
        System.Text.StringBuilder val_2 = val_3.Append(value:  val_4);
        return;
        label_4:
        if(value != null)
        {
                this.SerializeObject(obj:  value);
            return;
        }
        
        if(null == null)
        {
            goto label_11;
        }
        
        this.SerializeOther(value:  value);
    }
    private void SerializeObject(System.Collections.IDictionary obj)
    {
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        System.Text.StringBuilder val_1 = this.builder.Append(value:  '{');
        var val_13 = 0;
        val_13 = val_13 + 1;
        val_12 = obj;
        var val_14 = 0;
        val_14 = val_14 + 1;
        val_13 = obj;
        label_32:
        var val_15 = 0;
        val_15 = val_15 + 1;
        val_14 = obj;
        if(((obj & 1) & 1) == 0)
        {
            goto label_41;
        }
        
        var val_16 = 0;
        val_16 = val_16 + 1;
        val_15 = obj;
        if(((1 & 1) & 1) == 0)
        {
                val_16 = 44;
            System.Text.StringBuilder val_8 = this.builder.Append(value:  ',');
        }
        
        this.SerializeString(str:  obj);
        val_17 = 0;
        System.Text.StringBuilder val_9 = this.builder.Append(value:  ':');
        var val_17 = 0;
        val_17 = val_17 + 1;
        val_17 = 2;
        val_18 = obj;
        this.SerializeValue(value:  obj);
        goto label_32;
        label_41:
        if(obj != null)
        {
                var val_18 = 0;
            val_18 = val_18 + 1;
            val_19 = obj;
        }
        
        System.Text.StringBuilder val_12 = this.builder.Append(value:  '}');
    }
    private void SerializeArray(System.Collections.IList anArray)
    {
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        System.Text.StringBuilder val_1 = this.builder.Append(value:  '[');
        var val_10 = 0;
        val_10 = val_10 + 1;
        val_9 = anArray;
        label_20:
        var val_11 = 0;
        val_11 = val_11 + 1;
        val_10 = anArray;
        if(((anArray & 1) & 1) == 0)
        {
            goto label_29;
        }
        
        var val_12 = 0;
        val_12 = val_12 + 1;
        val_11 = anArray;
        if(((1 & 1) & 1) == 0)
        {
                System.Text.StringBuilder val_7 = this.builder.Append(value:  ',');
        }
        
        this.SerializeValue(value:  anArray);
        goto label_20;
        label_29:
        if(anArray != null)
        {
                var val_13 = 0;
            val_13 = val_13 + 1;
            val_12 = anArray;
        }
        
        System.Text.StringBuilder val_9 = this.builder.Append(value:  ']');
    }
    private void SerializeString(string str)
    {
        var val_14;
        System.Text.StringBuilder val_1 = this.builder.Append(value:  '"');
        val_14 = 0;
        if( < val_2.Length)
        {
                char val_14 = str.ToCharArray()[1];
            str.ToCharArray()[1] = val_14 - 8;
            if(((str.ToCharArray()[1] < '') ? (val_14 - 3) : 0) > 10)
        {
                return;
        }
        
            var val_15 = 25809000 + (val_2[1] < '' ? (val_2[0x1][0] - 3) : 0) << 2;
            val_15 = val_15 + 25809000;
        }
        else
        {
                System.Text.StringBuilder val_13 = this.builder.Append(value:  '"');
        }
    
    }
    private void SerializeOther(object value)
    {
        if(value != null)
        {
                if((((((((((null != null) && (null != null)) && (null != null)) && (null != null)) && (null != null)) && (null != null)) && (null != null)) && (null != null)) && (null != null)) && (null != null))
        {
                if(null != null)
        {
            goto label_12;
        }
        
        }
        
            System.Text.StringBuilder val_1 = this.builder.Append(value:  value);
            return;
        }
        
        label_12:
        this.SerializeString(str:  value);
    }

}
