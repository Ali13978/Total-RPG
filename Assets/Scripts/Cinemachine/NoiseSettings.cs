using UnityEngine;

namespace Cinemachine
{
    [Cinemachine.DocumentationSortingAttribute]
    public sealed class NoiseSettings : ScriptableObject
    {
        // Fields
        [UnityEngine.SerializeField]
        [UnityEngine.TooltipAttribute]
        private Cinemachine.NoiseSettings.TransformNoiseParams[] m_Position;
        [UnityEngine.SerializeField]
        [UnityEngine.TooltipAttribute]
        private Cinemachine.NoiseSettings.TransformNoiseParams[] m_Orientation;
        
        // Properties
        public Cinemachine.NoiseSettings.TransformNoiseParams[] PositionNoise { get; }
        public Cinemachine.NoiseSettings.TransformNoiseParams[] OrientationNoise { get; }
        
        // Methods
        public NoiseSettings()
        {
            this.m_Position = null;
            this.m_Orientation = null;
        }
        public Cinemachine.NoiseSettings.TransformNoiseParams[] get_PositionNoise()
        {
            return (TransformNoiseParams[])this.m_Position;
        }
        public Cinemachine.NoiseSettings.TransformNoiseParams[] get_OrientationNoise()
        {
            return (TransformNoiseParams[])this.m_Orientation;
        }
        public void CopyFrom(Cinemachine.NoiseSettings other)
        {
            this.m_Position = null;
            other.m_Position.CopyTo(array:  null, index:  0);
            this.m_Orientation = null;
            other.m_Orientation.CopyTo(array:  null, index:  0);
        }
    
    }

}
