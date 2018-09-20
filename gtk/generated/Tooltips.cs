// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[Obsolete]
	[Tooltips]
	public class Tooltips : Gtk.Object {

		[Obsolete]
		protected Tooltips(GLib.GType gtype) : base(gtype) {}
		public Tooltips(IntPtr raw) : base(raw) {}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_tooltips_new();

		public Tooltips () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (Tooltips)) {
				Gtk.Application.AssertMainThread();
				CreateNativeObject (Array.Empty<IntPtr> (), Array.Empty<GLib.Value> (), 0);
				return;
			}
			owned = true;
			Raw = gtk_tooltips_new();
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tooltips_set_delay(IntPtr raw, uint delay);

		public uint Delay {
			set  {
				Gtk.Application.AssertMainThread();
				gtk_tooltips_set_delay(Handle, value);
			}
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tooltips_disable(IntPtr raw);

		public void Disable() {
			gtk_tooltips_disable(Handle);
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tooltips_enable(IntPtr raw);

		public void Enable() {
			gtk_tooltips_enable(Handle);
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tooltips_force_window(IntPtr raw);

		public void ForceWindow() {
			gtk_tooltips_force_window(Handle);
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_tooltips_get_info_from_tip_window(IntPtr tip_window, IntPtr tooltips, IntPtr current_widget);

		public static bool GetInfoFromTipWindow(Gtk.Window tip_window, Gtk.Tooltips tooltips, Gtk.Widget current_widget) {
			Gtk.Application.AssertMainThread();
			bool raw_ret = gtk_tooltips_get_info_from_tip_window(tip_window == null ? IntPtr.Zero : tip_window.Handle, tooltips == null ? IntPtr.Zero : tooltips.Handle, current_widget == null ? IntPtr.Zero : current_widget.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_tooltips_get_type();

		static GLib.GType _gtype = new GLib.GType (gtk_tooltips_get_type());
		public static new GLib.GType GType { 
			get {
								return _gtype;
			}
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tooltips_set_tip(IntPtr raw, IntPtr widget, IntPtr tip_text, IntPtr tip_private);

		public void SetTip(Gtk.Widget widget, string tip_text, string tip_private) {
			Gtk.Application.AssertMainThread();
			IntPtr native_tip_text = GLib.Marshaller.StringToPtrGStrdup (tip_text);
			IntPtr native_tip_private = GLib.Marshaller.StringToPtrGStrdup (tip_private);
			gtk_tooltips_set_tip(Handle, widget == null ? IntPtr.Zero : widget.Handle, native_tip_text, native_tip_private);
			GLib.Marshaller.Free (native_tip_text);
			GLib.Marshaller.Free (native_tip_private);
		}

#endregion
	}

	internal class TooltipsAttribute : GLib.GTypeTypeAttribute {
		[DllImport ("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_tooltips_get_type ();

		private static GLib.GType _gtype = new GLib.GType (gtk_tooltips_get_type ());
		public static GLib.GType GType { get { return _gtype; } }
		public override GLib.GType Type { get { return _gtype; } }

	}
}
