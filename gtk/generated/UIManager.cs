// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[UIManager]
	public class UIManager : GLib.Object {

		[Obsolete]
		protected UIManager(GLib.GType gtype) : base(gtype) {}
		public UIManager(IntPtr raw) : base(raw) {}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_ui_manager_new();

		public UIManager () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (UIManager)) {
				Gtk.Application.AssertMainThread();
				CreateNativeObject (Array.Empty<IntPtr> (), Array.Empty<GLib.Value> (), 0);
				return;
			}
			owned = true;
			Raw = gtk_ui_manager_new();
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_ui_manager_get_add_tearoffs(IntPtr raw);

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_ui_manager_set_add_tearoffs(IntPtr raw, bool add_tearoffs);

		[GLib.Property ("add-tearoffs")]
		public bool AddTearoffs {
			get  {
				bool raw_ret = gtk_ui_manager_get_add_tearoffs(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				Gtk.Application.AssertMainThread();
				gtk_ui_manager_set_add_tearoffs(Handle, value);
			}
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_ui_manager_get_ui(IntPtr raw);

		[GLib.Property ("ui")]
		public string Ui {
			get  {
				IntPtr raw_ret = gtk_ui_manager_get_ui(Handle);
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void AddWidgetVMDelegate (IntPtr merge, IntPtr widget);

		[DllImport ("gtksharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtksharp_uimanager_override_add_widget (IntPtr gtype, AddWidgetVMDelegate cb);

		static AddWidgetVMDelegate AddWidgetVMCallback;

		static void addwidget_cb (IntPtr merge, IntPtr widget)
		{
			try {
				UIManager merge_managed = GLib.Object.GetObject (merge, false) as UIManager;
				merge_managed.OnAddWidget (GLib.Object.GetObject(widget) as Gtk.Widget);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideAddWidget (GLib.GType gtype)
		{
			if (AddWidgetVMCallback == null)
				AddWidgetVMCallback = new AddWidgetVMDelegate (addwidget_cb);
			gtksharp_uimanager_override_add_widget (gtype.Val, AddWidgetVMCallback);
		}

		[DllImport ("gtksharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtksharp_uimanager_base_add_widget (IntPtr merge, IntPtr widget);

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.UIManager), ConnectionMethod="OverrideAddWidget")]
		protected virtual void OnAddWidget (Gtk.Widget widget)
		{
			Gtk.Application.AssertMainThread();
			gtksharp_uimanager_base_add_widget (Handle, widget == null ? IntPtr.Zero : widget.Handle);
		}

		[GLib.Signal("add_widget")]
		public event Gtk.AddWidgetHandler AddWidget {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "add_widget", typeof (Gtk.AddWidgetArgs));
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "add_widget", typeof (Gtk.AddWidgetArgs));
				sig.RemoveDelegate (value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ActionsChangedVMDelegate (IntPtr merge);

		[DllImport ("gtksharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtksharp_uimanager_override_actions_changed (IntPtr gtype, ActionsChangedVMDelegate cb);

		static ActionsChangedVMDelegate ActionsChangedVMCallback;

		static void actionschanged_cb (IntPtr merge)
		{
			try {
				UIManager merge_managed = GLib.Object.GetObject (merge, false) as UIManager;
				merge_managed.OnActionsChanged ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideActionsChanged (GLib.GType gtype)
		{
			if (ActionsChangedVMCallback == null)
				ActionsChangedVMCallback = new ActionsChangedVMDelegate (actionschanged_cb);
			gtksharp_uimanager_override_actions_changed (gtype.Val, ActionsChangedVMCallback);
		}

		[DllImport ("gtksharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtksharp_uimanager_base_actions_changed (IntPtr merge);

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.UIManager), ConnectionMethod="OverrideActionsChanged")]
		protected virtual void OnActionsChanged ()
		{
			Gtk.Application.AssertMainThread();
			gtksharp_uimanager_base_actions_changed (Handle);
		}

		[GLib.Signal("actions_changed")]
		public event System.EventHandler ActionsChanged {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "actions_changed");
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "actions_changed");
				sig.RemoveDelegate (value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ConnectProxyVMDelegate (IntPtr merge, IntPtr action, IntPtr proxy);

		[DllImport ("gtksharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtksharp_uimanager_override_connect_proxy (IntPtr gtype, ConnectProxyVMDelegate cb);

		static ConnectProxyVMDelegate ConnectProxyVMCallback;

		static void connectproxy_cb (IntPtr merge, IntPtr action, IntPtr proxy)
		{
			try {
				UIManager merge_managed = GLib.Object.GetObject (merge, false) as UIManager;
				merge_managed.OnConnectProxy (GLib.Object.GetObject(action) as Gtk.Action, GLib.Object.GetObject(proxy) as Gtk.Widget);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideConnectProxy (GLib.GType gtype)
		{
			if (ConnectProxyVMCallback == null)
				ConnectProxyVMCallback = new ConnectProxyVMDelegate (connectproxy_cb);
			gtksharp_uimanager_override_connect_proxy (gtype.Val, ConnectProxyVMCallback);
		}

		[DllImport ("gtksharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtksharp_uimanager_base_connect_proxy (IntPtr merge, IntPtr action, IntPtr proxy);

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.UIManager), ConnectionMethod="OverrideConnectProxy")]
		protected virtual void OnConnectProxy (Gtk.Action action, Gtk.Widget proxy)
		{
			Gtk.Application.AssertMainThread();
			gtksharp_uimanager_base_connect_proxy (Handle, action == null ? IntPtr.Zero : action.Handle, proxy == null ? IntPtr.Zero : proxy.Handle);
		}

		[GLib.Signal("connect_proxy")]
		public event Gtk.ConnectProxyHandler ConnectProxy {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "connect_proxy", typeof (Gtk.ConnectProxyArgs));
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "connect_proxy", typeof (Gtk.ConnectProxyArgs));
				sig.RemoveDelegate (value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void DisconnectProxyVMDelegate (IntPtr merge, IntPtr action, IntPtr proxy);

		[DllImport ("gtksharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtksharp_uimanager_override_disconnect_proxy (IntPtr gtype, DisconnectProxyVMDelegate cb);

		static DisconnectProxyVMDelegate DisconnectProxyVMCallback;

		static void disconnectproxy_cb (IntPtr merge, IntPtr action, IntPtr proxy)
		{
			try {
				UIManager merge_managed = GLib.Object.GetObject (merge, false) as UIManager;
				merge_managed.OnDisconnectProxy (GLib.Object.GetObject(action) as Gtk.Action, GLib.Object.GetObject(proxy) as Gtk.Widget);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideDisconnectProxy (GLib.GType gtype)
		{
			if (DisconnectProxyVMCallback == null)
				DisconnectProxyVMCallback = new DisconnectProxyVMDelegate (disconnectproxy_cb);
			gtksharp_uimanager_override_disconnect_proxy (gtype.Val, DisconnectProxyVMCallback);
		}

		[DllImport ("gtksharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtksharp_uimanager_base_disconnect_proxy (IntPtr merge, IntPtr action, IntPtr proxy);

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.UIManager), ConnectionMethod="OverrideDisconnectProxy")]
		protected virtual void OnDisconnectProxy (Gtk.Action action, Gtk.Widget proxy)
		{
			Gtk.Application.AssertMainThread();
			gtksharp_uimanager_base_disconnect_proxy (Handle, action == null ? IntPtr.Zero : action.Handle, proxy == null ? IntPtr.Zero : proxy.Handle);
		}

		[GLib.Signal("disconnect_proxy")]
		public event Gtk.DisconnectProxyHandler DisconnectProxy {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "disconnect_proxy", typeof (Gtk.DisconnectProxyArgs));
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "disconnect_proxy", typeof (Gtk.DisconnectProxyArgs));
				sig.RemoveDelegate (value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void PreActivateVMDelegate (IntPtr merge, IntPtr action);

		[DllImport ("gtksharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtksharp_uimanager_override_pre_activate (IntPtr gtype, PreActivateVMDelegate cb);

		static PreActivateVMDelegate PreActivateVMCallback;

		static void preactivate_cb (IntPtr merge, IntPtr action)
		{
			try {
				UIManager merge_managed = GLib.Object.GetObject (merge, false) as UIManager;
				merge_managed.OnPreActivate (GLib.Object.GetObject(action) as Gtk.Action);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverridePreActivate (GLib.GType gtype)
		{
			if (PreActivateVMCallback == null)
				PreActivateVMCallback = new PreActivateVMDelegate (preactivate_cb);
			gtksharp_uimanager_override_pre_activate (gtype.Val, PreActivateVMCallback);
		}

		[DllImport ("gtksharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtksharp_uimanager_base_pre_activate (IntPtr merge, IntPtr action);

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.UIManager), ConnectionMethod="OverridePreActivate")]
		protected virtual void OnPreActivate (Gtk.Action action)
		{
			Gtk.Application.AssertMainThread();
			gtksharp_uimanager_base_pre_activate (Handle, action == null ? IntPtr.Zero : action.Handle);
		}

		[GLib.Signal("pre_activate")]
		public event Gtk.PreActivateHandler PreActivate {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "pre_activate", typeof (Gtk.PreActivateArgs));
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "pre_activate", typeof (Gtk.PreActivateArgs));
				sig.RemoveDelegate (value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void PostActivateVMDelegate (IntPtr merge, IntPtr action);

		[DllImport ("gtksharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtksharp_uimanager_override_post_activate (IntPtr gtype, PostActivateVMDelegate cb);

		static PostActivateVMDelegate PostActivateVMCallback;

		static void postactivate_cb (IntPtr merge, IntPtr action)
		{
			try {
				UIManager merge_managed = GLib.Object.GetObject (merge, false) as UIManager;
				merge_managed.OnPostActivate (GLib.Object.GetObject(action) as Gtk.Action);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverridePostActivate (GLib.GType gtype)
		{
			if (PostActivateVMCallback == null)
				PostActivateVMCallback = new PostActivateVMDelegate (postactivate_cb);
			gtksharp_uimanager_override_post_activate (gtype.Val, PostActivateVMCallback);
		}

		[DllImport ("gtksharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtksharp_uimanager_base_post_activate (IntPtr merge, IntPtr action);

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.UIManager), ConnectionMethod="OverridePostActivate")]
		protected virtual void OnPostActivate (Gtk.Action action)
		{
			Gtk.Application.AssertMainThread();
			gtksharp_uimanager_base_post_activate (Handle, action == null ? IntPtr.Zero : action.Handle);
		}

		[GLib.Signal("post_activate")]
		public event Gtk.PostActivateHandler PostActivate {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "post_activate", typeof (Gtk.PostActivateArgs));
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "post_activate", typeof (Gtk.PostActivateArgs));
				sig.RemoveDelegate (value);
			}
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_ui_manager_add_ui(IntPtr raw, uint merge_id, IntPtr path, IntPtr name, IntPtr action, int type, bool top);

		public void AddUi(uint merge_id, string path, string name, string action, Gtk.UIManagerItemType type, bool top) {
			Gtk.Application.AssertMainThread();
			IntPtr native_path = GLib.Marshaller.StringToPtrGStrdup (path);
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			IntPtr native_action = GLib.Marshaller.StringToPtrGStrdup (action);
			gtk_ui_manager_add_ui(Handle, merge_id, native_path, native_name, native_action, (int) type, top);
			GLib.Marshaller.Free (native_path);
			GLib.Marshaller.Free (native_name);
			GLib.Marshaller.Free (native_action);
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe uint gtk_ui_manager_add_ui_from_file(IntPtr raw, IntPtr filename, out IntPtr error);

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe uint gtk_ui_manager_add_ui_from_file_utf8(IntPtr raw, IntPtr filename, out IntPtr error);

		public unsafe uint AddUiFromFile(string filename) {
			Gtk.Application.AssertMainThread();
			IntPtr native_filename = GLib.Marshaller.StringToPtrGStrdup (filename);
			IntPtr error = IntPtr.Zero;
			uint raw_ret;
			if (Environment.OSVersion.Platform == PlatformID.Win32NT ||
			    Environment.OSVersion.Platform == PlatformID.Win32S ||
			    Environment.OSVersion.Platform == PlatformID.Win32Windows ||
			    Environment.OSVersion.Platform == PlatformID.WinCE)
				raw_ret = gtk_ui_manager_add_ui_from_file_utf8(Handle, native_filename, out error);
			else
				raw_ret = gtk_ui_manager_add_ui_from_file(Handle, native_filename, out error);
			uint ret = raw_ret;

			GLib.Marshaller.Free (native_filename);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe uint gtk_ui_manager_add_ui_from_string(IntPtr raw, IntPtr buffer, IntPtr length, out IntPtr error);

		public unsafe uint AddUiFromString(string buffer) {
			Gtk.Application.AssertMainThread();
			IntPtr native_buffer = GLib.Marshaller.StringToPtrGStrdup (buffer);
			IntPtr error = IntPtr.Zero;
			uint raw_ret = gtk_ui_manager_add_ui_from_string(Handle, native_buffer, new IntPtr ((long) System.Text.Encoding.UTF8.GetByteCount (buffer)), out error);
			uint ret = raw_ret;
			GLib.Marshaller.Free (native_buffer);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_ui_manager_ensure_update(IntPtr raw);

		public void EnsureUpdate() {
			gtk_ui_manager_ensure_update(Handle);
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_ui_manager_get_accel_group(IntPtr raw);

		public Gtk.AccelGroup AccelGroup { 
			get {
				IntPtr raw_ret = gtk_ui_manager_get_accel_group(Handle);
				Gtk.AccelGroup ret = GLib.Object.GetObject(raw_ret) as Gtk.AccelGroup;
				return ret;
			}
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_ui_manager_get_action(IntPtr raw, IntPtr path);

		public Gtk.Action GetAction(string path) {
			Gtk.Application.AssertMainThread();
			IntPtr native_path = GLib.Marshaller.StringToPtrGStrdup (path);
			IntPtr raw_ret = gtk_ui_manager_get_action(Handle, native_path);
			Gtk.Action ret = GLib.Object.GetObject(raw_ret) as Gtk.Action;
			GLib.Marshaller.Free (native_path);
			return ret;
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_ui_manager_get_type();

		static GLib.GType _gtype = new GLib.GType (gtk_ui_manager_get_type());
		public static new GLib.GType GType { 
			get {
								return _gtype;
			}
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_ui_manager_get_widget(IntPtr raw, IntPtr path);

		public Gtk.Widget GetWidget(string path) {
			Gtk.Application.AssertMainThread();
			IntPtr native_path = GLib.Marshaller.StringToPtrGStrdup (path);
			IntPtr raw_ret = gtk_ui_manager_get_widget(Handle, native_path);
			Gtk.Widget ret = GLib.Object.GetObject(raw_ret) as Gtk.Widget;
			GLib.Marshaller.Free (native_path);
			return ret;
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_ui_manager_insert_action_group(IntPtr raw, IntPtr action_group, int pos);

		public void InsertActionGroup(Gtk.ActionGroup action_group, int pos) {
			Gtk.Application.AssertMainThread();
			gtk_ui_manager_insert_action_group(Handle, action_group == null ? IntPtr.Zero : action_group.Handle, pos);
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_ui_manager_remove_action_group(IntPtr raw, IntPtr action_group);

		public void RemoveActionGroup(Gtk.ActionGroup action_group) {
			Gtk.Application.AssertMainThread();
			gtk_ui_manager_remove_action_group(Handle, action_group == null ? IntPtr.Zero : action_group.Handle);
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_ui_manager_remove_ui(IntPtr raw, uint merge_id);

		public void RemoveUi(uint merge_id) {
			Gtk.Application.AssertMainThread();
			gtk_ui_manager_remove_ui(Handle, merge_id);
		}

#endregion
#region Customized extensions
#line 1 "UIManager.custom"
// Gtk.UiManager.custom - Gtk UiManager class customizations
//
// Author: John Luke  <john.luke@gmail.com>
//
// Copyright (C) 2004 Novell, Inc.
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

		public uint AddUiFromResource (string resource)
		{
			if (resource == null)
				throw new ArgumentNullException ("resource");
			
			System.IO.Stream s = System.Reflection.Assembly.GetCallingAssembly ().GetManifestResourceStream (resource);
			if (s == null)
				throw new ArgumentException ("resource must be a valid resource name of 'assembly'.");

			return AddUiFromString (new System.IO.StreamReader (s).ReadToEnd ());
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention=CallingConvention.Cdecl)]
		static extern uint gtk_ui_manager_new_merge_id (IntPtr raw);

		public uint NewMergeId ()
		{
			return gtk_ui_manager_new_merge_id (Handle);
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention=CallingConvention.Cdecl)]
		static extern IntPtr gtk_ui_manager_get_toplevels (IntPtr raw, int types);

		public Widget[] GetToplevels (Gtk.UIManagerItemType types) {
			IntPtr raw_ret = gtk_ui_manager_get_toplevels (Handle, (int) types);
			return GLib.Marshaller.ListPtrToArray<Widget> (raw_ret, typeof (GLib.SList), true, false);
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention=CallingConvention.Cdecl)]
		static extern IntPtr gtk_ui_manager_get_action_groups (IntPtr raw);

		public ActionGroup[] ActionGroups { 
			get {
				IntPtr raw_ret = gtk_ui_manager_get_action_groups (Handle);
				GLib.List list = new GLib.List(raw_ret);
				return GLib.Marshaller.ListToArray<ActionGroup> (list);
			}
		}

#endregion
	}

	internal class UIManagerAttribute : GLib.GTypeTypeAttribute {
		[DllImport ("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_ui_manager_get_type ();

		private static GLib.GType _gtype = new GLib.GType (gtk_ui_manager_get_type ());
		public static GLib.GType GType { get { return _gtype; } }
		public override GLib.GType Type { get { return _gtype; } }

	}
}
