﻿//=============================================================================
/*
cmk NMS Common
Copyright (C) 2021  Chris Kushnir

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU Affero General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU Affero General Public License for more details.

You should have received a copy of the GNU Affero General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/
//=============================================================================



//=============================================================================

namespace cmk.NMS.PAK.MBIN
{
	public class ExmlDiffer
	: cmk.TextDiffer<ExmlViewer>
	{
		public ExmlDiffer() : base() {}

		public ExmlDiffer( Data LHS, Data RHS )
		: base(LHS?.CreateEXML(), RHS?.CreateEXML())
		{
			MbinLeft  = LHS;
			MbinRight = RHS;
		}

		public readonly NMS.PAK.MBIN.Data MbinLeft  = null;
		public readonly NMS.PAK.MBIN.Data MbinRight = null;
	}

	//=========================================================================

	public class EbinDiffer
	: cmk.TextDiffer<EbinViewer>
	{
		public EbinDiffer() : base() {}

		public EbinDiffer( Data LHS, Data RHS )
		: base(LHS?.CreateEBIN(), RHS?.CreateEBIN())
		{
			MbinLeft  = LHS;
			MbinRight = RHS;
		}

		public readonly NMS.PAK.MBIN.Data MbinLeft  = null;
		public readonly NMS.PAK.MBIN.Data MbinRight = null;
	}
}

//=============================================================================
