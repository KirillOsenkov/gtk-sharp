// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[Flags]
	[DragAction]
	public enum DragAction {

		Default = 1 << 0,
		Copy = 1 << 1,
		Move = 1 << 2,
		Link = 1 << 3,
		Private = 1 << 4,
		Ask = 1 << 5,
	}

	internal class DragActionAttribute : GLib.GTypeTypeAttribute {
		[DllImport ("libgdk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_drag_action_get_type ();

		private static GLib.GType _gtype = new GLib.GType (gdk_drag_action_get_type ());
		public static GLib.GType GType { get { return _gtype; } }
		public override GLib.GType Type { get { return _gtype; } }

	}
#endregion
}
