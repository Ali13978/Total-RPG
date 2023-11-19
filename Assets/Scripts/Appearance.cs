using UnityEngine;
[Cinemachine.DocumentationSortingAttribute]
[Serializable]
public class CinemachinePathBase.Appearance
{
    // Fields
    [UnityEngine.TooltipAttribute]
    public UnityEngine.Color pathColor;
    [UnityEngine.TooltipAttribute]
    public UnityEngine.Color inactivePathColor;
    [UnityEngine.TooltipAttribute]
    [UnityEngine.RangeAttribute]
    public float width;
    
    // Methods
    public CinemachinePathBase.Appearance()
    {
        UnityEngine.Color val_1 = UnityEngine.Color.green;
        this.pathColor = val_1;
        mem[1152921511740103316] = val_1.g;
        mem[1152921511740103320] = val_1.b;
        mem[1152921511740103324] = val_1.a;
        UnityEngine.Color val_2 = UnityEngine.Color.gray;
        this.inactivePathColor = val_2;
        mem[1152921511740103332] = val_2.g;
        mem[1152921511740103336] = val_2.b;
        mem[1152921511740103340] = val_2.a;
        this.width = 0.2f;
    }

}
