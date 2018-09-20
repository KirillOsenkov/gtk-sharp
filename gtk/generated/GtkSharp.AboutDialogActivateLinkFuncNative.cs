// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GtkSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
	internal delegate void AboutDialogActivateLinkFuncNative(IntPtr about, IntPtr link_, IntPtr data);

	internal class AboutDialogActivateLinkFuncInvoker {

		AboutDialogActivateLinkFuncNative native_cb;
		IntPtr __data;
		GLib.DestroyNotify __notify;

		~AboutDialogActivateLinkFuncInvoker ()
		{
			if (__notify == null)
				return;
			__notify (__data);
		}

		internal AboutDialogActivateLinkFuncInvoker (AboutDialogActivateLinkFuncNative native_cb) : this (native_cb, IntPtr.Zero, null) {}

		internal AboutDialogActivateLinkFuncInvoker (AboutDialogActivateLinkFuncNative native_cb, IntPtr data) : this (native_cb, data, null) {}

		internal AboutDialogActivateLinkFuncInvoker (AboutDialogActivateLinkFuncNative native_cb, IntPtr data, GLib.DestroyNotify notify)
		{
			this.native_cb = native_cb;
			__data = data;
			__notify = notify;
		}

		internal Gtk.AboutDialogActivateLinkFunc Handler {
			get {
				return new Gtk.AboutDialogActivateLinkFunc(InvokeNative);
			}
		}

		void InvokeNative (Gtk.AboutDialog about, string link_)
		{
			Gtk.Application.AssertMainThread();
			IntPtr native_link_ = GLib.Marshaller.StringToPtrGStrdup (link_);
			native_cb (about == null ? IntPtr.Zero : about.Handle, native_link_, __data);
			GLib.Marshaller.Free (native_link_);
		}
	}

	internal static class AboutDialogActivateLinkFuncWrapper {

		public static void NativeCallback (IntPtr about, IntPtr link_, IntPtr data)
		{
			try {
				var gch = (GCHandle)data;
				var managed = (Gtk.AboutDialogActivateLinkFunc)gch.Target;
				managed (GLib.Object.GetObject(about) as Gtk.AboutDialog, GLib.Marshaller.Utf8PtrToString (link_));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}


		internal static readonly AboutDialogActivateLinkFuncNative NativeDelegate = new AboutDialogActivateLinkFuncNative (NativeCallback);
	}
#endregion
}
