using UnityEngine;
public interface MiniParser.IMutableAttrList : MiniParser.IAttrList
{
    // Methods
    public abstract void Clear(); // 0
    public abstract void Add(string name, string value); // 0
    public abstract void CopyFrom(Mono.Xml.MiniParser.IAttrList attrs); // 0
    public abstract void Remove(int i); // 0
    public abstract void Remove(string name); // 0

}
