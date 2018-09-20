// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Pango {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[Context]
	public class Context : GLib.Object {

		[Obsolete]
		protected Context(GLib.GType gtype) : base(gtype) {}
		public Context(IntPtr raw) : base(raw) {}

		protected Context() : base(IntPtr.Zero)
		{
			CreateNativeObject (Array.Empty<IntPtr> (), Array.Empty<GLib.Value> (), 0);
		}

		[DllImport("libpango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int pango_context_get_base_dir(IntPtr raw);

		[DllImport("libpango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void pango_context_set_base_dir(IntPtr raw, int direction);

		public Pango.Direction BaseDir { 
			get {
				int raw_ret = pango_context_get_base_dir(Handle);
				Pango.Direction ret = (Pango.Direction) raw_ret;
				return ret;
			}
			set {
				pango_context_set_base_dir(Handle, (int) value);
			}
		}

		[DllImport("libpango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int pango_context_get_base_gravity(IntPtr raw);

		[DllImport("libpango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void pango_context_set_base_gravity(IntPtr raw, int gravity);

		public Pango.Gravity BaseGravity { 
			get {
				int raw_ret = pango_context_get_base_gravity(Handle);
				Pango.Gravity ret = (Pango.Gravity) raw_ret;
				return ret;
			}
			set {
				pango_context_set_base_gravity(Handle, (int) value);
			}
		}

		[DllImport("libpango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_context_get_font_description(IntPtr raw);

		[DllImport("libpango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void pango_context_set_font_description(IntPtr raw, IntPtr desc);

		public Pango.FontDescription FontDescription { 
			get {
				IntPtr raw_ret = pango_context_get_font_description(Handle);
				Pango.FontDescription ret = raw_ret == IntPtr.Zero ? null : (Pango.FontDescription) GLib.Opaque.GetOpaque (raw_ret, typeof (Pango.FontDescription), false);
				return ret;
			}
			set {
				pango_context_set_font_description(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("libpango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_context_get_font_map(IntPtr raw);

		public Pango.FontMap FontMap { 
			get {
				IntPtr raw_ret = pango_context_get_font_map(Handle);
				Pango.FontMap ret = GLib.Object.GetObject(raw_ret) as Pango.FontMap;
				return ret;
			}
		}

		[DllImport("libpango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int pango_context_get_gravity(IntPtr raw);

		public Pango.Gravity Gravity { 
			get {
				int raw_ret = pango_context_get_gravity(Handle);
				Pango.Gravity ret = (Pango.Gravity) raw_ret;
				return ret;
			}
		}

		[DllImport("libpango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int pango_context_get_gravity_hint(IntPtr raw);

		[DllImport("libpango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void pango_context_set_gravity_hint(IntPtr raw, int hint);

		public Pango.GravityHint GravityHint { 
			get {
				int raw_ret = pango_context_get_gravity_hint(Handle);
				Pango.GravityHint ret = (Pango.GravityHint) raw_ret;
				return ret;
			}
			set {
				pango_context_set_gravity_hint(Handle, (int) value);
			}
		}

		[DllImport("libpango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_context_get_language(IntPtr raw);

		[DllImport("libpango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void pango_context_set_language(IntPtr raw, IntPtr language);

		public Pango.Language Language { 
			get {
				IntPtr raw_ret = pango_context_get_language(Handle);
				Pango.Language ret = raw_ret == IntPtr.Zero ? null : (Pango.Language) GLib.Opaque.GetOpaque (raw_ret, typeof (Pango.Language), false);
				return ret;
			}
			set {
				pango_context_set_language(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("libpango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_context_get_matrix(IntPtr raw);

		[DllImport("libpango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void pango_context_set_matrix(IntPtr raw, ref Pango.Matrix value);

		public Pango.Matrix Matrix { 
			get {
				IntPtr raw_ret = pango_context_get_matrix(Handle);
				Pango.Matrix ret = Pango.Matrix.New (raw_ret);
				return ret;
			}
			set {
				pango_context_set_matrix(Handle, ref value);
			}
		}

		[DllImport("libpango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_context_get_metrics(IntPtr raw, IntPtr desc, IntPtr language);

		public Pango.FontMetrics GetMetrics(Pango.FontDescription desc, Pango.Language language) {
			IntPtr raw_ret = pango_context_get_metrics(Handle, desc == null ? IntPtr.Zero : desc.Handle, language == null ? IntPtr.Zero : language.Handle);
			Pango.FontMetrics ret = raw_ret == IntPtr.Zero ? null : (Pango.FontMetrics) GLib.Opaque.GetOpaque (raw_ret, typeof (Pango.FontMetrics), false);
			return ret;
		}

		[DllImport("libpango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_context_get_type();

		static GLib.GType _gtype = new GLib.GType (pango_context_get_type());
		public static new GLib.GType GType { 
			get {
								return _gtype;
			}
		}

		[DllImport("libpango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_context_load_font(IntPtr raw, IntPtr desc);

		public Pango.Font LoadFont(Pango.FontDescription desc) {
			IntPtr raw_ret = pango_context_load_font(Handle, desc == null ? IntPtr.Zero : desc.Handle);
			Pango.Font ret = GLib.Object.GetObject(raw_ret, true) as Pango.Font;
			return ret;
		}

		[DllImport("libpango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_context_load_fontset(IntPtr raw, IntPtr desc, IntPtr language);

		public Pango.Fontset LoadFontset(Pango.FontDescription desc, Pango.Language language) {
			IntPtr raw_ret = pango_context_load_fontset(Handle, desc == null ? IntPtr.Zero : desc.Handle, language == null ? IntPtr.Zero : language.Handle);
			Pango.Fontset ret = GLib.Object.GetObject(raw_ret, true) as Pango.Fontset;
			return ret;
		}

#endregion
#region Customized extensions
#line 1 "Context.custom"
// Pango.Context.custom - Pango Context class customizations
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
		static extern void pango_context_list_families(IntPtr raw, out IntPtr families, out int n_families);

		public FontFamily [] Families {
			get {
				int count;
				IntPtr array_ptr;
				pango_context_list_families (Handle, out array_ptr, out count);
				if (array_ptr == IntPtr.Zero)
					return new FontFamily [0];
				FontFamily [] result = new FontFamily [count];
				for (int i = 0; i < count; i++) {
					IntPtr fam_ptr = Marshal.ReadIntPtr (array_ptr, i * IntPtr.Size);
					result [i] = GLib.Object.GetObject (fam_ptr) as FontFamily;
				}

				g_free (array_ptr);
				return result;
			}
		}

		[DllImport("libpango-1.0-0.dll", CallingConvention=CallingConvention.Cdecl)]
		static extern void pango_context_list_families(IntPtr raw, IntPtr families, out int n_families);

		[Obsolete]
		public int ListFamilies(Pango.FontFamily families) {
			int n_families;
			pango_context_list_families(Handle, families.Handle, out n_families);
			return n_families;
		}


#endregion
	}

	internal class ContextAttribute : GLib.GTypeTypeAttribute {
		[DllImport ("libpango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_context_get_type ();

		private static GLib.GType _gtype = new GLib.GType (pango_context_get_type ());
		public static GLib.GType GType { get { return _gtype; } }
		public override GLib.GType Type { get { return _gtype; } }

	}
}
