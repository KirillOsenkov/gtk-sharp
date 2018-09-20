// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[PixbufAnimationIter]
	public class PixbufAnimationIter : GLib.Object {

		[Obsolete]
		protected PixbufAnimationIter(GLib.GType gtype) : base(gtype) {}
		public PixbufAnimationIter(IntPtr raw) : base(raw) {}

		protected PixbufAnimationIter() : base(IntPtr.Zero)
		{
			CreateNativeObject (Array.Empty<IntPtr> (), Array.Empty<GLib.Value> (), 0);
		}

		[DllImport("libgdk_pixbuf-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gdk_pixbuf_animation_iter_advance(IntPtr raw, IntPtr current_time);

		public bool Advance(IntPtr current_time) {
			bool raw_ret = gdk_pixbuf_animation_iter_advance(Handle, current_time);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgdk_pixbuf-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gdk_pixbuf_animation_iter_get_delay_time(IntPtr raw);

		public int DelayTime { 
			get {
				int raw_ret = gdk_pixbuf_animation_iter_get_delay_time(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libgdk_pixbuf-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_pixbuf_animation_iter_get_pixbuf(IntPtr raw);

		public Gdk.Pixbuf Pixbuf { 
			get {
				IntPtr raw_ret = gdk_pixbuf_animation_iter_get_pixbuf(Handle);
				Gdk.Pixbuf ret = GLib.Object.GetObject(raw_ret) as Gdk.Pixbuf;
				return ret;
			}
		}

		[DllImport("libgdk_pixbuf-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_pixbuf_animation_iter_get_type();

		static GLib.GType _gtype = new GLib.GType (gdk_pixbuf_animation_iter_get_type());
		public static new GLib.GType GType { 
			get {
								return _gtype;
			}
		}

		[DllImport("libgdk_pixbuf-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gdk_pixbuf_animation_iter_on_currently_loading_frame(IntPtr raw);

		public bool OnCurrentlyLoadingFrame() {
			bool raw_ret = gdk_pixbuf_animation_iter_on_currently_loading_frame(Handle);
			bool ret = raw_ret;
			return ret;
		}

#endregion
	}

	internal class PixbufAnimationIterAttribute : GLib.GTypeTypeAttribute {
		[DllImport ("libgdk_pixbuf-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_pixbuf_animation_iter_get_type ();

		private static GLib.GType _gtype = new GLib.GType (gdk_pixbuf_animation_iter_get_type ());
		public static GLib.GType GType { get { return _gtype; } }
		public override GLib.GType Type { get { return _gtype; } }

	}
}
