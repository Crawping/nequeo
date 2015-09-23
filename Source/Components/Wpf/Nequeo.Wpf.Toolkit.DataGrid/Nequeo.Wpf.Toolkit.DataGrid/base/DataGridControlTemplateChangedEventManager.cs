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
using System.Windows;

namespace Nequeo.Wpf.DataGrid
{
  internal class DataGridControlTemplateChangedEventManager : WeakEventManager
  {
    private DataGridControlTemplateChangedEventManager()
    {
    }

    public static void AddListener( object source, IWeakEventListener listener )
    {
      CurrentManager.ProtectedAddListener( source, listener );
    }

    public static void RemoveListener( object source, IWeakEventListener listener )
    {
      CurrentManager.ProtectedRemoveListener( source, listener );
    }

    protected override void StartListening( object source )
    {
      DataGridControl dataGridControl = source as DataGridControl;
      if( dataGridControl != null )
      {
        dataGridControl.TemplateApplied += new EventHandler( this.OnTemplateApplied );
        return;
      }

      throw new ArgumentException( "The specified source must be a DataGridControl.", "source" );
    }

    protected override void StopListening( object source )
    {
      DataGridControl dataGridControl = source as DataGridControl;
      if( dataGridControl != null )
      {
        dataGridControl.TemplateApplied -= new EventHandler( this.OnTemplateApplied );
        return;
      }

      throw new ArgumentException( "The specified source must be a DataGridControl.", "source" );
    }

    private static DataGridControlTemplateChangedEventManager CurrentManager
    {
      get
      {
        Type managerType = typeof( DataGridControlTemplateChangedEventManager );
        DataGridControlTemplateChangedEventManager currentManager = ( DataGridControlTemplateChangedEventManager )WeakEventManager.GetCurrentManager( managerType );

        if( currentManager == null )
        {
          currentManager = new DataGridControlTemplateChangedEventManager();
          WeakEventManager.SetCurrentManager( managerType, currentManager );
        }

        return currentManager;
      }
    }

    private void OnTemplateApplied( object sender, EventArgs args )
    {
      this.DeliverEvent( sender, args );
    }
  }
}
