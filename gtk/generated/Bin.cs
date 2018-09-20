// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[Bin]
	public class Bin : Gtk.Container {

		[Obsolete]
		protected Bin(GLib.GType gtype) : base(gtype) {}
		public Bin(IntPtr raw) : base(raw) {}

		protected Bin() : base(IntPtr.Zero)
		{
			CreateNativeObject (Array.Empty<IntPtr> (), Array.Empty<GLib.Value> (), 0);
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_bin_get_type();

		static GLib.GType _gtype = new GLib.GType (gtk_bin_get_type());
		public static new GLib.GType GType { 
			get {
								return _gtype;
			}
		}

#endregion
#region Customized extensions
#line 1 "Bin.custom"
// Gtk.Bin.custom - Gtk Bin class customizations
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
		static extern IntPtr gtk_bin_get_child(IntPtr raw);

		public new Gtk.Widget Child { 
			get {
				IntPtr raw_ret = gtk_bin_get_child(Handle);
				Gtk.Widget ret;
				if (raw_ret == IntPtr.Zero)
					ret = null;
				else
					ret = (Gtk.Widget) GLib.Object.GetObject(raw_ret);
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("child", val);
				val.Dispose ();
			}
		}


#endregion
	}

	internal class BinAttribute : GLib.GTypeTypeAttribute {
		[DllImport ("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_bin_get_type ();

		private static GLib.GType _gtype = new GLib.GType (gtk_bin_get_type ());
		public static GLib.GType GType { get { return _gtype; } }
		public override GLib.GType Type { get { return _gtype; } }

	}
}
