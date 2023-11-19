using UnityEngine;
public class XWeaponTrail.Element
{
    // Fields
    public UnityEngine.Vector3 PointStart;
    public UnityEngine.Vector3 PointEnd;
    
    // Properties
    public UnityEngine.Vector3 Pos { get; }
    
    // Methods
    public XWeaponTrail.Element(UnityEngine.Vector3 start, UnityEngine.Vector3 end)
    {
        this.PointStart = start;
        mem[1152921512824347508] = start.y;
        mem[1152921512824347512] = start.z;
        this.PointEnd = end;
        mem[1152921512824347520] = end.y;
        mem[1152921512824347524] = end.z;
    }
    public XWeaponTrail.Element()
    {
    
    }
    public UnityEngine.Vector3 get_Pos()
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = this.PointStart, y = V9.16B, z = V13.16B}, b:  new UnityEngine.Vector3() {x = this.PointEnd, y = V11.16B, z = V10.16B});
        return UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, d:  2f);
    }

}
