// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Pango {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class Units {

		[DllImport("libpango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int pango_units_from_double(double d);

		public static int FromDouble(double d) {
			int raw_ret = pango_units_from_double(d);
			int ret = raw_ret;
			return ret;
		}

		[DllImport("libpango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern double pango_units_to_double(int i);

		public static double ToDouble(int i) {
			double raw_ret = pango_units_to_double(i);
			double ret = raw_ret;
			return ret;
		}

#endregion
#region Customized extensions
#line 1 "Units.custom"
// Pango.Units.custom - Unit customizations.
//
// Author: Mike Kestner <mkestner@novell.com>
//
// Copyright (c) 2005 Novell, Inc.
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

		private Units () {}
		
		[DllImport("pangosharpglue-2", CallingConvention=CallingConvention.Cdecl)]
		static extern int pangosharp_pixels (int units);

		[DllImport("pangosharpglue-2", CallingConvention=CallingConvention.Cdecl)]
		static extern int pangosharp_scale ();

		public static int FromPixels (int pixels)
		{
			return pixels * pangosharp_scale ();
		}

		public static int ToPixels (int units)
		{
			return pangosharp_pixels (units);
		}


#endregion
	}
}
