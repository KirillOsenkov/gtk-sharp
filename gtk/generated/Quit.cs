// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class Quit {

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_quit_add_destroy(uint main_level, IntPtr objekt);

		public static void AddDestroy(uint main_level, Gtk.Object objekt) {
			Gtk.Application.AssertMainThread();
			gtk_quit_add_destroy(main_level, objekt == null ? IntPtr.Zero : objekt.Handle);
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_quit_remove(uint quit_handler_id);

		public static void Remove(uint quit_handler_id) {
			Gtk.Application.AssertMainThread();
			gtk_quit_remove(quit_handler_id);
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_quit_remove_by_data(IntPtr data);

		public static void RemoveByData(IntPtr data) {
			Gtk.Application.AssertMainThread();
			gtk_quit_remove_by_data(data);
		}

#endregion
#region Customized extensions
#line 1 "Quit.custom"
// Gtk.Quit.custom - Gtk Quit class customizations
//
// Author: Mike Kestner <mkestner@novell.com>
//
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


		class QuitProxy {

			Function function;
			CallbackMarshal marshal;
			IntPtr data;
			DestroyNotify destroy;

			public QuitProxy (Function function, CallbackMarshal marshal, IntPtr data, DestroyNotify destroy)
			{
				this.marshal = marshal;
				this.function = function;
				this.destroy = destroy;
				this.data = data;
			}

			static void OnDestroy (IntPtr data)
			{
				var gch = (GCHandle)data;
				var proxy = (QuitProxy)gch.Target;

				if (proxy.destroy != null)
					proxy.destroy ();

				gch.Free ();
			}

			static bool OnFunction (IntPtr data)
			{
				var gch = (GCHandle)data;
				var proxy = (QuitProxy)gch.Target;

				return proxy.function ();
			}

			static void OnCallbackMarshal (IntPtr objekt, IntPtr data, uint n_args, IntPtr args)
			{
				var gch = (GCHandle)data;
				var proxy = (QuitProxy)gch.Target;

				try {
					if (proxy.marshal != null)
						proxy.marshal (GLib.Object.GetObject (objekt) as Gtk.Object, proxy.data, n_args, Gtk.Arg.New (args));
				} catch (Exception e) {
					GLib.ExceptionManager.RaiseUnhandledException (e, false);
				}
			}

			public static GtkSharp.CallbackMarshalNative MarshalHandler = new GtkSharp.CallbackMarshalNative (OnCallbackMarshal);
			public static GtkSharp.FunctionNative FunctionHandler = new GtkSharp.FunctionNative (OnFunction);
			public static GLib.DestroyNotify DestroyHandler = new GLib.DestroyNotify (OnDestroy);
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention=CallingConvention.Cdecl)]
		static extern uint gtk_quit_add_full(uint main_level, GtkSharp.FunctionNative function, GtkSharp.CallbackMarshalNative marshal, IntPtr data, GLib.DestroyNotify destroy);

		[Obsolete ("Replaced by Add method")]
		public static uint AddFull (uint main_level, Function function, CallbackMarshal marshal, IntPtr data, DestroyNotify destroy) 
		{
			QuitProxy proxy = new QuitProxy (function, marshal, data, destroy);
			GCHandle gch = GCHandle.Alloc (proxy);
			return gtk_quit_add_full (main_level, QuitProxy.FunctionHandler, QuitProxy.MarshalHandler, (IntPtr) gch, QuitProxy.DestroyHandler);
		}

		public static uint Add (uint main_level, Function function)
		{
			QuitProxy proxy = new QuitProxy (function, null, IntPtr.Zero, null);
			GCHandle gch = GCHandle.Alloc (proxy);
			return gtk_quit_add_full (main_level, GtkSharp.FunctionWrapper.NativeDelegate, null, (IntPtr) gch, GLib.DestroyHelper.NotifyHandler);
		}



#endregion
	}
}
