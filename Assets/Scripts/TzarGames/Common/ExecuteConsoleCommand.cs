using UnityEngine;

namespace TzarGames.Common
{
    public class ExecuteConsoleCommand : MonoBehaviour
    {
        // Methods
        public ExecuteConsoleCommand()
        {
        
        }
        public void Execute(string command)
        {
            TzarGames.Common.Console.Execute(command:  null);
        }
    
    }

}
