using UnityEngine;

namespace UnityEditor.XCodeEditor
{
    public class PBXObject
    {
        // Fields
        protected const string ISA_KEY = "isa";
        protected string _guid;
        protected UnityEditor.XCodeEditor.PBXDictionary _data;
        
        // Properties
        public string guid { get; }
        public UnityEditor.XCodeEditor.PBXDictionary data { get; }
        
        // Methods
        public PBXObject()
        {
            this._data = new UnityEditor.XCodeEditor.PBXDictionary();
            set_Item(key:  "isa", value:  this.GetType());
            this._guid = UnityEditor.XCodeEditor.PBXObject.GenerateGuid();
        }
        public PBXObject(string guid)
        {
            if((UnityEditor.XCodeEditor.PBXObject.IsGuid(aString:  this)) == false)
            {
                    return;
            }
            
            this._guid = guid;
        }
        public PBXObject(string guid, UnityEditor.XCodeEditor.PBXDictionary dictionary)
        {
            var val_10;
            if((dictionary.ContainsKey(key:  "isa")) == false)
            {
                goto label_2;
            }
            
            val_10 = dictionary.Item["isa"];
            if(val_10 == null)
            {
                goto label_5;
            }
            
            if(null == null)
            {
                goto label_7;
            }
            
            goto label_8;
            label_5:
            label_8:
            val_10 = 0;
            label_7:
            if((val_10.CompareTo(strB:  this.GetType())) == 0)
            {
                goto label_9;
            }
            
            label_2:
            UnityEngine.Debug.LogError(message:  0);
            label_9:
            Dictionary.Enumerator<TKey, TValue> val_7 = dictionary.GetEnumerator();
            label_15:
            if((0 & 1) == 0)
            {
                goto label_18;
            }
            
            UnityEngine.Playables.PlayableHandle val_8 = 0.GetHandle();
            this._data.set_Item(key:  val_8.m_Handle.InitializationCallback, value:  val_8.m_Handle);
            goto label_15;
            label_18:
            0.Dispose();
            if((0 & 1) != 0)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
        
        }
        public string get_guid()
        {
            string val_4;
            if((System.String.IsNullOrEmpty(value:  0)) != false)
            {
                    this._guid = UnityEditor.XCodeEditor.PBXObject.GenerateGuid();
                return val_4;
            }
            
            val_4 = this._guid;
            return val_4;
        }
        public UnityEditor.XCodeEditor.PBXDictionary get_data()
        {
            UnityEditor.XCodeEditor.PBXDictionary val_2 = this._data;
            if(val_2 != null)
            {
                    return val_2;
            }
            
            UnityEditor.XCodeEditor.PBXDictionary val_1 = null;
            val_2 = val_1;
            val_1 = new UnityEditor.XCodeEditor.PBXDictionary();
            this._data = val_2;
            return val_2;
        }
        public static bool IsGuid(string aString)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(input:  0, pattern:  X1);
        }
        public static string GenerateGuid()
        {
            System.Guid val_1 = System.Guid.NewGuid();
            return (string)val_1._a.Substring(startIndex:  8).ToUpper();
        }
        public void Add(string key, object obj)
        {
            this._data.Add(key:  key, value:  obj);
        }
        public bool Remove(string key)
        {
            if(this._data != null)
            {
                    return this._data.Remove(key:  key);
            }
            
            return this._data.Remove(key:  key);
        }
        public bool ContainsKey(string key)
        {
            if(this._data != null)
            {
                    return this._data.ContainsKey(key:  key);
            }
            
            return this._data.ContainsKey(key:  key);
        }
        public static bool op_Implicit(UnityEditor.XCodeEditor.PBXObject x)
        {
            var val_4;
            var val_5;
            val_4 = X1;
            if(val_4 != 0)
            {
                    val_4 = val_4.data;
                var val_3 = (val_4.Count == 0) ? 1 : 0;
                return (bool)val_5;
            }
            
            val_5 = 0;
            return (bool)val_5;
        }
        public string ToCSV()
        {
            return 0 + "\"" + this.data;
        }
        public override string ToString()
        {
            return 0 + "{" + this.ToCSV();
        }
    
    }

}
