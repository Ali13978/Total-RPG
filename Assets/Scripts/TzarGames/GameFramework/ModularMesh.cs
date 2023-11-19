using UnityEngine;

namespace TzarGames.GameFramework
{
    public class ModularMesh : MonoBehaviour
    {
        // Fields
        public bool UseLightProbes;
        
        // Methods
        public ModularMesh()
        {
        
        }
        protected void AddPart(UnityEngine.GameObject bonedObject, UnityEngine.GameObject rootedObject)
        {
            goto label_2;
            label_6:
            this.ProcessBoneObject(bObj:  null, rootObject:  rootedObject);
            0 = 1;
            label_2:
            if(0 >= val_2.Length)
            {
                    return;
            }
            
            if(0 < val_2.Length)
            {
                goto label_6;
            }
            
            goto label_6;
        }
        private void ProcessBoneObject(UnityEngine.SkinnedMeshRenderer bObj, UnityEngine.GameObject rootObject)
        {
            var val_16;
            UnityEngine.GameObject val_3 = new UnityEngine.GameObject(name:  bObj.gameObject.name);
            transform.parent = rootObject.transform;
            UnityEngine.SkinnedMeshRenderer val_6 = AddComponent<UnityEngine.SkinnedMeshRenderer>();
            val_6.lightProbeUsage = this.UseLightProbes;
            UnityEngine.Transform[] val_7 = bObj.bones;
            val_16 = 0;
            goto label_10;
            label_23:
            var val_8 = null + ((X26) << 3);
            val_16 = 1;
            mem2[0] = null;
            label_10:
            UnityEngine.Transform[] val_9 = bObj.bones;
            if(val_16 >= val_9.Length)
            {
                goto label_13;
            }
            
            UnityEngine.Transform val_13 = this.findChildByName(name:  bObj.bones[1].name, tr:  rootObject.transform);
            if((val_13 == null) || (val_13 != null))
            {
                goto label_23;
            }
            
            goto label_23;
            label_13:
            val_6.bones = null;
            val_6.sharedMesh = bObj.sharedMesh;
            val_6.sharedMaterials = bObj.sharedMaterials;
        }
        private UnityEngine.Transform findChildByName(string name, UnityEngine.Transform tr)
        {
            UnityEngine.Object val_13;
            string val_14;
            UnityEngine.Object val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            val_13 = tr;
            val_14 = name;
            val_15 = this;
            string val_1 = val_13.name;
            if((System.String.op_Equality(a:  0, b:  val_14)) == true)
            {
                    return (UnityEngine.Transform)val_13;
            }
            
            System.Collections.IEnumerator val_4 = val_13.GetEnumerator();
            do
            {
                var val_13 = 0;
                val_13 = val_13 + 1;
                val_16 = val_4;
                if(((val_4 & 1) & 1) == 0)
            {
                goto label_34;
            }
            
                var val_14 = 0;
                val_14 = val_14 + 1;
                val_17 = val_4;
                val_18 = val_4;
                val_18 = 0;
                val_13 = val_15;
                bool val_10 = UnityEngine.Object.op_Inequality(x:  0, y:  this);
            }
            while(val_10 == false);
            
            val_14 = 0;
            val_15 = 111;
            label_34:
            if(val_4 != null)
            {
                    var val_15 = 0;
                val_15 = val_15 + 1;
                val_19 = val_4;
            }
            
            if( != 109)
            {
                    if( == 111)
            {
                    return (UnityEngine.Transform)val_13;
            }
            
            }
            
            val_13 = 0;
            return (UnityEngine.Transform)val_13;
        }
        public static System.Collections.Generic.List<UnityEngine.GameObject> AddSkinnedMeshTo(UnityEngine.GameObject obj, UnityEngine.Transform root, bool useLightProbes = False)
        {
            var val_1 = W3 & 1;
            return TzarGames.GameFramework.ModularMesh.AddSkinnedMeshTo(obj:  obj, root:  root, deleteOldObject:  useLightProbes, useLightProbes:  false);
        }
        public static System.Collections.Generic.List<UnityEngine.GameObject> AddSkinnedMeshTo(UnityEngine.GameObject obj, UnityEngine.Transform root, bool deleteOldObject, bool useLightProbes)
        {
            UnityEngine.SkinnedMeshRenderer val_4;
            var val_5;
            var val_4 = W4;
            System.Collections.Generic.List<UnityEngine.GameObject> val_1 = new System.Collections.Generic.List<UnityEngine.GameObject>();
            val_5 = 0;
            val_4 = val_4 & 1;
            goto label_2;
            label_7:
            val_4 = val_1;
            Add(item:  X25);
            val_5 = 1;
            label_2:
            if(val_5 >= val_2.Length)
            {
                goto label_4;
            }
            
            UnityEngine.GameObject val_3 = TzarGames.GameFramework.ModularMesh.ProcessBonedObject(ThisRenderer:  val_4, root:  root.GetComponentsInChildren<UnityEngine.SkinnedMeshRenderer>()[1], useLightProbes:  deleteOldObject);
            if(null != 0)
            {
                goto label_7;
            }
            
            goto label_7;
            label_4:
            if(useLightProbes == false)
            {
                    return val_1;
            }
            
            UnityEngine.Object.Destroy(obj:  0);
            return val_1;
        }
        private static UnityEngine.GameObject ProcessBonedObject(UnityEngine.SkinnedMeshRenderer ThisRenderer, UnityEngine.Transform root, bool useLightProbes = False)
        {
            UnityEngine.Mesh val_12;
            var val_13;
            UnityEngine.Material[] val_14;
            UnityEngine.Rendering.LightProbeUsage val_15;
            var val_16;
            UnityEngine.GameObject val_1 = root.gameObject;
            val_1.transform.parent = useLightProbes;
            if(root != null)
            {
                    val_12 = root.sharedMesh;
                val_13 = root.bones;
                val_14 = root.sharedMaterials;
                val_15 = W3 & 1;
            }
            else
            {
                    val_12 = 0.sharedMesh;
                val_13 = 0.bones;
                val_14 = root.sharedMaterials;
                val_15 = W3 & 1;
            }
            
            root.lightProbeUsage = val_15;
            val_16 = 0;
            goto label_7;
            label_16:
            var val_9 = null + ((X28) << 3);
            val_16 = 1;
            mem2[0] = val_7.Length;
            label_7:
            if(val_16 >= val_7.Length)
            {
                goto label_9;
            }
            
            string val_10 = val_13[1].name;
            UnityEngine.Transform val_11 = TzarGames.GameFramework.ModularMesh.FindChildByName(ThisName:  val_10, ThisGObj:  val_10);
            if((val_11 == null) || (val_11 != null))
            {
                goto label_16;
            }
            
            goto label_16;
            label_9:
            if(root != null)
            {
                    root.bones = null;
                root.sharedMesh = val_12;
            }
            else
            {
                    0.bones = null;
                0.sharedMesh = val_12;
            }
            
            root.sharedMaterials = val_14;
            return val_1;
        }
        protected static UnityEngine.Transform FindChildByName(string ThisName, UnityEngine.Transform ThisGObj)
        {
            var val_12;
            var val_13;
            UnityEngine.Object val_14;
            UnityEngine.Object val_15;
            var val_16;
            var val_17;
            var val_18;
            if((System.String.op_Equality(a:  0, b:  X2.name)) != false)
            {
                    return X2.transform;
            }
            
            System.Collections.IEnumerator val_3 = X2.GetEnumerator();
            do
            {
                var val_12 = 0;
                val_12 = val_12 + 1;
                val_12 = val_3;
                if(((val_3 & 1) & 1) == 0)
            {
                goto label_34;
            }
            
                var val_13 = 0;
                val_13 = val_13 + 1;
                val_13 = val_3;
                val_14 = val_3;
                val_14 = 0;
                val_15 = val_14;
                bool val_9 = UnityEngine.Object.op_Inequality(x:  0, y:  val_15);
            }
            while(val_9 == false);
            
            val_16 = 0;
            val_17 = 115;
            label_34:
            if(val_3 != null)
            {
                    var val_14 = 0;
                val_14 = val_14 + 1;
                val_18 = val_3;
            }
            
            if( != 113)
            {
                    if( == 115)
            {
                    return (UnityEngine.Transform)val_15;
            }
            
            }
            
            val_15 = 0;
            return (UnityEngine.Transform)val_15;
        }
    
    }

}
