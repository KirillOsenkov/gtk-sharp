// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class EventHelper {

		[DllImport("libgdk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gdk_event_free(IntPtr evnt);

		public static void Free(Gdk.Event evnt) {
			gdk_event_free(evnt == null ? IntPtr.Zero : evnt.Handle);
		}

		[DllImport("libgdk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gdk_event_get_axis(IntPtr evnt, int axis_use, out double value);

		public static bool GetAxis(Gdk.Event evnt, Gdk.AxisUse axis_use, out double value) {
			bool raw_ret = gdk_event_get_axis(evnt == null ? IntPtr.Zero : evnt.Handle, (int) axis_use, out value);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgdk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gdk_event_get_coords(IntPtr evnt, out double x_win, out double y_win);

		public static bool GetCoords(Gdk.Event evnt, out double x_win, out double y_win) {
			bool raw_ret = gdk_event_get_coords(evnt == null ? IntPtr.Zero : evnt.Handle, out x_win, out y_win);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgdk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gdk_event_get_root_coords(IntPtr evnt, out double x_root, out double y_root);

		public static bool GetRootCoords(Gdk.Event evnt, out double x_root, out double y_root) {
			bool raw_ret = gdk_event_get_root_coords(evnt == null ? IntPtr.Zero : evnt.Handle, out x_root, out y_root);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgdk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_event_get_screen(IntPtr evnt);

		public static Gdk.Screen GetScreen(Gdk.Event evnt) {
			IntPtr raw_ret = gdk_event_get_screen(evnt == null ? IntPtr.Zero : evnt.Handle);
			Gdk.Screen ret = GLib.Object.GetObject(raw_ret) as Gdk.Screen;
			return ret;
		}

		[DllImport("libgdk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gdk_event_get_state(IntPtr evnt, out int state);

		public static bool GetState(Gdk.Event evnt, out Gdk.ModifierType state) {
			int native_state;
			bool raw_ret = gdk_event_get_state(evnt == null ? IntPtr.Zero : evnt.Handle, out native_state);
			bool ret = raw_ret;
			state = (Gdk.ModifierType) native_state;
			return ret;
		}

		[DllImport("libgdk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern uint gdk_event_get_time(IntPtr evnt);

		public static uint GetTime(Gdk.Event evnt) {
			uint raw_ret = gdk_event_get_time(evnt == null ? IntPtr.Zero : evnt.Handle);
			uint ret = raw_ret;
			return ret;
		}

		[DllImport("libgdk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_event_get_type();

		static GLib.GType _gtype = new GLib.GType (gdk_event_get_type());
		public static GLib.GType GType { 
			get {
								return _gtype;
			}
		}

		[DllImport("libgdk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gdk_event_put(IntPtr evnt);

		public static void Put(Gdk.Event evnt) {
			gdk_event_put(evnt == null ? IntPtr.Zero : evnt.Handle);
		}

		[DllImport("libgdk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gdk_event_request_motions(IntPtr evnt);

		public static void RequestMotions(Gdk.EventMotion evnt) {
			gdk_event_request_motions(evnt == null ? IntPtr.Zero : evnt.Handle);
		}

		[DllImport("libgdk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gdk_event_send_client_message(IntPtr evnt, uint winid);

		public static bool SendClientMessage(Gdk.Event evnt, uint winid) {
			bool raw_ret = gdk_event_send_client_message(evnt == null ? IntPtr.Zero : evnt.Handle, winid);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgdk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gdk_event_send_client_message_for_display(IntPtr display, IntPtr evnt, uint winid);

		public static bool SendClientMessageForDisplay(Gdk.Display display, Gdk.Event evnt, uint winid) {
			bool raw_ret = gdk_event_send_client_message_for_display(display == null ? IntPtr.Zero : display.Handle, evnt == null ? IntPtr.Zero : evnt.Handle, winid);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgdk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gdk_event_send_clientmessage_toall(IntPtr evnt);

		public static void SendClientmessageToall(Gdk.Event evnt) {
			gdk_event_send_clientmessage_toall(evnt == null ? IntPtr.Zero : evnt.Handle);
		}

		[DllImport("libgdk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gdk_event_set_screen(IntPtr evnt, IntPtr screen);

		public static void SetScreen(Gdk.Event evnt, Gdk.Screen screen) {
			gdk_event_set_screen(evnt == null ? IntPtr.Zero : evnt.Handle, screen == null ? IntPtr.Zero : screen.Handle);
		}

#endregion
#region Customized extensions
#line 1 "EventHelper.custom"


		[DllImport("libgdk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_event_new(int type);

		public static Gdk.Event New(Gdk.EventType type) {
			IntPtr raw_ret = gdk_event_new((int) type);
			Gdk.Event ret = Gdk.Event.GetEvent (raw_ret, true);
			return ret;
		}

		[DllImport("libgdk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_event_get();

		public static Gdk.Event Get() {
			IntPtr raw_ret = gdk_event_get();
			Gdk.Event ret = Gdk.Event.GetEvent (raw_ret, true);
			return ret;
		}

		[DllImport("libgdk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_event_copy(IntPtr evnt);

		public static Gdk.Event Copy(Gdk.Event evnt) {
			IntPtr raw_ret = gdk_event_copy(evnt == null ? IntPtr.Zero : evnt.Handle);
			Gdk.Event ret = Gdk.Event.GetEvent (raw_ret, true);
			return ret;
		}

		[DllImport("libgdk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_event_get_graphics_expose(IntPtr window);

		public static Gdk.Event GetGraphicsExpose(Gdk.Window window) {
			IntPtr raw_ret = gdk_event_get_graphics_expose(window == null ? IntPtr.Zero : window.Handle);
			Gdk.Event ret = Gdk.Event.GetEvent (raw_ret, true);
			return ret;
		}

		[DllImport("libgdk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_event_peek();

		public static Gdk.Event Peek() {
			IntPtr raw_ret = gdk_event_peek();
			Gdk.Event ret = Gdk.Event.GetEvent (raw_ret, true);
			return ret;
		}
#endregion
	}
}
