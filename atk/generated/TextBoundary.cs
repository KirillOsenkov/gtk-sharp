// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Atk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[TextBoundary]
	public enum TextBoundary {

		Char,
		WordStart,
		WordEnd,
		SentenceStart,
		SentenceEnd,
		LineStart,
		LineEnd,
	}

	internal class TextBoundaryAttribute : GLib.GTypeTypeAttribute {
		[DllImport ("libatk-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr atk_text_boundary_get_type ();

		private static GLib.GType _gtype = new GLib.GType (atk_text_boundary_get_type ());
		public static GLib.GType GType { get { return _gtype; } }
		public override GLib.GType Type { get { return _gtype; } }

	}
#endregion
}
