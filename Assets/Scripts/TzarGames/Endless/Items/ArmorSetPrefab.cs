using UnityEngine;

namespace TzarGames.Endless.Items
{
    public class ArmorSetPrefab : MonoBehaviour
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.Transform rightHandWeaponSocket;
        [UnityEngine.SerializeField]
        private UnityEngine.Transform leftHandWeaponSocket;
        [UnityEngine.SerializeField]
        private UnityEngine.Transform shieldSocket;
        [UnityEngine.SerializeField]
        private TzarGames.TzarHero.CharacterAnimationBase characterAnimation;
        [UnityEngine.SerializeField]
        private UnityEngine.SkinnedMeshRenderer mainBodyRenderer;
        
        // Properties
        public UnityEngine.SkinnedMeshRenderer MainBodyRenderer { get; }
        public UnityEngine.Transform RightHandWeaponSocket { get; }
        public UnityEngine.Transform LeftHandWeaponSocket { get; }
        public UnityEngine.Transform ShieldSocket { get; }
        public TzarGames.TzarHero.CharacterAnimationBase CharacterAnimation { get; }
        
        // Methods
        public ArmorSetPrefab()
        {
        
        }
        public UnityEngine.SkinnedMeshRenderer get_MainBodyRenderer()
        {
            return (UnityEngine.SkinnedMeshRenderer)this.mainBodyRenderer;
        }
        public UnityEngine.Transform get_RightHandWeaponSocket()
        {
            return (UnityEngine.Transform)this.rightHandWeaponSocket;
        }
        public UnityEngine.Transform get_LeftHandWeaponSocket()
        {
            return (UnityEngine.Transform)this.leftHandWeaponSocket;
        }
        public UnityEngine.Transform get_ShieldSocket()
        {
            return (UnityEngine.Transform)this.shieldSocket;
        }
        public TzarGames.TzarHero.CharacterAnimationBase get_CharacterAnimation()
        {
            return (TzarGames.TzarHero.CharacterAnimationBase)this.characterAnimation;
        }
    
    }

}
