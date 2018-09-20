// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Pango {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GTypeOpaque]
	public class AttrIterator : GLib.Opaque {

		[DllImport("libpango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_attr_iterator_copy(IntPtr raw);

		public Pango.AttrIterator Copy() {
			IntPtr raw_ret = pango_attr_iterator_copy(Handle);
			Pango.AttrIterator ret = raw_ret == IntPtr.Zero ? null : (Pango.AttrIterator) GLib.Opaque.GetOpaque (raw_ret, typeof (Pango.AttrIterator), true);
			return ret;
		}

		[DllImport("libpango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_attr_iterator_get(IntPtr raw, int type);

		public Pango.Attribute Get(Pango.AttrType type) {
			IntPtr raw_ret = pango_attr_iterator_get(Handle, (int) type);
			Pango.Attribute ret = Pango.Attribute.GetAttribute (raw_ret);
			return ret;
		}

		[DllImport("libpango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool pango_attr_iterator_next(IntPtr raw);

		public bool Next() {
			bool raw_ret = pango_attr_iterator_next(Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libpango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void pango_attr_iterator_range(IntPtr raw, out int start, out int end);

		public void Range(out int start, out int end) {
			pango_attr_iterator_range(Handle, out start, out end);
		}

		public AttrIterator(IntPtr raw) : base(raw) {}

		[DllImport("libpango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void pango_attr_iterator_destroy(IntPtr raw);

		protected override void Free (IntPtr raw)
		{
			pango_attr_iterator_destroy (raw);
		}

		[Obsolete("Pango.AttrIterator is now freed automatically")]
		public void Destroy () {}

#endregion
#region Customized extensions
#line 1 "AttrIterator.custom"
// Pango.AttrIterator.custom - Pango AttrIterator class customizations
//
// Author: Mike Kestner  <mkestner@ximian.com>
//
// Copyright (c) 2004 Novell, Inc.
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


		[DllImport("libpango-1.0-0.dll", CallingConvention=CallingConvention.Cdecl)]
		static extern void pango_attr_iterator_get_font(IntPtr raw, IntPtr desc, out IntPtr language, out IntPtr extra_attrs);

		public void GetFont (out Pango.FontDescription desc, out Pango.Language language, out Pango.Attribute[] extra_attrs)
		{
			desc = new FontDescription ();
			IntPtr language_handle, list_handle;
			pango_attr_iterator_get_font (Handle, desc.Handle, out language_handle, out list_handle);
			desc.Family = desc.Family; // change static string to allocated one
			language = language_handle == IntPtr.Zero ? null : new Language (language_handle);
			if (list_handle == IntPtr.Zero) {
				extra_attrs = new Pango.Attribute [0];
				return;
			}
			GLib.SList list = new GLib.SList (list_handle, typeof(IntPtr), true, false);
			extra_attrs = new Pango.Attribute [list.Count];
			int i = 0;
			foreach (IntPtr raw_attr in list)
				extra_attrs [i++] = Pango.Attribute.GetAttribute (raw_attr, true);
		}

		[DllImport("libpango-1.0-0.dll", CallingConvention=CallingConvention.Cdecl)]
		static extern IntPtr pango_attr_iterator_get_attrs (IntPtr raw);

		public Pango.Attribute[] Attrs {
			get {
				IntPtr list_handle = pango_attr_iterator_get_attrs (Handle);
				if (list_handle == IntPtr.Zero)
					return new Pango.Attribute [0];
				GLib.SList list = new GLib.SList (list_handle, typeof(IntPtr), true, false);
				Pango.Attribute[] attrs = new Pango.Attribute [list.Count];
				int i = 0;
				foreach (IntPtr raw_attr in list)
					attrs [i++] = Pango.Attribute.GetAttribute (raw_attr, true);
				return attrs;
			}
		}

#endregion
	}
}
