// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[PixbufAlphaMode]
	public enum PixbufAlphaMode {

		Bilevel,
		Full,
	}

	internal class PixbufAlphaModeAttribute : GLib.GTypeTypeAttribute {
		[DllImport ("libgdk_pixbuf-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_pixbuf_alpha_mode_get_type ();

		private static GLib.GType _gtype = new GLib.GType (gdk_pixbuf_alpha_mode_get_type ());
		public static GLib.GType GType { get { return _gtype; } }
		public override GLib.GType Type { get { return _gtype; } }

	}
#endregion
}
