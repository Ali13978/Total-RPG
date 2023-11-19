using UnityEngine;

namespace TzarGames.TzarHero
{
    internal class Arrow
    {
        // Fields
        public TzarGames.TzarHero.TH_Character character;
        public UnityEngine.Vector3 position;
        public bool draw;
        
        // Methods
        public Arrow()
        {
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y});
            this.position = val_2;
            mem[1152921511618002348] = val_2.y;
            mem[1152921511618002352] = val_2.z;
        }
    
    }

}
