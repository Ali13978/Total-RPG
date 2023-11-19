using UnityEngine;

namespace TzarGames.Endless
{
    public class TrailFxController : MonoBehaviour, IPoolable
    {
        // Fields
        private System.Collections.Generic.List<TzarGames.Endless.TrailFxBehaviour> trails;
        private TzarGames.Endless.TrailFxInfo trailSettings;
        
        // Methods
        public TrailFxController()
        {
            this.trails = new System.Collections.Generic.List<TzarGames.Endless.TrailFxBehaviour>();
        }
        public void AddTrail(TzarGames.Endless.TrailFxBehaviour trailFx)
        {
            if((this.trails.Contains(item:  trailFx)) != false)
            {
                    return;
            }
            
            this.trails.Add(item:  trailFx);
        }
        public void RemoveTrail(TzarGames.Endless.TrailFxBehaviour trailFx)
        {
            if((this.trails.Contains(item:  trailFx)) == false)
            {
                    return;
            }
            
            bool val_2 = this.trails.Remove(item:  trailFx);
        }
        public void RemoveAllTrails()
        {
            this.trails.Clear();
        }
        public void SetCustomTrailSettings(TzarGames.Endless.TrailFxInfo info)
        {
            this.trailSettings = info;
        }
        public void RemoveCustomTrailSettings()
        {
            this.trailSettings = 0;
        }
        public void ActivateTrails(TzarGames.Endless.TrailFxInfo info)
        {
            UnityEngine.Object val_7;
            var val_8;
            val_7 = info;
            if(0 == val_7)
            {
                    val_7 = this.trailSettings;
            }
            
            val_8 = 0;
            goto label_4;
            label_15:
            X22.Activate();
            val_8 = 1;
            label_4:
            if(val_8 >= this.trails.Count)
            {
                    return;
            }
            
            if(0 != val_7)
            {
                    val_4.trail.MyColor = this.trailSettings.color;
            }
            
            if(this.trails.Item[1] != null)
            {
                goto label_15;
            }
            
            goto label_15;
        }
        public void DeactivateAndResetTrails()
        {
            this.deactivateTrails(reset:  true, smoothly:  false);
        }
        private void deactivateTrails(bool reset, bool smoothly)
        {
            goto label_1;
            label_20:
            0 = 1;
            label_1:
            if(0 >= this.trails.Count)
            {
                    return;
            }
            
            TzarGames.Endless.TrailFxBehaviour val_2 = this.trails.Item[1];
            if(0 != val_2)
            {
                goto label_7;
            }
            
            string val_4 = this.name;
            UnityEngine.Debug.LogErrorFormat(format:  0, args:  0 + "Null trail fx on ");
            goto label_20;
            label_7:
            if(smoothly != false)
            {
                    val_2.DeactivateSmoothly();
            }
            else
            {
                    val_2.trail.Deactivate();
            }
            
            if(reset == false)
            {
                goto label_20;
            }
            
            val_2.trail.MyColor = val_2.defaultColor;
            goto label_20;
        }
        public void DeactivateTrails()
        {
            this.deactivateTrails(reset:  false, smoothly:  false);
        }
        public void DeactivateTrailsSmoothly()
        {
            this.deactivateTrails(reset:  false, smoothly:  true);
        }
        public void ResetTrails()
        {
            goto label_1;
            label_7:
            0 = 1;
            mem2[0] = ???;
            label_1:
            if(0 >= this.trails.Count)
            {
                    return;
            }
            
            TzarGames.Endless.TrailFxBehaviour val_2 = this.trails.Item[1];
            if(val_2.trail != null)
            {
                goto label_7;
            }
            
            goto label_7;
        }
        public void OnPushedToPool()
        {
            this.trails.Clear();
        }
        public void OnPulledFromPool()
        {
        
        }
    
    }

}
