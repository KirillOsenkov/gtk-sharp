// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;

	public delegate void InsertTextHandler(object o, InsertTextArgs args);

	public class InsertTextArgs : GLib.SignalArgs {
		public Gtk.TextIter Pos{
			get {
				return (Gtk.TextIter) Args [0];
			}
		}

		public string Text{
			get {
				return (string) Args [1];
			}
		}

		public int Length{
			get {
				return (int) Args [2];
			}
		}

	}
}
