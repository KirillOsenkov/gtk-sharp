// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Atk {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[Hyperlink]
	public class Hyperlink : GLib.Object, Atk.Action {

		[Obsolete]
		protected Hyperlink(GLib.GType gtype) : base(gtype) {}
		public Hyperlink(IntPtr raw) : base(raw) {}

		protected Hyperlink() : base(IntPtr.Zero)
		{
			CreateNativeObject (Array.Empty<IntPtr> (), Array.Empty<GLib.Value> (), 0);
		}

		[GLib.Property ("selected-link")]
		public bool SelectedLink {
			get {
				using (GLib.Value val = GetProperty ("selected-link")) {
					bool ret = (bool) val;
					return ret;
				}
			}
		}

		[GLib.Property ("number-of-anchors")]
		public int NumberOfAnchors {
			get {
				using (GLib.Value val = GetProperty ("number-of-anchors")) {
					int ret = (int) val;
					return ret;
				}
			}
		}

		[DllImport("libatk-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int atk_hyperlink_get_end_index(IntPtr raw);

		[GLib.Property ("end-index")]
		public int EndIndex {
			get  {
				int raw_ret = atk_hyperlink_get_end_index(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libatk-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int atk_hyperlink_get_start_index(IntPtr raw);

		[GLib.Property ("start-index")]
		public int StartIndex {
			get  {
				int raw_ret = atk_hyperlink_get_start_index(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void LinkActivatedVMDelegate (IntPtr link_);

		[DllImport ("atksharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void atksharp_hyperlink_override_link_activated (IntPtr gtype, LinkActivatedVMDelegate cb);

		static LinkActivatedVMDelegate LinkActivatedVMCallback;

		static void linkactivated_cb (IntPtr link_)
		{
			try {
				Hyperlink link__managed = GLib.Object.GetObject (link_, false) as Hyperlink;
				link__managed.OnLinkActivated ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideLinkActivated (GLib.GType gtype)
		{
			if (LinkActivatedVMCallback == null)
				LinkActivatedVMCallback = new LinkActivatedVMDelegate (linkactivated_cb);
			atksharp_hyperlink_override_link_activated (gtype.Val, LinkActivatedVMCallback);
		}

		[DllImport ("atksharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void atksharp_hyperlink_base_link_activated (IntPtr link_);

		[GLib.DefaultSignalHandler(Type=typeof(Atk.Hyperlink), ConnectionMethod="OverrideLinkActivated")]
		protected virtual void OnLinkActivated ()
		{
			atksharp_hyperlink_base_link_activated (Handle);
		}

		[GLib.Signal("link_activated")]
		public event System.EventHandler LinkActivated {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "link_activated");
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "link_activated");
				sig.RemoveDelegate (value);
			}
		}

		[DllImport("libatk-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int atk_hyperlink_get_n_anchors(IntPtr raw);

		public int NAnchors { 
			get {
				int raw_ret = atk_hyperlink_get_n_anchors(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libatk-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr atk_hyperlink_get_object(IntPtr raw, int i);

		public Atk.Object GetObject(int i) {
			IntPtr raw_ret = atk_hyperlink_get_object(Handle, i);
			Atk.Object ret = GLib.Object.GetObject(raw_ret) as Atk.Object;
			return ret;
		}

		[DllImport("libatk-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr atk_hyperlink_get_type();

		static GLib.GType _gtype = new GLib.GType (atk_hyperlink_get_type());
		public static new GLib.GType GType { 
			get {
								return _gtype;
			}
		}

		[DllImport("libatk-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr atk_hyperlink_get_uri(IntPtr raw, int i);

		public string GetUri(int i) {
			IntPtr raw_ret = atk_hyperlink_get_uri(Handle, i);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			return ret;
		}

		[DllImport("libatk-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool atk_hyperlink_is_inline(IntPtr raw);

		public bool IsInline { 
			get {
				bool raw_ret = atk_hyperlink_is_inline(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libatk-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool atk_hyperlink_is_selected_link(IntPtr raw);

		public bool IsSelectedLink { 
			get {
				bool raw_ret = atk_hyperlink_is_selected_link(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libatk-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool atk_hyperlink_is_valid(IntPtr raw);

		public bool IsValid { 
			get {
				bool raw_ret = atk_hyperlink_is_valid(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libatk-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool atk_action_do_action(IntPtr raw, int i);

		public bool DoAction(int i) {
			bool raw_ret = atk_action_do_action(Handle, i);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libatk-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr atk_action_get_description(IntPtr raw, int i);

		public string GetDescription(int i) {
			IntPtr raw_ret = atk_action_get_description(Handle, i);
			string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
			return ret;
		}

		[DllImport("libatk-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr atk_action_get_keybinding(IntPtr raw, int i);

		public string GetKeybinding(int i) {
			IntPtr raw_ret = atk_action_get_keybinding(Handle, i);
			string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
			return ret;
		}

		[DllImport("libatk-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr atk_action_get_localized_name(IntPtr raw, int i);

		public string GetLocalizedName(int i) {
			IntPtr raw_ret = atk_action_get_localized_name(Handle, i);
			string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
			return ret;
		}

		[DllImport("libatk-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int atk_action_get_n_actions(IntPtr raw);

		public int NActions { 
			get {
				int raw_ret = atk_action_get_n_actions(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libatk-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr atk_action_get_name(IntPtr raw, int i);

		public string GetName(int i) {
			IntPtr raw_ret = atk_action_get_name(Handle, i);
			string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
			return ret;
		}

		[DllImport("libatk-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool atk_action_set_description(IntPtr raw, int i, IntPtr desc);

		public bool SetDescription(int i, string desc) {
			IntPtr native_desc = GLib.Marshaller.StringToPtrGStrdup (desc);
			bool raw_ret = atk_action_set_description(Handle, i, native_desc);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_desc);
			return ret;
		}

#endregion
#region Customized extensions
#line 1 "Hyperlink.custom"
// Hyperlink.custom - Atk Hyperlink class customizations
//
// Author: Mike Gorse <mgorse@novell.com>
//
// Copyright (c) 2008 Novell, Inc.
//
// This code is inserted after the automatically generated code.
//
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

		[DllImport("atksharpglue-2", CallingConvention=CallingConvention.Cdecl)]
		static extern void atksharp_hyperlink_override_get_uri (IntPtr type, GetUriDelegate cb);

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr GetUriDelegate (IntPtr raw, int i);

		static GetUriDelegate GetUriCallback;

		static IntPtr GetUri_cb (IntPtr raw, int i)
		{
			try {
				Atk.Hyperlink obj = GLib.Object.GetObject (raw, false) as Atk.Hyperlink;
				return GLib.Marshaller.StringToPtrGStrdup (obj.OnGetUri (i));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}

			return IntPtr.Zero;
		}

		static void OverrideGetUri (GLib.GType gtype)
		{
			if (GetUriCallback == null)
				GetUriCallback = new GetUriDelegate (GetUri_cb);
			atksharp_hyperlink_override_get_uri (gtype.Val, GetUriCallback);
		}

		[GLib.DefaultSignalHandler (Type=typeof(Atk.Hyperlink), ConnectionMethod="OverrideGetUri")]
		protected virtual string OnGetUri (int i)
	{
			return null;
		}
		[DllImport("atksharpglue-2", CallingConvention=CallingConvention.Cdecl)]
		static extern void atksharp_hyperlink_override_get_object (IntPtr type, GetObjectDelegate cb);

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr GetObjectDelegate (IntPtr raw, int i);

		static GetObjectDelegate GetObjectCallback;

		static IntPtr GetObject_cb (IntPtr raw, int i)
		{
			try {
				Atk.Hyperlink obj = GLib.Object.GetObject (raw, false) as Atk.Hyperlink;
				Atk.Object ret = obj.OnGetObject (i);
				return ret == null ? IntPtr.Zero : ret.Handle;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}

			return IntPtr.Zero;
		}

		static void OverrideGetObject (GLib.GType gtype)
		{
			if (GetObjectCallback == null)
				GetObjectCallback = new GetObjectDelegate (GetObject_cb);
			atksharp_hyperlink_override_get_object (gtype.Val, GetObjectCallback);
		}

		[GLib.DefaultSignalHandler (Type=typeof(Atk.Hyperlink), ConnectionMethod="OverrideGetObject")]
		protected virtual Atk.Object OnGetObject (int i)
		{
			return null;
		}

		[DllImport("atksharpglue-2", CallingConvention=CallingConvention.Cdecl)]
		static extern void atksharp_hyperlink_override_get_end_index (IntPtr type, GetEndIndexDelegate cb);

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int GetEndIndexDelegate (IntPtr raw);

		static GetEndIndexDelegate GetEndIndexCallback;

		static int GetEndIndex_cb (IntPtr raw)
		{
			try {
				Atk.Hyperlink obj = GLib.Object.GetObject (raw, false) as Atk.Hyperlink;
				return obj.OnGetEndIndex ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}

			return -1;
		}

		static void OverrideGetEndIndex (GLib.GType gtype)
		{
			if (GetEndIndexCallback == null)
				GetEndIndexCallback = new GetEndIndexDelegate (GetEndIndex_cb);
			atksharp_hyperlink_override_get_end_index (gtype.Val, GetEndIndexCallback);
		}

		[GLib.DefaultSignalHandler (Type=typeof(Atk.Hyperlink), ConnectionMethod="OverrideGetEndIndex")]
		protected virtual int OnGetEndIndex ()
		{
			return -1;
		}

		[DllImport("atksharpglue-2", CallingConvention=CallingConvention.Cdecl)]
		static extern void atksharp_hyperlink_override_get_start_index (IntPtr type, GetStartIndexDelegate cb);

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int GetStartIndexDelegate (IntPtr raw);

		static GetStartIndexDelegate GetStartIndexCallback;

		static int GetStartIndex_cb (IntPtr raw)
		{
			try {
				Atk.Hyperlink obj = GLib.Object.GetObject (raw, false) as Atk.Hyperlink;
				return obj.OnGetStartIndex ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}

			return -1;
		}

		static void OverrideGetStartIndex (GLib.GType gtype)
		{
			if (GetStartIndexCallback == null)
				GetStartIndexCallback = new GetStartIndexDelegate (GetStartIndex_cb);
			atksharp_hyperlink_override_get_start_index (gtype.Val, GetStartIndexCallback);
		}

		[GLib.DefaultSignalHandler (Type=typeof(Atk.Hyperlink), ConnectionMethod="OverrideGetStartIndex")]
		protected virtual int OnGetStartIndex ()
		{
			return -1;
		}

		[DllImport("atksharpglue-2", CallingConvention=CallingConvention.Cdecl)]
		static extern void atksharp_hyperlink_override_is_valid (IntPtr type, IsValidDelegate cb);

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool IsValidDelegate (IntPtr raw);

		static IsValidDelegate IsValidCallback;

		static bool IsValid_cb (IntPtr raw)
		{
			try {
				Atk.Hyperlink obj = GLib.Object.GetObject (raw, false) as Atk.Hyperlink;
				return obj.OnIsValid ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}

			return false;
		}

		static void OverrideIsValid (GLib.GType gtype)
		{
			if (IsValidCallback == null)
				IsValidCallback = new IsValidDelegate (IsValid_cb);
			atksharp_hyperlink_override_is_valid (gtype.Val, IsValidCallback);
		}

		[GLib.DefaultSignalHandler (Type=typeof(Atk.Hyperlink), ConnectionMethod="OverrideIsValid")]
		protected virtual bool OnIsValid()
		{
			return false;
		}

		[DllImport("atksharpglue-2", CallingConvention=CallingConvention.Cdecl)]
		static extern void atksharp_hyperlink_override_get_n_anchors (IntPtr type, GetNAnchorsDelegate cb);

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int GetNAnchorsDelegate (IntPtr raw);

		static GetNAnchorsDelegate GetNAnchorsCallback;

		static int GetNAnchors_cb (IntPtr raw)
		{
			try {
				Atk.Hyperlink obj = GLib.Object.GetObject (raw, false) as Atk.Hyperlink;
				return obj.OnGetNAnchors ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}

			return 0;
		}

		static void OverrideGetNAnchors (GLib.GType gtype)
		{
			if (GetNAnchorsCallback == null)
				GetNAnchorsCallback = new GetNAnchorsDelegate (GetNAnchors_cb);
			atksharp_hyperlink_override_get_n_anchors (gtype.Val, GetNAnchorsCallback);
		}

		[GLib.DefaultSignalHandler (Type=typeof(Atk.Hyperlink), ConnectionMethod="OverrideGetNAnchors")]
		protected virtual int OnGetNAnchors ()
		{
			return 0;
		}

		[DllImport("atksharpglue-2", CallingConvention=CallingConvention.Cdecl)]
		static extern void atksharp_hyperlink_override_link_state (IntPtr type, LinkStateDelegate cb);

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate uint LinkStateDelegate (IntPtr raw);

		static LinkStateDelegate LinkStateCallback;

		static uint LinkState_cb (IntPtr raw)
		{
			try {
				Atk.Hyperlink obj = GLib.Object.GetObject (raw, false) as Atk.Hyperlink;
				return obj.OnLinkState ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}

			return 0;
		}

		static void OverrideLinkState (GLib.GType gtype)
		{
			if (LinkStateCallback == null)
				LinkStateCallback = new LinkStateDelegate (LinkState_cb);
			atksharp_hyperlink_override_link_state (gtype.Val, LinkStateCallback);
		}

		[GLib.DefaultSignalHandler (Type=typeof(Atk.Hyperlink), ConnectionMethod="OverrideLinkState")]
		protected virtual uint OnLinkState ()
		{
			return 0;
		}

		[DllImport("atksharpglue-2", CallingConvention=CallingConvention.Cdecl)]
		static extern void atksharp_hyperlink_override_is_selected_link (IntPtr type, IsSelectedLinkDelegate cb);

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool IsSelectedLinkDelegate (IntPtr raw);

		static IsSelectedLinkDelegate IsSelectedLinkCallback;

		static bool IsSelectedLink_cb (IntPtr raw)
		{
			try {
				Atk.Hyperlink obj = GLib.Object.GetObject (raw, false) as Atk.Hyperlink;
				return obj.OnIsSelectedLink ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}

			return false;
		}

		static void OverrideIsSelectedLink (GLib.GType gtype)
		{
			if (IsSelectedLinkCallback == null)
				IsSelectedLinkCallback = new IsSelectedLinkDelegate (IsSelectedLink_cb);
			atksharp_hyperlink_override_is_selected_link (gtype.Val, IsSelectedLinkCallback);
		}

		[GLib.DefaultSignalHandler (Type=typeof(Atk.Hyperlink), ConnectionMethod="OverrideIsSelectedLink")]
		protected virtual bool OnIsSelectedLink ()
		{
			return false;
		}

		protected void EmitLinkActivated ()
		{
			GLib.Signal.Emit (this, "link_activated");
		}

#endregion
	}

	internal class HyperlinkAttribute : GLib.GTypeTypeAttribute {
		[DllImport ("libatk-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr atk_hyperlink_get_type ();

		private static GLib.GType _gtype = new GLib.GType (atk_hyperlink_get_type ());
		public static GLib.GType GType { get { return _gtype; } }
		public override GLib.GType Type { get { return _gtype; } }

	}
}
