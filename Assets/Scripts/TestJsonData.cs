using UnityEngine;
[Serializable]
private class Test_NetworkViewBase.TestJsonData
{
    // Fields
    public int _I;
    public string _S;
    public float _F;
    
    // Methods
    public Test_NetworkViewBase.TestJsonData()
    {
    
    }
    public string Serialize()
    {
        return UnityEngine.JsonUtility.ToJson(obj:  0);
    }
    public static TzarGames.GameFramework.TestUtils.Test_NetworkViewBase.TestJsonData Deserialize(string data)
    {
        return UnityEngine.JsonUtility.FromJson<EncodedData>(json:  0);
    }

}
