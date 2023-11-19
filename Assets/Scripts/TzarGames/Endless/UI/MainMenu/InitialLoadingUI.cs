using UnityEngine;

namespace TzarGames.Endless.UI.MainMenu
{
    public class InitialLoadingUI : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.GameObject screenFader;
        
        // Methods
        public InitialLoadingUI()
        {
        
        }
        private void Start()
        {
            this.screenFader.SetActive(value:  false);
        }
    
    }

}
