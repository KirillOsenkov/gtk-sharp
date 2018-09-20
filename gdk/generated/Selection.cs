// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class Selection {

		[DllImport("libgdk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gdk_selection_convert(IntPtr requestor, IntPtr selection, IntPtr target, uint time_);

		public static void Convert(Gdk.Window requestor, Gdk.Atom selection, Gdk.Atom target, uint time_) {
			gdk_selection_convert(requestor == null ? IntPtr.Zero : requestor.Handle, selection == null ? IntPtr.Zero : selection.Handle, target == null ? IntPtr.Zero : target.Handle, time_);
		}

		[DllImport("libgdk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_selection_owner_get(IntPtr selection);

		public static Gdk.Window OwnerGet(Gdk.Atom selection) {
			IntPtr raw_ret = gdk_selection_owner_get(selection == null ? IntPtr.Zero : selection.Handle);
			Gdk.Window ret = GLib.Object.GetObject(raw_ret) as Gdk.Window;
			return ret;
		}

		[DllImport("libgdk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_selection_owner_get_for_display(IntPtr display, IntPtr selection);

		public static Gdk.Window OwnerGetForDisplay(Gdk.Display display, Gdk.Atom selection) {
			IntPtr raw_ret = gdk_selection_owner_get_for_display(display == null ? IntPtr.Zero : display.Handle, selection == null ? IntPtr.Zero : selection.Handle);
			Gdk.Window ret = GLib.Object.GetObject(raw_ret) as Gdk.Window;
			return ret;
		}

		[DllImport("libgdk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gdk_selection_owner_set(IntPtr owner, IntPtr selection, uint time_, bool send_event);

		public static bool OwnerSet(Gdk.Window owner, Gdk.Atom selection, uint time_, bool send_event) {
			bool raw_ret = gdk_selection_owner_set(owner == null ? IntPtr.Zero : owner.Handle, selection == null ? IntPtr.Zero : selection.Handle, time_, send_event);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgdk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gdk_selection_owner_set_for_display(IntPtr display, IntPtr owner, IntPtr selection, uint time_, bool send_event);

		public static bool OwnerSetForDisplay(Gdk.Display display, Gdk.Window owner, Gdk.Atom selection, uint time_, bool send_event) {
			bool raw_ret = gdk_selection_owner_set_for_display(display == null ? IntPtr.Zero : display.Handle, owner == null ? IntPtr.Zero : owner.Handle, selection == null ? IntPtr.Zero : selection.Handle, time_, send_event);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgdk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gdk_selection_send_notify(uint requestor, IntPtr selection, IntPtr target, IntPtr property, uint time_);

		public static void SendNotify(uint requestor, Gdk.Atom selection, Gdk.Atom target, Gdk.Atom property, uint time_) {
			gdk_selection_send_notify(requestor, selection == null ? IntPtr.Zero : selection.Handle, target == null ? IntPtr.Zero : target.Handle, property == null ? IntPtr.Zero : property.Handle, time_);
		}

		[DllImport("libgdk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gdk_selection_send_notify_for_display(IntPtr display, uint requestor, IntPtr selection, IntPtr target, IntPtr property, uint time_);

		public static void SendNotifyForDisplay(Gdk.Display display, uint requestor, Gdk.Atom selection, Gdk.Atom target, Gdk.Atom property, uint time_) {
			gdk_selection_send_notify_for_display(display == null ? IntPtr.Zero : display.Handle, requestor, selection == null ? IntPtr.Zero : selection.Handle, target == null ? IntPtr.Zero : target.Handle, property == null ? IntPtr.Zero : property.Handle, time_);
		}

#endregion
#region Customized extensions
#line 1 "Selection.custom"
// Gdk.Selection.custom - Gdk Selection class customizations
//
// Author: Mike Kestner <mkestner@speakeasy.net>
//
// Copyright (c) 2003 Mike Kestner
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

[DllImport("gdksharpglue-2", CallingConvention=CallingConvention.Cdecl)]
static extern IntPtr gtksharp_get_gdk_selection_primary ();

public static Gdk.Atom Primary = new Gdk.Atom (gtksharp_get_gdk_selection_primary());

[DllImport("gdksharpglue-2", CallingConvention=CallingConvention.Cdecl)]
static extern IntPtr gtksharp_get_gdk_selection_secondary ();

public static Gdk.Atom Secondary = new Gdk.Atom (gtksharp_get_gdk_selection_secondary());

[DllImport("gdksharpglue-2", CallingConvention=CallingConvention.Cdecl)]
static extern IntPtr gtksharp_get_gdk_selection_clipboard ();

public static Gdk.Atom Clipboard = new Gdk.Atom (gtksharp_get_gdk_selection_clipboard());


#endregion
	}
}
