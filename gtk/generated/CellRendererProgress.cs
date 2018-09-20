// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[CellRendererProgress]
	public class CellRendererProgress : Gtk.CellRenderer {

		[Obsolete]
		protected CellRendererProgress(GLib.GType gtype) : base(gtype) {}
		public CellRendererProgress(IntPtr raw) : base(raw) {}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_cell_renderer_progress_new();

		public CellRendererProgress () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (CellRendererProgress)) {
				Gtk.Application.AssertMainThread();
				CreateNativeObject (Array.Empty<IntPtr> (), Array.Empty<GLib.Value> (), 0);
				return;
			}
			owned = true;
			Raw = gtk_cell_renderer_progress_new();
		}

		[GLib.Property ("value")]
		public int Value {
			get {
				using (GLib.Value val = GetProperty ("value")) {
					int ret = (int) val;
					return ret;
				}
			}
			set {
				using (GLib.Value val = new GLib.Value(value)) {
					SetProperty("value", val);
				}
			}
		}

		[GLib.Property ("text")]
		public string Text {
			get {
				using (GLib.Value val = GetProperty ("text")) {
					string ret = (string) val;
					return ret;
				}
			}
			set {
				using (GLib.Value val = new GLib.Value(value)) {
					SetProperty("text", val);
				}
			}
		}

		[GLib.Property ("pulse")]
		public int Pulse {
			get {
				using (GLib.Value val = GetProperty ("pulse")) {
					int ret = (int) val;
					return ret;
				}
			}
			set {
				using (GLib.Value val = new GLib.Value(value)) {
					SetProperty("pulse", val);
				}
			}
		}

		[GLib.Property ("text-xalign")]
		public float TextXAlign {
			get {
				using (GLib.Value val = GetProperty ("text-xalign")) {
					float ret = (float) val;
					return ret;
				}
			}
			set {
				using (GLib.Value val = new GLib.Value(value)) {
					SetProperty("text-xalign", val);
				}
			}
		}

		[GLib.Property ("text-yalign")]
		public float TextYAlign {
			get {
				using (GLib.Value val = GetProperty ("text-yalign")) {
					float ret = (float) val;
					return ret;
				}
			}
			set {
				using (GLib.Value val = new GLib.Value(value)) {
					SetProperty("text-yalign", val);
				}
			}
		}

		[GLib.Property ("orientation")]
		public Gtk.ProgressBarOrientation Orientation {
			get {
				using (GLib.Value val = GetProperty ("orientation")) {
					Gtk.ProgressBarOrientation ret = (Gtk.ProgressBarOrientation) (Enum) val;
					return ret;
				}
			}
			set {
				using (GLib.Value val = new GLib.Value((Enum) value)) {
					SetProperty("orientation", val);
				}
			}
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_cell_renderer_progress_get_type();

		static GLib.GType _gtype = new GLib.GType (gtk_cell_renderer_progress_get_type());
		public static new GLib.GType GType { 
			get {
								return _gtype;
			}
		}

#endregion
#region Customized extensions
#line 1 "CellRendererProgress.custom"
//
// CellRendererProgress.custom - Gtk CellRendererProgress class customizations
//
// Author: Peter Johanson <peter@peterjohanson.com>
//
// Copyright (C) 2007 Peter Johanson
//
// This code is inserted after the automatically generated code.
//
//
// This program is free software; you can redistribute it and/or
// modify it under the terms of version 2 of the Lesser GNU General 
// Public License as published by the Free Software Foundation.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public
// License along with this program; if not, write to the
// Free Software Foundation, Inc., 59 Temple Place - Suite 330,
// Boston, MA 02111-1307, USA.

		public override void GetSize (Gtk.Widget widget, ref Gdk.Rectangle cell_area, out int x_offset, out int y_offset, out int width, out int height) 
		{
			CellRenderer.InternalGetSize (Gtk.CellRendererProgress.GType, this, widget, ref cell_area, out x_offset, out y_offset, out width, out height);
		}

		protected override void Render (Gdk.Drawable window, Gtk.Widget widget, Gdk.Rectangle background_area, Gdk.Rectangle cell_area, Gdk.Rectangle expose_area, Gtk.CellRendererState flags)
		{
			CellRenderer.InternalRender (Gtk.CellRendererProgress.GType, this, window, widget, background_area, cell_area, expose_area, flags);
		}

		public override Gtk.CellEditable StartEditing(Gdk.Event evnt, Gtk.Widget widget, string path, Gdk.Rectangle background_area, Gdk.Rectangle cell_area, Gtk.CellRendererState flags) 
		{
			return Gtk.CellRenderer.InternalStartEditing (Gtk.CellRendererProgress.GType, this, evnt, widget, path, ref background_area, ref cell_area, flags);
		}

#endregion
	}

	internal class CellRendererProgressAttribute : GLib.GTypeTypeAttribute {
		[DllImport ("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_cell_renderer_progress_get_type ();

		private static GLib.GType _gtype = new GLib.GType (gtk_cell_renderer_progress_get_type ());
		public static GLib.GType GType { get { return _gtype; } }
		public override GLib.GType Type { get { return _gtype; } }

	}
}
