using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    [UnityEngine.ExecuteInEditMode]
    [UnityEngine.RequireComponent]
    [UnityEngine.RequireComponent]
    public class UIParticleSystem : MaskableGraphic
    {
        // Fields
        public UnityEngine.Texture particleTexture;
        public UnityEngine.Sprite particleSprite;
        private UnityEngine.Transform _transform;
        private UnityEngine.ParticleSystem _particleSystem;
        private UnityEngine.ParticleSystem.Particle[] _particles;
        private UnityEngine.UIVertex[] _quad;
        private UnityEngine.Vector4 _uv;
        private UnityEngine.ParticleSystem.TextureSheetAnimationModule _textureSheetAnimation;
        private int _textureSheetAnimationFrames;
        private UnityEngine.Vector2 _textureSheedAnimationFrameSize;
        
        // Properties
        public override UnityEngine.Texture mainTexture { get; }
        
        // Methods
        public UIParticleSystem()
        {
            this._quad = null;
            UnityEngine.Vector4 val_1 = UnityEngine.Vector4.zero;
            this._uv = val_1;
            mem[1152921512725277492] = val_1.y;
            mem[1152921512725277496] = val_1.z;
            mem[1152921512725277500] = val_1.w;
        }
        public override UnityEngine.Texture get_mainTexture()
        {
            UnityEngine.Sprite val_4;
            UnityEngine.Texture val_5;
            val_4 = this;
            if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
            {
                    val_5 = this.particleTexture;
                return (UnityEngine.Texture)val_4.texture;
            }
            
            val_5 = 0;
            if((UnityEngine.Object.op_Implicit(exists:  0)) == false)
            {
                    return (UnityEngine.Texture)val_4.texture;
            }
            
            val_4 = this.particleSprite;
            return (UnityEngine.Texture)val_4.texture;
        }
        protected bool Initialize()
        {
            UnityEngine.ParticleSystem val_31;
            UnityEngine.Object val_32;
            var val_33;
            if(0 == this._transform)
            {
                    this._transform = this.transform;
            }
            
            val_31 = this._particleSystem;
            val_32 = this.GetComponent<UnityEngine.ParticleSystemRenderer>();
            if(0 != val_31)
            {
                goto label_6;
            }
            
            val_31 = this.GetComponent<UnityEngine.ParticleSystem>();
            this._particleSystem = val_31;
            if(0 != val_31)
            {
                goto label_9;
            }
            
            val_33 = 0;
            return (bool)val_33;
            label_6:
            if(UnityEngine.Application.isPlaying == false)
            {
                goto label_30;
            }
            
            val_31 = val_32.material;
            if(0 != val_31)
            {
                goto label_30;
            }
            
            goto label_16;
            label_9:
            if(0 == val_32)
            {
                    val_32 = this._particleSystem.gameObject.AddComponent<UnityEngine.ParticleSystemRenderer>();
            }
            
            UnityEngine.Material val_14 = val_32.sharedMaterial;
            if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
            {
                    if((val_14.HasProperty(propertyName:  "_MainTex")) != false)
            {
                    this.particleTexture = val_14.mainTexture;
            }
            
            }
            
            this._particleSystem.scalingMode = 1;
            this._particles = 0;
            label_16:
            UnityEngine.Material val_19 = null;
            val_31 = val_19;
            val_19 = new UnityEngine.Material(shader:  UnityEngine.Shader.Find(name:  0));
            if(UnityEngine.Application.isPlaying != false)
            {
                    val_32.material = val_31;
            }
            
            label_30:
            if(this._particles == null)
            {
                    val_31 = this._particleSystem.maxParticles;
                this._particles = null;
            }
            
            if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
            {
                    this._uv = 0;
            }
            else
            {
                    if((UnityEngine.Object.op_Implicit(exists:  0)) != false)
            {
                    UnityEngine.Vector4 val_24 = UnityEngine.Sprites.DataUtility.GetOuterUV(sprite:  0);
                this._uv = val_24;
                mem[1152921512725655204] = val_24.y;
                mem[1152921512725655208] = val_24.z;
                mem[1152921512725655212] = val_24.w;
            }
            
            }
            
            TextureSheetAnimationModule val_25 = this._particleSystem.textureSheetAnimation;
            this._textureSheetAnimationFrames = 0;
            this._textureSheetAnimation = val_25.m_ParticleSystem;
            UnityEngine.Vector2 val_26 = UnityEngine.Vector2.zero;
            this._textureSheedAnimationFrameSize = val_26;
            mem[1152921512725655232] = val_26.y;
            if((this._textureSheetAnimation & 1) != 0)
            {
                    this._textureSheetAnimationFrames = this._textureSheetAnimation * this._textureSheetAnimation;
                val_31 = this._textureSheetAnimation;
                float val_30 = (float)val_31;
                float val_31 = 1f;
                val_30 = val_31 / val_30;
                val_31 = val_31 / (float)this._textureSheetAnimation;
                CinemachineFreeLook.Orbit val_28 = new CinemachineFreeLook.Orbit(h:  val_30, r:  val_31);
                this._textureSheedAnimationFrameSize = val_28.m_Height;
                mem[1152921512725655232] = val_28.m_Height >> 32;
            }
            
            val_33 = 1;
            return (bool)val_33;
        }
        protected override void Awake()
        {
            this.Awake();
            if(this.Initialize() != false)
            {
                    return;
            }
            
            this.enabled = false;
        }
        protected override void OnPopulateMesh(UnityEngine.UI.VertexHelper vh)
        {
            UnityEngine.UI.VertexHelper val_61;
            UnityEngine.ParticleSystem val_62;
            var val_63;
            var val_64;
            var val_65;
            float val_66;
            float val_69;
            float val_70;
            UnityEngine.Vector4 val_71;
            float val_72;
            float val_73;
            float val_74;
            var val_75;
            float val_76;
            UnityEngine.UIVertex[] val_79;
            float val_80;
            float val_81;
            val_61 = vh;
            val_61.Clear();
            val_62 = this.gameObject;
            if(val_62.activeInHierarchy == false)
            {
                    return;
            }
            
            val_62 = this._particleSystem;
            int val_3 = val_62.GetParticles(particles:  this._particles);
            if(val_3 < 1)
            {
                    return;
            }
            
            val_63 = 1152921504730062848;
            var val_65 = 0;
            val_64 = val_3;
            val_65 = 1152921504737091584;
            label_81:
            if(this._particleSystem.simulationSpace != 0)
            {
                    UnityEngine.Vector3 val_5 = this._transform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = 1.570796f, y = V1.16B, z = V2.16B});
            }
            
            val_66 = V2.16B;
            UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = 1.570796f, y = V1.16B, z = val_66});
            val_69 = val_6.x;
            val_70 = val_6.y;
            if(this._particleSystem.scalingMode == 2)
            {
                    val_66 = this.canvas.scaleFactor;
                UnityEngine.Vector2 val_10 = UnityEngine.Vector2.op_Division(a:  new UnityEngine.Vector2() {x = val_69, y = val_70}, d:  val_66);
                val_69 = val_10.x;
                val_70 = val_10.y;
            }
            
            val_71 = this._uv;
            if((this._textureSheetAnimation & 1) == 0)
            {
                goto label_19;
            }
            
            float val_57 = val_10.x;
            float val_11 = ShotQuality;
            val_11 = val_57 / val_11;
            val_57 = 1f - val_11;
            float val_58 = (float)this._textureSheetAnimation;
            val_58 = val_57 * val_58;
            float val_12 = UnityEngine.Mathf.Repeat(t:  val_58, length:  1f);
            if(this._textureSheetAnimation == 1)
            {
                goto label_22;
            }
            
            if(this._textureSheetAnimation != 0)
            {
                goto label_26;
            }
            
            float val_59 = (float)this._textureSheetAnimationFrames;
            val_59 = val_12 * val_59;
            int val_13 = UnityEngine.Mathf.FloorToInt(f:  val_59);
            goto label_26;
            label_22:
            float val_60 = (float)this._textureSheetAnimation;
            val_60 = val_12 * val_60;
            var val_62 = this._textureSheetAnimation.rowIndex;
            ParticleSystem.TextureSheetAnimationModule val_61 = this._textureSheetAnimation;
            val_61 = (UnityEngine.Mathf.FloorToInt(f:  val_60)) + (val_61 * val_62);
            label_26:
            int val_63 = this._textureSheetAnimationFrames;
            val_62 = val_61 - ((val_61 / val_63) * val_63);
            val_63 = val_62 / this._textureSheetAnimation;
            val_63 = val_62 - (val_63 * this._textureSheetAnimation);
            val_71 = this._textureSheedAnimationFrameSize * (float)val_63;
            val_64 = val_64;
            val_63 = val_63;
            val_65 = val_65;
            val_61 = val_61;
            val_66 = (float)UnityEngine.Mathf.FloorToInt(f:  (float)val_62 / this._textureSheetAnimation);
            val_72 = val_66 * ((float)val_62 / this._textureSheetAnimation);
            val_74 = val_71 + this._textureSheedAnimationFrameSize;
            val_73 = ((float)val_62 / this._textureSheetAnimation) + val_72;
            label_19:
            val_75 = null;
            this._quad[0] = ;
            CinemachineFreeLook.Orbit val_19 = new CinemachineFreeLook.Orbit(h:  val_71, r:  val_72);
            this._quad[0] = val_19.m_Height;
            this._quad[0] = val_19.m_Height >> 32;
            this._quad[1] = ;
            CinemachineFreeLook.Orbit val_21 = new CinemachineFreeLook.Orbit(h:  val_71, r:  val_73);
            this._quad[1] = val_21.m_Height;
            this._quad[1] = val_21.m_Height >> 32;
            this._quad[2] = ;
            CinemachineFreeLook.Orbit val_23 = new CinemachineFreeLook.Orbit(h:  val_74, r:  val_73);
            this._quad[2] = val_23.m_Height;
            this._quad[2] = val_23.m_Height >> 32;
            this._quad[3] = ;
            float val_25 = val_6.x * (-0.01745329f);
            CinemachineFreeLook.Orbit val_26 = new CinemachineFreeLook.Orbit(h:  val_74, r:  val_72);
            float val_64 = 0.5f;
            val_76 = val_6.x * val_64;
            this._quad[3] = val_26.m_Height;
            this._quad[3] = val_26.m_Height >> 32;
            if(val_25 == 0f)
            {
                    val_64 = val_69 - val_76;
                CinemachineFreeLook.Orbit val_29 = new CinemachineFreeLook.Orbit(h:  val_64, r:  val_70 - val_76);
                CinemachineFreeLook.Orbit val_32 = new CinemachineFreeLook.Orbit(h:  val_76 + val_69, r:  val_76 + val_70);
                CinemachineFreeLook.Orbit val_33 = new CinemachineFreeLook.Orbit(h:  val_29.m_Height, r:  val_29.m_Radius);
                UnityEngine.Vector3 val_34 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_33.m_Height, y = val_33.m_Radius});
                this._quad[0] = val_34.x;
                this._quad[0] = val_34.y;
                this._quad[0] = val_34.z;
                CinemachineFreeLook.Orbit val_35 = new CinemachineFreeLook.Orbit(h:  val_29.m_Height, r:  val_32.m_Radius);
                UnityEngine.Vector3 val_36 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_35.m_Height, y = val_35.m_Radius});
                this._quad[1] = val_36.x;
                this._quad[1] = val_36.y;
                this._quad[1] = val_36.z;
                CinemachineFreeLook.Orbit val_37 = new CinemachineFreeLook.Orbit(h:  val_32.m_Height, r:  val_32.m_Radius);
                UnityEngine.Vector3 val_38 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_37.m_Height, y = val_37.m_Radius});
                this._quad[2] = val_38.x;
                this._quad[2] = val_38.y;
                this._quad[2] = val_38.z;
                val_79 = this._quad;
                CinemachineFreeLook.Orbit val_39 = new CinemachineFreeLook.Orbit(h:  val_32.m_Height, r:  val_29.m_Radius);
                val_80 = val_39.m_Height;
                val_81 = val_39.m_Radius;
            }
            else
            {
                    float val_40 = val_25 + 1.570796f;
                CinemachineFreeLook.Orbit val_41 = new CinemachineFreeLook.Orbit(h:  val_25, r:  val_25);
                UnityEngine.Vector2 val_42 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_41.m_Height, y = val_41.m_Radius}, d:  val_76);
                CinemachineFreeLook.Orbit val_43 = new CinemachineFreeLook.Orbit(h:  val_40, r:  val_40);
                UnityEngine.Vector2 val_44 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_43.m_Height, y = val_43.m_Radius}, d:  val_76);
                val_76 = val_44.x;
                UnityEngine.Vector2 val_45 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_69, y = val_70}, b:  new UnityEngine.Vector2() {x = val_42.x, y = val_42.y});
                UnityEngine.Vector2 val_46 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_45.x, y = val_45.y}, b:  new UnityEngine.Vector2() {x = val_76, y = val_44.y});
                UnityEngine.Vector3 val_47 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_46.x, y = val_46.y});
                this._quad[0] = val_47.x;
                this._quad[0] = val_47.y;
                this._quad[0] = val_47.z;
                UnityEngine.Vector2 val_48 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_69, y = val_70}, b:  new UnityEngine.Vector2() {x = val_42.x, y = val_42.y});
                UnityEngine.Vector2 val_49 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_48.x, y = val_48.y}, b:  new UnityEngine.Vector2() {x = val_76, y = val_44.y});
                UnityEngine.Vector3 val_50 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_49.x, y = val_49.y});
                this._quad[1] = val_50.x;
                this._quad[1] = val_50.y;
                this._quad[1] = val_50.z;
                UnityEngine.Vector2 val_51 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_69, y = val_70}, b:  new UnityEngine.Vector2() {x = val_42.x, y = val_42.y});
                UnityEngine.Vector2 val_52 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_51.x, y = val_51.y}, b:  new UnityEngine.Vector2() {x = val_76, y = val_44.y});
                UnityEngine.Vector3 val_53 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_52.x, y = val_52.y});
                val_74 = val_53.y;
                this._quad[2] = val_53.x;
                this._quad[2] = val_74;
                this._quad[2] = val_53.z;
                val_79 = this._quad;
                val_81 = val_70;
                val_80 = val_69;
                UnityEngine.Vector2 val_54 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_80, y = val_81}, b:  new UnityEngine.Vector2() {x = val_42.x, y = val_42.y});
                val_66 = val_76;
                UnityEngine.Vector2 val_55 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_54.x, y = val_54.y}, b:  new UnityEngine.Vector2() {x = val_66, y = val_44.y});
            }
            
            UnityEngine.Vector3 val_56 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_55.x, y = val_55.y});
            val_79[3] = val_56.x;
            val_79[3] = val_56.y;
            val_79[3] = val_56.z;
            val_61.AddUIVertexQuad(verts:  this._quad);
            val_65 = val_65 + 1;
            val_62 = 32 + 120;
            if(val_64 != val_65)
            {
                goto label_81;
            }
        
        }
        private void Update()
        {
            if(UnityEngine.Application.isPlaying == false)
            {
                    return;
            }
            
            this._particleSystem.Simulate(t:  UnityEngine.Time.unscaledDeltaTime, withChildren:  false, restart:  false);
            this.SetAllDirty();
        }
    
    }

}
