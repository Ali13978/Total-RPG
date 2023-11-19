using UnityEngine;
public class ObjectCreatePackage : BasePackage
{
    // Methods
    public ObjectCreatePackage(float x, float y)
    {
        this.initWriter();
        this.writeFloat(val:  x);
        this.writeFloat(val:  y);
    }
    public override int getId()
    {
        return 1;
    }

}
