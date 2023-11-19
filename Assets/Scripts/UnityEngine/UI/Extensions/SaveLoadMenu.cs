using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    public class SaveLoadMenu : MonoBehaviour
    {
        // Fields
        public bool showMenu;
        public bool usePersistentDataPath;
        public string savePath;
        public System.Collections.Generic.Dictionary<string, UnityEngine.GameObject> prefabDictionary;
        
        // Methods
        public SaveLoadMenu()
        {
            this.usePersistentDataPath = true;
        }
        private void Start()
        {
            var val_10;
            var val_11;
            if(this.usePersistentDataPath != false)
            {
                    this.savePath = 0 + UnityEngine.Application.persistentDataPath;
            }
            
            this.prefabDictionary = new System.Collections.Generic.Dictionary<System.String, UnityEngine.GameObject>();
            val_10 = null;
            val_10 = null;
            val_11 = 0;
            goto label_6;
            label_21:
            val_11 = 1;
            label_6:
            if(val_11 >= val_4.Length)
            {
                    return;
            }
            
            T val_10 = UnityEngine.Resources.LoadAll<UnityEngine.GameObject>(path:  0)[1];
            UnityEngine.UI.Extensions.ObjectIdentifier val_5 = val_10.GetComponent<UnityEngine.UI.Extensions.ObjectIdentifier>();
            if((UnityEngine.Object.op_Implicit(exists:  0)) == false)
            {
                goto label_21;
            }
            
            this.prefabDictionary.Add(key:  val_10.name, value:  val_10);
            string val_8 = val_10.name;
            string val_9 = 0 + "Added GameObject to prefabDictionary: "("Added GameObject to prefabDictionary: ");
            UnityEngine.Debug.Log(message:  0);
            goto label_21;
        }
        private void Update()
        {
            if((UnityEngine.Input.GetKeyDown(key:  0)) != false)
            {
                    bool val_4 = this.showMenu;
                val_4 = val_4 ^ 1;
                this.showMenu = val_4;
            }
            
            if((UnityEngine.Input.GetKeyDown(key:  0)) != false)
            {
                    this.SaveGame();
            }
            
            if((UnityEngine.Input.GetKeyDown(key:  0)) == false)
            {
                    return;
            }
            
            this.LoadGame();
        }
        private void OnGUI()
        {
            if(this.showMenu == false)
            {
                    return;
            }
            
            UnityEngine.GUILayout.BeginHorizontal(options:  0);
            UnityEngine.GUILayout.FlexibleSpace();
            UnityEngine.GUILayout.BeginVertical(options:  0);
            UnityEngine.GUILayout.FlexibleSpace();
            if((UnityEngine.GUILayout.Button(text:  0, options:  "Exit to Windows")) != false)
            {
                    UnityEngine.Application.Quit();
                return;
            }
            
            if((UnityEngine.GUILayout.Button(text:  0, options:  "Save Game")) != false)
            {
                    this.SaveGame();
                return;
            }
            
            if((UnityEngine.GUILayout.Button(text:  0, options:  "Load Game")) != false)
            {
                    this.LoadGame();
                return;
            }
            
            UnityEngine.GUILayout.FlexibleSpace();
            UnityEngine.GUILayout.EndVertical();
            UnityEngine.GUILayout.FlexibleSpace();
            UnityEngine.GUILayout.EndHorizontal();
        }
        [System.Diagnostics.DebuggerHiddenAttribute]
        private System.Collections.IEnumerator wait(float time)
        {
            typeof(SaveLoadMenu.<wait>c__Iterator0).__il2cppRuntimeField_10 = time;
            return (System.Collections.IEnumerator)new System.Object();
        }
        public void SaveGame()
        {
            this.SaveGame(saveGameName:  "QuickSave");
        }
        public void SaveGame(string saveGameName)
        {
            var val_13;
            string val_18;
            string val_19;
            UnityEngine.UI.Extensions.SaveLoadMenu val_20;
            var val_21;
            var val_22;
            var val_23;
            val_19 = saveGameName;
            val_20 = this;
            if((System.String.IsNullOrEmpty(value:  0)) != false)
            {
                    UnityEngine.Debug.Log(message:  0);
                return;
            }
            
            val_21 = null;
            val_21 = null;
            UnityEngine.UI.Extensions.SaveLoad.saveGamePath = this.savePath;
            UnityEngine.UI.Extensions.SaveGame val_2 = new UnityEngine.UI.Extensions.SaveGame();
            typeof(UnityEngine.UI.Extensions.SaveGame).__il2cppRuntimeField_10 = val_19;
            System.Collections.Generic.List<UnityEngine.GameObject> val_3 = null;
            val_19 = val_3;
            val_3 = new System.Collections.Generic.List<UnityEngine.GameObject>();
            System.Type val_4 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            val_22 = 0;
            goto label_14;
            label_34:
            val_22 = 1;
            label_14:
            if(val_22 >= val_5.Length)
            {
                goto label_16;
            }
            
            UnityEngine.Object val_18 = UnityEngine.Object.FindObjectsOfType(type:  0)[1];
            if(val_18 == null)
            {
                goto label_18;
            }
            
            if((UnityEngine.Object.FindObjectsOfType(type:  0)[1]) != null)
            {
                goto label_19;
            }
            
            goto label_21;
            label_18:
            if(0 == 0)
            {
                goto label_21;
            }
            
            label_19:
            string val_8 = 0 + "GameObject " + val_18.gameObject.name;
            UnityEngine.Debug.Log(message:  0);
            goto label_34;
            label_21:
            if((System.String.IsNullOrEmpty(value:  0)) != false)
            {
                    val_18.SetID();
            }
            
            Add(item:  val_18.gameObject);
            goto label_34;
            label_16:
            List.Enumerator<T> val_11 = GetEnumerator();
            label_38:
            if((0 & 1) == 0)
            {
                goto label_36;
            }
            
            val_13.InitializationCallback.SendMessage(methodName:  "OnSerialize", options:  1);
            goto label_38;
            label_36:
            val_13.Dispose();
            List.Enumerator<T> val_15 = GetEnumerator();
            val_20 = 1152921512794983760;
            label_45:
            if((0 & 1) == 0)
            {
                goto label_42;
            }
            
            Add(item:  this.PackGameObject(go:  0.InitializationCallback));
            goto label_45;
            label_42:
            val_18 = 0;
            val_23 = 1;
            0.Dispose();
            UnityEngine.UI.Extensions.SaveLoad.Save(saveGame:  null);
        }
        public void LoadGame()
        {
            this.LoadGame(saveGameName:  "QuickSave");
        }
        public void LoadGame(string saveGameName)
        {
            var val_5;
            var val_17;
            var val_25;
            var val_26;
            var val_27;
            var val_28;
            this.ClearScene();
            val_25 = UnityEngine.UI.Extensions.SaveLoad.Load(gameToLoad:  null);
            if(val_25 == null)
            {
                goto label_3;
            }
            
            System.Collections.Generic.List<UnityEngine.GameObject> val_2 = null;
            val_26 = val_2;
            val_2 = new System.Collections.Generic.List<UnityEngine.GameObject>();
            List.Enumerator<T> val_3 = val_1.sceneObjects.GetEnumerator();
            label_10:
            if((0 & 1) == 0)
            {
                goto label_5;
            }
            
            UnityEngine.GameObject val_7 = this.UnpackGameObject(sceneObject:  val_5.InitializationCallback);
            if(0 == val_7)
            {
                goto label_10;
            }
            
            Add(item:  val_7);
            goto label_10;
            label_3:
            val_26 = 0 + "saveGameName " + saveGameName;
            UnityEngine.Debug.Log(message:  0);
            return;
            label_5:
            val_5.Dispose();
            List.Enumerator<T> val_10 = GetEnumerator();
            val_27 = 1152921510374903568;
            val_28 = 0;
            goto label_39;
            label_41:
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_11 = val_5.InitializationCallback;
            UnityEngine.UI.Extensions.ObjectIdentifier val_12 = val_11.GetComponent<UnityEngine.UI.Extensions.ObjectIdentifier>();
            if((System.String.IsNullOrEmpty(value:  0)) == true)
            {
                goto label_39;
            }
            
            List.Enumerator<T> val_15 = GetEnumerator();
            do
            {
                label_35:
                if((0 & 1) == 0)
            {
                goto label_40;
            }
            
                System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_18 = val_17.InitializationCallback;
                UnityEngine.UI.Extensions.ObjectIdentifier val_19 = val_18.GetComponent<UnityEngine.UI.Extensions.ObjectIdentifier>();
            }
            while((System.String.op_Equality(a:  0, b:  val_19.id)) == false);
            
            val_11.transform.parent = val_18.transform;
            goto label_35;
            label_40:
            val_17.Dispose();
            val_28 = 1152921504722022400;
            if(0 != 277)
            {
                    val_28 = 0;
                if(null != null)
            {
                    val_28 = 0;
            }
            
            }
            
            label_39:
            if((0 & 1) != 0)
            {
                goto label_41;
            }
            
            val_5.Dispose();
            List.Enumerator<T> val_23 = GetEnumerator();
            val_25 = "OnDeserialize";
            label_49:
            if((0 & 1) == 0)
            {
                goto label_47;
            }
            
            0.InitializationCallback.SendMessage(methodName:  "OnDeserialize", options:  1);
            goto label_49;
            label_47:
            0.Dispose();
            if(374 == 374)
            {
                    return;
            }
            
            if(val_28 == 0)
            {
                    return;
            }
        
        }
        public void ClearScene()
        {
            var val_7;
            UnityEngine.Object val_8;
            var val_9;
            var val_10;
            System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            val_7 = 0;
            goto label_5;
            label_21:
            val_7 = 1;
            label_5:
            if(val_7 >= val_2.Length)
            {
                    return;
            }
            
            val_8 = UnityEngine.Object.FindObjectsOfType(type:  0)[1];
            if(val_8 != null)
            {
                    if(null == null)
            {
                goto label_10;
            }
            
            }
            
            val_9 = 0;
            val_8 = 0;
            val_10 = 1;
            goto label_11;
            label_10:
            val_10 = 0;
            val_9 = val_8;
            label_11:
            if((val_9.CompareTag(tag:  "DontDestroy")) == false)
            {
                goto label_12;
            }
            
            string val_5 = val_8.name;
            string val_6 = 0 + "Keeping GameObject in the scene: "("Keeping GameObject in the scene: ");
            UnityEngine.Debug.Log(message:  0);
            goto label_21;
            label_12:
            UnityEngine.Object.Destroy(obj:  0);
            goto label_21;
        }
        public UnityEngine.UI.Extensions.SceneObject PackGameObject(UnityEngine.GameObject go)
        {
            var val_21;
            var val_32;
            var val_33;
            var val_34;
            typeof(UnityEngine.UI.Extensions.SceneObject).__il2cppRuntimeField_10 = go.name;
            if((go.GetComponent<UnityEngine.UI.Extensions.ObjectIdentifier>()) != null)
            {
                    typeof(UnityEngine.UI.Extensions.SceneObject).__il2cppRuntimeField_18 = val_1.prefabName;
            }
            else
            {
                    typeof(UnityEngine.UI.Extensions.SceneObject).__il2cppRuntimeField_18 = 7254272;
            }
            
            typeof(UnityEngine.UI.Extensions.SceneObject).__il2cppRuntimeField_20 = val_1.id;
            if(0 == go.transform.parent)
            {
                goto label_16;
            }
            
            UnityEngine.UI.Extensions.ObjectIdentifier val_9 = go.transform.parent.GetComponent<UnityEngine.UI.Extensions.ObjectIdentifier>();
            if((UnityEngine.Object.op_Implicit(exists:  0)) == false)
            {
                goto label_16;
            }
            
            UnityEngine.UI.Extensions.ObjectIdentifier val_13 = go.transform.parent.GetComponent<UnityEngine.UI.Extensions.ObjectIdentifier>();
            typeof(UnityEngine.UI.Extensions.SceneObject).__il2cppRuntimeField_28 = val_13.id;
            goto label_22;
            label_16:
            typeof(UnityEngine.UI.Extensions.SceneObject).__il2cppRuntimeField_28 = 0;
            label_22:
            System.Collections.Generic.List<System.String> val_14 = new System.Collections.Generic.List<System.String>();
            Add(item:  "UnityEngine.MonoBehaviour");
            System.Collections.Generic.List<System.Object> val_15 = new System.Collections.Generic.List<System.Object>();
            val_32 = 0;
            goto label_26;
            label_36:
            val_32 = 1;
            label_26:
            if(val_32 >= val_16.Length)
            {
                goto label_28;
            }
            
            T val_32 = go.GetComponents<UnityEngine.Component>()[1];
            if((Contains(item:  val_32.GetType())) == false)
            {
                goto label_36;
            }
            
            Add(item:  val_32);
            goto label_36;
            label_28:
            List.Enumerator<T> val_19 = GetEnumerator();
            label_41:
            if((0 & 1) == 0)
            {
                goto label_38;
            }
            
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_22 = val_21.InitializationCallback;
            UnityEngine.UI.Extensions.SceneObject.__il2cppRuntimeField_interopData.Add(item:  val_22.PackComponent(component:  val_22));
            goto label_41;
            label_38:
            val_33 = 0;
            val_34 = 1;
            val_21.Dispose();
            UnityEngine.Vector3 val_25 = go.transform.position;
            typeof(UnityEngine.UI.Extensions.SceneObject).__il2cppRuntimeField_34 = val_25.x;
            typeof(UnityEngine.UI.Extensions.SceneObject).__il2cppRuntimeField_38 = val_25.y;
            typeof(UnityEngine.UI.Extensions.SceneObject).__il2cppRuntimeField_3C = val_25.z;
            UnityEngine.Vector3 val_27 = go.transform.localScale;
            typeof(UnityEngine.UI.Extensions.SceneObject).__il2cppRuntimeField_40 = val_27.x;
            typeof(UnityEngine.UI.Extensions.SceneObject).__il2cppRuntimeField_44 = val_27.y;
            typeof(UnityEngine.UI.Extensions.SceneObject).__il2cppRuntimeField_48 = val_27.z;
            UnityEngine.Quaternion val_29 = go.transform.rotation;
            typeof(UnityEngine.UI.Extensions.SceneObject).__il2cppRuntimeField_4C = val_29.x;
            typeof(UnityEngine.UI.Extensions.SceneObject).__il2cppRuntimeField_50 = val_29.y;
            typeof(UnityEngine.UI.Extensions.SceneObject).__il2cppRuntimeField_54 = val_29.z;
            typeof(UnityEngine.UI.Extensions.SceneObject).__il2cppRuntimeField_58 = val_29.w;
            typeof(UnityEngine.UI.Extensions.SceneObject).__il2cppRuntimeField_30 = go.activeSelf;
            return (UnityEngine.UI.Extensions.SceneObject)new UnityEngine.UI.Extensions.SceneObject();
        }
        public UnityEngine.UI.Extensions.ObjectComponent PackComponent(object component)
        {
            var val_16;
            typeof(UnityEngine.UI.Extensions.ObjectComponent).__il2cppRuntimeField_18 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            System.Type val_3 = component.GetType();
            typeof(UnityEngine.UI.Extensions.ObjectComponent).__il2cppRuntimeField_10 = val_3;
            val_16 = 0;
            goto label_6;
            label_31:
            val_16 = 1;
            label_6:
            if(val_16 >= null)
            {
                    return (UnityEngine.UI.Extensions.ObjectComponent)new System.Object();
            }
            
            System.Type val_4 = val_3 + 8;
            if((val_3 == null) || (val_3.IsSerializable == false))
            {
                goto label_31;
            }
            
            if((UnityEngine.UI.Extensions.TypeSystem.IsEnumerableType(type:  0)) != true)
            {
                    if((UnityEngine.UI.Extensions.TypeSystem.IsCollectionType(type:  0)) == false)
            {
                goto label_14;
            }
            
            }
            
            if((UnityEngine.UI.Extensions.TypeSystem.GetElementType(seqType:  0).IsSerializable) == false)
            {
                goto label_31;
            }
            
            label_14:
            System.Type val_11 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            var val_16 = 0;
            label_27:
            if(val_16 >= null)
            {
                goto label_20;
            }
            
            val_16 = val_16 + 1;
            if(0.GetType() != (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                goto label_27;
            }
            
            goto label_31;
            label_20:
            Add(key:  val_3, value:  val_3);
            goto label_31;
        }
        public UnityEngine.GameObject UnpackGameObject(UnityEngine.UI.Extensions.SceneObject sceneObject)
        {
            System.Collections.Generic.Dictionary<System.String, UnityEngine.GameObject> val_21;
            TzarGames.GameFramework.TzarBehaviour val_22;
            var val_23;
            string val_24;
            var val_25;
            val_21 = this.prefabDictionary;
            if((val_21.ContainsKey(key:  sceneObject.prefabName)) == false)
            {
                goto label_3;
            }
            
            UnityEngine.GameObject val_3 = this.prefabDictionary.Item[sceneObject.prefabName];
            val_22 = UnityEngine.Object.Instantiate<TzarGames.GameFramework.TzarBehaviour>(original:  0, position:  new UnityEngine.Vector3() {x = sceneObject.position, y = V9.16B, z = V10.16B}, rotation:  new UnityEngine.Quaternion() {x = sceneObject.rotation, y = V13.16B, z = V12.16B, w = V11.16B});
            if(val_22 == null)
            {
                goto label_8;
            }
            
            val_22.name = sceneObject.name;
            val_23 = 0;
            goto label_9;
            label_3:
            string val_5 = 0 + "Can\'t find key " + sceneObject.prefabName;
            UnityEngine.Debug.Log(message:  0);
            val_22 = 0;
            return (UnityEngine.GameObject)val_22;
            label_8:
            val_22.name = sceneObject.name;
            val_23 = 1;
            label_9:
            val_22.transform.localScale = new UnityEngine.Vector3() {x = sceneObject.localScale, y = V9.16B, z = V10.16B};
            if((val_23 & 1) != 0)
            {
                    val_22.SetActive(value:  (sceneObject.active == true) ? 1 : 0);
            }
            else
            {
                    val_22.SetActive(value:  (sceneObject.active == true) ? 1 : 0);
            }
            
            UnityEngine.UI.Extensions.ObjectIdentifier val_9 = val_22.GetComponent<UnityEngine.UI.Extensions.ObjectIdentifier>();
            if((UnityEngine.Object.op_Implicit(exists:  0)) != true)
            {
                    UnityEngine.UI.Extensions.ObjectIdentifier val_12 = val_22.AddComponent<UnityEngine.UI.Extensions.ObjectIdentifier>();
            }
            
            UnityEngine.UI.Extensions.ObjectIdentifier val_13 = val_22.GetComponent<UnityEngine.UI.Extensions.ObjectIdentifier>();
            val_21 = val_13;
            if(val_21 != null)
            {
                    val_13.id = sceneObject.id;
                val_24 = sceneObject.idParent;
            }
            else
            {
                    mem[32] = sceneObject.id;
                val_24 = sceneObject.idParent;
            }
            
            val_13.idParent = val_24;
            val_13.UnpackComponents(go: ref  val_22, sceneObject:  sceneObject);
            val_25 = 0;
            goto label_26;
            label_42:
            val_25 = 1;
            label_26:
            if(val_25 >= val_15.Length)
            {
                    return (UnityEngine.GameObject)val_22;
            }
            
            T val_21 = val_22.GetComponentsInChildren<UnityEngine.UI.Extensions.ObjectIdentifier>()[1];
            UnityEngine.Transform val_17 = val_22.transform;
            if((0 == val_21.transform) || ((System.String.IsNullOrEmpty(value:  0)) == false))
            {
                goto label_42;
            }
            
            UnityEngine.GameObject val_20 = val_21.gameObject;
            UnityEngine.Object.Destroy(obj:  0);
            goto label_42;
        }
        public void UnpackComponents(ref UnityEngine.GameObject go, UnityEngine.UI.Extensions.SceneObject sceneObject)
        {
            var val_3;
            var val_15;
            System.Type val_18;
            var val_19;
            var val_20;
            List.Enumerator<T> val_1 = sceneObject.objectComponents.GetEnumerator();
            label_27:
            if((0 & 1) == 0)
            {
                goto label_30;
            }
            
            UnityEngine.Component val_5 = go.GetComponent(type:  X24);
            if((UnityEngine.Object.op_Implicit(exists:  0)) != true)
            {
                    val_18 = System.Type.GetType(typeName:  0);
                if(val_18 == null)
            {
                    val_18 = System.Type.GetType(typeName:  0);
            }
            
                UnityEngine.Component val_10 = go.AddComponent(componentType:  val_18);
            }
            
            UnityEngine.Component val_11 = go.GetComponent(type:  val_18);
            System.Type val_12 = val_11.GetType();
            Dictionary.Enumerator<TKey, TValue> val_13 = val_3.InitializationCallback.GetEnumerator();
            label_22:
            if((0 & 1) == 0)
            {
                goto label_19;
            }
            
            UnityEngine.Playables.PlayableHandle val_16 = val_15.GetHandle();
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_17 = val_16.m_Handle.InitializationCallback;
            if(val_12 == null)
            {
                goto label_22;
            }
            
            val_12.SetValue(obj:  val_11, value:  val_16.m_Handle);
            goto label_22;
            label_19:
            val_20 = 196;
            val_19 = 0;
            val_15.Dispose();
            if((196 == 196) || (val_19 == 0))
            {
                goto label_27;
            }
            
            goto label_27;
            label_30:
            val_3.Dispose();
            if(0 == 227)
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
