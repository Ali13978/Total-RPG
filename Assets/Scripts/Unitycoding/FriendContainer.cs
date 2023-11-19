using UnityEngine;

namespace Unitycoding
{
    public class FriendContainer : UIContainer<Unitycoding.FriendInfo>
    {
        // Fields
        private static System.Func<Unitycoding.FriendInfo, string> <>f__am$cache0;
        
        // Methods
        public FriendContainer()
        {
        
        }
        protected override void OnStart()
        {
            this.Load();
        }
        public virtual bool Add(Unitycoding.FriendInfo item, bool save)
        {
            Unitycoding.FriendInfo val_6;
            var val_7;
            val_6 = item;
            object val_1 = new System.Object();
            if(null != 0)
            {
                    val_7 = val_1;
                typeof(FriendContainer.<Add>c__AnonStorey0).__il2cppRuntimeField_10 = val_6;
            }
            else
            {
                    val_7 = 16;
                mem[16] = val_6;
                val_6 = mem[16];
            }
            
            if(val_6 != 0)
            {
                    if((this.Items.Find(match:  new System.Predicate<Unitycoding.FriendInfo>(object:  val_1, method:  System.Boolean FriendContainer.<Add>c__AnonStorey0::<>m__0(Unitycoding.FriendInfo x)))) == null)
            {
                goto label_5;
            }
            
            }
            
            var val_6 = 0;
            label_9:
            val_6 = val_6 & 1;
            return (bool)val_6;
            label_5:
            if(((this.Add(item:  mem[16])) == false) || (save == false))
            {
                goto label_9;
            }
            
            this.Save();
            goto label_9;
        }
        public override bool Add(Unitycoding.FriendInfo item)
        {
            goto typeof(Unitycoding.FriendContainer).__il2cppRuntimeField_200;
        }
        public void Save()
        {
            if((Unitycoding.FriendContainer.<>f__am$cache0) == null)
            {
                    Unitycoding.FriendContainer.<>f__am$cache0 = new System.Func<Unitycoding.FriendInfo, System.String>(object:  0, method:  static System.String Unitycoding.FriendContainer::<Save>m__0(Unitycoding.FriendInfo x));
                null = null;
            }
            
            System.Collections.Generic.IEnumerable<TResult> val_3 = System.Linq.Enumerable.Select<System.Type, System.String>(source:  0, selector:  this.Items);
            string val_5 = MiniJSON.Serializer.Serialize(obj:  System.Linq.Enumerable.ToList<UnityEngine.Component>(source:  0));
            UnityEngine.PlayerPrefs.SetString(key:  0, value:  0 + UnityEngine.PlayerPrefs.GetString(key:  0)(UnityEngine.PlayerPrefs.GetString(key:  0)));
        }
        public void Load()
        {
            var val_14;
            var val_15;
            string val_2 = 0 + UnityEngine.PlayerPrefs.GetString(key:  0)(UnityEngine.PlayerPrefs.GetString(key:  0));
            bool val_4 = System.String.IsNullOrEmpty(value:  0);
            if(val_4 == true)
            {
                    return;
            }
            
            if((UnityEngine.PlayerPrefs.GetString(key:  0)) != null)
            {
                    val_14 = MiniJSON.Parser.Parse(jsonString:  val_4);
            }
            
            val_14 = 0;
            System.Collections.Generic.IEnumerable<TResult> val_9 = System.Linq.Enumerable.OfType<System.String>(source:  0);
            System.Collections.Generic.List<TSource> val_10 = System.Linq.Enumerable.ToList<UnityEngine.Component>(source:  0);
            val_15 = 0;
            goto label_8;
            label_12:
            object val_12 = new System.Object();
            typeof(Unitycoding.FriendInfo).__il2cppRuntimeField_10 = val_10.Item[0];
            val_15 = 1;
            label_8:
            if(val_15 >= val_10.Count)
            {
                    return;
            }
            
            if(val_10 != null)
            {
                goto label_12;
            }
            
            goto label_12;
        }
        private static string <Save>m__0(Unitycoding.FriendInfo x)
        {
            if(X1 != 0)
            {
                    return (string)X1 + 16;
            }
            
            return (string)X1 + 16;
        }
    
    }

}
