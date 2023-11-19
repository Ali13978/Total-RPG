using UnityEngine;

namespace GooglePlayGames.Native.PInvoke
{
    internal class NativeEvent : BaseReferenceHolder, IEvent
    {
        // Properties
        public string Id { get; }
        public string Name { get; }
        public string Description { get; }
        public string ImageUrl { get; }
        public ulong CurrentCount { get; }
        public GooglePlayGames.BasicApi.Events.EventVisibility Visibility { get; }
        
        // Methods
        internal NativeEvent(IntPtr selfPointer)
        {
        
        }
        public string get_Id()
        {
            PInvokeUtilities.OutStringMethod val_1 = new PInvokeUtilities.OutStringMethod(object:  this, method:  System.UIntPtr GooglePlayGames.Native.PInvoke.NativeEvent::<get_Id>m__0(byte[] out_string, UIntPtr out_size));
            return GooglePlayGames.Native.PInvoke.PInvokeUtilities.OutParamsToString(outStringMethod:  0);
        }
        public string get_Name()
        {
            PInvokeUtilities.OutStringMethod val_1 = new PInvokeUtilities.OutStringMethod(object:  this, method:  System.UIntPtr GooglePlayGames.Native.PInvoke.NativeEvent::<get_Name>m__1(byte[] out_string, UIntPtr out_size));
            return GooglePlayGames.Native.PInvoke.PInvokeUtilities.OutParamsToString(outStringMethod:  0);
        }
        public string get_Description()
        {
            PInvokeUtilities.OutStringMethod val_1 = new PInvokeUtilities.OutStringMethod(object:  this, method:  System.UIntPtr GooglePlayGames.Native.PInvoke.NativeEvent::<get_Description>m__2(byte[] out_string, UIntPtr out_size));
            return GooglePlayGames.Native.PInvoke.PInvokeUtilities.OutParamsToString(outStringMethod:  0);
        }
        public string get_ImageUrl()
        {
            PInvokeUtilities.OutStringMethod val_1 = new PInvokeUtilities.OutStringMethod(object:  this, method:  System.UIntPtr GooglePlayGames.Native.PInvoke.NativeEvent::<get_ImageUrl>m__3(byte[] out_string, UIntPtr out_size));
            return GooglePlayGames.Native.PInvoke.PInvokeUtilities.OutParamsToString(outStringMethod:  0);
        }
        public ulong get_CurrentCount()
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.Event.Event_Count(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
        }
        public GooglePlayGames.BasicApi.Events.EventVisibility get_Visibility()
        {
            var val_5;
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            EventVisibility val_2 = GooglePlayGames.Native.Cwrapper.Event.Event_Visibility(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper});
            if(val_2 == 1)
            {
                    val_5 = 1;
                return (GooglePlayGames.BasicApi.Events.EventVisibility)val_5;
            }
            
            if(val_2 == 2)
            {
                    val_5 = 2;
                return (GooglePlayGames.BasicApi.Events.EventVisibility)val_5;
            }
            
            System.InvalidOperationException val_4 = new System.InvalidOperationException(message:  0 + "Unknown visibility: "("Unknown visibility: "));
        }
        protected override void CallDispose(System.Runtime.InteropServices.HandleRef selfPointer)
        {
            GooglePlayGames.Native.Cwrapper.Event.Event_Dispose(self:  new System.Runtime.InteropServices.HandleRef() {handle = selfPointer.wrapper});
        }
        public override string ToString()
        {
            var val_10;
            var val_11;
            if(this.IsDisposed() != false)
            {
                    val_11 = "[NativeEvent: DELETED]";
                return (string)System.String.Format(format:  0, args:  "[NativeEvent: Id={0}, Name={1}, Description={2}, ImageUrl={3}, CurrentCount={4}, Visibility={5}]");
            }
            
            val_10 = null;
            typeof(System.Object[]).__il2cppRuntimeField_20 = this.Id;
            typeof(System.Object[]).__il2cppRuntimeField_28 = this.Name;
            typeof(System.Object[]).__il2cppRuntimeField_30 = this.Description;
            typeof(System.Object[]).__il2cppRuntimeField_38 = this.ImageUrl;
            System.Runtime.InteropServices.HandleRef val_6 = this.SelfPtr();
            typeof(System.Object[]).__il2cppRuntimeField_40 = GooglePlayGames.Native.Cwrapper.Event.Event_Count(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_6.wrapper});
            typeof(System.Object[]).__il2cppRuntimeField_48 = this.Visibility;
            return (string)System.String.Format(format:  0, args:  "[NativeEvent: Id={0}, Name={1}, Description={2}, ImageUrl={3}, CurrentCount={4}, Visibility={5}]");
        }
        private UIntPtr <get_Id>m__0(byte[] out_string, UIntPtr out_size)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.Event.Event_Id(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, out_arg:  val_1.handle, out_size:  out_string);
        }
        private UIntPtr <get_Name>m__1(byte[] out_string, UIntPtr out_size)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.Event.Event_Name(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, out_arg:  val_1.handle, out_size:  out_string);
        }
        private UIntPtr <get_Description>m__2(byte[] out_string, UIntPtr out_size)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.Event.Event_Description(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, out_arg:  val_1.handle, out_size:  out_string);
        }
        private UIntPtr <get_ImageUrl>m__3(byte[] out_string, UIntPtr out_size)
        {
            System.Runtime.InteropServices.HandleRef val_1 = this.SelfPtr();
            return GooglePlayGames.Native.Cwrapper.Event.Event_ImageUrl(self:  new System.Runtime.InteropServices.HandleRef() {handle = val_1.wrapper}, out_arg:  val_1.handle, out_size:  out_string);
        }
    
    }

}
