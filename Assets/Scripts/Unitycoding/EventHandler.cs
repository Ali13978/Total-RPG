using UnityEngine;

namespace Unitycoding
{
    public class EventHandler : MonoBehaviour
    {
        // Fields
        private static System.Collections.Generic.Dictionary<string, System.Delegate> m_GlobalEvents;
        private static System.Collections.Generic.Dictionary<object, System.Collections.Generic.Dictionary<string, System.Delegate>> m_Events;
        
        // Methods
        private static EventHandler()
        {
            Unitycoding.EventHandler.m_GlobalEvents = new System.Collections.Generic.Dictionary<System.String, System.Delegate>();
            Unitycoding.EventHandler.m_Events = new System.Collections.Generic.Dictionary<System.Object, System.Collections.Generic.Dictionary<System.String, System.Delegate>>();
        }
        public EventHandler()
        {
        
        }
        public static void Execute(string eventName)
        {
            System.Delegate val_1 = Unitycoding.EventHandler.GetDelegate(eventName:  null);
            if(val_1 == null)
            {
                    return;
            }
            
            if(null != null)
            {
                    return;
            }
            
            val_1.Invoke();
        }
        public static void Execute(object obj, string eventName)
        {
            System.Delegate val_1 = Unitycoding.EventHandler.GetDelegate(obj:  null, eventName:  eventName);
            if(val_1 == null)
            {
                    return;
            }
            
            if(null != null)
            {
                    return;
            }
            
            val_1.Invoke();
        }
        public static void Execute<T1>(string eventName, T1 arg1)
        {
            var val_8;
            var val_9;
            val_8 = __RuntimeMethodHiddenParam;
            val_9 = mem[X3 + 48];
            val_9 = X3 + 48;
            if((Unitycoding.EventHandler.GetDelegate(eventName:  0)) == null)
            {
                    return;
            }
            
            val_8 = ???;
            val_9 = ???;
            goto X3 + 48 + 8;
        }
        public static void Execute<T1>(object obj, string eventName, T1 arg1)
        {
            var val_10;
            var val_11;
            var val_12;
            val_11 = __RuntimeMethodHiddenParam;
            val_12 = mem[X4 + 48];
            val_12 = X4 + 48;
            if((Unitycoding.EventHandler.GetDelegate(obj:  0, eventName:  eventName)) == null)
            {
                    return;
            }
            
            val_11 = ???;
            val_12 = ???;
            val_10 = ???;
            goto X4 + 48 + 8;
        }
        public static void Execute<T1, T2>(string eventName, T1 arg1, T2 arg2)
        {
            var val_10;
            var val_11;
            var val_12;
            val_10 = __RuntimeMethodHiddenParam;
            val_11 = arg2;
            val_12 = Unitycoding.EventHandler.GetDelegate(eventName:  0);
            if(val_12 == null)
            {
                    return;
            }
            
            val_10 = ???;
            val_11 = ???;
            val_12 = ???;
            goto X4 + 48 + 8;
        }
        public static void Execute<T1, T2>(object obj, string eventName, T1 arg1, T2 arg2)
        {
            var val_10;
            var val_11;
            var val_12;
            val_10 = __RuntimeMethodHiddenParam;
            val_11 = arg2;
            val_12 = Unitycoding.EventHandler.GetDelegate(obj:  0, eventName:  eventName);
            if(val_12 == null)
            {
                    return;
            }
            
            val_10 = ???;
            val_11 = ???;
            val_12 = ???;
            goto X5 + 48 + 8;
        }
        public static void Execute<T1, T2, T3>(string eventName, T1 arg1, T2 arg2, T3 arg3)
        {
            var val_10;
            var val_11;
            var val_12;
            val_10 = __RuntimeMethodHiddenParam;
            val_11 = arg3;
            val_12 = mem[X5 + 48];
            val_12 = X5 + 48;
            if((Unitycoding.EventHandler.GetDelegate(eventName:  0)) == null)
            {
                    return;
            }
            
            val_10 = ???;
            val_11 = ???;
            val_12 = ???;
            goto X5 + 48 + 8;
        }
        public static void Execute<T1, T2, T3>(object obj, string eventName, T1 arg1, T2 arg2, T3 arg3)
        {
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            val_13 = __RuntimeMethodHiddenParam;
            val_14 = arg3;
            val_15 = mem[X6 + 48];
            val_15 = X6 + 48;
            if((Unitycoding.EventHandler.GetDelegate(obj:  0, eventName:  eventName)) == null)
            {
                    return;
            }
            
            val_13 = ???;
            val_14 = ???;
            val_15 = ???;
            val_12 = ???;
            goto X6 + 48 + 8;
        }
        public static void Register(string eventName, System.Action handler)
        {
            Unitycoding.EventHandler.Register(eventName:  null, handler:  handler);
        }
        public static void Register(object obj, string eventName, System.Action handler)
        {
            Unitycoding.EventHandler.Register(obj:  null, eventName:  eventName, handler:  handler);
        }
        public static void Register<T1>(string eventName, System.Action<T1> handler)
        {
            Unitycoding.EventHandler.Register(eventName:  0, handler:  handler);
        }
        public static void Register<T1>(object obj, string eventName, System.Action<T1> handler)
        {
            Unitycoding.EventHandler.Register(obj:  0, eventName:  eventName, handler:  handler);
        }
        public static void Register<T1, T2>(string eventName, System.Action<T1, T2> handler)
        {
            Unitycoding.EventHandler.Register(eventName:  0, handler:  handler);
        }
        public static void Register<T1, T2>(object obj, string eventName, System.Action<T1, T2> handler)
        {
            Unitycoding.EventHandler.Register(obj:  0, eventName:  eventName, handler:  handler);
        }
        public static void Register<T1, T2, T3>(string eventName, System.Action<T1, T2, T3> handler)
        {
            Unitycoding.EventHandler.Register(eventName:  0, handler:  handler);
        }
        public static void Register<T1, T2, T3>(object obj, string eventName, System.Action<T1, T2, T3> handler)
        {
            Unitycoding.EventHandler.Register(obj:  0, eventName:  eventName, handler:  handler);
        }
        public static void Unregister(string eventName, System.Action handler)
        {
            Unitycoding.EventHandler.Unregister(eventName:  null, handler:  handler);
        }
        public static void Unregister(object obj, string eventName, System.Action handler)
        {
            Unitycoding.EventHandler.Unregister(obj:  null, eventName:  eventName, handler:  handler);
        }
        public static void Unregister<T1>(string eventName, System.Action<T1> handler)
        {
            Unitycoding.EventHandler.Unregister(eventName:  0, handler:  handler);
        }
        public static void Unregister<T1>(object obj, string eventName, System.Action<T1> handler)
        {
            Unitycoding.EventHandler.Unregister(obj:  0, eventName:  eventName, handler:  handler);
        }
        public static void Unregister<T1, T2>(string eventName, System.Action<T1, T2> handler)
        {
            Unitycoding.EventHandler.Unregister(eventName:  0, handler:  handler);
        }
        public static void Unregister<T1, T2>(object obj, string eventName, System.Action<T1, T2> handler)
        {
            Unitycoding.EventHandler.Unregister(obj:  0, eventName:  eventName, handler:  handler);
        }
        public static void Unregister<T1, T2, T3>(string eventName, System.Action<T1, T2, T3> handler)
        {
            Unitycoding.EventHandler.Unregister(eventName:  0, handler:  handler);
        }
        public static void Unregister<T1, T2, T3>(object obj, string eventName, System.Action<T1, T2, T3> handler)
        {
            Unitycoding.EventHandler.Unregister(obj:  0, eventName:  eventName, handler:  handler);
        }
        private static void Register(string eventName, System.Delegate handler)
        {
            var val_7;
            var val_8;
            var val_9;
            System.Collections.Generic.Dictionary<System.String, System.Delegate> val_10;
            var val_11;
            System.Delegate val_1 = 0;
            val_7 = null;
            val_7 = null;
            val_8 = null;
            if((Unitycoding.EventHandler.m_GlobalEvents.TryGetValue(key:  handler, value: out  val_1)) != false)
            {
                    val_9 = null;
                val_10 = Unitycoding.EventHandler.m_GlobalEvents;
                val_10.set_Item(key:  handler, value:  System.Delegate.Combine(a:  0, b:  val_1));
                return;
            }
            
            val_11 = null;
            val_10 = Unitycoding.EventHandler.m_GlobalEvents;
            val_10.Add(key:  handler, value:  X2);
        }
        private static void Register(object obj, string eventName, System.Delegate handler)
        {
            object val_9;
            System.Collections.Generic.Dictionary<System.Object, System.Collections.Generic.Dictionary<System.String, System.Delegate>> val_10;
            var val_11;
            System.Collections.Generic.Dictionary<System.String, System.Delegate> val_12;
            var val_13;
            val_9 = eventName;
            System.Delegate val_5 = 0;
            if(val_9 == null)
            {
                    return;
            }
            
            val_10 = 1152921504983842816;
            val_11 = null;
            val_11 = null;
            if((Unitycoding.EventHandler.m_Events.TryGetValue(key:  val_9, value: out  0)) != true)
            {
                    System.Collections.Generic.Dictionary<System.String, System.Delegate> val_4 = null;
                val_12 = val_4;
                val_4 = new System.Collections.Generic.Dictionary<System.String, System.Delegate>();
                val_13 = null;
                val_13 = null;
                val_12 = val_12;
                val_10 = Unitycoding.EventHandler.m_Events;
                val_10.Add(key:  val_9, value:  val_12);
            }
            
            val_9 = val_12;
            if((TryGetValue(key:  handler, value: out  val_5)) != false)
            {
                    set_Item(key:  handler, value:  System.Delegate.Combine(a:  0, b:  val_5));
                return;
            }
            
            Add(key:  handler, value:  X3);
        }
        private static void Unregister(string eventName, System.Delegate handler)
        {
            var val_4;
            System.Collections.Generic.Dictionary<System.String, System.Delegate> val_5;
            var val_6;
            System.Delegate val_1 = 0;
            val_4 = null;
            val_4 = null;
            val_5 = Unitycoding.EventHandler.m_GlobalEvents;
            if((val_5.TryGetValue(key:  handler, value: out  val_1)) == false)
            {
                    return;
            }
            
            val_6 = null;
            val_6 = null;
            val_5 = Unitycoding.EventHandler.m_GlobalEvents;
            val_5.set_Item(key:  handler, value:  System.Delegate.Remove(source:  0, value:  val_1));
        }
        private static void Unregister(object obj, string eventName, System.Delegate handler)
        {
            object val_6;
            var val_7;
            val_6 = eventName;
            System.Delegate val_3 = 0;
            System.Collections.Generic.Dictionary<System.String, System.Delegate> val_1 = 0;
            if(val_6 == null)
            {
                    return;
            }
            
            val_7 = null;
            val_7 = null;
            if((Unitycoding.EventHandler.m_Events.TryGetValue(key:  val_6, value: out  val_1)) == false)
            {
                    return;
            }
            
            val_6 = val_1;
            if((val_6.TryGetValue(key:  handler, value: out  val_3)) == false)
            {
                    return;
            }
            
            val_6 = val_1;
            val_6.set_Item(key:  handler, value:  System.Delegate.Remove(source:  0, value:  val_3));
        }
        private static System.Delegate GetDelegate(string eventName)
        {
            var val_4;
            System.Delegate val_1 = 0;
            val_4 = null;
            val_4 = null;
            return (System.Delegate)((Unitycoding.EventHandler.m_GlobalEvents.TryGetValue(key:  X1, value: out  val_1)) != true) ? (val_1) : 0;
        }
        private static System.Delegate GetDelegate(object obj, string eventName)
        {
            var val_6;
            var val_7;
            val_6 = null;
            System.Delegate val_3 = 0;
            val_6 = null;
            if((Unitycoding.EventHandler.m_Events.TryGetValue(key:  eventName, value: out  0)) != false)
            {
                    var val_5 = ((val_1.TryGetValue(key:  X2, value: out  val_3)) != true) ? (val_3) : 0;
                return (System.Delegate)val_7;
            }
            
            val_7 = 0;
            return (System.Delegate)val_7;
        }
    
    }

}
