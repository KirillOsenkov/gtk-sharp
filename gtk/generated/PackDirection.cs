// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[PackDirection]
	public enum PackDirection {

		Ltr,
		Rtl,
		Ttb,
		Btt,
	}

	internal class PackDirectionAttribute : GLib.GTypeTypeAttribute {
		[DllImport ("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_pack_direction_get_type ();

		private static GLib.GType _gtype = new GLib.GType (gtk_pack_direction_get_type ());
		public static GLib.GType GType { get { return _gtype; } }
		public override GLib.GType Type { get { return _gtype; } }

	}
#endregion
}
