using UnityEngine;
public class PlayRandomSound : MonoBehaviour
{
    // Fields
    [UnityEngine.SerializeField]
    private SoundGroup[] groups;
    private UnityEngine.Transform cachedTransform;
    private static TzarGames.Common.Pool<UnityEngine.AudioSource> audioPool;
    private const int PooledSourceCount = 30;
    private static TzarGames.Common.Pool.CreateObjectDeleagate<UnityEngine.AudioSource> <>f__mg$cache0;
    
    // Methods
    public PlayRandomSound()
    {
    
    }
    [UnityEngine.RuntimeInitializeOnLoadMethodAttribute]
    private static void initAudioPool()
    {
        if(PlayRandomSound.PooledSourceCount != 0)
        {
                return;
        }
        
        UnityEngine.Debug.Log(message:  0);
        if((PlayRandomSound.<>f__mg$cache0) == null)
        {
                PlayRandomSound.<>f__mg$cache0 = new Pool.CreateObjectDeleagate<UnityEngine.AudioSource>(object:  0, method:  static UnityEngine.AudioSource PlayRandomSound::createAudioSourceInstance());
        }
        
        PlayRandomSound.PooledSourceCount = new TzarGames.Common.Pool<UnityEngine.AudioSource>(createObjectCallback:  PlayRandomSound.<>f__mg$cache0, maxCount:  2147483647);
        PlayRandomSound.PooledSourceCount.__il2cppRuntimeField_3 = 268435456;
        CreateObjects(count:  30);
    }
    private static UnityEngine.AudioSource createAudioSourceInstance()
    {
        UnityEngine.GameObject val_1 = new UnityEngine.GameObject(name:  "Audio source instance (Pooled)");
        UnityEngine.Object.DontDestroyOnLoad(target:  0);
        UnityEngine.AudioSource val_2 = AddComponent<UnityEngine.AudioSource>();
        val_2.enabled = false;
        TzarGames.Common.EmptyBehaviour val_3 = AddComponent<TzarGames.Common.EmptyBehaviour>();
        return val_2;
    }
    public static void PlaySoundGroup(SoundGroup group, UnityEngine.Vector3 position)
    {
        PlayRandomSound.playSoundGroup(group:  group, position:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
    }
    public static void PlayAudioClip3D(UnityEngine.AudioClip clip, UnityEngine.Vector3 position, float volume = 1, float pitch = 1, UnityEngine.Audio.AudioMixerGroup group)
    {
        float val_8;
        UnityEngine.AudioSource val_1 = PlayRandomSound.PooledSourceCount.Get();
        if(val_1 != null)
        {
                val_1.enabled = true;
        }
        else
        {
                0.enabled = true;
        }
        
        val_1.clip = group;
        if(0 != X2)
        {
                val_1.outputAudioMixerGroup = X2;
        }
        
        if(val_1 != null)
        {
                val_1.spatialBlend = 1f;
        }
        else
        {
                val_1.spatialBlend = 1f;
        }
        
        val_1.transform.position = new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z};
        if(val_1 != null)
        {
                val_1.volume = volume;
            val_8 = pitch;
            val_1.pitch = val_8;
            val_1.PlayOneShot(clip:  group);
        }
        else
        {
                val_1.volume = volume;
            val_8 = pitch;
            val_1.pitch = val_8;
            val_1.PlayOneShot(clip:  group);
        }
        
        float val_5 = group.length;
        val_5 = val_5 + 0.016f;
        UnityEngine.Coroutine val_7 = val_1.GetComponent<TzarGames.Common.EmptyBehaviour>().StartCoroutine(routine:  PlayRandomSound.instanceRoutine(source:  group, time:  val_5));
    }
    public void PlayRandom(string soundGroupName)
    {
        if(0 == this.cachedTransform)
        {
                this.cachedTransform = this.transform;
        }
        
        var val_6 = 0;
        do
        {
            if(val_6 >= this.groups.Length)
        {
                return;
        }
        
            SoundGroup val_5 = this.groups[0];
            val_6 = val_6 + 1;
        }
        while((System.String.op_Equality(a:  0, b:  this.groups[0x0][0].name)) == false);
        
        UnityEngine.Vector3 val_4 = this.cachedTransform.position;
        PlayRandomSound.playSoundGroup(group:  this.cachedTransform, position:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
    }
    private static void playSoundGroup(SoundGroup group, UnityEngine.Vector3 position)
    {
        var val_13;
        var val_14;
        System.Collections.IEnumerator val_15;
        SoundGroup val_16;
        if(X1 != 0)
        {
                val_13 = mem[X1 + 24];
            val_13 = X1 + 24;
            val_14 = val_13;
        }
        else
        {
                val_14 = 7254272;
            val_13 = 7254272;
        }
        
        val_15 = (long)UnityEngine.Random.Range(min:  0, max:  0);
        var val_2 = val_14 + (((long)(int)(val_1)) << 3);
        if(0 == ((val_14 + ((long)(int)(val_1)) << 3) + 32))
        {
                string val_4 = 0 + "Clip is null for group ";
            UnityEngine.Debug.LogError(message:  0);
            return;
        }
        
        if(0 == (X1 + 32))
        {
                val_16 = PlayRandomSound.PooledSourceCount.Get();
            val_16.enabled = true;
            if(0 != (X1 + 40))
        {
                val_16.outputAudioMixerGroup = X1 + 40;
        }
        
            float val_9 = (val_14 + ((long)(int)(val_1)) << 3) + 32.length;
            val_9 = val_9 + 0.016f;
            val_15 = PlayRandomSound.instanceRoutine(source:  (val_14 + ((long)(int)(val_1)) << 3) + 32, time:  val_9);
            UnityEngine.Coroutine val_11 = val_16.GetComponent<TzarGames.Common.EmptyBehaviour>().StartCoroutine(routine:  val_15);
        }
        else
        {
                val_16 = mem[X1 + 32];
            val_16 = X1 + 32;
        }
        
        UnityEngine.Transform val_12 = val_16.transform;
        val_12.position = new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z};
        PlayRandomSound.playOnSource(source:  val_12, group:  val_16, clip:  X1);
    }
    [System.Diagnostics.DebuggerHiddenAttribute]
    private static System.Collections.IEnumerator instanceRoutine(UnityEngine.AudioSource source, float time)
    {
        if(null != 0)
        {
                typeof(PlayRandomSound.<instanceRoutine>c__Iterator0).__il2cppRuntimeField_10 = time;
        }
        else
        {
                mem[16] = time;
        }
        
        typeof(PlayRandomSound.<instanceRoutine>c__Iterator0).__il2cppRuntimeField_18 = X1;
        return (System.Collections.IEnumerator)new System.Object();
    }
    private static void playOnSource(UnityEngine.AudioSource source, SoundGroup group, UnityEngine.AudioClip clip)
    {
        if(group.enabled == false)
        {
                return;
        }
        
        if((W8 & 255) != 0)
        {
                float val_3 = X8 >> 32;
            float val_4 = UnityEngine.Random.Range(min:  val_3, max:  null);
            group.volume = val_4;
        }
        
        if(val_3 != 0)
        {
                float val_5 = UnityEngine.Random.Range(min:  val_4, max:  null);
            group.pitch = val_5;
        }
        
        if(group != null)
        {
                group.spatialBlend = val_5;
        }
        else
        {
                0.spatialBlend = val_5;
        }
        
        group.PlayOneShot(clip:  X3);
    }

}
