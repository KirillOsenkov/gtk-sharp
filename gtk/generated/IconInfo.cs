// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[IconInfo]
	public class IconInfo : GLib.Opaque {

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_icon_info_copy(IntPtr raw);

		public Gtk.IconInfo Copy() {
			IntPtr raw_ret = gtk_icon_info_copy(Handle);
			Gtk.IconInfo ret = raw_ret == IntPtr.Zero ? null : (Gtk.IconInfo) GLib.Opaque.GetOpaque (raw_ret, typeof (Gtk.IconInfo), true);
			return ret;
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_icon_info_get_attach_points(IntPtr raw, ref Gdk.Point points, out int n_points);

		public bool GetAttachPoints(Gdk.Point points, out int n_points) {
			Gtk.Application.AssertMainThread();
			bool raw_ret = gtk_icon_info_get_attach_points(Handle, ref points, out n_points);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_icon_info_get_base_size(IntPtr raw);

		public int BaseSize { 
			get {
				int raw_ret = gtk_icon_info_get_base_size(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_icon_info_get_builtin_pixbuf(IntPtr raw);

		public Gdk.Pixbuf BuiltinPixbuf { 
			get {
				IntPtr raw_ret = gtk_icon_info_get_builtin_pixbuf(Handle);
				Gdk.Pixbuf ret = GLib.Object.GetObject(raw_ret) as Gdk.Pixbuf;
				return ret;
			}
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_icon_info_get_display_name(IntPtr raw);

		public string DisplayName { 
			get {
				IntPtr raw_ret = gtk_icon_info_get_display_name(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_icon_info_get_embedded_rect(IntPtr raw, ref Gdk.Rectangle rectangle);

		public bool GetEmbeddedRect(Gdk.Rectangle rectangle) {
			Gtk.Application.AssertMainThread();
			bool raw_ret = gtk_icon_info_get_embedded_rect(Handle, ref rectangle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_icon_info_get_filename(IntPtr raw);

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_icon_info_get_filename_utf8(IntPtr raw);

		public string Filename { 
			get {
				IntPtr raw_ret;
				if (Environment.OSVersion.Platform == PlatformID.Win32NT ||
				    Environment.OSVersion.Platform == PlatformID.Win32S ||
				    Environment.OSVersion.Platform == PlatformID.Win32Windows ||
				    Environment.OSVersion.Platform == PlatformID.WinCE)
					raw_ret = gtk_icon_info_get_filename_utf8(Handle);
				else
					raw_ret = gtk_icon_info_get_filename(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);

				return ret;
			}
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_icon_info_get_type();

		static GLib.GType _gtype = new GLib.GType (gtk_icon_info_get_type());
		public static GLib.GType GType { 
			get {
								return _gtype;
			}
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe IntPtr gtk_icon_info_load_icon(IntPtr raw, out IntPtr error);

		public unsafe Gdk.Pixbuf LoadIcon() {
			Gtk.Application.AssertMainThread();
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = gtk_icon_info_load_icon(Handle, out error);
			Gdk.Pixbuf ret = GLib.Object.GetObject(raw_ret) as Gdk.Pixbuf;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_icon_info_set_raw_coordinates(IntPtr raw, bool raw_coordinates);

		public bool RawCoordinates { 
			set {
				Gtk.Application.AssertMainThread();
				gtk_icon_info_set_raw_coordinates(Handle, value);
			}
		}

		public IconInfo(IntPtr raw) : base(raw) {}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_icon_info_free(IntPtr raw);

		protected override void Free (IntPtr raw)
		{
			gtk_icon_info_free (raw);
		}

		[Obsolete("Gtk.IconInfo is now freed automatically")]
		public void Free () {}

#endregion
	}

	internal class IconInfoAttribute : GLib.GTypeTypeAttribute {
		[DllImport ("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_icon_info_get_type ();

		private static GLib.GType _gtype = new GLib.GType (gtk_icon_info_get_type ());
		public static GLib.GType GType { get { return _gtype; } }
		public override GLib.GType Type { get { return _gtype; } }

	}
}
