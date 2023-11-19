using UnityEngine;
public interface IPunPrefabPool
{
    // Methods
    public abstract UnityEngine.GameObject Instantiate(string prefabId, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation); // 0
    public abstract void Destroy(UnityEngine.GameObject gameObject); // 0

}
