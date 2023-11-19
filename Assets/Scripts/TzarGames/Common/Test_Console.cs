using UnityEngine;

namespace TzarGames.Common
{
    public class Test_Console : MonoBehaviour
    {
        // Methods
        public Test_Console()
        {
        
        }
        [TzarGames.Common.ConsoleCommand]
        public void B()
        {
            UnityEngine.Debug.Log(message:  0);
        }
        [TzarGames.Common.ConsoleCommand]
        public void C(string a)
        {
            string val_1 = 0 + "C ";
            UnityEngine.Debug.Log(message:  0);
        }
        [TzarGames.Common.ConsoleCommand]
        public void D(float a)
        {
            string val_1 = 0 + "D ";
            UnityEngine.Debug.Log(message:  0);
        }
        [TzarGames.Common.ConsoleCommand]
        public void E(int a, float b)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = "D ";
            typeof(System.Object[]).__il2cppRuntimeField_28 = a;
            typeof(System.Object[]).__il2cppRuntimeField_2C = 268435457;
            typeof(System.Object[]).__il2cppRuntimeField_30 = "  ";
            typeof(System.Object[]).__il2cppRuntimeField_38 = b;
            typeof(System.Object[]).__il2cppRuntimeField_3C = 268435457;
            string val_1 = +0;
            UnityEngine.Debug.Log(message:  0);
        }
        [TzarGames.Common.ConsoleCommand]
        public void testb_public_void_noparams()
        {
            UnityEngine.Debug.Log(message:  0);
        }
        [TzarGames.Common.ConsoleCommand]
        private void testb_private_void_noparams()
        {
            UnityEngine.Debug.Log(message:  0);
        }
        [TzarGames.Common.ConsoleCommand]
        public void testb_public_void_params(int i, string a)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = "testb_public_void_params i=";
            typeof(System.Object[]).__il2cppRuntimeField_28 = i;
            typeof(System.Object[]).__il2cppRuntimeField_2C = 268435457;
            typeof(System.Object[]).__il2cppRuntimeField_30 = " a=";
            typeof(System.Object[]).__il2cppRuntimeField_38 = a;
            string val_1 = +0;
            UnityEngine.Debug.Log(message:  0);
        }
        [TzarGames.Common.ConsoleCommand]
        private void testb_private_void_params(int i, string a)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = "testb_private_void_params i=";
            typeof(System.Object[]).__il2cppRuntimeField_28 = i;
            typeof(System.Object[]).__il2cppRuntimeField_2C = 268435457;
            typeof(System.Object[]).__il2cppRuntimeField_30 = " a=";
            typeof(System.Object[]).__il2cppRuntimeField_38 = a;
            string val_1 = +0;
            UnityEngine.Debug.Log(message:  0);
        }
        [TzarGames.Common.ConsoleCommand]
        public static void testb_static_public_void_params(int i, string a)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = "testb_static_public_void_params i=";
            typeof(System.Object[]).__il2cppRuntimeField_28 = a;
            typeof(System.Object[]).__il2cppRuntimeField_2C = 268435457;
            typeof(System.Object[]).__il2cppRuntimeField_30 = " a=";
            typeof(System.Object[]).__il2cppRuntimeField_38 = X2;
            string val_1 = +0;
            UnityEngine.Debug.Log(message:  0);
        }
        [TzarGames.Common.ConsoleCommand]
        private static void testb_static_private_void_params(int i, string a)
        {
            typeof(System.Object[]).__il2cppRuntimeField_20 = "testb_static_private_void_params i=";
            typeof(System.Object[]).__il2cppRuntimeField_28 = a;
            typeof(System.Object[]).__il2cppRuntimeField_2C = 268435457;
            typeof(System.Object[]).__il2cppRuntimeField_30 = " a=";
            typeof(System.Object[]).__il2cppRuntimeField_38 = X2;
            string val_1 = +0;
            UnityEngine.Debug.Log(message:  0);
        }
    
    }

}
