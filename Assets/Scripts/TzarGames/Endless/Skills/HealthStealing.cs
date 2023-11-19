using UnityEngine;

namespace TzarGames.Endless.Skills
{
    public class HealthStealing : EndlessCharacterSkill, IActivableSkill, ICommonSkillUpgrade
    {
        // Fields
        [UnityEngine.SerializeField]
        private UnityEngine.Sprite activatedIcon;
        [UnityEngine.SerializeField]
        private float damageToHealFactor;
        [UnityEngine.SerializeField]
        private float time;
        [UnityEngine.SerializeField]
        private float particleRotationSpeed;
        [UnityEngine.SerializeField]
        private float particleMoveSpeed;
        [UnityEngine.SerializeField]
        private string[] surfaceTypeNames;
        [UnityEngine.SerializeField]
        private TzarGames.Common.LocalizedStringAsset upgradeLabel;
        [UnityEngine.HeaderAttribute]
        [UnityEngine.SerializeField]
        private UnityEngine.ParticleSystem effect;
        [UnityEngine.SerializeField]
        private UnityEngine.ParticleSystem bodyEffect;
        [UnityEngine.SerializeField]
        private SoundGroup healthSounds;
        [UnityEngine.SerializeField]
        private SoundGroup activateSounds;
        private TzarGames.Endless.HealthStealingInfluence influence;
        private UnityEngine.ParticleSystem[] effectInstances;
        private UnityEngine.ParticleSystem bodyEffectInstance;
        private UnityEngine.ParticleSystem.Particle[] particleArray;
        private TzarGames.GameFramework.CharacteristicModificator timeModificator;
        private TzarGames.GameFramework.SurfaceTypeBase[] surfaceTypes;
        private static float defaultTimeToDelete;
        private static UnityEngine.Color defaultColor;
        private System.Collections.Generic.List<TzarGames.Endless.Skills.HealthStealing.ParticleInfo> spawnedParticles;
        
        // Properties
        public UnityEngine.Sprite ActivatedIcon { get; }
        public bool IsActive { get; }
        public TzarGames.GameFramework.CharacteristicModificator Modificator { get; }
        
        // Methods
        public HealthStealing()
        {
            this.damageToHealFactor = ;
            this.time = ;
            this.particleRotationSpeed = 1.5f;
            this.particleMoveSpeed = 1.5f;
            typeof(System.String[]).__il2cppRuntimeField_20 = "Bone";
            typeof(System.String[]).__il2cppRuntimeField_28 = "Flesh";
            this.surfaceTypeNames = null;
            this.particleArray = null;
            this.timeModificator = new TzarGames.GameFramework.CharacteristicModificator(value:  1f);
            this.spawnedParticles = new System.Collections.Generic.List<ParticleInfo>();
            this = new TzarGames.TzarHero.Skills.CharacterSkill();
        }
        public UnityEngine.Sprite get_ActivatedIcon()
        {
            return (UnityEngine.Sprite)this.activatedIcon;
        }
        public bool get_IsActive()
        {
            return UnityEngine.Object.op_Inequality(x:  0, y:  this.influence.Target);
        }
        public TzarGames.GameFramework.CharacteristicModificator get_Modificator()
        {
            return (TzarGames.GameFramework.CharacteristicModificator)this.timeModificator;
        }
        public override void OnInitialize()
        {
            var val_3;
            this.OnInitialize();
            this.surfaceTypes = null;
            val_3 = 0;
            goto label_2;
            label_13:
            var val_1 = X24 + ((X23) << 3);
            val_3 = 1;
            mem2[0] = null;
            label_2:
            if(val_3 >= this.surfaceTypeNames.Length)
            {
                    return;
            }
            
            string val_3 = this.surfaceTypeNames[1];
            TzarGames.GameFramework.SurfaceTypeBase val_2 = TzarGames.GameFramework.SurfaceTypeBase.GetOrCreate(surfaceName:  0);
            if(val_3 < this.surfaceTypes.Length)
            {
                goto label_13;
            }
            
            goto label_13;
        }
        protected override void OnCharacterAssigned()
        {
            var val_17;
            var val_21;
            var val_27;
            var val_34;
            var val_35;
            this.OnCharacterAssigned();
            this.Character.add_OnHitOtherCharacter(value:  new TH_Character.dlgHitEvent(object:  this, method:  System.Void TzarGames.Endless.Skills.HealthStealing::Character_OnHitOtherCharacter(TzarGames.TzarHero.ICharacterDamageInfo hitData)));
            this.influence = new TzarGames.Endless.HealthStealingInfluence(instigator:  this.Character, effectTime:  this.time);
            this.destroyEffect();
            T[] val_6 = UnityEngine.Object.Instantiate<Unitycoding.UIWidgets.RadialMenuItem>(original:  0).GetComponentsInChildren<UnityEngine.ParticleSystem>();
            val_34 = 0;
            this.effectInstances = val_6;
            goto label_5;
            label_10:
            Pause();
            val_34 = 1;
            label_5:
            if(val_34 >= val_6.Length)
            {
                goto label_7;
            }
            
            if(val_6[1] != 0)
            {
                goto label_10;
            }
            
            goto label_10;
            label_7:
            if(0 != this.bodyEffectInstance)
            {
                    UnityEngine.GameObject val_8 = this.bodyEffectInstance.gameObject;
                UnityEngine.Object.Destroy(obj:  0);
            }
            
            Unitycoding.UIWidgets.RadialMenuItem val_9 = UnityEngine.Object.Instantiate<Unitycoding.UIWidgets.RadialMenuItem>(original:  0);
            this.bodyEffectInstance = val_9;
            val_9.transform.SetParent(parent:  this.Character.transform);
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.zero;
            this.bodyEffectInstance.transform.localPosition = new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z};
            EmissionModule val_15 = this.bodyEffectInstance.emission;
            ParticleSystem.MinMaxCurve val_16 = ParticleSystem.MinMaxCurve.op_Implicit(constant:  0f);
            MainModule val_19 = this.effect.main;
            TzarGames.Endless.Skills.HealthStealing.defaultTimeToDelete = val_21.targetValue;
            MainModule val_23 = this.effect.main;
            UnityEngine.Color val_28 = val_27.targetColor;
            val_35 = 0;
            TzarGames.Endless.Skills.HealthStealing.defaultColor = val_28.r;
            TzarGames.Endless.Skills.HealthStealing.defaultTimeToDelete.__il2cppRuntimeField_8 = val_28.g;
            TzarGames.Endless.Skills.HealthStealing.defaultTimeToDelete.__il2cppRuntimeField_C = val_28.b;
            TzarGames.Endless.Skills.HealthStealing.defaultTimeToDelete.__il2cppRuntimeField_10 = val_28.a;
            goto label_29;
            label_35:
            var val_29 = 120 + 32;
            val_35 = 1;
            label_29:
            if(val_35 >= this.particleArray.Length)
            {
                    return;
            }
            
            UnityEngine.Color32 val_30 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = TzarGames.Endless.Skills.HealthStealing.defaultColor, g = TzarGames.Endless.Skills.HealthStealing.defaultTimeToDelete.__il2cppRuntimeField_8, b = TzarGames.Endless.Skills.HealthStealing.defaultTimeToDelete.__il2cppRuntimeField_C, a = TzarGames.Endless.Skills.HealthStealing.defaultTimeToDelete.__il2cppRuntimeField_10});
            byte val_31 = val_30.r & 4294967295;
            MainModule val_32 = this.effect.main;
            float val_33 = val_17.targetValue;
            ShotQuality = TzarGames.Endless.Skills.HealthStealing.defaultTimeToDelete;
            float val_34 = ShotQuality;
            if(val_35 < this.particleArray.Length)
            {
                goto label_35;
            }
            
            goto label_35;
        }
        protected override void OnCharacterRemoved(TzarGames.TzarHero.TH_Character character)
        {
            dlgHitEvent val_5;
            this.OnCharacterRemoved(character:  character);
            this.influence = 0;
            if(0 != character)
            {
                    TH_Character.dlgHitEvent val_2 = null;
                val_5 = val_2;
                val_2 = new TH_Character.dlgHitEvent(object:  this, method:  System.Void TzarGames.Endless.Skills.HealthStealing::Character_OnHitOtherCharacter(TzarGames.TzarHero.ICharacterDamageInfo hitData));
                character.remove_OnHitOtherCharacter(value:  val_5);
            }
            
            this.destroyEffect();
            if(0 == this.bodyEffectInstance)
            {
                    return;
            }
            
            UnityEngine.GameObject val_4 = this.bodyEffectInstance.gameObject;
            UnityEngine.Object.Destroy(obj:  0);
        }
        private void OnDestroy()
        {
            this.destroyEffect();
        }
        private void destroyEffect()
        {
            UnityEngine.ParticleSystem val_3 = this;
            if(this.effectInstances == null)
            {
                    return;
            }
            
            if(this.effectInstances.Length < 1)
            {
                    return;
            }
            
            do
            {
                val_3 = this.effectInstances[0];
                if(0 != val_3)
            {
                    val_3 = val_3.gameObject;
                UnityEngine.Object.Destroy(obj:  0);
            }
            
            }
            while((0 + 1) < this.effectInstances.Length);
        
        }
        private void Character_OnHitOtherCharacter(TzarGames.TzarHero.ICharacterDamageInfo hitData)
        {
            UnityEngine.Object val_26;
            var val_27;
            var val_28;
            var val_29;
            var val_30;
            var val_31;
            var val_32;
            var val_33;
            var val_34;
            float val_35;
            float val_36;
            float val_37;
            var val_38;
            val_26 = this.Character;
            if((val_26.HasInfluenceOfType<TzarGames.Endless.HealthStealingInfluence>()) == false)
            {
                    return;
            }
            
            var val_26 = 0;
            val_26 = val_26 + 1;
            val_27 = hitData;
            val_26 = hitData;
            if(0 == val_26)
            {
                    return;
            }
            
            var val_30 = 0;
            do
            {
                if(val_30 >= this.surfaceTypes.Length)
            {
                    return;
            }
            
                var val_28 = 0;
                val_28 = val_28 + 1;
                val_28 = hitData;
                var val_29 = 0;
                val_29 = val_29 + 1;
                val_29 = hitData;
                val_30 = val_30 + 1;
            }
            while(hitData != this.surfaceTypes[0]);
            
            var val_31 = 0;
            val_31 = val_31 + 1;
            val_30 = hitData;
            float val_9 = val_26.BaseHealth;
            float val_11 = UnityEngine.Mathf.Clamp(value:  V0.16B * this.damageToHealFactor, min:  0f, max:  val_9);
            var val_32 = 0;
            val_32 = val_32 + 1;
            val_31 = hitData;
            var val_33 = 0;
            val_33 = val_33 + 1;
            val_32 = hitData;
            var val_34 = 0;
            val_34 = val_34 + 1;
            val_33 = hitData;
            var val_35 = 0;
            val_35 = val_35 + 1;
            val_34 = hitData;
            val_26 = hitData;
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_11, y = 0f, z = val_9}, d:  val_11);
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, d:  2f);
            UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_11, y = 0f, z = val_9}, b:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z});
            UnityEngine.Vector3 val_19 = UnityEngine.Vector3.zero;
            val_35 = val_19.y;
            val_36 = UnityEngine.Random.Range(min:  -0.5f, max:  0.5f);
            val_37 = UnityEngine.Random.Range(min:  0f, max:  1f);
            val_36 = val_36;
            val_35 = val_35;
            val_37 = val_37;
            UnityEngine.Quaternion val_22 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = val_11, y = 0f, z = val_9});
            UnityEngine.Vector3 val_23 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_22.x, y = val_22.y, z = val_22.z, w = val_22.w}, point:  new UnityEngine.Vector3() {x = val_36, y = val_35, z = val_37});
            var val_36 = 0;
            val_36 = val_36 + 1;
            val_38 = hitData;
            this.spawnParticle(position:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z}, direction:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z}, hitPoints:  val_11, critical:  hitData & 1);
        }
        private void spawnParticle(UnityEngine.Vector3 position, UnityEngine.Vector3 direction, float hitPoints, bool critical)
        {
            float val_2;
            float val_3;
            MainModule val_1 = this.effect.main;
            float val_4 = val_2.targetValue;
            val_4 = ((critical != true) ? 2f : 1f) * val_4;
            val_2 = position.x;
            val_3 = direction.y;
            this.spawnedParticles.Add(item:  new ParticleInfo() {Position = new UnityEngine.Vector3() {x = val_2}, Direction = new UnityEngine.Vector3() {y = val_3}, Dying = false, TimeToDelete = 0f});
        }
        private static void updateParticle(ref UnityEngine.ParticleSystem.Particle particle, ref TzarGames.Endless.Skills.HealthStealing.ParticleInfo p)
        {
            float val_1 = UnityEngine.Mathf.Max(a:  X2 + 36, b:  0.001f);
            if((X2 + 32) != 0)
            {
                    float val_5 = X2 + 36;
                val_5 = val_5 / TzarGames.Endless.Skills.HealthStealing.defaultTimeToDelete;
                val_5 = 1f - val_5;
                UnityEngine.Color val_2 = UnityEngine.Color.Lerp(a:  new UnityEngine.Color() {r = TzarGames.Endless.Skills.HealthStealing.defaultColor, g = TzarGames.Endless.Skills.HealthStealing.defaultTimeToDelete.__il2cppRuntimeField_8, b = TzarGames.Endless.Skills.HealthStealing.defaultTimeToDelete.__il2cppRuntimeField_C, a = TzarGames.Endless.Skills.HealthStealing.defaultTimeToDelete.__il2cppRuntimeField_10}, b:  new UnityEngine.Color() {r = TzarGames.Endless.Skills.HealthStealing.defaultColor, g = TzarGames.Endless.Skills.HealthStealing.defaultTimeToDelete.__il2cppRuntimeField_8, b = TzarGames.Endless.Skills.HealthStealing.defaultTimeToDelete.__il2cppRuntimeField_C, a = 0f}, t:  val_5);
            }
            
            UnityEngine.Color32 val_3 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a});
            byte val_4 = val_3.r & 4294967295;
        }
        private void simulateEffects(float deltaTime)
        {
            float val_11;
            var val_13;
            int val_1 = this.spawnedParticles.Count;
            if(this.particleArray.Length < val_1)
            {
                    int val_3 = UnityEngine.Mathf.Max(a:  0, b:  this.particleArray.Length << 1);
                System.Array.Resize<Particle>(array: ref  0, newSize:  1922330776);
            }
            
            int val_5 = val_1 - 1;
            if(this.particleArray.Length >= val_1)
            {
                    var val_12 = 0;
                var val_13 = 32;
                do
            {
                ParticleInfo val_6 = this.spawnedParticles.Item[0];
                TzarGames.Endless.Skills.HealthStealing.updateParticle(particle: ref  new ParticleSystem.Particle() {m_Position = new UnityEngine.Vector3() {x = this.spawnedParticles, y = this.spawnedParticles, z = this.spawnedParticles}, m_Velocity = new UnityEngine.Vector3() {x = this.spawnedParticles, y = this.spawnedParticles, z = this.spawnedParticles}, m_AnimatedVelocity = new UnityEngine.Vector3() {x = this.spawnedParticles, y = this.spawnedParticles, z = this.spawnedParticles}, m_InitialVelocity = new UnityEngine.Vector3() {x = this.spawnedParticles, y = this.spawnedParticles, z = this.spawnedParticles}, m_AxisOfRotation = new UnityEngine.Vector3() {x = this.spawnedParticles, y = this.spawnedParticles, z = this.spawnedParticles}, m_Rotation = new UnityEngine.Vector3() {x = this.spawnedParticles, y = this.spawnedParticles, z = this.spawnedParticles}, m_AngularVelocity = new UnityEngine.Vector3() {x = this.spawnedParticles, y = this.spawnedParticles, z = this.spawnedParticles}, m_StartSize = new UnityEngine.Vector3() {x = this.spawnedParticles, y = this.spawnedParticles, z = this.spawnedParticles}}, p: ref  new ParticleInfo() {Position = new UnityEngine.Vector3() {x = this.particleArray[val_13], y = this.particleArray[val_13], z = this.particleArray[val_13]}, Direction = new UnityEngine.Vector3() {x = this.particleArray[val_13], y = this.particleArray[val_13], z = this.particleArray[val_13]}, HitPoints = this.particleArray[val_13], Size = this.particleArray[val_13], Dying = this.particleArray[val_13], TimeToDelete = this.particleArray[val_13]});
                val_12 = val_12 + 1;
                val_13 = val_13 + 120;
            }
            while(val_1 != val_12);
            
            }
            
            this.effectInstances[0].SetParticles(particles:  this.particleArray, size:  val_1);
            val_13 = 0;
            goto label_15;
            label_21:
            val_1.Simulate(t:  deltaTime, withChildren:  true, restart:  false);
            val_13 = 1;
            label_15:
            if(val_13 >= this.effectInstances.Length)
            {
                goto label_17;
            }
            
            if(this.effectInstances[1] != null)
            {
                goto label_21;
            }
            
            goto label_21;
            label_17:
            label_24:
            if((val_5 & 2147483648) != 0)
            {
                goto label_22;
            }
            
            ParticleInfo val_10 = this.spawnedParticles.Item[val_5];
            val_5 = val_5 - 1;
            if(val_11 <= 0f)
            {
                goto label_24;
            }
            
            return;
            label_22:
            this.spawnedParticles.Clear();
        }
        public override void UpdateSkill(float deltaTime)
        {
            float val_6;
            float val_7;
            float val_21;
            float val_22;
            float val_23;
            float val_24;
            var val_25;
            var val_27;
            float val_28;
            bool val_29;
            float val_30;
            float val_42;
            float val_43;
            UnityEngine.Object val_44;
            float val_45;
            float val_46;
            bool val_48;
            float val_49;
            val_42 = deltaTime;
            val_43 = val_42;
            this.UpdateSkill(deltaTime:  val_43);
            int val_41 = this.spawnedParticles.Count;
            val_44 = this.influence.Target;
            if(0 == val_44)
            {
                    val_44 = this.bodyEffectInstance;
                EmissionModule val_4 = val_44.emission;
                val_43 = 0f;
                ParticleSystem.MinMaxCurve val_5 = ParticleSystem.MinMaxCurve.op_Implicit(constant:  val_43);
            }
            else
            {
                    this.ResetCooldownTime();
            }
            
            if(this.effectInstances == null)
            {
                    return;
            }
            
            if(this.effectInstances.Length == 0)
            {
                    return;
            }
            
            if(val_41 == 0)
            {
                goto label_10;
            }
            
            float val_8 = UnityEngine.Time.time;
            UnityEngine.Vector3 val_10 = this.Character.GroundPivotPosition;
            val_45 = val_10.z;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.up;
            val_46 = val_11.y;
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_46, z = val_11.z}, d:  this.Character.AttackHeightOffset);
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_45}, b:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
            TzarGames.TzarHero.TH_Character val_16 = this.Character;
            val_42 = val_15.x;
            val_44 = this.Character;
            float val_18 = val_44.MaxMoveSpeed;
            val_41 = val_41 - 1;
            if((val_41 & 2147483648) != 0)
            {
                goto label_33;
            }
            
            val_18 = val_18 * this.particleMoveSpeed;
            val_18 = val_18 * val_42;
            do
            {
                ParticleInfo val_20 = this.spawnedParticles.Item[val_41];
                val_48 = val_29;
                UnityEngine.Vector3 val_31 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, b:  new UnityEngine.Vector3() {x = val_7, y = val_21, z = val_22});
                float val_32 = (val_48 == true) ? 2f : 1f;
                UnityEngine.Vector3 val_35 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_23, y = val_6, z = val_24}, b:  new UnityEngine.Vector3() {x = val_31.x, y = val_31.y, z = val_31.z}, t:  val_32 * (this.particleRotationSpeed * val_42));
                val_46 = val_35.z;
                UnityEngine.Vector3 val_36 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_35.x, y = val_35.y, z = val_35.z}, d:  val_18);
                UnityEngine.Vector3 val_37 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_36.x, y = val_36.y, z = val_36.z}, d:  val_32);
                UnityEngine.Vector3 val_38 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_7, y = val_21, z = val_22}, b:  new UnityEngine.Vector3() {x = val_37.x, y = val_37.y, z = val_37.z});
                val_45 = val_38.z;
                if(val_48 != false)
            {
                    val_49 = val_30 - val_42;
                val_7 = val_27;
                val_42 = val_25;
                this.spawnedParticles.set_Item(index:  val_41, value:  new ParticleInfo() {Position = new UnityEngine.Vector3() {x = val_38.x, y = val_38.y, z = val_45}, Direction = new UnityEngine.Vector3() {x = val_35.x, y = val_35.y, z = val_46}, HitPoints = val_42, Size = val_28, Dying = val_48, TimeToDelete = val_49});
            }
            else
            {
                    val_42 = val_25;
                UnityEngine.Vector3 val_39 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, b:  new UnityEngine.Vector3() {x = val_38.x, y = val_38.y, z = val_45});
                if(val_39.x > (val_42 * val_42))
            {
                    val_48 = 0;
            }
            else
            {
                    this.Character.IncreaseHealth(amount:  val_42);
                PlayRandomSound.PlaySoundGroup(group:  0, position:  new UnityEngine.Vector3() {x = val_38.x, y = val_38.y, z = val_45});
                val_48 = true;
            }
            
                val_49 = val_30;
            }
            
                val_44 = this.spawnedParticles;
                val_7 = val_27;
                val_44.set_Item(index:  val_41, value:  new ParticleInfo() {Position = new UnityEngine.Vector3() {x = val_38.x, y = val_38.y, z = val_45}, Direction = new UnityEngine.Vector3() {x = val_35.x, y = val_35.y, z = val_46}, HitPoints = val_42, Size = val_28, Dying = val_48, TimeToDelete = val_49});
                val_41 = val_41 - 1;
            }
            while((val_41 & 2147483648) == 0);
            
            goto label_33;
            label_10:
            label_33:
            this.simulateEffects(deltaTime:  val_42);
        }
        public override bool Validate()
        {
            if((this.Character.HasInfluenceOfType<TzarGames.Endless.HealthStealingInfluence>()) == true)
            {
                    return false;
            }
            
            if(this.influence == null)
            {
                    return false;
            }
            
            if(this.IsActive == false)
            {
                    return this.Validate();
            }
            
            return false;
        }
        protected override void OnStarted()
        {
            this.OnStarted();
            float val_2 = this.timeModificator.Value;
            TzarGames.Endless.HealthStealingInfluence val_3 = null;
            val_2 = this.time * val_2;
            val_3 = new TzarGames.Endless.HealthStealingInfluence(instigator:  this.Character, effectTime:  val_2);
            this.influence = val_3;
            this.Character.AddInfluence(influence:  this.influence);
            EmissionModule val_5 = this.bodyEffectInstance.emission;
            ParticleSystem.MinMaxCurve val_6 = ParticleSystem.MinMaxCurve.op_Implicit(constant:  30f);
            UnityEngine.Vector3 val_10 = this.Character.Position;
            PlayRandomSound.PlaySoundGroup(group:  0, position:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
            this.Finish();
        }
        protected override void OnStopped()
        {
            this.OnStopped();
        }
        public string GetUpgradeLabelWithBonus(float bonus)
        {
            var val_5;
            var val_6;
            if((TzarGames.Endless.EndlessUtils.FloatToPercent(val:  bonus)) > 0)
            {
                    val_5 = "+";
            }
            else
            {
                    val_6 = null;
                val_6 = null;
            }
            
            string val_2 = 0 + System.String.__il2cppRuntimeField_static_fields;
            return (string)System.String.Format(format:  0, arg0:  TzarGames.Common.LocalizedStringAsset.op_Implicit(text:  0));
        }
    
    }

}
