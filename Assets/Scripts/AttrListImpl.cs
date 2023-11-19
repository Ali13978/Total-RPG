using UnityEngine;
private class SmallXmlParser.AttrListImpl : SmallXmlParser.IAttrList
{
    // Fields
    private System.Collections.ArrayList attrNames;
    private System.Collections.ArrayList attrValues;
    
    // Properties
    public int Length { get; }
    public bool IsEmpty { get; }
    public string[] Names { get; }
    public string[] Values { get; }
    
    // Methods
    public SmallXmlParser.AttrListImpl()
    {
        this.attrNames = new System.Collections.ArrayList();
        this.attrValues = new System.Collections.ArrayList();
    }
    public int get_Length()
    {
        if(this.attrNames == null)
        {
            
        }
    
    }
    public bool get_IsEmpty()
    {
        return (bool)(this.attrNames == 0) ? 1 : 0;
    }
    public string GetName(int i)
    {
        System.Collections.ArrayList val_2 = this.attrNames;
        if(val_2 != null)
        {
                if(null == null)
        {
                return (string)val_2;
        }
        
        }
        
        val_2 = 0;
        return (string)val_2;
    }
    public string GetValue(int i)
    {
        System.Collections.ArrayList val_2 = this.attrValues;
        if(val_2 != null)
        {
                if(null == null)
        {
                return (string)val_2;
        }
        
        }
        
        val_2 = 0;
        return (string)val_2;
    }
    public string GetValue(string name)
    {
        System.Collections.ArrayList val_4;
        var val_5;
        var val_6;
        string val_7;
        var val_8;
        val_4 = name;
        val_5 = 0;
        goto label_1;
        label_9:
        val_5 = 1;
        label_1:
        if(val_5 >= this.attrNames)
        {
            goto label_11;
        }
        
        val_6 = null;
        val_7 = this.attrNames;
        val_6 = null;
        if(val_7 == null)
        {
            goto label_7;
        }
        
        if(null == val_6)
        {
            goto label_8;
        }
        
        label_7:
        val_7 = 0;
        label_8:
        if((System.String.op_Equality(a:  0, b:  val_7)) == false)
        {
            goto label_9;
        }
        
        val_4 = this.attrValues;
        val_8 = val_4;
        if(val_8 != null)
        {
                if(null == null)
        {
                return (string)val_8;
        }
        
        }
        
        label_11:
        val_8 = 0;
        return (string)val_8;
    }
    public string[] get_Names()
    {
        System.Collections.ArrayList val_3;
        var val_4;
        val_3 = this.attrNames;
        System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        if(val_3 != null)
        {
                val_4 = val_3;
            val_3 = null;
            if(val_4 != null)
        {
                return (System.String[])val_4;
        }
        
        }
        
        val_4 = 0;
        return (System.String[])val_4;
    }
    public string[] get_Values()
    {
        System.Collections.ArrayList val_3;
        var val_4;
        val_3 = this.attrValues;
        System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        if(val_3 != null)
        {
                val_4 = val_3;
            val_3 = null;
            if(val_4 != null)
        {
                return (System.String[])val_4;
        }
        
        }
        
        val_4 = 0;
        return (System.String[])val_4;
    }
    internal void Clear()
    {
        if(this.attrValues == null)
        {
            
        }
    
    }
    internal void Add(string name, string value)
    {
        if(this.attrValues == null)
        {
            
        }
    
    }

}
