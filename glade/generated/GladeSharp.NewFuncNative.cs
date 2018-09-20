// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GladeSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
	internal delegate IntPtr NewFuncNative(IntPtr xml, IntPtr widget_type, IntPtr info);

	internal class NewFuncWrapper {

		public IntPtr NativeCallback (IntPtr xml, IntPtr widget_type, IntPtr info)
		{
			try {
				Gtk.Widget __ret = managed (GLib.Object.GetObject(xml) as Glade.XML, new GLib.GType(widget_type), Glade.WidgetInfo.New (info));
				return __ret == null ? IntPtr.Zero : __ret.Handle;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: Above call does not return.
				throw e;
			}
		}


		internal readonly NewFuncNative NativeDelegate;
		Glade.NewFunc managed;

		public NewFuncWrapper (Glade.NewFunc managed)
		{
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new NewFuncNative (NativeCallback);
		}

	}
#endregion
}
