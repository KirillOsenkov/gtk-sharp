// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Glade {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	[GLib.GTypeStruct]
	public struct WidgetInfo {

		private IntPtr _parent;

		public Glade.WidgetInfo parent {
			get { return Glade.WidgetInfo.New (_parent); }
		}
		public string Classname;
		public string Name;
		private IntPtr _properties;

		public Glade.Property properties {
			get { return Glade.Property.New (_properties); }
		}
		public uint NProperties;
		private IntPtr _atk_props;

		public Glade.Property atk_props {
			get { return Glade.Property.New (_atk_props); }
		}
		public uint NAtkProps;
		private IntPtr _signals;

		public Glade.SignalInfo signals {
			get { return Glade.SignalInfo.New (_signals); }
		}
		public uint NSignals;
		private IntPtr _atk_actions;

		public Glade.AtkActionInfo atk_actions {
			get { return Glade.AtkActionInfo.New (_atk_actions); }
		}
		public uint NAtkActions;
		private IntPtr _relations;

		public Glade.AtkRelationInfo relations {
			get { return Glade.AtkRelationInfo.New (_relations); }
		}
		public uint NRelations;
		private IntPtr _accels;

		public Glade.AccelInfo accels {
			get { return Glade.AccelInfo.New (_accels); }
		}
		public uint NAccels;
		private IntPtr _children;

		public Glade.ChildInfo children {
			get { return Glade.ChildInfo.New (_children); }
		}
		public uint NChildren;

		public static Glade.WidgetInfo Zero = new Glade.WidgetInfo ();

		public static Glade.WidgetInfo New (IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Glade.WidgetInfo.Zero;
			return Marshal.PtrToStructure<Glade.WidgetInfo> (raw);
		}

#endregion
	}
}
