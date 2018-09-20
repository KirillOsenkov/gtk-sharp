// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[VScale]
	public class VScale : Gtk.Scale {

		[Obsolete]
		protected VScale(GLib.GType gtype) : base(gtype) {}
		public VScale(IntPtr raw) : base(raw) {}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_vscale_new(IntPtr adjustment);

		public VScale (Gtk.Adjustment adjustment) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (VScale)) {
				Gtk.Application.AssertMainThread();
				unsafe {
					var vals = stackalloc GLib.Value[1];
					var names = stackalloc IntPtr[1];
					var param_count = 0;
					if (adjustment != null) {
						names[param_count] = GLib.Marshaller.StringToPtrGStrdup ("adjustment");
						vals[param_count++] = new GLib.Value (adjustment);
					}
					CreateNativeObject (names, vals, param_count);
				}
				return;
			}
			Gtk.Application.AssertMainThread();
			owned = true;
			Raw = gtk_vscale_new(adjustment == null ? IntPtr.Zero : adjustment.Handle);
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_vscale_get_type();

		static GLib.GType _gtype = new GLib.GType (gtk_vscale_get_type());
		public static new GLib.GType GType { 
			get {
								return _gtype;
			}
		}

#endregion
#region Customized extensions
#line 1 "VScale.custom"
// Gtk.VScale.custom - Gtk VScale class customizations
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
		static extern IntPtr gtk_vscale_new_with_range (double min, double max, double step);

		public VScale (double min, double max, double step) : base (IntPtr.Zero)
		{
			if (GetType() != typeof (VScale)) {
				Adjustment adj = new Adjustment (min, min, max, step, 10 * step, 0);
				unsafe {
					var names = stackalloc IntPtr [1];
					var vals = stackalloc GLib.Value [1];
					names [0] = GLib.Marshaller.StringToPtrGStrdup ("adjustment");
					vals [0] = new GLib.Value (adj);
					CreateNativeObject (names, vals, 1);
				}
				return;
			}

			owned = true;
			Raw = gtk_vscale_new_with_range (min, max, step);
		}


#endregion
	}

	internal class VScaleAttribute : GLib.GTypeTypeAttribute {
		[DllImport ("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_vscale_get_type ();

		private static GLib.GType _gtype = new GLib.GType (gtk_vscale_get_type ());
		public static GLib.GType GType { get { return _gtype; } }
		public override GLib.GType Type { get { return _gtype; } }

	}
}
