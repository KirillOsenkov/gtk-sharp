// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[FontSelection]
	public class FontSelection : Gtk.VBox {

		[Obsolete]
		protected FontSelection(GLib.GType gtype) : base(gtype) {}
		public FontSelection(IntPtr raw) : base(raw) {}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_font_selection_new();

		public FontSelection () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (FontSelection)) {
				Gtk.Application.AssertMainThread();
				CreateNativeObject (Array.Empty<IntPtr> (), Array.Empty<GLib.Value> (), 0);
				return;
			}
			owned = true;
			Raw = gtk_font_selection_new();
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_font_selection_get_font_name(IntPtr raw);

		[GLib.Property ("font-name")]
		public string FontName {
			get  {
				IntPtr raw_ret = gtk_font_selection_get_font_name(Handle);
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				return ret;
			}
			set {
				using (GLib.Value val = new GLib.Value(value)) {
					SetProperty("font-name", val);
				}
			}
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_font_selection_get_font(IntPtr raw);

		[Obsolete]
		[GLib.Property ("font")]
		public Gdk.Font Font {
			get  {
				IntPtr raw_ret = gtk_font_selection_get_font(Handle);
				Gdk.Font ret = Gdk.Font.New (raw_ret);
				return ret;
			}
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_font_selection_get_preview_text(IntPtr raw);

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_font_selection_set_preview_text(IntPtr raw, IntPtr text);

		[GLib.Property ("preview-text")]
		public string PreviewText {
			get  {
				IntPtr raw_ret = gtk_font_selection_get_preview_text(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set  {
				Gtk.Application.AssertMainThread();
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_font_selection_set_preview_text(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_font_selection_get_type();

		static GLib.GType _gtype = new GLib.GType (gtk_font_selection_get_type());
		public static new GLib.GType GType { 
			get {
								return _gtype;
			}
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_font_selection_set_font_name(IntPtr raw, IntPtr fontname);

		public bool SetFontName(string fontname) {
			Gtk.Application.AssertMainThread();
			IntPtr native_fontname = GLib.Marshaller.StringToPtrGStrdup (fontname);
			bool raw_ret = gtk_font_selection_set_font_name(Handle, native_fontname);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_fontname);
			return ret;
		}

#endregion
	}

	internal class FontSelectionAttribute : GLib.GTypeTypeAttribute {
		[DllImport ("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_font_selection_get_type ();

		private static GLib.GType _gtype = new GLib.GType (gtk_font_selection_get_type ());
		public static GLib.GType GType { get { return _gtype; } }
		public override GLib.GType Type { get { return _gtype; } }

	}
}
