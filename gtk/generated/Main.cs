// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class Main {

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_main_do_event(IntPtr evnt);

		public static void DoEvent(Gdk.Event evnt) {
			Gtk.Application.AssertMainThread();
			gtk_main_do_event(evnt == null ? IntPtr.Zero : evnt.Handle);
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_main_iteration();

		public static bool Iteration() {
			bool raw_ret = gtk_main_iteration();
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_main_iteration_do(bool blocking);

		public static bool IterationDo(bool blocking) {
			Gtk.Application.AssertMainThread();
			bool raw_ret = gtk_main_iteration_do(blocking);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern uint gtk_main_level();

		public static uint Level() {
			uint raw_ret = gtk_main_level();
			uint ret = raw_ret;
			return ret;
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_main_quit();

		public static void Quit() {
			gtk_main_quit();
		}

#endregion
	}
}
