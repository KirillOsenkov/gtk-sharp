// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	[TreeIter]
	public struct TreeIter : IEquatable<TreeIter> {

		public int Stamp;
		private IntPtr _user_data;
		private IntPtr _user_data2;
		private IntPtr _user_data3;

		public static Gtk.TreeIter Zero = new Gtk.TreeIter ();

		public static Gtk.TreeIter New (IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Gtk.TreeIter.Zero;
			unsafe { return *(Gtk.TreeIter*)raw; }
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_tree_iter_get_type();

		public static GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_tree_iter_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("glibsharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr glibsharp_value_get_boxed (ref GLib.Value val);

		[DllImport("glibsharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void glibsharp_value_set_boxed (ref GLib.Value val, ref Gtk.TreeIter boxed);

		public static explicit operator GLib.Value (Gtk.TreeIter boxed)
		{
			GLib.Value val = GLib.Value.Empty;
			val.Init (TreeIterAttribute.GType);
			glibsharp_value_set_boxed (ref val, ref boxed);
			return val;
		}

		public static explicit operator Gtk.TreeIter (GLib.Value val)
		{
			IntPtr boxed_ptr = glibsharp_value_get_boxed (ref val);
			return New (boxed_ptr);
		}

		[Obsolete("This is a no-op")]
		public Gtk.TreeIter Copy() {
			return this;
		}
#endregion
#region Customized extensions
#line 1 "TreeIter.custom"
//
// To avoid ValueType.Equals which is slow
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

		public override int GetHashCode ()
		{
			return Stamp ^ (int)_user_data ^ (int)_user_data2 ^ (int)_user_data3;
		}

		public override bool Equals (object o)
		{
			if (!(o is TreeIter))
				return false;
			return Equals ((TreeIter)o);
		}

		public bool Equals (TreeIter ti)
		{
			return ti.Stamp == Stamp &&
					ti._user_data == _user_data &&
					ti._user_data2 == _user_data2 &&
					ti._user_data3 == _user_data3;
		}

		public IntPtr UserData {
			get {
				return _user_data;
			}
			set {
				_user_data = value;
			}
		}


#endregion
	}

	internal class TreeIterAttribute : GLib.GTypeTypeAttribute {
		[DllImport ("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_tree_iter_get_type ();

		private static GLib.GType _gtype = new GLib.GType (gtk_tree_iter_get_type ());
		public static GLib.GType GType { get { return _gtype; } }
		public override GLib.GType Type { get { return _gtype; } }

	}
}
