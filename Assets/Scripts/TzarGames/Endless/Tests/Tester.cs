using UnityEngine;

namespace TzarGames.Endless.Tests
{
    public class Tester : MonoBehaviour
    {
        // Fields
        private static TzarGames.Endless.Tests.Tester tester;
        
        // Methods
        public Tester()
        {
        
        }
        private static void checkTester()
        {
            TzarGames.Endless.Tests.Tester val_4 = TzarGames.Endless.Tests.Tester.tester;
            if(0 != val_4)
            {
                    return;
            }
            
            UnityEngine.GameObject val_2 = null;
            val_4 = val_2;
            val_2 = new UnityEngine.GameObject(name:  "Tester");
            UnityEngine.Object.DontDestroyOnLoad(target:  0);
            TzarGames.Endless.Tests.Tester.tester = AddComponent<TzarGames.Endless.Tests.Tester>();
        }
        [TzarGames.Common.ConsoleCommand]
        public static void StartLobbyTest(float interval)
        {
            System.Collections.IEnumerator val_4;
            TzarGames.Endless.Tests.Tester.checkTester();
            TzarGames.Endless.Tests.Tester.StopAllTests();
            if(TzarGames.Endless.Tests.Tester.tester != null)
            {
                    val_4 = this.lobbyTest(interval:  interval);
            }
            else
            {
                    val_4 = this.lobbyTest(interval:  interval);
            }
            
            UnityEngine.Coroutine val_3 = TzarGames.Endless.Tests.Tester.tester.StartCoroutine(routine:  val_4);
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator lobbyTest(float interval)
        {
            typeof(Tester.<lobbyTest>c__Iterator0).__il2cppRuntimeField_1C = interval;
            return (System.Collections.IEnumerator)new System.Object();
        }
        [TzarGames.Common.ConsoleCommand]
        public static void StopAllTests()
        {
            TzarGames.Endless.Tests.Tester.checkTester();
            TzarGames.Endless.Tests.Tester.tester.StopAllCoroutines();
        }
    
    }

}
