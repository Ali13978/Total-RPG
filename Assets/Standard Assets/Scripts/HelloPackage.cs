using UnityEngine;
public class HelloPackage : BasePackage
{
    // Methods
    public HelloPackage()
    {
        this.initWriter();
        this.writeFloat(val:  1.1f);
    }
    public override int getId()
    {
        return 2;
    }

}
