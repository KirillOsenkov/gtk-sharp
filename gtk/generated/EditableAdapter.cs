// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class EditableAdapter : GLib.GInterfaceAdapter, Gtk.Editable {

		static EditableIface iface;

		struct EditableIface {
			public IntPtr gtype;
			public IntPtr itype;

			public IntPtr insert_text;
			public IntPtr delete_text;
			public IntPtr changed;
			public InsertTextDelegate do_insert_text;
			public DeleteTextDelegate do_delete_text;
			public GetCharsDelegate get_chars;
			public SelectRegionDelegate set_selection_bounds;
			public GetSelectionBoundsDelegate get_selection_bounds;
			public SetPositionDelegate set_position;
			public GetPositionDelegate get_position;
		}

		static EditableAdapter ()
		{
			GLib.GType.Register (_gtype, typeof(EditableAdapter));
			iface.do_insert_text = new InsertTextDelegate (InsertTextCallback);
			iface.do_delete_text = new DeleteTextDelegate (DeleteTextCallback);
			iface.get_chars = new GetCharsDelegate (GetCharsCallback);
			iface.set_selection_bounds = new SelectRegionDelegate (SelectRegionCallback);
			iface.get_selection_bounds = new GetSelectionBoundsDelegate (GetSelectionBoundsCallback);
			iface.set_position = new SetPositionDelegate (SetPositionCallback);
			iface.get_position = new GetPositionDelegate (GetPositionCallback);
		}


		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void InsertTextDelegate (IntPtr editable, IntPtr text, int length, ref int position);

		static void InsertTextCallback (IntPtr editable, IntPtr text, int length, ref int position)
		{
			try {
				Gtk.EditableImplementor __obj = GLib.Object.GetObject (editable, false) as Gtk.EditableImplementor;
				__obj.InsertText (GLib.Marshaller.Utf8PtrToString (text), ref position);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void DeleteTextDelegate (IntPtr editable, int start_pos, int end_pos);

		static void DeleteTextCallback (IntPtr editable, int start_pos, int end_pos)
		{
			try {
				Gtk.EditableImplementor __obj = GLib.Object.GetObject (editable, false) as Gtk.EditableImplementor;
				__obj.DeleteText (start_pos, end_pos);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr GetCharsDelegate (IntPtr editable, int start_pos, int end_pos);

		static IntPtr GetCharsCallback (IntPtr editable, int start_pos, int end_pos)
		{
			try {
				Gtk.EditableImplementor __obj = GLib.Object.GetObject (editable, false) as Gtk.EditableImplementor;
				string __result = __obj.GetChars (start_pos, end_pos);
				return GLib.Marshaller.StringToPtrGStrdup(__result);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void SelectRegionDelegate (IntPtr editable, int start_pos, int end_pos);

		static void SelectRegionCallback (IntPtr editable, int start_pos, int end_pos)
		{
			try {
				Gtk.EditableImplementor __obj = GLib.Object.GetObject (editable, false) as Gtk.EditableImplementor;
				__obj.SelectRegion (start_pos, end_pos);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool GetSelectionBoundsDelegate (IntPtr editable, out int start_pos, out int end_pos);

		static bool GetSelectionBoundsCallback (IntPtr editable, out int start_pos, out int end_pos)
		{
			try {
				Gtk.EditableImplementor __obj = GLib.Object.GetObject (editable, false) as Gtk.EditableImplementor;
				bool __result = __obj.GetSelectionBounds (out start_pos, out end_pos);
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void SetPositionDelegate (IntPtr editable, int position);

		static void SetPositionCallback (IntPtr editable, int position)
		{
			try {
				Gtk.EditableImplementor __obj = GLib.Object.GetObject (editable, false) as Gtk.EditableImplementor;
				__obj.Position = position;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate int GetPositionDelegate (IntPtr editable);

		static int GetPositionCallback (IntPtr editable)
		{
			try {
				Gtk.EditableImplementor __obj = GLib.Object.GetObject (editable, false) as Gtk.EditableImplementor;
				int __result = __obj.Position;
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}
		static void Initialize (IntPtr ifaceptr, IntPtr data)
		{
			EditableIface native_iface = Marshal.PtrToStructure<EditableIface> (ifaceptr);
			native_iface.do_insert_text = iface.do_insert_text;
			native_iface.do_delete_text = iface.do_delete_text;
			native_iface.get_chars = iface.get_chars;
			native_iface.set_selection_bounds = iface.set_selection_bounds;
			native_iface.get_selection_bounds = iface.get_selection_bounds;
			native_iface.set_position = iface.set_position;
			native_iface.get_position = iface.get_position;
			Marshal.StructureToPtr<EditableIface> (native_iface, ifaceptr, false);
			GCHandle gch = (GCHandle) data;
			gch.Free ();
		}

		public EditableAdapter ()
		{
			InitHandler = new GLib.GInterfaceInitHandler (Initialize);
		}

		EditableImplementor implementor;

		public EditableAdapter (EditableImplementor implementor)
		{
			if (implementor == null)
				throw new ArgumentNullException ("implementor");
			this.implementor = implementor;
		}

		public EditableAdapter (IntPtr handle)
		{
			this.handle = handle;
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_editable_get_type();

		private static GLib.GType _gtype = new GLib.GType (gtk_editable_get_type ());

		public override GLib.GType GType {
			get {
				return _gtype;
			}
		}

		IntPtr handle;
		public override IntPtr Handle {
			get {
				if (handle != IntPtr.Zero)
					return handle;
				return implementor == null ? IntPtr.Zero : implementor.Handle;
			}
		}

		public static Editable GetObject (IntPtr handle, bool owned)
		{
			GLib.Object obj = GLib.Object.GetObject (handle, owned);
			return GetObject (obj);
		}

		public static Editable GetObject (GLib.Object obj)
		{
			if (obj == null)
				return null;
			else if (obj is EditableImplementor)
				return new EditableAdapter (obj as EditableImplementor);
			else if (obj as Editable == null)
				return new EditableAdapter (obj.Handle);
			else
				return obj as Editable;
		}

		public EditableImplementor Implementor {
			get {
				return implementor;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void TextInsertedSignalDelegate (IntPtr arg0, IntPtr arg1, int arg2, ref int arg3, IntPtr gch);

		static void TextInsertedSignalCallback (IntPtr arg0, IntPtr arg1, int arg2, ref int arg3, IntPtr gch)
		{
			Gtk.TextInsertedArgs args = new Gtk.TextInsertedArgs ();
			try {
				GLib.Signal sig = ((GCHandle) gch).Target as GLib.Signal;
				if (sig == null)
					throw new Exception("Unknown signal GC handle received " + gch);

				args.Args = new object[3];
				args.Args[0] = GLib.Marshaller.Utf8PtrToString (arg1);
				args.Args[1] = arg2;
				args.Args[2] = arg3;
				Gtk.TextInsertedHandler handler = (Gtk.TextInsertedHandler) sig.Handler;
				handler (GLib.Object.GetObject (arg0), args);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}

			try {
				arg3 = ((int)args.Args[2]);
			} catch (Exception) {
				Exception ex = new Exception ("args.RetVal or 'out' property unset or set to incorrect type in Gtk.TextInsertedHandler callback");
				GLib.ExceptionManager.RaiseUnhandledException (ex, true);
				// NOTREACHED: above call doesn't return.
				throw ex;
			}
		}

		[GLib.Signal("insert_text")]
		public event Gtk.TextInsertedHandler TextInserted {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (GLib.Object.GetObject (Handle), "insert_text", new TextInsertedSignalDelegate(TextInsertedSignalCallback));
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (GLib.Object.GetObject (Handle), "insert_text", new TextInsertedSignalDelegate(TextInsertedSignalCallback));
				sig.RemoveDelegate (value);
			}
		}

		[GLib.Signal("delete_text")]
		public event Gtk.TextDeletedHandler TextDeleted {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (GLib.Object.GetObject (Handle), "delete_text", typeof (Gtk.TextDeletedArgs));
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (GLib.Object.GetObject (Handle), "delete_text", typeof (Gtk.TextDeletedArgs));
				sig.RemoveDelegate (value);
			}
		}

		[GLib.Signal("changed")]
		public event System.EventHandler Changed {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (GLib.Object.GetObject (Handle), "changed");
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (GLib.Object.GetObject (Handle), "changed");
				sig.RemoveDelegate (value);
			}
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_editable_copy_clipboard(IntPtr raw);

		public void CopyClipboard() {
			gtk_editable_copy_clipboard(Handle);
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_editable_cut_clipboard(IntPtr raw);

		public void CutClipboard() {
			gtk_editable_cut_clipboard(Handle);
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_editable_delete_selection(IntPtr raw);

		public void DeleteSelection() {
			gtk_editable_delete_selection(Handle);
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_editable_delete_text(IntPtr raw, int start_pos, int end_pos);

		public void DeleteText(int start_pos, int end_pos) {
			Gtk.Application.AssertMainThread();
			gtk_editable_delete_text(Handle, start_pos, end_pos);
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_editable_get_chars(IntPtr raw, int start_pos, int end_pos);

		public string GetChars(int start_pos, int end_pos) {
			Gtk.Application.AssertMainThread();
			IntPtr raw_ret = gtk_editable_get_chars(Handle, start_pos, end_pos);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			return ret;
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_editable_get_editable(IntPtr raw);

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_editable_set_editable(IntPtr raw, bool is_editable);

		public bool IsEditable { 
			get {
				bool raw_ret = gtk_editable_get_editable(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set {
				Gtk.Application.AssertMainThread();
				gtk_editable_set_editable(Handle, value);
			}
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_editable_get_position(IntPtr raw);

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_editable_set_position(IntPtr raw, int position);

		public int Position { 
			get {
				int raw_ret = gtk_editable_get_position(Handle);
				int ret = raw_ret;
				return ret;
			}
			set {
				Gtk.Application.AssertMainThread();
				gtk_editable_set_position(Handle, value);
			}
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_editable_get_selection_bounds(IntPtr raw, out int start, out int end);

		public bool GetSelectionBounds(out int start, out int end) {
			Gtk.Application.AssertMainThread();
			bool raw_ret = gtk_editable_get_selection_bounds(Handle, out start, out end);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_editable_insert_text(IntPtr raw, IntPtr new_text, int new_text_length, ref int position);

		public void InsertText(string new_text, ref int position) {
			Gtk.Application.AssertMainThread();
			IntPtr native_new_text = GLib.Marshaller.StringToPtrGStrdup (new_text);
			gtk_editable_insert_text(Handle, native_new_text, System.Text.Encoding.UTF8.GetByteCount (new_text), ref position);
			GLib.Marshaller.Free (native_new_text);
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_editable_paste_clipboard(IntPtr raw);

		public void PasteClipboard() {
			gtk_editable_paste_clipboard(Handle);
		}

		[DllImport("libgtk-win32-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_editable_select_region(IntPtr raw, int start, int end);

		public void SelectRegion(int start, int end) {
			Gtk.Application.AssertMainThread();
			gtk_editable_select_region(Handle, start, end);
		}

#endregion
	}
}
