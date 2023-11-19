using UnityEngine;

namespace TzarGames.Common
{
    public static class InternetTime
    {
        // Fields
        private static System.Action<System.DateTime> <>f__am$cache0;
        
        // Methods
        [TzarGames.Common.ConsoleCommand]
        private static void GetInternetDateTest()
        {
            IntPtr val_2;
            if((TzarGames.Common.InternetTime.<>f__am$cache0) == null)
            {
                    val_2 = static System.Void TzarGames.Common.InternetTime::<GetInternetDateTest>m__0(System.DateTime time);
                12782 = null;
                12782 = new System.Action<System.DateTime>(object:  0, method:  val_2);
                TzarGames.Common.InternetTime.<>f__am$cache0 = 12782;
            }
            
            TzarGames.Common.InternetTime.GetNISTDate(callback:  12782);
        }
        public static void GetNISTDate(System.Action<System.DateTime> callback)
        {
            typeof(InternetTime.<GetNISTDate>c__AnonStorey0).__il2cppRuntimeField_10 = X1;
            System.Threading.Thread val_3 = new System.Threading.Thread(start:  new System.Threading.ThreadStart(object:  new System.Object(), method:  System.Void InternetTime.<GetNISTDate>c__AnonStorey0::<>m__0()));
            Start();
        }
        private static System.DateTime GetFastestNISTDate()
        {
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            var val_24;
            var val_25;
            val_18 = null;
            val_18 = null;
            typeof(System.String[]).__il2cppRuntimeField_20 = "nist1-ny.ustiming.org";
            typeof(System.String[]).__il2cppRuntimeField_28 = "nist1-nj.ustiming.org";
            typeof(System.String[]).__il2cppRuntimeField_30 = "nist1-pa.ustiming.org";
            typeof(System.String[]).__il2cppRuntimeField_38 = "time-a.nist.gov";
            typeof(System.String[]).__il2cppRuntimeField_40 = "time-b.nist.gov";
            typeof(System.String[]).__il2cppRuntimeField_48 = "nist1.aol-va.symmetricom.com";
            typeof(System.String[]).__il2cppRuntimeField_50 = "nist1.columbiacountyga.gov";
            typeof(System.String[]).__il2cppRuntimeField_58 = "nist1-chi.ustiming.org";
            typeof(System.String[]).__il2cppRuntimeField_60 = "nist.expertsmi.com";
            val_19 = 0;
            val_20 = 0;
            typeof(System.String[]).__il2cppRuntimeField_68 = "nist.netservicesgroup.com";
            goto label_34;
            label_85:
            val_20 = 1;
            label_34:
            val_21 = null;
            val_21 = null;
            System.Net.Sockets.TcpClient val_1 = new System.Net.Sockets.TcpClient(hostname:  typeof(System.String[]).__il2cppRuntimeField_28, port:  13);
            System.IO.StreamReader val_3 = new System.IO.StreamReader(stream:  GetStream());
            val_19 = 166;
            System.IO.StreamReader val_20 = null;
            if((mem[null + 258]) == 0)
            {
                goto label_42;
            }
            
            var val_18 = mem[null + 152];
            var val_19 = 0;
            val_18 = val_18 + 8;
            label_44:
            if(((mem[null + 152] + 8) + -8) == null)
            {
                goto label_43;
            }
            
            val_19 = val_19 + 1;
            val_18 = val_18 + 16;
            if(val_19 < (mem[null + 258]))
            {
                goto label_44;
            }
            
            label_42:
            val_22 = null;
            goto label_45;
            label_43:
            val_20 = val_20 + (((mem[null + 152] + 8)) << 4);
            label_45:
            if(166 == 166)
            {
                    val_19 = 0;
            }
            else
            {
                    if(0 != 0)
            {
                
            }
            
            }
            
            if((System.String.IsNullOrEmpty(value:  0)) == true)
            {
                goto label_85;
            }
            
            typeof(System.Char[]).__il2cppRuntimeField_20 = 32;
            System.String[] val_6 = Split(separator:  null);
            if((val_6.Length < 6) || ((System.String.op_Equality(a:  0, b:  val_6[5])) == false))
            {
                goto label_85;
            }
            
            typeof(System.Char[]).__il2cppRuntimeField_20 = 45;
            System.String[] val_8 = val_6[1].Split(separator:  null);
            typeof(System.Char[]).__il2cppRuntimeField_20 = 58;
            System.String[] val_9 = val_6[2].Split(separator:  null);
            string val_24 = val_8[0];
            string val_25 = val_8[1];
            string val_26 = val_8[2];
            string val_27 = val_9[0];
            string val_28 = val_9[1];
            string val_29 = val_9[2];
            System.DateTime val_17 = new System.DateTime(year:  (System.Convert.ToInt32(value:  0)) + 2000, month:  System.Convert.ToInt32(value:  0), day:  System.Convert.ToInt32(value:  0), hour:  System.Convert.ToInt32(value:  0), minute:  System.Convert.ToInt32(value:  0), second:  System.Convert.ToInt32(value:  0));
            val_24 = 0;
            return new System.DateTime() {ticks = new System.TimeSpan() {}, kind = System.DateTime.MaxValue.__il2cppRuntimeField_18};
            label_89:
            val_25 = 8;
            goto label_89;
        }
        private static void <GetInternetDateTest>m__0(System.DateTime time)
        {
            string val_1 = 0 + "Time: "("Time: ");
            UnityEngine.Debug.Log(message:  0);
        }
    
    }

}
