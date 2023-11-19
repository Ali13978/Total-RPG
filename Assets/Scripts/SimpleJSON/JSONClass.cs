using UnityEngine;

namespace SimpleJSON
{
    public class JSONClass : JSONNode, IEnumerable
    {
        // Fields
        private System.Collections.Generic.Dictionary<string, SimpleJSON.JSONNode> m_Dict;
        
        // Properties
        public override SimpleJSON.JSONNode Item { get; set; }
        public override SimpleJSON.JSONNode Item { get; set; }
        public override int Count { get; }
        public override System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode> Childs { get; }
        public System.Collections.Generic.Dictionary<string, SimpleJSON.JSONNode> Dict { get; }
        
        // Methods
        public JSONClass()
        {
            this.m_Dict = new System.Collections.Generic.Dictionary<System.String, SimpleJSON.JSONNode>();
            this = new System.Object();
        }
        public override SimpleJSON.JSONNode get_Item(string aKey)
        {
            if((this.m_Dict.ContainsKey(key:  aKey)) != false)
            {
                    if(this.m_Dict != null)
            {
                    return this.m_Dict.Item[aKey];
            }
            
                return this.m_Dict.Item[aKey];
            }
            
            typeof(SimpleJSON.JSONLazyCreator).__il2cppRuntimeField_10 = this;
            typeof(SimpleJSON.JSONLazyCreator).__il2cppRuntimeField_18 = aKey;
            return (SimpleJSON.JSONNode)new System.Object();
        }
        public override void set_Item(string aKey, SimpleJSON.JSONNode value)
        {
            if((this.m_Dict.ContainsKey(key:  aKey)) != false)
            {
                    this.m_Dict.set_Item(key:  aKey, value:  value);
                return;
            }
            
            this.m_Dict.Add(key:  aKey, value:  value);
        }
        public override SimpleJSON.JSONNode get_Item(int aIndex)
        {
            System.Collections.Generic.Dictionary<System.String, SimpleJSON.JSONNode> val_4;
            var val_5 = 0;
            if(((aIndex >> 30) & 2) != 0)
            {
                    return (SimpleJSON.JSONNode)val_5;
            }
            
            val_4 = this.m_Dict;
            if(val_4.Count > aIndex)
            {
                    System.Collections.Generic.KeyValuePair<System.Object, System.Object> val_3 = System.Linq.Enumerable.ElementAt<System.Collections.Generic.KeyValuePair<System.Object, System.Object>>(source:  0, index:  this.m_Dict);
                val_5;
                return (SimpleJSON.JSONNode)val_5;
            }
            
            val_5 = 0;
            return (SimpleJSON.JSONNode)val_5;
        }
        public override void set_Item(int aIndex, SimpleJSON.JSONNode value)
        {
            int val_5 = aIndex;
            if(((val_5 >> 30) & 2) != 0)
            {
                    return;
            }
            
            if(this.m_Dict.Count <= val_5)
            {
                    return;
            }
            
            System.Collections.Generic.KeyValuePair<System.Object, System.Object> val_3 = System.Linq.Enumerable.ElementAt<System.Collections.Generic.KeyValuePair<System.Object, System.Object>>(source:  0, index:  this.m_Dict);
            val_5 = this.m_Dict;
            val_5.set_Item(key:  val_3.Value.InitializationCallback, value:  value);
        }
        public override int get_Count()
        {
            if(this.m_Dict != null)
            {
                    return this.m_Dict.Count;
            }
            
            return this.m_Dict.Count;
        }
        public override void Add(string aKey, SimpleJSON.JSONNode aItem)
        {
            string val_5;
            System.Collections.Generic.Dictionary<System.String, SimpleJSON.JSONNode> val_6;
            var val_7;
            val_5 = aKey;
            val_6 = this;
            if((System.String.IsNullOrEmpty(value:  0)) != false)
            {
                    System.Guid val_3 = System.Guid.NewGuid();
                val_5 = ;
                val_7 = public System.Void System.Collections.Generic.Dictionary<System.String, SimpleJSON.JSONNode>::Add(System.String key, SimpleJSON.JSONNode value);
            }
            else
            {
                    val_6 = this.m_Dict;
                if((this.m_Dict.ContainsKey(key:  val_5)) != false)
            {
                    val_6.set_Item(key:  val_5, value:  aItem);
                return;
            }
            
                val_7 = public System.Void System.Collections.Generic.Dictionary<System.String, SimpleJSON.JSONNode>::Add(System.String key, SimpleJSON.JSONNode value);
            }
            
            val_6.Add(key:  val_5, value:  aItem);
        }
        public override SimpleJSON.JSONNode Remove(string aKey)
        {
            System.Collections.Generic.Dictionary<System.String, SimpleJSON.JSONNode> val_4;
            var val_5;
            val_4 = this.m_Dict;
            if((val_4.ContainsKey(key:  aKey)) != false)
            {
                    val_4 = this.m_Dict;
                val_5 = this.m_Dict.Item[aKey];
                bool val_3 = val_4.Remove(key:  aKey);
                return (SimpleJSON.JSONNode)val_5;
            }
            
            val_5 = 0;
            return (SimpleJSON.JSONNode)val_5;
        }
        public override SimpleJSON.JSONNode Remove(int aIndex)
        {
            System.Collections.Generic.Dictionary<System.String, SimpleJSON.JSONNode> val_6;
            System.Collections.Generic.Dictionary<System.String, SimpleJSON.JSONNode> val_7;
            var val_8;
            val_7 = this;
            val_8 = 0;
            if(((aIndex >> 30) & 2) != 0)
            {
                    return (SimpleJSON.JSONNode)val_8;
            }
            
            val_6 = this.m_Dict;
            if(val_6.Count > aIndex)
            {
                    System.Collections.Generic.KeyValuePair<System.Object, System.Object> val_3 = System.Linq.Enumerable.ElementAt<System.Collections.Generic.KeyValuePair<System.Object, System.Object>>(source:  0, index:  this.m_Dict);
                val_7 = this.m_Dict;
                bool val_5 = val_7.Remove(key:  val_3.Value.InitializationCallback);
                val_8;
                return (SimpleJSON.JSONNode)val_8;
            }
            
            val_8 = 0;
            return (SimpleJSON.JSONNode)val_8;
        }
        public override SimpleJSON.JSONNode Remove(SimpleJSON.JSONNode aNode)
        {
            typeof(JSONClass.<Remove>c__AnonStorey2).__il2cppRuntimeField_10 = aNode;
            System.Func<System.Collections.Generic.KeyValuePair<System.String, SimpleJSON.JSONNode>, System.Boolean> val_2 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, SimpleJSON.JSONNode>, System.Boolean>(object:  new System.Object(), method:  System.Boolean JSONClass.<Remove>c__AnonStorey2::<>m__0(System.Collections.Generic.KeyValuePair<string, SimpleJSON.JSONNode> k));
            System.Collections.Generic.IEnumerable<TSource> val_3 = System.Linq.Enumerable.Where<System.Collections.Generic.KeyValuePair<System.Object, System.Object>>(source:  0, predicate:  this.m_Dict);
            System.Collections.Generic.KeyValuePair<System.Object, System.Object> val_4 = System.Linq.Enumerable.First<System.Collections.Generic.KeyValuePair<System.Object, System.Object>>(source:  0);
            bool val_6 = this.m_Dict.Remove(key:  val_4.Value.InitializationCallback);
            if(null != 0)
            {
                    return (SimpleJSON.JSONNode)typeof(JSONClass.<Remove>c__AnonStorey2).__il2cppRuntimeField_10;
            }
            
            return (SimpleJSON.JSONNode)typeof(JSONClass.<Remove>c__AnonStorey2).__il2cppRuntimeField_10;
        }
        public override System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode> get_Childs()
        {
            if(null != 0)
            {
                    typeof(JSONClass.<>c__Iterator0).__il2cppRuntimeField_40 = this;
            }
            else
            {
                    mem[64] = this;
            }
            
            typeof(JSONClass.<>c__Iterator0).__il2cppRuntimeField_54 = -2;
            return (System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>)new System.Object();
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        public System.Collections.IEnumerator GetEnumerator()
        {
            typeof(JSONClass.<GetEnumerator>c__Iterator1).__il2cppRuntimeField_40 = this;
            return (System.Collections.IEnumerator)new System.Object();
        }
        public System.Collections.Generic.Dictionary<string, SimpleJSON.JSONNode> get_Dict()
        {
            return (System.Collections.Generic.Dictionary<System.String, SimpleJSON.JSONNode>)this.m_Dict;
        }
        public override string ToString()
        {
            var val_2;
            string val_11;
            Dictionary.Enumerator<TKey, TValue> val_1 = this.m_Dict.GetEnumerator();
            label_28:
            if((0 & 1) == 0)
            {
                goto label_33;
            }
            
            UnityEngine.Playables.PlayableHandle val_4 = val_2.GetHandle();
            if(Length < 3)
            {
                    val_11 = "{";
            }
            else
            {
                    val_11 = 0 + "{";
            }
            
            typeof(System.String[]).__il2cppRuntimeField_20 = val_11;
            typeof(System.String[]).__il2cppRuntimeField_28 = "\"";
            typeof(System.String[]).__il2cppRuntimeField_30 = SimpleJSON.JSONNode.Escape(aText:  val_4.m_Handle.InitializationCallback);
            typeof(System.String[]).__il2cppRuntimeField_38 = "\":";
            typeof(System.String[]).__il2cppRuntimeField_40 = ;
            string val_9 = +0;
            goto label_28;
            label_33:
            val_2.Dispose();
            return (string)0 + val_11;
        }
        public override string ToString(string aPrefix)
        {
            var val_2;
            string val_13;
            Dictionary.Enumerator<TKey, TValue> val_1 = this.m_Dict.GetEnumerator();
            label_28:
            if((0 & 1) == 0)
            {
                goto label_33;
            }
            
            UnityEngine.Playables.PlayableHandle val_4 = val_2.GetHandle();
            if(Length < 4)
            {
                    val_13 = "{ ";
            }
            else
            {
                    val_13 = 0 + "{ ";
            }
            
            string val_7 = 0 + val_13 + "\n" + aPrefix;
            typeof(System.String[]).__il2cppRuntimeField_20 = val_7;
            typeof(System.String[]).__il2cppRuntimeField_28 = "\"";
            typeof(System.String[]).__il2cppRuntimeField_30 = SimpleJSON.JSONNode.Escape(aText:  val_4.m_Handle.InitializationCallback);
            typeof(System.String[]).__il2cppRuntimeField_38 = "\" : ";
            string val_10 = 0 + aPrefix;
            typeof(System.String[]).__il2cppRuntimeField_40 = ;
            string val_11 = +0;
            goto label_28;
            label_33:
            val_2.Dispose();
            return (string)0 + val_7 + "\n" + aPrefix;
        }
        public override void Serialize(System.IO.BinaryWriter aWriter)
        {
            int val_1 = this.m_Dict.Count;
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_3 = this.m_Dict.Keys.GetEnumerator();
            label_9:
            if((0 & 1) == 0)
            {
                goto label_12;
            }
            
            if(this.m_Dict.Item[0] != null)
            {
                goto label_9;
            }
            
            goto label_9;
            label_12:
            if((0 & 1) != 0)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
        
        }
    
    }

}
