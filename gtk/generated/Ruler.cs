// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[Ruler]
	public class Ruler : Gtk.Widget {

		[Obsolete]
		protected Ruler(GLib.GType gtype) : base(gtype) {}
		public Ruler(IntPtr raw) : base(raw) {}

		protected Ruler() : base(IntPtr.Zero)
		{
			CreateNativeObject (Array.Empty<IntPtr> (), Array.Empty<GLib.Value> (), 0);
		}

		[GLib.Property ("lower")]
		public double Lower {
			get {
				using (GLib.Value val = GetProperty ("lower")) {
					double ret = (double) val;
					return ret;
				}
			}
			set {
				using (GLib.Value val = new GLib.Value(value)) {
					SetProperty("lower", val);
				}
			}
		}

		[GLib.Property ("upper")]
		public double Upper {
			get {
				using (GLib.Value val = GetProperty ("upper")) {
					double ret = (double) val;
					return ret;
				}
			}
			set {
				using (GLib.Value val = new GLib.Value(value)) {
					SetProperty("upper", val);
				}
			}
		}

		[GLib.Property ("position")]
		public double Position {
			get {
				using (GLib.Value val = GetProperty ("position")) {
					double ret = (double) val;
					return ret;
				}
			}
			set {
				using (GLib.Value val = new GLib.Value(value)) {
					SetProperty("position", val);
				}
			}
		}

		[GLib.Property ("max-size")]
		public double MaxSize {
			get {
				using (GLib.Value val = GetProperty ("max-size")) {
					double ret = (double) val;
					return ret;
				}
			}
			set {
				using (GLib.Value val = new GLib.Value(value)) {
					SetProperty("max-size", val);
				}
			}
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_ruler_get_metric(IntPtr raw);

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_ruler_set_metric(IntPtr raw, int metric);

		[GLib.Property ("metric")]
		public Gtk.MetricType Metric {
			get  {
				int raw_ret = gtk_ruler_get_metric(Handle);
				Gtk.MetricType ret = (Gtk.MetricType) raw_ret;
				return ret;
			}
			set  {
				Gtk.Application.AssertMainThread();
				gtk_ruler_set_metric(Handle, (int) value);
			}
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_ruler_draw_pos(IntPtr raw);

		public void DrawPos() {
			gtk_ruler_draw_pos(Handle);
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_ruler_draw_ticks(IntPtr raw);

		public void DrawTicks() {
			gtk_ruler_draw_ticks(Handle);
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_ruler_get_range(IntPtr raw, out double lower, out double upper, out double position, out double max_size);

		public void GetRange(out double lower, out double upper, out double position, out double max_size) {
			Gtk.Application.AssertMainThread();
			gtk_ruler_get_range(Handle, out lower, out upper, out position, out max_size);
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_ruler_get_type();

		static GLib.GType _gtype = new GLib.GType (gtk_ruler_get_type());
		public static new GLib.GType GType { 
			get {
								return _gtype;
			}
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_ruler_set_range(IntPtr raw, double lower, double upper, double position, double max_size);

		public void SetRange(double lower, double upper, double position, double max_size) {
			Gtk.Application.AssertMainThread();
			gtk_ruler_set_range(Handle, lower, upper, position, max_size);
		}

#endregion
	}

	internal class RulerAttribute : GLib.GTypeTypeAttribute {
		[DllImport ("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_ruler_get_type ();

		private static GLib.GType _gtype = new GLib.GType (gtk_ruler_get_type ());
		public static GLib.GType GType { get { return _gtype; } }
		public override GLib.GType Type { get { return _gtype; } }

	}
}
