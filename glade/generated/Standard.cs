// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Glade {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class Standard {

		[DllImport("libglade-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void glade_standard_build_children(IntPtr self, IntPtr parent, ref Glade.WidgetInfo info);

		public static void BuildChildren(Glade.XML self, Gtk.Widget parent, Glade.WidgetInfo info) {
			glade_standard_build_children(self == null ? IntPtr.Zero : self.Handle, parent == null ? IntPtr.Zero : parent.Handle, ref info);
		}

		[DllImport("libglade-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr glade_standard_build_widget(IntPtr xml, IntPtr widget_type, ref Glade.WidgetInfo info);

		public static Gtk.Widget BuildWidget(Glade.XML xml, GLib.GType widget_type, Glade.WidgetInfo info) {
			IntPtr raw_ret = glade_standard_build_widget(xml == null ? IntPtr.Zero : xml.Handle, widget_type.Val, ref info);
			Gtk.Widget ret = GLib.Object.GetObject(raw_ret) as Gtk.Widget;
			return ret;
		}

#endregion
	}
}
