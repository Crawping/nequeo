/* miktex/TeXAndFriends/config.h:                       -*- C++ -*-

   Copyright (C) 2009-2016 Christian Schenk

   This file is part of the MiKTeX TeXMF Library.

   The MiKTeX TeXMF Library is free software; you can redistribute it
   and/or modify it under the terms of the GNU General Public License
   as published by the Free Software Foundation; either version 2, or
   (at your option) any later version.
   
   The MiKTeX TeXMF Library is distributed in the hope that it will be
   useful, but WITHOUT ANY WARRANTY; without even the implied warranty
   of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
   GNU General Public License for more details.
   
   You should have received a copy of the GNU General Public License
   along with the MiKTeX TeXMF Library; if not, write to the Free
   Software Foundation, 59 Temple Place - Suite 330, Boston, MA
   02111-1307, USA. */

/* This file was generated from miktex/TeXAndFriends/config.h.cmake. */

#if defined(_MSC_VER)
#  pragma once
#endif

#if !defined(D6EDC25DF28A4C09A02D177CFBE34499)
#define D6EDC25DF28A4C09A02D177CFBE34499

#include <miktex/First>
#include <miktex/Definitions>

// DLL import/export switch
#if !defined(B8C7815676699B4EA2DE96F0BD727276)
#  if defined(MIKTEX_TEXMF_SHARED)
#    define MIKTEXMFEXPORT MIKTEXDLLIMPORT
#  else
#    define MIKTEXMFEXPORT
#  endif
#endif

#define MIKTEXMFAPI_(type, cc) MIKTEXMFEXPORT type cc

// API decoration for exported member functions
#define MIKTEXMFTHISAPI(type) MIKTEXMFEXPORT type MIKTEXTHISCALL

// API decoration for exported functions
#define MIKTEXMFCEEAPI(type) MIKTEXMFEXPORT type MIKTEXCEECALL

// API decoration for exported types
#if defined(__GNUC__)
#  define MIKTEXMFTYPEAPI(type) MIKTEXMFEXPORT type
#else
#  define MIKTEXMFTYPEAPI(type) type
#endif

// API decoration for exported data
#define MIKTEXMFDATA(type) MIKTEXMFEXPORT type

#define MIKTEXMF_BEGIN_NAMESPACE                \
  namespace MiKTeX {                            \
    namespace TeXAndFriends {

#define MIKTEXMF_END_NAMESPACE                  \
    }                                           \
  }

#cmakedefine WITH_PDFTEX 1
#cmakedefine WITH_SYNCTEX 1

#cmakedefine C4P_VAR_NAME_PREFIX ${C4P_VAR_NAME_PREFIX}

#define C4P_VAR(name) ${C4P_VAR_NAME_PREFIX}##name

#endif
