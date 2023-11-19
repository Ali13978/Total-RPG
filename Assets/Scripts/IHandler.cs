using UnityEngine;
public interface MiniParser.IHandler
{
    // Methods
    public abstract void OnStartParsing(Mono.Xml.MiniParser parser); // 0
    public abstract void OnStartElement(string name, Mono.Xml.MiniParser.IAttrList attrs); // 0
    public abstract void OnEndElement(string name); // 0
    public abstract void OnChars(string ch); // 0
    public abstract void OnEndParsing(Mono.Xml.MiniParser parser); // 0

}
