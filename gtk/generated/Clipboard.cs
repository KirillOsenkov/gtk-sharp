// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[Clipboard]
	public class Clipboard : GLib.Object {

		[Obsolete]
		protected Clipboard(GLib.GType gtype) : base(gtype) {}
		public Clipboard(IntPtr raw) : base(raw) {}

		protected Clipboard() : base(IntPtr.Zero)
		{
			CreateNativeObject (Array.Empty<IntPtr> (), Array.Empty<GLib.Value> (), 0);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void OwnerChangeVMDelegate (IntPtr clipboard, IntPtr evnt);

		static OwnerChangeVMDelegate OwnerChangeVMCallback;

		static void ownerchange_cb (IntPtr clipboard, IntPtr evnt)
		{
			try {
				Clipboard clipboard_managed = GLib.Object.GetObject (clipboard, false) as Clipboard;
				clipboard_managed.OnOwnerChange (new Gdk.EventOwnerChange(evnt));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideOwnerChange (GLib.GType gtype)
		{
			if (OwnerChangeVMCallback == null)
				OwnerChangeVMCallback = new OwnerChangeVMDelegate (ownerchange_cb);
			OverrideVirtualMethod (gtype, "owner_change", OwnerChangeVMCallback);
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.Clipboard), ConnectionMethod="OverrideOwnerChange")]
		protected virtual void OnOwnerChange (Gdk.EventOwnerChange evnt)
		{
			GLib.Value ret = GLib.Value.Empty;
			unsafe {
				GLib.Value* inst_and_params = stackalloc GLib.Value [2];
				using (inst_and_params[0] = new GLib.Value (this)) {
					using (inst_and_params [1] = new GLib.Value (evnt)) {
						g_signal_chain_from_overridden (inst_and_params, ref ret);
					}
				}
			}
		}

		[GLib.Signal("owner_change")]
		public event Gtk.OwnerChangeHandler OwnerChange {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "owner_change", typeof (Gtk.OwnerChangeArgs));
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "owner_change", typeof (Gtk.OwnerChangeArgs));
				sig.RemoveDelegate (value);
			}
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_clipboard_clear(IntPtr raw);

		public void Clear() {
			gtk_clipboard_clear(Handle);
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_clipboard_get(IntPtr selection);

		public static Gtk.Clipboard Get(Gdk.Atom selection) {
			Gtk.Application.AssertMainThread();
			IntPtr raw_ret = gtk_clipboard_get(selection == null ? IntPtr.Zero : selection.Handle);
			Gtk.Clipboard ret = GLib.Object.GetObject(raw_ret) as Gtk.Clipboard;
			return ret;
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_clipboard_get_display(IntPtr raw);

		public Gdk.Display Display { 
			get {
				IntPtr raw_ret = gtk_clipboard_get_display(Handle);
				Gdk.Display ret = GLib.Object.GetObject(raw_ret) as Gdk.Display;
				return ret;
			}
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_clipboard_get_for_display(IntPtr display, IntPtr selection);

		public static Gtk.Clipboard GetForDisplay(Gdk.Display display, Gdk.Atom selection) {
			Gtk.Application.AssertMainThread();
			IntPtr raw_ret = gtk_clipboard_get_for_display(display == null ? IntPtr.Zero : display.Handle, selection == null ? IntPtr.Zero : selection.Handle);
			Gtk.Clipboard ret = GLib.Object.GetObject(raw_ret) as Gtk.Clipboard;
			return ret;
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_clipboard_get_owner(IntPtr raw);

		public GLib.Object Owner { 
			get {
				IntPtr raw_ret = gtk_clipboard_get_owner(Handle);
				GLib.Object ret = GLib.Object.GetObject (raw_ret);
				return ret;
			}
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_clipboard_get_type();

		static GLib.GType _gtype = new GLib.GType (gtk_clipboard_get_type());
		public static new GLib.GType GType { 
			get {
								return _gtype;
			}
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_clipboard_request_contents(IntPtr raw, IntPtr target, GtkSharp.ClipboardReceivedFuncNative cb, IntPtr user_data);

		public void RequestContents(Gdk.Atom target, Gtk.ClipboardReceivedFunc cb) {
			Gtk.Application.AssertMainThread();
			IntPtr gch = IntPtr.Zero;
			if (cb != null) {
				gch = (IntPtr)GCHandle.Alloc (cb);
			}
			gtk_clipboard_request_contents(Handle, target == null ? IntPtr.Zero : target.Handle, (cb == null) ? null : GtkSharp.ClipboardReceivedFuncWrapper.NativeDelegate, (IntPtr)gch);
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_clipboard_request_image(IntPtr raw, GtkSharp.ClipboardImageReceivedFuncNative cb, IntPtr user_data);

		public void RequestImage(Gtk.ClipboardImageReceivedFunc cb) {
			Gtk.Application.AssertMainThread();
			IntPtr gch = IntPtr.Zero;
			if (cb != null) {
				gch = (IntPtr)GCHandle.Alloc (cb);
			}
			gtk_clipboard_request_image(Handle, (cb == null) ? null : GtkSharp.ClipboardImageReceivedFuncWrapper.NativeDelegate, (IntPtr)gch);
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_clipboard_request_targets(IntPtr raw, GtkSharp.ClipboardTargetsReceivedFuncNative cb, IntPtr user_data);

		public void RequestTargets(Gtk.ClipboardTargetsReceivedFunc cb) {
			Gtk.Application.AssertMainThread();
			IntPtr gch = IntPtr.Zero;
			if (cb != null) {
				gch = (IntPtr)GCHandle.Alloc (cb);
			}
			gtk_clipboard_request_targets(Handle, (cb == null) ? null : GtkSharp.ClipboardTargetsReceivedFuncWrapper.NativeDelegate, (IntPtr)gch);
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_clipboard_request_text(IntPtr raw, GtkSharp.ClipboardTextReceivedFuncNative cb, IntPtr user_data);

		public void RequestText(Gtk.ClipboardTextReceivedFunc cb) {
			Gtk.Application.AssertMainThread();
			IntPtr gch = IntPtr.Zero;
			if (cb != null) {
				gch = (IntPtr)GCHandle.Alloc (cb);
			}
			gtk_clipboard_request_text(Handle, (cb == null) ? null : GtkSharp.ClipboardTextReceivedFuncWrapper.NativeDelegate, (IntPtr)gch);
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_clipboard_set_can_store(IntPtr raw, ref Gtk.TargetEntry targets, int n_targets);

		public void SetCanStore(Gtk.TargetEntry targets, int n_targets) {
			Gtk.Application.AssertMainThread();
			gtk_clipboard_set_can_store(Handle, ref targets, n_targets);
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_clipboard_set_image(IntPtr raw, IntPtr pixbuf);

		public Gdk.Pixbuf Image { 
			set {
				Gtk.Application.AssertMainThread();
				gtk_clipboard_set_image(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_clipboard_set_text(IntPtr raw, IntPtr text, int len);

		public string Text { 
			set {
				Gtk.Application.AssertMainThread();
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_clipboard_set_text(Handle, native_value, System.Text.Encoding.UTF8.GetByteCount (value));
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_clipboard_store(IntPtr raw);

		public void Store() {
			gtk_clipboard_store(Handle);
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_clipboard_wait_for_contents(IntPtr raw, IntPtr target);

		public Gtk.SelectionData WaitForContents(Gdk.Atom target) {
			Gtk.Application.AssertMainThread();
			IntPtr raw_ret = gtk_clipboard_wait_for_contents(Handle, target == null ? IntPtr.Zero : target.Handle);
			Gtk.SelectionData ret = raw_ret == IntPtr.Zero ? null : (Gtk.SelectionData) GLib.Opaque.GetOpaque (raw_ret, typeof (Gtk.SelectionData), true);
			return ret;
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_clipboard_wait_for_image(IntPtr raw);

		public Gdk.Pixbuf WaitForImage() {
			IntPtr raw_ret = gtk_clipboard_wait_for_image(Handle);
			Gdk.Pixbuf ret = GLib.Object.GetObject(raw_ret, true) as Gdk.Pixbuf;
			return ret;
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_clipboard_wait_for_targets(IntPtr raw, out IntPtr targets, out int n_targets);

		public bool WaitForTargets(out Gdk.Atom targets, out int n_targets) {
			Gtk.Application.AssertMainThread();
			IntPtr native_targets;
			bool raw_ret = gtk_clipboard_wait_for_targets(Handle, out native_targets, out n_targets);
			bool ret = raw_ret;
			targets = native_targets == IntPtr.Zero ? null : (Gdk.Atom) GLib.Opaque.GetOpaque (native_targets, typeof (Gdk.Atom), false);
			return ret;
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_clipboard_wait_for_text(IntPtr raw);

		public string WaitForText() {
			IntPtr raw_ret = gtk_clipboard_wait_for_text(Handle);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			return ret;
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_clipboard_wait_is_image_available(IntPtr raw);

		public bool WaitIsImageAvailable() {
			bool raw_ret = gtk_clipboard_wait_is_image_available(Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_clipboard_wait_is_rich_text_available(IntPtr raw, IntPtr buffer);

		public bool WaitIsRichTextAvailable(Gtk.TextBuffer buffer) {
			Gtk.Application.AssertMainThread();
			bool raw_ret = gtk_clipboard_wait_is_rich_text_available(Handle, buffer == null ? IntPtr.Zero : buffer.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_clipboard_wait_is_target_available(IntPtr raw, IntPtr target);

		public bool WaitIsTargetAvailable(Gdk.Atom target) {
			Gtk.Application.AssertMainThread();
			bool raw_ret = gtk_clipboard_wait_is_target_available(Handle, target == null ? IntPtr.Zero : target.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_clipboard_wait_is_text_available(IntPtr raw);

		public bool WaitIsTextAvailable() {
			bool raw_ret = gtk_clipboard_wait_is_text_available(Handle);
			bool ret = raw_ret;
			return ret;
		}

#endregion
#region Customized extensions
#line 1 "Clipboard.custom"
// Gtk.Clipboard.custom - Customizations for the Clipboard class
//
// Authors:  Mike Kestner  <mkestner@novell.com>
//
// Copyright (c) 2005  Novell, Inc.
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


		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention=CallingConvention.Cdecl)]
		static extern bool gtk_clipboard_set_with_data(IntPtr raw, TargetEntry[] targets, int n_targets, GtkSharp.ClipboardGetFuncNative get_func, GtkSharp.ClipboardClearFuncNative clear_func, IntPtr data);

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention=CallingConvention.Cdecl)]
		static extern bool gtk_clipboard_set_with_owner(IntPtr raw, TargetEntry[] targets, int n_targets, GtkSharp.ClipboardGetFuncNative get_func, GtkSharp.ClipboardClearFuncNative clear_func, IntPtr owner);

		static void ClearProxy (Clipboard clipboard)
		{
			if (clipboard.PersistentData ["clear_func"] != null)  {
				ClipboardClearFunc clear = clipboard.PersistentData ["clear_func"] as ClipboardClearFunc;
				clear (clipboard);
			}
			clipboard.SetPersistentData (null, null, null);
		}

		void SetPersistentData (object get_func_wrapper, object clear_func, object clear_proxy_wrapper)
		{
			PersistentData ["get_func_wrapper"] = get_func_wrapper;
			PersistentData ["clear_func"] = clear_func;
			PersistentData ["clear_proxy_wrapper"] = clear_proxy_wrapper;
		}

		static readonly ClipboardClearFunc clear_proxy = ClearProxy;
		public bool SetWithData (TargetEntry[] targets, ClipboardGetFunc get_func, ClipboardClearFunc clear_func)
		{
			GtkSharp.ClipboardGetFuncWrapper get_func_wrapper = new GtkSharp.ClipboardGetFuncWrapper (get_func);
			GtkSharp.ClipboardClearFuncWrapper clear_proxy_wrapper = new GtkSharp.ClipboardClearFuncWrapper (clear_proxy);
			bool ret = gtk_clipboard_set_with_data (Handle, targets, targets.Length, get_func_wrapper.NativeDelegate, clear_proxy_wrapper.NativeDelegate, IntPtr.Zero);
			SetPersistentData (get_func_wrapper, clear_func, clear_proxy_wrapper);
			return ret;
		}

		public bool SetWithOwner (TargetEntry[] targets, ClipboardGetFunc get_func, ClipboardClearFunc clear_func, GLib.Object owner)
		{
			GtkSharp.ClipboardGetFuncWrapper get_func_wrapper = new GtkSharp.ClipboardGetFuncWrapper (get_func);
			GtkSharp.ClipboardClearFuncWrapper clear_proxy_wrapper = new GtkSharp.ClipboardClearFuncWrapper (clear_proxy);
			bool ret = gtk_clipboard_set_with_owner (Handle, targets, targets.Length, get_func_wrapper.NativeDelegate, clear_proxy_wrapper.NativeDelegate, owner == null ? IntPtr.Zero : owner.Handle);
			SetPersistentData (get_func_wrapper, clear_func, clear_proxy_wrapper);
			return ret;
		}

		[Obsolete ("Replaced by Text property.")]
		public void SetText (string text)
		{
			Text = text;
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention=CallingConvention.Cdecl)]
		static extern IntPtr gtk_clipboard_wait_for_rich_text (IntPtr raw, IntPtr buffer, out IntPtr format, out UIntPtr length);

		public byte[] WaitForRichText(Gtk.TextBuffer buffer, out Gdk.Atom format)
		{
			UIntPtr length;
			IntPtr format_as_native;
			IntPtr raw_ret = gtk_clipboard_wait_for_rich_text (Handle, buffer == null ? IntPtr.Zero : buffer.Handle, out format_as_native, out length);
			format = format_as_native == IntPtr.Zero ? null : (Gdk.Atom) GLib.Opaque.GetOpaque (format_as_native, typeof (Gdk.Atom), false);
			if (raw_ret == IntPtr.Zero)
				return Array.Empty<byte> ();
			int sz = (int) (uint) length;
			byte[] ret = new byte [sz];
			Marshal.Copy (ret, 0, raw_ret, sz);
			GLib.Marshaller.Free (raw_ret);
			return ret;
		}

		public delegate void RichTextReceivedFunc (Gtk.Clipboard clipboard, Gdk.Atom format, byte[] text);

		static readonly RichTextReceivedFuncNative rt_rcvd_marshaler = new RichTextReceivedFuncNative (RichTextReceivedCallback);

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void RichTextReceivedFuncNative (IntPtr clipboard, IntPtr format, IntPtr text, UIntPtr length, IntPtr data);

		static void RichTextReceivedCallback (IntPtr clipboard_ptr, IntPtr format_ptr, IntPtr text_ptr, UIntPtr length, IntPtr data)
		{
			try {
				Gtk.Clipboard clipboard = GLib.Object.GetObject(clipboard_ptr) as Gtk.Clipboard;
				Gdk.Atom format = format_ptr == IntPtr.Zero ? null : (Gdk.Atom) GLib.Opaque.GetOpaque (format_ptr, typeof (Gdk.Atom), false);
				int sz = (int) (uint) length;
				byte[] text = new byte [sz];
				Marshal.Copy (text, 0, text_ptr, sz);
				GCHandle gch = (GCHandle) data;
				RichTextReceivedFunc cb = gch.Target as RichTextReceivedFunc;
				cb (clipboard, format, text);
				gch.Free ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention=CallingConvention.Cdecl)]
		static extern void gtk_clipboard_request_rich_text(IntPtr raw, IntPtr buffer, RichTextReceivedFuncNative cb, IntPtr user_data);

		public void RequestRichText (Gtk.TextBuffer buffer, RichTextReceivedFunc cb)
		{
			gtk_clipboard_request_rich_text (Handle, buffer == null ? IntPtr.Zero : buffer.Handle, rt_rcvd_marshaler, (IntPtr) GCHandle.Alloc (cb));
		}

#endregion
	}

	internal class ClipboardAttribute : GLib.GTypeTypeAttribute {
		[DllImport ("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_clipboard_get_type ();

		private static GLib.GType _gtype = new GLib.GType (gtk_clipboard_get_type ());
		public static GLib.GType GType { get { return _gtype; } }
		public override GLib.GType Type { get { return _gtype; } }

	}
}
