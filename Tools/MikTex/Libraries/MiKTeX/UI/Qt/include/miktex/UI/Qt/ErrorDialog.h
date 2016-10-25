/* miktex/UI/Qt/ErrorDialog.h:                          -*- C++ -*-

   Copyright (C) 2008-2016 Christian Schenk

   This file is part of MiKTeX UI Library.

   MiKTeX UI Library is free software; you can redistribute it and/or
   modify it under the terms of the GNU General Public License as
   published by the Free Software Foundation; either version 2, or (at
   your option) any later version.

   MiKTeX UI Library is distributed in the hope that it will be
   useful, but WITHOUT ANY WARRANTY; without even the implied warranty
   of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
   GNU General Public License for more details.

   You should have received a copy of the GNU General Public License
   along with MiKTeX UI Library; if not, write to the Free Software
   Foundation, 59 Temple Place - Suite 330, Boston, MA 02111-1307,
   USA. */

#if defined(_MSC_VER)
#  pragma once
#endif

#if !defined(EBA4CBBFF14748B78ED09743FADFD8F9)
#define EBA4CBBFF14748B78ED09743FADFD8F9

#include "Prototypes"

#include <exception>

#include <miktex/Core/Exceptions>

class QWidget;

MIKUI_QT_BEGIN_NAMESPACE;

class MIKTEXNOVTABLE ErrorDialog
{
public:
  static MIKTEXUIQTCEEAPI(int) DoModal(QWidget * pParent, const MiKTeX::Core::MiKTeXException & e);

public:
  static MIKTEXUIQTCEEAPI(int) DoModal(QWidget * pParent, const std::exception & e);
};

MIKUI_QT_END_NAMESPACE;

#endif
