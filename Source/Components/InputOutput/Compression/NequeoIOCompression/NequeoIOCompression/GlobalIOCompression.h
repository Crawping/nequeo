/* Company :       Nequeo Pty Ltd, http://www.nequeo.com.au/
*  Copyright :     Copyright � Nequeo Pty Ltd 2014 http://www.nequeo.com.au/
*
*  File :          GlobalIOCompression.h
*  Purpose :       GlobalIOCompression class.
*
*/

/*
Permission is hereby granted, free of charge, to any person
obtaining a copy of this software and associated documentation
files (the "Software"), to deal in the Software without
restriction, including without limitation the rights to use,
copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the
Software is furnished to do so, subject to the following
conditions:

The above copyright notice and this permission notice shall be
included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
OTHER DEALINGS IN THE SOFTWARE.
*/

#pragma once

#ifndef _GLOBALIOCOMPRESSION_H
#define _GLOBALIOCOMPRESSION_H

#include "stdafx.h"
#include <windows.h>
#include <compressapi.h>
#include <atlbase.h>
#include <tchar.h>
#include <string>
#include <memory>
#include <vector>
#include <queue>
#include <map>
#include <iterator>
#include <algorithm>
#include <climits>

using namespace std;

const bool T = true;
const bool F = false;
const int UniqueSymbols = 1 << CHAR_BIT;

namespace Nequeo {
	namespace IO
	{
		/// <summary>
		/// Vector char buffer wrapper.
		/// </summary>
		template<typename CharT, typename TraitsT = std::char_traits<CharT>>
		class VectorBuffer : public std::basic_streambuf<CharT, TraitsT>
		{
		public:
			/// <summary>
			/// Constructor for the current class.
			/// </summary>
			VectorBuffer(std::vector<CharT> &vec)
			{
				this->setg(vec.data(), vec.data(), vec.data() + vec.size());
			}
		};
	}
}
#endif