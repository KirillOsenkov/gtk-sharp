// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GtkSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
	internal delegate IntPtr TranslateFuncNative(IntPtr path, IntPtr func_data);

	internal static class TranslateFuncWrapper {

		public static IntPtr NativeCallback (IntPtr path, IntPtr func_data)
		{
			try {
				var gch = (GCHandle)func_data;
				var managed = (Gtk.TranslateFunc)gch.Target;
				string __ret = managed (GLib.Marshaller.Utf8PtrToString (path));
				return GLib.Marshaller.StringToPtrGStrdup(__ret);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: Above call does not return.
				throw e;
			}
		}


		internal static readonly TranslateFuncNative NativeDelegate = new TranslateFuncNative (NativeCallback);
	}
#endregion
}
