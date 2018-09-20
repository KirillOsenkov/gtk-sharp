// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[HBox]
	public class HBox : Gtk.Box {

		[Obsolete]
		protected HBox(GLib.GType gtype) : base(gtype) {}
		public HBox(IntPtr raw) : base(raw) {}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_hbox_new(bool homogeneous, int spacing);

		public HBox (bool homogeneous, int spacing) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (HBox)) {
				Gtk.Application.AssertMainThread();
				unsafe {
					var vals = stackalloc GLib.Value[2];
					var names = stackalloc IntPtr[2];
					names[0] = GLib.Marshaller.StringToPtrGStrdup ("homogeneous");
					vals[0] = new GLib.Value (homogeneous);
					names[1] = GLib.Marshaller.StringToPtrGStrdup ("spacing");
					vals[1] = new GLib.Value (spacing);
					CreateNativeObject (names, vals, 2);
				}
				return;
			}
			Gtk.Application.AssertMainThread();
			owned = true;
			Raw = gtk_hbox_new(homogeneous, spacing);
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_hbox_get_type();

		static GLib.GType _gtype = new GLib.GType (gtk_hbox_get_type());
		public static new GLib.GType GType { 
			get {
								return _gtype;
			}
		}

#endregion
#region Customized extensions
#line 1 "HBox.custom"
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


public HBox () : this (false, 0) {}

#endregion
	}

	internal class HBoxAttribute : GLib.GTypeTypeAttribute {
		[DllImport ("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_hbox_get_type ();

		private static GLib.GType _gtype = new GLib.GType (gtk_hbox_get_type ());
		public static GLib.GType GType { get { return _gtype; } }
		public override GLib.GType Type { get { return _gtype; } }

	}
}
