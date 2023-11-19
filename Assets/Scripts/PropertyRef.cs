using UnityEngine;
[Serializable]
public class PropertyBinding.PropertyRef
{
    // Fields
    [UnityEngine.SerializeField]
    private UnityEngine.Component m_Component;
    private System.Reflection.FieldInfo m_Field;
    private System.Reflection.PropertyInfo m_Property;
    [UnityEngine.SerializeField]
    private string m_PropertyPath;
    
    // Properties
    public UnityEngine.Component component { get; }
    public string propertyPath { get; }
    
    // Methods
    public PropertyBinding.PropertyRef()
    {
    
    }
    public UnityEngine.Component get_component()
    {
        return (UnityEngine.Component)this.m_Component;
    }
    public string get_propertyPath()
    {
        return (string)this.m_PropertyPath;
    }
    public object GetValue()
    {
        var val_3;
        var val_5;
        var val_10;
        var val_11;
        val_10 = this;
        if((this.m_Field == null) && (this.m_Property == null))
        {
                bool val_1 = this.CacheProperty();
        }
        
        if(this.m_Property != null)
        {
                if((this.m_Property & 1) == 0)
        {
                return 0;
        }
        
            val_11 = ???;
            val_10 = ???;
        }
        else
        {
                if((val_10 + 24) == 0)
        {
                return 0;
        }
        
            val_11 = val_3;
            val_10 = val_5;
        }
    
    }
    public bool SetValue(object value)
    {
        System.Reflection.PropertyInfo val_2;
        var val_3;
        if(this.m_Field != null)
        {
            goto label_0;
        }
        
        if(this.m_Property != null)
        {
            goto label_3;
        }
        
        if(this.CacheProperty() == false)
        {
            goto label_6;
        }
        
        if(this.m_Field == null)
        {
            goto label_3;
        }
        
        label_0:
        this.m_Field.SetValue(obj:  this.m_Component, value:  value);
        goto label_4;
        label_3:
        val_2 = this.m_Property;
        if((val_2 & 1) == 0)
        {
            goto label_6;
        }
        
        val_2 = this.m_Property;
        label_4:
        val_3 = 1;
        return (bool)val_3;
        label_6:
        val_3 = 0;
        return (bool)val_3;
    }
    private bool CacheProperty()
    {
        if(0 != this.m_Component)
        {
                if((System.String.IsNullOrEmpty(value:  0)) == false)
        {
            goto label_6;
        }
        
        }
        
        this.m_Field = 0;
        this.m_Property = 0;
        return (bool)(0 != 0) ? 1 : 0;
        label_6:
        System.Type val_5 = this.m_Component.GetType();
        this.m_Field = val_5.GetField(name:  this.m_PropertyPath);
        this.m_Property = val_5.GetProperty(name:  this.m_PropertyPath);
        if(this.m_Field == null)
        {
                return (bool)(0 != 0) ? 1 : 0;
        }
        
        return (bool)(0 != 0) ? 1 : 0;
    }

}
