// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[PixbufAniAnim]
	public class PixbufAniAnim : Gdk.PixbufAnimation {

		[Obsolete]
		protected PixbufAniAnim(GLib.GType gtype) : base(gtype) {}
		public PixbufAniAnim(IntPtr raw) : base(raw) {}

		protected PixbufAniAnim() : base(IntPtr.Zero)
		{
			CreateNativeObject (Array.Empty<IntPtr> (), Array.Empty<GLib.Value> (), 0);
		}

		[DllImport("libgdk_pixbuf-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_pixbuf_ani_anim_get_type();

		static GLib.GType _gtype = new GLib.GType (gdk_pixbuf_ani_anim_get_type());
		public static new GLib.GType GType { 
			get {
								return _gtype;
			}
		}

#endregion
	}

	internal class PixbufAniAnimAttribute : GLib.GTypeTypeAttribute {
		[DllImport ("libgdk_pixbuf-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_pixbuf_ani_anim_get_type ();

		private static GLib.GType _gtype = new GLib.GType (gdk_pixbuf_ani_anim_get_type ());
		public static GLib.GType GType { get { return _gtype; } }
		public override GLib.GType Type { get { return _gtype; } }

	}
}
