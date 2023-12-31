using UnityEngine;

namespace I2.Loc
{
    public class RTLFixer
    {
        // Methods
        public RTLFixer()
        {
        
        }
        public static string Fix(string str)
        {
            return I2.Loc.RTLFixer.Fix(str:  str, showTashkeel:  false, useHinduNumbers:  false);
        }
        public static string Fix(string str, bool rtl)
        {
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            if((W2 & 1) != 0)
            {
                    return I2.Loc.RTLFixer.Fix(str:  21934, showTashkeel:  rtl, useHinduNumbers:  false);
            }
            
            typeof(System.Char[]).__il2cppRuntimeField_20 = 32;
            val_13 = null;
            val_13 = null;
            val_14 = 0;
            goto label_7;
            label_22:
            val_14 = 1;
            label_7:
            if(val_14 >= val_1.Length)
            {
                goto label_9;
            }
            
            string val_13 = rtl.Split(separator:  null)[1];
            if(val_13 != null)
            {
                    val_15 = val_13.ToLower();
            }
            else
            {
                    val_15 = 0.ToLower();
            }
            
            int val_4 = val_13.Length;
            rtl.Split(separator:  null)[1] = (val_4 < 0) ? (val_4 + 1) : (val_4);
            char val_6 = val_15.Chars[(rtl.Split(separator:  null)[1]) >> 1];
            bool val_7 = System.Char.IsLower(c:  ' ');
            if(val_7 == false)
            {
                goto label_16;
            }
            
            string val_9 = 0 + System.String.Empty + I2.Loc.RTLFixer.Fix(str:  val_7, showTashkeel:  System.String.Empty, useHinduNumbers:  false)(I2.Loc.RTLFixer.Fix(str:  val_7, showTashkeel:  System.String.Empty, useHinduNumbers:  false)) + val_13;
            goto label_22;
            label_16:
            string val_10 = 0 + System.String.Empty + val_13;
            goto label_22;
            label_9:
            val_16 = null;
            val_16 = null;
            bool val_11 = System.String.op_Inequality(a:  0, b:  System.String.Empty);
            if(val_11 == false)
            {
                    return (string)System.String.Empty;
            }
            
            string val_12 = I2.Loc.RTLFixer.Fix(str:  val_11, showTashkeel:  System.String.Empty, useHinduNumbers:  false);
            return 0 + System.String.Empty;
        }
        public static string Fix(string str, bool showTashkeel, bool useHinduNumbers)
        {
            var val_17;
            string val_18;
            var val_19;
            string val_20;
            var val_21;
            string val_22;
            var val_23;
            val_17 = showTashkeel;
            val_18 = I2.Loc.HindiFixer.Fix(text:  21933);
            if((System.String.op_Inequality(a:  0, b:  val_18)) == true)
            {
                    return val_18;
            }
            
            val_19 = null;
            val_19 = null;
            I2.Loc.RTLFixerTool.showTashkeel = useHinduNumbers;
            I2.Loc.RTLFixerTool.useHinduNumbers = W3 & 1;
            val_20 = "\n";
            if((val_17.Contains(value:  "\n")) != false)
            {
                    val_21 = val_17.Replace(oldValue:  "\n", newValue:  System.Environment.NewLine);
            }
            
            if((val_21.Contains(value:  System.Environment.NewLine)) == false)
            {
                    return I2.Loc.RTLFixerTool.FixLine(str:  null);
            }
            
            val_20 = System.Environment.NewLine;
            typeof(System.String[]).__il2cppRuntimeField_20 = val_20;
            System.String[] val_12 = val_21.Split(separator:  null, options:  0);
            if(val_12.Length == 1)
            {
                    return I2.Loc.RTLFixerTool.FixLine(str:  null);
            }
            
            if(val_12.Length == 0)
            {
                    return I2.Loc.RTLFixerTool.FixLine(str:  null);
            }
            
            val_22 = val_12[0];
            val_18 = I2.Loc.RTLFixerTool.FixLine(str:  null);
            if(val_12.Length <= 1)
            {
                    return val_18;
            }
            
            val_23 = 1;
            goto label_24;
            label_32:
            val_18 = 0 + val_18 + val_22;
            val_23 = 2;
            label_24:
            if(val_23 >= val_12.Length)
            {
                    return val_18;
            }
            
            string val_15 = System.Environment.NewLine;
            string val_17 = val_12[2];
            string val_16 = I2.Loc.RTLFixerTool.FixLine(str:  null);
            goto label_32;
        }
    
    }

}
