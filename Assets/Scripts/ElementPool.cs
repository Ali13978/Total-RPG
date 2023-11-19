using UnityEngine;
public class XWeaponTrail.ElementPool
{
    // Fields
    private readonly System.Collections.Generic.Stack<XftWeapon.XWeaponTrail.Element> _stack;
    [System.Diagnostics.DebuggerBrowsableAttribute]
    private int <CountAll>k__BackingField;
    
    // Properties
    public int CountAll { get; set; }
    public int CountActive { get; }
    public int CountInactive { get; }
    
    // Methods
    public XWeaponTrail.ElementPool(int preCount)
    {
        var val_3;
        System.Collections.Generic.Stack<Element> val_4;
        val_3 = preCount;
        System.Collections.Generic.Stack<Element> val_1 = null;
        val_4 = val_1;
        val_1 = new System.Collections.Generic.Stack<Element>();
        this._stack = val_4;
        if(val_3 < 1)
        {
                return;
        }
        
        do
        {
            object val_2 = null;
            val_4 = val_2;
            val_2 = new System.Object();
            this._stack.Push(t:  val_4);
            int val_3 = this.<CountAll>k__BackingField;
            val_3 = val_3 - 1;
            val_3 = val_3 + 1;
            this.<CountAll>k__BackingField = val_3;
        }
        while(val_3 != 0);
    
    }
    public int get_CountAll()
    {
        return (int)this.<CountAll>k__BackingField;
    }
    private void set_CountAll(int value)
    {
        this.<CountAll>k__BackingField = value;
    }
    public int get_CountActive()
    {
        int val_1 = this.CountInactive;
        val_1 = (this.<CountAll>k__BackingField) - val_1;
        return (int)val_1;
    }
    public int get_CountInactive()
    {
        if(this._stack != null)
        {
                return this._stack.Count;
        }
        
        return this._stack.Count;
    }
    public XftWeapon.XWeaponTrail.Element Get()
    {
        if(this._stack.Count != 0)
        {
                if(this._stack != null)
        {
                return this._stack.Pop();
        }
        
            return this._stack.Pop();
        }
        
        int val_3 = this.<CountAll>k__BackingField;
        val_3 = val_3 + 1;
        this.<CountAll>k__BackingField = val_3;
        return (Element)new System.Object();
    }
    public void Release(XftWeapon.XWeaponTrail.Element element)
    {
        System.Collections.Generic.Stack<Element> val_4 = this._stack;
        if(val_4.Count >= 1)
        {
                val_4 = this._stack;
            if((System.Object.ReferenceEquals(objA:  0, objB:  val_4.Peek())) != false)
        {
                UnityEngine.Debug.LogError(message:  0);
        }
        
        }
        
        this._stack.Push(t:  element);
    }

}
