// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Pango {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[TabAlign]
	public enum TabAlign {

		Left,
	}

	internal class TabAlignAttribute : GLib.GTypeTypeAttribute {
		[DllImport ("libpango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_tab_align_get_type ();

		private static GLib.GType _gtype = new GLib.GType (pango_tab_align_get_type ());
		public static GLib.GType GType { get { return _gtype; } }
		public override GLib.GType Type { get { return _gtype; } }

	}
#endregion
}
