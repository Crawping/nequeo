/* winRegistry.h: Windows registry operations           -*- C++ -*-

   Copyright (C) 1996-2016 Christian Schenk

   This file is part of the MiKTeX Core Library.

   The MiKTeX Core Library is free software; you can redistribute it
   and/or modify it under the terms of the GNU General Public License
   as published by the Free Software Foundation; either version 2, or
   (at your option) any later version.

   The MiKTeX Core Library is distributed in the hope that it will be
   useful, but WITHOUT ANY WARRANTY; without even the implied warranty
   of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
   GNU General Public License for more details.

   You should have received a copy of the GNU General Public License
   along with the MiKTeX Core Library; if not, write to the Free
   Software Foundation, 59 Temple Place - Suite 330, Boston, MA
   02111-1307, USA. */

#if defined(_MSC_VER)
#  pragma once
#endif

#if !defined(DC954E57C2A944218F4555DB45B27527)
#define DC954E57C2A944218F4555DB45B27527

#include "miktex/Core/TriState.h"

BEGIN_INTERNAL_NAMESPACE;

class winRegistry
{
public:
  static bool TryGetRegistryValue(HKEY hkeyParent, const std::wstring & path, const std::wstring & valueName, std::vector<BYTE> & value, DWORD & valueType);

public:
  static bool TryGetRegistryValue(HKEY hkeyParent, const std::wstring & path, const std::wstring & valueName, std::wstring & value, DWORD & valueType);

public:
  static bool TryGetRegistryValue(HKEY hkeyParent, const std::wstring & path, const std::wstring & valueName, std::wstring & value);

public:
  static bool TryGetRegistryValue(HKEY hkeyParent, const std::string & path, const std::string & valueName, std::string & value);

public:
  static bool TryDeleteRegistryValue(HKEY hkeyParent, const std::wstring & path, const std::wstring & valueName);

public:
  static bool TryDeleteRegistryValue(HKEY hkeyParent, const std::string & path, const std::string & valueName);

public:
  static bool TryDeleteRegistryKey(HKEY hkeyParent, const std::wstring & path);

public:
  static bool TryDeleteRegistryKey(HKEY hkeyParent, const std::string & path);

public:
  static void SetRegistryValue(HKEY hkeyParent, const std::wstring & path, const std::wstring & valueName, const BYTE * value, size_t valueSize, DWORD valueType);

public:
  static void SetRegistryValue(HKEY hkeyParent, const std::wstring & path, const std::wstring & valueName, const std::wstring & value, DWORD valueType);

public:
  static void SetRegistryValue(HKEY hkeyParent, const std::wstring & path, const std::wstring & valueName, const std::wstring & value)
  {
    SetRegistryValue(hkeyParent, path, valueName, value, REG_SZ);
  }

public:
  static void SetRegistryValue(HKEY hkeyParent, const std::string & path, const std::string & valueName, const std::string & value);

public:
  static bool TryGetRegistryValue(MiKTeX::Core::TriState shared, const std::wstring & keyName, const std::wstring & valueName, std::wstring & value);

public:
  static bool TryGetRegistryValue(MiKTeX::Core::TriState shared, const std::string & keyName, const std::string & valueName, std::string & value);

public:
  static bool TryGetRegistryValue(MiKTeX::Core::TriState shared, const std::wstring & keyName, const std::wstring & valueName, MiKTeX::Core::PathName & path);

public:
  static bool TryGetRegistryValue(MiKTeX::Core::TriState shared, const std::string & keyName, const std::string & valueName, MiKTeX::Core::PathName & path);

public:
  static bool TryDeleteRegistryValue(MiKTeX::Core::TriState shared, const std::wstring & keyName, const std::wstring & valueName);

public:
  static bool TryDeleteRegistryValue(MiKTeX::Core::TriState shared, const std::string & keyName, const std::string & valueName);

public:
  static void SetRegistryValue(MiKTeX::Core::TriState shared, const std::wstring & keyName, const std::wstring & valueName, const std::wstring & value);

public:
  static void SetRegistryValue(MiKTeX::Core::TriState shared, const std::string & keyName, const std::string & valueName, const std::string & value);
};

END_INTERNAL_NAMESPACE;

#endif
