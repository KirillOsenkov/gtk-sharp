// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GtkSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
	internal delegate bool AccelGroupActivateNative(IntPtr accel_group, IntPtr acceleratable, uint keyval, int modifier);

	internal class AccelGroupActivateWrapper {

		public bool NativeCallback (IntPtr accel_group, IntPtr acceleratable, uint keyval, int modifier)
		{
			try {
				bool __ret = managed (GLib.Object.GetObject(accel_group) as Gtk.AccelGroup, GLib.Object.GetObject (acceleratable), keyval, (Gdk.ModifierType) modifier);
				return __ret;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
				return false;
			}
		}


		internal readonly AccelGroupActivateNative NativeDelegate;
		Gtk.AccelGroupActivate managed;

		public AccelGroupActivateWrapper (Gtk.AccelGroupActivate managed)
		{
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new AccelGroupActivateNative (NativeCallback);
		}

	}
#endregion
}
