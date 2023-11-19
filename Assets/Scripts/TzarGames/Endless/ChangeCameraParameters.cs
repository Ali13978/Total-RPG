using UnityEngine;

namespace TzarGames.Endless
{
    public class ChangeCameraParameters : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private float time;
        [UnityEngine.SerializeField]
        private float defaultYaw;
        [UnityEngine.SerializeField]
        private float defaultPitch;
        [UnityEngine.SerializeField]
        private float defaultOffset;
        
        // Methods
        public ChangeCameraParameters()
        {
            this.time = ;
            this.defaultYaw = ;
            this.defaultPitch = 60f;
            this.defaultOffset = 10f;
        }
        public void Change()
        {
            this.changeYaw(yaw:  this.defaultYaw, changeTime:  this.time);
        }
        private void changeYaw(float yaw, float changeTime)
        {
            TzarGames.Endless.PlayerCharacter val_1 = TzarGames.Endless.EndlessGameManager.LocalPlayerCharacter;
            if(0 == val_1)
            {
                    return;
            }
            
            val_1.PlayerCamera.ChangeCameraYaw(yaw:  yaw, time:  changeTime);
        }
        private void changePitch(float pitch, float changeTime)
        {
            TzarGames.Endless.PlayerCharacter val_1 = TzarGames.Endless.EndlessGameManager.LocalPlayerCharacter;
            if(0 == val_1)
            {
                    return;
            }
            
            val_1.PlayerCamera.ChangeCameraPitch(pitch:  pitch, time:  changeTime);
        }
        private void changeOffset(float offset, float changeTime)
        {
            TzarGames.Endless.PlayerCharacter val_1 = TzarGames.Endless.EndlessGameManager.LocalPlayerCharacter;
            if(0 == val_1)
            {
                    return;
            }
            
            val_1.PlayerCamera.SetOffset(targetOffset:  offset, time:  changeTime);
        }
        public void ChangeYawImmediately(float yaw)
        {
            this.changeYaw(yaw:  yaw, changeTime:  0f);
        }
        public void ChangeYaw(float yaw)
        {
            this.changeYaw(yaw:  yaw, changeTime:  this.time);
        }
        public void ChangePitchImmediately(float pitch)
        {
            this.changePitch(pitch:  pitch, changeTime:  0f);
        }
        public void ChangePitchToValue(float pitch)
        {
            this.changePitch(pitch:  pitch, changeTime:  this.time);
        }
        public void ChangePitch()
        {
            this.changePitch(pitch:  this.defaultPitch, changeTime:  this.time);
        }
        public void ChangeOffsetImmediately(float offset)
        {
            this.changeOffset(offset:  offset, changeTime:  0f);
        }
        public void ChangeOffsetToValue(float offset)
        {
            this.changeOffset(offset:  offset, changeTime:  this.time);
        }
        public void ChangeOffset()
        {
            this.changeOffset(offset:  this.defaultOffset, changeTime:  this.time);
        }
    
    }

}
