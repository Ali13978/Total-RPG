using UnityEngine;
private sealed class I2Utils.<RemoveNonASCII>c__AnonStorey0
{
    // Fields
    internal bool allowCategory;
    
    // Methods
    public I2Utils.<RemoveNonASCII>c__AnonStorey0()
    {
    
    }
    internal char <>m__0(char c)
    {
        char val_4 = c;
        if((System.Char.IsControl(c:  ' ')) != true)
        {
                if((val_4 & 65535) != '\')
        {
                return (char)val_4;
        }
        
            if(this.allowCategory == true)
        {
                return (char)val_4;
        }
        
        }
        
        val_4 = 32;
        return (char)val_4;
    }

}
