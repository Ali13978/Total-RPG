using UnityEngine;

namespace SA.Common.Util
{
    public static class General
    {
        // Fields
        private static string[] _rfc3339Formats;
        private const string Rfc3339Format = "yyyy-MM-dd\'T\'HH:mm:ssK";
        private const string MinRfc339Value = "0001-01-01T00:00:00Z";
        
        // Properties
        public static int CurrentTimeStamp { get; }
        public static string[] DateTimePatterns { get; }
        
        // Methods
        public static void Invoke(float time, System.Action callback, string name = "")
        {
            SA.Common.Models.Invoker.Create(name:  callback).StartInvoke(callback:  name, time:  time);
        }
        public static T ParseEnum<T>(string value)
        {
            var val_4;
            object val_2 = System.Enum.Parse(enumType:  0, value:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), ignoreCase:  __RuntimeMethodHiddenParam);
            if(val_2 != null)
            {
                    val_4 = val_2;
                if(val_4 != null)
            {
                    return (object)val_4;
            }
            
            }
            
            val_4 = 0;
            return (object)val_4;
        }
        public static int get_CurrentTimeStamp()
        {
            System.DateTime val_1 = System.DateTime.UtcNow;
            return (int)(int)D0;
        }
        public static string DateTimeToRfc3339(System.DateTime dateTime)
        {
            var val_3;
            var val_4;
            val_3 = null;
            val_3 = null;
            if((System.DateTime.op_Equality(d1:  new System.DateTime() {ticks = new System.TimeSpan(), kind = dateTime.kind}, d2:  new System.DateTime() {ticks = new System.TimeSpan() {_ticks = X2}, kind = System.DateTime.MinValue})) != false)
            {
                    val_4 = "0001-01-01T00:00:00Z";
                return (string)val_4;
            }
            
            System.Globalization.DateTimeFormatInfo val_2 = System.Globalization.DateTimeFormatInfo.InvariantInfo;
            val_4;
            return (string)val_4;
        }
        public static System.DateTime ConvertFromUnixTimestamp(long timestamp)
        {
            return new System.DateTime() {ticks = new System.TimeSpan() {_ticks = 1152921510498021584}};
        }
        public static long ConvertToUnixTimestamp(System.DateTime date)
        {
            System.TimeSpan val_1 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {ticks = new System.TimeSpan(), kind = date.kind}, d2:  new System.DateTime() {ticks = new System.TimeSpan()});
            return (long)(long)D0;
        }
        public static string[] get_DateTimePatterns()
        {
            var val_7;
            string val_8;
            val_7 = null;
            val_7 = null;
            val_8 = SA.Common.Util.General.MinRfc339Value;
            if(val_8 == null)
            {
                    val_7 = null;
            }
            
            if((SA.Common.Util.General.MinRfc339Value + 24) >= 1)
            {
                    return (System.String[])SA.Common.Util.General.MinRfc339Value;
            }
            
            val_7 = null;
            SA.Common.Util.General.MinRfc339Value = null;
            typeof(System.String[]).__il2cppRuntimeField_20 = "yyyy\'-\'MM\'-\'dd\'T\'HH\':\'mm\':\'ss\'.\'fffffffK";
            typeof(System.String[]).__il2cppRuntimeField_28 = "yyyy\'-\'MM\'-\'dd\'T\'HH\':\'mm\':\'ss\'.\'ffffffK";
            typeof(System.String[]).__il2cppRuntimeField_30 = "yyyy\'-\'MM\'-\'dd\'T\'HH\':\'mm\':\'ss\'.\'fffffK";
            typeof(System.String[]).__il2cppRuntimeField_38 = "yyyy\'-\'MM\'-\'dd\'T\'HH\':\'mm\':\'ss\'.\'ffffK";
            typeof(System.String[]).__il2cppRuntimeField_40 = "yyyy\'-\'MM\'-\'dd\'T\'HH\':\'mm\':\'ss\'.\'fffK";
            typeof(System.String[]).__il2cppRuntimeField_48 = "yyyy\'-\'MM\'-\'dd\'T\'HH\':\'mm\':\'ss\'.\'ffK";
            typeof(System.String[]).__il2cppRuntimeField_50 = "yyyy\'-\'MM\'-\'dd\'T\'HH\':\'mm\':\'ss\'.\'fK";
            typeof(System.String[]).__il2cppRuntimeField_58 = "yyyy\'-\'MM\'-\'dd\'T\'HH\':\'mm\':\'ssK";
            typeof(System.String[]).__il2cppRuntimeField_60 = "yyyy\'-\'MM\'-\'dd\'T\'HH\':\'mm\':\'ss\'.\'fffffffK";
            typeof(System.String[]).__il2cppRuntimeField_68 = System.Globalization.DateTimeFormatInfo.InvariantInfo.UniversalSortableDateTimePattern;
            val_8 = System.Globalization.DateTimeFormatInfo.InvariantInfo.SortableDateTimePattern;
            typeof(System.String[]).__il2cppRuntimeField_70 = val_8;
            return (System.String[])SA.Common.Util.General.MinRfc339Value;
        }
        public static bool TryParseRfc3339(string s, out System.DateTime result)
        {
            System.IFormatProvider val_8;
            var val_9;
            System.DateTime val_1 = System.DateTime.Now;
            mem2[0] = val_1.ticks._ticks;
            mem2[0] = val_1.kind;
            if((System.String.IsNullOrEmpty(value:  0)) != true)
            {
                    val_8 = SA.Common.Util.General.DateTimePatterns;
                if((System.DateTime.TryParseExact(s:  0, formats:  result.ticks._ticks, provider:  val_8, style:  System.Globalization.DateTimeFormatInfo.InvariantInfo, result: out  new System.DateTime() {ticks = new System.TimeSpan()})) != false)
            {
                    val_8 = 0;
                val_9 = 1;
                System.DateTime val_7 = System.DateTime.SpecifyKind(value:  new System.DateTime() {ticks = new System.TimeSpan()}, kind:  val_8);
                mem2[0] = val_7.ticks._ticks;
                mem2[0] = val_7.kind;
                mem2[0] = X2;
                mem2[0] = 0;
                return (bool)val_9;
            }
            
            }
            
            val_9 = 0;
            return (bool)val_9;
        }
        public static string HMAC(string key, string data)
        {
            var val_7;
            var val_8;
            var val_12;
            System.Byte[] val_4 = ComputeHash(buffer:  System.Text.Encoding.UTF8);
            val_7 = null;
            val_7 = null;
            val_8 = 0;
            goto label_11;
            label_17:
            val_8 = 1;
            label_11:
            string val_5 = 0 + System.String.Empty;
            goto label_17;
            label_23:
            if(((mem[null + 152] + 8) + -8) == null)
            {
                goto label_22;
            }
            
             =  + 1;
             =  + 16;
            if( < (mem[null + 258]))
            {
                goto label_23;
            }
            
            val_12 = new System.Security.Cryptography.HMACSHA256(key:  System.Text.Encoding.UTF8);
            goto label_24;
            label_22:
             =  + (((mem[null + 152] + 8)) << 4);
            label_24:
            if(125 == 125)
            {
                    return (string);
            }
            
            if( == 0)
            {
                    return (string);
            }
            
            return (string);
        }
        public static void CleanupInstallation()
        {
        
        }
        private static General()
        {
            SA.Common.Util.General.MinRfc339Value = null;
        }
    
    }

}
