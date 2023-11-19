using UnityEngine;

namespace I2.Loc
{
    internal class TashkeelLocation
    {
        // Fields
        public char tashkeel;
        public int position;
        
        // Methods
        public TashkeelLocation(char tashkeel, int position)
        {
            this.position = position;
            this.tashkeel = tashkeel;
        }
    
    }

}
