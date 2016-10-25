/* miktex/Util/Tokenizer.h:                             -*- C++ -*-

   Copyright (C) 1996-2016 Christian Schenk

   This file is part of the MiKTeX Util Library.

   The MiKTeX Util Library is free software; you can redistribute it
   and/or modify it under the terms of the GNU General Public License
   as published by the Free Software Foundation; either version 2, or
   (at your option) any later version.

   The MiKTeX Util Library is distributed in the hope that it will be
   useful, but WITHOUT ANY WARRANTY; without even the implied warranty
   of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
   GNU General Public License for more details.

   You should have received a copy of the GNU General Public License
   along with the MiKTeX Util Library; if not, write to the Free
   Software Foundation, 59 Temple Place - Suite 330, Boston, MA
   02111-1307, USA. */

#if defined(_MSC_VER)
#  pragma once
#endif

#if !defined(B8F781CD4C5C48639A1A9A90A45F9855)
#define B8F781CD4C5C48639A1A9A90A45F9855

#include "config.h"

#include "CharBuffer.h"

MIKTEX_UTIL_BEGIN_NAMESPACE;

class Tokenizer : protected CharBuffer<char, 512>
{
protected:
  typedef CharBuffer<char, 512> Base;

public:
  MIKTEXUTILEXPORT MIKTEXTHISCALL Tokenizer(const char * lpsz, const char * lpszDelim);

public:
  MIKTEXUTILTHISAPI(void) SetDelim(const char * lpszDelim);

public:
  const char * GetCurrent() const
  {
    return lpszCurrent == nullptr || *lpszCurrent == 0 ? nullptr : lpszCurrent;
  }

public:
  MIKTEXUTILTHISAPI(const char *) operator++ ();

public:
  virtual MIKTEXUTILEXPORT MIKTEXTHISCALL ~Tokenizer();

public:
  Tokenizer(const Tokenizer & rhs) = delete;

public:
  Tokenizer & operator= (const Tokenizer & rhs) = delete;

private:
  void FindToken();

private:
  const char * lpszCurrent;

private:
  char * lpszNext;

private:
  void * pDelims;
};

MIKTEX_UTIL_END_NAMESPACE;

#endif
