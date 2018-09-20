// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Pango {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[AttrList]
	public class AttrList : GLib.Opaque {

		[DllImport("libpango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void pango_attr_list_change(IntPtr raw, IntPtr attr);

		public void Change(Pango.Attribute attr) {
			pango_attr_list_change(Handle, attr.Handle);
		}

		[DllImport("libpango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_attr_list_copy(IntPtr raw);

		public Pango.AttrList Copy() {
			IntPtr raw_ret = pango_attr_list_copy(Handle);
			Pango.AttrList ret = raw_ret == IntPtr.Zero ? null : (Pango.AttrList) GLib.Opaque.GetOpaque (raw_ret, typeof (Pango.AttrList), true);
			return ret;
		}

		[DllImport("libpango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_attr_list_filter(IntPtr raw, PangoSharp.AttrFilterFuncNative func, IntPtr data);

		public Pango.AttrList Filter(Pango.AttrFilterFunc func) {
			GCHandle gch = GCHandle.Alloc (func);
			IntPtr raw_ret = pango_attr_list_filter(Handle, (func == null) ? null : PangoSharp.AttrFilterFuncWrapper.NativeDelegate, (IntPtr)gch);
			Pango.AttrList ret = raw_ret == IntPtr.Zero ? null : (Pango.AttrList) GLib.Opaque.GetOpaque (raw_ret, typeof (Pango.AttrList), false);
			gch.Free();
			return ret;
		}

		[DllImport("libpango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_attr_list_get_iterator(IntPtr raw);

		public Pango.AttrIterator Iterator { 
			get {
				IntPtr raw_ret = pango_attr_list_get_iterator(Handle);
				Pango.AttrIterator ret = raw_ret == IntPtr.Zero ? null : (Pango.AttrIterator) GLib.Opaque.GetOpaque (raw_ret, typeof (Pango.AttrIterator), true);
				return ret;
			}
		}

		[DllImport("libpango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_attr_list_get_type();

		static GLib.GType _gtype = new GLib.GType (pango_attr_list_get_type());
		public static GLib.GType GType { 
			get {
								return _gtype;
			}
		}

		[DllImport("libpango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void pango_attr_list_splice(IntPtr raw, IntPtr other, int pos, int len);

		public void Splice(Pango.AttrList other, int pos, int len) {
			pango_attr_list_splice(Handle, other == null ? IntPtr.Zero : other.Handle, pos, len);
		}

		public AttrList(IntPtr raw) : base(raw) {}

		[DllImport("libpango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_attr_list_new();

		public AttrList () 
		{
			Raw = pango_attr_list_new();
		}

		[DllImport("libpango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_attr_list_ref(IntPtr raw);

		protected override void Ref (IntPtr raw)
		{
			if (!Owned) {
				pango_attr_list_ref (raw);
				Owned = true;
			}
		}

		[Obsolete("Pango.AttrList is now refcounted automatically")]
		public AttrList Ref () { return this; }

		[DllImport("libpango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void pango_attr_list_unref(IntPtr raw);

		protected override void Unref (IntPtr raw)
		{
			if (Owned) {
				pango_attr_list_unref (raw);
				Owned = false;
			}
		}

		[Obsolete("Pango.AttrList is now refcounted automatically")]
		public void Unref () {}

#endregion
#region Customized extensions
#line 1 "AttrList.custom"
// Pango.AttrList.custom - Pango AttrList customizations
//
// Authors:  Mike Kestner  <mkestner@novell.com>
//
// Copyright (c) 2008 Novell, Inc.
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
		static extern IntPtr pango_attribute_copy (IntPtr raw);

		[DllImport("libpango-1.0-0.dll", CallingConvention=CallingConvention.Cdecl)]
		static extern void pango_attr_list_insert (IntPtr raw, IntPtr attr);

		public void Insert (Pango.Attribute attr) 
		{
			pango_attr_list_insert (Handle, pango_attribute_copy (attr.Handle));
		}

		[DllImport("libpango-1.0-0.dll", CallingConvention=CallingConvention.Cdecl)]
		static extern void pango_attr_list_insert_before (IntPtr raw, IntPtr attr);

		public void InsertBefore (Pango.Attribute attr)
		{
			pango_attr_list_insert_before (Handle, pango_attribute_copy (attr.Handle));
		}


#endregion
	}

	internal class AttrListAttribute : GLib.GTypeTypeAttribute {
		[DllImport ("libpango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_attr_list_get_type ();

		private static GLib.GType _gtype = new GLib.GType (pango_attr_list_get_type ());
		public static GLib.GType GType { get { return _gtype; } }
		public override GLib.GType Type { get { return _gtype; } }

	}
}
