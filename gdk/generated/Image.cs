// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[Image]
	public class Image : GLib.Object {

		[Obsolete]
		protected Image(GLib.GType gtype) : base(gtype) {}
		public Image(IntPtr raw) : base(raw) {}

		[DllImport("libgdk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_image_new(int type, IntPtr visual, int width, int height);

		public Image (Gdk.ImageType type, Gdk.Visual visual, int width, int height) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (Image)) {
				throw new InvalidOperationException ("Can't override this constructor.");
			}
			owned = true;
			Raw = gdk_image_new((int) type, visual == null ? IntPtr.Zero : visual.Handle, width, height);
		}

		[DllImport ("gdksharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		extern static uint gdksharp_gdk_image_get_type_offset ();

		static uint type_offset = gdksharp_gdk_image_get_type_offset ();
		public Gdk.ImageType Type {
			get {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + type_offset);
					return (Gdk.ImageType) (*raw_ptr);
				}
			}
		}

		[DllImport ("gdksharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		extern static uint gdksharp_gdk_image_get_visual_offset ();

		static uint visual_offset = gdksharp_gdk_image_get_visual_offset ();
		public Gdk.Visual Visual {
			get {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + visual_offset);
					return GLib.Object.GetObject((*raw_ptr)) as Gdk.Visual;
				}
			}
		}

		[DllImport ("gdksharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		extern static uint gdksharp_gdk_image_get_byte_order_offset ();

		static uint byte_order_offset = gdksharp_gdk_image_get_byte_order_offset ();
		public Gdk.ByteOrder ByteOrder {
			get {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + byte_order_offset);
					return (Gdk.ByteOrder) (*raw_ptr);
				}
			}
		}

		[DllImport ("gdksharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		extern static uint gdksharp_gdk_image_get_width_offset ();

		static uint width_offset = gdksharp_gdk_image_get_width_offset ();
		public int Width {
			get {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + width_offset);
					return (*raw_ptr);
				}
			}
		}

		[DllImport ("gdksharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		extern static uint gdksharp_gdk_image_get_height_offset ();

		static uint height_offset = gdksharp_gdk_image_get_height_offset ();
		public int Height {
			get {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + height_offset);
					return (*raw_ptr);
				}
			}
		}

		[DllImport ("gdksharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		extern static uint gdksharp_gdk_image_get_depth_offset ();

		static uint depth_offset = gdksharp_gdk_image_get_depth_offset ();
		public ushort Depth {
			get {
				unsafe {
					ushort* raw_ptr = (ushort*)(((byte*)Handle) + depth_offset);
					return (*raw_ptr);
				}
			}
		}

		[DllImport ("gdksharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		extern static uint gdksharp_gdk_image_get_bpp_offset ();

		static uint bpp_offset = gdksharp_gdk_image_get_bpp_offset ();
		public ushort Bpp {
			get {
				unsafe {
					ushort* raw_ptr = (ushort*)(((byte*)Handle) + bpp_offset);
					return (*raw_ptr);
				}
			}
		}

		[DllImport ("gdksharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		extern static uint gdksharp_gdk_image_get_bpl_offset ();

		static uint bpl_offset = gdksharp_gdk_image_get_bpl_offset ();
		public ushort Bpl {
			get {
				unsafe {
					ushort* raw_ptr = (ushort*)(((byte*)Handle) + bpl_offset);
					return (*raw_ptr);
				}
			}
		}

		[DllImport ("gdksharpglue-2", CallingConvention = CallingConvention.Cdecl)]
		extern static uint gdksharp_gdk_image_get_bits_per_pixel_offset ();

		static uint bits_per_pixel_offset = gdksharp_gdk_image_get_bits_per_pixel_offset ();
		public ushort BitsPerPixel {
			get {
				unsafe {
					ushort* raw_ptr = (ushort*)(((byte*)Handle) + bits_per_pixel_offset);
					return (*raw_ptr);
				}
			}
		}

		[DllImport("libgdk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_image_get_colormap(IntPtr raw);

		[DllImport("libgdk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gdk_image_set_colormap(IntPtr raw, IntPtr colormap);

		public Gdk.Colormap Colormap {
			get  {
				IntPtr raw_ret = gdk_image_get_colormap(Handle);
				Gdk.Colormap ret = GLib.Object.GetObject(raw_ret) as Gdk.Colormap;
				return ret;
			}
			set  {
				gdk_image_set_colormap(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("libgdk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_image_get(IntPtr drawable, int x, int y, int width, int height);

		[Obsolete]
		public static Gdk.Image Get(Gdk.Drawable drawable, int x, int y, int width, int height) {
			IntPtr raw_ret = gdk_image_get(drawable == null ? IntPtr.Zero : drawable.Handle, x, y, width, height);
			Gdk.Image ret = GLib.Object.GetObject(raw_ret) as Gdk.Image;
			return ret;
		}

		[DllImport("libgdk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern uint gdk_image_get_pixel(IntPtr raw, int x, int y);

		public uint GetPixel(int x, int y) {
			uint raw_ret = gdk_image_get_pixel(Handle, x, y);
			uint ret = raw_ret;
			return ret;
		}

		[DllImport("libgdk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_image_get_type();

		static GLib.GType _gtype = new GLib.GType (gdk_image_get_type());
		public static new GLib.GType GType { 
			get {
								return _gtype;
			}
		}

		[DllImport("libgdk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gdk_image_put_pixel(IntPtr raw, int x, int y, uint pixel);

		public void PutPixel(int x, int y, uint pixel) {
			gdk_image_put_pixel(Handle, x, y, pixel);
		}

		[DllImport("libgdk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_image_ref(IntPtr raw);

		[Obsolete]
		public Gdk.Image Ref() {
			IntPtr raw_ret = gdk_image_ref(Handle);
			Gdk.Image ret = GLib.Object.GetObject(raw_ret) as Gdk.Image;
			return ret;
		}

		[DllImport("libgdk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gdk_image_unref(IntPtr raw);

		[Obsolete]
		public void Unref() {
			gdk_image_unref(Handle);
		}

#endregion
	}

	internal class ImageAttribute : GLib.GTypeTypeAttribute {
		[DllImport ("libgdk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_image_get_type ();

		private static GLib.GType _gtype = new GLib.GType (gdk_image_get_type ());
		public static GLib.GType GType { get { return _gtype; } }
		public override GLib.GType Type { get { return _gtype; } }

	}
}
