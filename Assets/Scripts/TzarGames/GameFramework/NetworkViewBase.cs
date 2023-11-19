using UnityEngine;

namespace TzarGames.GameFramework
{
    public abstract class NetworkViewBase : MonoBehaviour, IPoolable
    {
        // Fields
        protected System.Collections.Generic.List<TzarGames.GameFramework.ISerializeView> serializableComponents;
        
        // Properties
        public abstract bool HasUnassignedViewID { get; }
        public abstract TzarGames.GameFramework.NetworkViewID ViewID { get; }
        public abstract int Group { get; set; }
        
        // Methods
        protected NetworkViewBase()
        {
            this.serializableComponents = new System.Collections.Generic.List<TzarGames.GameFramework.ISerializeView>();
        }
        public abstract bool get_HasUnassignedViewID(); // 0
        public abstract TzarGames.GameFramework.NetworkViewID get_ViewID(); // 0
        public abstract void UnassignViewID(); // 0
        public abstract void SetViewID(TzarGames.GameFramework.NetworkViewID newId, TzarGames.GameFramework.NetworkPlayer player); // 0
        protected abstract void RPC(string rpcName, TzarGames.GameFramework.TzarRPCModes mode, object[] args); // 0
        protected abstract void RPC(string rpcName, TzarGames.GameFramework.NetworkPlayer player, object[] args); // 0
        protected abstract void UnreliableRPC(string rpcName, TzarGames.GameFramework.TzarRPCModes mode, object[] args); // 0
        protected abstract void UnreliableRPC(string rpcName, TzarGames.GameFramework.NetworkPlayer player, object[] args); // 0
        public abstract int get_Group(); // 0
        public abstract void set_Group(int value); // 0
        public void RegisterSerializableComponent(TzarGames.GameFramework.ISerializeView serializedComponent)
        {
            if((this.serializableComponents.Contains(item:  serializedComponent)) != false)
            {
                    return;
            }
            
            this.serializableComponents.Add(item:  serializedComponent);
        }
        public void UnregisterSerializableComponent(TzarGames.GameFramework.ISerializeView serializedComponent)
        {
            bool val_1 = this.serializableComponents.Remove(item:  serializedComponent);
        }
        public void RPC<A>(TzarGames.GameFramework.RPCall<A> methodDelegate, TzarGames.GameFramework.TzarRPCModes mode, object[] args)
        {
            System.Reflection.MethodInfo val_1 = methodDelegate.Method;
            System.Object[] val_2 = TzarGames.GameFramework.NetworkViewBase.checkArgs(args:  0, method:  args);
            if(this == null)
            {
                
            }
        
        }
        public void RPC<A, B>(TzarGames.GameFramework.RPCall<A, B> methodDelegate, TzarGames.GameFramework.TzarRPCModes mode, object[] args)
        {
            System.Reflection.MethodInfo val_1 = methodDelegate.Method;
            System.Object[] val_2 = TzarGames.GameFramework.NetworkViewBase.checkArgs(args:  0, method:  args);
            if(this == null)
            {
                
            }
        
        }
        public void RPC<A, B, C>(TzarGames.GameFramework.RPCall<A, B, C> methodDelegate, TzarGames.GameFramework.TzarRPCModes mode, object[] args)
        {
            System.Reflection.MethodInfo val_1 = methodDelegate.Method;
            System.Object[] val_2 = TzarGames.GameFramework.NetworkViewBase.checkArgs(args:  0, method:  args);
            if(this == null)
            {
                
            }
        
        }
        public void RPC<A, B, C, D>(TzarGames.GameFramework.RPCall<A, B, C, D> methodDelegate, TzarGames.GameFramework.TzarRPCModes mode, object[] args)
        {
            System.Reflection.MethodInfo val_1 = methodDelegate.Method;
            System.Object[] val_2 = TzarGames.GameFramework.NetworkViewBase.checkArgs(args:  0, method:  args);
            if(this == null)
            {
                
            }
        
        }
        public void RPC<A, B, C, D, E>(TzarGames.GameFramework.RPCall<A, B, C, D, E> methodDelegate, TzarGames.GameFramework.TzarRPCModes mode, object[] args)
        {
            System.Reflection.MethodInfo val_1 = methodDelegate.Method;
            System.Object[] val_2 = TzarGames.GameFramework.NetworkViewBase.checkArgs(args:  0, method:  args);
            if(this == null)
            {
                
            }
        
        }
        public void RPC<A, B, C, D, E, F>(TzarGames.GameFramework.RPCall<A, B, C, D, E, F> methodDelegate, TzarGames.GameFramework.TzarRPCModes mode, object[] args)
        {
            System.Reflection.MethodInfo val_1 = methodDelegate.Method;
            System.Object[] val_2 = TzarGames.GameFramework.NetworkViewBase.checkArgs(args:  0, method:  args);
            if(this == null)
            {
                
            }
        
        }
        public void RPC<A, B, C, D, E, F, G>(TzarGames.GameFramework.RPCall<A, B, C, D, E, F, G> methodDelegate, TzarGames.GameFramework.TzarRPCModes mode, object[] args)
        {
            System.Reflection.MethodInfo val_1 = methodDelegate.Method;
            System.Object[] val_2 = TzarGames.GameFramework.NetworkViewBase.checkArgs(args:  0, method:  args);
            if(this == null)
            {
                
            }
        
        }
        public void RPC<A, B, C, D, E, F, G, H>(TzarGames.GameFramework.RPCall<A, B, C, D, E, F, G, H> methodDelegate, TzarGames.GameFramework.TzarRPCModes mode, object[] args)
        {
            System.Reflection.MethodInfo val_1 = methodDelegate.Method;
            System.Object[] val_2 = TzarGames.GameFramework.NetworkViewBase.checkArgs(args:  0, method:  args);
            if(this == null)
            {
                
            }
        
        }
        public void RPC<A, B, C, D, E, F, G, H, I>(TzarGames.GameFramework.RPCall<A, B, C, D, E, F, G, H, I> methodDelegate, TzarGames.GameFramework.TzarRPCModes mode, object[] args)
        {
            System.Reflection.MethodInfo val_1 = methodDelegate.Method;
            System.Object[] val_2 = TzarGames.GameFramework.NetworkViewBase.checkArgs(args:  0, method:  args);
            if(this == null)
            {
                
            }
        
        }
        public void RPC<A, B, C, D, E, F, G, H, I, J>(TzarGames.GameFramework.RPCall<A, B, C, D, E, F, G, H, I, J> methodDelegate, TzarGames.GameFramework.TzarRPCModes mode, object[] args)
        {
            System.Reflection.MethodInfo val_1 = methodDelegate.Method;
            System.Object[] val_2 = TzarGames.GameFramework.NetworkViewBase.checkArgs(args:  0, method:  args);
            if(this == null)
            {
                
            }
        
        }
        public void RPC<A, B, C, D, E, F, G, H, I, J, K>(TzarGames.GameFramework.RPCall<A, B, C, D, E, F, G, H, I, J, K> methodDelegate, TzarGames.GameFramework.TzarRPCModes mode, object[] args)
        {
            System.Reflection.MethodInfo val_1 = methodDelegate.Method;
            System.Object[] val_2 = TzarGames.GameFramework.NetworkViewBase.checkArgs(args:  0, method:  args);
            if(this == null)
            {
                
            }
        
        }
        public void RPC<A>(TzarGames.GameFramework.RPCall<A> methodDelegate, TzarGames.GameFramework.NetworkPlayer player, object[] args)
        {
            System.Reflection.MethodInfo val_1 = methodDelegate.Method;
            System.Object[] val_2 = TzarGames.GameFramework.NetworkViewBase.checkArgs(args:  0, method:  args);
            if(this == null)
            {
                
            }
        
        }
        public void RPC<A, B>(TzarGames.GameFramework.RPCall<A, B> methodDelegate, TzarGames.GameFramework.NetworkPlayer player, object[] args)
        {
            System.Reflection.MethodInfo val_1 = methodDelegate.Method;
            System.Object[] val_2 = TzarGames.GameFramework.NetworkViewBase.checkArgs(args:  0, method:  args);
            if(this == null)
            {
                
            }
        
        }
        public void RPC<A, B, C>(TzarGames.GameFramework.RPCall<A, B, C> methodDelegate, TzarGames.GameFramework.NetworkPlayer player, object[] args)
        {
            System.Reflection.MethodInfo val_1 = methodDelegate.Method;
            System.Object[] val_2 = TzarGames.GameFramework.NetworkViewBase.checkArgs(args:  0, method:  args);
            if(this == null)
            {
                
            }
        
        }
        public void RPC<A, B, C, D>(TzarGames.GameFramework.RPCall<A, B, C, D> methodDelegate, TzarGames.GameFramework.NetworkPlayer player, object[] args)
        {
            System.Reflection.MethodInfo val_1 = methodDelegate.Method;
            System.Object[] val_2 = TzarGames.GameFramework.NetworkViewBase.checkArgs(args:  0, method:  args);
            if(this == null)
            {
                
            }
        
        }
        public void RPC<A, B, C, D, E>(TzarGames.GameFramework.RPCall<A, B, C, D, E> methodDelegate, TzarGames.GameFramework.NetworkPlayer player, object[] args)
        {
            System.Reflection.MethodInfo val_1 = methodDelegate.Method;
            System.Object[] val_2 = TzarGames.GameFramework.NetworkViewBase.checkArgs(args:  0, method:  args);
            if(this == null)
            {
                
            }
        
        }
        public void RPC<A, B, C, D, E, F>(TzarGames.GameFramework.RPCall<A, B, C, D, E, F> methodDelegate, TzarGames.GameFramework.NetworkPlayer player, object[] args)
        {
            System.Reflection.MethodInfo val_1 = methodDelegate.Method;
            System.Object[] val_2 = TzarGames.GameFramework.NetworkViewBase.checkArgs(args:  0, method:  args);
            if(this == null)
            {
                
            }
        
        }
        public void RPC<A, B, C, D, E, F, G>(TzarGames.GameFramework.RPCall<A, B, C, D, E, F, G> methodDelegate, TzarGames.GameFramework.NetworkPlayer player, object[] args)
        {
            System.Reflection.MethodInfo val_1 = methodDelegate.Method;
            System.Object[] val_2 = TzarGames.GameFramework.NetworkViewBase.checkArgs(args:  0, method:  args);
            if(this == null)
            {
                
            }
        
        }
        public void RPC<A, B, C, D, E, F, G, H>(TzarGames.GameFramework.RPCall<A, B, C, D, E, F, G, H> methodDelegate, TzarGames.GameFramework.NetworkPlayer player, object[] args)
        {
            System.Reflection.MethodInfo val_1 = methodDelegate.Method;
            System.Object[] val_2 = TzarGames.GameFramework.NetworkViewBase.checkArgs(args:  0, method:  args);
            if(this == null)
            {
                
            }
        
        }
        public void RPC<A, B, C, D, E, F, G, H, I>(TzarGames.GameFramework.RPCall<A, B, C, D, E, F, G, H, I> methodDelegate, TzarGames.GameFramework.NetworkPlayer player, object[] args)
        {
            System.Reflection.MethodInfo val_1 = methodDelegate.Method;
            System.Object[] val_2 = TzarGames.GameFramework.NetworkViewBase.checkArgs(args:  0, method:  args);
            if(this == null)
            {
                
            }
        
        }
        public void RPC<A, B, C, D, E, F, G, H, I, J>(TzarGames.GameFramework.RPCall<A, B, C, D, E, F, G, H, I, J> methodDelegate, TzarGames.GameFramework.NetworkPlayer player, object[] args)
        {
            System.Reflection.MethodInfo val_1 = methodDelegate.Method;
            System.Object[] val_2 = TzarGames.GameFramework.NetworkViewBase.checkArgs(args:  0, method:  args);
            if(this == null)
            {
                
            }
        
        }
        public void RPC<A, B, C, D, E, F, G, H, I, J, K>(TzarGames.GameFramework.RPCall<A, B, C, D, E, F, G, H, I, J, K> methodDelegate, TzarGames.GameFramework.NetworkPlayer player, object[] args)
        {
            System.Reflection.MethodInfo val_1 = methodDelegate.Method;
            System.Object[] val_2 = TzarGames.GameFramework.NetworkViewBase.checkArgs(args:  0, method:  args);
            if(this == null)
            {
                
            }
        
        }
        public void UnreliableRPC<A>(TzarGames.GameFramework.RPCall<A> methodDelegate, TzarGames.GameFramework.TzarRPCModes mode, object[] args)
        {
            System.Reflection.MethodInfo val_1 = methodDelegate.Method;
            System.Object[] val_2 = TzarGames.GameFramework.NetworkViewBase.checkArgs(args:  0, method:  args);
            if(this == null)
            {
                
            }
        
        }
        public void UnreliableRPC<A, B>(TzarGames.GameFramework.RPCall<A, B> methodDelegate, TzarGames.GameFramework.TzarRPCModes mode, object[] args)
        {
            System.Reflection.MethodInfo val_1 = methodDelegate.Method;
            System.Object[] val_2 = TzarGames.GameFramework.NetworkViewBase.checkArgs(args:  0, method:  args);
            if(this == null)
            {
                
            }
        
        }
        public void UnreliableRPC<A, B, C>(TzarGames.GameFramework.RPCall<A, B, C> methodDelegate, TzarGames.GameFramework.TzarRPCModes mode, object[] args)
        {
            System.Reflection.MethodInfo val_1 = methodDelegate.Method;
            System.Object[] val_2 = TzarGames.GameFramework.NetworkViewBase.checkArgs(args:  0, method:  args);
            if(this == null)
            {
                
            }
        
        }
        public void UnreliableRPC<A, B, C, D>(TzarGames.GameFramework.RPCall<A, B, C, D> methodDelegate, TzarGames.GameFramework.TzarRPCModes mode, object[] args)
        {
            System.Reflection.MethodInfo val_1 = methodDelegate.Method;
            System.Object[] val_2 = TzarGames.GameFramework.NetworkViewBase.checkArgs(args:  0, method:  args);
            if(this == null)
            {
                
            }
        
        }
        public void UnreliableRPC<A, B, C, D, E>(TzarGames.GameFramework.RPCall<A, B, C, D, E> methodDelegate, TzarGames.GameFramework.TzarRPCModes mode, object[] args)
        {
            System.Reflection.MethodInfo val_1 = methodDelegate.Method;
            System.Object[] val_2 = TzarGames.GameFramework.NetworkViewBase.checkArgs(args:  0, method:  args);
            if(this == null)
            {
                
            }
        
        }
        public void UnreliableRPC<A, B, C, D, E, F>(TzarGames.GameFramework.RPCall<A, B, C, D, E, F> methodDelegate, TzarGames.GameFramework.TzarRPCModes mode, object[] args)
        {
            System.Reflection.MethodInfo val_1 = methodDelegate.Method;
            System.Object[] val_2 = TzarGames.GameFramework.NetworkViewBase.checkArgs(args:  0, method:  args);
            if(this == null)
            {
                
            }
        
        }
        public void UnreliableRPC<A, B, C, D, E, F, G>(TzarGames.GameFramework.RPCall<A, B, C, D, E, F, G> methodDelegate, TzarGames.GameFramework.TzarRPCModes mode, object[] args)
        {
            System.Reflection.MethodInfo val_1 = methodDelegate.Method;
            System.Object[] val_2 = TzarGames.GameFramework.NetworkViewBase.checkArgs(args:  0, method:  args);
            if(this == null)
            {
                
            }
        
        }
        public void UnreliableRPC<A, B, C, D, E, F, G, H>(TzarGames.GameFramework.RPCall<A, B, C, D, E, F, G, H> methodDelegate, TzarGames.GameFramework.TzarRPCModes mode, object[] args)
        {
            System.Reflection.MethodInfo val_1 = methodDelegate.Method;
            System.Object[] val_2 = TzarGames.GameFramework.NetworkViewBase.checkArgs(args:  0, method:  args);
            if(this == null)
            {
                
            }
        
        }
        public void UnreliableRPC<A, B, C, D, E, F, G, H, I>(TzarGames.GameFramework.RPCall<A, B, C, D, E, F, G, H, I> methodDelegate, TzarGames.GameFramework.TzarRPCModes mode, object[] args)
        {
            System.Reflection.MethodInfo val_1 = methodDelegate.Method;
            System.Object[] val_2 = TzarGames.GameFramework.NetworkViewBase.checkArgs(args:  0, method:  args);
            if(this == null)
            {
                
            }
        
        }
        public void UnreliableRPC<A, B, C, D, E, F, G, H, I, J>(TzarGames.GameFramework.RPCall<A, B, C, D, E, F, G, H, I, J> methodDelegate, TzarGames.GameFramework.TzarRPCModes mode, object[] args)
        {
            System.Reflection.MethodInfo val_1 = methodDelegate.Method;
            System.Object[] val_2 = TzarGames.GameFramework.NetworkViewBase.checkArgs(args:  0, method:  args);
            if(this == null)
            {
                
            }
        
        }
        public void UnreliableRPC<A, B, C, D, E, F, G, H, I, J, K>(TzarGames.GameFramework.RPCall<A, B, C, D, E, F, G, H, I, J, K> methodDelegate, TzarGames.GameFramework.TzarRPCModes mode, object[] args)
        {
            System.Reflection.MethodInfo val_1 = methodDelegate.Method;
            System.Object[] val_2 = TzarGames.GameFramework.NetworkViewBase.checkArgs(args:  0, method:  args);
            if(this == null)
            {
                
            }
        
        }
        public void UnreliableRPC<A>(TzarGames.GameFramework.RPCall<A> methodDelegate, TzarGames.GameFramework.NetworkPlayer player, object[] args)
        {
            System.Reflection.MethodInfo val_1 = methodDelegate.Method;
            System.Object[] val_2 = TzarGames.GameFramework.NetworkViewBase.checkArgs(args:  0, method:  args);
            if(this == null)
            {
                
            }
        
        }
        public void UnreliableRPC<A, B>(TzarGames.GameFramework.RPCall<A, B> methodDelegate, TzarGames.GameFramework.NetworkPlayer player, object[] args)
        {
            System.Reflection.MethodInfo val_1 = methodDelegate.Method;
            System.Object[] val_2 = TzarGames.GameFramework.NetworkViewBase.checkArgs(args:  0, method:  args);
            if(this == null)
            {
                
            }
        
        }
        public void UnreliableRPC<A, B, C>(TzarGames.GameFramework.RPCall<A, B, C> methodDelegate, TzarGames.GameFramework.NetworkPlayer player, object[] args)
        {
            System.Reflection.MethodInfo val_1 = methodDelegate.Method;
            System.Object[] val_2 = TzarGames.GameFramework.NetworkViewBase.checkArgs(args:  0, method:  args);
            if(this == null)
            {
                
            }
        
        }
        public void UnreliableRPC<A, B, C, D>(TzarGames.GameFramework.RPCall<A, B, C, D> methodDelegate, TzarGames.GameFramework.NetworkPlayer player, object[] args)
        {
            System.Reflection.MethodInfo val_1 = methodDelegate.Method;
            System.Object[] val_2 = TzarGames.GameFramework.NetworkViewBase.checkArgs(args:  0, method:  args);
            if(this == null)
            {
                
            }
        
        }
        public void UnreliableRPC<A, B, C, D, E>(TzarGames.GameFramework.RPCall<A, B, C, D, E> methodDelegate, TzarGames.GameFramework.NetworkPlayer player, object[] args)
        {
            System.Reflection.MethodInfo val_1 = methodDelegate.Method;
            System.Object[] val_2 = TzarGames.GameFramework.NetworkViewBase.checkArgs(args:  0, method:  args);
            if(this == null)
            {
                
            }
        
        }
        public void UnreliableRPC<A, B, C, D, E, F>(TzarGames.GameFramework.RPCall<A, B, C, D, E, F> methodDelegate, TzarGames.GameFramework.NetworkPlayer player, object[] args)
        {
            System.Reflection.MethodInfo val_1 = methodDelegate.Method;
            System.Object[] val_2 = TzarGames.GameFramework.NetworkViewBase.checkArgs(args:  0, method:  args);
            if(this == null)
            {
                
            }
        
        }
        public void UnreliableRPC<A, B, C, D, E, F, G>(TzarGames.GameFramework.RPCall<A, B, C, D, E, F, G> methodDelegate, TzarGames.GameFramework.NetworkPlayer player, object[] args)
        {
            System.Reflection.MethodInfo val_1 = methodDelegate.Method;
            System.Object[] val_2 = TzarGames.GameFramework.NetworkViewBase.checkArgs(args:  0, method:  args);
            if(this == null)
            {
                
            }
        
        }
        public void UnreliableRPC<A, B, C, D, E, F, G, H>(TzarGames.GameFramework.RPCall<A, B, C, D, E, F, G, H> methodDelegate, TzarGames.GameFramework.NetworkPlayer player, object[] args)
        {
            System.Reflection.MethodInfo val_1 = methodDelegate.Method;
            System.Object[] val_2 = TzarGames.GameFramework.NetworkViewBase.checkArgs(args:  0, method:  args);
            if(this == null)
            {
                
            }
        
        }
        public void UnreliableRPC<A, B, C, D, E, F, G, H, I>(TzarGames.GameFramework.RPCall<A, B, C, D, E, F, G, H, I> methodDelegate, TzarGames.GameFramework.NetworkPlayer player, object[] args)
        {
            System.Reflection.MethodInfo val_1 = methodDelegate.Method;
            System.Object[] val_2 = TzarGames.GameFramework.NetworkViewBase.checkArgs(args:  0, method:  args);
            if(this == null)
            {
                
            }
        
        }
        public void UnreliableRPC<A, B, C, D, E, F, G, H, I, J>(TzarGames.GameFramework.RPCall<A, B, C, D, E, F, G, H, I, J> methodDelegate, TzarGames.GameFramework.NetworkPlayer player, object[] args)
        {
            System.Reflection.MethodInfo val_1 = methodDelegate.Method;
            System.Object[] val_2 = TzarGames.GameFramework.NetworkViewBase.checkArgs(args:  0, method:  args);
            if(this == null)
            {
                
            }
        
        }
        public void UnreliableRPC<A, B, C, D, E, F, G, H, I, J, K>(TzarGames.GameFramework.RPCall<A, B, C, D, E, F, G, H, I, J, K> methodDelegate, TzarGames.GameFramework.NetworkPlayer player, object[] args)
        {
            System.Reflection.MethodInfo val_1 = methodDelegate.Method;
            System.Object[] val_2 = TzarGames.GameFramework.NetworkViewBase.checkArgs(args:  0, method:  args);
            if(this == null)
            {
                
            }
        
        }
        public void RPC(System.Delegate methodDelegate, TzarGames.GameFramework.TzarRPCModes mode, object[] args)
        {
            System.Object[] val_2 = TzarGames.GameFramework.NetworkViewBase.checkArgs(args:  methodDelegate.Method, method:  args);
            goto typeof(TzarGames.GameFramework.NetworkViewBase).__il2cppRuntimeField_1B0;
        }
        public void RPC(System.Delegate methodDelegate, TzarGames.GameFramework.NetworkPlayer player, object[] args)
        {
            System.Object[] val_2 = TzarGames.GameFramework.NetworkViewBase.checkArgs(args:  methodDelegate.Method, method:  args);
            goto typeof(TzarGames.GameFramework.NetworkViewBase).__il2cppRuntimeField_1C0;
        }
        public void RPC(System.Action methodDelegate, TzarGames.GameFramework.TzarRPCModes mode, object[] args)
        {
            System.Object[] val_2 = TzarGames.GameFramework.NetworkViewBase.checkArgs(args:  methodDelegate.Method, method:  args);
            goto typeof(TzarGames.GameFramework.NetworkViewBase).__il2cppRuntimeField_1B0;
        }
        public void RPC(System.Action methodDelegate, TzarGames.GameFramework.NetworkPlayer player, object[] args)
        {
            System.Object[] val_2 = TzarGames.GameFramework.NetworkViewBase.checkArgs(args:  methodDelegate.Method, method:  args);
            goto typeof(TzarGames.GameFramework.NetworkViewBase).__il2cppRuntimeField_1C0;
        }
        public void UnreliableRPC(System.Delegate methodDelegate, TzarGames.GameFramework.TzarRPCModes mode, object[] args)
        {
            System.Object[] val_2 = TzarGames.GameFramework.NetworkViewBase.checkArgs(args:  methodDelegate.Method, method:  args);
            goto typeof(TzarGames.GameFramework.NetworkViewBase).__il2cppRuntimeField_1D0;
        }
        public void UnreliableRPC(System.Delegate methodDelegate, TzarGames.GameFramework.NetworkPlayer player, object[] args)
        {
            System.Object[] val_2 = TzarGames.GameFramework.NetworkViewBase.checkArgs(args:  methodDelegate.Method, method:  args);
            goto typeof(TzarGames.GameFramework.NetworkViewBase).__il2cppRuntimeField_1E0;
        }
        public void UnreliableRPC(System.Action methodDelegate, TzarGames.GameFramework.TzarRPCModes mode, object[] args)
        {
            System.Object[] val_2 = TzarGames.GameFramework.NetworkViewBase.checkArgs(args:  methodDelegate.Method, method:  args);
            goto typeof(TzarGames.GameFramework.NetworkViewBase).__il2cppRuntimeField_1D0;
        }
        public void UnreliableRPC(System.Action methodDelegate, TzarGames.GameFramework.NetworkPlayer player, object[] args)
        {
            System.Object[] val_2 = TzarGames.GameFramework.NetworkViewBase.checkArgs(args:  methodDelegate.Method, method:  args);
            goto typeof(TzarGames.GameFramework.NetworkViewBase).__il2cppRuntimeField_1E0;
        }
        private static object[] checkArgs(object[] args, System.Delegate method)
        {
            var val_12;
            System.Delegate val_13;
            var val_14;
            val_13 = method;
            System.Reflection.MethodInfo val_1 = X2.Method;
            if(null < 1)
            {
                    return (System.Object[])val_13;
            }
            
            var val_12 = -4294967296;
            val_12 = val_12 + 91936764268118016;
            if((val_12 >> 32) >= null)
            {
                    val_14 = 0;
            }
            
            System.Reflection.MethodInfo val_3 = val_1 + ((((-4294967296 + 91936764268118016) >> 32)) << 3);
            val_12 = null;
            if(val_1 != (System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())))
            {
                    return (System.Object[])val_13;
            }
            
            IntPtr val_5 = method.invoke_impl + 1;
            System.Array.Resize<System.String>(array: ref  0, newSize:  -1782541752);
            TzarGames.GameFramework.Player val_10 = TzarGames.GameFramework.GameManager.Instance.LocalPlayer;
            var val_13 = -4294967296;
            val_13 = val_13 + ((method + 24) << 32);
            val_12 = val_13 >> 32;
            System.Delegate val_11 = val_13 + ((((-4294967296 + (method + 24) << 32) >> 32)) << 3);
            mem2[0] = TzarGames.GameFramework.GameManager.Instance.Net;
            val_13 = val_13;
            return (System.Object[])val_13;
        }
        public virtual void OnPushedToPool()
        {
            if((0 & 1) == 0)
            {
                goto typeof(TzarGames.GameFramework.NetworkViewBase).__il2cppRuntimeField_190;
            }
        
        }
        public virtual void OnPulledFromPool()
        {
        
        }
    
    }

}
