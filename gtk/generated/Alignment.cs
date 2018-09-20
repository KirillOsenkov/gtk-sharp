// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[Alignment]
	public class Alignment : Gtk.Bin {

		[Obsolete]
		protected Alignment(GLib.GType gtype) : base(gtype) {}
		public Alignment(IntPtr raw) : base(raw) {}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_alignment_new(float xalign, float yalign, float xscale, float yscale);

		public Alignment (float xalign, float yalign, float xscale, float yscale) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (Alignment)) {
				Gtk.Application.AssertMainThread();
				unsafe {
					var vals = stackalloc GLib.Value[4];
					var names = stackalloc IntPtr[4];
					names[0] = GLib.Marshaller.StringToPtrGStrdup ("xalign");
					vals[0] = new GLib.Value (xalign);
					names[1] = GLib.Marshaller.StringToPtrGStrdup ("yalign");
					vals[1] = new GLib.Value (yalign);
					names[2] = GLib.Marshaller.StringToPtrGStrdup ("xscale");
					vals[2] = new GLib.Value (xscale);
					names[3] = GLib.Marshaller.StringToPtrGStrdup ("yscale");
					vals[3] = new GLib.Value (yscale);
					CreateNativeObject (names, vals, 4);
				}
				return;
			}
			Gtk.Application.AssertMainThread();
			owned = true;
			Raw = gtk_alignment_new(xalign, yalign, xscale, yscale);
		}

		[GLib.Property ("xalign")]
		public float Xalign {
			get {
				using (GLib.Value val = GetProperty ("xalign")) {
					float ret = (float) val;
					return ret;
				}
			}
			set {
				using (GLib.Value val = new GLib.Value(value)) {
					SetProperty("xalign", val);
				}
			}
		}

		[GLib.Property ("yalign")]
		public float Yalign {
			get {
				using (GLib.Value val = GetProperty ("yalign")) {
					float ret = (float) val;
					return ret;
				}
			}
			set {
				using (GLib.Value val = new GLib.Value(value)) {
					SetProperty("yalign", val);
				}
			}
		}

		[GLib.Property ("xscale")]
		public float Xscale {
			get {
				using (GLib.Value val = GetProperty ("xscale")) {
					float ret = (float) val;
					return ret;
				}
			}
			set {
				using (GLib.Value val = new GLib.Value(value)) {
					SetProperty("xscale", val);
				}
			}
		}

		[GLib.Property ("yscale")]
		public float Yscale {
			get {
				using (GLib.Value val = GetProperty ("yscale")) {
					float ret = (float) val;
					return ret;
				}
			}
			set {
				using (GLib.Value val = new GLib.Value(value)) {
					SetProperty("yscale", val);
				}
			}
		}

		[GLib.Property ("top-padding")]
		public uint TopPadding {
			get {
				using (GLib.Value val = GetProperty ("top-padding")) {
					uint ret = (uint) val;
					return ret;
				}
			}
			set {
				using (GLib.Value val = new GLib.Value(value)) {
					SetProperty("top-padding", val);
				}
			}
		}

		[GLib.Property ("bottom-padding")]
		public uint BottomPadding {
			get {
				using (GLib.Value val = GetProperty ("bottom-padding")) {
					uint ret = (uint) val;
					return ret;
				}
			}
			set {
				using (GLib.Value val = new GLib.Value(value)) {
					SetProperty("bottom-padding", val);
				}
			}
		}

		[GLib.Property ("left-padding")]
		public uint LeftPadding {
			get {
				using (GLib.Value val = GetProperty ("left-padding")) {
					uint ret = (uint) val;
					return ret;
				}
			}
			set {
				using (GLib.Value val = new GLib.Value(value)) {
					SetProperty("left-padding", val);
				}
			}
		}

		[GLib.Property ("right-padding")]
		public uint RightPadding {
			get {
				using (GLib.Value val = GetProperty ("right-padding")) {
					uint ret = (uint) val;
					return ret;
				}
			}
			set {
				using (GLib.Value val = new GLib.Value(value)) {
					SetProperty("right-padding", val);
				}
			}
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_alignment_get_padding(IntPtr raw, out uint padding_top, out uint padding_bottom, out uint padding_left, out uint padding_right);

		public void GetPadding(out uint padding_top, out uint padding_bottom, out uint padding_left, out uint padding_right) {
			Gtk.Application.AssertMainThread();
			gtk_alignment_get_padding(Handle, out padding_top, out padding_bottom, out padding_left, out padding_right);
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_alignment_get_type();

		static GLib.GType _gtype = new GLib.GType (gtk_alignment_get_type());
		public static new GLib.GType GType { 
			get {
								return _gtype;
			}
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_alignment_set(IntPtr raw, float xalign, float yalign, float xscale, float yscale);

		public void Set(float xalign, float yalign, float xscale, float yscale) {
			Gtk.Application.AssertMainThread();
			gtk_alignment_set(Handle, xalign, yalign, xscale, yscale);
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_alignment_set_padding(IntPtr raw, uint padding_top, uint padding_bottom, uint padding_left, uint padding_right);

		public void SetPadding(uint padding_top, uint padding_bottom, uint padding_left, uint padding_right) {
			Gtk.Application.AssertMainThread();
			gtk_alignment_set_padding(Handle, padding_top, padding_bottom, padding_left, padding_right);
		}

#endregion
	}

	internal class AlignmentAttribute : GLib.GTypeTypeAttribute {
		[DllImport ("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_alignment_get_type ();

		private static GLib.GType _gtype = new GLib.GType (gtk_alignment_get_type ());
		public static GLib.GType GType { get { return _gtype; } }
		public override GLib.GType Type { get { return _gtype; } }

	}
}
