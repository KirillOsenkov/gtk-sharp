// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[WindowEdge]
	public enum WindowEdge {

		NorthWest,
		North,
		NorthEast,
		West,
		East,
		SouthWest,
		South,
		SouthEast,
	}

	internal class WindowEdgeAttribute : GLib.GTypeTypeAttribute {
		[DllImport ("libgdk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_window_edge_get_type ();

		private static GLib.GType _gtype = new GLib.GType (gdk_window_edge_get_type ());
		public static GLib.GType GType { get { return _gtype; } }
		public override GLib.GType Type { get { return _gtype; } }

	}
#endregion
}
