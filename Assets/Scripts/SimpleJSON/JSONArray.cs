using UnityEngine;

namespace SimpleJSON
{
    public class JSONArray : JSONNode, IEnumerable
    {
        // Fields
        private System.Collections.Generic.List<SimpleJSON.JSONNode> m_List;
        
        // Properties
        public override SimpleJSON.JSONNode Item { get; set; }
        public override SimpleJSON.JSONNode Item { get; set; }
        public override int Count { get; }
        public override System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode> Childs { get; }
        
        // Methods
        public JSONArray()
        {
            this.m_List = new System.Collections.Generic.List<SimpleJSON.JSONNode>();
            this = new System.Object();
        }
        public override SimpleJSON.JSONNode get_Item(int aIndex)
        {
            System.Collections.Generic.List<SimpleJSON.JSONNode> val_3;
            if((aIndex & 2147483648) == 0)
            {
                    val_3 = this.m_List;
                if(val_3.Count > aIndex)
            {
                    if(this.m_List != null)
            {
                    return this.m_List.Item[aIndex];
            }
            
                return this.m_List.Item[aIndex];
            }
            
            }
            
            typeof(SimpleJSON.JSONLazyCreator).__il2cppRuntimeField_10 = this;
            typeof(SimpleJSON.JSONLazyCreator).__il2cppRuntimeField_18 = 0;
            return (SimpleJSON.JSONNode)new System.Object();
        }
        public override void set_Item(int aIndex, SimpleJSON.JSONNode value)
        {
            if((aIndex & 2147483648) == 0)
            {
                    if(this.m_List.Count > aIndex)
            {
                    this.m_List.set_Item(index:  aIndex, value:  value);
                return;
            }
            
            }
            
            this.m_List.Add(item:  value);
        }
        public override SimpleJSON.JSONNode get_Item(string aKey)
        {
            typeof(SimpleJSON.JSONLazyCreator).__il2cppRuntimeField_10 = this;
            typeof(SimpleJSON.JSONLazyCreator).__il2cppRuntimeField_18 = 0;
            return (SimpleJSON.JSONNode)new System.Object();
        }
        public override void set_Item(string aKey, SimpleJSON.JSONNode value)
        {
            this.m_List.Add(item:  value);
        }
        public override int get_Count()
        {
            if(this.m_List != null)
            {
                    return this.m_List.Count;
            }
            
            return this.m_List.Count;
        }
        public override void Add(string aKey, SimpleJSON.JSONNode aItem)
        {
            this.m_List.Add(item:  aItem);
        }
        public override SimpleJSON.JSONNode Remove(int aIndex)
        {
            System.Collections.Generic.List<SimpleJSON.JSONNode> val_4;
            var val_5;
            if(((aIndex >> 30) & 2) == 0)
            {
                    val_4 = this.m_List;
                if(val_4.Count > aIndex)
            {
                    val_4 = this.m_List;
                val_5 = this.m_List.Item[aIndex];
                val_4.RemoveAt(index:  aIndex);
                return (SimpleJSON.JSONNode)val_5;
            }
            
            }
            
            val_5 = 0;
            return (SimpleJSON.JSONNode)val_5;
        }
        public override SimpleJSON.JSONNode Remove(SimpleJSON.JSONNode aNode)
        {
            bool val_1 = this.m_List.Remove(item:  aNode);
            return (SimpleJSON.JSONNode)aNode;
        }
        public override System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode> get_Childs()
        {
            if(null != 0)
            {
                    typeof(JSONArray.<>c__Iterator0).__il2cppRuntimeField_30 = this;
            }
            else
            {
                    mem[48] = this;
            }
            
            typeof(JSONArray.<>c__Iterator0).__il2cppRuntimeField_44 = -2;
            return (System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>)new System.Object();
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        public System.Collections.IEnumerator GetEnumerator()
        {
            typeof(JSONArray.<GetEnumerator>c__Iterator1).__il2cppRuntimeField_30 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        public override string ToString()
        {
            string val_8;
            string val_9;
            List.Enumerator<T> val_1 = this.m_List.GetEnumerator();
            label_11:
            if((0 & 1) == 0)
            {
                goto label_16;
            }
            
            val_8 = 0;
            if(Length < 3)
            {
                    val_9 = "[ ";
            }
            else
            {
                    val_8 = "[ ";
                val_9 = 0 + val_8;
            }
            
            string val_5 = 0.InitializationCallback.ToString();
            string val_6 = 0 + val_9;
            goto label_11;
            label_16:
            0.Dispose();
            return (string)0 + val_9;
        }
        public override string ToString(string aPrefix)
        {
            string val_9;
            List.Enumerator<T> val_1 = this.m_List.GetEnumerator();
            label_11:
            if((0 & 1) == 0)
            {
                goto label_16;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_2 = 0.InitializationCallback;
            if(Length < 4)
            {
                    val_9 = "[ ";
            }
            else
            {
                    val_9 = 0 + "[ ";
            }
            
            string val_5 = 0 + val_9 + "\n" + aPrefix;
            string val_6 = 0 + aPrefix;
            string val_7 = 0 + val_5;
            goto label_11;
            label_16:
            0.Dispose();
            return (string)0 + val_5 + "\n" + aPrefix;
        }
        public override void Serialize(System.IO.BinaryWriter aWriter)
        {
            var val_4;
            int val_1 = this.m_List.Count;
            val_4 = 0;
            goto label_3;
            label_8:
            val_4 = 1;
            label_3:
            if(val_4 >= this.m_List.Count)
            {
                    return;
            }
            
            if(this.m_List.Item[1] != null)
            {
                goto label_8;
            }
            
            goto label_8;
        }
    
    }

}
