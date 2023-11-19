using UnityEngine;
private sealed class IdFactory.<>c__AnonStorey0
{
    // Fields
    internal System.Random random;
    
    // Methods
    public IdFactory.<>c__AnonStorey0()
    {
    
    }
    internal char <>m__0(string s)
    {
        int val_1 = s.Length;
        if(s != null)
        {
                return s.Chars[this.random];
        }
        
        return s.Chars[this.random];
    }

}
