/* miktex/Core/MemoryMappedFile.h:                      -*- C++ -*-

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

#if !defined(B15AA2CEBAC6439F92AFC9ED642BB435)
#define B15AA2CEBAC6439F92AFC9ED642BB435

#include <miktex/Core/config.h>

#include <cstddef>

#include "PathName.h"

MIKTEX_CORE_BEGIN_NAMESPACE;

/// Instances of this class provide access to memory-mapped files.
class MIKTEXNOVTABLE MemoryMappedFile
{
  /// Destructor.
public:
  virtual MIKTEXTHISCALL ~MemoryMappedFile() = 0;

  /// Maps a file into memory.
  /// @param lpszPath The file to be mapped.
  /// @param readWrite Indicates whether the file should
  /// be open for reading and writing.
  /// @return Returns a pointer to the block of memory.
public:
  virtual void * MIKTEXTHISCALL Open(const char * lpszPath, bool readWrite) = 0;

public:
  void * Open(const PathName & path, bool readWrite)
  {
    return Open(path.Get(), readWrite);
  }

  /// Closes a file mapping.
public:
  virtual void MIKTEXTHISCALL Close() = 0;

  /// Resizes the memory-mapped file.
  /// @param newSize The new size of the memory-mapped file.
  /// @return Returns a pointer to the block of memory.
public:
  virtual void * MIKTEXTHISCALL Resize(std::size_t newSize) = 0;

  /// Gets a pointer to rhe block of memory.
  /// @return Returns a pointer to the block of memory.
public:
  virtual void * MIKTEXTHISCALL GetPtr() const = 0;

public:
  virtual const char * MIKTEXTHISCALL GetName() const = 0;

  /// Gets the size of the memory-mapped file.
  /// @return Returns the size (in bytes).
public:
  virtual std::size_t MIKTEXTHISCALL GetSize() const = 0;

  /// Flushes the memory-mapped file to disk.
public:
  virtual void MIKTEXTHISCALL Flush() = 0;

  /// Creates a new MemoryMappedFile object. The caller is responsible
  /// for deleting the object.
  /// @return Returns the MemoryMappedFile object.
public:
  static MIKTEXCORECEEAPI(MemoryMappedFile *) Create();
};

MIKTEX_CORE_END_NAMESPACE;

#endif
