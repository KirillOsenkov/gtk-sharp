// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Pango {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	[GLib.GTypeStruct]
	public struct GlyphVisAttr {

		private uint _bitfield0;

		[DllImport ("pangosharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		extern static bool pangosharp_pango_glyphvisattr_get_is_cluster_start (ref Pango.GlyphVisAttr raw);
		[DllImport ("pangosharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		extern static void pangosharp_pango_glyphvisattr_set_is_cluster_start (ref Pango.GlyphVisAttr raw, bool value);
		public bool IsClusterStart {
			get {
				bool result = pangosharp_pango_glyphvisattr_get_is_cluster_start (ref this);
				return result;
			}
			set {
				pangosharp_pango_glyphvisattr_set_is_cluster_start (ref this, value);
			}
		}


		public static Pango.GlyphVisAttr Zero = new Pango.GlyphVisAttr ();

		public static Pango.GlyphVisAttr New (IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Pango.GlyphVisAttr.Zero;
			unsafe { return *(Pango.GlyphVisAttr*)raw; }
		}

#endregion
	}
}
