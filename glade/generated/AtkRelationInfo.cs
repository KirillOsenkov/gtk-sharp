// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Glade {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	[GLib.GTypeStruct]
	public struct AtkRelationInfo {

		public string Target;
		public string Type;

		public static Glade.AtkRelationInfo Zero = new Glade.AtkRelationInfo ();

		public static Glade.AtkRelationInfo New (IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Glade.AtkRelationInfo.Zero;
			return Marshal.PtrToStructure<Glade.AtkRelationInfo> (raw);
		}

#endregion
	}
}
