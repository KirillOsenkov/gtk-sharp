// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[RecentChooserWidget]
	public class RecentChooserWidget : Gtk.VBox, Gtk.RecentChooser {

		[Obsolete]
		protected RecentChooserWidget(GLib.GType gtype) : base(gtype) {}
		public RecentChooserWidget(IntPtr raw) : base(raw) {}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_recent_chooser_widget_new();

		public RecentChooserWidget () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (RecentChooserWidget)) {
				Gtk.Application.AssertMainThread();
				CreateNativeObject (Array.Empty<IntPtr> (), Array.Empty<GLib.Value> (), 0);
				return;
			}
			owned = true;
			Raw = gtk_recent_chooser_widget_new();
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_recent_chooser_widget_new_for_manager(IntPtr manager);

		public RecentChooserWidget (Gtk.RecentManager manager) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (RecentChooserWidget)) {
				Gtk.Application.AssertMainThread();
				throw new InvalidOperationException ("Can't override this constructor.");
			}
			Gtk.Application.AssertMainThread();
			owned = true;
			Raw = gtk_recent_chooser_widget_new_for_manager(manager == null ? IntPtr.Zero : manager.Handle);
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_recent_chooser_widget_get_type();

		static GLib.GType _gtype = new GLib.GType (gtk_recent_chooser_widget_get_type());
		public static new GLib.GType GType { 
			get {
								return _gtype;
			}
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_recent_chooser_add_filter(IntPtr raw, IntPtr filter);

		public void AddFilter(Gtk.RecentFilter filter) {
			Gtk.Application.AssertMainThread();
			gtk_recent_chooser_add_filter(Handle, filter == null ? IntPtr.Zero : filter.Handle);
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_recent_chooser_get_current_item(IntPtr raw);

		public Gtk.RecentInfo CurrentItem { 
			get {
				IntPtr raw_ret = gtk_recent_chooser_get_current_item(Handle);
				Gtk.RecentInfo ret = raw_ret == IntPtr.Zero ? null : (Gtk.RecentInfo) GLib.Opaque.GetOpaque (raw_ret, typeof (Gtk.RecentInfo), false);
				return ret;
			}
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_recent_chooser_get_current_uri(IntPtr raw);

		public string CurrentUri { 
			get {
				IntPtr raw_ret = gtk_recent_chooser_get_current_uri(Handle);
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				return ret;
			}
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_recent_chooser_get_items(IntPtr raw);

		public GLib.List Items { 
			get {
				IntPtr raw_ret = gtk_recent_chooser_get_items(Handle);
				GLib.List ret = new GLib.List(raw_ret);
				return ret;
			}
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_recent_chooser_get_show_numbers(IntPtr raw);

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_recent_chooser_set_show_numbers(IntPtr raw, bool show_numbers);

		[Obsolete]
		public bool ShowNumbers { 
			get {
				bool raw_ret = gtk_recent_chooser_get_show_numbers(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set {
				Gtk.Application.AssertMainThread();
				gtk_recent_chooser_set_show_numbers(Handle, value);
			}
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_recent_chooser_get_uris(IntPtr raw, out UIntPtr length);

		public string[] GetSelectedUris(out ulong length) {
			Gtk.Application.AssertMainThread();
			UIntPtr native_length;
			IntPtr raw_ret = gtk_recent_chooser_get_uris(Handle, out native_length);
			string[] ret = GLib.Marshaller.NullTermPtrToStringArray (raw_ret, true);
			length = (ulong) native_length;
			return ret;
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_recent_chooser_list_filters(IntPtr raw);

		public GLib.SList ListFilters() {
			IntPtr raw_ret = gtk_recent_chooser_list_filters(Handle);
			GLib.SList ret = new GLib.SList(raw_ret);
			return ret;
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_recent_chooser_remove_filter(IntPtr raw, IntPtr filter);

		public void RemoveFilter(Gtk.RecentFilter filter) {
			Gtk.Application.AssertMainThread();
			gtk_recent_chooser_remove_filter(Handle, filter == null ? IntPtr.Zero : filter.Handle);
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_recent_chooser_select_all(IntPtr raw);

		public void SelectAll() {
			gtk_recent_chooser_select_all(Handle);
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_recent_chooser_select_uri(IntPtr raw, IntPtr uri, out IntPtr error);

		public bool SelectUri(string uri) {
			Gtk.Application.AssertMainThread();
			IntPtr native_uri = GLib.Marshaller.StringToPtrGStrdup (uri);
			IntPtr error = IntPtr.Zero;
			bool raw_ret = gtk_recent_chooser_select_uri(Handle, native_uri, out error);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_uri);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_recent_chooser_set_current_uri(IntPtr raw, IntPtr uri, out IntPtr error);

		public bool SetCurrentUri(string uri) {
			Gtk.Application.AssertMainThread();
			IntPtr native_uri = GLib.Marshaller.StringToPtrGStrdup (uri);
			IntPtr error = IntPtr.Zero;
			bool raw_ret = gtk_recent_chooser_set_current_uri(Handle, native_uri, out error);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_uri);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_recent_chooser_set_sort_func(IntPtr raw, GtkSharp.RecentSortFuncNative sort_func, IntPtr sort_data, GLib.DestroyNotify data_destroy);

		public Gtk.RecentSortFunc SortFunc { 
			set {
				Gtk.Application.AssertMainThread();
				IntPtr sort_data;
				GLib.DestroyNotify data_destroy;
				if (value == null) {
					sort_data = IntPtr.Zero;
					data_destroy = null;
				} else {
					sort_data = (IntPtr) GCHandle.Alloc (value);
					data_destroy = GLib.DestroyHelper.NotifyHandler;
				}
				gtk_recent_chooser_set_sort_func(Handle, (value == null) ? null : GtkSharp.RecentSortFuncWrapper.NativeDelegate, sort_data, data_destroy);
			}
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_recent_chooser_unselect_all(IntPtr raw);

		public void UnselectAll() {
			gtk_recent_chooser_unselect_all(Handle);
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_recent_chooser_unselect_uri(IntPtr raw, IntPtr uri);

		public void UnselectUri(string uri) {
			Gtk.Application.AssertMainThread();
			IntPtr native_uri = GLib.Marshaller.StringToPtrGStrdup (uri);
			gtk_recent_chooser_unselect_uri(Handle, native_uri);
			GLib.Marshaller.Free (native_uri);
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_recent_chooser_get_show_private(IntPtr raw);

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_recent_chooser_set_show_private(IntPtr raw, bool show_private);

		[GLib.Property ("show-private")]
		public bool ShowPrivate {
			get  {
				bool raw_ret = gtk_recent_chooser_get_show_private(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				Gtk.Application.AssertMainThread();
				gtk_recent_chooser_set_show_private(Handle, value);
			}
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_recent_chooser_get_show_tips(IntPtr raw);

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_recent_chooser_set_show_tips(IntPtr raw, bool show_tips);

		[GLib.Property ("show-tips")]
		public bool ShowTips {
			get  {
				bool raw_ret = gtk_recent_chooser_get_show_tips(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				Gtk.Application.AssertMainThread();
				gtk_recent_chooser_set_show_tips(Handle, value);
			}
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_recent_chooser_get_show_icons(IntPtr raw);

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_recent_chooser_set_show_icons(IntPtr raw, bool show_icons);

		[GLib.Property ("show-icons")]
		public bool ShowIcons {
			get  {
				bool raw_ret = gtk_recent_chooser_get_show_icons(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				Gtk.Application.AssertMainThread();
				gtk_recent_chooser_set_show_icons(Handle, value);
			}
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_recent_chooser_get_show_not_found(IntPtr raw);

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_recent_chooser_set_show_not_found(IntPtr raw, bool show_not_found);

		[GLib.Property ("show-not-found")]
		public bool ShowNotFound {
			get  {
				bool raw_ret = gtk_recent_chooser_get_show_not_found(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				Gtk.Application.AssertMainThread();
				gtk_recent_chooser_set_show_not_found(Handle, value);
			}
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_recent_chooser_get_select_multiple(IntPtr raw);

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_recent_chooser_set_select_multiple(IntPtr raw, bool select_multiple);

		[GLib.Property ("select-multiple")]
		public bool SelectMultiple {
			get  {
				bool raw_ret = gtk_recent_chooser_get_select_multiple(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				Gtk.Application.AssertMainThread();
				gtk_recent_chooser_set_select_multiple(Handle, value);
			}
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_recent_chooser_get_local_only(IntPtr raw);

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_recent_chooser_set_local_only(IntPtr raw, bool local_only);

		[GLib.Property ("local-only")]
		public bool LocalOnly {
			get  {
				bool raw_ret = gtk_recent_chooser_get_local_only(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				Gtk.Application.AssertMainThread();
				gtk_recent_chooser_set_local_only(Handle, value);
			}
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_recent_chooser_get_limit(IntPtr raw);

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_recent_chooser_set_limit(IntPtr raw, int limit);

		[GLib.Property ("limit")]
		public int Limit {
			get  {
				int raw_ret = gtk_recent_chooser_get_limit(Handle);
				int ret = raw_ret;
				return ret;
			}
			set  {
				Gtk.Application.AssertMainThread();
				gtk_recent_chooser_set_limit(Handle, value);
			}
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_recent_chooser_get_sort_type(IntPtr raw);

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_recent_chooser_set_sort_type(IntPtr raw, int sort_type);

		[GLib.Property ("sort-type")]
		public Gtk.RecentSortType SortType {
			get  {
				int raw_ret = gtk_recent_chooser_get_sort_type(Handle);
				Gtk.RecentSortType ret = (Gtk.RecentSortType) raw_ret;
				return ret;
			}
			set  {
				Gtk.Application.AssertMainThread();
				gtk_recent_chooser_set_sort_type(Handle, (int) value);
			}
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_recent_chooser_get_filter(IntPtr raw);

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_recent_chooser_set_filter(IntPtr raw, IntPtr filter);

		[GLib.Property ("filter")]
		public Gtk.RecentFilter Filter {
			get  {
				IntPtr raw_ret = gtk_recent_chooser_get_filter(Handle);
				Gtk.RecentFilter ret = GLib.Object.GetObject(raw_ret) as Gtk.RecentFilter;
				return ret;
			}
			set  {
				Gtk.Application.AssertMainThread();
				gtk_recent_chooser_set_filter(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void SelectionChangedVMDelegate (IntPtr chooser);

		static SelectionChangedVMDelegate SelectionChangedVMCallback;

		static void selectionchanged_cb (IntPtr chooser)
		{
			try {
				RecentChooserWidget chooser_managed = GLib.Object.GetObject (chooser, false) as RecentChooserWidget;
				chooser_managed.OnSelectionChanged ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideSelectionChanged (GLib.GType gtype)
		{
			if (SelectionChangedVMCallback == null)
				SelectionChangedVMCallback = new SelectionChangedVMDelegate (selectionchanged_cb);
			OverrideVirtualMethod (gtype, "selection-changed", SelectionChangedVMCallback);
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.RecentChooserWidget), ConnectionMethod="OverrideSelectionChanged")]
		protected virtual void OnSelectionChanged ()
		{
			GLib.Value ret = GLib.Value.Empty;
			unsafe {
				GLib.Value* inst_and_params = stackalloc GLib.Value [1];
				using (inst_and_params[0] = new GLib.Value (this)) {
					g_signal_chain_from_overridden (inst_and_params, ref ret);
				}
			}
		}

		[GLib.Signal("selection-changed")]
		public event System.EventHandler SelectionChanged {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "selection-changed");
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "selection-changed");
				sig.RemoveDelegate (value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ItemActivatedVMDelegate (IntPtr chooser);

		static ItemActivatedVMDelegate ItemActivatedVMCallback;

		static void itemactivated_cb (IntPtr chooser)
		{
			try {
				RecentChooserWidget chooser_managed = GLib.Object.GetObject (chooser, false) as RecentChooserWidget;
				chooser_managed.OnItemActivated ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideItemActivated (GLib.GType gtype)
		{
			if (ItemActivatedVMCallback == null)
				ItemActivatedVMCallback = new ItemActivatedVMDelegate (itemactivated_cb);
			OverrideVirtualMethod (gtype, "item-activated", ItemActivatedVMCallback);
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.RecentChooserWidget), ConnectionMethod="OverrideItemActivated")]
		protected virtual void OnItemActivated ()
		{
			GLib.Value ret = GLib.Value.Empty;
			unsafe {
				GLib.Value* inst_and_params = stackalloc GLib.Value [1];
				using (inst_and_params[0] = new GLib.Value (this)) {
					g_signal_chain_from_overridden (inst_and_params, ref ret);
				}
			}
		}

		[GLib.Signal("item-activated")]
		public event System.EventHandler ItemActivated {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "item-activated");
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "item-activated");
				sig.RemoveDelegate (value);
			}
		}

#endregion
#region Customized extensions
#line 1 "RecentChooserWidget.custom"
		[Obsolete ("Use GetSelectedUris instead")]
		public string GetUris (out ulong length)
		{
			var res = GetSelectedUris (out length);
			if (length > 0)
				return res [0];
			return null;
		}

#endregion
	}

	internal class RecentChooserWidgetAttribute : GLib.GTypeTypeAttribute {
		[DllImport ("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_recent_chooser_widget_get_type ();

		private static GLib.GType _gtype = new GLib.GType (gtk_recent_chooser_widget_get_type ());
		public static GLib.GType GType { get { return _gtype; } }
		public override GLib.GType Type { get { return _gtype; } }

	}
}
