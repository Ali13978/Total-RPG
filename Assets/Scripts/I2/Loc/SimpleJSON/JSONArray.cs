using UnityEngine;

namespace I2.Loc.SimpleJSON
{
    public class JSONArray : JSONNode, IEnumerable
    {
        // Fields
        private System.Collections.Generic.List<I2.Loc.SimpleJSON.JSONNode> m_List;
        
        // Properties
        public override I2.Loc.SimpleJSON.JSONNode Item { get; set; }
        public override I2.Loc.SimpleJSON.JSONNode Item { get; set; }
        public override int Count { get; }
        public override System.Collections.Generic.IEnumerable<I2.Loc.SimpleJSON.JSONNode> Childs { get; }
        
        // Methods
        public JSONArray()
        {
            this.m_List = new System.Collections.Generic.List<I2.Loc.SimpleJSON.JSONNode>();
        }
        public override I2.Loc.SimpleJSON.JSONNode get_Item(int aIndex)
        {
            System.Collections.Generic.List<I2.Loc.SimpleJSON.JSONNode> val_3;
            if((aIndex & 2147483648) != 0)
            {
                    return (I2.Loc.SimpleJSON.JSONNode)new I2.Loc.SimpleJSON.JSONLazyCreator(aNode:  this);
            }
            
            val_3 = this.m_List;
            if(val_3.Count <= aIndex)
            {
                    return (I2.Loc.SimpleJSON.JSONNode)new I2.Loc.SimpleJSON.JSONLazyCreator(aNode:  this);
            }
            
            if(this.m_List != null)
            {
                    return this.m_List.Item[aIndex];
            }
            
            return this.m_List.Item[aIndex];
        }
        public override void set_Item(int aIndex, I2.Loc.SimpleJSON.JSONNode value)
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
        public override I2.Loc.SimpleJSON.JSONNode get_Item(string aKey)
        {
            return (I2.Loc.SimpleJSON.JSONNode)new I2.Loc.SimpleJSON.JSONLazyCreator(aNode:  this);
        }
        public override void set_Item(string aKey, I2.Loc.SimpleJSON.JSONNode value)
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
        public override void Add(string aKey, I2.Loc.SimpleJSON.JSONNode aItem)
        {
            this.m_List.Add(item:  aItem);
        }
        public override I2.Loc.SimpleJSON.JSONNode Remove(int aIndex)
        {
            System.Collections.Generic.List<I2.Loc.SimpleJSON.JSONNode> val_4;
            var val_5;
            if(((aIndex >> 30) & 2) == 0)
            {
                    val_4 = this.m_List;
                if(val_4.Count > aIndex)
            {
                    val_4 = this.m_List;
                val_5 = this.m_List.Item[aIndex];
                val_4.RemoveAt(index:  aIndex);
                return (I2.Loc.SimpleJSON.JSONNode)val_5;
            }
            
            }
            
            val_5 = 0;
            return (I2.Loc.SimpleJSON.JSONNode)val_5;
        }
        public override I2.Loc.SimpleJSON.JSONNode Remove(I2.Loc.SimpleJSON.JSONNode aNode)
        {
            bool val_1 = this.m_List.Remove(item:  aNode);
            return (I2.Loc.SimpleJSON.JSONNode)aNode;
        }
        public override System.Collections.Generic.IEnumerable<I2.Loc.SimpleJSON.JSONNode> get_Childs()
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
            return (System.Collections.Generic.IEnumerable<I2.Loc.SimpleJSON.JSONNode>)new System.Object();
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
