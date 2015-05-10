/* Company :       Nequeo Pty Ltd, http://www.nequeo.com.au/
*  Copyright :     Copyright � Nequeo Pty Ltd 2014 http://www.nequeo.com.au/
*
*  File :          BinaryWriter.cpp
*  Purpose :       BinaryWriter class.
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

#include "stdafx.h"

#include "BinaryWriter.h"
#include "Base\ByteOrder.h"
#include "IO\Text\TextEncoding.h"
#include "IO\Text\TextConverter.h"
#include <cstring>

namespace Nequeo {
	namespace IO
	{
		BinaryWriter::BinaryWriter(std::ostream& ostr, StreamByteOrder byteOrder) :
			_ostr(ostr),
			_pTextConverter(0)
		{
#if defined(NEQUEO_ARCH_BIG_ENDIAN)
			_flipBytes = (byteOrder == LITTLE_ENDIAN_BYTE_ORDER);
#else
			_flipBytes = (byteOrder == BIG_ENDIAN_BYTE_ORDER);
#endif
		}


		BinaryWriter::BinaryWriter(std::ostream& ostr, Nequeo::IO::Text::TextEncoding& encoding, StreamByteOrder byteOrder) :
			_ostr(ostr),
			_pTextConverter(new Nequeo::IO::Text::TextConverter(Nequeo::IO::Text::TextEncoding::global(), encoding))
		{
#if defined(NEQUEO_ARCH_BIG_ENDIAN)
			_flipBytes = (byteOrder == LITTLE_ENDIAN_BYTE_ORDER);
#else
			_flipBytes = (byteOrder == BIG_ENDIAN_BYTE_ORDER);
#endif
		}


		BinaryWriter::~BinaryWriter()
		{
			delete _pTextConverter;
		}


		BinaryWriter& BinaryWriter::operator << (bool value)
		{
			_ostr.write((const char*)&value, sizeof(value));
			return *this;
		}


		BinaryWriter& BinaryWriter::operator << (char value)
		{
			_ostr.write((const char*)&value, sizeof(value));
			return *this;
		}


		BinaryWriter& BinaryWriter::operator << (unsigned char value)
		{
			_ostr.write((const char*)&value, sizeof(value));
			return *this;
		}


		BinaryWriter& BinaryWriter::operator << (signed char value)
		{
			_ostr.write((const char*)&value, sizeof(value));
			return *this;
		}


		BinaryWriter& BinaryWriter::operator << (short value)
		{
			if (_flipBytes)
			{
				short fValue = ByteOrder::flipBytes(value);
				_ostr.write((const char*)&fValue, sizeof(fValue));
			}
			else
			{
				_ostr.write((const char*)&value, sizeof(value));
			}
			return *this;
		}


		BinaryWriter& BinaryWriter::operator << (unsigned short value)
		{
			if (_flipBytes)
			{
				unsigned short fValue = ByteOrder::flipBytes(value);
				_ostr.write((const char*)&fValue, sizeof(fValue));
			}
			else
			{
				_ostr.write((const char*)&value, sizeof(value));
			}
			return *this;
		}


		BinaryWriter& BinaryWriter::operator << (int value)
		{
			if (_flipBytes)
			{
				int fValue = ByteOrder::flipBytes(value);
				_ostr.write((const char*)&fValue, sizeof(fValue));
			}
			else
			{
				_ostr.write((const char*)&value, sizeof(value));
			}
			return *this;
		}


		BinaryWriter& BinaryWriter::operator << (unsigned int value)
		{
			if (_flipBytes)
			{
				unsigned int fValue = ByteOrder::flipBytes(value);
				_ostr.write((const char*)&fValue, sizeof(fValue));
			}
			else
			{
				_ostr.write((const char*)&value, sizeof(value));
			}
			return *this;
		}


		BinaryWriter& BinaryWriter::operator << (long value)
		{
			if (_flipBytes)
			{
#if defined(NEQUEO_LONG_IS_64_BIT)
				long fValue = ByteOrder::flipBytes((Int64) value);
#else
				long fValue = ByteOrder::flipBytes((Int32)value);
#endif
				_ostr.write((const char*)&fValue, sizeof(fValue));
			}
			else
			{
				_ostr.write((const char*)&value, sizeof(value));
			}
			return *this;
		}


		BinaryWriter& BinaryWriter::operator << (unsigned long value)
		{
			if (_flipBytes)
			{
#if defined(NEQUEO_LONG_IS_64_BIT)
				long fValue = ByteOrder::flipBytes((UInt64) value);
#else
				long fValue = ByteOrder::flipBytes((UInt32)value);
#endif
				_ostr.write((const char*)&fValue, sizeof(fValue));
			}
			else
			{
				_ostr.write((const char*)&value, sizeof(value));
			}
			return *this;
		}


		BinaryWriter& BinaryWriter::operator << (float value)
		{
			if (_flipBytes)
			{
				const char* ptr = (const char*)&value;
				ptr += sizeof(value);
				for (unsigned i = 0; i < sizeof(value); ++i)
					_ostr.write(--ptr, 1);
			}
			else
			{
				_ostr.write((const char*)&value, sizeof(value));
			}
			return *this;
		}


		BinaryWriter& BinaryWriter::operator << (double value)
		{
			if (_flipBytes)
			{
				const char* ptr = (const char*)&value;
				ptr += sizeof(value);
				for (unsigned i = 0; i < sizeof(value); ++i)
					_ostr.write(--ptr, 1);
			}
			else
			{
				_ostr.write((const char*)&value, sizeof(value));
			}
			return *this;
		}


#if defined(NEQUEO_HAVE_INT64) && !defined(NEQUEO_LONG_IS_64_BIT)


		BinaryWriter& BinaryWriter::operator << (Int64 value)
		{
			if (_flipBytes)
			{
				Int64 fValue = ByteOrder::flipBytes(value);
				_ostr.write((const char*) &fValue, sizeof(fValue));
			}
			else
			{
				_ostr.write((const char*) &value, sizeof(value));
			}
			return *this;
		}


		BinaryWriter& BinaryWriter::operator << (UInt64 value)
		{
			if (_flipBytes)
			{
				UInt64 fValue = ByteOrder::flipBytes(value);
				_ostr.write((const char*) &fValue, sizeof(fValue));
			}
			else
			{
				_ostr.write((const char*) &value, sizeof(value));
			}
			return *this;
		}


#endif


		BinaryWriter& BinaryWriter::operator << (const std::string& value)
		{
			if (_pTextConverter)
			{
				std::string converted;
				_pTextConverter->convert(value, converted);
				UInt32 length = (UInt32)converted.size();
				write7BitEncoded(length);
				_ostr.write(converted.data(), length);
			}
			else
			{
				UInt32 length = (UInt32)value.size();
				write7BitEncoded(length);
				_ostr.write(value.data(), length);
			}
			return *this;
		}


		BinaryWriter& BinaryWriter::operator << (const char* value)
		{
			if (_pTextConverter)
			{
				std::string converted;
				_pTextConverter->convert(value, static_cast<int>(std::strlen(value)), converted);
				UInt32 length = (UInt32)converted.size();
				write7BitEncoded(length);
				_ostr.write(converted.data(), length);
			}
			else
			{
				UInt32 length = static_cast<UInt32>(std::strlen(value));
				write7BitEncoded(length);
				_ostr.write(value, length);
			}
			return *this;
		}


		void BinaryWriter::write7BitEncoded(UInt32 value)
		{
			do
			{
				unsigned char c = (unsigned char)(value & 0x7F);
				value >>= 7;
				if (value) c |= 0x80;
				_ostr.write((const char*)&c, 1);
			} while (value);
		}


#if defined(NEQUEO_HAVE_INT64)


		void BinaryWriter::write7BitEncoded(UInt64 value)
		{
			do
			{
				unsigned char c = (unsigned char) (value & 0x7F);
				value >>= 7;
				if (value) c |= 0x80;
				_ostr.write((const char*) &c, 1);
			}
			while (value);
		}


#endif


		void BinaryWriter::writeRaw(const std::string& rawData)
		{
			_ostr.write(rawData.data(), (std::streamsize) rawData.length());
		}


		void BinaryWriter::writeRaw(const char* buffer, std::streamsize length)
		{
			_ostr.write(buffer, length);
		}


		void BinaryWriter::writeBOM()
		{
			UInt16 value = 0xFEFF;
			if (_flipBytes) value = ByteOrder::flipBytes(value);
			_ostr.write((const char*)&value, sizeof(value));
		}


		void BinaryWriter::flush()
		{
			_ostr.flush();
		}
	}
}