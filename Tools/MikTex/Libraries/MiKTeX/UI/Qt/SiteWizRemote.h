/* SiteWizRemote.h:                                     -*- C++ -*-

   Copyright (C) 2008-2016 Christian Schenk

   This file is part of the MiKTeX UI Library.

   The MiKTeX UI Library is free software; you can redistribute it
   and/or modify it under the terms of the GNU General Public License
   as published by the Free Software Foundation; either version 2, or
   (at your option) any later version.

   The MiKTeX UI Library is distributed in the hope that it will be
   useful, but WITHOUT ANY WARRANTY; without even the implied warranty
   of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
   GNU General Public License for more details.

   You should have received a copy of the GNU General Public License
   along with the MiKTeX UI Library; if not, write to the Free
   Software Foundation, 59 Temple Place - Suite 330, Boston, MA
   02111-1307, USA. */

#if defined(_MSC_VER)
#  pragma once
#endif

#if !defined(A3643CF8B9BF477B8A6ABB24B46841B7)
#define A3643CF8B9BF477B8A6ABB24B46841B7

#include <vector>
#include <miktex/PackageManager/PackageManager>

#include "ui_SiteWizRemote.h"
#include <QThread>

class QSortFilterProxyModel;

class SiteWizRemote : public QWizardPage, private Ui::SiteWizRemote
{
private:
  Q_OBJECT;

public:
  SiteWizRemote(std::shared_ptr<MiKTeX::Packages::PackageManager> pManager);

public:
  virtual void initializePage();

public:
  virtual bool isComplete() const;

public:
  virtual bool validatePage();

public:
  virtual int nextId() const
  {
    return -1;
  }

private slots:
  void FillList();

private:
  void SetItemText(int row, int column, const QString & text);

private:
  class DownloadThread : public QThread
  {
  public:
    DownloadThread(SiteWizRemote * pParent) :
      QThread(pParent)
    {
    }
  public:
    virtual void run();
  public:
    MiKTeX::Core::MiKTeXException threadMiKTeXException;
  public:
    bool error = false;
  };

private:
  DownloadThread * pDownloadThread = nullptr;

private:
  std::shared_ptr<MiKTeX::Packages::PackageManager> pManager;

private:
  std::vector<MiKTeX::Packages::RepositoryInfo> repositories;

private:
  bool firstVisit = true;

private:
  QSortFilterProxyModel * pProxyModel = nullptr;
};

#endif
