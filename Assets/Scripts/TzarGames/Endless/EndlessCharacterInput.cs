using UnityEngine;

namespace TzarGames.Endless
{
    public class EndlessCharacterInput : TH_CharacterInput
    {
        // Fields
        [UnityEngine.HeaderAttribute]
        [UnityEngine.SerializeField]
        private TzarGames.Endless.SkillInputInfo[] skills;
        private TzarGames.Endless.PlayerCharacter _playerCharacter;
        
        // Methods
        public EndlessCharacterInput()
        {
        
        }
        private void Start()
        {
            if(this.Character != null)
            {
                    0 = 0;
            }
            
            this._playerCharacter = ;
        }
        protected override UnityEngine.Vector3 calculateMoveVector()
        {
            UnityEngine.Vector3 val_1 = this.calculateMoveVector();
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.up;
            UnityEngine.Quaternion val_5 = UnityEngine.Quaternion.AngleAxis(angle:  this._playerCharacter.PlayerCamera.CameraYaw, axis:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            return UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_5.x, y = val_5.y, z = val_5.z, w = val_5.w}, point:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
        }
    
    }

}
