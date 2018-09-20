// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[ImageMenuItem]
	public class ImageMenuItem : Gtk.MenuItem {

		[Obsolete]
		protected ImageMenuItem(GLib.GType gtype) : base(gtype) {}
		public ImageMenuItem(IntPtr raw) : base(raw) {}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_image_menu_item_new();

		public ImageMenuItem () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (ImageMenuItem)) {
				Gtk.Application.AssertMainThread();
				CreateNativeObject (Array.Empty<IntPtr> (), Array.Empty<GLib.Value> (), 0);
				return;
			}
			owned = true;
			Raw = gtk_image_menu_item_new();
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_image_menu_item_new_from_stock(IntPtr stock_id, IntPtr accel_group);

		public ImageMenuItem (string stock_id, Gtk.AccelGroup accel_group) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (ImageMenuItem)) {
				Gtk.Application.AssertMainThread();
				throw new InvalidOperationException ("Can't override this constructor.");
			}
			Gtk.Application.AssertMainThread();
			IntPtr native_stock_id = GLib.Marshaller.StringToPtrGStrdup (stock_id);
			owned = true;
			Raw = gtk_image_menu_item_new_from_stock(native_stock_id, accel_group == null ? IntPtr.Zero : accel_group.Handle);
			GLib.Marshaller.Free (native_stock_id);
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_image_menu_item_get_image(IntPtr raw);

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_image_menu_item_set_image(IntPtr raw, IntPtr image);

		[GLib.Property ("image")]
		public Gtk.Widget Image {
			get  {
				IntPtr raw_ret = gtk_image_menu_item_get_image(Handle);
				Gtk.Widget ret = GLib.Object.GetObject(raw_ret) as Gtk.Widget;
				return ret;
			}
			set  {
				Gtk.Application.AssertMainThread();
				gtk_image_menu_item_set_image(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_image_menu_item_get_type();

		static GLib.GType _gtype = new GLib.GType (gtk_image_menu_item_get_type());
		public static new GLib.GType GType { 
			get {
								return _gtype;
			}
		}

#endregion
#region Customized extensions
#line 1 "ImageMenuItem.custom"
// Gtk.ImageMenuItem.custom - Gtk ImageMenuItem class customizations
//
// Author: Mike Kestner <mkestner@ximian.com> 
//
// Copyright (C) 2004 Novell, Inc.
//
// This code is inserted after the automatically generated code.
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

		
		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention=CallingConvention.Cdecl)]
		static extern IntPtr gtk_image_menu_item_new_with_mnemonic (IntPtr label);

		public ImageMenuItem (string label) : base (IntPtr.Zero)
		{
			if (GetType() != typeof (ImageMenuItem)) {
				CreateNativeObject (Array.Empty<IntPtr> (), Array.Empty<GLib.Value> (), 0);
				AccelLabel al = new AccelLabel ("");
				al.TextWithMnemonic = label;
				al.SetAlignment (0.0f, 0.5f);
				Add (al);
				al.AccelWidget = this;
				return;
			}

			owned = true;
			IntPtr native = GLib.Marshaller.StringToPtrGStrdup (label);
			Raw = gtk_image_menu_item_new_with_mnemonic (native);
			GLib.Marshaller.Free (native);
		}


#endregion
	}

	internal class ImageMenuItemAttribute : GLib.GTypeTypeAttribute {
		[DllImport ("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_image_menu_item_get_type ();

		private static GLib.GType _gtype = new GLib.GType (gtk_image_menu_item_get_type ());
		public static GLib.GType GType { get { return _gtype; } }
		public override GLib.GType Type { get { return _gtype; } }

	}
}
