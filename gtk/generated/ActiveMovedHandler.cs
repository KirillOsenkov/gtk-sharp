// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;

	public delegate void ActiveMovedHandler(object o, ActiveMovedArgs args);

	public class ActiveMovedArgs : GLib.SignalArgs {
		public Gtk.ScrollType P0{
			get {
				return (Gtk.ScrollType) Args [0];
			}
		}

	}
}
