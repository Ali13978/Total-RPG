using UnityEngine;
[Serializable]
public class SoundGroup
{
    // Fields
    public string name;
    public UnityEngine.AudioClip[] clips;
    public UnityEngine.AudioSource source;
    public UnityEngine.Audio.AudioMixerGroup optionalMixerGroup;
    public bool randomizeVolume;
    public float minVolume;
    public float maxVolume;
    public bool randomizePitch;
    public float minPitch;
    public float maxPitch;
    public float spatializeBlend;
    
    // Methods
    public SoundGroup()
    {
        this.randomizeVolume = true;
        this.minVolume = 0.9f;
        this.maxVolume = 1f;
        this.randomizePitch = true;
        this.minPitch = 0.9f;
        this.maxPitch = 7.346868E-41f;
        this.spatializeBlend = 1f;
    }

}
