// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[CellRendererPixbuf]
	public class CellRendererPixbuf : Gtk.CellRenderer {

		[Obsolete]
		protected CellRendererPixbuf(GLib.GType gtype) : base(gtype) {}
		public CellRendererPixbuf(IntPtr raw) : base(raw) {}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_cell_renderer_pixbuf_new();

		public CellRendererPixbuf () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (CellRendererPixbuf)) {
				Gtk.Application.AssertMainThread();
				CreateNativeObject (Array.Empty<IntPtr> (), Array.Empty<GLib.Value> (), 0);
				return;
			}
			owned = true;
			Raw = gtk_cell_renderer_pixbuf_new();
		}

		[GLib.Property ("pixbuf")]
		public Gdk.Pixbuf Pixbuf {
			get {
				using (GLib.Value val = GetProperty ("pixbuf")) {
					Gdk.Pixbuf ret = (Gdk.Pixbuf) val;
					return ret;
				}
			}
			set {
				using (GLib.Value val = new GLib.Value(value)) {
					SetProperty("pixbuf", val);
				}
			}
		}

		[GLib.Property ("pixbuf-expander-open")]
		public Gdk.Pixbuf PixbufExpanderOpen {
			get {
				using (GLib.Value val = GetProperty ("pixbuf-expander-open")) {
					Gdk.Pixbuf ret = (Gdk.Pixbuf) val;
					return ret;
				}
			}
			set {
				using (GLib.Value val = new GLib.Value(value)) {
					SetProperty("pixbuf-expander-open", val);
				}
			}
		}

		[GLib.Property ("pixbuf-expander-closed")]
		public Gdk.Pixbuf PixbufExpanderClosed {
			get {
				using (GLib.Value val = GetProperty ("pixbuf-expander-closed")) {
					Gdk.Pixbuf ret = (Gdk.Pixbuf) val;
					return ret;
				}
			}
			set {
				using (GLib.Value val = new GLib.Value(value)) {
					SetProperty("pixbuf-expander-closed", val);
				}
			}
		}

		[GLib.Property ("stock-id")]
		public string StockId {
			get {
				using (GLib.Value val = GetProperty ("stock-id")) {
					string ret = (string) val;
					return ret;
				}
			}
			set {
				using (GLib.Value val = new GLib.Value(value)) {
					SetProperty("stock-id", val);
				}
			}
		}

		[GLib.Property ("stock-size")]
		public uint StockSize {
			get {
				using (GLib.Value val = GetProperty ("stock-size")) {
					uint ret = (uint) val;
					return ret;
				}
			}
			set {
				using (GLib.Value val = new GLib.Value(value)) {
					SetProperty("stock-size", val);
				}
			}
		}

		[GLib.Property ("stock-detail")]
		public string StockDetail {
			get {
				using (GLib.Value val = GetProperty ("stock-detail")) {
					string ret = (string) val;
					return ret;
				}
			}
			set {
				using (GLib.Value val = new GLib.Value(value)) {
					SetProperty("stock-detail", val);
				}
			}
		}

		[GLib.Property ("icon-name")]
		public string IconName {
			get {
				using (GLib.Value val = GetProperty ("icon-name")) {
					string ret = (string) val;
					return ret;
				}
			}
			set {
				using (GLib.Value val = new GLib.Value(value)) {
					SetProperty("icon-name", val);
				}
			}
		}

		[GLib.Property ("follow-state")]
		public bool FollowState {
			get {
				using (GLib.Value val = GetProperty ("follow-state")) {
					bool ret = (bool) val;
					return ret;
				}
			}
			set {
				using (GLib.Value val = new GLib.Value(value)) {
					SetProperty("follow-state", val);
				}
			}
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_cell_renderer_pixbuf_get_type();

		static GLib.GType _gtype = new GLib.GType (gtk_cell_renderer_pixbuf_get_type());
		public static new GLib.GType GType { 
			get {
								return _gtype;
			}
		}

#endregion
#region Customized extensions
#line 1 "CellRendererPixbuf.custom"
//
// CellRendererPixbuf.custom - Gtk CellRendererPixbuf class customizations
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
			CellRenderer.InternalGetSize (Gtk.CellRendererPixbuf.GType, this, widget, ref cell_area, out x_offset, out y_offset, out width, out height);
		}

		protected override void Render (Gdk.Drawable window, Gtk.Widget widget, Gdk.Rectangle background_area, Gdk.Rectangle cell_area, Gdk.Rectangle expose_area, Gtk.CellRendererState flags)
		{
			CellRenderer.InternalRender (Gtk.CellRendererPixbuf.GType, this, window, widget, background_area, cell_area, expose_area, flags);
		}

		public override Gtk.CellEditable StartEditing(Gdk.Event evnt, Gtk.Widget widget, string path, Gdk.Rectangle background_area, Gdk.Rectangle cell_area, Gtk.CellRendererState flags) 
		{
			return Gtk.CellRenderer.InternalStartEditing (Gtk.CellRendererPixbuf.GType, this, evnt, widget, path, ref background_area, ref cell_area, flags);
		}

#endregion
	}

	internal class CellRendererPixbufAttribute : GLib.GTypeTypeAttribute {
		[DllImport ("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_cell_renderer_pixbuf_get_type ();

		private static GLib.GType _gtype = new GLib.GType (gtk_cell_renderer_pixbuf_get_type ());
		public static GLib.GType GType { get { return _gtype; } }
		public override GLib.GType Type { get { return _gtype; } }

	}
}
