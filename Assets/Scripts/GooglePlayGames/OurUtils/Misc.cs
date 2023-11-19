using UnityEngine;

namespace GooglePlayGames.OurUtils
{
    public static class Misc
    {
        // Methods
        public static bool BuffersAreIdentical(byte[] a, byte[] b)
        {
            var val_2;
            var val_3;
            if(b == X2)
            {
                goto label_4;
            }
            
            val_2 = 0;
            if(b == null)
            {
                    return (bool)val_2;
            }
            
            if(X2 == 0)
            {
                    return (bool)val_2;
            }
            
            val_2 = 0;
            if(b.Length != (X2 + 24))
            {
                    return (bool)val_2;
            }
            
            val_3 = 0;
            label_7:
            if(val_3 >= b.Length)
            {
                goto label_4;
            }
            
            var val_1 = X2 + 0;
            val_3 = val_3 + 1;
            if(b[0] == ((X2 + 0) + 32))
            {
                goto label_7;
            }
            
            val_2 = 0;
            return (bool)val_2;
            label_4:
            val_2 = 1;
            return (bool)val_2;
        }
        public static byte[] GetSubsetBytes(byte[] array, int offset, int length)
        {
            int val_4;
            System.ArgumentOutOfRangeException val_5;
            string val_6;
            var val_7;
            val_4 = offset;
            if(val_4 == 0)
            {
                goto label_1;
            }
            
            if(((length & 2147483648) != 0) || )
            {
                goto label_3;
            }
            
            if(((W3 & 2147483648) != 0) || (((offset + 24) - length) < W3))
            {
                goto label_5;
            }
            
            if(length == 0)
            {
                    if((offset + 24) == W3)
            {
                    return (System.Byte[])val_4;
            }
            
            }
            
            System.Array.Copy(sourceArray:  0, sourceIndex:  val_4, destinationArray:  length, destinationIndex:  460851360, length:  0);
            val_4 = null;
            return (System.Byte[])val_4;
            label_3:
            val_5 = null;
            val_6 = "offset";
            goto label_8;
            label_1:
            System.ArgumentNullException val_2 = null;
            val_7 = val_2;
            val_2 = new System.ArgumentNullException(paramName:  "array");
            goto label_9;
            label_5:
            val_5 = null;
            val_6 = "length";
            label_8:
            val_7 = val_5;
            val_5 = new System.ArgumentOutOfRangeException(paramName:  val_6);
            label_9:
        }
        public static T CheckNotNull<T>(T value)
        {
            if(__RuntimeMethodHiddenParam != 0)
            {
                    return (object)__RuntimeMethodHiddenParam;
            }
            
            System.ArgumentNullException val_1 = new System.ArgumentNullException();
        }
        public static T CheckNotNull<T>(T value, string paramName)
        {
            if(paramName != null)
            {
                    return (object)paramName;
            }
            
            System.ArgumentNullException val_1 = new System.ArgumentNullException(paramName:  __RuntimeMethodHiddenParam);
        }
    
    }

}
