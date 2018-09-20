// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Glade {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class Global {

		[DllImport("libglade-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int glade_enum_from_string(IntPtr type, IntPtr str1ng);

		public static int EnumFromString(GLib.GType type, string str1ng) {
			IntPtr native_str1ng = GLib.Marshaller.StringToPtrGStrdup (str1ng);
			int raw_ret = glade_enum_from_string(type.Val, native_str1ng);
			int ret = raw_ret;
			GLib.Marshaller.Free (native_str1ng);
			return ret;
		}

		[DllImport("libglade-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern uint glade_flags_from_string(IntPtr type, IntPtr str1ng);

		public static uint FlagsFromString(GLib.GType type, string str1ng) {
			IntPtr native_str1ng = GLib.Marshaller.StringToPtrGStrdup (str1ng);
			uint raw_ret = glade_flags_from_string(type.Val, native_str1ng);
			uint ret = raw_ret;
			GLib.Marshaller.Free (native_str1ng);
			return ret;
		}

		[DllImport("libglade-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr glade_get_widget_name(IntPtr widget);

		public static string GetWidgetName(Gtk.Widget widget) {
			IntPtr raw_ret = glade_get_widget_name(widget == null ? IntPtr.Zero : widget.Handle);
			string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
			return ret;
		}

		[DllImport("libglade-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr glade_get_widget_tree(IntPtr widget);

		public static Glade.XML GetWidgetTree(Gtk.Widget widget) {
			IntPtr raw_ret = glade_get_widget_tree(widget == null ? IntPtr.Zero : widget.Handle);
			Glade.XML ret = GLib.Object.GetObject(raw_ret) as Glade.XML;
			return ret;
		}

		[DllImport("libglade-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr glade_module_check_version(int version);

		public static string ModuleCheckVersion(int version) {
			IntPtr raw_ret = glade_module_check_version(version);
			string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
			return ret;
		}

		[DllImport("libglade-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void glade_register_custom_prop(IntPtr type, IntPtr prop_name, GladeSharp.ApplyCustomPropFuncNative apply_prop);

		public static void RegisterCustomProp(GLib.GType type, string prop_name, Glade.ApplyCustomPropFunc apply_prop) {
			IntPtr native_prop_name = GLib.Marshaller.StringToPtrGStrdup (prop_name);
			GladeSharp.ApplyCustomPropFuncWrapper apply_prop_wrapper = new GladeSharp.ApplyCustomPropFuncWrapper (apply_prop);
			glade_register_custom_prop(type.Val, native_prop_name, apply_prop_wrapper.NativeDelegate);
			GLib.Marshaller.Free (native_prop_name);
		}

		[DllImport("libglade-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void glade_register_widget(IntPtr type, GladeSharp.NewFuncNative new_func, GladeSharp.BuildChildrenFuncNative build_children, GladeSharp.FindInternalChildFuncNative find_internal_child);

		public static void RegisterWidget(GLib.GType type, Glade.NewFunc new_func, Glade.BuildChildrenFunc build_children, Glade.FindInternalChildFunc find_internal_child) {
			GladeSharp.NewFuncWrapper new_func_wrapper = new GladeSharp.NewFuncWrapper (new_func);
			GladeSharp.BuildChildrenFuncWrapper build_children_wrapper = new GladeSharp.BuildChildrenFuncWrapper (build_children);
			GladeSharp.FindInternalChildFuncWrapper find_internal_child_wrapper = new GladeSharp.FindInternalChildFuncWrapper (find_internal_child);
			glade_register_widget(type.Val, new_func_wrapper.NativeDelegate, build_children_wrapper.NativeDelegate, find_internal_child_wrapper.NativeDelegate);
		}

#endregion
#region Customized extensions
#line 1 "Global.custom"
// Copyright (c) 2005 Novell, Inc.
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

[Obsolete ("Replaced by Glade.XML.CustomHandler static property.")]
public static void SetCustomHandler (Glade.XMLCustomWidgetHandler handler)
{
	XML.CustomHandler = handler;
}

#endregion
	}
}
