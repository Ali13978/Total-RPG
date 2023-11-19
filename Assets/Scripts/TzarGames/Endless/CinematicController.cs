using UnityEngine;

namespace TzarGames.Endless
{
    public class CinematicController : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.Events.UnityEvent onFadeInComplete;
        
        // Methods
        public CinematicController()
        {
        
        }
        public void FadeScreen()
        {
            UnityEngine.Object.FindObjectOfType<UnityEngine.UI.Extensions.BoundTooltipItem>().DisableAndFadeIn(onCompleteCallback:  new System.Action(object:  this, method:  System.Void TzarGames.Endless.CinematicController::<FadeScreen>m__0()));
        }
        public void FadeOutScreen()
        {
            UnityEngine.Object.FindObjectOfType<UnityEngine.UI.Extensions.BoundTooltipItem>().FadeOut(onCompleteCallback:  0);
        }
        public void FadeInAndOut()
        {
            typeof(CinematicController.<FadeInAndOut>c__AnonStorey1).__il2cppRuntimeField_18 = this;
            UnityEngine.UI.Extensions.BoundTooltipItem val_2 = UnityEngine.Object.FindObjectOfType<UnityEngine.UI.Extensions.BoundTooltipItem>();
            typeof(CinematicController.<FadeInAndOut>c__AnonStorey1).__il2cppRuntimeField_10 = val_2;
            val_2.DisableAndFadeIn(onCompleteCallback:  new System.Action(object:  new System.Object(), method:  System.Void CinematicController.<FadeInAndOut>c__AnonStorey1::<>m__0()));
        }
        public void SetPlayerMovement(bool enable)
        {
            if(enable != false)
            {
                    TzarGames.GameFramework.GameManager.Instance.ResumePlayerMovement();
                return;
            }
            
            TzarGames.GameFramework.GameManager.Instance.StopPlayerMovement();
        }
        public void FadeScreenAndTeleportPlayerTo(UnityEngine.Transform point)
        {
            TzarGames.Endless.PlayerCharacter val_6;
            if(null != 0)
            {
                    typeof(CinematicController.<FadeScreenAndTeleportPlayerTo>c__AnonStorey2).__il2cppRuntimeField_18 = point;
                typeof(CinematicController.<FadeScreenAndTeleportPlayerTo>c__AnonStorey2).__il2cppRuntimeField_28 = this;
                val_6 = TzarGames.Endless.EndlessGameManager.LocalPlayerCharacter;
            }
            else
            {
                    mem[24] = point;
                mem[40] = this;
                val_6 = TzarGames.Endless.EndlessGameManager.LocalPlayerCharacter;
            }
            
            typeof(CinematicController.<FadeScreenAndTeleportPlayerTo>c__AnonStorey2).__il2cppRuntimeField_10 = val_6;
            UnityEngine.UI.Extensions.BoundTooltipItem val_4 = UnityEngine.Object.FindObjectOfType<UnityEngine.UI.Extensions.BoundTooltipItem>();
            typeof(CinematicController.<FadeScreenAndTeleportPlayerTo>c__AnonStorey2).__il2cppRuntimeField_20 = val_4;
            val_4.DisableAndFadeIn(onCompleteCallback:  new System.Action(object:  new System.Object(), method:  System.Void CinematicController.<FadeScreenAndTeleportPlayerTo>c__AnonStorey2::<>m__0()));
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator movePlayerCharacter(TzarGames.TzarHero.TH_Character character, UnityEngine.Transform point)
        {
            if(null != 0)
            {
                    typeof(CinematicController.<movePlayerCharacter>c__Iterator0).__il2cppRuntimeField_10 = point;
            }
            else
            {
                    mem[16] = point;
            }
            
            typeof(CinematicController.<movePlayerCharacter>c__Iterator0).__il2cppRuntimeField_18 = character;
            return (System.Collections.IEnumerator)new System.Object();
        }
        [UnityEngine.ContextMenu]
        public void ReturnToGameplay()
        {
            UnityEngine.Object.FindObjectOfType<UnityEngine.UI.Extensions.BoundTooltipItem>().ShowGameHUD();
        }
        [UnityEngine.ContextMenu]
        private void testFadeAndTeleport()
        {
            this.FadeScreenAndTeleportPlayerTo(point:  this.transform);
        }
        public void SetFog(bool enable)
        {
            bool val_1 = enable;
            UnityEngine.RenderSettings.fog = false;
        }
        private void <FadeScreen>m__0()
        {
            this.onFadeInComplete.Invoke();
        }
    
    }

}
