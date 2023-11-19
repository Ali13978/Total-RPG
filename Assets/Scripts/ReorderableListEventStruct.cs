using UnityEngine;
[Serializable]
public struct ReorderableList.ReorderableListEventStruct
{
    // Fields
    public UnityEngine.GameObject DroppedObject;
    public int FromIndex;
    public UnityEngine.UI.Extensions.ReorderableList FromList;
    public bool IsAClone;
    public UnityEngine.GameObject SourceObject;
    public int ToIndex;
    public UnityEngine.UI.Extensions.ReorderableList ToList;
    

}
