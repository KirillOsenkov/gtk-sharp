// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[HandleBox]
	public class HandleBox : Gtk.Bin {

		[Obsolete]
		protected HandleBox(GLib.GType gtype) : base(gtype) {}
		public HandleBox(IntPtr raw) : base(raw) {}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_handle_box_new();

		public HandleBox () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (HandleBox)) {
				Gtk.Application.AssertMainThread();
				CreateNativeObject (Array.Empty<IntPtr> (), Array.Empty<GLib.Value> (), 0);
				return;
			}
			owned = true;
			Raw = gtk_handle_box_new();
		}

		[GLib.Property ("shadow")]
		public Gtk.ShadowType Shadow {
			get {
				using (GLib.Value val = GetProperty ("shadow")) {
					Gtk.ShadowType ret = (Gtk.ShadowType) (Enum) val;
					return ret;
				}
			}
			set {
				using (GLib.Value val = new GLib.Value((Enum) value)) {
					SetProperty("shadow", val);
				}
			}
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_handle_box_get_handle_position(IntPtr raw);

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_handle_box_set_handle_position(IntPtr raw, int position);

		[GLib.Property ("handle-position")]
		public Gtk.PositionType HandlePosition {
			get  {
				int raw_ret = gtk_handle_box_get_handle_position(Handle);
				Gtk.PositionType ret = (Gtk.PositionType) raw_ret;
				return ret;
			}
			set  {
				Gtk.Application.AssertMainThread();
				gtk_handle_box_set_handle_position(Handle, (int) value);
			}
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_handle_box_get_snap_edge(IntPtr raw);

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_handle_box_set_snap_edge(IntPtr raw, int edge);

		[GLib.Property ("snap-edge")]
		public Gtk.PositionType SnapEdge {
			get  {
				int raw_ret = gtk_handle_box_get_snap_edge(Handle);
				Gtk.PositionType ret = (Gtk.PositionType) raw_ret;
				return ret;
			}
			set  {
				Gtk.Application.AssertMainThread();
				gtk_handle_box_set_snap_edge(Handle, (int) value);
			}
		}

		[GLib.Property ("snap-edge-set")]
		public bool SnapEdgeSet {
			get {
				using (GLib.Value val = GetProperty ("snap-edge-set")) {
					bool ret = (bool) val;
					return ret;
				}
			}
			set {
				using (GLib.Value val = new GLib.Value(value)) {
					SetProperty("snap-edge-set", val);
				}
			}
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_handle_box_get_shadow_type(IntPtr raw);

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_handle_box_set_shadow_type(IntPtr raw, int type);

		public Gtk.ShadowType ShadowType {
			get  {
				int raw_ret = gtk_handle_box_get_shadow_type(Handle);
				Gtk.ShadowType ret = (Gtk.ShadowType) raw_ret;
				return ret;
			}
			set  {
				Gtk.Application.AssertMainThread();
				gtk_handle_box_set_shadow_type(Handle, (int) value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ChildAttachedVMDelegate (IntPtr handle_box, IntPtr child);

		[DllImport ("gtksharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtksharp_handlebox_override_child_attached (IntPtr gtype, ChildAttachedVMDelegate cb);

		static ChildAttachedVMDelegate ChildAttachedVMCallback;

		static void childattached_cb (IntPtr handle_box, IntPtr child)
		{
			try {
				HandleBox handle_box_managed = GLib.Object.GetObject (handle_box, false) as HandleBox;
				handle_box_managed.OnChildAttached (GLib.Object.GetObject(child) as Gtk.Widget);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideChildAttached (GLib.GType gtype)
		{
			if (ChildAttachedVMCallback == null)
				ChildAttachedVMCallback = new ChildAttachedVMDelegate (childattached_cb);
			gtksharp_handlebox_override_child_attached (gtype.Val, ChildAttachedVMCallback);
		}

		[DllImport ("gtksharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtksharp_handlebox_base_child_attached (IntPtr handle_box, IntPtr child);

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.HandleBox), ConnectionMethod="OverrideChildAttached")]
		protected virtual void OnChildAttached (Gtk.Widget child)
		{
			Gtk.Application.AssertMainThread();
			gtksharp_handlebox_base_child_attached (Handle, child == null ? IntPtr.Zero : child.Handle);
		}

		[GLib.Signal("child_attached")]
		public event Gtk.ChildAttachedHandler ChildAttached {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "child_attached", typeof (Gtk.ChildAttachedArgs));
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "child_attached", typeof (Gtk.ChildAttachedArgs));
				sig.RemoveDelegate (value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ChildDetachedVMDelegate (IntPtr handle_box, IntPtr child);

		[DllImport ("gtksharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtksharp_handlebox_override_child_detached (IntPtr gtype, ChildDetachedVMDelegate cb);

		static ChildDetachedVMDelegate ChildDetachedVMCallback;

		static void childdetached_cb (IntPtr handle_box, IntPtr child)
		{
			try {
				HandleBox handle_box_managed = GLib.Object.GetObject (handle_box, false) as HandleBox;
				handle_box_managed.OnChildDetached (GLib.Object.GetObject(child) as Gtk.Widget);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideChildDetached (GLib.GType gtype)
		{
			if (ChildDetachedVMCallback == null)
				ChildDetachedVMCallback = new ChildDetachedVMDelegate (childdetached_cb);
			gtksharp_handlebox_override_child_detached (gtype.Val, ChildDetachedVMCallback);
		}

		[DllImport ("gtksharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtksharp_handlebox_base_child_detached (IntPtr handle_box, IntPtr child);

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.HandleBox), ConnectionMethod="OverrideChildDetached")]
		protected virtual void OnChildDetached (Gtk.Widget child)
		{
			Gtk.Application.AssertMainThread();
			gtksharp_handlebox_base_child_detached (Handle, child == null ? IntPtr.Zero : child.Handle);
		}

		[GLib.Signal("child_detached")]
		public event Gtk.ChildDetachedHandler ChildDetached {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "child_detached", typeof (Gtk.ChildDetachedArgs));
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "child_detached", typeof (Gtk.ChildDetachedArgs));
				sig.RemoveDelegate (value);
			}
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_handle_box_get_type();

		static GLib.GType _gtype = new GLib.GType (gtk_handle_box_get_type());
		public static new GLib.GType GType { 
			get {
								return _gtype;
			}
		}

#endregion
	}

	internal class HandleBoxAttribute : GLib.GTypeTypeAttribute {
		[DllImport ("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_handle_box_get_type ();

		private static GLib.GType _gtype = new GLib.GType (gtk_handle_box_get_type ());
		public static GLib.GType GType { get { return _gtype; } }
		public override GLib.GType Type { get { return _gtype; } }

	}
}
