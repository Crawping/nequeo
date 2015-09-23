﻿/*************************************************************************************

   Extended WPF Toolkit

   Copyright (C) 2007-2013 Nequeo Software Inc.

   This program is provided to you under the terms of the Microsoft Public
   License (Ms-PL) as published at http://wpftoolkit.codeplex.com/license 

   For more features, controls, and fast professional support,
   pick up the Plus Edition at http://Nequeo.com/wpf_toolkit

   Stay informed: follow @datagrid on Twitter or Like http://facebook.com/datagrids

  ***********************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nequeo.Wpf.Toolkit.Core;

namespace Nequeo.Wpf.DataGrid
{
  public delegate void DataGridCurrentChangingEventHandler( object sender, DataGridCurrentChangingEventArgs e );

  public class DataGridCurrentChangingEventArgs : CancelRoutedEventArgs
  {
    internal DataGridCurrentChangingEventArgs( DataGridContext oldDataGridContext, object oldCurrent, DataGridContext newDataGridContext, object newCurrent, bool isCancelable )
      : base( DataGridControl.CurrentChangingEvent )
    {
      this.IsCancelable = isCancelable;
      this.OldDataGridContext = oldDataGridContext;
      this.OldCurrent = oldCurrent;
      this.NewDataGridContext = newDataGridContext;
      this.NewCurrent = newCurrent;
    }

    public bool IsCancelable
    {
      get;
      private set;
    }

    public DataGridContext OldDataGridContext
    {
      get;
      private set;
    }

    public object OldCurrent
    {
      get;
      private set;
    }

    public DataGridContext NewDataGridContext
    {
      get;
      private set;
    }

    public object NewCurrent
    {
      get;
      private set;
    }
  }
}
