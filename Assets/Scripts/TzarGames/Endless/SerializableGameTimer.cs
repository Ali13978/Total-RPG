using UnityEngine;

namespace TzarGames.Endless
{
    public class SerializableGameTimer
    {
        // Fields
        private const string time_key_const = "_TIME";
        private const string elapsed_time_key_const = "_ELAPSED_TIME";
        private string time_key;
        private string elapsed_time_key;
        [System.Diagnostics.DebuggerBrowsableAttribute]
        private System.Action<TzarGames.Endless.SerializableGameTimer> OnExpired;
        private TzarGames.Common.SerializableData _data;
        private float _startTime;
        private float _elapsedTime;
        private float _time;
        public TzarGames.GameFramework.CharacteristicModificator _modificator;
        private float _gameTime;
        private bool stopped;
        
        // Properties
        public bool IsStopped { get; }
        public float NormalizedTime { get; }
        
        // Methods
        public SerializableGameTimer(string serializationPrefix, TzarGames.Common.SerializableData data)
        {
            this.stopped = true;
            val_1 = new System.Object();
            this.updateKeys(serializationPrefix:  serializationPrefix);
            this._data = val_1;
        }
        public void add_OnExpired(System.Action<TzarGames.Endless.SerializableGameTimer> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Combine(a:  0, b:  this.OnExpired);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921510565447120 != this.OnExpired);
        
        }
        public void remove_OnExpired(System.Action<TzarGames.Endless.SerializableGameTimer> value)
        {
            var val_3;
            do
            {
                System.Delegate val_1 = System.Delegate.Remove(source:  0, value:  this.OnExpired);
                val_3 = 0;
                if(val_1 != null)
            {
                    val_3 = val_1;
                if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
            }
            while(1152921510565583696 != this.OnExpired);
        
        }
        public bool get_IsStopped()
        {
            return (bool)this.stopped;
        }
        public float get_NormalizedTime()
        {
            float val_1 = this._gameTime - this._startTime;
            val_1 = val_1 + this._elapsedTime;
            val_1 = val_1 / this._time;
            return UnityEngine.Mathf.Clamp01(value:  val_1);
        }
        public bool Continue(float gameTime)
        {
            string val_5;
            float val_7;
            var val_8;
            val_5 = this.time_key;
            this._gameTime = gameTime;
            if((this._data.HasFloat(id:  val_5)) != false)
            {
                    float val_2 = this._data.GetFloat(id:  this.time_key);
                val_5 = this.elapsed_time_key;
                if((this._data.HasFloat(id:  val_5)) != false)
            {
                    val_5 = this.elapsed_time_key;
                val_7 = this._data.GetFloat(id:  val_5);
            }
            else
            {
                    val_7 = 0f;
            }
            
                if(val_7 < val_2)
            {
                    this.StartTimer(time:  val_2, gameTime:  gameTime, elapsedTime:  val_7);
                val_8 = 1;
                return (bool)val_8;
            }
            
                this.removeData(data:  this._data);
            }
            
            val_8 = 0;
            return (bool)val_8;
        }
        public bool WasStartedBefore()
        {
            if(this._data != null)
            {
                    return this._data.HasFloat(id:  this.time_key);
            }
            
            return this._data.HasFloat(id:  this.time_key);
        }
        public static bool TimerWasStarted(string serializationPrefix, TzarGames.Common.SerializableData data)
        {
            if(X2 != 0)
            {
                    return X2.HasFloat(id:  0 + data);
            }
            
            return X2.HasFloat(id:  0 + data);
        }
        private void removeData(TzarGames.Common.SerializableData data)
        {
            string val_1;
            if(data != null)
            {
                    data.DeleteFloat(id:  this.elapsed_time_key);
                val_1 = this.time_key;
            }
            else
            {
                    0.DeleteFloat(id:  this.elapsed_time_key);
                val_1 = this.time_key;
            }
            
            data.DeleteFloat(id:  val_1);
        }
        public void PauseTimer()
        {
            string val_3 = this.time_key;
            if((this._data.HasFloat(id:  val_3 = this.time_key)) == false)
            {
                    return;
            }
            
            val_3 = this.time_key;
            float val_3 = this._gameTime;
            val_3 = val_3 - this._startTime;
            val_3 = val_3 + this._elapsedTime;
            if(val_3 < (this._data.GetFloat(id:  val_3)))
            {
                    return;
            }
            
            this.handleExpiration();
        }
        public void SerializeElapsedTime()
        {
            float val_2 = this._gameTime;
            val_2 = (val_2 - this._startTime) + this._elapsedTime;
            this._data.SetFloat(id:  this.elapsed_time_key, val:  val_2);
        }
        public void Update(float gameTime)
        {
            this._gameTime = gameTime;
            if(this.stopped == true)
            {
                    return;
            }
            
            gameTime = gameTime - this._startTime;
            gameTime = gameTime + this._elapsedTime;
            if(gameTime < this._time)
            {
                    return;
            }
            
            this.handleExpiration();
        }
        private void handleExpiration()
        {
            this.stopped = true;
            this.removeData(data:  this._data);
            if(this.OnExpired == null)
            {
                    return;
            }
            
            this.OnExpired.Invoke(obj:  this);
        }
        public void StartTimer(float time, float gameTime)
        {
            this.StartTimer(time:  time, gameTime:  gameTime, elapsedTime:  0f);
        }
        private void updateKeys(string serializationPrefix)
        {
            this.time_key = 0 + serializationPrefix;
            this.elapsed_time_key = 0 + serializationPrefix;
        }
        private void StartTimer(float time, float gameTime, float elapsedTime)
        {
            this._gameTime = gameTime;
            this._data.SetFloat(id:  this.time_key, val:  time);
            this._data.SetFloat(id:  this.elapsed_time_key, val:  elapsedTime);
            this.stopped = false;
            this._elapsedTime = elapsedTime;
            this._time = time;
            this._startTime = this._gameTime;
        }
    
    }

}
