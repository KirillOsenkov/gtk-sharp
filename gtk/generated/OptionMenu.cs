// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[Obsolete]
	[OptionMenu]
	public class OptionMenu : Gtk.Button {

		[Obsolete]
		protected OptionMenu(GLib.GType gtype) : base(gtype) {}
		public OptionMenu(IntPtr raw) : base(raw) {}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_option_menu_new();

		public OptionMenu () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (OptionMenu)) {
				Gtk.Application.AssertMainThread();
				CreateNativeObject (Array.Empty<IntPtr> (), Array.Empty<GLib.Value> (), 0);
				return;
			}
			owned = true;
			Raw = gtk_option_menu_new();
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_option_menu_get_menu(IntPtr raw);

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_option_menu_set_menu(IntPtr raw, IntPtr menu);

		[GLib.Property ("menu")]
		public Gtk.Widget Menu {
			get  {
				IntPtr raw_ret = gtk_option_menu_get_menu(Handle);
				Gtk.Widget ret = GLib.Object.GetObject(raw_ret) as Gtk.Widget;
				return ret;
			}
			set  {
				Gtk.Application.AssertMainThread();
				gtk_option_menu_set_menu(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ChangedVMDelegate (IntPtr option_menu);

		[DllImport ("gtksharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtksharp_optionmenu_override_changed (IntPtr gtype, ChangedVMDelegate cb);

		static ChangedVMDelegate ChangedVMCallback;

		static void changed_cb (IntPtr option_menu)
		{
			try {
				OptionMenu option_menu_managed = GLib.Object.GetObject (option_menu, false) as OptionMenu;
				option_menu_managed.OnChanged ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideChanged (GLib.GType gtype)
		{
			if (ChangedVMCallback == null)
				ChangedVMCallback = new ChangedVMDelegate (changed_cb);
			gtksharp_optionmenu_override_changed (gtype.Val, ChangedVMCallback);
		}

		[DllImport ("gtksharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtksharp_optionmenu_base_changed (IntPtr option_menu);

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.OptionMenu), ConnectionMethod="OverrideChanged")]
		protected virtual void OnChanged ()
		{
			Gtk.Application.AssertMainThread();
			gtksharp_optionmenu_base_changed (Handle);
		}

		[GLib.Signal("changed")]
		public event System.EventHandler Changed {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "changed");
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "changed");
				sig.RemoveDelegate (value);
			}
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_option_menu_get_history(IntPtr raw);

		public int History { 
			get {
				int raw_ret = gtk_option_menu_get_history(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_option_menu_get_type();

		static GLib.GType _gtype = new GLib.GType (gtk_option_menu_get_type());
		public static new GLib.GType GType { 
			get {
								return _gtype;
			}
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_option_menu_remove_menu(IntPtr raw);

		public void RemoveMenu() {
			gtk_option_menu_remove_menu(Handle);
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_option_menu_set_history(IntPtr raw, uint index_);

		public void SetHistory(uint index_) {
			Gtk.Application.AssertMainThread();
			gtk_option_menu_set_history(Handle, index_);
		}

#endregion
	}

	internal class OptionMenuAttribute : GLib.GTypeTypeAttribute {
		[DllImport ("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_option_menu_get_type ();

		private static GLib.GType _gtype = new GLib.GType (gtk_option_menu_get_type ());
		public static GLib.GType GType { get { return _gtype; } }
		public override GLib.GType Type { get { return _gtype; } }

	}
}
