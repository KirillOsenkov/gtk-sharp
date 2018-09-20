// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[Button]
	public class Button : Gtk.Bin {

		[Obsolete]
		protected Button(GLib.GType gtype) : base(gtype) {}
		public Button(IntPtr raw) : base(raw) {}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_button_new();

		public Button () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (Button)) {
				Gtk.Application.AssertMainThread();
				CreateNativeObject (Array.Empty<IntPtr> (), Array.Empty<GLib.Value> (), 0);
				return;
			}
			owned = true;
			Raw = gtk_button_new();
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_button_new_with_label(IntPtr label);

		public static Button NewWithLabel(string label)
		{
			Gtk.Application.AssertMainThread();
			IntPtr native_label = GLib.Marshaller.StringToPtrGStrdup (label);
			Button result = new Button (gtk_button_new_with_label(native_label));
			GLib.Marshaller.Free (native_label);
			return result;
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_button_new_with_mnemonic(IntPtr label);

		public static Button NewWithMnemonic(string label)
		{
			Gtk.Application.AssertMainThread();
			IntPtr native_label = GLib.Marshaller.StringToPtrGStrdup (label);
			Button result = new Button (gtk_button_new_with_mnemonic(native_label));
			GLib.Marshaller.Free (native_label);
			return result;
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_button_get_label(IntPtr raw);

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_button_set_label(IntPtr raw, IntPtr label);

		[GLib.Property ("label")]
		public string Label {
			get  {
				IntPtr raw_ret = gtk_button_get_label(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set  {
				Gtk.Application.AssertMainThread();
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_button_set_label(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_button_get_use_underline(IntPtr raw);

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_button_set_use_underline(IntPtr raw, bool use_underline);

		[GLib.Property ("use-underline")]
		public bool UseUnderline {
			get  {
				bool raw_ret = gtk_button_get_use_underline(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				Gtk.Application.AssertMainThread();
				gtk_button_set_use_underline(Handle, value);
			}
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_button_get_use_stock(IntPtr raw);

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_button_set_use_stock(IntPtr raw, bool use_stock);

		[GLib.Property ("use-stock")]
		public bool UseStock {
			get  {
				bool raw_ret = gtk_button_get_use_stock(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				Gtk.Application.AssertMainThread();
				gtk_button_set_use_stock(Handle, value);
			}
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_button_get_focus_on_click(IntPtr raw);

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_button_set_focus_on_click(IntPtr raw, bool focus_on_click);

		[GLib.Property ("focus-on-click")]
		public bool FocusOnClick {
			get  {
				bool raw_ret = gtk_button_get_focus_on_click(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				Gtk.Application.AssertMainThread();
				gtk_button_set_focus_on_click(Handle, value);
			}
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_button_get_relief(IntPtr raw);

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_button_set_relief(IntPtr raw, int newstyle);

		[GLib.Property ("relief")]
		public Gtk.ReliefStyle Relief {
			get  {
				int raw_ret = gtk_button_get_relief(Handle);
				Gtk.ReliefStyle ret = (Gtk.ReliefStyle) raw_ret;
				return ret;
			}
			set  {
				Gtk.Application.AssertMainThread();
				gtk_button_set_relief(Handle, (int) value);
			}
		}

		[GLib.Property ("xalign")]
		public float Xalign {
			get {
				using (GLib.Value val = GetProperty ("xalign")) {
					float ret = (float) val;
					return ret;
				}
			}
			set {
				using (GLib.Value val = new GLib.Value(value)) {
					SetProperty("xalign", val);
				}
			}
		}

		[GLib.Property ("yalign")]
		public float Yalign {
			get {
				using (GLib.Value val = GetProperty ("yalign")) {
					float ret = (float) val;
					return ret;
				}
			}
			set {
				using (GLib.Value val = new GLib.Value(value)) {
					SetProperty("yalign", val);
				}
			}
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_button_get_image(IntPtr raw);

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_button_set_image(IntPtr raw, IntPtr image);

		[GLib.Property ("image")]
		public Gtk.Widget Image {
			get  {
				IntPtr raw_ret = gtk_button_get_image(Handle);
				Gtk.Widget ret = GLib.Object.GetObject(raw_ret) as Gtk.Widget;
				return ret;
			}
			set  {
				Gtk.Application.AssertMainThread();
				gtk_button_set_image(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_button_get_image_position(IntPtr raw);

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_button_set_image_position(IntPtr raw, int position);

		[GLib.Property ("image-position")]
		public Gtk.PositionType ImagePosition {
			get  {
				int raw_ret = gtk_button_get_image_position(Handle);
				Gtk.PositionType ret = (Gtk.PositionType) raw_ret;
				return ret;
			}
			set  {
				Gtk.Application.AssertMainThread();
				gtk_button_set_image_position(Handle, (int) value);
			}
		}

		[DllImport ("gtksharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		extern static bool gtksharp_gtk_button_get_in_button (IntPtr raw);
		[DllImport ("gtksharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		extern static void gtksharp_gtk_button_set_in_button (IntPtr raw, bool value);
		public bool InButton {
			get {
				bool result = gtksharp_gtk_button_get_in_button (Handle);
				return result;
			}
			set {
				gtksharp_gtk_button_set_in_button (Handle, value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void PressedVMDelegate (IntPtr button);

		[DllImport ("gtksharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtksharp_button_override_pressed (IntPtr gtype, PressedVMDelegate cb);

		static PressedVMDelegate PressedVMCallback;

		static void pressed_cb (IntPtr button)
		{
			try {
				Button button_managed = GLib.Object.GetObject (button, false) as Button;
				button_managed.OnPressed ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverridePressed (GLib.GType gtype)
		{
			if (PressedVMCallback == null)
				PressedVMCallback = new PressedVMDelegate (pressed_cb);
			gtksharp_button_override_pressed (gtype.Val, PressedVMCallback);
		}

		[DllImport ("gtksharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtksharp_button_base_pressed (IntPtr button);

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.Button), ConnectionMethod="OverridePressed")]
		protected virtual void OnPressed ()
		{
			Gtk.Application.AssertMainThread();
			gtksharp_button_base_pressed (Handle);
		}

		[GLib.Signal("pressed")]
		public event System.EventHandler Pressed {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "pressed");
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "pressed");
				sig.RemoveDelegate (value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ReleasedVMDelegate (IntPtr button);

		[DllImport ("gtksharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtksharp_button_override_released (IntPtr gtype, ReleasedVMDelegate cb);

		static ReleasedVMDelegate ReleasedVMCallback;

		static void released_cb (IntPtr button)
		{
			try {
				Button button_managed = GLib.Object.GetObject (button, false) as Button;
				button_managed.OnReleased ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideReleased (GLib.GType gtype)
		{
			if (ReleasedVMCallback == null)
				ReleasedVMCallback = new ReleasedVMDelegate (released_cb);
			gtksharp_button_override_released (gtype.Val, ReleasedVMCallback);
		}

		[DllImport ("gtksharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtksharp_button_base_released (IntPtr button);

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.Button), ConnectionMethod="OverrideReleased")]
		protected virtual void OnReleased ()
		{
			Gtk.Application.AssertMainThread();
			gtksharp_button_base_released (Handle);
		}

		[GLib.Signal("released")]
		public event System.EventHandler Released {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "released");
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "released");
				sig.RemoveDelegate (value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ClickedVMDelegate (IntPtr button);

		[DllImport ("gtksharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtksharp_button_override_clicked (IntPtr gtype, ClickedVMDelegate cb);

		static ClickedVMDelegate ClickedVMCallback;

		static void clicked_cb (IntPtr button)
		{
			try {
				Button button_managed = GLib.Object.GetObject (button, false) as Button;
				button_managed.OnClicked ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideClicked (GLib.GType gtype)
		{
			if (ClickedVMCallback == null)
				ClickedVMCallback = new ClickedVMDelegate (clicked_cb);
			gtksharp_button_override_clicked (gtype.Val, ClickedVMCallback);
		}

		[DllImport ("gtksharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtksharp_button_base_clicked (IntPtr button);

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.Button), ConnectionMethod="OverrideClicked")]
		protected virtual void OnClicked ()
		{
			Gtk.Application.AssertMainThread();
			gtksharp_button_base_clicked (Handle);
		}

		[GLib.Signal("clicked")]
		public event System.EventHandler Clicked {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "clicked");
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "clicked");
				sig.RemoveDelegate (value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void EnteredVMDelegate (IntPtr button);

		[DllImport ("gtksharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtksharp_button_override_enter (IntPtr gtype, EnteredVMDelegate cb);

		static EnteredVMDelegate EnteredVMCallback;

		static void entered_cb (IntPtr button)
		{
			try {
				Button button_managed = GLib.Object.GetObject (button, false) as Button;
				button_managed.OnEntered ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideEntered (GLib.GType gtype)
		{
			if (EnteredVMCallback == null)
				EnteredVMCallback = new EnteredVMDelegate (entered_cb);
			gtksharp_button_override_enter (gtype.Val, EnteredVMCallback);
		}

		[DllImport ("gtksharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtksharp_button_base_enter (IntPtr button);

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.Button), ConnectionMethod="OverrideEntered")]
		protected virtual void OnEntered ()
		{
			Gtk.Application.AssertMainThread();
			gtksharp_button_base_enter (Handle);
		}

		[GLib.Signal("enter")]
		public event System.EventHandler Entered {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "enter");
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "enter");
				sig.RemoveDelegate (value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void LeftVMDelegate (IntPtr button);

		[DllImport ("gtksharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtksharp_button_override_leave (IntPtr gtype, LeftVMDelegate cb);

		static LeftVMDelegate LeftVMCallback;

		static void left_cb (IntPtr button)
		{
			try {
				Button button_managed = GLib.Object.GetObject (button, false) as Button;
				button_managed.OnLeft ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideLeft (GLib.GType gtype)
		{
			if (LeftVMCallback == null)
				LeftVMCallback = new LeftVMDelegate (left_cb);
			gtksharp_button_override_leave (gtype.Val, LeftVMCallback);
		}

		[DllImport ("gtksharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtksharp_button_base_leave (IntPtr button);

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.Button), ConnectionMethod="OverrideLeft")]
		protected virtual void OnLeft ()
		{
			Gtk.Application.AssertMainThread();
			gtksharp_button_base_leave (Handle);
		}

		[GLib.Signal("leave")]
		public event System.EventHandler Left {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "leave");
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "leave");
				sig.RemoveDelegate (value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ActivatedVMDelegate (IntPtr button);

		[DllImport ("gtksharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtksharp_button_override_activate (IntPtr gtype, ActivatedVMDelegate cb);

		static ActivatedVMDelegate ActivatedVMCallback;

		static void activated_cb (IntPtr button)
		{
			try {
				Button button_managed = GLib.Object.GetObject (button, false) as Button;
				button_managed.OnActivated ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideActivated (GLib.GType gtype)
		{
			if (ActivatedVMCallback == null)
				ActivatedVMCallback = new ActivatedVMDelegate (activated_cb);
			gtksharp_button_override_activate (gtype.Val, ActivatedVMCallback);
		}

		[DllImport ("gtksharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtksharp_button_base_activate (IntPtr button);

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.Button), ConnectionMethod="OverrideActivated")]
		protected virtual void OnActivated ()
		{
			Gtk.Application.AssertMainThread();
			gtksharp_button_base_activate (Handle);
		}

		[GLib.Signal("activate")]
		public event System.EventHandler Activated {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "activate");
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "activate");
				sig.RemoveDelegate (value);
			}
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_button_action_get_type();

		public static GLib.GType ActionGetType() {
			IntPtr raw_ret = gtk_button_action_get_type();
			GLib.GType ret = new GLib.GType(raw_ret);
			return ret;
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_button_clicked(IntPtr raw);

		public void Click() {
			gtk_button_clicked(Handle);
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_button_enter(IntPtr raw);

		public void Enter() {
			gtk_button_enter(Handle);
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_button_get_alignment(IntPtr raw, out float xalign, out float yalign);

		public void GetAlignment(out float xalign, out float yalign) {
			Gtk.Application.AssertMainThread();
			gtk_button_get_alignment(Handle, out xalign, out yalign);
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_button_get_type();

		static GLib.GType _gtype = new GLib.GType (gtk_button_get_type());
		public static new GLib.GType GType { 
			get {
								return _gtype;
			}
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_button_leave(IntPtr raw);

		public void Leave() {
			gtk_button_leave(Handle);
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_button_pressed(IntPtr raw);

		public void Press() {
			gtk_button_pressed(Handle);
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_button_released(IntPtr raw);

		public void Release() {
			gtk_button_released(Handle);
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_button_set_alignment(IntPtr raw, float xalign, float yalign);

		public void SetAlignment(float xalign, float yalign) {
			Gtk.Application.AssertMainThread();
			gtk_button_set_alignment(Handle, xalign, yalign);
		}

#endregion
#region Customized extensions
#line 1 "Button.custom"
// Gtk.Button.custom - Gtk Button class customizations
//
// Author: Mike Kestner <mkestner@ximian.com> 
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


[DllImport("libgtk-win32-2.0-0.dll", CallingConvention=CallingConvention.Cdecl)]
static extern IntPtr gtk_button_new_from_stock(IntPtr stock_id);

public Button (string stock_id) : base (IntPtr.Zero)
{
	if (GetType () != typeof (Button)) {
		unsafe {
			var vals = stackalloc GLib.Value [2];
			var names = stackalloc IntPtr [2];
			names [0] = GLib.Marshaller.StringToPtrGStrdup ("label");
			vals [0] = new GLib.Value (stock_id);
			names [1] = GLib.Marshaller.StringToPtrGStrdup ("use_stock");
			vals [1] = new GLib.Value (true);
			CreateNativeObject (names, vals, 2);
		}
		return;
	}
	owned = true;
	IntPtr native = GLib.Marshaller.StringToPtrGStrdup (stock_id);
	Raw = gtk_button_new_from_stock (native);
	GLib.Marshaller.Free (native);
}

public Button (Widget widget) : this ()
{
	Add (widget);
}

#endregion
	}

	internal class ButtonAttribute : GLib.GTypeTypeAttribute {
		[DllImport ("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_button_get_type ();

		private static GLib.GType _gtype = new GLib.GType (gtk_button_get_type ());
		public static GLib.GType GType { get { return _gtype; } }
		public override GLib.GType Type { get { return _gtype; } }

	}
}
