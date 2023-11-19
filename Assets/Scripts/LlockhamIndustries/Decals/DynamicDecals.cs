using UnityEngine;

namespace LlockhamIndustries.Decals
{
    [UnityEngine.ExecuteInEditMode]
    public class DynamicDecals : MonoBehaviour
    {
        // Fields
        private static LlockhamIndustries.Decals.DynamicDecals system;
        private LlockhamIndustries.Decals.DynamicDecalSettings settings;
        public LlockhamIndustries.Decals.SystemPath renderingPath;
        private bool shaderReplacement;
        internal UnityEngine.RenderTextureFormat depthFormat;
        internal UnityEngine.RenderTextureFormat normalFormat;
        internal UnityEngine.RenderTextureFormat maskFormat;
        private System.Collections.Generic.List<LlockhamIndustries.Decals.ProjectionData> Projections;
        private bool renderersMarked;
        private UnityEngine.Mesh cube;
        private UnityEngine.Shader depthShader;
        private UnityEngine.Shader normalShader;
        private UnityEngine.Shader maskShader;
        private UnityEngine.Shader depthNormalShader;
        private UnityEngine.Shader normalMaskShader;
        private UnityEngine.Shader depthNormalMaskShader;
        private UnityEngine.Shader depthNormalMaskShader_Packed;
        private UnityEngine.Material stereoBlitLeft;
        private UnityEngine.Material stereoBlitRight;
        private UnityEngine.Material stereoDepthBlitLeft;
        private UnityEngine.Material stereoDepthBlitRight;
        internal System.Collections.Generic.Dictionary<UnityEngine.Camera, LlockhamIndustries.Decals.CameraData> cameraData;
        private UnityEngine.Camera customCamera;
        private System.Collections.Generic.Dictionary<int, LlockhamIndustries.Decals.ProjectionPool> Pools;
        
        // Properties
        public static bool Initialized { get; }
        public static LlockhamIndustries.Decals.DynamicDecals System { get; }
        public LlockhamIndustries.Decals.DynamicDecalSettings Settings { get; }
        private bool FireInCulling { get; }
        public LlockhamIndustries.Decals.SystemPath SystemPath { get; }
        public bool ShaderReplacement { get; set; }
        public bool Instanced { get; }
        public int ProjectionCount { get; }
        public int RendererCount { get; }
        public UnityEngine.Mesh Cube { get; }
        public UnityEngine.Shader DepthShader { get; }
        public UnityEngine.Shader NormalShader { get; }
        public UnityEngine.Shader MaskShader { get; }
        public UnityEngine.Shader NormalMaskShader { get; }
        public UnityEngine.Shader DepthNormalMaskShader { get; }
        public UnityEngine.Shader DepthNormalMaskShader_Packed { get; }
        public UnityEngine.Material StereoBlitLeft { get; }
        public UnityEngine.Material StereoBlitRight { get; }
        public UnityEngine.Material StereoDepthBlitLeft { get; }
        public UnityEngine.Material StereoDepthBlitRight { get; }
        public UnityEngine.Camera CustomCamera { get; }
        public LlockhamIndustries.Decals.ProjectionPool DefaultPool { get; }
        public static string DebugLog { get; }
        
        // Methods
        public DynamicDecals()
        {
            this.shaderReplacement = true;
            this.cameraData = new System.Collections.Generic.Dictionary<UnityEngine.Camera, LlockhamIndustries.Decals.CameraData>();
        }
        public static bool get_Initialized()
        {
            return UnityEngine.Object.op_Inequality(x:  0, y:  LlockhamIndustries.Decals.DynamicDecals.system);
        }
        public static LlockhamIndustries.Decals.DynamicDecals get_System()
        {
            LlockhamIndustries.Decals.DynamicDecals val_4 = LlockhamIndustries.Decals.DynamicDecals.system;
            if(0 != val_4)
            {
                    return (LlockhamIndustries.Decals.DynamicDecals)LlockhamIndustries.Decals.DynamicDecals.system;
            }
            
            UnityEngine.GameObject val_2 = null;
            val_4 = val_2;
            val_2 = new UnityEngine.GameObject(name:  "Dynamic Decals");
            if(null != 0)
            {
                    hideFlags = 23;
            }
            else
            {
                    0.hideFlags = 23;
            }
            
            LlockhamIndustries.Decals.DynamicDecals val_3 = AddComponent<LlockhamIndustries.Decals.DynamicDecals>();
            return (LlockhamIndustries.Decals.DynamicDecals)LlockhamIndustries.Decals.DynamicDecals.system;
        }
        private void Start()
        {
            if(UnityEngine.Application.isPlaying == false)
            {
                    return;
            }
            
            UnityEngine.GameObject val_2 = this.gameObject;
            UnityEngine.Object.DontDestroyOnLoad(target:  0);
        }
        private void OnEnable()
        {
            if(0 != LlockhamIndustries.Decals.DynamicDecals.system)
            {
                goto label_3;
            }
            
            LlockhamIndustries.Decals.DynamicDecals.system = this;
            goto label_7;
            label_3:
            if(0 == this)
            {
                goto label_7;
            }
            
            if(UnityEngine.Application.isPlaying == false)
            {
                goto label_8;
            }
            
            UnityEngine.Object.Destroy(obj:  0);
            return;
            label_7:
            this.Initialize();
            return;
            label_8:
            UnityEngine.Object.DestroyImmediate(obj:  0, allowDestroyingAssets:  this.gameObject);
        }
        private void OnDisable()
        {
            this.Terminate();
        }
        public LlockhamIndustries.Decals.DynamicDecalSettings get_Settings()
        {
            LlockhamIndustries.Decals.DynamicDecalSettings val_7;
            LlockhamIndustries.Decals.DynamicDecalSettings val_8;
            if(0 == this.settings)
            {
                    val_7 = UnityEngine.Resources.Load<UnityEngine.Mesh>(path:  0);
                this.settings = val_7;
            }
            else
            {
                    val_7 = this.settings;
            }
            
            if(0 == val_7)
            {
                    this.settings = UnityEngine.ScriptableObject.CreateInstance<LlockhamIndustries.Decals.DynamicDecalSettings>();
                return val_8;
            }
            
            val_8 = this.settings;
            return val_8;
        }
        public static void ApplySettings()
        {
            LlockhamIndustries.Decals.DynamicDecals.system.settings = UnityEngine.Resources.Load<UnityEngine.Mesh>(path:  0);
        }
        private bool get_FireInCulling()
        {
            var val_5;
            var val_6;
            val_5 = this;
            if(UnityEngine.XR.XRSettings.enabled != false)
            {
                    val_6 = 0;
                return (bool)(val_3.replacement != 1) ? 1 : 0;
            }
            
            val_5 = this.Settings;
            return (bool)(val_3.replacement != 1) ? 1 : 0;
        }
        public LlockhamIndustries.Decals.SystemPath get_SystemPath()
        {
            return (LlockhamIndustries.Decals.SystemPath)this.renderingPath;
        }
        public bool get_ShaderReplacement()
        {
            var val_3;
            if(this.Projections.Count >= 1)
            {
                    var val_2 = (this.shaderReplacement == true) ? 1 : 0;
                return (bool)val_3;
            }
            
            val_3 = 0;
            return (bool)val_3;
        }
        public void set_ShaderReplacement(bool value)
        {
            this.shaderReplacement = value;
        }
        public bool get_Instanced()
        {
            return UnityEngine.SystemInfo.supportsInstancing;
        }
        private void UpdateSystemPath()
        {
            UnityEngine.Object val_13;
            if(0 == UnityEngine.Camera.main)
            {
                goto label_3;
            }
            
            UnityEngine.Camera val_3 = UnityEngine.Camera.main;
            goto label_4;
            label_3:
            val_13 = 0;
            if(0 == UnityEngine.Camera.current)
            {
                goto label_7;
            }
            
            label_4:
            val_13 = UnityEngine.Camera.current;
            label_7:
            if(0 == val_13)
            {
                    return;
            }
            
            if(val_13.actualRenderingPath != 1)
            {
                    if(val_13.actualRenderingPath != 3)
            {
                goto label_14;
            }
            
            }
            
            LlockhamIndustries.Decals.SystemPath val_11 = (val_13.actualRenderingPath == 3) ? 1 : 0;
            if(this.renderingPath == val_11)
            {
                    return;
            }
            
            this.renderingPath = val_11;
            this.UpdateRenderers();
            return;
            label_14:
            UnityEngine.Debug.LogWarning(message:  0);
        }
        public void RestoreDepthTextureModes()
        {
            goto label_1;
            label_8:
            0 = 1;
            label_1:
            if(0 >= this.cameraData.Count)
            {
                    return;
            }
            
            System.Collections.Generic.KeyValuePair<System.Object, System.Object> val_2 = System.Linq.Enumerable.ElementAt<System.Collections.Generic.KeyValuePair<System.Object, System.Object>>(source:  0, index:  this.cameraData);
            System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> val_3 = val_2.Value.InitializationCallback;
            if(0 == val_3)
            {
                goto label_8;
            }
            
            System.Collections.Generic.KeyValuePair<System.Object, System.Object> val_5 = System.Linq.Enumerable.ElementAt<System.Collections.Generic.KeyValuePair<System.Object, System.Object>>(source:  0, index:  this.cameraData);
            val_5.Value.RestoreDepthTextureMode(Camera:  val_3);
            goto label_8;
        }
        private LlockhamIndustries.Decals.ProjectionData GetProjectionData(LlockhamIndustries.Decals.Projection Projection)
        {
            System.Collections.Generic.List<LlockhamIndustries.Decals.ProjectionData> val_5;
            var val_6;
            var val_7;
            val_5 = Projection;
            val_6 = 0;
            goto label_1;
            label_8:
            val_6 = 1;
            label_1:
            if(val_6 >= this.Projections.Count)
            {
                goto label_3;
            }
            
            LlockhamIndustries.Decals.ProjectionData val_2 = this.Projections.Item[1];
            if(0 != val_2.projection)
            {
                goto label_8;
            }
            
            val_5 = this.Projections;
            LlockhamIndustries.Decals.ProjectionData val_4 = val_5.Item[1];
            return (LlockhamIndustries.Decals.ProjectionData)val_7;
            label_3:
            val_7 = 0;
            return (LlockhamIndustries.Decals.ProjectionData)val_7;
        }
        private void UpdateProjectionData()
        {
            goto label_1;
            label_7:
            X21.Update();
            0 = 1;
            label_1:
            if(0 >= this.Projections.Count)
            {
                    return;
            }
            
            LlockhamIndustries.Decals.ProjectionData val_2 = this.Projections.Item[1];
            if(val_2.projection != null)
            {
                goto label_7;
            }
            
            goto label_7;
        }
        public bool Register(LlockhamIndustries.Decals.ProjectionRenderer Instance)
        {
            LlockhamIndustries.Decals.Projection val_7;
            var val_8;
            if(0 == Instance)
            {
                    return false;
            }
            
            val_7 = Instance.Projection;
            LlockhamIndustries.Decals.ProjectionData val_3 = this.GetProjectionData(Projection:  val_7);
            if(val_3 != null)
            {
                    val_3.Add(Instance:  Instance);
                return this.isActiveAndEnabled;
            }
            
            LlockhamIndustries.Decals.ProjectionData val_4 = new LlockhamIndustries.Decals.ProjectionData(Projection:  val_7);
            Add(Instance:  Instance);
            val_8 = 0;
            goto label_8;
            label_15:
            val_8 = 1;
            label_8:
            if(val_8 >= this.Projections.Count)
            {
                goto label_10;
            }
            
            LlockhamIndustries.Decals.ProjectionData val_6 = this.Projections.Item[1];
            if(val_2.priority >= val_6.projection.priority)
            {
                goto label_15;
            }
            
            this.Projections.Insert(index:  1, item:  val_4);
            return false;
            label_10:
            val_7 = this.Projections;
            val_7.Add(item:  val_4);
            return this.isActiveAndEnabled;
        }
        public void Deregister(LlockhamIndustries.Decals.ProjectionRenderer Instance)
        {
            var val_9;
            System.Collections.Generic.List<LlockhamIndustries.Decals.ProjectionData> val_10;
            if(0 == Instance)
            {
                    return;
            }
            
            LlockhamIndustries.Decals.Projection val_2 = Instance.Projection;
            val_9 = 0;
            goto label_5;
            label_12:
            val_9 = 1;
            label_5:
            val_10 = this.Projections;
            if(val_9 >= val_10.Count)
            {
                    return;
            }
            
            LlockhamIndustries.Decals.ProjectionData val_4 = this.Projections.Item[1];
            val_10 = val_4.projection;
            if(0 != val_10)
            {
                goto label_12;
            }
            
            this.Projections.Item[1].Remove(Instance:  Instance);
            LlockhamIndustries.Decals.ProjectionData val_7 = this.Projections.Item[1];
            if(val_7.instances.Count != 0)
            {
                    return;
            }
            
            this.Projections.RemoveAt(index:  1);
        }
        public void Reorder(LlockhamIndustries.Decals.Projection Projection)
        {
            var val_5;
            LlockhamIndustries.Decals.ProjectionData val_1 = this.GetProjectionData(Projection:  Projection);
            if(val_1 == null)
            {
                    return;
            }
            
            bool val_2 = this.Projections.Remove(item:  val_1);
            val_5 = 0;
            goto label_3;
            label_10:
            val_5 = 1;
            label_3:
            if(val_5 >= this.Projections.Count)
            {
                goto label_5;
            }
            
            LlockhamIndustries.Decals.ProjectionData val_4 = this.Projections.Item[1];
            if(Projection.priority >= val_4.projection.priority)
            {
                goto label_10;
            }
            
            this.Projections.Insert(index:  1, item:  val_1);
            return;
            label_5:
            this.Projections.Add(item:  val_1);
            this.OrderRenderers();
        }
        public void OrderRenderers()
        {
            var val_4;
            var val_5;
            val_4 = this;
            if(this.renderersMarked == false)
            {
                    return;
            }
            
            if(this.Projections == null)
            {
                    return;
            }
            
            List.Enumerator<T> val_1 = this.Projections.GetEnumerator();
            label_5:
            if((0 & 1) == 0)
            {
                goto label_3;
            }
            
            0.InitializationCallback.AssertOrder(Order: ref  1);
            goto label_5;
            label_3:
            val_4 = 0;
            val_5 = 1;
            0.Dispose();
            if((val_5 & 1) != 0)
            {
                    return;
            }
            
            if(val_4 == 0)
            {
                    return;
            }
        
        }
        public void MarkRenderers()
        {
            this.renderersMarked = true;
        }
        public void UpdateRenderers()
        {
            System.Collections.Generic.List<LlockhamIndustries.Decals.ProjectionData> val_3;
            var val_4;
            val_3 = this.Projections;
            if(val_3 == null)
            {
                    return;
            }
            
            val_4 = 0;
            goto label_2;
            label_7:
            val_3.UpdateRenderers();
            val_3 = this.Projections;
            val_4 = 1;
            label_2:
            if(val_4 >= val_3.Count)
            {
                    return;
            }
            
            if(this.Projections.Item[1] != null)
            {
                goto label_7;
            }
            
            goto label_7;
        }
        public void UpdateRenderers(LlockhamIndustries.Decals.Projection Projection)
        {
            var val_5;
            System.Collections.Generic.List<LlockhamIndustries.Decals.ProjectionData> val_6 = this.Projections;
            if(val_6 == null)
            {
                    return;
            }
            
            val_5 = 0;
            goto label_2;
            label_9:
            val_6 = this.Projections;
            val_5 = 1;
            label_2:
            if(val_5 >= val_6.Count)
            {
                    return;
            }
            
            LlockhamIndustries.Decals.ProjectionData val_2 = this.Projections.Item[1];
            if(0 != val_2.projection)
            {
                goto label_9;
            }
            
            this.Projections.Item[1].UpdateRenderers();
        }
        public int get_ProjectionCount()
        {
            if(this.Projections != null)
            {
                    return this.Projections.Count;
            }
            
            return this.Projections.Count;
        }
        public int get_RendererCount()
        {
            var val_4;
            var val_5;
            val_4 = 0;
            val_5 = 0;
            goto label_1;
            label_7:
            val_5 = X22.Count + val_5;
            val_4 = 1;
            label_1:
            if(val_4 >= this.Projections.Count)
            {
                    return (int)val_5;
            }
            
            LlockhamIndustries.Decals.ProjectionData val_3 = this.Projections.Item[1];
            if(val_3.instances != null)
            {
                goto label_7;
            }
            
            goto label_7;
        }
        public UnityEngine.Mesh get_Cube()
        {
            if(0 != this.cube)
            {
                    return (UnityEngine.Mesh)this.cube;
            }
            
            UnityEngine.Mesh val_2 = UnityEngine.Resources.Load<UnityEngine.Mesh>(path:  0);
            this.cube = val_2;
            val_2.name = "Projection";
            return (UnityEngine.Mesh)this.cube;
        }
        public UnityEngine.Shader get_DepthShader()
        {
            UnityEngine.Shader val_4;
            if(0 == this.depthShader)
            {
                    this.depthShader = UnityEngine.Shader.Find(name:  0);
                return val_4;
            }
            
            val_4 = this.depthShader;
            return val_4;
        }
        public UnityEngine.Shader get_NormalShader()
        {
            UnityEngine.Shader val_4;
            if(0 == this.normalShader)
            {
                    this.normalShader = UnityEngine.Shader.Find(name:  0);
                return val_4;
            }
            
            val_4 = this.normalShader;
            return val_4;
        }
        public UnityEngine.Shader get_MaskShader()
        {
            UnityEngine.Shader val_4;
            if(0 == this.maskShader)
            {
                    this.maskShader = UnityEngine.Shader.Find(name:  0);
                return val_4;
            }
            
            val_4 = this.maskShader;
            return val_4;
        }
        public UnityEngine.Shader get_NormalMaskShader()
        {
            UnityEngine.Shader val_4;
            if(0 == this.normalMaskShader)
            {
                    this.normalMaskShader = UnityEngine.Shader.Find(name:  0);
                return val_4;
            }
            
            val_4 = this.normalMaskShader;
            return val_4;
        }
        public UnityEngine.Shader get_DepthNormalMaskShader()
        {
            UnityEngine.Shader val_4;
            if(0 == this.depthNormalMaskShader)
            {
                    this.depthNormalMaskShader = UnityEngine.Shader.Find(name:  0);
                return val_4;
            }
            
            val_4 = this.depthNormalMaskShader;
            return val_4;
        }
        public UnityEngine.Shader get_DepthNormalMaskShader_Packed()
        {
            UnityEngine.Shader val_4;
            if(0 == this.depthNormalMaskShader_Packed)
            {
                    this.depthNormalMaskShader_Packed = UnityEngine.Shader.Find(name:  0);
                return val_4;
            }
            
            val_4 = this.depthNormalMaskShader_Packed;
            return val_4;
        }
        public UnityEngine.Material get_StereoBlitLeft()
        {
            UnityEngine.Material val_5;
            if(0 == this.stereoBlitLeft)
            {
                    UnityEngine.Material val_4 = null;
                val_5 = val_4;
                val_4 = new UnityEngine.Material(shader:  UnityEngine.Shader.Find(name:  0));
                this.stereoBlitLeft = val_5;
                return val_5;
            }
            
            val_5 = this.stereoBlitLeft;
            return val_5;
        }
        public UnityEngine.Material get_StereoBlitRight()
        {
            UnityEngine.Material val_5;
            if(0 == this.stereoBlitRight)
            {
                    UnityEngine.Material val_4 = null;
                val_5 = val_4;
                val_4 = new UnityEngine.Material(shader:  UnityEngine.Shader.Find(name:  0));
                this.stereoBlitRight = val_5;
                return val_5;
            }
            
            val_5 = this.stereoBlitRight;
            return val_5;
        }
        public UnityEngine.Material get_StereoDepthBlitLeft()
        {
            UnityEngine.Material val_5;
            if(0 == this.stereoDepthBlitLeft)
            {
                    UnityEngine.Material val_4 = null;
                val_5 = val_4;
                val_4 = new UnityEngine.Material(shader:  UnityEngine.Shader.Find(name:  0));
                this.stereoDepthBlitLeft = val_5;
                return val_5;
            }
            
            val_5 = this.stereoDepthBlitLeft;
            return val_5;
        }
        public UnityEngine.Material get_StereoDepthBlitRight()
        {
            UnityEngine.Material val_5;
            if(0 == this.stereoDepthBlitRight)
            {
                    UnityEngine.Material val_4 = null;
                val_5 = val_4;
                val_4 = new UnityEngine.Material(shader:  UnityEngine.Shader.Find(name:  0));
                this.stereoDepthBlitRight = val_5;
                return val_5;
            }
            
            val_5 = this.stereoDepthBlitRight;
            return val_5;
        }
        private void SetupMaskedMaterials()
        {
            var val_4;
            var val_5;
            LlockhamIndustries.Decals.DynamicDecalSettings val_1 = this.Settings;
            List.Enumerator<T> val_2 = val_1.materials.GetEnumerator();
            label_5:
            if((0 & 1) == 0)
            {
                goto label_3;
            }
            
            0.InitializationCallback.renderQueue = 183;
            goto label_5;
            label_3:
            val_4 = 0;
            val_5 = 1;
            0.Dispose();
            if((val_5 & 1) != 0)
            {
                    return;
            }
            
            if(val_4 == 0)
            {
                    return;
            }
        
        }
        internal LlockhamIndustries.Decals.CameraData GetData(UnityEngine.Camera Camera)
        {
            System.Collections.Generic.Dictionary<UnityEngine.Camera, LlockhamIndustries.Decals.CameraData> val_9;
            var val_10;
            val_9 = this.cameraData;
            if((val_9.TryGetValue(key:  Camera, value: out  0)) != true)
            {
                    object val_4 = null;
                val_9 = val_4;
                val_4 = new System.Object();
                this.cameraData.set_Item(key:  Camera, value:  val_9);
            }
            
            val_10 = val_9;
            if(null == 0)
            {
                    return val_9;
            }
            
            if(null != 0)
            {
                goto label_5;
            }
            
            val_10 = val_9;
            if(0 == (Camera.GetComponent<LlockhamIndustries.Decals.ProjectionBlocker>()))
            {
                    typeof(LlockhamIndustries.Decals.CameraData).__il2cppRuntimeField_58 = 1;
                return val_9;
            }
            
            if(null == 0)
            {
                goto label_12;
            }
            
            label_5:
            if(typeof(LlockhamIndustries.Decals.CameraData).__il2cppRuntimeField_58 == 0)
            {
                    return val_9;
            }
            
            if(0 == (Camera.GetComponent<LlockhamIndustries.Decals.ProjectionBlocker>()))
            {
                    return val_9;
            }
            
            RestoreDepthTextureMode(Camera:  Camera);
            ReleaseTextures();
            typeof(LlockhamIndustries.Decals.CameraData).__il2cppRuntimeField_58 = 0;
            return val_9;
            label_12:
        }
        public UnityEngine.Camera get_CustomCamera()
        {
            var val_8;
            if(0 != this.customCamera)
            {
                    return (UnityEngine.Camera)this.customCamera;
            }
            
            if(null != 0)
            {
                    this.customCamera = AddComponent<UnityEngine.Camera>();
                LlockhamIndustries.Decals.ProjectionBlocker val_4 = AddComponent<LlockhamIndustries.Decals.ProjectionBlocker>();
                hideFlags = 23;
                val_8 = new UnityEngine.GameObject(name:  "Custom Camera");
            }
            else
            {
                    this.customCamera = AddComponent<UnityEngine.Camera>();
                LlockhamIndustries.Decals.ProjectionBlocker val_6 = AddComponent<LlockhamIndustries.Decals.ProjectionBlocker>();
                0.hideFlags = 23;
                val_8 = 0;
            }
            
            SetActive(value:  false);
            if(UnityEngine.Application.isPlaying == false)
            {
                    return (UnityEngine.Camera)this.customCamera;
            }
            
            UnityEngine.Object.DontDestroyOnLoad(target:  0);
            return (UnityEngine.Camera)this.customCamera;
        }
        internal LlockhamIndustries.Decals.ProjectionPool PoolFromInstance(LlockhamIndustries.Decals.PoolInstance Instance)
        {
            LlockhamIndustries.Decals.PoolInstance val_6;
            System.Collections.Generic.Dictionary<System.Int32, LlockhamIndustries.Decals.ProjectionPool> val_7;
            val_6 = Instance;
            val_7 = this.Pools;
            if(val_7 == null)
            {
                    System.Collections.Generic.Dictionary<System.Int32, LlockhamIndustries.Decals.ProjectionPool> val_1 = null;
                val_7 = val_1;
                val_1 = new System.Collections.Generic.Dictionary<System.Int32, LlockhamIndustries.Decals.ProjectionPool>();
                this.Pools = val_7;
            }
            
            if((TryGetValue(key:  Instance.id, value: out  0)) == true)
            {
                    return val_7;
            }
            
            object val_5 = null;
            val_7 = val_5;
            val_5 = new System.Object();
            typeof(LlockhamIndustries.Decals.ProjectionPool).__il2cppRuntimeField_10 = val_6;
            if(val_6 == null)
            {
                    val_7 = val_7;
            }
            
            val_6 = Instance.id;
            this.Pools.Add(key:  val_6, value:  val_7);
            return val_7;
        }
        public LlockhamIndustries.Decals.ProjectionPool get_DefaultPool()
        {
            LlockhamIndustries.Decals.DynamicDecalSettings val_1 = this.Settings;
            return this.PoolFromInstance(Instance:  val_1.pools[0]);
        }
        public LlockhamIndustries.Decals.ProjectionPool GetPool(string Title)
        {
            var val_4;
            LlockhamIndustries.Decals.PoolInstance[] val_5;
            LlockhamIndustries.Decals.PoolInstance val_6;
            val_4 = 0;
            goto label_1;
            label_11:
            val_4 = 1;
            label_1:
            LlockhamIndustries.Decals.DynamicDecalSettings val_1 = this.Settings;
            val_5 = val_1.pools;
            if(val_4 >= val_1.pools.Length)
            {
                goto label_4;
            }
            
            LlockhamIndustries.Decals.PoolInstance val_4 = this.settings.pools[1];
            val_5 = this.settings.pools[0x1][0].title;
            if((System.String.op_Equality(a:  0, b:  val_5)) == false)
            {
                goto label_11;
            }
            
            val_6 = this.settings.pools[1];
            return this.PoolFromInstance(Instance:  val_6 = this.settings.pools[0]);
            label_4:
            string val_3 = 0 + "No valid pool with the title : "("No valid pool with the title : ") + Title;
            UnityEngine.Debug.LogWarning(message:  0);
            return this.PoolFromInstance(Instance:  val_6);
        }
        public LlockhamIndustries.Decals.ProjectionPool GetPool(int ID)
        {
            goto label_1;
            label_9:
            0 = 1;
            label_1:
            LlockhamIndustries.Decals.DynamicDecalSettings val_1 = this.Settings;
            if(0 >= val_1.pools.Length)
            {
                goto label_4;
            }
            
            LlockhamIndustries.Decals.PoolInstance val_4 = this.settings.pools[1];
            if(this.settings.pools[0x1][0].id != ID)
            {
                goto label_9;
            }
            
            return this.PoolFromInstance(Instance:  this.settings.pools[1]);
            label_4:
            string val_2 = 0 + "No valid pool with the ID : "("No valid pool with the ID : ") + ID;
            UnityEngine.Debug.LogWarning(message:  0);
            return (LlockhamIndustries.Decals.ProjectionPool)this.PoolFromInstance(Instance:  this.settings.pools[0]);
        }
        private void Initialize()
        {
            var val_14;
            CameraCallback val_15;
            CameraCallback val_16;
            System.Collections.Generic.List<LlockhamIndustries.Decals.ProjectionData> val_17;
            var val_18;
            this.depthFormat = 1;
            UnityEngine.RenderTextureFormat val_2 = ((UnityEngine.SystemInfo.SupportsRenderTextureFormat(format:  0)) != true) ? 8 : 0;
            if(this != null)
            {
                    this.normalFormat = val_2;
                bool val_3 = UnityEngine.SystemInfo.SupportsRenderTextureFormat(format:  0);
            }
            else
            {
                    this.normalFormat = val_2;
                bool val_4 = UnityEngine.SystemInfo.SupportsRenderTextureFormat(format:  0);
            }
            
            this.maskFormat = 0;
            val_14 = 1152921504717549568;
            Camera.CameraCallback val_5 = new Camera.CameraCallback(object:  this, method:  System.Void LlockhamIndustries.Decals.DynamicDecals::SuperLateUpdate(UnityEngine.Camera Camera));
            System.Delegate val_6 = System.Delegate.Combine(a:  0, b:  UnityEngine.Camera.onPreCull);
            val_15 = 0;
            if(val_6 != null)
            {
                    val_15 = val_6;
                if(null != null)
            {
                    val_15 = 0;
            }
            
            }
            
            UnityEngine.Camera.onPreCull = val_15;
            Camera.CameraCallback val_8 = new Camera.CameraCallback(object:  this, method:  System.Void LlockhamIndustries.Decals.DynamicDecals::PreRender(UnityEngine.Camera Camera));
            System.Delegate val_9 = System.Delegate.Combine(a:  0, b:  UnityEngine.Camera.onPreRender);
            val_16 = 0;
            if(val_9 != null)
            {
                    val_16 = val_9;
                if(null != null)
            {
                    val_16 = 0;
            }
            
            }
            
            UnityEngine.Camera.onPreRender = val_16;
            val_17 = this.Projections;
            if(val_17 == null)
            {
                goto label_7;
            }
            
            val_14 = 1152921511756687440;
            val_18 = 0;
            goto label_8;
            label_13:
            val_17.EnableRenderers();
            val_17 = this.Projections;
            val_18 = 1;
            label_8:
            if(val_18 >= val_17.Count)
            {
                goto label_10;
            }
            
            if(this.Projections.Item[1] != null)
            {
                goto label_13;
            }
            
            goto label_13;
            label_7:
            this.Projections = new System.Collections.Generic.List<LlockhamIndustries.Decals.ProjectionData>();
            label_10:
            this.SetupMaskedMaterials();
        }
        private void Terminate()
        {
            CameraCallback val_12;
            CameraCallback val_13;
            System.Collections.Generic.List<LlockhamIndustries.Decals.ProjectionData> val_14;
            var val_15;
            Camera.CameraCallback val_1 = new Camera.CameraCallback(object:  this, method:  System.Void LlockhamIndustries.Decals.DynamicDecals::SuperLateUpdate(UnityEngine.Camera Camera));
            System.Delegate val_2 = System.Delegate.Remove(source:  0, value:  UnityEngine.Camera.onPreCull);
            val_12 = 0;
            if(val_2 != null)
            {
                    val_12 = val_2;
                if(null != null)
            {
                    val_12 = 0;
            }
            
            }
            
            UnityEngine.Camera.onPreCull = val_12;
            Camera.CameraCallback val_4 = new Camera.CameraCallback(object:  this, method:  System.Void LlockhamIndustries.Decals.DynamicDecals::PreRender(UnityEngine.Camera Camera));
            System.Delegate val_5 = System.Delegate.Remove(source:  0, value:  UnityEngine.Camera.onPreRender);
            val_13 = 0;
            if(val_5 != null)
            {
                    val_13 = val_5;
                if(null != null)
            {
                    val_13 = 0;
            }
            
            }
            
            UnityEngine.Camera.onPreRender = val_13;
            Dictionary.Enumerator<TKey, TValue> val_7 = this.cameraData.GetEnumerator();
            goto label_6;
            label_9:
            mem2[0] = 0;
            label_6:
            if((0 & 1) == 0)
            {
                goto label_20;
            }
            
            UnityEngine.Playables.PlayableHandle val_8 = 0.GetHandle();
            val_8.m_Handle.RestoreDepthTextureMode(Camera:  val_8.m_Handle.InitializationCallback);
            val_8.m_Handle.ReleaseTextures();
            goto label_9;
            label_20:
            0.Dispose();
            this.cameraData.Clear();
            val_14 = this.Projections;
            if(val_14 == null)
            {
                    return;
            }
            
            val_15 = 0;
            goto label_14;
            label_19:
            val_14.DisableRenderers();
            val_14 = this.Projections;
            val_15 = 1;
            label_14:
            if(val_15 >= val_14.Count)
            {
                    return;
            }
            
            if(this.Projections.Item[1] != null)
            {
                goto label_19;
            }
            
            goto label_19;
        }
        private void LateUpdate()
        {
            this.UpdateSystemPath();
            this.UpdateProjectionData();
            this.OrderRenderers();
        }
        private void SuperLateUpdate(UnityEngine.Camera Camera)
        {
            if(this.FireInCulling == false)
            {
                    return;
            }
            
            if(val_2.initialized == false)
            {
                    return;
            }
            
            if(Camera.cameraType != 2)
            {
                    if(Camera.cameraType != 4)
            {
                    if(Camera.isActiveAndEnabled == false)
            {
                    return;
            }
            
            }
            
            }
            
            this.GetData(Camera:  Camera).Update(Camera:  Camera, System:  this);
        }
        private void PreRender(UnityEngine.Camera Camera)
        {
            LlockhamIndustries.Decals.CameraData val_1 = this.GetData(Camera:  Camera);
            if(val_1.initialized == false)
            {
                    return;
            }
            
            if(Camera.cameraType != 2)
            {
                    if(Camera.cameraType != 4)
            {
                    if(Camera.isActiveAndEnabled == false)
            {
                    return;
            }
            
            }
            
            }
            
            if(this.FireInCulling != true)
            {
                    val_1.Update(Camera:  Camera, System:  this);
            }
            
            val_1.AssignGlobalProperties(Camera:  Camera);
        }
        public static string get_DebugLog()
        {
            UnityEngine.Object val_33;
            string val_35;
            typeof(System.Object[]).__il2cppRuntimeField_20 = 0 + 0 + 0 + "Debug Information (Copy and Paste) \r\n"(0 + "Debug Information (Copy and Paste) \r\n") + "OS : "("OS : ") + UnityEngine.SystemInfo.operatingSystem(0 + 0 + "Debug Information (Copy and Paste) \r\n"(0 + "Debug Information (Copy and Paste) \r\n") + "OS : "("OS : ") + UnityEngine.SystemInfo.operatingSystem) + "Graphics device : "("Graphics device : ") + UnityEngine.SystemInfo.graphicsDeviceName;
            typeof(System.Object[]).__il2cppRuntimeField_28 = "Graphics API : ";
            typeof(System.Object[]).__il2cppRuntimeField_30 = UnityEngine.SystemInfo.graphicsDeviceType;
            typeof(System.Object[]).__il2cppRuntimeField_38 = "\r\n";
            string val_7 = +0;
            val_33 = UnityEngine.Camera.main;
            if(0 != val_33)
            {
                    typeof(System.Object[]).__il2cppRuntimeField_20 = 0 + val_7;
                typeof(System.Object[]).__il2cppRuntimeField_28 = "Rendering path : ";
                typeof(System.Object[]).__il2cppRuntimeField_30 = val_33.actualRenderingPath;
                typeof(System.Object[]).__il2cppRuntimeField_38 = "\r\n";
                typeof(System.Object[]).__il2cppRuntimeField_20 = +0;
                typeof(System.Object[]).__il2cppRuntimeField_28 = "Is orthographic : ";
                typeof(System.Object[]).__il2cppRuntimeField_30 = val_33.orthographic;
                typeof(System.Object[]).__il2cppRuntimeField_31 = 27952484;
                typeof(System.Object[]).__il2cppRuntimeField_38 = "\r\n";
                LlockhamIndustries.Decals.CameraData val_20 = LlockhamIndustries.Decals.DynamicDecals.System.GetData(Camera:  val_33);
                val_33 = val_20.replacement;
                UnityEngine.Vector2 val_22 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3());
                mem2[0] = null;
                string val_23 = 0 + 0 + +0(+0)(0 + +0(+0)) + "Method : "("Method : ") + val_33.ToString();
            }
            
            val_35 = 0 + val_7;
            if(UnityEngine.XR.XRSettings.enabled == false)
            {
                    return (string)val_35;
            }
            
            typeof(System.Object[]).__il2cppRuntimeField_20 = val_35;
            typeof(System.Object[]).__il2cppRuntimeField_28 = "\r\nVirtualReality : ";
            typeof(System.Object[]).__il2cppRuntimeField_30 = UnityEngine.XR.XRSettings.isDeviceActive;
            typeof(System.Object[]).__il2cppRuntimeField_31 = 27952628;
            typeof(System.Object[]).__il2cppRuntimeField_38 = "\r\n";
            val_33 = 0 + +0(+0) + "VR API : "("VR API : ") + UnityEngine.XR.XRSettings.loadedDeviceName;
            val_35 = 0 + val_33 + "VR device : "("VR device : ") + UnityEngine.XR.XRDevice.model;
            return (string)val_35;
        }
        public static void DebugInDevelopmentBuild()
        {
            if(UnityEngine.Debug.isDebugBuild == false)
            {
                    return;
            }
            
            string val_2 = LlockhamIndustries.Decals.DynamicDecals.DebugLog;
            UnityEngine.Debug.Log(message:  0);
        }
    
    }

}
