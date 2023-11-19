using UnityEngine;
public interface SmallXmlParser.IAttrList
{
    // Properties
    public abstract int Length { get; }
    public abstract bool IsEmpty { get; }
    public abstract string[] Names { get; }
    public abstract string[] Values { get; }
    
    // Methods
    public abstract int get_Length(); // 0
    public abstract bool get_IsEmpty(); // 0
    public abstract string GetName(int i); // 0
    public abstract string GetValue(int i); // 0
    public abstract string GetValue(string name); // 0
    public abstract string[] get_Names(); // 0
    public abstract string[] get_Values(); // 0

}
