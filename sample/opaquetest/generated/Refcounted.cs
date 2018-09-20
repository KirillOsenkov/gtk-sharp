// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtksharp {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GTypeOpaque]
	public class Refcounted : GLib.Opaque {

		[DllImport("libopaque.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtksharp_refcounted_get_serial(IntPtr raw);

		public int Serial {
			get  {
				int raw_ret = gtksharp_refcounted_get_serial(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libopaque.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtksharp_refcounted_get_refcount(IntPtr raw);

		public int Refcount {
			get  {
				int raw_ret = gtksharp_refcounted_get_refcount(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libopaque.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtksharp_refcounted_get_friend(IntPtr raw);

		[DllImport("libopaque.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtksharp_refcounted_set_friend(IntPtr raw, IntPtr friend);

		public Gtksharp.Refcounted Friend {
			get  {
				IntPtr raw_ret = gtksharp_refcounted_get_friend(Handle);
				Gtksharp.Refcounted ret = raw_ret == IntPtr.Zero ? null : (Gtksharp.Refcounted) GLib.Opaque.GetOpaque (raw_ret, typeof (Gtksharp.Refcounted), false);
				return ret;
			}
			set  {
				gtksharp_refcounted_set_friend(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("libopaque.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtksharp_refcounted_check(GtksharpSharp.RefcountedReturnFuncNative func, GtksharpSharp.GCFuncNative gc);

		public static Gtksharp.Refcounted Check(Gtksharp.RefcountedReturnFunc func, Gtksharp.GCFunc gc) {
			GtksharpSharp.RefcountedReturnFuncWrapper func_wrapper = new GtksharpSharp.RefcountedReturnFuncWrapper (func);
			GtksharpSharp.GCFuncWrapper gc_wrapper = new GtksharpSharp.GCFuncWrapper (gc);
			IntPtr raw_ret = gtksharp_refcounted_check(func_wrapper.NativeDelegate, gc_wrapper.NativeDelegate);
			Gtksharp.Refcounted ret = raw_ret == IntPtr.Zero ? null : (Gtksharp.Refcounted) GLib.Opaque.GetOpaque (raw_ret, typeof (Gtksharp.Refcounted), false);
			return ret;
		}

		[DllImport("libopaque.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtksharp_refcounted_check_unref(GtksharpSharp.RefcountedReturnFuncNative func, GtksharpSharp.GCFuncNative gc);

		public static Gtksharp.Refcounted CheckUnref(Gtksharp.RefcountedReturnFunc func, Gtksharp.GCFunc gc) {
			GtksharpSharp.RefcountedReturnFuncWrapper func_wrapper = new GtksharpSharp.RefcountedReturnFuncWrapper (func);
			GtksharpSharp.GCFuncWrapper gc_wrapper = new GtksharpSharp.GCFuncWrapper (gc);
			IntPtr raw_ret = gtksharp_refcounted_check_unref(func_wrapper.NativeDelegate, gc_wrapper.NativeDelegate);
			Gtksharp.Refcounted ret = raw_ret == IntPtr.Zero ? null : (Gtksharp.Refcounted) GLib.Opaque.GetOpaque (raw_ret, typeof (Gtksharp.Refcounted), false);
			return ret;
		}

		[DllImport("libopaque.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtksharp_refcounted_get_last_serial();

		public static int LastSerial { 
			get {
				int raw_ret = gtksharp_refcounted_get_last_serial();
				int ret = raw_ret;
				return ret;
			}
		}

		public Refcounted(IntPtr raw) : base(raw) {}

		[DllImport("libopaque.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtksharp_refcounted_new();

		public Refcounted () 
		{
			Raw = gtksharp_refcounted_new();
		}

		[DllImport("libopaque.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtksharp_refcounted_ref(IntPtr raw);

		protected override void Ref (IntPtr raw)
		{
			if (!Owned) {
				gtksharp_refcounted_ref (raw);
				Owned = true;
			}
		}

		[DllImport("libopaque.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtksharp_refcounted_unref(IntPtr raw);

		protected override void Unref (IntPtr raw)
		{
			if (Owned) {
				gtksharp_refcounted_unref (raw);
				Owned = false;
			}
		}

#endregion
	}
}
