using UnityEngine;

namespace LlockhamIndustries.ExtensionMethods
{
    [System.Runtime.CompilerServices.ExtensionAttribute]
    public static class LayerMaskExtensionMethods
    {
        // Methods
        [System.Runtime.CompilerServices.ExtensionAttribute]
        public static bool Contains(UnityEngine.LayerMask Mask, int Layer)
        {
            int val_1 = Layer & 4294967295;
            var val_4 = W2 & 31;
            val_4 = 1 << val_4;
            val_4 = (UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask())) | val_4;
            return (bool)((UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask())) == val_4) ? 1 : 0;
        }
        [System.Runtime.CompilerServices.ExtensionAttribute]
        public static UnityEngine.LayerMask Remove(UnityEngine.LayerMask Mask, int Layer)
        {
            Layer = Layer & 4294967295;
            var val_2 = W2 & 31;
            val_2 = 1 << val_2;
            int val_3 = (UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask())) & (~val_2);
            UnityEngine.LayerMask val_4 = UnityEngine.LayerMask.op_Implicit(intVal:  0);
            val_4.m_Mask = val_4.m_Mask & 4294967295;
            return (UnityEngine.LayerMask)val_4.m_Mask;
        }
        [System.Runtime.CompilerServices.ExtensionAttribute]
        public static UnityEngine.LayerMask Remove(UnityEngine.LayerMask Mask, UnityEngine.LayerMask Layers)
        {
            Layers.m_Mask = Layers.m_Mask & 4294967295;
            var val_2 = X2 & 4294967295;
            int val_4 = (UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask())) & (~(UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask())));
            UnityEngine.LayerMask val_5 = UnityEngine.LayerMask.op_Implicit(intVal:  0);
            val_5.m_Mask = val_5.m_Mask & 4294967295;
            return (UnityEngine.LayerMask)val_5.m_Mask;
        }
        [System.Runtime.CompilerServices.ExtensionAttribute]
        public static UnityEngine.LayerMask Add(UnityEngine.LayerMask Mask, int Layer)
        {
            Layer = Layer & 4294967295;
            var val_2 = W2 & 31;
            val_2 = 1 << val_2;
            int val_3 = (UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask())) | val_2;
            UnityEngine.LayerMask val_4 = UnityEngine.LayerMask.op_Implicit(intVal:  0);
            val_4.m_Mask = val_4.m_Mask & 4294967295;
            return (UnityEngine.LayerMask)val_4.m_Mask;
        }
        [System.Runtime.CompilerServices.ExtensionAttribute]
        public static UnityEngine.LayerMask Add(UnityEngine.LayerMask Mask, UnityEngine.LayerMask Layers)
        {
            Layers.m_Mask = Layers.m_Mask & 4294967295;
            var val_2 = X2 & 4294967295;
            int val_4 = (UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask())) | (UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask()));
            UnityEngine.LayerMask val_5 = UnityEngine.LayerMask.op_Implicit(intVal:  0);
            val_5.m_Mask = val_5.m_Mask & 4294967295;
            return (UnityEngine.LayerMask)val_5.m_Mask;
        }
        [System.Runtime.CompilerServices.ExtensionAttribute]
        public static int[] ContainedLayers(UnityEngine.LayerMask Mask)
        {
            var val_4 = X1;
            System.Collections.Generic.List<System.Int32> val_1 = new System.Collections.Generic.List<System.Int32>();
            var val_6 = 0;
            val_4 = val_4 & 4294967295;
            do
            {
                var val_5 = 0;
                val_5 = (UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask())) | val_5;
                if((UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask())) == val_5)
            {
                    Add(item:  0);
            }
            
                val_6 = val_6 + 1;
            }
            while(val_6 != 32);
            
            if(null != 0)
            {
                    return ToArray();
            }
            
            return ToArray();
        }
        [System.Runtime.CompilerServices.ExtensionAttribute]
        public static string[] ContainedLayerNames(UnityEngine.LayerMask Mask)
        {
            var val_5 = X1;
            System.Collections.Generic.List<System.String> val_1 = new System.Collections.Generic.List<System.String>();
            var val_7 = 0;
            val_5 = val_5 & 4294967295;
            do
            {
                var val_6 = 0;
                val_6 = (UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask())) | val_6;
                if((UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask())) == val_6)
            {
                    Add(item:  UnityEngine.LayerMask.LayerToName(layer:  0));
            }
            
                val_7 = val_7 + 1;
            }
            while(val_7 != 32);
            
            if(null != 0)
            {
                    return ToArray();
            }
            
            return ToArray();
        }
        [System.Runtime.CompilerServices.ExtensionAttribute]
        public static void LogLayers(UnityEngine.LayerMask Mask)
        {
            var val_3;
            var val_1 = X1 & 4294967295;
            val_3 = 0;
            goto label_1;
            label_7:
            UnityEngine.Debug.Log(message:  0);
            val_3 = 1;
            label_1:
            if(val_3 >= val_2.Length)
            {
                    return;
            }
            
            int val_3 = LlockhamIndustries.ExtensionMethods.LayerMaskExtensionMethods.ContainedLayers(Mask:  new UnityEngine.LayerMask() {m_Mask = 14315})[1];
            goto label_7;
        }
        [System.Runtime.CompilerServices.ExtensionAttribute]
        public static void LogLayerNames(UnityEngine.LayerMask Mask)
        {
            var val_3;
            var val_1 = X1 & 4294967295;
            val_3 = 0;
            goto label_1;
            label_7:
            UnityEngine.Debug.Log(message:  0);
            val_3 = 1;
            label_1:
            if(val_3 >= val_2.Length)
            {
                    return;
            }
            
            string val_3 = LlockhamIndustries.ExtensionMethods.LayerMaskExtensionMethods.ContainedLayerNames(Mask:  new UnityEngine.LayerMask() {m_Mask = 14314})[1];
            goto label_7;
        }
    
    }

}
