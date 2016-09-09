﻿//
//  ChannelList64.cs
//
//  Author:
//       Jae Stutzman <jaebird@gmail.com>
//
//  Copyright (c) 2016 Jae Stutzman
//
//  This library is free software; you can redistribute it and/or modify
//  it under the terms of the GNU Lesser General Public License as
//  published by the Free Software Foundation; either version 2.1 of the
//  License, or (at your option) any later version.
//
//  This library is distributed in the hope that it will be useful, but
//  WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU
//  Lesser General Public License for more details.
//
//  You should have received a copy of the GNU Lesser General Public
//  License along with this library; if not, write to the Free Software
//  Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA 02111-1307 USA

using System;
using System.Runtime.InteropServices;

namespace HamLibSharp.x64
{
	[StructLayout (LayoutKind.Sequential)]
	internal struct ChannelList64 : IChannelList
	{
		public int Start { get { return start; } }

		public int End { get { return end; } }

		public RigMemoryChannel Type { get { return type; } }

		public IChannelCapability MemCaps { get { return mem_caps; } }

		// Starting memory channel \b number
		int start;
		// Ending memory channel \b number
		int end;
		// Memory type. see chan_type_t
		RigMemoryChannel type;
		// Definition of attributes that can be stored/retrieved
		ChannelCapability64 mem_caps;
	};

}

