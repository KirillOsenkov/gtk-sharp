// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[Assistant]
	public class Assistant : Gtk.Window {

		[Obsolete]
		protected Assistant(GLib.GType gtype) : base(gtype) {}
		public Assistant(IntPtr raw) : base(raw) {}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_assistant_new();

		public Assistant () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (Assistant)) {
				Gtk.Application.AssertMainThread();
				CreateNativeObject (Array.Empty<IntPtr> (), Array.Empty<GLib.Value> (), 0);
				return;
			}
			owned = true;
			Raw = gtk_assistant_new();
		}

		public class AssistantChild : Gtk.Container.ContainerChild {
			protected internal AssistantChild (Gtk.Container parent, Gtk.Widget child) : base (parent, child) {}

			[Gtk.ChildProperty ("page-type")]
			public Gtk.AssistantPageType PageType {
				get {
					using (GLib.Value val = parent.ChildGetProperty (child, "page-type")) {
						Gtk.AssistantPageType ret = (Gtk.AssistantPageType) (Enum) val;
						return ret;
					}
				}
				set {
					using (GLib.Value val = new GLib.Value((Enum) value)) {
						parent.ChildSetProperty(child, "page-type", val);
					}
				}
			}

			[Gtk.ChildProperty ("title")]
			public new string Title {
				get {
					using (GLib.Value val = parent.ChildGetProperty (child, "title")) {
						string ret = (string) val;
						return ret;
					}
				}
				set {
					using (GLib.Value val = new GLib.Value(value)) {
						parent.ChildSetProperty(child, "title", val);
					}
				}
			}

			[Gtk.ChildProperty ("header-image")]
			public Gdk.Pixbuf HeaderImage {
				get {
					using (GLib.Value val = parent.ChildGetProperty (child, "header-image")) {
						Gdk.Pixbuf ret = (Gdk.Pixbuf) val;
						return ret;
					}
				}
				set {
					using (GLib.Value val = new GLib.Value(value)) {
						parent.ChildSetProperty(child, "header-image", val);
					}
				}
			}

			[Gtk.ChildProperty ("sidebar-image")]
			public Gdk.Pixbuf SidebarImage {
				get {
					using (GLib.Value val = parent.ChildGetProperty (child, "sidebar-image")) {
						Gdk.Pixbuf ret = (Gdk.Pixbuf) val;
						return ret;
					}
				}
				set {
					using (GLib.Value val = new GLib.Value(value)) {
						parent.ChildSetProperty(child, "sidebar-image", val);
					}
				}
			}

			[Gtk.ChildProperty ("complete")]
			public bool Complete {
				get {
					using (GLib.Value val = parent.ChildGetProperty (child, "complete")) {
						bool ret = (bool) val;
						return ret;
					}
				}
				set {
					using (GLib.Value val = new GLib.Value(value)) {
						parent.ChildSetProperty(child, "complete", val);
					}
				}
			}

		}

		public override Gtk.Container.ContainerChild this [Gtk.Widget child] {
			get {
				return new AssistantChild (this, child);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void CancelVMDelegate (IntPtr assistant);

		[DllImport ("gtksharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtksharp_assistant_override_cancel (IntPtr gtype, CancelVMDelegate cb);

		static CancelVMDelegate CancelVMCallback;

		static void cancel_cb (IntPtr assistant)
		{
			try {
				Assistant assistant_managed = GLib.Object.GetObject (assistant, false) as Assistant;
				assistant_managed.OnCancel ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideCancel (GLib.GType gtype)
		{
			if (CancelVMCallback == null)
				CancelVMCallback = new CancelVMDelegate (cancel_cb);
			gtksharp_assistant_override_cancel (gtype.Val, CancelVMCallback);
		}

		[DllImport ("gtksharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtksharp_assistant_base_cancel (IntPtr assistant);

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.Assistant), ConnectionMethod="OverrideCancel")]
		protected virtual void OnCancel ()
		{
			Gtk.Application.AssertMainThread();
			gtksharp_assistant_base_cancel (Handle);
		}

		[GLib.Signal("cancel")]
		public event System.EventHandler Cancel {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "cancel");
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "cancel");
				sig.RemoveDelegate (value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void PrepareVMDelegate (IntPtr assistant, IntPtr page);

		[DllImport ("gtksharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtksharp_assistant_override_prepare (IntPtr gtype, PrepareVMDelegate cb);

		static PrepareVMDelegate PrepareVMCallback;

		static void prepare_cb (IntPtr assistant, IntPtr page)
		{
			try {
				Assistant assistant_managed = GLib.Object.GetObject (assistant, false) as Assistant;
				assistant_managed.OnPrepare (GLib.Object.GetObject(page) as Gtk.Widget);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverridePrepare (GLib.GType gtype)
		{
			if (PrepareVMCallback == null)
				PrepareVMCallback = new PrepareVMDelegate (prepare_cb);
			gtksharp_assistant_override_prepare (gtype.Val, PrepareVMCallback);
		}

		[DllImport ("gtksharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtksharp_assistant_base_prepare (IntPtr assistant, IntPtr page);

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.Assistant), ConnectionMethod="OverridePrepare")]
		protected virtual void OnPrepare (Gtk.Widget page)
		{
			Gtk.Application.AssertMainThread();
			gtksharp_assistant_base_prepare (Handle, page == null ? IntPtr.Zero : page.Handle);
		}

		[GLib.Signal("prepare")]
		public event Gtk.PrepareHandler Prepare {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "prepare", typeof (Gtk.PrepareArgs));
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "prepare", typeof (Gtk.PrepareArgs));
				sig.RemoveDelegate (value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ApplyVMDelegate (IntPtr assistant);

		[DllImport ("gtksharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtksharp_assistant_override_apply (IntPtr gtype, ApplyVMDelegate cb);

		static ApplyVMDelegate ApplyVMCallback;

		static void apply_cb (IntPtr assistant)
		{
			try {
				Assistant assistant_managed = GLib.Object.GetObject (assistant, false) as Assistant;
				assistant_managed.OnApply ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideApply (GLib.GType gtype)
		{
			if (ApplyVMCallback == null)
				ApplyVMCallback = new ApplyVMDelegate (apply_cb);
			gtksharp_assistant_override_apply (gtype.Val, ApplyVMCallback);
		}

		[DllImport ("gtksharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtksharp_assistant_base_apply (IntPtr assistant);

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.Assistant), ConnectionMethod="OverrideApply")]
		protected virtual void OnApply ()
		{
			Gtk.Application.AssertMainThread();
			gtksharp_assistant_base_apply (Handle);
		}

		[GLib.Signal("apply")]
		public event System.EventHandler Apply {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "apply");
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "apply");
				sig.RemoveDelegate (value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void CloseVMDelegate (IntPtr assistant);

		[DllImport ("gtksharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtksharp_assistant_override_close (IntPtr gtype, CloseVMDelegate cb);

		static CloseVMDelegate CloseVMCallback;

		static void close_cb (IntPtr assistant)
		{
			try {
				Assistant assistant_managed = GLib.Object.GetObject (assistant, false) as Assistant;
				assistant_managed.OnClose ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideClose (GLib.GType gtype)
		{
			if (CloseVMCallback == null)
				CloseVMCallback = new CloseVMDelegate (close_cb);
			gtksharp_assistant_override_close (gtype.Val, CloseVMCallback);
		}

		[DllImport ("gtksharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtksharp_assistant_base_close (IntPtr assistant);

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.Assistant), ConnectionMethod="OverrideClose")]
		protected virtual void OnClose ()
		{
			Gtk.Application.AssertMainThread();
			gtksharp_assistant_base_close (Handle);
		}

		[GLib.Signal("close")]
		public event System.EventHandler Close {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "close");
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "close");
				sig.RemoveDelegate (value);
			}
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_assistant_add_action_widget(IntPtr raw, IntPtr child);

		public void AddActionWidget(Gtk.Widget child) {
			Gtk.Application.AssertMainThread();
			gtk_assistant_add_action_widget(Handle, child == null ? IntPtr.Zero : child.Handle);
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_assistant_append_page(IntPtr raw, IntPtr page);

		public int AppendPage(Gtk.Widget page) {
			Gtk.Application.AssertMainThread();
			int raw_ret = gtk_assistant_append_page(Handle, page == null ? IntPtr.Zero : page.Handle);
			int ret = raw_ret;
			return ret;
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_assistant_get_current_page(IntPtr raw);

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_assistant_set_current_page(IntPtr raw, int page_num);

		public int CurrentPage { 
			get {
				int raw_ret = gtk_assistant_get_current_page(Handle);
				int ret = raw_ret;
				return ret;
			}
			set {
				Gtk.Application.AssertMainThread();
				gtk_assistant_set_current_page(Handle, value);
			}
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_assistant_get_n_pages(IntPtr raw);

		public int NPages { 
			get {
				int raw_ret = gtk_assistant_get_n_pages(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_assistant_get_nth_page(IntPtr raw, int page_num);

		public Gtk.Widget GetNthPage(int page_num) {
			Gtk.Application.AssertMainThread();
			IntPtr raw_ret = gtk_assistant_get_nth_page(Handle, page_num);
			Gtk.Widget ret = GLib.Object.GetObject(raw_ret) as Gtk.Widget;
			return ret;
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_assistant_get_page_complete(IntPtr raw, IntPtr page);

		public bool GetPageComplete(Gtk.Widget page) {
			Gtk.Application.AssertMainThread();
			bool raw_ret = gtk_assistant_get_page_complete(Handle, page == null ? IntPtr.Zero : page.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_assistant_get_page_header_image(IntPtr raw, IntPtr page);

		public Gdk.Pixbuf GetPageHeaderImage(Gtk.Widget page) {
			Gtk.Application.AssertMainThread();
			IntPtr raw_ret = gtk_assistant_get_page_header_image(Handle, page == null ? IntPtr.Zero : page.Handle);
			Gdk.Pixbuf ret = GLib.Object.GetObject(raw_ret) as Gdk.Pixbuf;
			return ret;
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_assistant_get_page_side_image(IntPtr raw, IntPtr page);

		public Gdk.Pixbuf GetPageSideImage(Gtk.Widget page) {
			Gtk.Application.AssertMainThread();
			IntPtr raw_ret = gtk_assistant_get_page_side_image(Handle, page == null ? IntPtr.Zero : page.Handle);
			Gdk.Pixbuf ret = GLib.Object.GetObject(raw_ret) as Gdk.Pixbuf;
			return ret;
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_assistant_get_page_title(IntPtr raw, IntPtr page);

		public string GetPageTitle(Gtk.Widget page) {
			Gtk.Application.AssertMainThread();
			IntPtr raw_ret = gtk_assistant_get_page_title(Handle, page == null ? IntPtr.Zero : page.Handle);
			string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
			return ret;
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_assistant_get_page_type(IntPtr raw, IntPtr page);

		public Gtk.AssistantPageType GetPageType(Gtk.Widget page) {
			Gtk.Application.AssertMainThread();
			int raw_ret = gtk_assistant_get_page_type(Handle, page == null ? IntPtr.Zero : page.Handle);
			Gtk.AssistantPageType ret = (Gtk.AssistantPageType) raw_ret;
			return ret;
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_assistant_get_type();

		static GLib.GType _gtype = new GLib.GType (gtk_assistant_get_type());
		public static new GLib.GType GType { 
			get {
								return _gtype;
			}
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_assistant_insert_page(IntPtr raw, IntPtr page, int position);

		public int InsertPage(Gtk.Widget page, int position) {
			Gtk.Application.AssertMainThread();
			int raw_ret = gtk_assistant_insert_page(Handle, page == null ? IntPtr.Zero : page.Handle, position);
			int ret = raw_ret;
			return ret;
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_assistant_prepend_page(IntPtr raw, IntPtr page);

		public int PrependPage(Gtk.Widget page) {
			Gtk.Application.AssertMainThread();
			int raw_ret = gtk_assistant_prepend_page(Handle, page == null ? IntPtr.Zero : page.Handle);
			int ret = raw_ret;
			return ret;
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_assistant_remove_action_widget(IntPtr raw, IntPtr child);

		public void RemoveActionWidget(Gtk.Widget child) {
			Gtk.Application.AssertMainThread();
			gtk_assistant_remove_action_widget(Handle, child == null ? IntPtr.Zero : child.Handle);
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_assistant_set_forward_page_func(IntPtr raw, GtkSharp.AssistantPageFuncNative page_func, IntPtr data, GLib.DestroyNotify destroy);

		public Gtk.AssistantPageFunc ForwardPageFunc { 
			set {
				Gtk.Application.AssertMainThread();
				IntPtr data;
				GLib.DestroyNotify destroy;
				if (value == null) {
					data = IntPtr.Zero;
					destroy = null;
				} else {
					data = (IntPtr) GCHandle.Alloc (value);
					destroy = GLib.DestroyHelper.NotifyHandler;
				}
				gtk_assistant_set_forward_page_func(Handle, (value == null) ? null : GtkSharp.AssistantPageFuncWrapper.NativeDelegate, data, destroy);
			}
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_assistant_set_page_complete(IntPtr raw, IntPtr page, bool complete);

		public void SetPageComplete(Gtk.Widget page, bool complete) {
			Gtk.Application.AssertMainThread();
			gtk_assistant_set_page_complete(Handle, page == null ? IntPtr.Zero : page.Handle, complete);
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_assistant_set_page_header_image(IntPtr raw, IntPtr page, IntPtr pixbuf);

		public void SetPageHeaderImage(Gtk.Widget page, Gdk.Pixbuf pixbuf) {
			Gtk.Application.AssertMainThread();
			gtk_assistant_set_page_header_image(Handle, page == null ? IntPtr.Zero : page.Handle, pixbuf == null ? IntPtr.Zero : pixbuf.Handle);
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_assistant_set_page_side_image(IntPtr raw, IntPtr page, IntPtr pixbuf);

		public void SetPageSideImage(Gtk.Widget page, Gdk.Pixbuf pixbuf) {
			Gtk.Application.AssertMainThread();
			gtk_assistant_set_page_side_image(Handle, page == null ? IntPtr.Zero : page.Handle, pixbuf == null ? IntPtr.Zero : pixbuf.Handle);
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_assistant_set_page_title(IntPtr raw, IntPtr page, IntPtr title);

		public void SetPageTitle(Gtk.Widget page, string title) {
			Gtk.Application.AssertMainThread();
			IntPtr native_title = GLib.Marshaller.StringToPtrGStrdup (title);
			gtk_assistant_set_page_title(Handle, page == null ? IntPtr.Zero : page.Handle, native_title);
			GLib.Marshaller.Free (native_title);
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_assistant_set_page_type(IntPtr raw, IntPtr page, int type);

		public void SetPageType(Gtk.Widget page, Gtk.AssistantPageType type) {
			Gtk.Application.AssertMainThread();
			gtk_assistant_set_page_type(Handle, page == null ? IntPtr.Zero : page.Handle, (int) type);
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_assistant_update_buttons_state(IntPtr raw);

		public void UpdateButtonsState() {
			gtk_assistant_update_buttons_state(Handle);
		}

#endregion
	}

	internal class AssistantAttribute : GLib.GTypeTypeAttribute {
		[DllImport ("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_assistant_get_type ();

		private static GLib.GType _gtype = new GLib.GType (gtk_assistant_get_type ());
		public static GLib.GType GType { get { return _gtype; } }
		public override GLib.GType Type { get { return _gtype; } }

	}
}
