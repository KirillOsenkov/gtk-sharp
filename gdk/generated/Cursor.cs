// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[Cursor]
	public class Cursor : GLib.Opaque {

		[DllImport ("gdksharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		extern static uint gdksharp_gdk_cursor_get_type_offset ();

		static uint type_offset = gdksharp_gdk_cursor_get_type_offset ();
		public Gdk.CursorType Type {
			get {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + type_offset);
					return (Gdk.CursorType) (*raw_ptr);
				}
			}
			set {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + type_offset);
					*raw_ptr = (int) value;
				}
			}
		}

		[DllImport("libgdk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_cursor_get_display(IntPtr raw);

		public Gdk.Display Display { 
			get {
				IntPtr raw_ret = gdk_cursor_get_display(Handle);
				Gdk.Display ret = GLib.Object.GetObject(raw_ret) as Gdk.Display;
				return ret;
			}
		}

		[DllImport("libgdk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_cursor_get_image(IntPtr raw);

		public Gdk.Pixbuf Image { 
			get {
				IntPtr raw_ret = gdk_cursor_get_image(Handle);
				Gdk.Pixbuf ret = GLib.Object.GetObject(raw_ret) as Gdk.Pixbuf;
				return ret;
			}
		}

		[DllImport("libgdk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_cursor_get_type();

		static GLib.GType _gtype = new GLib.GType (gdk_cursor_get_type());
		public static GLib.GType GType { 
			get {
								return _gtype;
			}
		}

		public Cursor(IntPtr raw) : base(raw) {}

		[DllImport("libgdk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_cursor_new(int cursor_type);

		public Cursor (Gdk.CursorType cursor_type) 
		{
			Raw = gdk_cursor_new((int) cursor_type);
		}

		[DllImport("libgdk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_cursor_new_for_display(IntPtr display, int cursor_type);

		public Cursor (Gdk.Display display, Gdk.CursorType cursor_type) 
		{
			Raw = gdk_cursor_new_for_display(display == null ? IntPtr.Zero : display.Handle, (int) cursor_type);
		}

		[DllImport("libgdk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_cursor_new_from_name(IntPtr display, IntPtr name);

		public static Cursor NewFromName(Gdk.Display display, string name)
		{
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			Cursor result = new Cursor (gdk_cursor_new_from_name(display == null ? IntPtr.Zero : display.Handle, native_name));
			GLib.Marshaller.Free (native_name);
			return result;
		}

		[DllImport("libgdk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_cursor_new_from_pixbuf(IntPtr display, IntPtr pixbuf, int x, int y);

		public Cursor (Gdk.Display display, Gdk.Pixbuf pixbuf, int x, int y) 
		{
			Raw = gdk_cursor_new_from_pixbuf(display == null ? IntPtr.Zero : display.Handle, pixbuf == null ? IntPtr.Zero : pixbuf.Handle, x, y);
		}

		[DllImport("libgdk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_cursor_new_from_pixmap(IntPtr source, IntPtr mask, ref Gdk.Color fg, ref Gdk.Color bg, int x, int y);

		public Cursor (Gdk.Pixmap source, Gdk.Pixmap mask, Gdk.Color fg, Gdk.Color bg, int x, int y) 
		{
			Raw = gdk_cursor_new_from_pixmap(source == null ? IntPtr.Zero : source.Handle, mask == null ? IntPtr.Zero : mask.Handle, ref fg, ref bg, x, y);
		}

		[DllImport("libgdk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_cursor_ref(IntPtr raw);

		protected override void Ref (IntPtr raw)
		{
			if (!Owned) {
				gdk_cursor_ref (raw);
				Owned = true;
			}
		}

		[Obsolete("Gdk.Cursor is now refcounted automatically")]
		public Cursor Ref () { return this; }

		[DllImport("libgdk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gdk_cursor_unref(IntPtr raw);

		protected override void Unref (IntPtr raw)
		{
			if (Owned) {
				gdk_cursor_unref (raw);
				Owned = false;
			}
		}

		[Obsolete("Gdk.Cursor is now refcounted automatically")]
		public void Unref () {}

#endregion
	}

	internal class CursorAttribute : GLib.GTypeTypeAttribute {
		[DllImport ("libgdk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_cursor_get_type ();

		private static GLib.GType _gtype = new GLib.GType (gdk_cursor_get_type ());
		public static GLib.GType GType { get { return _gtype; } }
		public override GLib.GType Type { get { return _gtype; } }

	}
}
