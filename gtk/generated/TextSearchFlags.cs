// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[Flags]
	[TextSearchFlags]
	public enum TextSearchFlags {

		VisibleOnly = 1 << 0,
		TextOnly = 1 << 1,
	}

	internal class TextSearchFlagsAttribute : GLib.GTypeTypeAttribute {
		[DllImport ("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_text_search_flags_get_type ();

		private static GLib.GType _gtype = new GLib.GType (gtk_text_search_flags_get_type ());
		public static GLib.GType GType { get { return _gtype; } }
		public override GLib.GType Type { get { return _gtype; } }

	}
#endregion
}
