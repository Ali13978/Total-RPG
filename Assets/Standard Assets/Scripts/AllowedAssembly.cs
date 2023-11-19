using UnityEngine;
private class InjectionDetector.AllowedAssembly
{
    // Fields
    public readonly string name;
    public readonly int[] hashes;
    
    // Methods
    public InjectionDetector.AllowedAssembly(string name, int[] hashes)
    {
        this.name = name;
        this.hashes = hashes;
    }

}
