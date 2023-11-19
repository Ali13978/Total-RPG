using UnityEngine;

namespace TzarGames.Endless
{
    public abstract class CharacterSerializableTimer
    {
        // Fields
        private TzarGames.Endless.SerializableGameTimer _timer;
        private TzarGames.Common.SerializableData _data;
        private TzarGames.GameFramework.CharacteristicModificator _modificator;
        private TzarGames.TzarHero.TH_Character _character;
        private float _gameTime;
        
        // Properties
        protected TzarGames.Common.SerializableData Data { get; }
        protected float GameTime { get; }
        protected TzarGames.TzarHero.TH_Character Character { get; }
        public bool IsStopped { get; }
        public float NormalizedTime { get; }
        
        // Methods
        public CharacterSerializableTimer(TzarGames.TzarHero.TH_Character character, TzarGames.Common.SerializableData data)
        {
            val_1 = new System.Object();
            this._character = character;
            this._data = val_1;
            character.add_OnComponentDestroy(value:  new TzarGames.GameFramework.dlgTzarDestroy(object:  this, method:  System.Void TzarGames.Endless.CharacterSerializableTimer::Character_OnComponentDestroy(TzarGames.GameFramework.TzarBehaviour behaviour)));
        }
        protected abstract string GetPrefixSerializationKey(); // 0
        protected abstract void ReadSerializedData(TzarGames.Common.IReadableData data); // 0
        protected abstract void RemoveSerializedData(TzarGames.Common.SerializableData data); // 0
        protected abstract void OnTimerExpired(); // 0
        protected abstract void OnStart(); // 0
        protected TzarGames.Common.SerializableData get_Data()
        {
            return (TzarGames.Common.SerializableData)this._data;
        }
        protected float get_GameTime()
        {
            return (float)this._gameTime;
        }
        protected TzarGames.TzarHero.TH_Character get_Character()
        {
            return (TzarGames.TzarHero.TH_Character)this._character;
        }
        public bool get_IsStopped()
        {
            if(this._timer == null)
            {
                    return true;
            }
            
            return this._timer.IsStopped;
        }
        public float get_NormalizedTime()
        {
            if(this._timer == null)
            {
                    return 0f;
            }
            
            return this._timer.NormalizedTime;
        }
        public void Continue(float gameTime)
        {
            this._gameTime = gameTime;
            if((TzarGames.Endless.SerializableGameTimer.TimerWasStarted(serializationPrefix:  0, data:  this)) == false)
            {
                    return;
            }
            
            this.start(time:  0f, gameTime:  gameTime, continueTimer:  true);
        }
        private void Character_OnComponentDestroy(TzarGames.GameFramework.TzarBehaviour behaviour)
        {
            behaviour.remove_OnComponentDestroy(value:  new TzarGames.GameFramework.dlgTzarDestroy(object:  this, method:  System.Void TzarGames.Endless.CharacterSerializableTimer::Character_OnComponentDestroy(TzarGames.GameFramework.TzarBehaviour behaviour)));
            if(this._timer == null)
            {
                    return;
            }
            
            this._timer.PauseTimer();
        }
        public void SerializeElapsedTime()
        {
            if(this._timer == null)
            {
                    return;
            }
            
            this._timer.SerializeElapsedTime();
        }
        public void StopAndSerialize()
        {
            if(this._timer == null)
            {
                    return;
            }
            
            this._timer.PauseTimer();
        }
        public void Start(float time, float gameTime)
        {
            this.start(time:  time, gameTime:  gameTime, continueTimer:  false);
        }
        private void start(float time, float gameTime, bool continueTimer)
        {
            TzarGames.Endless.SerializableGameTimer val_6 = this._timer;
            if(val_6 == null)
            {
                    TzarGames.Endless.SerializableGameTimer val_1 = null;
                val_6 = val_1;
                val_1 = new TzarGames.Endless.SerializableGameTimer(serializationPrefix:  this, data:  this._data);
                add_OnExpired(value:  new System.Action<TzarGames.Endless.SerializableGameTimer>(object:  this, method:  System.Void TzarGames.Endless.CharacterSerializableTimer::<start>m__0(TzarGames.Endless.SerializableGameTimer gameTimer)));
                this._timer = val_6;
            }
            
            if(continueTimer == false)
            {
                goto label_3;
            }
            
            if((Continue(gameTime:  this._gameTime)) == false)
            {
                goto label_5;
            }
            
            return;
            label_3:
            StartTimer(time:  time, gameTime:  gameTime);
            return;
            label_5:
            string val_5 = 0 + "Failed to start timer for ";
            UnityEngine.Debug.LogError(message:  0);
        }
        public void Update(float gameTime)
        {
            if(this._timer == null)
            {
                    return;
            }
            
            this._timer.Update(gameTime:  gameTime);
        }
        private void <start>m__0(TzarGames.Endless.SerializableGameTimer gameTimer)
        {
            goto typeof(TzarGames.Endless.CharacterSerializableTimer).__il2cppRuntimeField_170;
        }
    
    }

}
