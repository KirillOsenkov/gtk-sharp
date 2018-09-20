// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[IconFactory]
	public class IconFactory : GLib.Object {

		[Obsolete]
		protected IconFactory(GLib.GType gtype) : base(gtype) {}
		public IconFactory(IntPtr raw) : base(raw) {}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_icon_factory_new();

		public IconFactory () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (IconFactory)) {
				Gtk.Application.AssertMainThread();
				CreateNativeObject (Array.Empty<IntPtr> (), Array.Empty<GLib.Value> (), 0);
				return;
			}
			owned = true;
			Raw = gtk_icon_factory_new();
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_icon_factory_add(IntPtr raw, IntPtr stock_id, IntPtr icon_set);

		public void Add(string stock_id, Gtk.IconSet icon_set) {
			Gtk.Application.AssertMainThread();
			IntPtr native_stock_id = GLib.Marshaller.StringToPtrGStrdup (stock_id);
			gtk_icon_factory_add(Handle, native_stock_id, icon_set == null ? IntPtr.Zero : icon_set.Handle);
			GLib.Marshaller.Free (native_stock_id);
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_icon_factory_add_default(IntPtr raw);

		public void AddDefault() {
			gtk_icon_factory_add_default(Handle);
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_icon_factory_get_type();

		static GLib.GType _gtype = new GLib.GType (gtk_icon_factory_get_type());
		public static new GLib.GType GType { 
			get {
								return _gtype;
			}
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_icon_factory_lookup(IntPtr raw, IntPtr stock_id);

		public Gtk.IconSet Lookup(string stock_id) {
			Gtk.Application.AssertMainThread();
			IntPtr native_stock_id = GLib.Marshaller.StringToPtrGStrdup (stock_id);
			IntPtr raw_ret = gtk_icon_factory_lookup(Handle, native_stock_id);
			Gtk.IconSet ret = raw_ret == IntPtr.Zero ? null : (Gtk.IconSet) GLib.Opaque.GetOpaque (raw_ret, typeof (Gtk.IconSet), false);
			GLib.Marshaller.Free (native_stock_id);
			return ret;
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_icon_factory_lookup_default(IntPtr stock_id);

		public static Gtk.IconSet LookupDefault(string stock_id) {
			Gtk.Application.AssertMainThread();
			IntPtr native_stock_id = GLib.Marshaller.StringToPtrGStrdup (stock_id);
			IntPtr raw_ret = gtk_icon_factory_lookup_default(native_stock_id);
			Gtk.IconSet ret = raw_ret == IntPtr.Zero ? null : (Gtk.IconSet) GLib.Opaque.GetOpaque (raw_ret, typeof (Gtk.IconSet), false);
			GLib.Marshaller.Free (native_stock_id);
			return ret;
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_icon_factory_remove_default(IntPtr raw);

		public void RemoveDefault() {
			gtk_icon_factory_remove_default(Handle);
		}

#endregion
#region Customized extensions
#line 1 "IconFactory.custom"
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
                extern static void gtk_icon_size_lookup (IconSize size, out int width, out int height);

                /// <summary> Query icon dimensions </summary>
                /// <remarks> Queries dimensions for icons of the specified size. </remarks>
                public void LookupIconSize (IconSize size, out int width, out int height)
                {
                    gtk_icon_size_lookup (size, out width, out height);
                }


#endregion
	}

	internal class IconFactoryAttribute : GLib.GTypeTypeAttribute {
		[DllImport ("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_icon_factory_get_type ();

		private static GLib.GType _gtype = new GLib.GType (gtk_icon_factory_get_type ());
		public static GLib.GType GType { get { return _gtype; } }
		public override GLib.GType Type { get { return _gtype; } }

	}
}
