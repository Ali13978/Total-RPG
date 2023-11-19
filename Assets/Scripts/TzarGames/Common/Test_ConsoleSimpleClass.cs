using UnityEngine;

namespace TzarGames.Common
{
    public class Test_ConsoleSimpleClass : Object
    {
        // Methods
        public Test_ConsoleSimpleClass()
        {
        
        }
        [TzarGames.Common.ConsoleCommand]
        private void A()
        {
            UnityEngine.Debug.Log(message:  0);
        }
        [TzarGames.Common.ConsoleCommand]
        public void test_public_void_noparams()
        {
            string val_2 = 0 + this.ToString();
            UnityEngine.Debug.Log(message:  0);
        }
        [TzarGames.Common.ConsoleCommand]
        private void test_private_void_noparams()
        {
            string val_2 = 0 + this.ToString();
            UnityEngine.Debug.Log(message:  0);
        }
        [TzarGames.Common.ConsoleCommand]
        public void test_public_void_params(int i, string a)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = this.ToString();
            typeof(System.Object[]).__il2cppRuntimeField_28 = "test_public_void_params i=";
            typeof(System.Object[]).__il2cppRuntimeField_30 = i;
            typeof(System.Object[]).__il2cppRuntimeField_34 = 268435457;
            typeof(System.Object[]).__il2cppRuntimeField_38 = " a=";
            typeof(System.Object[]).__il2cppRuntimeField_40 = a;
            string val_2 = +0;
            UnityEngine.Debug.Log(message:  0);
        }
        [TzarGames.Common.ConsoleCommand]
        private void test_private_void_params(int i, string a)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = this.ToString();
            typeof(System.Object[]).__il2cppRuntimeField_28 = "test_private_void_params i=";
            typeof(System.Object[]).__il2cppRuntimeField_30 = i;
            typeof(System.Object[]).__il2cppRuntimeField_34 = 268435457;
            typeof(System.Object[]).__il2cppRuntimeField_38 = " a=";
            typeof(System.Object[]).__il2cppRuntimeField_40 = a;
            string val_2 = +0;
            UnityEngine.Debug.Log(message:  0);
        }
        [TzarGames.Common.ConsoleCommand]
        public static void test_static_public_void_params(int i, string a)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = "test_static_public_void_params i=";
            typeof(System.Object[]).__il2cppRuntimeField_28 = a;
            typeof(System.Object[]).__il2cppRuntimeField_2C = 268435457;
            typeof(System.Object[]).__il2cppRuntimeField_30 = " a=";
            typeof(System.Object[]).__il2cppRuntimeField_38 = X2;
            string val_1 = +0;
            UnityEngine.Debug.Log(message:  0);
        }
        [TzarGames.Common.ConsoleCommand]
        private static void test_static_private_void_params(int i, string a)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = "test_static_private_void_params i=";
            typeof(System.Object[]).__il2cppRuntimeField_28 = a;
            typeof(System.Object[]).__il2cppRuntimeField_2C = 268435457;
            typeof(System.Object[]).__il2cppRuntimeField_30 = " a=";
            typeof(System.Object[]).__il2cppRuntimeField_38 = X2;
            string val_1 = +0;
            UnityEngine.Debug.Log(message:  0);
        }
    
    }

}
