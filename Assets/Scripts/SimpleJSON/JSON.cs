using UnityEngine;

namespace SimpleJSON
{
    public static class JSON
    {
        // Methods
        public static SimpleJSON.JSONNode Parse(string aJSON)
        {
            return SimpleJSON.JSONNode.Parse(aJSON:  aJSON);
        }
    
    }

}
