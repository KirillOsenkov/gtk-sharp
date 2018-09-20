// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GtkSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
	internal delegate bool TextCharPredicateNative(uint ch, IntPtr user_data);

	internal static class TextCharPredicateWrapper {

		public static bool NativeCallback (uint ch, IntPtr user_data)
		{
			try {
				var gch = (GCHandle)user_data;
				var managed = (Gtk.TextCharPredicate)gch.Target;
				bool __ret = managed (GLib.Marshaller.GUnicharToChar (ch));
				return __ret;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
				return false;
			}
		}


		internal static readonly TextCharPredicateNative NativeDelegate = new TextCharPredicateNative (NativeCallback);
	}
#endregion
}
