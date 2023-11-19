using UnityEngine;
public interface SmallXmlParser.IContentHandler
{
    // Methods
    public abstract void OnStartParsing(Mono.Xml.SmallXmlParser parser); // 0
    public abstract void OnEndParsing(Mono.Xml.SmallXmlParser parser); // 0
    public abstract void OnStartElement(string name, Mono.Xml.SmallXmlParser.IAttrList attrs); // 0
    public abstract void OnEndElement(string name); // 0
    public abstract void OnProcessingInstruction(string name, string text); // 0
    public abstract void OnChars(string text); // 0
    public abstract void OnIgnorableWhitespace(string text); // 0

}
