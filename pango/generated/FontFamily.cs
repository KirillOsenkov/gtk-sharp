// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Pango {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[FontFamily]
	public class FontFamily : GLib.Object {

		[Obsolete]
		protected FontFamily(GLib.GType gtype) : base(gtype) {}
		public FontFamily(IntPtr raw) : base(raw) {}

		protected FontFamily() : base(IntPtr.Zero)
		{
			CreateNativeObject (Array.Empty<IntPtr> (), Array.Empty<GLib.Value> (), 0);
		}

		[DllImport("libpango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_font_family_get_name(IntPtr raw);

		public string Name { 
			get {
				IntPtr raw_ret = pango_font_family_get_name(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}

		[DllImport("libpango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_font_family_get_type();

		static GLib.GType _gtype = new GLib.GType (pango_font_family_get_type());
		public static new GLib.GType GType { 
			get {
								return _gtype;
			}
		}

		[DllImport("libpango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool pango_font_family_is_monospace(IntPtr raw);

		public bool IsMonospace { 
			get {
				bool raw_ret = pango_font_family_is_monospace(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

#endregion
#region Customized extensions
#line 1 "FontFamily.custom"
// Pango.FontFamily.custom - Pango FontFamily class customizations
//
// Authors:  Mike Kestner  <mkestner@ximian.com>
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

		[DllImport("libglib-2.0-0.dll", CallingConvention=CallingConvention.Cdecl)]
		static extern void g_free (IntPtr raw);

		[DllImport("libpango-1.0-0.dll", CallingConvention=CallingConvention.Cdecl)]
		static extern void pango_font_family_list_faces(IntPtr raw, out IntPtr faces, out int n_faces);

		public FontFace [] Faces {
			get {
				int count;
				IntPtr array_ptr;
				pango_font_family_list_faces (Handle, out array_ptr, out count);
				if (array_ptr == IntPtr.Zero)
					return new FontFace [0];
				FontFace [] result = new FontFace [count];
				for (int i = 0; i < count; i++) {
					IntPtr fam_ptr = Marshal.ReadIntPtr (array_ptr, i * IntPtr.Size);
					result [i] = GLib.Object.GetObject (fam_ptr) as FontFace;
				}

				g_free (array_ptr);
				return result;
			}
		}

		[DllImport("libpango-1.0-0.dll", CallingConvention=CallingConvention.Cdecl)]
		static extern void pango_font_family_list_faces(IntPtr raw, IntPtr faces, out int n_faces);

		[Obsolete]
		public int ListFaces(Pango.FontFace faces) {
			int n_faces;
			pango_font_family_list_faces(Handle, faces.Handle, out n_faces);
			return n_faces;
		}


#endregion
	}

	internal class FontFamilyAttribute : GLib.GTypeTypeAttribute {
		[DllImport ("libpango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_font_family_get_type ();

		private static GLib.GType _gtype = new GLib.GType (pango_font_family_get_type ());
		public static GLib.GType GType { get { return _gtype; } }
		public override GLib.GType Type { get { return _gtype; } }

	}
}
