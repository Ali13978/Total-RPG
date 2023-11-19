using UnityEngine;
[System.AttributeUsageAttribute]
public class Uninterrupted : Attribute
{
    // Fields
    private System.Type[] exceptions;
    private bool canIgnoreUninterrupted;
    
    // Properties
    public System.Type[] Exceptions { get; }
    public bool IgnoreUninterrupted { get; }
    
    // Methods
    public Uninterrupted()
    {
    
    }
    public Uninterrupted(System.Type[] exceptionTypes)
    {
        if(this.exceptions != null)
        {
                return;
        }
        
        this.exceptions = exceptionTypes;
    }
    public Uninterrupted(bool ignoreUninterrupted)
    {
        this.canIgnoreUninterrupted = ignoreUninterrupted;
    }
    public Uninterrupted(System.Type[] exceptionTypes, bool ignoreUninterrupted)
    {
        this.canIgnoreUninterrupted = ignoreUninterrupted;
        if(this.exceptions != null)
        {
                return;
        }
        
        this.exceptions = exceptionTypes;
    }
    public System.Type[] get_Exceptions()
    {
        return (System.Type[])this.exceptions;
    }
    public bool get_IgnoreUninterrupted()
    {
        return (bool)this.canIgnoreUninterrupted;
    }
    private void initExceptions(System.Type[] exceptionTypes)
    {
        this.exceptions = exceptionTypes;
    }

}
