// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GdkSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
	internal delegate void DestroyNotifyNative(IntPtr data);

	internal static class DestroyNotifyWrapper {

		public static void NativeCallback (IntPtr data)
		{
			try {
				var gch = (GCHandle)data;
				var managed = (Gdk.DestroyNotify)gch.Target;
				managed ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}


		internal static readonly DestroyNotifyNative NativeDelegate = new DestroyNotifyNative (NativeCallback);
	}
#endregion
}
