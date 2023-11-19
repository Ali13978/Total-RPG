using UnityEngine;

namespace TzarGames.GameFramework.NetworkSubsystem_Photon
{
    internal class PhotonBitStream : _IBitStream
    {
        // Fields
        private PhotonStream _stream;
        
        // Properties
        public bool IsWriting { get; }
        
        // Methods
        public PhotonBitStream(PhotonStream stream)
        {
            this._stream = stream;
        }
        public PhotonStream GetNativeBitstream()
        {
            return (PhotonStream)this._stream;
        }
        public bool get_IsWriting()
        {
            if(this._stream != null)
            {
                    return this._stream.isWriting;
            }
            
            return this._stream.isWriting;
        }
        public T Read<T>()
        {
            var val_3;
            object val_1 = this._stream.ReceiveNext();
            val_3 = 0;
            if(val_1 == null)
            {
                    return (object)val_3;
            }
            
            val_3 = val_1;
            if(val_3 != null)
            {
                    return (object)val_3;
            }
            
            val_3 = 0;
            return (object)val_3;
        }
        public void Write(float val)
        {
            this._stream.Serialize(obj: ref  float val_1 = 2.973339E+38f);
        }
        public void Write(UnityEngine.Quaternion val)
        {
            this._stream.Serialize(obj: ref  new UnityEngine.Quaternion() {x = val.x, y = val.y, z = val.z, w = val.w});
        }
        public void Write(UnityEngine.Vector3 val)
        {
            this._stream.Serialize(obj: ref  new UnityEngine.Vector3() {x = val.x, y = val.y, z = val.z});
        }
        public void Write(int val)
        {
            this._stream.Serialize(myInt: ref  val);
        }
        public void Write(string val)
        {
            this._stream.Serialize(value: ref  val);
        }
        public void Write(short val)
        {
            this._stream.Serialize(value: ref  val);
        }
    
    }

}
