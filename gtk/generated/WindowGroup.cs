// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[WindowGroup]
	public class WindowGroup : GLib.Object {

		[Obsolete]
		protected WindowGroup(GLib.GType gtype) : base(gtype) {}
		public WindowGroup(IntPtr raw) : base(raw) {}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_window_group_new();

		public WindowGroup () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (WindowGroup)) {
				Gtk.Application.AssertMainThread();
				CreateNativeObject (Array.Empty<IntPtr> (), Array.Empty<GLib.Value> (), 0);
				return;
			}
			owned = true;
			Raw = gtk_window_group_new();
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_window_group_add_window(IntPtr raw, IntPtr window);

		public void AddWindow(Gtk.Window window) {
			Gtk.Application.AssertMainThread();
			gtk_window_group_add_window(Handle, window == null ? IntPtr.Zero : window.Handle);
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_window_group_get_type();

		static GLib.GType _gtype = new GLib.GType (gtk_window_group_get_type());
		public static new GLib.GType GType { 
			get {
								return _gtype;
			}
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_window_group_remove_window(IntPtr raw, IntPtr window);

		public void RemoveWindow(Gtk.Window window) {
			Gtk.Application.AssertMainThread();
			gtk_window_group_remove_window(Handle, window == null ? IntPtr.Zero : window.Handle);
		}

#endregion
	}

	internal class WindowGroupAttribute : GLib.GTypeTypeAttribute {
		[DllImport ("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_window_group_get_type ();

		private static GLib.GType _gtype = new GLib.GType (gtk_window_group_get_type ());
		public static GLib.GType GType { get { return _gtype; } }
		public override GLib.GType Type { get { return _gtype; } }

	}
}
