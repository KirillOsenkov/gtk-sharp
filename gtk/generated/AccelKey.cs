// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	[GLib.GTypeStruct]
	public struct AccelKey {

		public Gdk.Key Key;
		public Gdk.ModifierType AccelMods;
		private uint _bitfield0;

		[DllImport ("gtksharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		extern static int gtksharp_gtk_accelkey_get_accel_flags (ref Gtk.AccelKey raw);
		[DllImport ("gtksharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		extern static void gtksharp_gtk_accelkey_set_accel_flags (ref Gtk.AccelKey raw, int value);
		public Gtk.AccelFlags AccelFlags {
			get {
				Gtk.AccelFlags result = (Gtk.AccelFlags) gtksharp_gtk_accelkey_get_accel_flags (ref this);
				return result;
			}
			set {
				gtksharp_gtk_accelkey_set_accel_flags (ref this, (int) value);
			}
		}


		public static Gtk.AccelKey Zero = new Gtk.AccelKey ();

		public static Gtk.AccelKey New (IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Gtk.AccelKey.Zero;
			unsafe { return *(Gtk.AccelKey*)raw; }
		}

#endregion
#region Customized extensions
#line 1 "AccelKey.custom"
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

public AccelKey (Gdk.Key key, Gdk.ModifierType mods, Gtk.AccelFlags flags)
{
	this.Key = key;
	this.AccelMods = mods;
	this._bitfield0 = 0;
	this.AccelFlags = flags;
}

#endregion
	}
}
