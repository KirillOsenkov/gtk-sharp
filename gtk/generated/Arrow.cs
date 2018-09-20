// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[Arrow]
	public class Arrow : Gtk.Misc {

		[Obsolete]
		protected Arrow(GLib.GType gtype) : base(gtype) {}
		public Arrow(IntPtr raw) : base(raw) {}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_arrow_new(int arrow_type, int shadow_type);

		public Arrow (Gtk.ArrowType arrow_type, Gtk.ShadowType shadow_type) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (Arrow)) {
				Gtk.Application.AssertMainThread();
				unsafe {
					var vals = stackalloc GLib.Value[2];
					var names = stackalloc IntPtr[2];
					names[0] = GLib.Marshaller.StringToPtrGStrdup ("arrow_type");
					vals[0] = new GLib.Value (arrow_type);
					names[1] = GLib.Marshaller.StringToPtrGStrdup ("shadow_type");
					vals[1] = new GLib.Value (shadow_type);
					CreateNativeObject (names, vals, 2);
				}
				return;
			}
			Gtk.Application.AssertMainThread();
			owned = true;
			Raw = gtk_arrow_new((int) arrow_type, (int) shadow_type);
		}

		[GLib.Property ("arrow-type")]
		public Gtk.ArrowType ArrowType {
			get {
				using (GLib.Value val = GetProperty ("arrow-type")) {
					Gtk.ArrowType ret = (Gtk.ArrowType) (Enum) val;
					return ret;
				}
			}
			set {
				using (GLib.Value val = new GLib.Value((Enum) value)) {
					SetProperty("arrow-type", val);
				}
			}
		}

		[GLib.Property ("shadow-type")]
		public Gtk.ShadowType ShadowType {
			get {
				using (GLib.Value val = GetProperty ("shadow-type")) {
					Gtk.ShadowType ret = (Gtk.ShadowType) (Enum) val;
					return ret;
				}
			}
			set {
				using (GLib.Value val = new GLib.Value((Enum) value)) {
					SetProperty("shadow-type", val);
				}
			}
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_arrow_get_type();

		static GLib.GType _gtype = new GLib.GType (gtk_arrow_get_type());
		public static new GLib.GType GType { 
			get {
								return _gtype;
			}
		}

#endregion
	}

	internal class ArrowAttribute : GLib.GTypeTypeAttribute {
		[DllImport ("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_arrow_get_type ();

		private static GLib.GType _gtype = new GLib.GType (gtk_arrow_get_type ());
		public static GLib.GType GType { get { return _gtype; } }
		public override GLib.GType Type { get { return _gtype; } }

	}
}
