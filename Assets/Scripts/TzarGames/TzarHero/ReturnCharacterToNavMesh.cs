using UnityEngine;

namespace TzarGames.TzarHero
{
    public class ReturnCharacterToNavMesh : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private float maxSampleDistance;
        [UnityEngine.SerializeField]
        private int sampleAreas;
        [UnityEngine.SerializeField]
        private UnityEngine.Transform defaultPosition;
        [UnityEngine.SerializeField]
        private float verticalOffset;
        
        // Methods
        public ReturnCharacterToNavMesh()
        {
            this.maxSampleDistance = 1000f;
            this.sampleAreas = 0;
            this.verticalOffset = 0.1f;
        }
        private void setCharacterPosition(TzarGames.TzarHero.TH_Character character, UnityEngine.Vector3 hitPoint)
        {
            UnityEngine.Vector3 val_1 = character.Position;
            UnityEngine.Vector3 val_2 = character.GroundPivotPosition;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = hitPoint.x, y = hitPoint.y, z = hitPoint.z}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, d:  this.verticalOffset);
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
            bool val_8 = UnityEngine.Time.inFixedTimeStep;
            if(val_8 != false)
            {
                    character.Position = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
                return;
            }
            
            UnityEngine.Coroutine val_11 = this.StartCoroutine(routine:  val_8.waitForFixedTime(character:  character, hitPoint:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}));
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator waitForFixedTime(TzarGames.TzarHero.TH_Character character, UnityEngine.Vector3 hitPoint)
        {
            if(null != 0)
            {
                    typeof(ReturnCharacterToNavMesh.<waitForFixedTime>c__Iterator0).__il2cppRuntimeField_10 = hitPoint.x;
                typeof(ReturnCharacterToNavMesh.<waitForFixedTime>c__Iterator0).__il2cppRuntimeField_14 = hitPoint.y;
                typeof(ReturnCharacterToNavMesh.<waitForFixedTime>c__Iterator0).__il2cppRuntimeField_18 = hitPoint.z;
            }
            else
            {
                    mem[16] = hitPoint.x;
                typeof(ReturnCharacterToNavMesh.<waitForFixedTime>c__Iterator0).__il2cppRuntimeField_14 = hitPoint.y;
                mem[24] = hitPoint.z;
            }
            
            typeof(ReturnCharacterToNavMesh.<waitForFixedTime>c__Iterator0).__il2cppRuntimeField_20 = character;
            return (System.Collections.IEnumerator)new System.Object();
        }
        public void ReturnCharacter(TzarGames.TzarHero.TH_Character other)
        {
            UnityEngine.Transform val_6;
            UnityEngine.Vector3 val_1 = other.Position;
            if((UnityEngine.AI.NavMesh.SamplePosition(sourcePosition:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, hit: out  new UnityEngine.AI.NavMeshHit() {m_Position = new UnityEngine.Vector3(), m_Normal = new UnityEngine.Vector3()}, maxDistance:  this.maxSampleDistance, areaMask:  -1690377352)) != false)
            {
                    this.setCharacterPosition(character:  other, hitPoint:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
                return;
            }
            
            val_6 = this.defaultPosition;
            if(0 != val_6)
            {
                    UnityEngine.Vector3 val_4 = this.defaultPosition.position;
            }
            else
            {
                    UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
            }
            
            other.Position = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
        }
        public void OnCharacterEnterToTrigger(TzarGames.TzarHero.TH_Character other)
        {
            this.ReturnCharacter(other:  other);
        }
    
    }

}
