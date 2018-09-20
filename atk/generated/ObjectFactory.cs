// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Atk {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[ObjectFactory]
	public class ObjectFactory : GLib.Object {

		[Obsolete]
		protected ObjectFactory(GLib.GType gtype) : base(gtype) {}
		public ObjectFactory(IntPtr raw) : base(raw) {}

		protected ObjectFactory() : base(IntPtr.Zero)
		{
			CreateNativeObject (Array.Empty<IntPtr> (), Array.Empty<GLib.Value> (), 0);
		}

		[DllImport("libatk-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr atk_object_factory_create_accessible(IntPtr raw, IntPtr obj);

		public Atk.Object CreateAccessible(GLib.Object obj) {
			IntPtr raw_ret = atk_object_factory_create_accessible(Handle, obj == null ? IntPtr.Zero : obj.Handle);
			Atk.Object ret = GLib.Object.GetObject(raw_ret, true) as Atk.Object;
			return ret;
		}

		[DllImport("libatk-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr atk_object_factory_get_accessible_type(IntPtr raw);

		public GLib.GType AccessibleType { 
			get {
				IntPtr raw_ret = atk_object_factory_get_accessible_type(Handle);
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libatk-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr atk_object_factory_get_type();

		static GLib.GType _gtype = new GLib.GType (atk_object_factory_get_type());
		public static new GLib.GType GType { 
			get {
								return _gtype;
			}
		}

		[DllImport("libatk-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void atk_object_factory_invalidate(IntPtr raw);

		public void Invalidate() {
			atk_object_factory_invalidate(Handle);
		}

#endregion
#region Customized extensions
#line 1 "ObjectFactory.custom"
// ObjectFactory.custom - Atk ObjectFactory class customizations
//
// Authors: Mike Gorse <mgorse@novell.com>
//          Mike Kestner <mkestner@novell.com>
//
// Copyright (c) 2008-2009 Novell, Inc.
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

		static Hashtable instances = new Hashtable ();

		protected override IntPtr Raw {
			get { return base.Raw; }
			set {
				base.Raw = value;
				if (value != IntPtr.Zero)
					instances [LookupGType (GetType ())] = this;
			}
		}

		static Hashtable marshalers = new Hashtable ();

		static Marshaler GetMarshaler (GLib.GType gtype)
		{
			Marshaler marshaler = marshalers [gtype] as Marshaler;
			if (marshaler == null) {
				marshaler = new Marshaler (gtype);
				marshalers [gtype] = marshaler;
			}
			return marshaler;
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr CreateAccessibleDelegate (IntPtr raw);

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void InvalidateDelegate (IntPtr raw);

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr GetAccessibleTypeDelegate (IntPtr raw);

		class Marshaler {

			GLib.GType gtype;
			CreateAccessibleDelegate create_cb;
			InvalidateDelegate invalidate_cb;
			GetAccessibleTypeDelegate gettype_cb;

			public Marshaler (GLib.GType gtype)
			{
				this.gtype = gtype;
			}

			IntPtr CreateAccessible_cb (IntPtr raw)
			{
				try {
					Atk.ObjectFactory obj = instances [gtype] as Atk.ObjectFactory;
					if (obj == null)
						return IntPtr.Zero;
					Atk.Object ret = obj.OnCreateAccessible (GLib.Object.GetObject (raw, false));
					return ret == null ? IntPtr.Zero : ret.Handle;
				} catch (Exception e) {
					GLib.ExceptionManager.RaiseUnhandledException (e, false);
				}

				return IntPtr.Zero;
			}

			void Invalidate_cb (IntPtr raw)
			{
				try {
					Atk.ObjectFactory obj = GLib.Object.GetObject (raw, false) as Atk.ObjectFactory;
					obj.OnInvalidate ();
					instances.Remove (gtype);
					marshalers.Remove (gtype);
				} catch (Exception e) {
					GLib.ExceptionManager.RaiseUnhandledException (e, false);
				}
			}

			IntPtr GetAccessibleType_cb (IntPtr raw)
			{
				try {
					Atk.ObjectFactory obj = instances [gtype] as Atk.ObjectFactory;
					if (obj == null)
						return GLib.GType.Invalid.Val;
					return obj.OnGetAccessibleType ().Val;
				} catch (Exception e) {
					GLib.ExceptionManager.RaiseUnhandledException (e, false);
				}

				return GLib.GType.Invalid.Val;
			}

			[DllImport("atksharpglue-2", CallingConvention=CallingConvention.Cdecl)]
			static extern void atksharp_object_factory_override_create_accessible (IntPtr type, CreateAccessibleDelegate cb);

			public void ConnectCreateAccessible ()
			{
				create_cb = new CreateAccessibleDelegate (CreateAccessible_cb);
				atksharp_object_factory_override_create_accessible (gtype.Val, create_cb);
			}

			[DllImport("atksharpglue-2", CallingConvention=CallingConvention.Cdecl)]
			static extern void atksharp_object_factory_override_invalidate (IntPtr type, InvalidateDelegate cb);

			public void ConnectInvalidate ()
			{
				invalidate_cb = new InvalidateDelegate (Invalidate_cb);
				atksharp_object_factory_override_invalidate (gtype.Val, invalidate_cb);
			}

			[DllImport("atksharpglue-2", CallingConvention=CallingConvention.Cdecl)]
			static extern void atksharp_object_factory_override_get_accessible_type (IntPtr type, GetAccessibleTypeDelegate cb);

			public void ConnectGetAccessibleType ()
			{
				gettype_cb = new GetAccessibleTypeDelegate (GetAccessibleType_cb);
				atksharp_object_factory_override_get_accessible_type (gtype.Val, gettype_cb);
			}
		}

		static void OverrideCreateAccessible (GLib.GType gtype)
		{
			GetMarshaler (gtype).ConnectCreateAccessible ();
		}

		[DllImport("atksharpglue-2", CallingConvention=CallingConvention.Cdecl)]
		static extern IntPtr atksharp_object_factory_base_create_accessible (IntPtr raw, IntPtr obj);

		[GLib.DefaultSignalHandler (Type=typeof(Atk.ObjectFactory), ConnectionMethod="OverrideCreateAccessible")]
		protected virtual Atk.Object OnCreateAccessible (GLib.Object obj)
		{
			var raw = atksharp_object_factory_base_create_accessible (Handle, obj.Handle);
			return GLib.Object.GetObject (raw, true) as Atk.Object;
		}

		static void OverrideInvalidate (GLib.GType gtype)
		{
			GetMarshaler (gtype).ConnectInvalidate ();
		}

		[DllImport("atksharpglue-2", CallingConvention=CallingConvention.Cdecl)]
		static extern IntPtr atksharp_object_factory_base_invalidate (IntPtr raw);

		[GLib.DefaultSignalHandler (Type=typeof(Atk.ObjectFactory), ConnectionMethod="OverrideInvalidate")]
		protected virtual void OnInvalidate ()
		{
			atksharp_object_factory_base_invalidate (Handle);
		}

		static void OverrideGetAccessibleType (GLib.GType gtype)
		{
			GetMarshaler (gtype).ConnectGetAccessibleType ();
		}

		[DllImport("atksharpglue-2", CallingConvention=CallingConvention.Cdecl)]
		static extern IntPtr atksharp_object_factory_base_get_accessible_type (IntPtr raw);

		[GLib.DefaultSignalHandler (Type=typeof(Atk.ObjectFactory), ConnectionMethod="OverrideGetAccessibleType")]
		protected virtual GLib.GType OnGetAccessibleType ()
		{
			return new GLib.GType (atksharp_object_factory_base_get_accessible_type (Handle));
		}

#endregion
	}

	internal class ObjectFactoryAttribute : GLib.GTypeTypeAttribute {
		[DllImport ("libatk-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr atk_object_factory_get_type ();

		private static GLib.GType _gtype = new GLib.GType (atk_object_factory_get_type ());
		public static GLib.GType GType { get { return _gtype; } }
		public override GLib.GType Type { get { return _gtype; } }

	}
}
